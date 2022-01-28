using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TmbAnalyst.Services.DataAccess;
using TmbAnalyst.Services.DataAccess.Entities;
using TmbAnalyst.Services.DataContracts.Models;
using TmbAnalyst.Services.DataContracts.Requests;
using TmbAnalyst.Services.Engine.Contracts;
using TmbAnalyst.Services.Manager.Contracts;

namespace TmbAnalyst.Services.Manager;

public class VoteManager : IVoteManager
{
    private readonly IVoteEngine _voteEngine;
    private readonly IMapper _mapper;
    private readonly TmbAnalystDbContext _dbContext;
    private readonly IConfigurationProvider _configurationProvider;

    public VoteManager(
        IVoteEngine voteEngine, 
        IMapper mapper, 
        TmbAnalystDbContext dbContext,
        IConfigurationProvider configurationProvider)
    {
        _voteEngine = voteEngine;
        _mapper = mapper;
        _dbContext = dbContext;
        _configurationProvider = configurationProvider;
    }
    public async Task<VoteModel> CreateVote(CreateVoteRequest createVoteRequest)
    {
        var voteEntity = _mapper.Map<CreateVoteRequest, Vote>(createVoteRequest);
        voteEntity.VoteItems = await _voteEngine.CreateVoteItems();
        await _dbContext.Votes.AddAsync(voteEntity);
        await _dbContext.SaveChangesAsync();
        return await _dbContext.Votes
            .Where(x => x.Id == voteEntity.Id)
            .ProjectTo<VoteModel>(_configurationProvider)
            .SingleAsync();
    }

    public async Task<VoteModel> GetCurrentVote()
    {
        return await _dbContext.Votes
            .Where(x => x.ActiveUntil > DateTime.UtcNow)
            .OrderByDescending(x => x.Created)
            .ThenBy(x => x.ActiveUntil)
            .ProjectTo<VoteModel>(_configurationProvider)
            .FirstOrDefaultAsync();
    }

    public async Task<List<VoteItemModel>> GetVoteItems(int voteId)
    {
        return await _dbContext
            .VoteItems
            .Where(x => x.VoteId == voteId)
            .OrderByDescending(x => x.Item.ItemSource.ItemSourceCategoryId)
            .ThenBy(x => x.Item.ItemSourceId)
            .ProjectTo<VoteItemModel>(_configurationProvider)
            .ToListAsync();
    }
}