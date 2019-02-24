using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProviderAPI.Migrations
{
    public partial class prefixesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StatePrefixes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrefixValue = table.Column<string>(nullable: false),
                    LangConfigId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatePrefixes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatePrefixes_LangConfigs_LangConfigId",
                        column: x => x.LangConfigId,
                        principalTable: "LangConfigs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatePrefixes_LangConfigId",
                table: "StatePrefixes",
                column: "LangConfigId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatePrefixes");
        }
    }
}
