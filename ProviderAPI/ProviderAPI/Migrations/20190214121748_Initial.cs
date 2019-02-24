using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProviderAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessBanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<string>(nullable: false),
                    IdentityCardNumber = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlfanetTvs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlfanetTvs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AtaBanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerCode = table.Column<string>(nullable: false),
                    LoanAccountNumber = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtaBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avirtels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avirtels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AzerOnlines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzerOnlines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AzerTurkBanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<string>(nullable: false),
                    PinCode = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzerTurkBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AzeuroTelPhones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzeuroTelPhones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AzeuroTels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzeuroTels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Azincoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Azincoms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankOfBakus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<string>(nullable: false),
                    CardNumberId = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankOfBakus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankRespublikas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<string>(nullable: false),
                    CardNumberId = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankRespublikas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClipTvs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClipTvs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpressBanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<string>(nullable: false),
                    PinCode = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpressBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XalqBanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoanContractNumber = table.Column<string>(nullable: false),
                    PinCodeSerialNumber = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XalqBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Irshads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerCode = table.Column<string>(nullable: false),
                    PIN = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Irshads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KapitalBanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerCode = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KapitalBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LangConfigs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LangName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LangConfigs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UniBanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CardPinId = table.Column<string>(nullable: false),
                    AgreementNumber = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntertainmentPrefixes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: false),
                    LangConfigId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntertainmentPrefixes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntertainmentPrefixes_LangConfigs_LangConfigId",
                        column: x => x.LangConfigId,
                        principalTable: "LangConfigs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prefix",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrefixValue = table.Column<string>(nullable: false),
                    LangConfigId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prefix", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prefix_LangConfigs_LangConfigId",
                        column: x => x.LangConfigId,
                        principalTable: "LangConfigs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UtilityPrefixes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrefixValue = table.Column<string>(nullable: false),
                    LangConfigId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilityPrefixes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UtilityPrefixes_LangConfigs_LangConfigId",
                        column: x => x.LangConfigId,
                        principalTable: "LangConfigs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrWebs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    EntertainmentPrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrWebs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrWebs_EntertainmentPrefixes_EntertainmentPrefixId",
                        column: x => x.EntertainmentPrefixId,
                        principalTable: "EntertainmentPrefixes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Esets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    EntertainmentPrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Esets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Esets_EntertainmentPrefixes_EntertainmentPrefixId",
                        column: x => x.EntertainmentPrefixId,
                        principalTable: "EntertainmentPrefixes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kasperskies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    EntertainmentPrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kasperskies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kasperskies_EntertainmentPrefixes_EntertainmentPrefixId",
                        column: x => x.EntertainmentPrefixId,
                        principalTable: "EntertainmentPrefixes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Azercells",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Azercells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Azercells_Prefix_PrefixId",
                        column: x => x.PrefixId,
                        principalTable: "Prefix",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AzerPays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzerPays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AzerPays_Prefix_PrefixId",
                        column: x => x.PrefixId,
                        principalTable: "Prefix",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bakcells",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakcells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bakcells_Prefix_PrefixId",
                        column: x => x.PrefixId,
                        principalTable: "Prefix",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Naxtels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naxtels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Naxtels_Prefix_PrefixId",
                        column: x => x.PrefixId,
                        principalTable: "Prefix",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nars_Prefix_PrefixId",
                        column: x => x.PrefixId,
                        principalTable: "Prefix",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortManats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortManats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PortManats_Prefix_PrefixId",
                        column: x => x.PrefixId,
                        principalTable: "Prefix",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AzerIshiqs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AbonentCode = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    UtilityPrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzerIshiqs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AzerIshiqs_UtilityPrefixes_UtilityPrefixId",
                        column: x => x.UtilityPrefixId,
                        principalTable: "UtilityPrefixes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AzeriQazes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AbonentCode = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    UtilityPrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzeriQazes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AzeriQazes_UtilityPrefixes_UtilityPrefixId",
                        column: x => x.UtilityPrefixId,
                        principalTable: "UtilityPrefixes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AzerSus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AbonentCode = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    UtilityPrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzerSus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AzerSus_UtilityPrefixes_UtilityPrefixId",
                        column: x => x.UtilityPrefixId,
                        principalTable: "UtilityPrefixes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VOEN = table.Column<string>(nullable: false),
                    ServiceType = table.Column<string>(nullable: false),
                    User = table.Column<string>(nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    UtilityPrefixId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vns_UtilityPrefixes_UtilityPrefixId",
                        column: x => x.UtilityPrefixId,
                        principalTable: "UtilityPrefixes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Azercells_PrefixId",
                table: "Azercells",
                column: "PrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_AzerIshiqs_UtilityPrefixId",
                table: "AzerIshiqs",
                column: "UtilityPrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_AzeriQazes_UtilityPrefixId",
                table: "AzeriQazes",
                column: "UtilityPrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_AzerPays_PrefixId",
                table: "AzerPays",
                column: "PrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_AzerSus_UtilityPrefixId",
                table: "AzerSus",
                column: "UtilityPrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_Bakcells_PrefixId",
                table: "Bakcells",
                column: "PrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_DrWebs_EntertainmentPrefixId",
                table: "DrWebs",
                column: "EntertainmentPrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_EntertainmentPrefixes_LangConfigId",
                table: "EntertainmentPrefixes",
                column: "LangConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_Esets_EntertainmentPrefixId",
                table: "Esets",
                column: "EntertainmentPrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_Kasperskies_EntertainmentPrefixId",
                table: "Kasperskies",
                column: "EntertainmentPrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_Naxtels_PrefixId",
                table: "Naxtels",
                column: "PrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_Nars_PrefixId",
                table: "Nars",
                column: "PrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_PortManats_PrefixId",
                table: "PortManats",
                column: "PrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_Prefix_LangConfigId",
                table: "Prefix",
                column: "LangConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityPrefixes_LangConfigId",
                table: "UtilityPrefixes",
                column: "LangConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_Vns_UtilityPrefixId",
                table: "Vns",
                column: "UtilityPrefixId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessBanks");

            migrationBuilder.DropTable(
                name: "AlfanetTvs");

            migrationBuilder.DropTable(
                name: "AtaBanks");

            migrationBuilder.DropTable(
                name: "Avirtels");

            migrationBuilder.DropTable(
                name: "Azercells");

            migrationBuilder.DropTable(
                name: "AzerIshiqs");

            migrationBuilder.DropTable(
                name: "AzeriQazes");

            migrationBuilder.DropTable(
                name: "AzerOnlines");

            migrationBuilder.DropTable(
                name: "AzerPays");

            migrationBuilder.DropTable(
                name: "AzerSus");

            migrationBuilder.DropTable(
                name: "AzerTurkBanks");

            migrationBuilder.DropTable(
                name: "AzeuroTelPhones");

            migrationBuilder.DropTable(
                name: "AzeuroTels");

            migrationBuilder.DropTable(
                name: "Azincoms");

            migrationBuilder.DropTable(
                name: "Bakcells");

            migrationBuilder.DropTable(
                name: "BankOfBakus");

            migrationBuilder.DropTable(
                name: "BankRespublikas");

            migrationBuilder.DropTable(
                name: "Catels");

            migrationBuilder.DropTable(
                name: "ClipTvs");

            migrationBuilder.DropTable(
                name: "DrWebs");

            migrationBuilder.DropTable(
                name: "ExpressBanks");

            migrationBuilder.DropTable(
                name: "Esets");

            migrationBuilder.DropTable(
                name: "XalqBanks");

            migrationBuilder.DropTable(
                name: "Irshads");

            migrationBuilder.DropTable(
                name: "KapitalBanks");

            migrationBuilder.DropTable(
                name: "Kasperskies");

            migrationBuilder.DropTable(
                name: "Naxtels");

            migrationBuilder.DropTable(
                name: "Nars");

            migrationBuilder.DropTable(
                name: "PortManats");

            migrationBuilder.DropTable(
                name: "UniBanks");

            migrationBuilder.DropTable(
                name: "Vns");

            migrationBuilder.DropTable(
                name: "EntertainmentPrefixes");

            migrationBuilder.DropTable(
                name: "Prefix");

            migrationBuilder.DropTable(
                name: "UtilityPrefixes");

            migrationBuilder.DropTable(
                name: "LangConfigs");
        }
    }
}
