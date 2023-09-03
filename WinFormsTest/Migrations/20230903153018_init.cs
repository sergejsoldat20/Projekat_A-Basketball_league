using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsTest.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Season = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasketballPlayer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DressNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClubId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    City = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Arena = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    GuestId = table.Column<Guid>(type: "uuid", nullable: false),
                    HomeId = table.Column<Guid>(type: "uuid", nullable: false),
                    GameTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GuestPoints = table.Column<int>(type: "integer", nullable: false),
                    HomePoints = table.Column<int>(type: "integer", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    State = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                    ClubId = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false),
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
