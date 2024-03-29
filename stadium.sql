USE [master]
GO
/****** Object:  Database [Stadium]    Script Date: 5/22/2018 10:24:44 PM ******/
CREATE DATABASE [Stadium]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stadium', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Stadium.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Stadium_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Stadium_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Stadium] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stadium].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stadium] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Stadium] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Stadium] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Stadium] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Stadium] SET ARITHABORT OFF 
GO
ALTER DATABASE [Stadium] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Stadium] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Stadium] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stadium] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stadium] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stadium] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Stadium] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Stadium] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stadium] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Stadium] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stadium] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Stadium] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stadium] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Stadium] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Stadium] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Stadium] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stadium] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Stadium] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Stadium] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Stadium] SET  MULTI_USER 
GO
ALTER DATABASE [Stadium] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Stadium] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Stadium] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Stadium] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Stadium]
GO
/****** Object:  Table [dbo].[MyStadiums]    Script Date: 5/22/2018 10:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MyStadiums](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_STADIUMS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rents]    Script Date: 5/22/2018 10:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[StadiumId] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[Time] [int] NOT NULL,
	[EndTime] [datetime] NOT NULL,
 CONSTRAINT [PK_RENT] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/22/2018 10:24:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[MyStadiums] ON 

INSERT [dbo].[MyStadiums] ([Id], [Name], [Price]) VALUES (1, N'A1', 30.0000)
INSERT [dbo].[MyStadiums] ([Id], [Name], [Price]) VALUES (3, N'A2', 40.0000)
INSERT [dbo].[MyStadiums] ([Id], [Name], [Price]) VALUES (4, N'B1', 60.0000)
INSERT [dbo].[MyStadiums] ([Id], [Name], [Price]) VALUES (5, N'B2', 80.0000)
SET IDENTITY_INSERT [dbo].[MyStadiums] OFF
SET IDENTITY_INSERT [dbo].[Rents] ON 

INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1078, 1035, 1, CAST(0x0000A8EB016AA51C AS DateTime), 45, CAST(0x0000A8EB0177012C AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1079, 1036, 4, CAST(0x0000A8EB0149A9C0 AS DateTime), 60, CAST(0x0000A8EB015A2480 AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1080, 1037, 3, CAST(0x0000A8E8016ABD0B AS DateTime), 45, CAST(0x0000A8E80177191B AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1081, 1037, 3, CAST(0x0000A8EF016ABD0B AS DateTime), 45, CAST(0x0000A8EF0177191B AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1082, 1037, 3, CAST(0x0000A8F6016ABD0B AS DateTime), 45, CAST(0x0000A8F60177191B AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1083, 1037, 3, CAST(0x0000A8FD016ABD0B AS DateTime), 45, CAST(0x0000A8FD0177191B AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1084, 1037, 3, CAST(0x0000A904016ABD0B AS DateTime), 45, CAST(0x0000A9040177191B AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1085, 1037, 3, CAST(0x0000A90B016ABD0B AS DateTime), 45, CAST(0x0000A90B0177191B AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1086, 1037, 3, CAST(0x0000A912016ABD0B AS DateTime), 45, CAST(0x0000A9120177191B AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1087, 1037, 3, CAST(0x0000A919016ABD0B AS DateTime), 45, CAST(0x0000A9190177191B AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1088, 1038, 4, CAST(0x0000A8F0016A925C AS DateTime), 60, CAST(0x0000A8F0017B0D1C AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1089, 1038, 4, CAST(0x0000A8F7016A925C AS DateTime), 60, CAST(0x0000A8F7017B0D1C AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1090, 1038, 4, CAST(0x0000A8FE016A925C AS DateTime), 60, CAST(0x0000A8FE017B0D1C AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1091, 1038, 4, CAST(0x0000A905016A925C AS DateTime), 60, CAST(0x0000A905017B0D1C AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1092, 1039, 4, CAST(0x0000A8FE01418178 AS DateTime), 45, CAST(0x0000A8FE014DDD88 AS DateTime))
INSERT [dbo].[Rents] ([Id], [UserId], [StadiumId], [StartTime], [Time], [EndTime]) VALUES (1093, 1040, 4, CAST(0x0000A8FE017B5A74 AS DateTime), 120, CAST(0x0000A8FF0010CDF4 AS DateTime))
SET IDENTITY_INSERT [dbo].[Rents] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Type]) VALUES (1035, N'Elcin', N'Agayev', 0)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Type]) VALUES (1036, N'Said', N'Aliyev', 0)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Type]) VALUES (1037, N'sasa', N'sdsad', 1)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Type]) VALUES (1038, N'Elcin', N'Agayev', 1)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Type]) VALUES (1039, N'Bextiyar', N'Qarasov', 0)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Type]) VALUES (1040, N'Sadi', N'Memmedov', 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Type]  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_Rents_MyStadiums] FOREIGN KEY([StadiumId])
REFERENCES [dbo].[MyStadiums] ([Id])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_Rents_MyStadiums]
GO
ALTER TABLE [dbo].[Rents]  WITH CHECK ADD  CONSTRAINT [FK_Rents_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Rents] CHECK CONSTRAINT [FK_Rents_Users]
GO
USE [master]
GO
ALTER DATABASE [Stadium] SET  READ_WRITE 
GO
