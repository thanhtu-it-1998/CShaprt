USE [master]
GO
/****** Object:  Database [WingtipToys]    Script Date: 11/2/2020 10:02:13 PM ******/
CREATE DATABASE [WingtipToys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WingWingtipToys', FILENAME = N'D:\Profile\SQL\MSSQL12.SQLEXPRESS\MSSQL\DATA\WingWingtipToys.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WingWingtipToys_log', FILENAME = N'D:\Profile\SQL\MSSQL12.SQLEXPRESS\MSSQL\DATA\WingWingtipToys_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WingtipToys] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WingtipToys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WingtipToys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WingtipToys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WingtipToys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WingtipToys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WingtipToys] SET ARITHABORT OFF 
GO
ALTER DATABASE [WingtipToys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WingtipToys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WingtipToys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WingtipToys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WingtipToys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WingtipToys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WingtipToys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WingtipToys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WingtipToys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WingtipToys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WingtipToys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WingtipToys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WingtipToys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WingtipToys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WingtipToys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WingtipToys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WingtipToys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WingtipToys] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WingtipToys] SET  MULTI_USER 
GO
ALTER DATABASE [WingtipToys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WingtipToys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WingtipToys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WingtipToys] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WingtipToys] SET DELAYED_DURABILITY = DISABLED 
GO
USE [WingtipToys]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/2/2020 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
	[Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/2/2020 10:02:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
	[ImagePath] [nvarchar](100) NULL,
	[UnitPrice] [money] NULL,
	[CategoryID] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [IX_Product]    Script Date: 11/2/2020 10:02:14 PM ******/
CREATE NONCLUSTERED INDEX [IX_Product] ON [dbo].[Product]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_1]    Script Date: 11/2/2020 10:02:14 PM ******/
CREATE NONCLUSTERED INDEX [IX_Product_1] ON [dbo].[Product]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [WingtipToys] SET  READ_WRITE 
GO
