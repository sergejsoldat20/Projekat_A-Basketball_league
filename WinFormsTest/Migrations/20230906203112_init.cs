using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WinFormsTest.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Season = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasketballPlayer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DressNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClubId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketballPlayer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketballPlayer_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    City = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Arena = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GuestId = table.Column<int>(type: "integer", nullable: false),
                    HomeId = table.Column<int>(type: "integer", nullable: false),
                    GameTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuestPoints = table.Column<int>(type: "integer", nullable: false),
                    HomePoints = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Club_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Game_Club_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    State = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TableId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League", x => x.Id);
                    table.ForeignKey(
                        name: "FK_League_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TableClub",
                columns: table => new
                {
                    ClubId = table.Column<int>(type: "integer", nullable: false),
                    TableId = table.Column<int>(type: "integer", nullable: false),
                    ClubPoints = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableClub", x => new { x.TableId, x.ClubId });
                    table.ForeignKey(
                        name: "FK_TableClub_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TableClub_Table_TableId",
                        column: x => x.TableId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "Sergej", "Soldat", "admin", "ADMIN", "admin" },
                    { 2, "Sergej", "Soldat", "user", "USER", "user" }
                });

            migrationBuilder.InsertData(
                table: "Club",
                columns: new[] { "Id", "City", "Name" },
                values: new object[,]
                {
                    { 1, "City 1", "Club 1" },
                    { 2, "City 2", "Club 2" }
                });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "Season" },
                values: new object[,]
                {
                    { 1, "2020" },
                    { 2, "2020" }
                });

            migrationBuilder.InsertData(
                table: "BasketballPlayer",
                columns: new[] { "Id", "ClubId", "DressNumber", "Name", "Position" },
                values: new object[,]
                {
                    { 1, 1, "23", "Player 1", "Guard" },
                    { 2, 1, "10", "Player 2", "Forward" },
                    { 3, 2, "7", "Player 3", "Center" },
                    { 4, 2, "15", "Player 4", "Guard" },
                    { 5, 2, "33", "Player 5", "Forward" }
                });

            migrationBuilder.InsertData(
                table: "TableClub",
                columns: new[] { "ClubId", "TableId", "ClubPoints" },
                values: new object[,]
                {
                    { 1, 1, 56 },
                    { 2, 1, 77 },
                    { 1, 2, 55 },
                    { 2, 2, 99 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketballPlayer_ClubId",
                table: "BasketballPlayer",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_GuestId",
                table: "Game",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_HomeId",
                table: "Game",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_League_TableId",
                table: "League",
                column: "TableId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TableClub_ClubId",
                table: "TableClub",
                column: "ClubId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "BasketballPlayer");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "League");

            migrationBuilder.DropTable(
                name: "TableClub");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "Table");
        }
    }
}
