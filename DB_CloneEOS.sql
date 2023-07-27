USE [EOS_Final_Project]
GO
/****** Object:  Table [dbo].[Quiz]    Script Date: 27/07/2023 5:10:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quiz](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](max) NULL,
	[Anwser] [nchar](10) NULL,
	[Type_Id] [int] NULL,
 CONSTRAINT [PK_Quiz] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Results]    Script Date: 27/07/2023 5:10:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Results](
	[UserID] [int] NULL,
	[TypeID] [int] NULL,
	[Grade] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 27/07/2023 5:10:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 27/07/2023 5:10:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Rold_ID] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Quiz] ON 

INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (1, N'Based upon studies from conducted by accredited certification bodies and the Lumina Foundation, which of the following is true regarding professionals who hold industry validated certifications?

A. They demonstrate higher productivity than peers without professional certifications.
B. They have greater potential to earn higher salaries than peers without professional certifications.
C. They are statistically shown to have greater intelligence than their peers without professional certifications.
D. They are more likely to be employed by enterprise level organizations.', N'A         ', 1)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (3, N'sfvvd', N'D         ', 1)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (4, N'1+1=?
A.1
B.2
C.3
D.4', N'B         ', 1)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (1002, N'ffg', N'ABC       ', 3)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (1003, N'dghjlkl', N'BD        ', 4)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (1004, N'sdf', N'AD        ', 2)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (1005, N'sdcvxv', N'AB        ', 2)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (1006, N'Can', N'BCD       ', 4)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (2003, N'123456dfghh', N'ABCD      ', 2)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (2004, N'dgdfgdsfdsg', N'BD        ', 5)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (2005, N'fghnfvdfg', N'AB        ', 5)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (2006, N'fgdhfgh', N'BC        ', NULL)
INSERT [dbo].[Quiz] ([Id], [Question], [Anwser], [Type_Id]) VALUES (2007, N'ABCDEF', N'AC        ', 4)
SET IDENTITY_INSERT [dbo].[Quiz] OFF
GO
INSERT [dbo].[Results] ([UserID], [TypeID], [Grade]) VALUES (1, 1, 9)
INSERT [dbo].[Results] ([UserID], [TypeID], [Grade]) VALUES (1, 2, 8)
INSERT [dbo].[Results] ([UserID], [TypeID], [Grade]) VALUES (2, 2, 7)
INSERT [dbo].[Results] ([UserID], [TypeID], [Grade]) VALUES (2, 3, 10)
INSERT [dbo].[Results] ([UserID], [TypeID], [Grade]) VALUES (1002, 4, 10)
INSERT [dbo].[Results] ([UserID], [TypeID], [Grade]) VALUES (1002, 1, 9)
INSERT [dbo].[Results] ([UserID], [TypeID], [Grade]) VALUES (1003, 3, 5)
INSERT [dbo].[Results] ([UserID], [TypeID], [Grade]) VALUES (1003, 4, 2)
INSERT [dbo].[Results] ([UserID], [TypeID], [Grade]) VALUES (1, NULL, 5)
GO
SET IDENTITY_INSERT [dbo].[Type] ON 

INSERT [dbo].[Type] ([Id], [Name], [Code]) VALUES (1, N'PRN', N'SU23_PRN_123')
INSERT [dbo].[Type] ([Id], [Name], [Code]) VALUES (2, N'MAS', N'MAS_PT2')
INSERT [dbo].[Type] ([Id], [Name], [Code]) VALUES (3, N'MAD', N'MAD301_123')
INSERT [dbo].[Type] ([Id], [Name], [Code]) VALUES (4, N'CSD', N'CSD_FE_SU23')
INSERT [dbo].[Type] ([Id], [Name], [Code]) VALUES (5, N'SSG104', N'SSg104_Pt3')
SET IDENTITY_INSERT [dbo].[Type] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Username], [Password], [Rold_ID]) VALUES (1, N'Kiennh', N'123', 2)
INSERT [dbo].[User] ([Id], [Username], [Password], [Rold_ID]) VALUES (2, N'TUng', N'123', 2)
INSERT [dbo].[User] ([Id], [Username], [Password], [Rold_ID]) VALUES (1002, N'Tien', N'123', 2)
INSERT [dbo].[User] ([Id], [Username], [Password], [Rold_ID]) VALUES (1003, N'HuNg', N'123', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Quiz]  WITH CHECK ADD  CONSTRAINT [FK_Quiz_Type] FOREIGN KEY([Type_Id])
REFERENCES [dbo].[Type] ([Id])
GO
ALTER TABLE [dbo].[Quiz] CHECK CONSTRAINT [FK_Quiz_Type]
GO
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Results_Type] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Type] ([Id])
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Results_Type]
GO
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Results_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Results_User]
GO
