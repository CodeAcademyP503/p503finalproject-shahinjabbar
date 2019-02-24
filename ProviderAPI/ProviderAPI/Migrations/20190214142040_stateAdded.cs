using Microsoft.EntityFrameworkCore.Migrations;

namespace ProviderAPI.Migrations
{
    public partial class stateAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vns_UtilityPrefixes_UtilityPrefixId",
                table: "Vns");

            migrationBuilder.RenameColumn(
                name: "UtilityPrefixId",
                table: "Vns",
                newName: "StatePrefixId");

            migrationBuilder.RenameIndex(
                name: "IX_Vns_UtilityPrefixId",
                table: "Vns",
                newName: "IX_Vns_StatePrefixId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vns_StatePrefixes_StatePrefixId",
                table: "Vns",
                column: "StatePrefixId",
                principalTable: "StatePrefixes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vns_StatePrefixes_StatePrefixId",
                table: "Vns");

            migrationBuilder.RenameColumn(
                name: "StatePrefixId",
                table: "Vns",
                newName: "UtilityPrefixId");

            migrationBuilder.RenameIndex(
                name: "IX_Vns_StatePrefixId",
                table: "Vns",
                newName: "IX_Vns_UtilityPrefixId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vns_UtilityPrefixes_UtilityPrefixId",
                table: "Vns",
                column: "UtilityPrefixId",
                principalTable: "UtilityPrefixes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
