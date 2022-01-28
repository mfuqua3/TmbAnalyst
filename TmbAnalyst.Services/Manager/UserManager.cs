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
using TmbAnalyst.Services.Manager.Contracts;
using TmbAnalyst.Services.Utilities;

namespace TmbAnalyst.Services.Manager;

public class UserManager : IUserManager
{
    private readonly TmbAnalystDbContext _dbContext;
    private readonly IConfigurationProvider _configurationProvider;

    public UserManager(TmbAnalystDbContext dbContext, IConfigurationProvider configurationProvider)
    {
        _dbContext = dbContext;
        _configurationProvider = configurationProvider;
    }

    public async Task<bool> IsInRole(ulong userId, string role)
    {
        var roleId = RoleId(role);
        return await _dbContext
            .UserRoles
            .AnyAsync(x => x.UserId == userId && x.RoleId == roleId);
    }

    public async Task AddToRole(ulong userId, string role)
    {
        if (await IsInRole(userId, role))
            return;
        var roleId = RoleId(role);
        await _dbContext.AddAsync(new UserRole
        {
            UserId = userId, RoleId = roleId
        });
        await _dbContext.SaveChangesAsync();
    }

    public async Task RemoveFromRole(ulong userId, string role)
    {
        var roleId = RoleId(role);
        var roleEntity = await _dbContext.UserRoles
            .Where(x => x.UserId == userId && x.RoleId == roleId)
            .SingleOrDefaultAsync();
        if (roleEntity == null)
            return;
        _dbContext.UserRoles.Remove(roleEntity);
        await _dbContext.SaveChangesAsync();
    }

    private int RoleId(string role)
    {
        var roleEnum = Enum.Parse<Enums.Role>(role);
        return (int)roleEnum;
    }
    public async Task<List<RoleModel>> GetUserRoles(ulong userId)
    {
        return await _dbContext.UserRoles
            .Where(x => x.UserId == userId)
            .ProjectTo<RoleModel>(_configurationProvider)
            .ToListAsync();
    }
}