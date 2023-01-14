using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopMatch",
                columns: table => new
                {
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    Team1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Team1 = table.Column<int>(type: "int", nullable: false),
                    Score1 = table.Column<int>(type: "int", nullable: false),
                    Team2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Team2 = table.Column<int>(type: "int", nullable: false),
                    Score2 = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TopScorersSP",
                columns: table => new
                {
                    TotalScore = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scores_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scores_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Played" },
                    { 2, "Played" },
                    { 3, "Played" },
                    { 4, "Played" },
                    { 5, "Played" },
                    { 6, "Played" },
                    { 7, "Played" },
                    { 8, "Played" },
                    { 9, "Played" },
                    { 10, "Played" },
                    { 11, "Played" },
                    { 12, "Played" },
                    { 13, "Played" },
                    { 14, "Played" },
                    { 15, "Played" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lakers" },
                    { 2, "Bulls" },
                    { 3, "Warriors" },
                    { 4, "Celtics" },
                    { 5, "Nets" },
                    { 6, "Mavericks" }
                });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "Id", "MatchId", "TeamId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 1, 100 },
                    { 2, 1, 2, 90 },
                    { 3, 2, 1, 85 },
                    { 4, 2, 3, 95 },
                    { 5, 3, 1, 80 },
                    { 6, 3, 4, 95 },
                    { 7, 14, 1, 82 },
                    { 8, 14, 5, 93 },
                    { 9, 4, 1, 90 },
                    { 10, 4, 6, 78 },
                    { 11, 5, 2, 99 },
                    { 12, 5, 3, 77 },
                    { 13, 6, 2, 80 },
                    { 14, 6, 4, 95 },
                    { 15, 7, 2, 90 },
                    { 16, 7, 5, 78 },
                    { 17, 8, 2, 95 },
                    { 18, 8, 6, 74 },
                    { 19, 10, 3, 94 },
                    { 20, 10, 5, 73 },
                    { 21, 11, 3, 111 },
                    { 22, 11, 6, 110 },
                    { 23, 12, 4, 86 },
                    { 24, 12, 5, 75 },
                    { 25, 13, 4, 100 },
                    { 26, 13, 6, 78 },
                    { 27, 15, 5, 91 },
                    { 28, 15, 6, 71 },
                    { 29, 9, 3, 88 },
                    { 30, 9, 4, 69 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Scores_MatchId",
                table: "Scores",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_TeamId",
                table: "Scores",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "TopMatch");

            migrationBuilder.DropTable(
                name: "TopScorersSP");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
