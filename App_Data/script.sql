USE [master]
GO
/****** Object:  Database [dbProdukter]    Script Date: 02/13/2015 18:58:59 ******/
CREATE DATABASE [dbProdukter] ON  PRIMARY 
( NAME = N'dbProdukter', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\dbProdukter.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbProdukter_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\dbProdukter_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbProdukter] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbProdukter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbProdukter] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [dbProdukter] SET ANSI_NULLS OFF
GO
ALTER DATABASE [dbProdukter] SET ANSI_PADDING OFF
GO
ALTER DATABASE [dbProdukter] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [dbProdukter] SET ARITHABORT OFF
GO
ALTER DATABASE [dbProdukter] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [dbProdukter] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [dbProdukter] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [dbProdukter] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [dbProdukter] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [dbProdukter] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [dbProdukter] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [dbProdukter] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [dbProdukter] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [dbProdukter] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [dbProdukter] SET  DISABLE_BROKER
GO
ALTER DATABASE [dbProdukter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [dbProdukter] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [dbProdukter] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [dbProdukter] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [dbProdukter] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [dbProdukter] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [dbProdukter] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [dbProdukter] SET  READ_WRITE
GO
ALTER DATABASE [dbProdukter] SET RECOVERY SIMPLE
GO
ALTER DATABASE [dbProdukter] SET  MULTI_USER
GO
ALTER DATABASE [dbProdukter] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [dbProdukter] SET DB_CHAINING OFF
GO
USE [dbProdukter]
GO
/****** Object:  Table [dbo].[tblAargang]    Script Date: 02/13/2015 18:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAargang](
	[fldAargangID] [int] IDENTITY(1,1) NOT NULL,
	[fk_fldMotorStoerelseID] [int] NOT NULL,
	[fldAargang] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblAargang] PRIMARY KEY CLUSTERED 
(
	[fldAargangID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblAargang] ON
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (4, 8, N'1990')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (5, 9, N'2000')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (6, 10, N'1')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (7, 11, N'1')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (8, 12, N'1')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (9, 13, N'2')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (10, 14, N'3')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (11, 15, N'1234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (12, 16, N'2')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (13, 17, N'2')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (14, 4, N'1990')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (15, 20, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (16, 21, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (17, 22, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (18, 23, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (19, 24, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (20, 25, N'34')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (21, 26, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (22, 27, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (23, 28, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (24, 29, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (25, 30, N'234')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (26, 31, N'34')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (27, 32, N'123')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (28, 33, N'123')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (29, 34, N'123')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (30, 35, N'123')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (31, 36, N'123')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (32, 37, N'1989')
INSERT [dbo].[tblAargang] ([fldAargangID], [fk_fldMotorStoerelseID], [fldAargang]) VALUES (33, 123, N'123')
SET IDENTITY_INSERT [dbo].[tblAargang] OFF
/****** Object:  Table [dbo].[tblMotorStoerelse]    Script Date: 02/13/2015 18:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMotorStoerelse](
	[fldMotorStoerelseID] [int] IDENTITY(1,1) NOT NULL,
	[fk_fldModelID] [int] NOT NULL,
	[fldMotorStoerelse] [varchar](150) NOT NULL,
 CONSTRAINT [PK_tblMotorStoerelse] PRIMARY KEY CLUSTERED 
(
	[fldMotorStoerelseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblMotorStoerelse] ON
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (8, 9, N'1,3')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (9, 10, N'2,0')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (10, 11, N'q')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (11, 12, N'q')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (12, 13, N'q')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (13, 14, N'ty')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (14, 15, N'ty4')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (15, 16, N'test')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (16, 17, N's')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (17, 18, N's')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (18, 19, N'eheheheh')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (19, 19, N'hhhhhhhhhhhhhhhhhhhhhhhhhhhh')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (20, 20, N'asd')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (21, 21, N'asdas')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (22, 22, N'ddasd')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (23, 23, N'as')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (24, 24, N'sdasd')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (25, 25, N'asda')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (26, 26, N'asd')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (27, 27, N'asdas')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (28, 28, N'ddasd')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (29, 29, N'as')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (30, 30, N'sdasd')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (31, 31, N'asda')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (32, 32, N'asd')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (33, 33, N'12')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (34, 34, N'12')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (35, 35, N'2')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (36, 36, N'12')
INSERT [dbo].[tblMotorStoerelse] ([fldMotorStoerelseID], [fk_fldModelID], [fldMotorStoerelse]) VALUES (37, 37, N'2.0')
SET IDENTITY_INSERT [dbo].[tblMotorStoerelse] OFF
/****** Object:  Table [dbo].[tblModel]    Script Date: 02/13/2015 18:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblModel](
	[fldModelID] [int] IDENTITY(1,1) NOT NULL,
	[fk_fldMaerkeID] [int] NOT NULL,
	[fldModelNavn] [varchar](150) NOT NULL,
 CONSTRAINT [PK_tblModel] PRIMARY KEY CLUSTERED 
(
	[fldModelID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblModel] ON
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (9, 24, N'II')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (10, 26, N'Golf')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (11, 80, N'q')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (12, 81, N'q')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (13, 82, N'q')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (14, 83, N'ty')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (15, 84, N'ty4')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (16, 85, N'test')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (17, 86, N's')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (18, 87, N's')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (19, 24, N'sssssssssssssssss')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (20, 89, N'asd')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (21, 90, N'd')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (22, 91, N'sdas')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (23, 92, N'asd')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (24, 93, N'asda')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (25, 94, N'asd')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (26, 95, N'asd')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (27, 96, N'd')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (28, 97, N'sdas')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (29, 98, N'asd')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (30, 99, N'asda')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (31, 100, N'asd')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (32, 101, N'asdasd')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (33, 102, N'qweqwe')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (34, 103, N'qweqweqw')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (35, 104, N'qweqweqwe')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (36, 105, N'qweqwe')
INSERT [dbo].[tblModel] ([fldModelID], [fk_fldMaerkeID], [fldModelNavn]) VALUES (37, 106, N'mikkel')
SET IDENTITY_INSERT [dbo].[tblModel] OFF
/****** Object:  Table [dbo].[tblMaerke]    Script Date: 02/13/2015 18:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMaerke](
	[fldMaerkeID] [int] IDENTITY(1,1) NOT NULL,
	[fldMaerkeNavn] [varchar](150) NOT NULL,
 CONSTRAINT [PK_tblMaerke] PRIMARY KEY CLUSTERED 
(
	[fldMaerkeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblMaerke] ON
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (23, N'volsomt')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (24, N'Golf')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (25, N'pegeot')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (26, N'VW')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (27, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (28, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (29, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (30, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (31, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (32, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (33, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (34, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (35, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (36, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (37, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (38, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (39, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (40, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (41, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (42, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (43, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (44, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (45, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (46, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (47, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (48, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (49, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (50, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (51, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (52, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (53, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (54, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (55, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (56, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (57, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (58, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (59, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (60, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (61, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (62, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (63, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (64, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (65, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (66, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (67, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (68, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (69, N'dsa')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (70, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (71, N'')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (72, N'asdfg')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (73, N'asdfg')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (74, N'asdfg')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (75, N'asdfg')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (76, N'asdfg')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (77, N'gfd')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (78, N'gf')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (79, N'gfdjhf')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (80, N'q')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (81, N'q')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (82, N'q')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (83, N'ty')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (84, N'ty4')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (85, N'test')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (86, N's')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (87, N's')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (88, N'etete')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (89, N'asd')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (90, N'asdas')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (91, N'asdas')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (92, N'dasd')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (93, N'asd')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (94, N'asd')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (95, N'asd')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (96, N'asdas')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (97, N'asdas')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (98, N'dasd')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (99, N'asd')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (100, N'asd')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (101, N'asdsad')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (102, N'qewq')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (103, N'qweqwe')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (104, N'qweqweqwe')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (105, N'qweqweqw')
INSERT [dbo].[tblMaerke] ([fldMaerkeID], [fldMaerkeNavn]) VALUES (106, N'mikkel')
SET IDENTITY_INSERT [dbo].[tblMaerke] OFF
/****** Object:  Table [dbo].[tblDel]    Script Date: 02/13/2015 18:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDel](
	[fldDelID] [int] IDENTITY(1,1) NOT NULL,
	[fk_fldAargangID] [int] NOT NULL,
	[fldDelNavn] [varchar](150) NOT NULL,
	[fldDelTekst] [varchar](200) NOT NULL,
	[fldDelAntal] [int] NOT NULL,
	[fldDelPris] [int] NOT NULL,
	[fldDelBillede] [varchar](200) NULL,
 CONSTRAINT [PK_tblDel] PRIMARY KEY CLUSTERED 
(
	[fldDelID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblDel] ON
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (1, 4, N'asd', N'asd', 3, 3, NULL)
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (2, 24, N'test', N'teten', 123, 2312, NULL)
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (3, 24, N'del', N'del', 1, 12, NULL)
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (4, 24, N'del 2', N'del 2', 12, 321, NULL)
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (5, 24, N'asd', N'asd', 213, 123, NULL)
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (6, 24, N'qwewq', N'qweq', 213, 123, NULL)
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (7, 106, N'mikkel', N'mikkel', 123, 123, NULL)
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (8, 106, N'mikkel2', N'mikkel2', 123, 123, NULL)
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (9, 106, N'trest', N'test', 123, 123, NULL)
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (10, 32, N'teswte', N'testqewqwe', 123, 123, N'wqewqeasd')
INSERT [dbo].[tblDel] ([fldDelID], [fk_fldAargangID], [fldDelNavn], [fldDelTekst], [fldDelAntal], [fldDelPris], [fldDelBillede]) VALUES (11, 32, N'asd', N'sadmin mor', 213, 123, N'dasdasd')
SET IDENTITY_INSERT [dbo].[tblDel] OFF
