using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TmbAnalyst.Services.DataAccess.Migrations
{
    public partial class Votes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ActiveUntil = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoteItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VoteId = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VoteItems_Votes_VoteId",
                        column: x => x.VoteId,
                        principalTable: "Votes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoteItemCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CharacterId = table.Column<int>(type: "integer", nullable: false),
                    VoteItemId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteItemCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteItemCharacters_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VoteItemCharacters_VoteItems_VoteItemId",
                        column: x => x.VoteItemId,
                        principalTable: "VoteItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoteItemUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<decimal>(type: "numeric(20,0)", nullable: false),
                    VoteItemId = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteItemUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteItemUsers_VoteItems_VoteItemId",
                        column: x => x.VoteItemId,
                        principalTable: "VoteItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoteItemUserCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OrderNumber = table.Column<int>(type: "integer", nullable: false),
                    VoteItemUserId = table.Column<int>(type: "integer", nullable: false),
                    CharacterId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteItemUserCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteItemUserCharacters_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VoteItemUserCharacters_VoteItemUsers_VoteItemUserId",
                        column: x => x.VoteItemUserId,
                        principalTable: "VoteItemUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoteItemUserComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    VoteItemUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteItemUserComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoteItemUserComments_VoteItemUsers_VoteItemUserId",
                        column: x => x.VoteItemUserId,
                        principalTable: "VoteItemUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VoteItemCharacters_CharacterId",
                table: "VoteItemCharacters",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteItemCharacters_VoteItemId",
                table: "VoteItemCharacters",
                column: "VoteItemId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteItems_ItemId",
                table: "VoteItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteItems_VoteId",
                table: "VoteItems",
                column: "VoteId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteItemUserCharacters_CharacterId",
                table: "VoteItemUserCharacters",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteItemUserCharacters_VoteItemUserId",
                table: "VoteItemUserCharacters",
                column: "VoteItemUserId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteItemUserComments_VoteItemUserId",
                table: "VoteItemUserComments",
                column: "VoteItemUserId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteItemUsers_VoteItemId",
                table: "VoteItemUsers",
                column: "VoteItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VoteItemCharacters");

            migrationBuilder.DropTable(
                name: "VoteItemUserCharacters");

            migrationBuilder.DropTable(
                name: "VoteItemUserComments");

            migrationBuilder.DropTable(
                name: "VoteItemUsers");

            migrationBuilder.DropTable(
                name: "VoteItems");

            migrationBuilder.DropTable(
                name: "Votes");
        }
    }
}
