USE [master]
GO
/****** Object:  Database [ControlAsistencias]    Script Date: 13/01/2025 20:01:40 ******/
CREATE DATABASE [ControlAsistencias]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ControlAsistencias', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ControlAsistencias.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ControlAsistencias_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ControlAsistencias_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ControlAsistencias] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ControlAsistencias].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ControlAsistencias] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ControlAsistencias] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ControlAsistencias] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ControlAsistencias] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ControlAsistencias] SET ARITHABORT OFF 
GO
ALTER DATABASE [ControlAsistencias] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ControlAsistencias] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ControlAsistencias] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ControlAsistencias] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ControlAsistencias] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ControlAsistencias] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ControlAsistencias] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ControlAsistencias] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ControlAsistencias] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ControlAsistencias] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ControlAsistencias] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ControlAsistencias] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ControlAsistencias] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ControlAsistencias] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ControlAsistencias] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ControlAsistencias] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ControlAsistencias] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ControlAsistencias] SET RECOVERY FULL 
GO
ALTER DATABASE [ControlAsistencias] SET  MULTI_USER 
GO
ALTER DATABASE [ControlAsistencias] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ControlAsistencias] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ControlAsistencias] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ControlAsistencias] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ControlAsistencias] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ControlAsistencias] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ControlAsistencias', N'ON'
GO
ALTER DATABASE [ControlAsistencias] SET QUERY_STORE = ON
GO
ALTER DATABASE [ControlAsistencias] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ControlAsistencias]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 13/01/2025 20:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/01/2025 20:01:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Celular] [varchar](15) NULL,
	[Cedula] [varchar](20) NOT NULL,
	[PaisID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Paises] ON 

INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (1, N'Argentina')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (2, N'Brasil')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (3, N'Chile')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (4, N'Colombia')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (5, N'México')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (6, N'Perú')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (7, N'Estados Unidos')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (8, N'España')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (9, N'Cuba')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (10, N'Venezuela')
INSERT [dbo].[Paises] ([ID], [Nombre]) VALUES (11, N'Ecuador')
SET IDENTITY_INSERT [dbo].[Paises] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID], [Nombre], [Apellido], [Email], [Celular], [Cedula], [PaisID]) VALUES (1, N'Armando', N'Guerra', N'armandowarfare@gmail.com', N'098498454', N'17489123456', 2)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuarios__A9D10534B7FB6384]    Script Date: 13/01/2025 20:01:40 ******/
ALTER TABLE [dbo].[Usuarios] ADD UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuarios__B4ADFE38805D7C58]    Script Date: 13/01/2025 20:01:40 ******/
ALTER TABLE [dbo].[Usuarios] ADD UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([PaisID])
REFERENCES [dbo].[Paises] ([ID])
GO
USE [master]
GO
ALTER DATABASE [ControlAsistencias] SET  READ_WRITE 
GO
