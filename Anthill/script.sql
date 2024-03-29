USE [master]
GO
/****** Object:  Database [Anthill]    Script Date: 02-Jan-23 11:04:58 PM ******/
CREATE DATABASE [Anthill]

GO
ALTER DATABASE [Anthill] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Anthill].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Anthill] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Anthill] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Anthill] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Anthill] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Anthill] SET ARITHABORT OFF 
GO
ALTER DATABASE [Anthill] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Anthill] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Anthill] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Anthill] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Anthill] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Anthill] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Anthill] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Anthill] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Anthill] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Anthill] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Anthill] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Anthill] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Anthill] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Anthill] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Anthill] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Anthill] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Anthill] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Anthill] SET RECOVERY FULL 
GO
ALTER DATABASE [Anthill] SET  MULTI_USER 
GO
ALTER DATABASE [Anthill] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Anthill] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Anthill] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Anthill] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Anthill] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Anthill] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Anthill', N'ON'
GO
ALTER DATABASE [Anthill] SET QUERY_STORE = OFF
GO
USE [Anthill]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 02-Jan-23 11:04:58 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matches]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matches](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Matches] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scores]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeamId] [int] NOT NULL,
	[MatchId] [int] NOT NULL,
	[Value] [int] NOT NULL,
 CONSTRAINT [PK_Scores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TopMatch]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopMatch](
	[MatchId] [int] NOT NULL,
	[Team1Name] [nvarchar](max) NOT NULL,
	[Team1] [int] NOT NULL,
	[Score1] [int] NOT NULL,
	[Team2Name] [nvarchar](max) NOT NULL,
	[Team2] [int] NOT NULL,
	[Score2] [int] NOT NULL,
	[Total] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TopScorersSP]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopScorersSP](
	[MatchId] [int] NOT NULL,
	[Value] [int] NOT NULL,
	[TeamId] [int] NOT NULL,
	[TeamName] [nvarchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221223094447_Initial', N'6.0.12')
GO
SET IDENTITY_INSERT [dbo].[Matches] ON 

INSERT [dbo].[Matches] ([Id], [Status]) VALUES (1, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (2, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (3, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (4, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (5, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (6, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (7, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (8, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (9, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (10, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (11, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (12, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (13, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (14, N'Played')
INSERT [dbo].[Matches] ([Id], [Status]) VALUES (15, N'Played')
SET IDENTITY_INSERT [dbo].[Matches] OFF
GO
SET IDENTITY_INSERT [dbo].[Scores] ON 

INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (1, 1, 1, 100)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (2, 2, 1, 90)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (3, 1, 2, 85)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (4, 3, 2, 95)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (5, 1, 3, 80)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (6, 4, 3, 95)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (7, 1, 14, 82)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (8, 5, 14, 93)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (9, 1, 4, 90)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (10, 6, 4, 78)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (11, 2, 5, 99)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (12, 3, 5, 77)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (13, 2, 6, 80)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (14, 4, 6, 95)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (15, 2, 7, 90)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (16, 5, 7, 78)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (17, 2, 8, 95)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (18, 6, 8, 74)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (19, 3, 10, 94)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (20, 5, 10, 73)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (21, 3, 11, 111)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (22, 6, 11, 110)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (23, 4, 12, 86)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (24, 5, 12, 75)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (25, 4, 13, 100)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (26, 6, 13, 78)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (27, 5, 15, 91)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (28, 6, 15, 71)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (29, 3, 9, 88)
INSERT [dbo].[Scores] ([Id], [TeamId], [MatchId], [Value]) VALUES (30, 4, 9, 69)
SET IDENTITY_INSERT [dbo].[Scores] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 

INSERT [dbo].[Teams] ([Id], [Name]) VALUES (1, N'Lakers')
INSERT [dbo].[Teams] ([Id], [Name]) VALUES (2, N'Bulls')
INSERT [dbo].[Teams] ([Id], [Name]) VALUES (3, N'Warriors')
INSERT [dbo].[Teams] ([Id], [Name]) VALUES (4, N'Celtics')
INSERT [dbo].[Teams] ([Id], [Name]) VALUES (5, N'Nets')
INSERT [dbo].[Teams] ([Id], [Name]) VALUES (6, N'Mavericks')
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
/****** Object:  Index [IX_Scores_MatchId]    Script Date: 02-Jan-23 11:04:58 PM ******/
CREATE NONCLUSTERED INDEX [IX_Scores_MatchId] ON [dbo].[Scores]
(
	[MatchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Scores_TeamId]    Script Date: 02-Jan-23 11:04:58 PM ******/
CREATE NONCLUSTERED INDEX [IX_Scores_TeamId] ON [dbo].[Scores]
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Scores]  WITH CHECK ADD  CONSTRAINT [FK_Scores_Matches_MatchId] FOREIGN KEY([MatchId])
REFERENCES [dbo].[Matches] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Scores] CHECK CONSTRAINT [FK_Scores_Matches_MatchId]
GO
ALTER TABLE [dbo].[Scores]  WITH CHECK ADD  CONSTRAINT [FK_Scores_Teams_TeamId] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Scores] CHECK CONSTRAINT [FK_Scores_Teams_TeamId]
GO
/****** Object:  StoredProcedure [dbo].[AllTeams]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AllTeams]

AS
BEGIN
select * from Teams
END
GO
/****** Object:  StoredProcedure [dbo].[GetTopConceederSP]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetTopConceederSP]

AS
BEGIN
SELECT TOP 1 tt1.Id as TeamId,tt1.Name as TeamName,SUM (t2.Value) as TotalScore
FROM Scores t1, Scores t2,Teams tt1,Teams tt2
where t1.MatchId = t2.MatchId AND t1.TeamId!=t2.TeamId AND tt1.Id=t1.TeamId AND tt2.Id=t2.TeamId
group by tt1.Id,tt1.Name
order by TotalScore desc
END
GO
/****** Object:  StoredProcedure [dbo].[GetTopMatch]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetTopMatch]

AS
BEGIN
SELECT TOP 1 t1.MatchId,tt1.Name as Team1Name,t1.TeamId as Team1,t1.Value as Score1,tt2.Name as Team2Name,t2.TeamId as Team2,t2.Value as Score2,(t1.Value+t2.Value) as Total
FROM Scores t1, Scores t2,Teams tt1,Teams tt2
where t1.MatchId = t2.MatchId AND t1.TeamId!=t2.TeamId AND tt1.Id=t1.TeamId AND tt2.Id=t2.TeamId
ORDER BY Total desc
END
GO
/****** Object:  StoredProcedure [dbo].[GetTopScorers]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetTopScorers]

AS
BEGIN
SELECT TOP 1 Teams.Id as TeamId,Teams.Name as TeamName,SUM (Scores.Value) as TotalScore
from Scores
INNER JOIN Teams ON Teams.Id=Scores.TeamId
group by Teams.Id,Teams.Name,Scores.TeamId
order by TotalScore desc
END
GO
/****** Object:  StoredProcedure [dbo].[TeamById]    Script Date: 02-Jan-23 11:04:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TeamById]
@TeamID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * from Teams where @TeamID = teams.Id
END
GO
USE [master]
GO
ALTER DATABASE [Anthill] SET  READ_WRITE 
GO
