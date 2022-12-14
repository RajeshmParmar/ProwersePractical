USE [master]
GO
/****** Object:  Database [AutoMotiveWorkshop]    Script Date: 12-11-2022 09:15:32 ******/
CREATE DATABASE [AutoMotiveWorkshop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoMotiveWorkshop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AutoMotiveWorkshop.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AutoMotiveWorkshop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\AutoMotiveWorkshop_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AutoMotiveWorkshop] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoMotiveWorkshop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoMotiveWorkshop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET  MULTI_USER 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoMotiveWorkshop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AutoMotiveWorkshop] SET DELAYED_DURABILITY = DISABLED 
GO
USE [AutoMotiveWorkshop]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12-11-2022 09:15:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[PhoneNO] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Service]    Script Date: 12-11-2022 09:15:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceDate] [datetime] NULL,
	[VehicleId] [int] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 12-11-2022 09:15:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ModelName] [nvarchar](50) NULL,
	[Number] [nvarchar](50) NULL,
	[ServiceDueDate] [datetime] NULL,
	[CustomerID] [int] NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [Name], [Address], [PhoneNO]) VALUES (1, N'Bill', N'Ahmedabad', N'1234567890')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([ID], [ServiceDate], [VehicleId]) VALUES (5, CAST(N'2023-02-13 00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Service] ([ID], [ServiceDate], [VehicleId]) VALUES (6, CAST(N'2022-12-12 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Service] ([ID], [ServiceDate], [VehicleId]) VALUES (7, CAST(N'2023-03-12 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Service] OFF
SET IDENTITY_INSERT [dbo].[Vehicle] ON 

INSERT [dbo].[Vehicle] ([ID], [ModelName], [Number], [ServiceDueDate], [CustomerID]) VALUES (1, N'BMW', N'1234', CAST(N'2023-06-12 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Vehicle] ([ID], [ModelName], [Number], [ServiceDueDate], [CustomerID]) VALUES (2, N'Ferrari', N'5643', CAST(N'2023-05-13 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Vehicle] ([ID], [ModelName], [Number], [ServiceDueDate], [CustomerID]) VALUES (3, N'Creta', N'7895', CAST(N'2022-11-15 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Vehicle] OFF
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_Vehicle] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicle] ([ID])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_Vehicle]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Customer]
GO
USE [master]
GO
ALTER DATABASE [AutoMotiveWorkshop] SET  READ_WRITE 
GO
