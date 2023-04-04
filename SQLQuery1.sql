﻿USE [TEST3]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](30) NULL,
	[Password] [nchar](25) NULL,
	[Quyen] [nchar](10) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
 (
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [Username], [Password], [Quyen]) VALUES (1, N'admin', N'admin', N'ADMIN')
INSERT [dbo].[Users] ([ID], [Username], [Password], [Quyen]) VALUES (2, N'User', N'User', N'USER')
INSERT [dbo].[Users] ([ID], [Username], [Password], [Quyen]) VALUES (3, N'Hehe', N'Hehe', N'USER')
INSERT [dbo].[Users] ([ID], [Username], [Password], [Quyen]) VALUES (4, N'123', N'123', N'ADMIN')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
-- Path: SQLQuery2.sql
USE [TEST3]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN] (
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nchar](100) NULL,
	[GENDER] [nchar](10) NULL,
	[DATE] [date] NULL,
	[ADDRESS] [nchar](100) NULL,
	[CCCD] [nchar](10) NULL,
	[KHOA] [nchar](5) NULL,
	[SCHOOL] [nchar](100) NULL,
	[TOA] [nchar](10) NULL,
	[IDROOM] [int] NULL,
	[PHONE] [nchar](10) NULL,
	[EMAIL] [nchar](100) NULL,
CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SINHVIEN] ON
--insert data
INSERT [dbo].[SINHVIEN] ([ID], [NAME], [GENDER], [DATE], [ADDRESS], [CCCD], [KHOA], [SCHOOL], [TOA], [IDROOM], [PHONE], [EMAIL]) VALUES (156, N'Nguyễn Văn A', N'Nam', CAST(N'1999-01-01' AS Date), N'Đà Nẵng', N'123456789', N'K59', N'Đại học Bách Khoa', N'H1', 710, N'0123456789',N'locc')

SET IDENTITY_INSERT [dbo].[SINHVIEN] OFF
GO

CREATE TABLE [dbo].[ROOM] (
	[IDROOM] [int] IDENTITY(1,1) NOT NULL,
	[NUMST] [int] NULL,
	[NUMSTMAX] [int] NULL,
	[TOA] [nchar](10) NULL,
	[STYLE] [nchar](10) NULL,
	[FLOOR] [int] NULL,
	[STATUS] [nchar](50) NULL,
	[MONEYBILL] [int] NULL,
	[STATUSBILL] [nchar](50) NULL,
CONSTRAINT [PK_ROOM] PRIMARY KEY CLUSTERED 
(
	[IDROOM] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[ROOM] ON
INSERT [dbo].[ROOM] ([IDROOM], [NUMST], [NUMSTMAX], [TOA], [STYLE], [FLOOR], [STATUS], [MONEYBILL], [STATUSBILL]) VALUES (710, 0, 4, N'H1', N'Phòng 4', 7, N'Thiếu', 30000, N'Chưa đóng')
INSERT [dbo].[ROOM] ([IDROOM], [NUMST], [NUMSTMAX], [TOA], [STYLE], [FLOOR], [STATUS], [MONEYBILL], [STATUSBILL]) VALUES (711, 0, 4, N'H1', N'Phòng 4', 7, N'Thiếu', 40000, N'Chưa đóng')

SET IDENTITY_INSERT [dbo].[ROOM] OFF
GO

CREATE TABLE [dbo].[TANG] (
    [IDTANG] [int] IDENTITY(1,1) NOT NULL,
	[IDTOA] [nchar] (10) NULL,
	[MANAGER] [nvarchar] (100) NULL,
	[STATUS] [nchar] (50) NULL,
CONSTRAINT [PK_TANG] PRIMARY KEY CLUSTERED 
(
	[IDTANG] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[TANG] ON
INSERT [dbo].[TANG] ([IDTANG], [IDTOA], [MANAGER], [STATUS]) VALUES (1, N'H1', N'Nguyễn Văn A', N'Thiếu')
INSERT [dbo].[TANG] ([IDTANG], [IDTOA], [MANAGER], [STATUS]) VALUES (2, N'H2', N'Nguyễn Văn B', N'Thiếu')
INSERT [dbo].[TANG] ([IDTANG], [IDTOA], [MANAGER], [STATUS]) VALUES (3, N'H3', N'Nguyễn Văn C', N'Thiếu')
INSERT [dbo].[TANG] ([IDTANG], [IDTOA], [MANAGER], [STATUS]) VALUES (4, N'H4', N'Nguyễn Văn D', N'Thiếu')
INSERT [dbo].[TANG] ([IDTANG], [IDTOA], [MANAGER], [STATUS]) VALUES (5, N'H5', N'Nguyễn Văn E', N'Thiếu')
INSERT [dbo].[TANG] ([IDTANG], [IDTOA], [MANAGER], [STATUS]) VALUES (6, N'H6', N'Nguyễn Văn F', N'Thiếu')

SET IDENTITY_INSERT [dbo].[TANG] OFF
GO

CREATE TABLE [dbo].[BILL] (
	[IDBILL] [int] IDENTITY(1,1) NOT NULL,
	[IDROOM] [int] NULL,
	[DATE] [date] NULL,
	[DIENNUM] [int] NULL,
	[NUOCNUM] [int] NULL,
	[MONEYBILL] [int] NULL,
	[STATUSBILL] [nvarchar](15) NULL,
CONSTRAINT [PK_BILL] PRIMARY KEY CLUSTERED
(
	[IDBILL] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[BILL] ON
INSERT [dbo].[BILL] ([IDBILL], [IDROOM], [DATE], [DIENNUM], [NUOCNUM], [MONEYBILL], [STATUSBILL]) VALUES (1, 710, CAST(N'2019-01-01' AS Date), 10, 0, 30000, N'Chưa thanh toán')
INSERT [dbo].[BILL] ([IDBILL], [IDROOM], [DATE], [DIENNUM], [NUOCNUM], [MONEYBILL], [STATUSBILL]) VALUES (2, 711, CAST(N'2019-01-01' AS Date), 10, 0, 40000, N'Chưa thanh toán')

SET IDENTITY_INSERT [dbo].[BILL] OFF



