using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProject.Migrations
{
    public partial class ButtonTextsAddedToGroupProvider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupProviderPageButtonTexts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    LangId = table.Column<int>(nullable: false),
                    LanguageConfigurationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupProviderPageButtonTexts", x => x.id);
                    table.ForeignKey(
                        name: "FK_GroupProviderPageButtonTexts_LanguageConfigurations_LanguageConfigurationId",
                        column: x => x.LanguageConfigurationId,
                        principalTable: "LanguageConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupProviderPageButtonTexts_LanguageConfigurationId",
                table: "GroupProviderPageButtonTexts",
                column: "LanguageConfigurationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupProviderPageButtonTexts");
        }
    }
}
