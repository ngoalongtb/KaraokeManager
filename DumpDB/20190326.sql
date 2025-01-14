USE [master]
GO
/****** Object:  Database [Karaoke]    Script Date: 3/26/2019 1:39:13 AM ******/
CREATE DATABASE [Karaoke]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Karaoke', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Karaoke.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Karaoke_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Karaoke_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Karaoke] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Karaoke].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Karaoke] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Karaoke] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Karaoke] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Karaoke] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Karaoke] SET ARITHABORT OFF 
GO
ALTER DATABASE [Karaoke] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Karaoke] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Karaoke] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Karaoke] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Karaoke] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Karaoke] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Karaoke] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Karaoke] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Karaoke] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Karaoke] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Karaoke] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Karaoke] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Karaoke] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Karaoke] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Karaoke] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Karaoke] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Karaoke] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Karaoke] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Karaoke] SET  MULTI_USER 
GO
ALTER DATABASE [Karaoke] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Karaoke] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Karaoke] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Karaoke] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Karaoke] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Karaoke] SET QUERY_STORE = OFF
GO
USE [Karaoke]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 3/26/2019 1:39:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Music]    Script Date: 3/26/2019 1:39:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Music](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Author] [nvarchar](255) NULL,
	[Singer] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 3/26/2019 1:39:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StartDateTime] [datetime] NULL,
	[KaraokeType] [nvarchar](255) NULL,
	[EndDateTime] [datetime] NULL,
	[RoomPrice] [float] NULL,
	[Username] [nvarchar](255) NULL,
	[RoomCode] [varchar](50) NULL,
	[CustomerName] [varchar](255) NULL,
	[PhoneNumber] [varchar](25) NULL,
	[PersonID] [nvarchar](25) NULL,
	[Status] [nvarchar](255) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderFood]    Script Date: 3/26/2019 1:39:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderFood](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[FoodId] [int] NULL,
	[FoodPrice] [float] NULL,
 CONSTRAINT [PK_OrderFood] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderMusic]    Script Date: 3/26/2019 1:39:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderMusic](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[MusicId] [int] NULL,
 CONSTRAINT [PK_OrderMusic] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 3/26/2019 1:39:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[Code] [varchar](50) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Price] [float] NULL,
	[Status] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/26/2019 1:39:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Username] [nvarchar](255) NOT NULL,
	[Password] [varchar](255) NULL,
	[Fullname] [nvarchar](255) NULL,
	[PhoneNumber] [varchar](25) NULL,
	[PersonId] [nvarchar](255) NULL,
	[UserType] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([Id], [Name], [Price]) VALUES (1, N'Trái cây đĩa lớn', 80000)
INSERT [dbo].[Food] ([Id], [Name], [Price]) VALUES (2, N'Trái cây đặc biệt', 120000)
SET IDENTITY_INSERT [dbo].[Food] OFF
SET IDENTITY_INSERT [dbo].[Music] ON 

INSERT [dbo].[Music] ([Id], [Name], [Author], [Singer]) VALUES (1, N'Duyên phận', N'Thái Thịnh', N'Lệ Quyên')
INSERT [dbo].[Music] ([Id], [Name], [Author], [Singer]) VALUES (2, N'Món quà vô giám', N'Nguyễn Văn Chung', N'Tim')
SET IDENTITY_INSERT [dbo].[Music] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (1, CAST(N'2019-03-26T00:13:18.263' AS DateTime), NULL, NULL, NULL, NULL, NULL, N'', N'', N'', NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (2, CAST(N'2019-03-26T00:18:49.613' AS DateTime), NULL, NULL, NULL, NULL, NULL, N'', N'', N'', NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (3, CAST(N'2019-03-26T00:19:54.763' AS DateTime), NULL, NULL, NULL, NULL, NULL, N'', N'', N'', NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (4, CAST(N'2019-03-26T00:21:08.730' AS DateTime), NULL, NULL, NULL, NULL, NULL, N'', N'', N'', NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (6, CAST(N'2019-03-26T00:22:56.073' AS DateTime), NULL, NULL, NULL, NULL, NULL, N'', N'', N'', NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (7, NULL, NULL, NULL, NULL, NULL, NULL, N'Nguy?n Van A', N'0966810905', N'123441231', NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (8, CAST(N'2019-03-26T00:26:32.103' AS DateTime), NULL, NULL, NULL, NULL, NULL, N'Khach Hang', N'09512312', N'23123123', NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (9, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (10, CAST(N'2019-03-26T00:28:49.580' AS DateTime), NULL, NULL, NULL, NULL, NULL, N'', N'', N'', NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (11, CAST(N'2019-03-26T00:30:37.147' AS DateTime), NULL, NULL, NULL, NULL, N'P004', N'', N'', N'', NULL)
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (12, CAST(N'2019-03-26T00:31:17.137' AS DateTime), NULL, NULL, NULL, NULL, N'P004', N'Nguyen Van D', N'0966810905', N'123412356', N'Đã thanh toán')
INSERT [dbo].[Order] ([Id], [StartDateTime], [KaraokeType], [EndDateTime], [RoomPrice], [Username], [RoomCode], [CustomerName], [PhoneNumber], [PersonID], [Status]) VALUES (13, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Đã thanh toán')
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[OrderFood] ON 

INSERT [dbo].[OrderFood] ([Id], [OrderId], [FoodId], [FoodPrice]) VALUES (1, 12, 1, 80000)
INSERT [dbo].[OrderFood] ([Id], [OrderId], [FoodId], [FoodPrice]) VALUES (2, 12, 2, 120000)
SET IDENTITY_INSERT [dbo].[OrderFood] OFF
SET IDENTITY_INSERT [dbo].[OrderMusic] ON 

INSERT [dbo].[OrderMusic] ([Id], [OrderId], [MusicId]) VALUES (1, 12, 1)
SET IDENTITY_INSERT [dbo].[OrderMusic] OFF
INSERT [dbo].[Room] ([Code], [Name], [Price], [Status]) VALUES (N'P001', N'Phòng 1 tầng 0', 20000, N'Đang có khách')
INSERT [dbo].[Room] ([Code], [Name], [Price], [Status]) VALUES (N'P002', N'Phòng 2 Tầng 0', 50000, N'Đang có khách')
INSERT [dbo].[Room] ([Code], [Name], [Price], [Status]) VALUES (N'P003', N'Phòng 3 Tầng 0', 100000, N'Sẵn sàng')
INSERT [dbo].[Room] ([Code], [Name], [Price], [Status]) VALUES (N'P004', N'Phòng 4 Tầng 0', 100000, N'Sẵn sàng')
INSERT [dbo].[User] ([Username], [Password], [Fullname], [PhoneNumber], [PersonId], [UserType]) VALUES (N'admin', N'admin', N'ten day du', N'0966810905', N'15123123123', N'Quản trị viên')
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Room] FOREIGN KEY([RoomCode])
REFERENCES [dbo].[Room] ([Code])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Room]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([Username])
REFERENCES [dbo].[User] ([Username])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User]
GO
ALTER TABLE [dbo].[OrderFood]  WITH CHECK ADD  CONSTRAINT [FK_OrderFood_Food] FOREIGN KEY([FoodId])
REFERENCES [dbo].[Food] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderFood] CHECK CONSTRAINT [FK_OrderFood_Food]
GO
ALTER TABLE [dbo].[OrderFood]  WITH CHECK ADD  CONSTRAINT [FK_OrderFood_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderFood] CHECK CONSTRAINT [FK_OrderFood_Order]
GO
ALTER TABLE [dbo].[OrderMusic]  WITH CHECK ADD  CONSTRAINT [FK_OrderMusic_Music] FOREIGN KEY([MusicId])
REFERENCES [dbo].[Music] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderMusic] CHECK CONSTRAINT [FK_OrderMusic_Music]
GO
ALTER TABLE [dbo].[OrderMusic]  WITH CHECK ADD  CONSTRAINT [FK_OrderMusic_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderMusic] CHECK CONSTRAINT [FK_OrderMusic_Order]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tính theo bài hay theo giờ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Order', @level2type=N'COLUMN',@level2name=N'KaraokeType'
GO
USE [master]
GO
ALTER DATABASE [Karaoke] SET  READ_WRITE 
GO
