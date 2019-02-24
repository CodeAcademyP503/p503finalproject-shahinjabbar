using Microsoft.EntityFrameworkCore.Migrations;

namespace ProviderAPI.Migrations
{
    public partial class stateAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "Vns");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceType",
                table: "Vns",
                nullable: false,
                defaultValue: "");
        }
    }
}
