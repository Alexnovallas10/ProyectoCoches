USE [master]
GO
/****** Object:  Database [proyectocoches]    Script Date: 04/06/2019 18:44:15 ******/
CREATE DATABASE [proyectocoches]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyectocoches', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\proyectocoches.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyectocoches_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\proyectocoches_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [proyectocoches] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyectocoches].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyectocoches] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyectocoches] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyectocoches] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyectocoches] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyectocoches] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyectocoches] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyectocoches] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyectocoches] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyectocoches] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyectocoches] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyectocoches] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyectocoches] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyectocoches] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyectocoches] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyectocoches] SET  DISABLE_BROKER 
GO
ALTER DATABASE [proyectocoches] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyectocoches] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyectocoches] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyectocoches] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyectocoches] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyectocoches] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyectocoches] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyectocoches] SET RECOVERY FULL 
GO
ALTER DATABASE [proyectocoches] SET  MULTI_USER 
GO
ALTER DATABASE [proyectocoches] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyectocoches] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyectocoches] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyectocoches] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyectocoches] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'proyectocoches', N'ON'
GO
ALTER DATABASE [proyectocoches] SET QUERY_STORE = OFF
GO
USE [proyectocoches]
GO
/****** Object:  Table [dbo].[Coches]    Script Date: 04/06/2019 18:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coches](
	[id] [int] NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[color] [varchar](50) NOT NULL,
	[año] [numeric](18, 0) NOT NULL,
	[km] [numeric](18, 0) NOT NULL,
	[combustible] [varchar](50) NOT NULL,
	[tracccion] [varchar](50) NULL,
	[Itv] [bit] NOT NULL,
	[precio] [numeric](18, 0) NOT NULL,
	[descrpcion] [varchar](500) NULL,
	[imagen] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Coches] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[datosusuario]    Script Date: 04/06/2019 18:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datosusuario](
	[id] [int] NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[apellido1] [varchar](25) NOT NULL,
	[apellido2] [varchar](25) NOT NULL,
	[email] [varchar](25) NOT NULL,
	[telefono] [numeric](9, 0) NOT NULL,
 CONSTRAINT [PK_datosusuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 04/06/2019 18:44:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](10) NOT NULL,
	[contraseña] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Coches] ([id], [marca], [modelo], [color], [año], [km], [combustible], [tracccion], [Itv], [precio], [descrpcion], [imagen]) VALUES (1, N'bmw', N'm3', N'rojo', CAST(2008 AS Numeric(18, 0)), CAST(1556 AS Numeric(18, 0)), N'gasolina', N'delantera', 0, CAST(2000 AS Numeric(18, 0)), N'holaaa', N'olaa')
INSERT [dbo].[datosusuario] ([id], [nombre], [apellido1], [apellido2], [email], [telefono]) VALUES (1, N'juan', N'aaa', N'bbb', N'ola@ola', CAST(123456 AS Numeric(9, 0)))
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id], [usuario], [contraseña]) VALUES (1, N'Alex', N'1234')
INSERT [dbo].[Usuarios] ([id], [usuario], [contraseña]) VALUES (2, N'juan', N'125534')
INSERT [dbo].[Usuarios] ([id], [usuario], [contraseña]) VALUES (3, N'pedro', N'125455534')
INSERT [dbo].[Usuarios] ([id], [usuario], [contraseña]) VALUES (4, N'pedro', N'125455534')
INSERT [dbo].[Usuarios] ([id], [usuario], [contraseña]) VALUES (5, N'luis', N'1254555534')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Coches]  WITH CHECK ADD  CONSTRAINT [FK_Coches_datosusuario] FOREIGN KEY([id])
REFERENCES [dbo].[datosusuario] ([id])
GO
ALTER TABLE [dbo].[Coches] CHECK CONSTRAINT [FK_Coches_datosusuario]
GO
USE [master]
GO
ALTER DATABASE [proyectocoches] SET  READ_WRITE 
GO
