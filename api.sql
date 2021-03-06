USE [master]
GO
/****** Object:  Database [APIDb]    Script Date: 16.02.2019 17:27:42 ******/
CREATE DATABASE [APIDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'APIDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\APIDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'APIDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\APIDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [APIDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [APIDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [APIDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [APIDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [APIDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [APIDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [APIDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [APIDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [APIDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [APIDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [APIDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [APIDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [APIDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [APIDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [APIDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [APIDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [APIDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [APIDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [APIDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [APIDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [APIDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [APIDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [APIDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [APIDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [APIDb] SET RECOVERY FULL 
GO
ALTER DATABASE [APIDb] SET  MULTI_USER 
GO
ALTER DATABASE [APIDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [APIDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [APIDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [APIDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [APIDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'APIDb', N'ON'
GO
ALTER DATABASE [APIDb] SET QUERY_STORE = OFF
GO
USE [APIDb]
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
USE [APIDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16.02.2019 17:27:42 ******/
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
/****** Object:  Table [dbo].[AccessBanks]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccessBanks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [nvarchar](max) NOT NULL,
	[IdentityCardNumber] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_AccessBanks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlfanetTvs]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlfanetTvs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_AlfanetTvs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AtaBanks]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AtaBanks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerCode] [nvarchar](max) NOT NULL,
	[LoanAccountNumber] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_AtaBanks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Avirtels]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avirtels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_Avirtels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Azercells]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Azercells](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[PrefixId] [int] NOT NULL,
 CONSTRAINT [PK_Azercells] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AzerIshiqs]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AzerIshiqs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AbonentCode] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[UtilityPrefixId] [int] NOT NULL,
 CONSTRAINT [PK_AzerIshiqs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AzeriQazes]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AzeriQazes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AbonentCode] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[UtilityPrefixId] [int] NOT NULL,
 CONSTRAINT [PK_AzeriQazes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AzerOnlines]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AzerOnlines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_AzerOnlines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AzerPays]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AzerPays](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[PrefixId] [int] NOT NULL,
 CONSTRAINT [PK_AzerPays] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AzerSus]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AzerSus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AbonentCode] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[UtilityPrefixId] [int] NOT NULL,
 CONSTRAINT [PK_AzerSus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AzerTurkBanks]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AzerTurkBanks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [nvarchar](max) NOT NULL,
	[PinCode] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_AzerTurkBanks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AzeuroTelPhones]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AzeuroTelPhones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_AzeuroTelPhones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AzeuroTels]    Script Date: 16.02.2019 17:27:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AzeuroTels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_AzeuroTels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Azincoms]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Azincoms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_Azincoms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bakcells]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bakcells](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[PrefixId] [int] NOT NULL,
 CONSTRAINT [PK_Bakcells] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankOfBakus]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankOfBakus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [nvarchar](max) NOT NULL,
	[CardNumberId] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_BankOfBakus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankRespublikas]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankRespublikas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [nvarchar](max) NOT NULL,
	[CardNumberId] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_BankRespublikas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Catels]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_Catels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClipTvs]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClipTvs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_ClipTvs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DrWebs]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrWebs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[EntertainmentPrefixId] [int] NOT NULL,
 CONSTRAINT [PK_DrWebs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpressBanks]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpressBanks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [nvarchar](max) NOT NULL,
	[PinCode] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_ExpressBanks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntertainmentPrefixes]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntertainmentPrefixes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
	[LangConfigId] [int] NOT NULL,
 CONSTRAINT [PK_EntertainmentPrefixes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Esets]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Esets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[EntertainmentPrefixId] [int] NOT NULL,
 CONSTRAINT [PK_Esets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XalqBanks]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XalqBanks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoanContractNumber] [nvarchar](max) NOT NULL,
	[PinCodeSerialNumber] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_XalqBanks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Irshads]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Irshads](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerCode] [nvarchar](max) NOT NULL,
	[PIN] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_Irshads] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KapitalBanks]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KapitalBanks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerCode] [nvarchar](max) NOT NULL,
	[DateOfBirth] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_KapitalBanks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kasperskies]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kasperskies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[EntertainmentPrefixId] [int] NOT NULL,
 CONSTRAINT [PK_Kasperskies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LangConfigs]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LangConfigs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LangName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_LangConfigs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Naxtels]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Naxtels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[PrefixId] [int] NOT NULL,
 CONSTRAINT [PK_Naxtels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nars]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[PrefixId] [int] NOT NULL,
 CONSTRAINT [PK_Nars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PortManats]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PortManats](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[PrefixId] [int] NOT NULL,
 CONSTRAINT [PK_PortManats] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prefix]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prefix](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PrefixValue] [nvarchar](max) NOT NULL,
	[LangConfigId] [int] NOT NULL,
 CONSTRAINT [PK_Prefix] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatePrefixes]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatePrefixes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PrefixValue] [nvarchar](max) NOT NULL,
	[LangConfigId] [int] NOT NULL,
 CONSTRAINT [PK_StatePrefixes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UniBanks]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UniBanks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CardPinId] [nvarchar](max) NOT NULL,
	[AgreementNumber] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_UniBanks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UtilityPrefixes]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UtilityPrefixes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PrefixValue] [nvarchar](max) NOT NULL,
	[LangConfigId] [int] NOT NULL,
 CONSTRAINT [PK_UtilityPrefixes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vns]    Script Date: 16.02.2019 17:27:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VOEN] [nvarchar](max) NOT NULL,
	[User] [nvarchar](max) NOT NULL,
	[Balance] [decimal](8, 2) NOT NULL,
	[StatePrefixId] [int] NOT NULL,
 CONSTRAINT [PK_Vns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190214121748_Initial', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190214141836_prefixesAdded', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190214142040_stateAdded', N'2.2.0-rtm-35687')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190214142147_stateAdded2', N'2.2.0-rtm-35687')
SET IDENTITY_INSERT [dbo].[AccessBanks] ON 

INSERT [dbo].[AccessBanks] ([Id], [CustomerId], [IdentityCardNumber], [User], [Balance]) VALUES (1, N'4785146', N'1478', N'asfd', CAST(0.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[AccessBanks] OFF
SET IDENTITY_INSERT [dbo].[AlfanetTvs] ON 

INSERT [dbo].[AlfanetTvs] ([Id], [Number], [User], [Balance]) VALUES (1, N'1548464874', N'ddf', CAST(25.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[AlfanetTvs] OFF
SET IDENTITY_INSERT [dbo].[AtaBanks] ON 

INSERT [dbo].[AtaBanks] ([Id], [CustomerCode], [LoanAccountNumber], [User], [Balance]) VALUES (1, N'7994512', N'1254783', N'fesghbgfb0', CAST(12.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[AtaBanks] OFF
SET IDENTITY_INSERT [dbo].[Avirtels] ON 

INSERT [dbo].[Avirtels] ([Id], [Number], [User], [Balance]) VALUES (1, N'4447788551', N'ewfer', CAST(44.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Avirtels] OFF
SET IDENTITY_INSERT [dbo].[Azercells] ON 

INSERT [dbo].[Azercells] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (1, N'8745142', N'ghj', CAST(0.74 AS Decimal(8, 2)), 1)
INSERT [dbo].[Azercells] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (2, N'4881354', N'vbnm', CAST(0.14 AS Decimal(8, 2)), 2)
INSERT [dbo].[Azercells] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (3, N'5464007', N'hghvh', CAST(1.20 AS Decimal(8, 2)), 7)
INSERT [dbo].[Azercells] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (4, N'5463898', N'hfwefvgh', CAST(0.00 AS Decimal(8, 2)), 8)
INSERT [dbo].[Azercells] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (6, N'7851641', N'bvsvcn', CAST(0.55 AS Decimal(8, 2)), 13)
INSERT [dbo].[Azercells] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (7, N'4784645', N'jyfthvgv', CAST(0.74 AS Decimal(8, 2)), 14)
SET IDENTITY_INSERT [dbo].[Azercells] OFF
SET IDENTITY_INSERT [dbo].[AzerIshiqs] ON 

INSERT [dbo].[AzerIshiqs] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (1, N'47258945671', N'asad', CAST(5.00 AS Decimal(8, 2)), 5)
INSERT [dbo].[AzerIshiqs] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (2, N'57984651315', N'dsfg', CAST(0.00 AS Decimal(8, 2)), 6)
INSERT [dbo].[AzerIshiqs] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (3, N'47258945671', N'fdg', CAST(5.00 AS Decimal(8, 2)), 3)
INSERT [dbo].[AzerIshiqs] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (5, N'57984651315', N'sdfgh', CAST(0.00 AS Decimal(8, 2)), 4)
INSERT [dbo].[AzerIshiqs] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (6, N'47258945671', N'fdgfg', CAST(5.00 AS Decimal(8, 2)), 1)
INSERT [dbo].[AzerIshiqs] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (7, N'57984651315', N'gffgd', CAST(0.00 AS Decimal(8, 2)), 2)
SET IDENTITY_INSERT [dbo].[AzerIshiqs] OFF
SET IDENTITY_INSERT [dbo].[AzeriQazes] ON 

INSERT [dbo].[AzeriQazes] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (1, N'123456789415236', N'efrtgrs', CAST(0.00 AS Decimal(8, 2)), 1)
INSERT [dbo].[AzeriQazes] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (2, N'444444445751648', N'efger', CAST(1.00 AS Decimal(8, 2)), 2)
INSERT [dbo].[AzeriQazes] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (3, N'123456789415236', N'khukg', CAST(0.00 AS Decimal(8, 2)), 3)
INSERT [dbo].[AzeriQazes] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (4, N'444444445751648', N'dgsrg', CAST(1.00 AS Decimal(8, 2)), 4)
INSERT [dbo].[AzeriQazes] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (5, N'123456789415236', N'bfjhgcfuy', CAST(0.00 AS Decimal(8, 2)), 5)
INSERT [dbo].[AzeriQazes] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (6, N'444444445751648', N'klkjhgkr', CAST(1.00 AS Decimal(8, 2)), 6)
SET IDENTITY_INSERT [dbo].[AzeriQazes] OFF
SET IDENTITY_INSERT [dbo].[AzerOnlines] ON 

INSERT [dbo].[AzerOnlines] ([Id], [Number], [User], [Balance]) VALUES (1, N'1201201478', N'ewrw', CAST(4.22 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[AzerOnlines] OFF
SET IDENTITY_INSERT [dbo].[AzerPays] ON 

INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (1, N'4758787', N'lehdsj', CAST(10.00 AS Decimal(8, 2)), 1)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (2, N'5998975', N'bjvhg', CAST(0.00 AS Decimal(8, 2)), 2)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (3, N'4795133', N'jhuyg', CAST(11.00 AS Decimal(8, 2)), 3)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (6, N'1545512', N'khfvh j', CAST(4.00 AS Decimal(8, 2)), 4)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (7, N'3463213', N'khfuvhj', CAST(10.00 AS Decimal(8, 2)), 5)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (8, N'7165343', N'mnvjhm', CAST(30.00 AS Decimal(8, 2)), 6)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (9, N'4758787', N'hjvuyb', CAST(10.00 AS Decimal(8, 2)), 7)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (10, N'5998975', N'jhvb', CAST(0.00 AS Decimal(8, 2)), 8)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (11, N'4795133', N'hv ', CAST(11.00 AS Decimal(8, 2)), 9)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (12, N'1545512', N'jhvj ', CAST(4.00 AS Decimal(8, 2)), 10)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (13, N'3463213', N'kjvjbjh ', CAST(10.00 AS Decimal(8, 2)), 11)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (14, N'7165343', N'k.kn', CAST(30.00 AS Decimal(8, 2)), 12)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (15, N'4758787', N'mv', CAST(10.00 AS Decimal(8, 2)), 13)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (16, N'5998975', N'gngh', CAST(0.00 AS Decimal(8, 2)), 14)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (17, N'4795133', N'hgfh', CAST(11.00 AS Decimal(8, 2)), 15)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (18, N'1545512', N'jhv', CAST(4.00 AS Decimal(8, 2)), 16)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (19, N'3463213', N'mnvn', CAST(10.00 AS Decimal(8, 2)), 17)
INSERT [dbo].[AzerPays] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (20, N'7165343', N'mhvuhj', CAST(30.00 AS Decimal(8, 2)), 18)
SET IDENTITY_INSERT [dbo].[AzerPays] OFF
SET IDENTITY_INSERT [dbo].[AzerSus] ON 

INSERT [dbo].[AzerSus] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (1, N'1234567894152', N'fgsehtrf', CAST(1.00 AS Decimal(8, 2)), 1)
INSERT [dbo].[AzerSus] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (2, N'2498351649724', N'dfdhrg', CAST(2.00 AS Decimal(8, 2)), 2)
INSERT [dbo].[AzerSus] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (3, N'1234567894152', N'sdggdrh', CAST(1.00 AS Decimal(8, 2)), 3)
INSERT [dbo].[AzerSus] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (4, N'2498351649724', N'khegkh', CAST(2.00 AS Decimal(8, 2)), 4)
INSERT [dbo].[AzerSus] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (5, N'1234567894152', N'dgfg', CAST(1.00 AS Decimal(8, 2)), 5)
INSERT [dbo].[AzerSus] ([Id], [AbonentCode], [User], [Balance], [UtilityPrefixId]) VALUES (6, N'2498351649724', N'hffhg', CAST(2.00 AS Decimal(8, 2)), 6)
SET IDENTITY_INSERT [dbo].[AzerSus] OFF
SET IDENTITY_INSERT [dbo].[AzerTurkBanks] ON 

INSERT [dbo].[AzerTurkBanks] ([Id], [AccountNumber], [PinCode], [User], [Balance]) VALUES (1, N'4561234', N'1122445', N'dfewsgh', CAST(120.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[AzerTurkBanks] OFF
SET IDENTITY_INSERT [dbo].[AzeuroTelPhones] ON 

INSERT [dbo].[AzeuroTelPhones] ([Id], [Number], [User], [Balance]) VALUES (1, N'8885471', N'refge', CAST(0.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[AzeuroTelPhones] OFF
SET IDENTITY_INSERT [dbo].[AzeuroTels] ON 

INSERT [dbo].[AzeuroTels] ([Id], [Number], [User], [Balance]) VALUES (1, N'1114785', N'ewfr', CAST(0.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[AzeuroTels] OFF
SET IDENTITY_INSERT [dbo].[Azincoms] ON 

INSERT [dbo].[Azincoms] ([Id], [Number], [User], [Balance]) VALUES (1, N'3486489744', N'ewfwefew', CAST(0.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Azincoms] OFF
SET IDENTITY_INSERT [dbo].[Bakcells] ON 

INSERT [dbo].[Bakcells] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (1, N'1458474', N'asvfdvw', CAST(2.54 AS Decimal(8, 2)), 5)
INSERT [dbo].[Bakcells] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (2, N'2486535', N'fedfbg', CAST(2.54 AS Decimal(8, 2)), 11)
INSERT [dbo].[Bakcells] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (3, N'2465123', N'sdshrd', CAST(2.54 AS Decimal(8, 2)), 17)
SET IDENTITY_INSERT [dbo].[Bakcells] OFF
SET IDENTITY_INSERT [dbo].[BankOfBakus] ON 

INSERT [dbo].[BankOfBakus] ([Id], [AccountNumber], [CardNumberId], [User], [Balance]) VALUES (1, N'2001475', N'11144485201', N'erhjtnhg', CAST(127.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[BankOfBakus] OFF
SET IDENTITY_INSERT [dbo].[BankRespublikas] ON 

INSERT [dbo].[BankRespublikas] ([Id], [AccountNumber], [CardNumberId], [User], [Balance]) VALUES (1, N'7894565', N'14555421369', N'segetbf', CAST(550.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[BankRespublikas] OFF
SET IDENTITY_INSERT [dbo].[Catels] ON 

INSERT [dbo].[Catels] ([Id], [Number], [User], [Balance]) VALUES (1, N'7856971', N'frd', CAST(0.44 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Catels] OFF
SET IDENTITY_INSERT [dbo].[ClipTvs] ON 

INSERT [dbo].[ClipTvs] ([Id], [Number], [User], [Balance]) VALUES (1, N'8885554', N'rwsfgdf', CAST(1.57 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[ClipTvs] OFF
SET IDENTITY_INSERT [dbo].[DrWebs] ON 

INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (2, N'sahin@gmail.com', N'asdfdf', CAST(0.54 AS Decimal(8, 2)), 1)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (3, N'test@gmail.com', N'dsffg', CAST(0.00 AS Decimal(8, 2)), 2)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (4, N'sgsgdf@gmail.com', N'saghb', CAST(0.55 AS Decimal(8, 2)), 3)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (5, N'efjghgfejb@gmail.com', N'fjrekg', CAST(50.00 AS Decimal(8, 2)), 4)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (6, N'fewg@gmail.com', N'wewfgweg', CAST(47.00 AS Decimal(8, 2)), 5)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (7, N'dsad@gmail.com', N'hsgf', CAST(14.00 AS Decimal(8, 2)), 6)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (8, N'sahin@gmail.com', N'fsedfdf', CAST(0.54 AS Decimal(8, 2)), 7)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (9, N'test@gmail.com', N'dgd', CAST(0.00 AS Decimal(8, 2)), 8)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (10, N'sgsgdf@gmail.com', N'sfvxc', CAST(0.55 AS Decimal(8, 2)), 9)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (11, N'efjghgfejb@gmail.com', N'sgdfvvfg', CAST(50.00 AS Decimal(8, 2)), 10)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (12, N'fewg@gmail.com', N'fsfd', CAST(47.00 AS Decimal(8, 2)), 11)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (13, N'dsad@gmail.com', N'fssfd', CAST(14.00 AS Decimal(8, 2)), 12)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (14, N'sahin@gmail.com', N'lekfgop', CAST(0.54 AS Decimal(8, 2)), 13)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (15, N'test@gmail.com', N'fsdfs', CAST(0.00 AS Decimal(8, 2)), 14)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (16, N'sgsgdf@gmail.com', N'fffdf', CAST(0.55 AS Decimal(8, 2)), 15)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (17, N'efjghgfejb@gmail.com', N'ddfdvsd', CAST(50.00 AS Decimal(8, 2)), 16)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (18, N'fewg@gmail.com', N'dfsfg', CAST(47.00 AS Decimal(8, 2)), 17)
INSERT [dbo].[DrWebs] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (19, N'dsad@gmail.com', N'dfgs', CAST(14.00 AS Decimal(8, 2)), 18)
SET IDENTITY_INSERT [dbo].[DrWebs] OFF
SET IDENTITY_INSERT [dbo].[ExpressBanks] ON 

INSERT [dbo].[ExpressBanks] ([Id], [CustomerId], [PinCode], [User], [Balance]) VALUES (1, N'1000200', N'1422214', N'emgwe', CAST(105.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[ExpressBanks] OFF
SET IDENTITY_INSERT [dbo].[EntertainmentPrefixes] ON 

INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (1, N'Dr-Web-Antivirus-1-key-1-PC-on-12-month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (2, N'Dr. Web Antivirus - 1 key 1 PC on 6 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (3, N'Dr. Web Antivirus - 1 key 1 PC on 3 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (4, N'Dr.Web Security Space - 1 key 1 PC on 12 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (5, N'Dr.Web Security Space - 1 key 1 PC on 6 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (6, N'Dr.Web Security Space - 1 key 1 PC on 3 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (7, N'Dr. Web Antivirus - 1 key 1 PC on 12 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (8, N'Dr. Web Antivirus - 1 key 1 PC on 6 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (9, N'Dr. Web Antivirus - 1 key 1 PC on 3 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (10, N'Dr.Web Security Space - 1 key 1 PC on 12 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (11, N'Dr.Web Security Space - 1 key 1 PC on 6 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (12, N'Dr.Web Security Space - 1 key 1 PC on 3 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (13, N'Dr. Web Antivirus - 1 key 1 PC on 12 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (14, N'Dr. Web Antivirus - 1 key 1 PC on 6 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (15, N'Dr. Web Antivirus - 1 key 1 PC on 3 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (16, N'Dr.Web Security Space - 1 key 1 PC on 12 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (17, N'Dr.Web Security Space - 1 key 1 PC on 6 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (18, N'Dr.Web Security Space - 1 key 1 PC on 3 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (19, N'Eset Nod32 Smart Security - 1 key 3 PC on 12 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (20, N'Eset Nod32 Smart Security - 1 key 3 PC on 6 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (21, N'Eset Nod32 Smart Security - 1 key 3 PC on 3 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (22, N'Eset Nod32 Antivirus - 1 key 3 PC on 12 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (23, N'Eset Nod32 Antivirus - 1 key 3 PC on 6 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (24, N'Eset Nod32 Antivirus - 1 key  3 PC on 3 month ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (25, N'Eset Nod32 Smart Security - 1 key 3 PC on 12 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (26, N'Eset Nod32 Smart Security - 1 key 3 PC on 6 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (27, N'Eset Nod32 Smart Security - 1 key 3 PC on 3 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (28, N'Eset Nod32 Antivirus - 1 key 3 PC on 12 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (29, N'Eset Nod32 Antivirus - 1 key 3 PC on 6 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (30, N'Eset Nod32 Antivirus - 1 key  3 PC on 3 month ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (31, N'Eset Nod32 Smart Security - 1 key 3 PC on 12 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (32, N'Eset Nod32 Smart Security - 1 key 3 PC on 6 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (33, N'Eset Nod32 Smart Security - 1 key 3 PC on 3 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (34, N'Eset Nod32 Antivirus - 1 key 3 PC on 12 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (35, N'Eset Nod32 Antivirus - 1 key 3 PC on 6 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (36, N'Eset Nod32 Antivirus - 1 key  3 PC on 3 month ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (37, N'Kaspersky Internet Security 2 PC / 12 M ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (38, N'Kaspersky Internet Security Renewal 2 PC / 12 M ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (39, N'Kaspersky Anti-Virus 2 PC / 12 M ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (40, N'Kaspersky Anti-Virus Renewal 2 PC / 12 M ', 1)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (41, N'Kaspersky Internet Security 2 PC / 12 M ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (42, N'Kaspersky Internet Security Renewal 2 PC / 12 M ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (43, N'Kaspersky Anti-Virus 2 PC / 12 M ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (44, N'Kaspersky Anti-Virus Renewal 2 PC / 12 M ', 2)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (45, N'Kaspersky Internet Security 2 PC / 12 M ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (46, N'Kaspersky Internet Security Renewal 2 PC / 12 M ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (47, N'Kaspersky Anti-Virus 2 PC / 12 M ', 3)
INSERT [dbo].[EntertainmentPrefixes] ([Id], [Value], [LangConfigId]) VALUES (48, N'Kaspersky Anti-Virus Renewal 2 PC / 12 M ', 3)
SET IDENTITY_INSERT [dbo].[EntertainmentPrefixes] OFF
SET IDENTITY_INSERT [dbo].[Esets] ON 

INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (2, N'sahdh@gmail.com', N'sfd', CAST(14.00 AS Decimal(8, 2)), 19)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (3, N'hah@gmail.com', N'jkdfger', CAST(10.00 AS Decimal(8, 2)), 20)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (4, N'ewfsd@gmail.com', N'jekwfg', CAST(14.00 AS Decimal(8, 2)), 21)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (5, N'fsd@gmail.com', N'hghf', CAST(5.00 AS Decimal(8, 2)), 22)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (6, N'df@gmail.com', N'efrg', CAST(1.00 AS Decimal(8, 2)), 23)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (7, N'asdfs@gmail.com', N'hejgfwv', CAST(68.00 AS Decimal(8, 2)), 24)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (8, N'sahdh@gmail.com', N'dasfs', CAST(14.00 AS Decimal(8, 2)), 25)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (9, N'hah@gmail.com', N'jkbdf', CAST(10.00 AS Decimal(8, 2)), 26)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (10, N'ewfsd@gmail.com', N'kvgv', CAST(14.00 AS Decimal(8, 2)), 27)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (11, N'fsd@gmail.com', N'jgjhyft', CAST(5.00 AS Decimal(8, 2)), 28)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (12, N'df@gmail.com', N'kgyjg', CAST(1.00 AS Decimal(8, 2)), 29)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (13, N'asdfs@gmail.com', N'kjguyv', CAST(68.00 AS Decimal(8, 2)), 30)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (14, N'sahdh@gmail.com', N'khfc', CAST(14.00 AS Decimal(8, 2)), 31)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (15, N'hah@gmail.com', N'hfhvh', CAST(10.00 AS Decimal(8, 2)), 32)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (16, N'ewfsd@gmail.com', N'jhbh', CAST(14.00 AS Decimal(8, 2)), 33)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (17, N'fsd@gmail.com', N'ihguhj', CAST(5.00 AS Decimal(8, 2)), 34)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (19, N'df@gmail.com', N'ugbjm', CAST(1.00 AS Decimal(8, 2)), 35)
INSERT [dbo].[Esets] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (20, N'asdfs@gmail.com', N'kugbjnm', CAST(68.00 AS Decimal(8, 2)), 36)
SET IDENTITY_INSERT [dbo].[Esets] OFF
SET IDENTITY_INSERT [dbo].[XalqBanks] ON 

INSERT [dbo].[XalqBanks] ([Id], [LoanContractNumber], [PinCodeSerialNumber], [User], [Balance]) VALUES (1, N'222244557894578', N'1447711447', N'wfeghfgd', CAST(0.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[XalqBanks] OFF
SET IDENTITY_INSERT [dbo].[Irshads] ON 

INSERT [dbo].[Irshads] ([Id], [CustomerCode], [PIN], [User], [Balance]) VALUES (1, N'1002489', N'4455667', N'rthgbfv', CAST(14.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Irshads] OFF
SET IDENTITY_INSERT [dbo].[KapitalBanks] ON 

INSERT [dbo].[KapitalBanks] ([Id], [CustomerCode], [DateOfBirth], [User], [Balance]) VALUES (1, N'8746534', N'1478520140', N'ukj', CAST(103.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[KapitalBanks] OFF
SET IDENTITY_INSERT [dbo].[Kasperskies] ON 

INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (1, N'ahsha@gmail.com', N'asdf', CAST(47.00 AS Decimal(8, 2)), 37)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (2, N'edfs@gmail.com', N'jhggsh', CAST(10.00 AS Decimal(8, 2)), 38)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (3, N'fhgjh@gmail.com', N'sfs', CAST(41.00 AS Decimal(8, 2)), 39)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (4, N'erjhg@gmail.com', N'hfsg', CAST(12.00 AS Decimal(8, 2)), 40)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (5, N'ahsha@gmail.com', N'jhuyg', CAST(47.00 AS Decimal(8, 2)), 41)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (6, N'edfs@gmail.com', N'jguyvhjb', CAST(10.00 AS Decimal(8, 2)), 42)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (7, N'fhgjh@gmail.com', N'jghjb', CAST(41.00 AS Decimal(8, 2)), 43)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (8, N'erjhg@gmail.com', N'jhuy', CAST(12.00 AS Decimal(8, 2)), 44)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (9, N'ahsha@gmail.com', N'jkgbhj', CAST(47.00 AS Decimal(8, 2)), 45)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (10, N'edfs@gmail.com', N'khgh', CAST(10.00 AS Decimal(8, 2)), 46)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (11, N'fhgjh@gmail.com', N'jgbh', CAST(41.00 AS Decimal(8, 2)), 47)
INSERT [dbo].[Kasperskies] ([Id], [Number], [User], [Balance], [EntertainmentPrefixId]) VALUES (12, N'erjhg@gmail.com', N'kjgjbh', CAST(12.00 AS Decimal(8, 2)), 48)
SET IDENTITY_INSERT [dbo].[Kasperskies] OFF
SET IDENTITY_INSERT [dbo].[LangConfigs] ON 

INSERT [dbo].[LangConfigs] ([Id], [LangName]) VALUES (1, N'Aze')
INSERT [dbo].[LangConfigs] ([Id], [LangName]) VALUES (2, N'Rus')
INSERT [dbo].[LangConfigs] ([Id], [LangName]) VALUES (3, N'Eng')
SET IDENTITY_INSERT [dbo].[LangConfigs] OFF
SET IDENTITY_INSERT [dbo].[Naxtels] ON 

INSERT [dbo].[Naxtels] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (1, N'8785631', N'dasd', CAST(5.47 AS Decimal(8, 2)), 6)
INSERT [dbo].[Naxtels] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (2, N'8785631', N'afsd', CAST(5.47 AS Decimal(8, 2)), 12)
INSERT [dbo].[Naxtels] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (3, N'8785631', N'adfs', CAST(5.47 AS Decimal(8, 2)), 18)
SET IDENTITY_INSERT [dbo].[Naxtels] OFF
SET IDENTITY_INSERT [dbo].[Nars] ON 

INSERT [dbo].[Nars] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (1, N'7545454', N'zdsda', CAST(0.00 AS Decimal(8, 2)), 3)
INSERT [dbo].[Nars] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (3, N'7813211', N'sfsfs', CAST(0.25 AS Decimal(8, 2)), 4)
INSERT [dbo].[Nars] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (4, N'7545454', N'asasa', CAST(0.00 AS Decimal(8, 2)), 9)
INSERT [dbo].[Nars] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (5, N'7813211', N'sdsd', CAST(0.25 AS Decimal(8, 2)), 10)
INSERT [dbo].[Nars] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (6, N'7545454', N'adada', CAST(0.00 AS Decimal(8, 2)), 15)
INSERT [dbo].[Nars] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (7, N'7813211', N'sdsxq', CAST(0.25 AS Decimal(8, 2)), 16)
SET IDENTITY_INSERT [dbo].[Nars] OFF
SET IDENTITY_INSERT [dbo].[PortManats] ON 

INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (1, N'4758787', N'vbjh', CAST(14.00 AS Decimal(8, 2)), 1)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (2, N'5998975', N'hbjvh', CAST(15.00 AS Decimal(8, 2)), 2)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (3, N'2546154', N'kjfygvhjmj', CAST(20.00 AS Decimal(8, 2)), 3)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (4, N'4684365', N'jhgjb ', CAST(13.00 AS Decimal(8, 2)), 4)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (5, N'8946513', N'yjfgu', CAST(0.00 AS Decimal(8, 2)), 5)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (6, N'2496355', N'kbjbhjb', CAST(0.00 AS Decimal(8, 2)), 6)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (7, N'4758787', N'lkub', CAST(14.00 AS Decimal(8, 2)), 7)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (8, N'5998975', N'ljik', CAST(15.00 AS Decimal(8, 2)), 8)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (10, N'2546154', N'kjg', CAST(20.00 AS Decimal(8, 2)), 9)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (11, N'4684365', N'ldljbfhb', CAST(13.00 AS Decimal(8, 2)), 10)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (12, N'8946513', N'kkunk', CAST(0.00 AS Decimal(8, 2)), 11)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (13, N'2496355', N'hhjbn', CAST(0.00 AS Decimal(8, 2)), 12)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (14, N'4758787', N'asfhvh', CAST(14.00 AS Decimal(8, 2)), 13)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (15, N'5998975', N'hjvh', CAST(15.00 AS Decimal(8, 2)), 14)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (16, N'2546154', N'mbhbm', CAST(20.00 AS Decimal(8, 2)), 15)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (17, N'4684365', N'jvhj', CAST(13.00 AS Decimal(8, 2)), 16)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (18, N'8946513', N'jbjhb', CAST(0.00 AS Decimal(8, 2)), 17)
INSERT [dbo].[PortManats] ([Id], [Number], [User], [Balance], [PrefixId]) VALUES (19, N'2496355', N'mhhjvbjh', CAST(0.00 AS Decimal(8, 2)), 18)
SET IDENTITY_INSERT [dbo].[PortManats] OFF
SET IDENTITY_INSERT [dbo].[Prefix] ON 

INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (1, N'051', 1)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (2, N'050', 1)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (3, N'070', 1)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (4, N'077', 1)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (5, N'055', 1)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (6, N'060', 1)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (7, N'050', 2)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (8, N'051', 2)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (9, N'077', 2)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (10, N'070', 2)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (11, N'055', 2)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (12, N'060', 2)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (13, N'051', 3)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (14, N'050', 3)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (15, N'070', 3)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (16, N'077', 3)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (17, N'055', 3)
INSERT [dbo].[Prefix] ([Id], [PrefixValue], [LangConfigId]) VALUES (18, N'060', 3)
SET IDENTITY_INSERT [dbo].[Prefix] OFF
SET IDENTITY_INSERT [dbo].[StatePrefixes] ON 

INSERT [dbo].[StatePrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (1, N'Rusum ve Vergi odenishleri', 1)
INSERT [dbo].[StatePrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (2, N'Inzibati cerime odenishleri', 1)
INSERT [dbo].[StatePrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (3, N'Налоги', 2)
INSERT [dbo].[StatePrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (4, N'Административные штрафы', 2)
INSERT [dbo].[StatePrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (5, N'Taxes', 3)
INSERT [dbo].[StatePrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (6, N'Administrative penalties', 3)
SET IDENTITY_INSERT [dbo].[StatePrefixes] OFF
SET IDENTITY_INSERT [dbo].[UniBanks] ON 

INSERT [dbo].[UniBanks] ([Id], [CardPinId], [AgreementNumber], [User], [Balance]) VALUES (1, N'8745647', N'0214547', N'rwgfdvc', CAST(250.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[UniBanks] OFF
SET IDENTITY_INSERT [dbo].[UtilityPrefixes] ON 

INSERT [dbo].[UtilityPrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (1, N'Residential', 3)
INSERT [dbo].[UtilityPrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (2, N'Commercial', 3)
INSERT [dbo].[UtilityPrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (3, N'Физические лица ', 2)
INSERT [dbo].[UtilityPrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (4, N'Юридические лица', 2)
INSERT [dbo].[UtilityPrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (5, N'Əhali', 1)
INSERT [dbo].[UtilityPrefixes] ([Id], [PrefixValue], [LangConfigId]) VALUES (6, N'Qeyri əhali ', 1)
SET IDENTITY_INSERT [dbo].[UtilityPrefixes] OFF
SET IDENTITY_INSERT [dbo].[Vns] ON 

INSERT [dbo].[Vns] ([Id], [VOEN], [User], [Balance], [StatePrefixId]) VALUES (2, N'4645634', N'DAF', CAST(1.57 AS Decimal(8, 2)), 1)
INSERT [dbo].[Vns] ([Id], [VOEN], [User], [Balance], [StatePrefixId]) VALUES (3, N'4681248', N'SFSDFD', CAST(7.55 AS Decimal(8, 2)), 2)
INSERT [dbo].[Vns] ([Id], [VOEN], [User], [Balance], [StatePrefixId]) VALUES (4, N'4645634', N'dfsdgvbsd', CAST(1.57 AS Decimal(8, 2)), 3)
INSERT [dbo].[Vns] ([Id], [VOEN], [User], [Balance], [StatePrefixId]) VALUES (5, N'4681248', N'svfdcjnm', CAST(7.55 AS Decimal(8, 2)), 4)
INSERT [dbo].[Vns] ([Id], [VOEN], [User], [Balance], [StatePrefixId]) VALUES (6, N'4645634', N'hjmbjh', CAST(1.57 AS Decimal(8, 2)), 5)
INSERT [dbo].[Vns] ([Id], [VOEN], [User], [Balance], [StatePrefixId]) VALUES (7, N'4681248', N'gsjhgshj', CAST(7.55 AS Decimal(8, 2)), 6)
SET IDENTITY_INSERT [dbo].[Vns] OFF
/****** Object:  Index [IX_Azercells_PrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_Azercells_PrefixId] ON [dbo].[Azercells]
(
	[PrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AzerIshiqs_UtilityPrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_AzerIshiqs_UtilityPrefixId] ON [dbo].[AzerIshiqs]
(
	[UtilityPrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AzeriQazes_UtilityPrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_AzeriQazes_UtilityPrefixId] ON [dbo].[AzeriQazes]
(
	[UtilityPrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AzerPays_PrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_AzerPays_PrefixId] ON [dbo].[AzerPays]
(
	[PrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AzerSus_UtilityPrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_AzerSus_UtilityPrefixId] ON [dbo].[AzerSus]
(
	[UtilityPrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Bakcells_PrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_Bakcells_PrefixId] ON [dbo].[Bakcells]
(
	[PrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DrWebs_EntertainmentPrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_DrWebs_EntertainmentPrefixId] ON [dbo].[DrWebs]
(
	[EntertainmentPrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EntertainmentPrefixes_LangConfigId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_EntertainmentPrefixes_LangConfigId] ON [dbo].[EntertainmentPrefixes]
(
	[LangConfigId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Esets_EntertainmentPrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_Esets_EntertainmentPrefixId] ON [dbo].[Esets]
(
	[EntertainmentPrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Kasperskies_EntertainmentPrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_Kasperskies_EntertainmentPrefixId] ON [dbo].[Kasperskies]
(
	[EntertainmentPrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Naxtels_PrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_Naxtels_PrefixId] ON [dbo].[Naxtels]
(
	[PrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Nars_PrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_Nars_PrefixId] ON [dbo].[Nars]
(
	[PrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PortManats_PrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_PortManats_PrefixId] ON [dbo].[PortManats]
(
	[PrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Prefix_LangConfigId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_Prefix_LangConfigId] ON [dbo].[Prefix]
(
	[LangConfigId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_StatePrefixes_LangConfigId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_StatePrefixes_LangConfigId] ON [dbo].[StatePrefixes]
(
	[LangConfigId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UtilityPrefixes_LangConfigId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_UtilityPrefixes_LangConfigId] ON [dbo].[UtilityPrefixes]
(
	[LangConfigId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Vns_StatePrefixId]    Script Date: 16.02.2019 17:27:43 ******/
CREATE NONCLUSTERED INDEX [IX_Vns_StatePrefixId] ON [dbo].[Vns]
(
	[StatePrefixId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Azercells]  WITH CHECK ADD  CONSTRAINT [FK_Azercells_Prefix_PrefixId] FOREIGN KEY([PrefixId])
REFERENCES [dbo].[Prefix] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Azercells] CHECK CONSTRAINT [FK_Azercells_Prefix_PrefixId]
GO
ALTER TABLE [dbo].[AzerIshiqs]  WITH CHECK ADD  CONSTRAINT [FK_AzerIshiqs_UtilityPrefixes_UtilityPrefixId] FOREIGN KEY([UtilityPrefixId])
REFERENCES [dbo].[UtilityPrefixes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AzerIshiqs] CHECK CONSTRAINT [FK_AzerIshiqs_UtilityPrefixes_UtilityPrefixId]
GO
ALTER TABLE [dbo].[AzeriQazes]  WITH CHECK ADD  CONSTRAINT [FK_AzeriQazes_UtilityPrefixes_UtilityPrefixId] FOREIGN KEY([UtilityPrefixId])
REFERENCES [dbo].[UtilityPrefixes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AzeriQazes] CHECK CONSTRAINT [FK_AzeriQazes_UtilityPrefixes_UtilityPrefixId]
GO
ALTER TABLE [dbo].[AzerPays]  WITH CHECK ADD  CONSTRAINT [FK_AzerPays_Prefix_PrefixId] FOREIGN KEY([PrefixId])
REFERENCES [dbo].[Prefix] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AzerPays] CHECK CONSTRAINT [FK_AzerPays_Prefix_PrefixId]
GO
ALTER TABLE [dbo].[AzerSus]  WITH CHECK ADD  CONSTRAINT [FK_AzerSus_UtilityPrefixes_UtilityPrefixId] FOREIGN KEY([UtilityPrefixId])
REFERENCES [dbo].[UtilityPrefixes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AzerSus] CHECK CONSTRAINT [FK_AzerSus_UtilityPrefixes_UtilityPrefixId]
GO
ALTER TABLE [dbo].[Bakcells]  WITH CHECK ADD  CONSTRAINT [FK_Bakcells_Prefix_PrefixId] FOREIGN KEY([PrefixId])
REFERENCES [dbo].[Prefix] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bakcells] CHECK CONSTRAINT [FK_Bakcells_Prefix_PrefixId]
GO
ALTER TABLE [dbo].[DrWebs]  WITH CHECK ADD  CONSTRAINT [FK_DrWebs_EntertainmentPrefixes_EntertainmentPrefixId] FOREIGN KEY([EntertainmentPrefixId])
REFERENCES [dbo].[EntertainmentPrefixes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DrWebs] CHECK CONSTRAINT [FK_DrWebs_EntertainmentPrefixes_EntertainmentPrefixId]
GO
ALTER TABLE [dbo].[EntertainmentPrefixes]  WITH CHECK ADD  CONSTRAINT [FK_EntertainmentPrefixes_LangConfigs_LangConfigId] FOREIGN KEY([LangConfigId])
REFERENCES [dbo].[LangConfigs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EntertainmentPrefixes] CHECK CONSTRAINT [FK_EntertainmentPrefixes_LangConfigs_LangConfigId]
GO
ALTER TABLE [dbo].[Esets]  WITH CHECK ADD  CONSTRAINT [FK_Esets_EntertainmentPrefixes_EntertainmentPrefixId] FOREIGN KEY([EntertainmentPrefixId])
REFERENCES [dbo].[EntertainmentPrefixes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Esets] CHECK CONSTRAINT [FK_Esets_EntertainmentPrefixes_EntertainmentPrefixId]
GO
ALTER TABLE [dbo].[Kasperskies]  WITH CHECK ADD  CONSTRAINT [FK_Kasperskies_EntertainmentPrefixes_EntertainmentPrefixId] FOREIGN KEY([EntertainmentPrefixId])
REFERENCES [dbo].[EntertainmentPrefixes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Kasperskies] CHECK CONSTRAINT [FK_Kasperskies_EntertainmentPrefixes_EntertainmentPrefixId]
GO
ALTER TABLE [dbo].[Naxtels]  WITH CHECK ADD  CONSTRAINT [FK_Naxtels_Prefix_PrefixId] FOREIGN KEY([PrefixId])
REFERENCES [dbo].[Prefix] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Naxtels] CHECK CONSTRAINT [FK_Naxtels_Prefix_PrefixId]
GO
ALTER TABLE [dbo].[Nars]  WITH CHECK ADD  CONSTRAINT [FK_Nars_Prefix_PrefixId] FOREIGN KEY([PrefixId])
REFERENCES [dbo].[Prefix] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nars] CHECK CONSTRAINT [FK_Nars_Prefix_PrefixId]
GO
ALTER TABLE [dbo].[PortManats]  WITH CHECK ADD  CONSTRAINT [FK_PortManats_Prefix_PrefixId] FOREIGN KEY([PrefixId])
REFERENCES [dbo].[Prefix] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PortManats] CHECK CONSTRAINT [FK_PortManats_Prefix_PrefixId]
GO
ALTER TABLE [dbo].[Prefix]  WITH CHECK ADD  CONSTRAINT [FK_Prefix_LangConfigs_LangConfigId] FOREIGN KEY([LangConfigId])
REFERENCES [dbo].[LangConfigs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prefix] CHECK CONSTRAINT [FK_Prefix_LangConfigs_LangConfigId]
GO
ALTER TABLE [dbo].[StatePrefixes]  WITH CHECK ADD  CONSTRAINT [FK_StatePrefixes_LangConfigs_LangConfigId] FOREIGN KEY([LangConfigId])
REFERENCES [dbo].[LangConfigs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StatePrefixes] CHECK CONSTRAINT [FK_StatePrefixes_LangConfigs_LangConfigId]
GO
ALTER TABLE [dbo].[UtilityPrefixes]  WITH CHECK ADD  CONSTRAINT [FK_UtilityPrefixes_LangConfigs_LangConfigId] FOREIGN KEY([LangConfigId])
REFERENCES [dbo].[LangConfigs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UtilityPrefixes] CHECK CONSTRAINT [FK_UtilityPrefixes_LangConfigs_LangConfigId]
GO
ALTER TABLE [dbo].[Vns]  WITH CHECK ADD  CONSTRAINT [FK_Vns_StatePrefixes_StatePrefixId] FOREIGN KEY([StatePrefixId])
REFERENCES [dbo].[StatePrefixes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vns] CHECK CONSTRAINT [FK_Vns_StatePrefixes_StatePrefixId]
GO
USE [master]
GO
ALTER DATABASE [APIDb] SET  READ_WRITE 
GO
