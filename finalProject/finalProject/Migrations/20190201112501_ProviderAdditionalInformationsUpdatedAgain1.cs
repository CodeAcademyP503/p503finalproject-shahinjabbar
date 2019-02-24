using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProject.Migrations
{
    public partial class ProviderAdditionalInformationsUpdatedAgain1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SecondaryInputValidLength",
                table: "ProviderAdditionalInformations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "InputText",
                table: "ProviderAdditionalInformations",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "FirstInputValidLength",
                table: "ProviderAdditionalInformations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AdditionalInputValidLength",
                table: "ProviderAdditionalInformations",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SecondaryInputValidLength",
                table: "ProviderAdditionalInformations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InputText",
                table: "ProviderAdditionalInformations",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirstInputValidLength",
                table: "ProviderAdditionalInformations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdditionalInputValidLength",
                table: "ProviderAdditionalInformations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
