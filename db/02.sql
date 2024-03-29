USE [master]
GO
/****** Object:  Database [DBShipsTracks]    Script Date: 03/26/2018 15:32:34 ******/
CREATE DATABASE [DBShipsTracks] ON  PRIMARY 
( NAME = N'DBShipsTracks', FILENAME = N'C:\DATA\DBShipsTracks.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBShipsTracks_log', FILENAME = N'C:\DATA\DBShipsTracks_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBShipsTracks] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBShipsTracks].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBShipsTracks] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DBShipsTracks] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DBShipsTracks] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DBShipsTracks] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DBShipsTracks] SET ARITHABORT OFF
GO
ALTER DATABASE [DBShipsTracks] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [DBShipsTracks] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DBShipsTracks] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DBShipsTracks] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DBShipsTracks] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DBShipsTracks] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DBShipsTracks] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DBShipsTracks] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DBShipsTracks] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DBShipsTracks] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DBShipsTracks] SET  DISABLE_BROKER
GO
ALTER DATABASE [DBShipsTracks] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DBShipsTracks] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DBShipsTracks] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DBShipsTracks] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DBShipsTracks] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DBShipsTracks] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [DBShipsTracks] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DBShipsTracks] SET  READ_WRITE
GO
ALTER DATABASE [DBShipsTracks] SET RECOVERY FULL
GO
ALTER DATABASE [DBShipsTracks] SET  MULTI_USER
GO
ALTER DATABASE [DBShipsTracks] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DBShipsTracks] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBShipsTracks', N'ON'
GO
USE [DBShipsTracks]
GO
/****** Object:  Table [dbo].[t_Ships]    Script Date: 03/26/2018 15:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Ships](
	[ShipID] [varchar](40) NULL,
	[ShipNO] [varchar](50) NULL,
	[ShipName] [varchar](50) NULL,
	[Owner] [varchar](50) NULL,
	[OwnerCompany] [varchar](50) NULL,
	[Contact] [varchar](200) NULL,
	[Lon] [float] NULL,
	[Lat] [float] NULL,
	[Lon0] [float] NULL,
	[Lat0] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[t_Ships] ([ShipID], [ShipNO], [ShipName], [Owner], [OwnerCompany], [Contact], [Lon], [Lat], [Lon0], [Lat0]) VALUES (N'1', N'中船001', N'广渔001', N'张三', N'  中国渔业', N'18888888888', 108.58320115434961, 34.839258250094382, 108.58250516577567, 34.839177780906233)
INSERT [dbo].[t_Ships] ([ShipID], [ShipNO], [ShipName], [Owner], [OwnerCompany], [Contact], [Lon], [Lat], [Lon0], [Lat0]) VALUES (N'2', N'美船002', N'SIH', N'jim', N'American', N'01293823993', 110.60320115434961, 3.2792582500943572, 110.60250516577567, 3.2791777809062119)
/****** Object:  Table [dbo].[t_BS]    Script Date: 03/26/2018 15:32:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_BS](
	[BSID] [varchar](40) NULL,
	[BSNO] [varchar](50) NULL,
	[BSName] [varchar](50) NULL,
	[Contact] [varchar](200) NULL,
	[Range] [float] NULL,
	[Lon] [float] NULL,
	[Lat] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'米' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N't_BS', @level2type=N'COLUMN',@level2name=N'Range'
GO
INSERT [dbo].[t_BS] ([BSID], [BSNO], [BSName], [Contact], [Range], [Lon], [Lat]) VALUES (N'1', N'BS001', N'BS1', N'293239239', 10000, 108.32, 34.32)
INSERT [dbo].[t_BS] ([BSID], [BSNO], [BSName], [Contact], [Range], [Lon], [Lat]) VALUES (N'2', N'BS002', N'BS2', N'323432334', 50000, 110.32, 34.89)
