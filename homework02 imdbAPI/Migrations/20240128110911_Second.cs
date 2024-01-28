using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homework02_imdbAPI.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parenttitles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ImageId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {

                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RunningTimeInMinutes = table.Column<int>(type: "int", nullable: false),
                    NextEpisode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfEpisodes = table.Column<int>(type: "int", nullable: false),
                    SeriesEndYear = table.Column<int>(type: "int", nullable: false),
                    SeriesStartYear = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Episode = table.Column<int>(type: "int", nullable: false),
                    Season = table.Column<int>(type: "int", nullable: false),
                    ParentTitleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PreviousEpisode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_Parenttitles_ParentTitleId",
                        column: x => x.ParentTitleId,
                        principalTable: "Parenttitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Principals",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LegacyNameText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Characters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndYear = table.Column<int>(type: "int", nullable: false),
                    EpisodeCount = table.Column<int>(type: "int", nullable: false),
                    StartYear = table.Column<int>(type: "int", nullable: false),
                    Attr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Billing = table.Column<int>(type: "int", nullable: false),
                    Disambiguation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    As = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResultId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Principals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Principals_Results_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Character = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipalId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Roles_Principals_PrincipalId",
                        column: x => x.PrincipalId,
                        principalTable: "Principals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parenttitles_ImageId",
                table: "Parenttitles",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Principals_ResultId",
                table: "Principals",
                column: "ResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ImageId",
                table: "Results",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ParentTitleId",
                table: "Results",
                column: "ParentTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_PrincipalId",
                table: "Roles",
                column: "PrincipalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Principals");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Parenttitles");

            migrationBuilder.DropTable(
                name: "Image1");
        }
    }
}
