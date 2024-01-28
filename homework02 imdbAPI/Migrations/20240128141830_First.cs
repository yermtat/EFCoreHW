using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homework02_imdbAPI.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image1",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parenttitle",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parenttitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parenttitle_Image1_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image1",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImageId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RunningTimeInMinutes = table.Column<int>(type: "int", nullable: false),
                    NextEpisode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfEpisodes = table.Column<int>(type: "int", nullable: true),
                    SeriesEndYear = table.Column<int>(type: "int", nullable: true),
                    SeriesStartYear = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Episode = table.Column<int>(type: "int", nullable: true),
                    Season = table.Column<int>(type: "int", nullable: true),
                    ParentTitleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PreviousEpisode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Results_Parenttitle_ParentTitleId",
                        column: x => x.ParentTitleId,
                        principalTable: "Parenttitle",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Principal",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LegacyNameText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Characters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndYear = table.Column<int>(type: "int", nullable: true),
                    EpisodeCount = table.Column<int>(type: "int", nullable: true),
                    StartYear = table.Column<int>(type: "int", nullable: true),
                    Attr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Billing = table.Column<int>(type: "int", nullable: false),
                    Disambiguation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    As = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResultId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Principal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Principal_Results_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Results",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    CharacterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Character = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipalId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Role_Principal_PrincipalId",
                        column: x => x.PrincipalId,
                        principalTable: "Principal",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parenttitle_ImageId",
                table: "Parenttitle",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Principal_ResultId",
                table: "Principal",
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
                name: "IX_Role_PrincipalId",
                table: "Role",
                column: "PrincipalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Principal");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Parenttitle");

            migrationBuilder.DropTable(
                name: "Image1");
        }
    }
}
