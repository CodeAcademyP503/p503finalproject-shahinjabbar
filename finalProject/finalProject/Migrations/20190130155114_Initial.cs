using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LanguageConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LangName = table.Column<string>(maxLength: 50, nullable: false),
                    PhotoPath = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProviderCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoreProviders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagName = table.Column<string>(maxLength: 50, nullable: false),
                    BackColor = table.Column<string>(maxLength: 50, nullable: false),
                    ImagePath = table.Column<string>(maxLength: 255, nullable: false),
                    Text = table.Column<string>(maxLength: 70, nullable: true),
                    DataId = table.Column<int>(nullable: false),
                    LangId = table.Column<int>(nullable: false),
                    LanguageConfigurationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoreProviders_LanguageConfigurations_LanguageConfigurationId",
                        column: x => x.LanguageConfigurationId,
                        principalTable: "LanguageConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FooterInfos",
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
                    table.PrimaryKey("PK_FooterInfos", x => x.id);
                    table.ForeignKey(
                        name: "FK_FooterInfos_LanguageConfigurations_LanguageConfigurationId",
                        column: x => x.LanguageConfigurationId,
                        principalTable: "LanguageConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndexPhotos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhotoPath = table.Column<string>(maxLength: 500, nullable: false),
                    LangId = table.Column<int>(nullable: false),
                    LanguageConfigurationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndexPhotos", x => x.id);
                    table.ForeignKey(
                        name: "FK_IndexPhotos_LanguageConfigurations_LanguageConfigurationId",
                        column: x => x.LanguageConfigurationId,
                        principalTable: "LanguageConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TopProviders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagName = table.Column<string>(maxLength: 50, nullable: false),
                    BackColor = table.Column<string>(maxLength: 50, nullable: false),
                    ImagePath = table.Column<string>(maxLength: 255, nullable: false),
                    DataId = table.Column<int>(nullable: false),
                    LangId = table.Column<int>(nullable: false),
                    LanguageConfigurationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TopProviders_LanguageConfigurations_LanguageConfigurationId",
                        column: x => x.LanguageConfigurationId,
                        principalTable: "LanguageConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupProviders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TagName = table.Column<string>(maxLength: 50, nullable: false),
                    BackColor = table.Column<string>(maxLength: 50, nullable: false),
                    ImagePath = table.Column<string>(maxLength: 255, nullable: false),
                    HasOptions = table.Column<bool>(nullable: false),
                    HasSecondaryOptions = table.Column<bool>(nullable: false),
                    HasInput = table.Column<bool>(nullable: false),
                    HasSecondaryInput = table.Column<bool>(nullable: false),
                    HasAdditionalInput = table.Column<bool>(nullable: false),
                    CoreProviderId = table.Column<int>(nullable: false),
                    ProviderCategroyId = table.Column<int>(nullable: false),
                    ProviderCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupProviders_CoreProviders_CoreProviderId",
                        column: x => x.CoreProviderId,
                        principalTable: "CoreProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupProviders_ProviderCategories_ProviderCategoryId",
                        column: x => x.ProviderCategoryId,
                        principalTable: "ProviderCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProviderHeaderInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImgPath = table.Column<string>(maxLength: 70, nullable: false),
                    Text = table.Column<string>(maxLength: 70, nullable: false),
                    CoreProviderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderHeaderInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderHeaderInfos_CoreProviders_CoreProviderId",
                        column: x => x.CoreProviderId,
                        principalTable: "CoreProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProviderAdditionalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InputText = table.Column<string>(nullable: false),
                    SecondaryInputText = table.Column<string>(nullable: true),
                    AdditionalInputText = table.Column<string>(nullable: true),
                    FirstInputValidLength = table.Column<int>(nullable: false),
                    SecondaryInputValidLength = table.Column<int>(nullable: false),
                    AdditionalInputValidLength = table.Column<int>(nullable: false),
                    GroupProviderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderAdditionalInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderAdditionalInformations_GroupProviders_GroupProviderId",
                        column: x => x.GroupProviderId,
                        principalTable: "GroupProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProviderOptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    LabelText = table.Column<string>(nullable: false),
                    IsFirstOption = table.Column<bool>(nullable: false),
                    IsSecondaryOption = table.Column<bool>(nullable: false),
                    GroupProviderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProviderOptions_GroupProviders_GroupProviderId",
                        column: x => x.GroupProviderId,
                        principalTable: "GroupProviders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoreProviders_LanguageConfigurationId",
                table: "CoreProviders",
                column: "LanguageConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_FooterInfos_LanguageConfigurationId",
                table: "FooterInfos",
                column: "LanguageConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupProviders_CoreProviderId",
                table: "GroupProviders",
                column: "CoreProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupProviders_ProviderCategoryId",
                table: "GroupProviders",
                column: "ProviderCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndexPhotos_LanguageConfigurationId",
                table: "IndexPhotos",
                column: "LanguageConfigurationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderAdditionalInformations_GroupProviderId",
                table: "ProviderAdditionalInformations",
                column: "GroupProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderHeaderInfos_CoreProviderId",
                table: "ProviderHeaderInfos",
                column: "CoreProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderOptions_GroupProviderId",
                table: "ProviderOptions",
                column: "GroupProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_TopProviders_LanguageConfigurationId",
                table: "TopProviders",
                column: "LanguageConfigurationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FooterInfos");

            migrationBuilder.DropTable(
                name: "IndexPhotos");

            migrationBuilder.DropTable(
                name: "ProviderAdditionalInformations");

            migrationBuilder.DropTable(
                name: "ProviderHeaderInfos");

            migrationBuilder.DropTable(
                name: "ProviderOptions");

            migrationBuilder.DropTable(
                name: "TopProviders");

            migrationBuilder.DropTable(
                name: "GroupProviders");

            migrationBuilder.DropTable(
                name: "CoreProviders");

            migrationBuilder.DropTable(
                name: "ProviderCategories");

            migrationBuilder.DropTable(
                name: "LanguageConfigurations");
        }
    }
}
