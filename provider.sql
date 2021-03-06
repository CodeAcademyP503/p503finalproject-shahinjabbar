USE [master]
GO
/****** Object:  Database [ProviderDb]    Script Date: 16.02.2019 17:26:54 ******/
CREATE DATABASE [ProviderDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProviderDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ProviderDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProviderDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ProviderDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProviderDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProviderDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProviderDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProviderDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProviderDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProviderDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProviderDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProviderDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProviderDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProviderDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProviderDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProviderDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProviderDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProviderDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProviderDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProviderDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProviderDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProviderDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProviderDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProviderDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProviderDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProviderDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProviderDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ProviderDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProviderDb] SET RECOVERY FULL 
GO
ALTER DATABASE [ProviderDb] SET  MULTI_USER 
GO
ALTER DATABASE [ProviderDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProviderDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProviderDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProviderDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProviderDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProviderDb', N'ON'
GO
ALTER DATABASE [ProviderDb] SET QUERY_STORE = OFF
GO
USE [ProviderDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ProviderDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CoreProviders]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoreProviders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TagName] [nvarchar](50) NOT NULL,
	[BackColor] [nvarchar](50) NOT NULL,
	[ImagePath] [nvarchar](255) NOT NULL,
	[Text] [nvarchar](70) NULL,
	[DataId] [int] NOT NULL,
	[LangId] [int] NOT NULL,
	[LanguageConfigurationId] [int] NULL,
 CONSTRAINT [PK_CoreProviders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FooterInfos]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FooterInfos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[LangId] [int] NOT NULL,
	[LanguageConfigurationId] [int] NULL,
 CONSTRAINT [PK_FooterInfos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupProviderPageButtonTexts]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupProviderPageButtonTexts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[LangId] [int] NOT NULL,
	[LanguageConfigurationId] [int] NULL,
 CONSTRAINT [PK_GroupProviderPageButtonTexts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupProviders]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupProviders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TagName] [nvarchar](50) NOT NULL,
	[BackColor] [nvarchar](50) NOT NULL,
	[ImagePath] [nvarchar](255) NOT NULL,
	[HasOptions] [bit] NOT NULL,
	[HasSecondaryOptions] [bit] NOT NULL,
	[HasInput] [bit] NOT NULL,
	[HasSecondaryInput] [bit] NOT NULL,
	[HasAdditionalInput] [bit] NOT NULL,
	[CoreProviderId] [int] NOT NULL,
	[ProviderCategroyId] [int] NOT NULL,
	[ProviderCategoryId] [int] NULL,
	[ProviderName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_GroupProviders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HomeButtonTexts]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HomeButtonTexts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[LangId] [int] NOT NULL,
	[LanguageConfigurationId] [int] NULL,
 CONSTRAINT [PK_HomeButtonTexts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IndexPhotos]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IndexPhotos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PhotoPath] [nvarchar](500) NOT NULL,
	[LangId] [int] NOT NULL,
	[LanguageConfigurationId] [int] NULL,
 CONSTRAINT [PK_IndexPhotos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LanguageConfigurations]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageConfigurations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LangName] [nvarchar](50) NOT NULL,
	[PhotoPath] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_LanguageConfigurations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProviderAdditionalInformations]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProviderAdditionalInformations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InputText] [nvarchar](max) NULL,
	[SecondaryInputText] [nvarchar](max) NULL,
	[AdditionalInputText] [nvarchar](max) NULL,
	[FirstInputValidLength] [int] NULL,
	[SecondaryInputValidLength] [int] NULL,
	[AdditionalInputValidLength] [int] NULL,
	[GroupProviderId] [int] NOT NULL,
 CONSTRAINT [PK_ProviderAdditionalInformations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProviderCategories]    Script Date: 16.02.2019 17:26:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProviderCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ProviderCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProviderHeaderInfos]    Script Date: 16.02.2019 17:26:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProviderHeaderInfos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImgPath] [nvarchar](70) NOT NULL,
	[Text] [nvarchar](70) NOT NULL,
	[CoreProviderId] [int] NOT NULL,
 CONSTRAINT [PK_ProviderHeaderInfos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProviderOptions]    Script Date: 16.02.2019 17:26:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProviderOptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[LabelText] [nvarchar](max) NOT NULL,
	[IsFirstOption] [bit] NOT NULL,
	[IsSecondaryOption] [bit] NOT NULL,
	[GroupProviderId] [int] NOT NULL,
 CONSTRAINT [PK_ProviderOptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TopProviders]    Script Date: 16.02.2019 17:26:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopProviders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TagName] [nvarchar](50) NOT NULL,
	[BackColor] [nvarchar](50) NOT NULL,
	[ImagePath] [nvarchar](255) NOT NULL,
	[DataId] [int] NOT NULL,
	[LangId] [int] NOT NULL,
	[LanguageConfigurationId] [int] NULL,
 CONSTRAINT [PK_TopProviders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190130155114_Initial', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190201112257_ProviderAdditionalInformationsUpdated', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190201112501_ProviderAdditionalInformationsUpdatedAgain1', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190202203410_SecondLabelTextAddedToProviderOptions', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190202224752_ButtonTextsAddedToGroupProvider', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190202224901_ButtonTextsAddedToGroupProvider', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190202231905_HomeButtonTextAddedToGroupProvider', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190215090815_providernameadded', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190216000831_IdentityAdded', N'2.2.0-rtm-35687')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4159a56e-3f3d-4296-b6e0-6dbd74124464', N'User', N'USER', N'c88b51c1-81fe-4940-8572-fcf69ef341a1')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'440844ae-3b5d-48e3-8036-1949ef06d833', N'Admin', N'ADMIN', N'6f2cbc33-7b51-4e8e-9ba6-c4ba457094c3')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'b3901c07-9568-4816-9ba1-bf032d83baf9', N'Moderator', N'MODERATOR', N'2d19a264-538b-4a1e-bdfa-b628fe1f39a1')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f35ed3c6-67f7-4ccd-a70d-bd9812a826ba', N'4159a56e-3f3d-4296-b6e0-6dbd74124464')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f35ed3c6-67f7-4ccd-a70d-bd9812a826ba', N'440844ae-3b5d-48e3-8036-1949ef06d833')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f35ed3c6-67f7-4ccd-a70d-bd9812a826ba', N'sasasjahsjahs', N'SASASJAHSJAHS', N'shjassah@gmail.com', N'SHJASSAH@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELJKZIZ7Pk+lqnknshzdYVUTY2oXiO5Eo14FSkXf91b9PHU3oP9ocTAbDflUShmIMg==', N'4LPCTSFDAH4B7K3HUJHCIO2JXVRKT4XI', N'50e1843c-9931-4e74-b8c3-fab7a763f5d9', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[CoreProviders] ON 

INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (1, N'a', N'rgb(23,92,179)', N'communal.png', N'Kommunal ödənişlər', 1, 1, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (2, N'a', N'rgb(253,169,6)', N'hand-with-smartphone-and-wireless-internet.png', N'Mobil operatorlar', 2, 1, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (3, N'a', N'rgb(61,30,121)', N'bill.png', N'Bank xidmətləri', 3, 1, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (4, N'a', N'rgb(177,29,165)', N'university-with-a-flag.png', N'Dövlət və bələdiyyə', 4, 1, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (5, N'a', N'rgb(68,128,28)', N'monitor.png', N'TV', 5, 1, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (6, N'a', N'rgb(239,58,37)', N'Wifi.png', N'İnternet', 6, 1, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (7, N'a', N'rgb(49,137,188)', N'old-telephone-ringing.png', N'Telefon', 7, 1, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (8, N'a', N'rgb(179,30,69)', N'gamepad.png', N'Əyləncə və oyunlar', 8, 1, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (9, N'a', N'rgb(180,116,48)', N'wallet-filled-money-tool.png', N'E-pulqabı', 9, 1, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (10, N'a', N'rgb(23,92,179)', N'communal.png', N'Коммунальные платежи', 1, 2, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (11, N'a', N'rgb(253,169,6)', N'hand-with-smartphone-and-wireless-internet.png', N' Сотовые операторы', 2, 2, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (12, N'a', N'rgb(61,30,121)', N'bill.png', N' Банковские услуги ', 3, 2, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (13, N'a', N'rgb(177,29,165)', N'university-with-a-flag.png', N' Государственные и муниципальные платежи', 4, 2, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (14, N'a', N'rgb(68,128,28)', N'monitor.png', N'TВ', 5, 2, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (15, N'a', N'rgb(239,58,37)', N'Wifi.png', N'Интернет', 6, 2, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (16, N'a', N'rgb(49,137,188)', N'old-telephone-ringing.png', N'Tелефон', 7, 2, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (17, N'a', N'rgb(179,30,69)', N'gamepad.png', N'Развлечения и игры', 8, 2, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (18, N'a', N'rgb(180,116,48)', N'wallet-filled-money-tool.png', N' E-кошелек ', 9, 2, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (19, N'a', N'rgb(23,92,179)', N'communal.png', N' Utility payments ', 1, 3, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (20, N'a', N'rgb(253,169,6)', N'hand-with-smartphone-and-wireless-internet.png', N' Mobile operators ', 2, 3, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (21, N'a', N'rgb(61,30,121)', N'bill.png', N' Bank services ', 3, 3, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (22, N'a', N'rgb(177,29,165)', N'university-with-a-flag.png', N' State and municipality payments ', 4, 3, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (23, N'a', N'rgb(68,128,28)', N'monitor.png', N' TV ', 5, 3, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (24, N'a', N'rgb(239,58,37)', N'Wifi.png', N' Internet ', 6, 3, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (25, N'a', N'rgb(49,137,188)', N'old-telephone-ringing.png', N' Phone ', 7, 3, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (26, N'a', N'rgb(179,30,69)', N'gamepad.png', N' Entertainment and Games ', 8, 3, NULL)
INSERT [dbo].[CoreProviders] ([Id], [TagName], [BackColor], [ImagePath], [Text], [DataId], [LangId], [LanguageConfigurationId]) VALUES (27, N'a', N'rgb(180,116,48)', N'wallet-filled-money-tool.png', N' E-Wallet ', 9, 3, NULL)
SET IDENTITY_INSERT [dbo].[CoreProviders] OFF
SET IDENTITY_INSERT [dbo].[FooterInfos] ON 

INSERT [dbo].[FooterInfos] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (1, N'Müştəri xidmətləri: 012 404 48 88', 1, NULL)
INSERT [dbo].[FooterInfos] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (2, N'Служба поддержки клиентов: 012 404 48 88', 2, NULL)
INSERT [dbo].[FooterInfos] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (3, N'Customer service: 012 404 48 88', 3, NULL)
SET IDENTITY_INSERT [dbo].[FooterInfos] OFF
SET IDENTITY_INSERT [dbo].[GroupProviderPageButtonTexts] ON 

INSERT [dbo].[GroupProviderPageButtonTexts] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (1, N'Davam Et', 1, NULL)
INSERT [dbo].[GroupProviderPageButtonTexts] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (3, N'İmtina et', 1, NULL)
INSERT [dbo].[GroupProviderPageButtonTexts] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (4, N'Continue', 3, NULL)
INSERT [dbo].[GroupProviderPageButtonTexts] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (5, N'Cancel', 3, NULL)
INSERT [dbo].[GroupProviderPageButtonTexts] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (6, N'Далее', 2, NULL)
INSERT [dbo].[GroupProviderPageButtonTexts] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (7, N'Отменить', 2, NULL)
SET IDENTITY_INSERT [dbo].[GroupProviderPageButtonTexts] OFF
SET IDENTITY_INSERT [dbo].[GroupProviders] ON 

INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (1, N'a', N'fff', N'azeriqaz.png', 1, 0, 1, 0, 0, 1, 1, NULL, N'Azeriqaz')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (2, N'a', N'fff', N'AZERSU logo.png', 1, 0, 1, 0, 0, 1, 1, NULL, N'Azersu')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (3, N'a', N'fff', N'bes.png', 1, 0, 1, 0, 0, 1, 1, NULL, N'Azerishiq')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (5, N'a', N'fff', N'azeriqaz.png', 1, 0, 1, 0, 0, 10, 1, NULL, N'Azeriqaz')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (6, N'a', N'fff', N'AZERSU logo.png', 1, 0, 1, 0, 0, 10, 1, NULL, N'Azersu')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (7, N'a', N'fff', N'bes.png', 1, 0, 1, 0, 0, 10, 1, NULL, N'Azerishiq')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (9, N'a', N'fff', N'azeriqaz.png', 1, 0, 1, 0, 0, 19, 1, NULL, N'Azeriqaz')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (10, N'a', N'fff', N'AZERSU logo.png', 1, 0, 1, 0, 0, 19, 1, NULL, N'Azersu')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (11, N'a', N'fff', N'bes.png', 1, 0, 1, 0, 0, 19, 1, NULL, N'Azerishiq')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (13, N'a', N'fff', N'azercell.png', 1, 0, 1, 0, 0, 2, 2, NULL, N'Azercell')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (14, N'a', N'fff', N'200x41 red-logo.png', 1, 0, 1, 0, 0, 2, 2, NULL, N'Bakcell')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (15, N'a', N'fff', N'230x96narlogo.png', 1, 0, 1, 0, 0, 2, 2, NULL, N'Nar')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (16, N'a', N'fff', N'naxtel4gmobile.png', 1, 0, 1, 0, 0, 2, 2, NULL, N'Naxtel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (17, N'a', N'fff', N'azercell.png', 1, 0, 1, 0, 0, 11, 2, NULL, N'Azercell')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (18, N'a', N'fff', N'200x41 red-logo.png', 1, 0, 1, 0, 0, 11, 2, NULL, N'Bakcell')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (19, N'a', N'fff', N'230x96narlogo.png', 1, 0, 1, 0, 0, 11, 2, NULL, N'Nar')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (20, N'a', N'fff', N'naxtel4gmobile.png', 1, 0, 1, 0, 0, 11, 2, NULL, N'Naxtel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (21, N'a', N'fff', N'azercell.png', 1, 0, 1, 0, 0, 20, 2, NULL, N'Azercell')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (22, N'a', N'fff', N'200x41 red-logo.png', 1, 0, 1, 0, 0, 20, 2, NULL, N'Bakcell')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (23, N'a', N'fff', N'230x96narlogo.png', 1, 0, 1, 0, 0, 20, 2, NULL, N'Nar')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (24, N'a', N'fff', N'naxtel4gmobile.png', 1, 0, 1, 0, 0, 20, 2, NULL, N'Naxtel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (25, N'a', N'fff', N'accessbank.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'AccessBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (28, N'a', N'fff', N'atabank.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'AtaBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (29, N'a', N'fff', N'azer_turk7.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'AzerTurkBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (30, N'a', N'fff', N'bankofbaku.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'BankofBaku')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (31, N'a', N'fff', N'bankrespublika.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'BankRespublika')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (32, N'a', N'fff', N'express.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'ExpressBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (33, N'a', N'fff', N'logo_irshad1.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'Irshad')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (34, N'a', N'fff', N'kapitalbank.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'Kapitalbank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (37, N'a', N'fff', N'unibank.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'Unibank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (38, N'a', N'fff', N'header.png', 0, 0, 1, 1, 0, 3, 3, NULL, N'XalqBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (39, N'a', N'fff', N'accessbank.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'AccessBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (42, N'a', N'fff', N'atabank.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'AtaBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (43, N'a', N'fff', N'azer_turk7.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'AzerTurkBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (44, N'a', N'fff', N'bankofbaku.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'BankofBaku')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (45, N'a', N'fff', N'bankrespublika.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'BankRespublika')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (46, N'a', N'fff', N'express.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'ExpressBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (47, N'a', N'fff', N'logo_irshad1.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'Irshad')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (48, N'a', N'fff', N'kapitalbank.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'Kapitalbank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (51, N'a', N'fff', N'unibank.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'Unibank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (52, N'a', N'fff', N'header.png', 0, 0, 1, 1, 0, 12, 3, NULL, N'XalqBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (53, N'a', N'fff', N'accessbank.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'AccessBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (56, N'a', N'fff', N'atabank.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'AtaBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (57, N'a', N'fff', N'azer_turk7.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'AzerTurkBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (58, N'a', N'fff', N'bankofbaku.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'BankofBaku')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (59, N'a', N'fff', N'bankrespublika.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'BankRespublika')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (60, N'a', N'fff', N'express.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'ExpressBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (61, N'a', N'fff', N'logo_irshad1.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'Irshad')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (62, N'a', N'fff', N'kapitalbank.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'Kapitalbank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (65, N'a', N'fff', N'unibank.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'Unibank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (66, N'a', N'fff', N'header.png', 0, 0, 1, 1, 0, 21, 3, NULL, N'XalqBank')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (67, N'a', N'fff', N'taxes.png', 1, 0, 1, 0, 0, 4, 4, NULL, N'Taxes')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (68, N'a', N'fff', N'taxes.png', 1, 0, 1, 0, 0, 13, 4, NULL, N'Taxes')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (69, N'a', N'fff', N'taxes.png', 1, 0, 1, 0, 0, 22, 4, NULL, N'Taxes')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (72, N'a', N'fff', N'ALFANET_TV.png', 0, 0, 1, 0, 0, 5, 5, NULL, N'AlfanetTv')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (75, N'a', N'fff', N'cliptv150.png', 0, 0, 1, 0, 0, 5, 5, NULL, N'ClipTv')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (81, N'a', N'fff', N'ALFANET_TV.png', 0, 0, 1, 0, 0, 14, 5, NULL, N'AlfanetTv')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (84, N'a', N'fff', N'cliptv150.png', 0, 0, 1, 0, 0, 14, 5, NULL, N'ClipTv')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (90, N'a', N'fff', N'ALFANET_TV.png', 0, 0, 1, 0, 0, 23, 5, NULL, N'AlfanetTv')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (93, N'a', N'fff', N'cliptv150.png', 0, 0, 1, 0, 0, 23, 5, NULL, N'ClipTV')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (99, N'a', N'fff', N'avirtel.png', 0, 0, 1, 0, 0, 6, 6, NULL, N'Avirtel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (100, N'a', N'fff', N'azeronline.png', 0, 0, 1, 0, 0, 6, 6, NULL, N'AzerOnline')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (101, N'a', N'fff', N'azeurot_logo.png', 0, 0, 1, 0, 0, 6, 6, NULL, N'AzEuroTel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (102, N'a', N'fff', N'azincom.png', 0, 0, 1, 0, 0, 6, 6, NULL, N'Azincom')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (107, N'a', N'fff', N'avirtel.png', 0, 0, 1, 0, 0, 15, 6, NULL, N'Avirtel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (108, N'a', N'fff', N'azeronline.png', 0, 0, 1, 0, 0, 15, 6, NULL, N'AzerOnline')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (109, N'a', N'fff', N'azeurot_logo.png', 0, 0, 1, 0, 0, 15, 6, NULL, N'AzEuroTel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (110, N'a', N'fff', N'azincom.png', 0, 0, 1, 0, 0, 15, 6, NULL, N'Azincom')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (115, N'a', N'fff', N'avirtel.png', 0, 0, 1, 0, 0, 24, 6, NULL, N'Avirtel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (116, N'a', N'fff', N'azeronline.png', 0, 0, 1, 0, 0, 24, 6, NULL, N'AzerOnline')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (117, N'a', N'fff', N'azeurot_logo.png', 0, 0, 1, 0, 0, 24, 6, NULL, N'AzEuroTel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (118, N'a', N'fff', N'azincom.png', 0, 0, 1, 0, 0, 24, 6, NULL, N'Azincom')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (121, N'a', N'fff', N'azeurot_logo.png', 0, 0, 1, 0, 0, 7, 7, NULL, N'AzEuroTelPhone')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (122, N'a', N'fff', N'catel (1).png', 0, 0, 1, 0, 0, 7, 7, NULL, N'Catel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (124, N'a', N'fff', N'azeurot_logo.png', 0, 0, 1, 0, 0, 16, 7, NULL, N'AzEuroTelPhone')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (125, N'a', N'fff', N'catel (1).png', 0, 0, 1, 0, 0, 16, 7, NULL, N'Catel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (127, N'a', N'fff', N'azeurot_logo.png', 0, 0, 1, 0, 0, 25, 7, NULL, N'AzEuroTelPhone')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (128, N'a', N'fff', N'catel (1).png', 0, 0, 1, 0, 0, 25, 7, NULL, N'Catel')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (131, N'a', N'fff', N'DrWeb.png', 1, 0, 1, 0, 0, 8, 8, NULL, N'DrWeb')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (132, N'a', N'fff', N'ESET_logo.png', 1, 0, 1, 0, 0, 8, 8, NULL, N'Eset')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (133, N'a', N'fff', N'kaspersky.png', 1, 0, 1, 0, 0, 8, 8, NULL, N'Kaspersky')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (135, N'a', N'fff', N'DrWeb.png', 1, 0, 1, 0, 0, 17, 8, NULL, N'DrWeb')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (136, N'a', N'fff', N'ESET_logo.png', 1, 0, 1, 0, 0, 17, 8, NULL, N'Eset')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (137, N'a', N'fff', N'kaspersky.png', 1, 0, 1, 0, 0, 17, 8, NULL, N'Kaspersky')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (139, N'a', N'fff', N'DrWeb.png', 1, 0, 1, 0, 0, 26, 8, NULL, N'DrWEb')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (140, N'a', N'fff', N'ESET_logo.png', 1, 0, 1, 0, 0, 26, 8, NULL, N'Eset')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (141, N'a', N'fff', N'kaspersky.png', 1, 0, 1, 0, 0, 26, 8, NULL, N'Kaspersky')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (142, N'a', N'fff', N'144.jpg', 1, 0, 1, 0, 0, 9, 9, NULL, N'AzerPay')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (143, N'a', N'fff', N'portmanat.png', 1, 0, 1, 0, 0, 9, 9, NULL, N'Portmanat')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (144, N'a', N'fff', N'144.jpg', 1, 0, 1, 0, 0, 18, 9, NULL, N'AzerPay')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (145, N'a', N'fff', N'portmanat.png', 1, 0, 1, 0, 0, 18, 9, NULL, N'PortManat')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (146, N'a', N'fff', N'144.jpg', 1, 0, 1, 0, 0, 27, 9, NULL, N'AzerPay')
INSERT [dbo].[GroupProviders] ([Id], [TagName], [BackColor], [ImagePath], [HasOptions], [HasSecondaryOptions], [HasInput], [HasSecondaryInput], [HasAdditionalInput], [CoreProviderId], [ProviderCategroyId], [ProviderCategoryId], [ProviderName]) VALUES (147, N'a', N'fff', N'portmanat.png', 1, 0, 1, 0, 0, 27, 9, NULL, N'Portmanat')
SET IDENTITY_INSERT [dbo].[GroupProviders] OFF
SET IDENTITY_INSERT [dbo].[HomeButtonTexts] ON 

INSERT [dbo].[HomeButtonTexts] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (1, N'Ana Səhifə', 1, NULL)
INSERT [dbo].[HomeButtonTexts] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (2, N'Главная страница', 2, NULL)
INSERT [dbo].[HomeButtonTexts] ([id], [Text], [LangId], [LanguageConfigurationId]) VALUES (4, N'Home Page', 3, NULL)
SET IDENTITY_INSERT [dbo].[HomeButtonTexts] OFF
SET IDENTITY_INSERT [dbo].[IndexPhotos] ON 

INSERT [dbo].[IndexPhotos] ([id], [PhotoPath], [LangId], [LanguageConfigurationId]) VALUES (1, N'emanat.png', 1, NULL)
INSERT [dbo].[IndexPhotos] ([id], [PhotoPath], [LangId], [LanguageConfigurationId]) VALUES (2, N'Info-I-Logo.png', 1, NULL)
INSERT [dbo].[IndexPhotos] ([id], [PhotoPath], [LangId], [LanguageConfigurationId]) VALUES (3, N'emanat.png', 2, NULL)
INSERT [dbo].[IndexPhotos] ([id], [PhotoPath], [LangId], [LanguageConfigurationId]) VALUES (4, N'Info-I-Logo.png', 2, NULL)
INSERT [dbo].[IndexPhotos] ([id], [PhotoPath], [LangId], [LanguageConfigurationId]) VALUES (5, N'emanat.png', 3, NULL)
INSERT [dbo].[IndexPhotos] ([id], [PhotoPath], [LangId], [LanguageConfigurationId]) VALUES (6, N'Info-I-Logo.png', 3, NULL)
SET IDENTITY_INSERT [dbo].[IndexPhotos] OFF
SET IDENTITY_INSERT [dbo].[LanguageConfigurations] ON 

INSERT [dbo].[LanguageConfigurations] ([Id], [LangName], [PhotoPath]) VALUES (1, N'aze', N'if_Flag_of_Azerbaijan_96205.png')
INSERT [dbo].[LanguageConfigurations] ([Id], [LangName], [PhotoPath]) VALUES (2, N'rus', N'if_Flag_of_Russia_96241.png')
INSERT [dbo].[LanguageConfigurations] ([Id], [LangName], [PhotoPath]) VALUES (3, N'eng', N'if_Flag_of_United_Kingdom_96354.png')
SET IDENTITY_INSERT [dbo].[LanguageConfigurations] OFF
SET IDENTITY_INSERT [dbo].[ProviderAdditionalInformations] ON 

INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (2, N'Abonent kodu', NULL, NULL, 15, NULL, NULL, 1)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (4, N'Abonent kodu', NULL, NULL, 13, NULL, NULL, 2)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (5, N'Abonent kodu', NULL, NULL, 11, NULL, NULL, 3)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (7, N'Aбонентский код', NULL, NULL, 15, NULL, NULL, 5)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (8, N'Aбонентский код', NULL, NULL, 13, NULL, NULL, 6)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (9, N'Aбонентский код', NULL, NULL, 11, NULL, NULL, 7)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (11, N'Subscriber Number', NULL, NULL, 15, NULL, NULL, 9)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (12, N'Subscriber Number', NULL, NULL, 13, NULL, NULL, 10)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (13, N'Subscriber Number', NULL, NULL, 11, NULL, NULL, 11)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (15, N'Nömrə', NULL, NULL, 7, NULL, NULL, 13)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (16, N'Nömrə', NULL, NULL, 7, NULL, NULL, 14)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (17, N'Nömrə', NULL, NULL, 7, NULL, NULL, 15)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (18, N'Nömrə', NULL, NULL, 7, NULL, NULL, 16)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (19, N'Номер', NULL, NULL, 7, NULL, NULL, 17)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (20, N'Номер', NULL, NULL, 7, NULL, NULL, 18)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (21, N'Номер', NULL, NULL, 7, NULL, NULL, 19)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (22, N'Номер', NULL, NULL, 7, NULL, NULL, 20)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (23, N'Number', NULL, NULL, 7, NULL, NULL, 21)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (24, N'Number', NULL, NULL, 7, NULL, NULL, 22)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (25, N'Number', NULL, NULL, 7, NULL, NULL, 23)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (26, N'Number', NULL, NULL, 7, NULL, NULL, 24)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (27, N'Müştəri Kodu', N'Ş.V. nömrəsi (son 4 rəqəm)', NULL, 7, 4, NULL, 25)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (28, N'Müştəri kodu', N'Kredit hesab nömrəsi', NULL, 7, 7, NULL, 28)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (29, N'Hesab nömrəsi', N'Pin Kod', NULL, 7, 7, NULL, 29)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (30, N'Hesab nömrəsi', N'Şəxsiyyət vəsiqəsinin nömrəsi', NULL, 7, 11, NULL, 30)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (31, N'Hesab nömrəsi', N'Şəxsiyyət vəsiqəsinin nömrəsi', NULL, 7, 11, NULL, 31)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (32, N'Müştəri kodu', N'Pin Kod', NULL, 7, 7, NULL, 32)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (33, N'Müştəri kodu', N'FIN', NULL, 7, 7, NULL, 33)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (34, N'Müştəri kodu (CİF kod)', N'Doğum tarixi', NULL, 7, 10, NULL, 34)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (37, N'Şəxsiyyət vəsiqəsinin PİN kodu', N'Müqavilə nömrəsi', NULL, 7, 7, NULL, 37)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (38, N'Kredit müqaviləsinin nömrəsi', N'Şəxsiyyət vəsiqəsinin PİN-kodu / seriya və nömrə (digər sənədlər üçün)', NULL, 15, 10, NULL, 38)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (40, N'ИД пользователя', N'Номер удостоверения личности ( последние 4 цифры)', NULL, 7, 4, NULL, 39)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (41, N'Kод клиента', N'Номер кредитного счета', NULL, 7, 7, NULL, 42)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (42, N'Номер счета', N'Пин код', NULL, 7, 7, NULL, 43)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (43, N'Номер счета', N'Номер паспорта', NULL, 7, 11, NULL, 44)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (44, N'Номер счета', N'Номер паспорта', NULL, 7, 11, NULL, 45)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (45, N'Идентификатор пользователя', N'Пин код', NULL, 7, 7, NULL, 46)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (46, N'Код клиента', N'ПИН', NULL, 7, 7, NULL, 47)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (47, N'Код клиента (CIF Код)', N'Дата рождения', NULL, 7, 10, NULL, 48)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (50, N'Номер PİN паспорта', N'Номер договора', NULL, 7, 7, NULL, 51)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (51, N'Номер кредитного договора', N'ПИН-код удостоверения личности / серия и номер (для прочих документов)', NULL, 15, 10, NULL, 52)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (52, N'Customer ID', N'Identity card number ( last 4 digits )', NULL, 7, 4, NULL, 53)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (53, N'Customer Code', N'Loan Account Number', NULL, 7, 7, NULL, 56)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (54, N'Account Number', N'Pin code', NULL, 7, 7, NULL, 57)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (55, N'Account Number', N'ID Card Number', NULL, 7, 11, NULL, 58)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (56, N'Account Number', N'ID Card Number', NULL, 7, 11, NULL, 59)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (57, N'Customer id', N'Pin code', NULL, 7, 7, NULL, 60)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (58, N'Customer code', N'PIN', NULL, 7, 7, NULL, 61)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (59, N'Customer Code (CIF Code)', N'Date Of Birth', NULL, 7, 10, NULL, 62)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (62, N'ID Card PIN', N'Agreement Number', NULL, 7, 7, NULL, 65)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (63, N'Loan contract number', N'PIN-code of ID / serial and number (for other documents)', NULL, 15, 10, NULL, 66)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (64, N'VÖEN', NULL, NULL, 7, NULL, NULL, 67)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (65, N'VÖEN', NULL, NULL, 7, NULL, NULL, 68)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (66, N'VÖEN', NULL, NULL, 7, NULL, NULL, 69)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (68, N'Telefon nömrəsi', NULL, NULL, 10, NULL, NULL, 72)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (71, N'Müştəri kodu', NULL, NULL, 7, NULL, NULL, 75)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (74, N'Номер телефона', NULL, NULL, 10, NULL, NULL, 81)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (75, N'Код клиента', NULL, NULL, 7, NULL, NULL, 84)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (76, N'Phone Number', NULL, NULL, 10, NULL, NULL, 90)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (77, N'Customer Code', NULL, NULL, 7, NULL, NULL, 93)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (78, N'Telefon nömrəsi', NULL, NULL, 10, NULL, NULL, 99)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (79, N'Telefon nömrəsi', NULL, NULL, 10, NULL, NULL, 100)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (80, N'Nömrə', NULL, NULL, 7, NULL, NULL, 101)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (81, N'Telefon nömrəsi', NULL, NULL, 10, NULL, NULL, 102)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (83, N'Номер телефона', NULL, NULL, 10, NULL, NULL, 107)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (84, N'Номер телефона', NULL, NULL, 10, NULL, NULL, 108)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (85, N'Номер', NULL, NULL, 7, NULL, NULL, 109)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (86, N'Номер телефона', NULL, NULL, 10, NULL, NULL, 110)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (88, N'Phone Number', NULL, NULL, 10, NULL, NULL, 115)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (89, N'Phone Number', NULL, NULL, 10, NULL, NULL, 116)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (90, N'Number', NULL, NULL, 7, NULL, NULL, 117)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (91, N'Phone Number', NULL, NULL, 10, NULL, NULL, 118)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (93, N'Nömrə', NULL, NULL, 7, NULL, NULL, 121)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (94, N'Nömrə', NULL, NULL, 7, NULL, NULL, 122)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (96, N'Номер', NULL, NULL, 7, NULL, NULL, 124)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (97, N'Номер', NULL, NULL, 7, NULL, NULL, 125)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (99, N'Number', NULL, NULL, 7, NULL, NULL, 127)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (100, N'Number', NULL, NULL, 7, NULL, NULL, 128)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (102, N'E-mail', NULL, NULL, 45, NULL, NULL, 131)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (103, N'E-mail', NULL, NULL, 45, NULL, NULL, 132)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (104, N'E-mail', NULL, NULL, 45, NULL, NULL, 133)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (105, N'E-mail', NULL, NULL, 45, NULL, NULL, 135)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (106, N'E-mail', NULL, NULL, 45, NULL, NULL, 136)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (107, N'E-mail', NULL, NULL, 45, NULL, NULL, 137)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (108, N'E-mail', NULL, NULL, 45, NULL, NULL, 139)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (109, N'E-mail', NULL, NULL, 45, NULL, NULL, 140)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (110, N'E-mail', NULL, NULL, 45, NULL, NULL, 141)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (111, N'Nömrə', NULL, NULL, 7, NULL, NULL, 142)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (112, N'Nömrə', NULL, NULL, 7, NULL, NULL, 143)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (113, N'Номер', NULL, NULL, 7, NULL, NULL, 144)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (114, N'Номер', NULL, NULL, 7, NULL, NULL, 145)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (116, N'Number', NULL, NULL, 7, NULL, NULL, 146)
INSERT [dbo].[ProviderAdditionalInformations] ([Id], [InputText], [SecondaryInputText], [AdditionalInputText], [FirstInputValidLength], [SecondaryInputValidLength], [AdditionalInputValidLength], [GroupProviderId]) VALUES (117, N'Номер', NULL, NULL, 7, NULL, NULL, 147)
SET IDENTITY_INSERT [dbo].[ProviderAdditionalInformations] OFF
SET IDENTITY_INSERT [dbo].[ProviderCategories] ON 

INSERT [dbo].[ProviderCategories] ([Id], [Name]) VALUES (1, N'utility')
INSERT [dbo].[ProviderCategories] ([Id], [Name]) VALUES (2, N'mobile')
INSERT [dbo].[ProviderCategories] ([Id], [Name]) VALUES (3, N'bank')
INSERT [dbo].[ProviderCategories] ([Id], [Name]) VALUES (4, N'state')
INSERT [dbo].[ProviderCategories] ([Id], [Name]) VALUES (5, N'tv')
INSERT [dbo].[ProviderCategories] ([Id], [Name]) VALUES (6, N'internet')
INSERT [dbo].[ProviderCategories] ([Id], [Name]) VALUES (7, N'phone')
INSERT [dbo].[ProviderCategories] ([Id], [Name]) VALUES (8, N'Entertainment')
INSERT [dbo].[ProviderCategories] ([Id], [Name]) VALUES (9, N'e_wallet')
SET IDENTITY_INSERT [dbo].[ProviderCategories] OFF
SET IDENTITY_INSERT [dbo].[ProviderHeaderInfos] ON 

INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (1, N'communal.png', N'KOMMUNAL ÖDƏNİŞLƏR', 1)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (2, N'communal.png', N'КОММУНАЛНЫЕ ПЛАТЕЖИ', 10)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (3, N'communal.png', N'UTILITY PAYMENTS', 19)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (4, N'hand-with-smartphone-and-wireless-internet.png', N'MOBIL OPERATORLAR', 2)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (5, N'hand-with-smartphone-and-wireless-internet.png', N'МОБИЛЬНЫЕ ОПЕРАТОРЫ', 11)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (6, N'hand-with-smartphone-and-wireless-internet.png', N'MOBILE OPERATORS', 20)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (7, N'bill.png', N'BANK XIDMƏTLƏRI', 3)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (8, N'bill.png', N' Банковские услуги ', 12)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (9, N'bill.png', N'BANKING SERVICES', 21)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (10, N'university-with-a-flag.png', N'Dövlət və bələdiyyə', 4)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (11, N'university-with-a-flag.png', N'Государственные и муниципальные платежи', 13)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (12, N'university-with-a-flag.png', N'State and municipality payments ', 22)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (13, N'monitor.png', N'TV', 5)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (14, N'monitor.png', N'TВ', 14)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (15, N'monitor.png', N'TV', 23)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (16, N'Wifi.png', N'İnternet', 6)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (17, N'Wifi.png', N'Интернет', 15)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (18, N'Wifi.png', N'İnternet', 24)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (19, N'old-telephone-ringing.png', N'Telefon', 7)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (20, N'old-telephone-ringing.png', N'Tелефон', 16)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (21, N'old-telephone-ringing.png', N'Phone ', 25)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (22, N'gamepad.png', N'Əyləncə və oyunlar', 8)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (23, N'gamepad.png', N'Развлечения и игры', 17)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (24, N'gamepad.png', N'Entertainment and Games ', 26)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (25, N'wallet-filled-money-tool.png', N'E-pulqabı', 9)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (26, N'wallet-filled-money-tool.png', N' E-кошелек ', 18)
INSERT [dbo].[ProviderHeaderInfos] ([Id], [ImgPath], [Text], [CoreProviderId]) VALUES (27, N'wallet-filled-money-tool.png', N' E-Wallet ', 27)
SET IDENTITY_INSERT [dbo].[ProviderHeaderInfos] OFF
SET IDENTITY_INSERT [dbo].[ProviderOptions] ON 

INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1, N'Əhali ', N'Ödənişin növü', 1, 0, 1)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (2, N'Qeyri əhali ', N'Ödənişin növü', 1, 0, 1)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (4, N'Əhali ', N'Hesab növü', 1, 0, 2)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (5, N'Qeyri əhali ', N'Hesab növü', 1, 0, 2)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (6, N'Əhali ', N'Ödənişin növü', 1, 0, 3)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (7, N'Qeyri əhali ', N'Ödənişin növü', 1, 0, 3)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (14, N'Физические лица ', N'Tип оплаты', 1, 0, 5)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (15, N'Юридические лица ', N'Tип оплаты', 1, 0, 5)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (17, N'Физические лица ', N'Tип оплаты', 1, 0, 6)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (18, N'Юридические лица ', N'Tип оплаты', 1, 0, 6)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (21, N'Физические лица ', N'Tип оплаты', 1, 0, 7)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (22, N'Юридические лица ', N'Tип оплаты', 1, 0, 7)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (29, N'Residential ', N'Payment Type', 1, 0, 9)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (30, N'Commercial ', N'Payment Type', 1, 0, 9)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (32, N'Residential ', N'Account type', 1, 0, 10)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (33, N'Commercial ', N'Account type', 1, 0, 10)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (34, N'Residential ', N'Payment Type', 1, 0, 11)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (35, N'Commercial ', N'Payment Type', 1, 0, 11)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (42, N'050', N'Prefiks', 1, 0, 13)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (43, N'051', N'Prefiks', 1, 0, 13)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (44, N'055', N'Prefiks', 1, 0, 14)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (45, N'070', N'Prefiks', 1, 0, 15)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (46, N'077', N'Prefiks', 1, 0, 15)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (47, N'060', N'Prefiks', 1, 0, 16)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (48, N'050', N'Префикс', 1, 0, 17)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (49, N'051', N'Префикс', 1, 0, 17)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (50, N'055', N'Префикс', 1, 0, 18)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (51, N'070', N'Префикс', 1, 0, 19)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (52, N'077', N'Префикс', 1, 0, 19)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (53, N'060', N'Префикс', 1, 0, 20)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (54, N'050', N'Prefix', 1, 0, 21)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (55, N'051', N'Prefix', 1, 0, 21)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (56, N'055', N'Prefix', 1, 0, 22)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (57, N'070', N'Prefix', 1, 0, 23)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (58, N'077', N'Prefix', 1, 0, 23)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (59, N'060', N'Prefix', 1, 0, 24)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (66, N'Rusum ve Vergi odenishleri', N'Xidmət növü', 1, 0, 67)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (67, N'Inzibati cerime odenishleri', N'Xidmət növü', 1, 0, 67)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (68, N'VÖEN ilə axtarış ', N'İdentifikatsiya növü', 0, 1, 67)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (69, N'Налоги', N'Тип обслуживания', 1, 0, 68)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (70, N'Административные штрафы', N'Тип обслуживания', 1, 0, 68)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (71, N'Поиск по ИНН', N'Тип идентификации', 0, 1, 68)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (72, N'Taxes', N'Service type', 1, 0, 69)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (73, N'Administrative penalties', N'Service Type', 1, 0, 69)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (74, N'Search by TIN', N'Identification type', 0, 1, 69)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1491, N'Dr-Web-Antivirus-1-key-1-PC-on-12-month ', N'Servis', 1, 0, 131)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1492, N'Dr. Web Antivirus - 1 key 1 PC on 6 month ', N'Servis', 1, 0, 131)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1493, N'Dr. Web Antivirus - 1 key 1 PC on 3 month ', N'Servis', 1, 0, 131)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1494, N'Dr.Web Security Space - 1 key 1 PC on 12 month ', N'Servis', 1, 0, 131)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1495, N'Dr.Web Security Space - 1 key 1 PC on 6 month ', N'Servis', 1, 0, 131)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1496, N'Dr.Web Security Space - 1 key 1 PC on 3 month ', N'Servis', 1, 0, 131)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1497, N'Eset Nod32 Smart Security - 1 key 3 PC on 12 month ', N'Servis', 1, 0, 132)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1498, N'Eset Nod32 Smart Security - 1 key 3 PC on 6 month ', N'Servis', 1, 0, 132)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1499, N'Eset Nod32 Smart Security - 1 key 3 PC on 3 month ', N'Servis', 1, 0, 132)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1500, N'Eset Nod32 Antivirus - 1 key 3 PC on 12 month ', N'Servis', 1, 0, 132)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1501, N'Eset Nod32 Antivirus - 1 key 3 PC on 6 month ', N'Servis', 1, 0, 132)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1502, N'Eset Nod32 Antivirus - 1 key  3 PC on 3 month ', N'Servis', 1, 0, 132)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1503, N'Kaspersky Internet Security 2 PC / 12 M ', N'Servis', 1, 0, 133)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1504, N'Kaspersky Internet Security Renewal 2 PC / 12 M ', N'Servis', 1, 0, 133)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1505, N'Kaspersky Anti-Virus 2 PC / 12 M ', N'Servis', 1, 0, 133)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1506, N'Kaspersky Anti-Virus Renewal 2 PC / 12 M ', N'Servis', 1, 0, 133)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1507, N'Dr. Web Antivirus - 1 key 1 PC on 12 month ', N'Услуга', 1, 0, 135)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1508, N'Dr. Web Antivirus - 1 key 1 PC on 6 month ', N'Услуга', 1, 0, 135)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1509, N'Dr. Web Antivirus - 1 key 1 PC on 3 month ', N'Услуга', 1, 0, 135)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1510, N'Dr.Web Security Space - 1 key 1 PC on 12 month ', N'Услуга', 1, 0, 135)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1511, N'Dr.Web Security Space - 1 key 1 PC on 6 month ', N'Услуга', 1, 0, 135)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1512, N'Dr.Web Security Space - 1 key 1 PC on 3 month ', N'Услуга', 1, 0, 135)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1513, N'Eset Nod32 Smart Security - 1 key 3 PC on 12 month ', N'Услуга', 1, 0, 136)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1514, N'Eset Nod32 Smart Security - 1 key 3 PC on 6 month ', N'Услуга', 1, 0, 136)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1515, N'Eset Nod32 Smart Security - 1 key 3 PC on 3 month ', N'Услуга', 1, 0, 136)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1516, N'Eset Nod32 Antivirus - 1 key 3 PC on 12 month ', N'Услуга', 1, 0, 136)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1517, N'Eset Nod32 Antivirus - 1 key 3 PC on 6 month ', N'Услуга', 1, 0, 136)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1518, N'Eset Nod32 Antivirus - 1 key  3 PC on 3 month ', N'Услуга', 1, 0, 136)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1519, N'Kaspersky Internet Security 2 PC / 12 M ', N'Услуга', 1, 0, 137)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1520, N'Kaspersky Internet Security Renewal 2 PC / 12 M ', N'Услуга', 1, 0, 137)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1521, N'Kaspersky Anti-Virus 2 PC / 12 M ', N'Услуга', 1, 0, 137)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1522, N'Kaspersky Anti-Virus Renewal 2 PC / 12 M ', N'Услуга', 1, 0, 137)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1523, N'Dr. Web Antivirus - 1 key 1 PC on 12 month ', N'Service', 1, 0, 139)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1524, N'Dr. Web Antivirus - 1 key 1 PC on 6 month ', N'Service', 1, 0, 139)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1525, N'Dr. Web Antivirus - 1 key 1 PC on 3 month ', N'Service', 1, 0, 139)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1526, N'Dr.Web Security Space - 1 key 1 PC on 12 month ', N'Service', 1, 0, 139)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1527, N'Dr.Web Security Space - 1 key 1 PC on 6 month ', N'Service', 1, 0, 139)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1528, N'Dr.Web Security Space - 1 key 1 PC on 3 month ', N'Service', 1, 0, 139)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1529, N'Eset Nod32 Smart Security - 1 key 3 PC on 12 month ', N'Service', 1, 0, 140)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1530, N'Eset Nod32 Smart Security - 1 key 3 PC on 6 month ', N'Service', 1, 0, 140)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1531, N'Eset Nod32 Smart Security - 1 key 3 PC on 3 month ', N'Service', 1, 0, 140)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1532, N'Eset Nod32 Antivirus - 1 key 3 PC on 12 month ', N'Service', 1, 0, 140)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1533, N'Eset Nod32 Antivirus - 1 key 3 PC on 6 month ', N'Service', 1, 0, 140)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1534, N'Eset Nod32 Antivirus - 1 key  3 PC on 3 month ', N'Service', 1, 0, 140)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1535, N'Kaspersky Internet Security 2 PC / 12 M ', N'Service', 1, 0, 141)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1536, N'Kaspersky Internet Security Renewal 2 PC / 12 M ', N'Service', 1, 0, 141)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1537, N'Kaspersky Anti-Virus 2 PC / 12 M ', N'Service', 1, 0, 141)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1538, N'Kaspersky Anti-Virus Renewal 2 PC / 12 M ', N'Service', 1, 0, 141)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1539, N'050', N'Prefiks', 1, 0, 142)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1540, N'051', N'Prefiks', 1, 0, 142)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1541, N'070', N'Prefiks', 1, 0, 142)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1542, N'077', N'Prefiks', 1, 0, 142)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1543, N'055', N'Prefiks', 1, 0, 142)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1544, N'060', N'Prefiks', 1, 0, 142)
GO
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1545, N'050', N'Префикс', 1, 0, 144)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1546, N'051', N'Префикс', 1, 0, 144)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1547, N'070', N'Префикс', 1, 0, 144)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1548, N'077', N'Префикс', 1, 0, 144)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1549, N'055', N'Префикс', 1, 0, 144)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1550, N'060', N'Префикс', 1, 0, 144)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1551, N'050', N'Prefix', 1, 0, 146)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1552, N'051', N'Prefix', 1, 0, 146)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1553, N'070', N'Prefix', 1, 0, 146)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1554, N'077', N'Prefix', 1, 0, 146)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1555, N'055', N'Prefix', 1, 0, 146)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1556, N'060', N'Prefix', 1, 0, 146)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1557, N'050', N'Prefiks', 1, 0, 143)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1558, N'051', N'Prefiks', 1, 0, 143)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1559, N'070', N'Prefiks', 1, 0, 143)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1560, N'077', N'Prefiks', 1, 0, 143)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1561, N'055', N'Prefiks', 1, 0, 143)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1562, N'060', N'Prefiks', 1, 0, 143)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1563, N'050', N'Префикс', 1, 0, 145)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1564, N'051', N'Префикс', 1, 0, 145)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1565, N'070', N'Префикс', 1, 0, 145)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1566, N'077', N'Префикс', 1, 0, 145)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1567, N'055', N'Префикс', 1, 0, 145)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1568, N'060', N'Префикс', 1, 0, 145)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1569, N'050', N'Prefix', 1, 0, 147)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1570, N'051', N'Prefix', 1, 0, 147)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1571, N'070', N'Prefix', 1, 0, 147)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1572, N'077', N'Prefix', 1, 0, 147)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1573, N'055', N'Prefix', 1, 0, 147)
INSERT [dbo].[ProviderOptions] ([Id], [Text], [LabelText], [IsFirstOption], [IsSecondaryOption], [GroupProviderId]) VALUES (1574, N'060', N'Prefix', 1, 0, 147)
SET IDENTITY_INSERT [dbo].[ProviderOptions] OFF
SET IDENTITY_INSERT [dbo].[TopProviders] ON 

INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (2, N'a', N'rgb(29,135,198)', N'AZERSU logo.png', 2, 1, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (3, N'a', N'rgb(192, 178, 250)', N'Azercell_logo.png', 13, 1, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (4, N'a', N'rgb(257,77,97)', N'bakcell.png', 14, 1, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (5, N'a', N'rgb(176, 4, 62)', N'230x96narlogo.png', 15, 1, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (6, N'a', N'rgb(193, 188, 36)', N'bes.png', 3, 1, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (9, N'a', N'rgb(29,135,198)', N'AZERSU logo.png', 6, 2, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (10, N'a', N'rgb(192, 178, 250)', N'Azercell_logo.png', 17, 2, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (11, N'a', N'rgb(257,77,97)', N'bakcell.png', 18, 2, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (12, N'a', N'rgb(176, 4, 62)', N'230x96narlogo.png', 19, 2, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (13, N'a', N'rgb(193, 188, 36)', N'bes.png', 7, 2, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (16, N'a', N'rgb(29,135,198)', N'AZERSU logo.png', 10, 3, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (17, N'a', N'rgb(192, 178, 250)', N'Azercell_logo.png', 21, 3, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (18, N'a', N'rgb(257,77,97)', N'bakcell.png', 22, 3, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (19, N'a', N'rgb(176, 4, 62)', N'230x96narlogo.png', 23, 3, NULL)
INSERT [dbo].[TopProviders] ([Id], [TagName], [BackColor], [ImagePath], [DataId], [LangId], [LanguageConfigurationId]) VALUES (20, N'a', N'rgb(193, 188, 36)', N'bes.png', 11, 3, NULL)
SET IDENTITY_INSERT [dbo].[TopProviders] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 16.02.2019 17:26:56 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 16.02.2019 17:26:56 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CoreProviders_LanguageConfigurationId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_CoreProviders_LanguageConfigurationId] ON [dbo].[CoreProviders]
(
	[LanguageConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FooterInfos_LanguageConfigurationId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_FooterInfos_LanguageConfigurationId] ON [dbo].[FooterInfos]
(
	[LanguageConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GroupProviderPageButtonTexts_LanguageConfigurationId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_GroupProviderPageButtonTexts_LanguageConfigurationId] ON [dbo].[GroupProviderPageButtonTexts]
(
	[LanguageConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GroupProviders_CoreProviderId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_GroupProviders_CoreProviderId] ON [dbo].[GroupProviders]
(
	[CoreProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GroupProviders_ProviderCategoryId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_GroupProviders_ProviderCategoryId] ON [dbo].[GroupProviders]
(
	[ProviderCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HomeButtonTexts_LanguageConfigurationId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_HomeButtonTexts_LanguageConfigurationId] ON [dbo].[HomeButtonTexts]
(
	[LanguageConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_IndexPhotos_LanguageConfigurationId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_IndexPhotos_LanguageConfigurationId] ON [dbo].[IndexPhotos]
(
	[LanguageConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProviderAdditionalInformations_GroupProviderId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_ProviderAdditionalInformations_GroupProviderId] ON [dbo].[ProviderAdditionalInformations]
(
	[GroupProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProviderHeaderInfos_CoreProviderId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_ProviderHeaderInfos_CoreProviderId] ON [dbo].[ProviderHeaderInfos]
(
	[CoreProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProviderOptions_GroupProviderId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_ProviderOptions_GroupProviderId] ON [dbo].[ProviderOptions]
(
	[GroupProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TopProviders_LanguageConfigurationId]    Script Date: 16.02.2019 17:26:56 ******/
CREATE NONCLUSTERED INDEX [IX_TopProviders_LanguageConfigurationId] ON [dbo].[TopProviders]
(
	[LanguageConfigurationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GroupProviders] ADD  DEFAULT (N'True') FOR [ProviderName]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[CoreProviders]  WITH CHECK ADD  CONSTRAINT [FK_CoreProviders_LanguageConfigurations_LanguageConfigurationId] FOREIGN KEY([LanguageConfigurationId])
REFERENCES [dbo].[LanguageConfigurations] ([Id])
GO
ALTER TABLE [dbo].[CoreProviders] CHECK CONSTRAINT [FK_CoreProviders_LanguageConfigurations_LanguageConfigurationId]
GO
ALTER TABLE [dbo].[FooterInfos]  WITH CHECK ADD  CONSTRAINT [FK_FooterInfos_LanguageConfigurations_LanguageConfigurationId] FOREIGN KEY([LanguageConfigurationId])
REFERENCES [dbo].[LanguageConfigurations] ([Id])
GO
ALTER TABLE [dbo].[FooterInfos] CHECK CONSTRAINT [FK_FooterInfos_LanguageConfigurations_LanguageConfigurationId]
GO
ALTER TABLE [dbo].[GroupProviderPageButtonTexts]  WITH CHECK ADD  CONSTRAINT [FK_GroupProviderPageButtonTexts_LanguageConfigurations_LanguageConfigurationId] FOREIGN KEY([LanguageConfigurationId])
REFERENCES [dbo].[LanguageConfigurations] ([Id])
GO
ALTER TABLE [dbo].[GroupProviderPageButtonTexts] CHECK CONSTRAINT [FK_GroupProviderPageButtonTexts_LanguageConfigurations_LanguageConfigurationId]
GO
ALTER TABLE [dbo].[GroupProviders]  WITH CHECK ADD  CONSTRAINT [FK_GroupProviders_CoreProviders_CoreProviderId] FOREIGN KEY([CoreProviderId])
REFERENCES [dbo].[CoreProviders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GroupProviders] CHECK CONSTRAINT [FK_GroupProviders_CoreProviders_CoreProviderId]
GO
ALTER TABLE [dbo].[GroupProviders]  WITH CHECK ADD  CONSTRAINT [FK_GroupProviders_ProviderCategories_ProviderCategoryId] FOREIGN KEY([ProviderCategoryId])
REFERENCES [dbo].[ProviderCategories] ([Id])
GO
ALTER TABLE [dbo].[GroupProviders] CHECK CONSTRAINT [FK_GroupProviders_ProviderCategories_ProviderCategoryId]
GO
ALTER TABLE [dbo].[HomeButtonTexts]  WITH CHECK ADD  CONSTRAINT [FK_HomeButtonTexts_LanguageConfigurations_LanguageConfigurationId] FOREIGN KEY([LanguageConfigurationId])
REFERENCES [dbo].[LanguageConfigurations] ([Id])
GO
ALTER TABLE [dbo].[HomeButtonTexts] CHECK CONSTRAINT [FK_HomeButtonTexts_LanguageConfigurations_LanguageConfigurationId]
GO
ALTER TABLE [dbo].[IndexPhotos]  WITH CHECK ADD  CONSTRAINT [FK_IndexPhotos_LanguageConfigurations_LanguageConfigurationId] FOREIGN KEY([LanguageConfigurationId])
REFERENCES [dbo].[LanguageConfigurations] ([Id])
GO
ALTER TABLE [dbo].[IndexPhotos] CHECK CONSTRAINT [FK_IndexPhotos_LanguageConfigurations_LanguageConfigurationId]
GO
ALTER TABLE [dbo].[ProviderAdditionalInformations]  WITH CHECK ADD  CONSTRAINT [FK_ProviderAdditionalInformations_GroupProviders_GroupProviderId] FOREIGN KEY([GroupProviderId])
REFERENCES [dbo].[GroupProviders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProviderAdditionalInformations] CHECK CONSTRAINT [FK_ProviderAdditionalInformations_GroupProviders_GroupProviderId]
GO
ALTER TABLE [dbo].[ProviderHeaderInfos]  WITH CHECK ADD  CONSTRAINT [FK_ProviderHeaderInfos_CoreProviders_CoreProviderId] FOREIGN KEY([CoreProviderId])
REFERENCES [dbo].[CoreProviders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProviderHeaderInfos] CHECK CONSTRAINT [FK_ProviderHeaderInfos_CoreProviders_CoreProviderId]
GO
ALTER TABLE [dbo].[ProviderOptions]  WITH CHECK ADD  CONSTRAINT [FK_ProviderOptions_GroupProviders_GroupProviderId] FOREIGN KEY([GroupProviderId])
REFERENCES [dbo].[GroupProviders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProviderOptions] CHECK CONSTRAINT [FK_ProviderOptions_GroupProviders_GroupProviderId]
GO
ALTER TABLE [dbo].[TopProviders]  WITH CHECK ADD  CONSTRAINT [FK_TopProviders_LanguageConfigurations_LanguageConfigurationId] FOREIGN KEY([LanguageConfigurationId])
REFERENCES [dbo].[LanguageConfigurations] ([Id])
GO
ALTER TABLE [dbo].[TopProviders] CHECK CONSTRAINT [FK_TopProviders_LanguageConfigurations_LanguageConfigurationId]
GO
USE [master]
GO
ALTER DATABASE [ProviderDb] SET  READ_WRITE 
GO
