Create Database [DTMS]
Go
USE [DTMS]
GO
/****** Object:  Table [dbo].[T_UserPermission]    Script Date: 03/05/2017 13:55:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_UserPermission](
	[ControlName] [nvarchar](50) NOT NULL,
	[UserID] [nvarchar](3) NOT NULL,
	[Permission] [tinyint] NULL,
	[Status] [nvarchar](1) NULL,
 CONSTRAINT [PK_T_Roles_1] PRIMARY KEY CLUSTERED 
(
	[ControlName] ASC,
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 03/05/2017 13:55:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_User](
	[UserID] [nvarchar](3) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [varchar](25) NOT NULL,
	[ExpireDate] [date] NULL,
	[Department] [nvarchar](50) NULL,
	[Function] [nvarchar](50) NULL,
	[Branch] [nvarchar](150) NOT NULL,
	[Status] [nvarchar](1) NOT NULL,
	[CreatedBy] [nvarchar](3) NULL,
	[CreatedDate] [datetime] NULL,
	[IsChanged] [tinyint] NULL,
 CONSTRAINT [PK_T_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Controls]    Script Date: 03/05/2017 13:55:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[T_Controls](
	[CTID] [int] IDENTITY(1,1) NOT NULL,
	[ControlName] [nvarchar](50) NOT NULL,
	[ParentID] [int] NULL,
	[DisplayOrder] [int] NULL,
	[ControlType] [varchar](50) NULL,
	[ControlText] [nvarchar](150) NULL,
 CONSTRAINT [PK_T_Controls] PRIMARY KEY CLUSTERED 
(
	[CTID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_ConfigSystem]    Script Date: 03/05/2017 13:55:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_ConfigSystem](
	[cfgID] [int] IDENTITY(1,1) NOT NULL,
	[DataControl] [nvarchar](1) NULL,
	[ConfigControl] [nvarchar](1) NULL,
	[DataUser] [nvarchar](1) NULL,
	[PermissionUser] [nvarchar](1) NULL,
 CONSTRAINT [PK_T_ConfigSystem] PRIMARY KEY CLUSTERED 
(
	[cfgID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_T_User_Status]    Script Date: 03/05/2017 13:55:38 ******/
ALTER TABLE [dbo].[T_User] ADD  CONSTRAINT [DF_T_User_Status]  DEFAULT (N'A') FOR [Status]
GO
/****** Object:  Default [DF_T_User_IsChanged]    Script Date: 03/05/2017 13:55:38 ******/
ALTER TABLE [dbo].[T_User] ADD  CONSTRAINT [DF_T_User_IsChanged]  DEFAULT ((0)) FOR [IsChanged]
GO
/****** Object:  Default [DF_T_UserPermission_Status]    Script Date: 03/05/2017 13:55:38 ******/
ALTER TABLE [dbo].[T_UserPermission] ADD  CONSTRAINT [DF_T_UserPermission_Status]  DEFAULT (N'A') FOR [Status]
GO
