﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalProject.Models;

namespace finalProject.Migrations
{
    [DbContext(typeof(ProviderDbContext))]
    [Migration("20190216000831_IdentityAdded")]
    partial class IdentityAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("finalProject.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("finalProject.Models.CoreProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackColor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("DataId");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("LangId");

                    b.Property<int?>("LanguageConfigurationId");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Text")
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.HasIndex("LanguageConfigurationId");

                    b.ToTable("CoreProviders");
                });

            modelBuilder.Entity("finalProject.Models.FooterInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LangId");

                    b.Property<int?>("LanguageConfigurationId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("LanguageConfigurationId");

                    b.ToTable("FooterInfos");
                });

            modelBuilder.Entity("finalProject.Models.GroupProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackColor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("CoreProviderId");

                    b.Property<bool>("HasAdditionalInput");

                    b.Property<bool>("HasInput");

                    b.Property<bool>("HasOptions");

                    b.Property<bool>("HasSecondaryInput");

                    b.Property<bool>("HasSecondaryOptions");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int?>("ProviderCategoryId");

                    b.Property<int>("ProviderCategroyId");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("True");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CoreProviderId");

                    b.HasIndex("ProviderCategoryId");

                    b.ToTable("GroupProviders");
                });

            modelBuilder.Entity("finalProject.Models.GroupProviderPageButtonText", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LangId");

                    b.Property<int?>("LanguageConfigurationId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("LanguageConfigurationId");

                    b.ToTable("GroupProviderPageButtonTexts");
                });

            modelBuilder.Entity("finalProject.Models.HomeButtonText", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LangId");

                    b.Property<int?>("LanguageConfigurationId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("LanguageConfigurationId");

                    b.ToTable("HomeButtonTexts");
                });

            modelBuilder.Entity("finalProject.Models.IndexPhoto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LangId");

                    b.Property<int?>("LanguageConfigurationId");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("id");

                    b.HasIndex("LanguageConfigurationId");

                    b.ToTable("IndexPhotos");
                });

            modelBuilder.Entity("finalProject.Models.LanguageConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LangName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("LanguageConfigurations");
                });

            modelBuilder.Entity("finalProject.Models.ProviderAdditionalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInputText");

                    b.Property<int?>("AdditionalInputValidLength");

                    b.Property<int?>("FirstInputValidLength");

                    b.Property<int>("GroupProviderId");

                    b.Property<string>("InputText");

                    b.Property<string>("SecondaryInputText");

                    b.Property<int?>("SecondaryInputValidLength");

                    b.HasKey("Id");

                    b.HasIndex("GroupProviderId");

                    b.ToTable("ProviderAdditionalInformations");
                });

            modelBuilder.Entity("finalProject.Models.ProviderCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ProviderCategories");
                });

            modelBuilder.Entity("finalProject.Models.ProviderHeaderInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoreProviderId");

                    b.Property<string>("ImgPath")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.HasIndex("CoreProviderId");

                    b.ToTable("ProviderHeaderInfos");
                });

            modelBuilder.Entity("finalProject.Models.ProviderOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupProviderId");

                    b.Property<bool>("IsFirstOption");

                    b.Property<bool>("IsSecondaryOption");

                    b.Property<string>("LabelText")
                        .IsRequired();

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("GroupProviderId");

                    b.ToTable("ProviderOptions");
                });

            modelBuilder.Entity("finalProject.Models.TopProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackColor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("DataId");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("LangId");

                    b.Property<int?>("LanguageConfigurationId");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("LanguageConfigurationId");

                    b.ToTable("TopProviders");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("finalProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("finalProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("finalProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("finalProject.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("finalProject.Models.CoreProvider", b =>
                {
                    b.HasOne("finalProject.Models.LanguageConfiguration", "LanguageConfiguration")
                        .WithMany()
                        .HasForeignKey("LanguageConfigurationId");
                });

            modelBuilder.Entity("finalProject.Models.FooterInfo", b =>
                {
                    b.HasOne("finalProject.Models.LanguageConfiguration", "LanguageConfiguration")
                        .WithMany()
                        .HasForeignKey("LanguageConfigurationId");
                });

            modelBuilder.Entity("finalProject.Models.GroupProvider", b =>
                {
                    b.HasOne("finalProject.Models.CoreProvider", "CoreProvider")
                        .WithMany()
                        .HasForeignKey("CoreProviderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("finalProject.Models.ProviderCategory", "ProviderCategory")
                        .WithMany()
                        .HasForeignKey("ProviderCategoryId");
                });

            modelBuilder.Entity("finalProject.Models.GroupProviderPageButtonText", b =>
                {
                    b.HasOne("finalProject.Models.LanguageConfiguration", "LanguageConfiguration")
                        .WithMany()
                        .HasForeignKey("LanguageConfigurationId");
                });

            modelBuilder.Entity("finalProject.Models.HomeButtonText", b =>
                {
                    b.HasOne("finalProject.Models.LanguageConfiguration", "LanguageConfiguration")
                        .WithMany()
                        .HasForeignKey("LanguageConfigurationId");
                });

            modelBuilder.Entity("finalProject.Models.IndexPhoto", b =>
                {
                    b.HasOne("finalProject.Models.LanguageConfiguration", "LanguageConfiguration")
                        .WithMany()
                        .HasForeignKey("LanguageConfigurationId");
                });

            modelBuilder.Entity("finalProject.Models.ProviderAdditionalInformation", b =>
                {
                    b.HasOne("finalProject.Models.GroupProvider", "GroupProvider")
                        .WithMany()
                        .HasForeignKey("GroupProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("finalProject.Models.ProviderHeaderInfo", b =>
                {
                    b.HasOne("finalProject.Models.CoreProvider", "CoreProvider")
                        .WithMany()
                        .HasForeignKey("CoreProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("finalProject.Models.ProviderOption", b =>
                {
                    b.HasOne("finalProject.Models.GroupProvider", "GroupProvider")
                        .WithMany()
                        .HasForeignKey("GroupProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("finalProject.Models.TopProvider", b =>
                {
                    b.HasOne("finalProject.Models.LanguageConfiguration", "LanguageConfiguration")
                        .WithMany()
                        .HasForeignKey("LanguageConfigurationId");
                });
#pragma warning restore 612, 618
        }
    }
}
