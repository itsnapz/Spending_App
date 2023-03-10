USE [master]
GO
/****** Object:  Database [SpendingDb]    Script Date: 29.11.2022 16:46:20 ******/
CREATE DATABASE [SpendingDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SpendingDb', FILENAME = N'C:\Users\mnovo\SpendingDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SpendingDb_log', FILENAME = N'C:\Users\mnovo\SpendingDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SpendingDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SpendingDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SpendingDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SpendingDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SpendingDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SpendingDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SpendingDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SpendingDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SpendingDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SpendingDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SpendingDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SpendingDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SpendingDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SpendingDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SpendingDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SpendingDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SpendingDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SpendingDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SpendingDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SpendingDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SpendingDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SpendingDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SpendingDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SpendingDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SpendingDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SpendingDb] SET  MULTI_USER 
GO
ALTER DATABASE [SpendingDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SpendingDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SpendingDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SpendingDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SpendingDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SpendingDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SpendingDb] SET QUERY_STORE = OFF
GO
USE [SpendingDb]
GO
/****** Object:  Table [dbo].[Spend]    Script Date: 29.11.2022 16:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Spend](
	[spend_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [int] NULL,
	[users_id] [int] NULL,
	[dateofaddition] [datetime] NULL,
	[paid] [bit] NULL,
 CONSTRAINT [PK_Spend] PRIMARY KEY CLUSTERED 
(
	[spend_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 29.11.2022 16:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[users_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[users_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Spend] ON 

INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (1, N'Boty', 1999, 1, CAST(N'2022-11-26T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (2, N'Jídlo', 199, 2, CAST(N'2022-11-24T12:59:00.000' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3, N'Vánoce', 2357, 1, CAST(N'2022-11-25T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (4, N'Svačina', 99, 3, CAST(N'2022-11-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (5, N'Oběd', 129, 1, CAST(N'2022-11-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (9, N'Klávesnice', 1999, 1, CAST(N'2022-11-26T14:27:40.343' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (10, N'Myš', 2999, 1, CAST(N'2022-11-26T14:28:18.447' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (1002, N'Jidlo', 199, 1002, CAST(N'2022-11-27T10:27:01.427' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (2002, N'test', 199, 2002, CAST(N'2022-11-27T15:10:46.187' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3002, N'Podložka', 699, 1, CAST(N'2022-11-28T15:55:25.677' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3003, N'Snídaně', 99, 1, CAST(N'2022-11-28T16:02:00.020' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3004, N'Hokejka', 3999, 2002, CAST(N'2022-11-28T16:02:57.730' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3005, N'test', 12, 1, CAST(N'2022-11-28T16:21:37.737' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3006, N'Brusle', 5999, 2002, CAST(N'2022-11-28T16:49:56.443' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3007, N'test', 99, 2002, CAST(N'2022-11-28T16:58:37.820' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3008, N'test', 99, 1002, CAST(N'2022-11-28T17:00:04.233' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3009, N'Nový codka', 999, 1, CAST(N'2022-11-28T17:00:30.237' AS DateTime), 1)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3010, N'NHL', 1499, 1, CAST(N'2022-11-28T17:01:36.393' AS DateTime), 0)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (3011, N'RTX 3060', 9999, 1, CAST(N'2022-11-28T17:02:18.697' AS DateTime), 0)
INSERT [dbo].[Spend] ([spend_id], [name], [price], [users_id], [dateofaddition], [paid]) VALUES (4002, N'Chrániče', 2999, 2002, CAST(N'2022-11-29T16:40:57.580' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Spend] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([users_id], [name], [surname], [email]) VALUES (1, N'Matyáš', N'Novotný', N'novotny.matyas@ssakhk.cz')
INSERT [dbo].[Users] ([users_id], [name], [surname], [email]) VALUES (2, N'Pepa', N'Vomáčka', N'vomacka.pepa@ssakhk.cz')
INSERT [dbo].[Users] ([users_id], [name], [surname], [email]) VALUES (3, N'Lukáš', N'Šustr', N'sustr.lukas@ssakhk.cz')
INSERT [dbo].[Users] ([users_id], [name], [surname], [email]) VALUES (1002, N'Nathan', N'Kane', N'kane.nathan@gmail.com')
INSERT [dbo].[Users] ([users_id], [name], [surname], [email]) VALUES (2002, N'Conor', N'McDavid', N'mcdavid@gmail.com')
INSERT [dbo].[Users] ([users_id], [name], [surname], [email]) VALUES (3002, N'David', N'Pastrňák', N'pastrnak.david@mail.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Spend]  WITH CHECK ADD  CONSTRAINT [FK_Spend_Users1] FOREIGN KEY([users_id])
REFERENCES [dbo].[Users] ([users_id])
GO
ALTER TABLE [dbo].[Spend] CHECK CONSTRAINT [FK_Spend_Users1]
GO
USE [master]
GO
ALTER DATABASE [SpendingDb] SET  READ_WRITE 
GO
