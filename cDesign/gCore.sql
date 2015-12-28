USE [master]
GO
/****** Object:  Database [gCore]    Script Date: 12/12/2014 11:54:42 AM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'gCore')
BEGIN
CREATE DATABASE [gCore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gCore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\gCore.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'gCore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\gCore_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
END

GO
ALTER DATABASE [gCore] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [gCore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gCore] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [gCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gCore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gCore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gCore] SET RECOVERY FULL 
GO
ALTER DATABASE [gCore] SET  MULTI_USER 
GO
ALTER DATABASE [gCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gCore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gCore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gCore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'gCore', N'ON'
GO
USE [gCore]
GO
/****** Object:  Table [dbo].[gc_App]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_App]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_App](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Type] [int] NULL,
	[Code] [nvarchar](32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Name] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FullName] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Url] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IsDebug] [bit] NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_App] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Function]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Function]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Function](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Type] [int] NULL,
	[Code] [nvarchar](32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Name] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FullName] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Function] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Function_Flow]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Function_Flow]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Function_Flow](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FunctionId] [bigint] NULL,
	[Type] [int] NULL,
	[Code] [nvarchar](32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Name] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FullName] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Function_Flow] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Function_Input]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Function_Input]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Function_Input](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FunctionId] [bigint] NULL,
	[Type] [int] NULL,
	[Code] [nvarchar](32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Name] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FullName] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[IsReference] [bit] NULL,
	[DefaultValue] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [bigint] NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Function_Input] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Function_Output]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Function_Output]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Function_Output](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FunctionId] [bigint] NULL,
	[Type] [int] NULL,
	[Code] [nvarchar](32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Name] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FullName] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DefaultValue] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Function_Output] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Page]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Page]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Page](
	[Id] [bigint] NOT NULL,
	[AppId] [bigint] NULL,
	[Type] [int] NULL,
	[Code] [nvarchar](32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Name] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FullName] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[RouteFormat] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [bigint] NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Page] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Page_Param]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Page_Param]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Page_Param](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PageId] [bigint] NOT NULL,
	[Type] [int] NULL,
	[Code] [nvarchar](32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Name] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[RegEx] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Page_Param] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Page_Template]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Page_Template]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Page_Template](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PageId] [bigint] NULL,
	[TemplateId] [bigint] NULL,
	[IsActive] [bit] NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Page_Template] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Page_URLFormat]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Page_URLFormat]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Page_URLFormat](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PageId] [bigint] NULL,
	[HasKey] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Type] [int] NULL,
	[ParseFormat] [nvarchar](1024) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Page_RegEx] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Template]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Template]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Template](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Type] [int] NULL,
	[Code] [nvarchar](32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Name] [nvarchar](128) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FullName] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[FilePath] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Content] [text] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Template] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Template_Event]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Template_Event]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Template_Event](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TemplateId] [bigint] NULL,
	[FunctionId] [bigint] NULL,
	[Type] [int] NULL,
	[IsActive] [bit] NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Event] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[gc_Template_Slot]    Script Date: 12/12/2014 11:54:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[gc_Template_Slot]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[gc_Template_Slot](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TemplateId1] [bigint] NULL,
	[TemplateId2] [bigint] NULL,
	[Type] [int] NULL,
	[SlotCode] [nvarchar](32) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Note] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgStatus] [int] NULL,
	[isPrgCreatedDate] [datetime] NULL,
	[isPrgUpdatedDate] [datetime] NULL,
	[isPrgHistoryInfo] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgCreatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[isPrgUpdatedAccount] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_gc_Template_Slot] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[gc_App] ON 

INSERT [dbo].[gc_App] ([Id], [Type], [Code], [Name], [FullName], [Url], [Note], [Description], [IsDebug], [isPrgStatus], [isPrgCreatedDate], [isPrgUpdatedDate], [isPrgHistoryInfo], [isPrgCreatedAccount], [isPrgUpdatedAccount]) VALUES (1, 1, N'vxr', N'vexere.com', N'vexere.com', N'vexere.com', NULL, NULL, 1, NULL, CAST(0x0000A3FE00A46CA1 AS DateTime), CAST(0x0000A3FE00A46CA1 AS DateTime), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[gc_App] OFF
INSERT [dbo].[gc_Page] ([Id], [AppId], [Type], [Code], [Name], [FullName], [RouteFormat], [Note], [Description], [isPrgStatus], [isPrgCreatedDate], [isPrgUpdatedDate], [isPrgHistoryInfo], [isPrgCreatedAccount], [isPrgUpdatedAccount]) VALUES (1, 1, 3, N'SearchTicket', N'Default', NULL, N've-xe-{url}.html', NULL, NULL, NULL, CAST(0x0000A3FE00A815CF AS DateTime), CAST(0x0000A3FE00A815CF AS DateTime), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[gc_Template] ON 

INSERT [dbo].[gc_Template] ([Id], [Type], [Code], [Name], [FullName], [FilePath], [Content], [Note], [Description], [isPrgStatus], [isPrgCreatedDate], [isPrgUpdatedDate], [isPrgHistoryInfo], [isPrgCreatedAccount], [isPrgUpdatedAccount]) VALUES (1, 1, N've-xe', N've-xe', NULL, NULL, N'<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vxr.Front.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>VeXeRe.com</title>
<link rel="stylesheet" type="text/css" media="screen" href="<%= ResolveUrl("~/Content/css/reset.css") %>" />
<link rel="stylesheet" type="text/css" media="print" href="<%= ResolveUrl("~/Content/css/print.css") %>" />
<link rel="stylesheet" type="text/css" media="screen" href="<%= ResolveUrl("~/Content/css/ui-css.css") %>" />
<link rel="stylesheet" type="text/css" media="screen" href="<%= ResolveUrl("~/Content/css/styles.css") %>"/>
<link rel="stylesheet" type="text/css" media="screen" href="<%= ResolveUrl("~/Content/css/nivo-slider.css") %>" />

</head>

<body>
<!--These lines are used to detect any specific browser on even specific OS (Mac, Window, Linux) without using css hacking-->
	<!--[if gt IE 8]><div class="ie ie9"><![endif]-->
    <!--[if IE 8]><div class="ie ie8"><![endif]-->
    <!--[if IE 7]><div class="ie ie7"><![endif]-->
    <!--[if IE 6]><div class="ie ie6"><![endif]-->
    <!--[if lt IE 6]><div class="ie ie5"><![endif]-->
    <!--[if !IE]>--><div class="ie0"><!--<![endif]-->
        <div id="page">
            <!-- >header -->
            <div id="header" class="clearfix">
              <div class="content-inner clearfix">
                <a class="logo mg-t-20 col-08 fl-l" href="" title="vexere.com"><img src="<%= ResolveUrl("~/Content/images/logo.png") %>" width="311" height="75" alt="vexere.com" /></a>
                
                <div class="top-header rel-pos clearfix fl-r">
                	<div class="sc-like col-03 fl-l"><img src="<%= ResolveUrl("~/Content/images/fb-like.png") %>" alt="" /></div> <!-- To be replaced with fb like frame-->
                    <div class="sc-like col-02 fl-l"><img src="<%= ResolveUrl("~/Content/images/gg-like.png") %>" alt="" /></div> <!-- To be replaced with google like frame-->
                    <!-- >Hotline -->
                    <a id="hotline" class="hd-common-bg hotline-btn col-03 fl-l" href="">Hotline</a>
                    <div id="hotlineContent" class="clearfix">
                    	<div class="rel-pos">
                        	<div class="point-arrow col-01"></div>
                            <div class="hotline-content col-05 rounded-4 shadow clearfix">
                            	<p class="al-c"><strong>Vui lòng g?i cho chúng tôi d? du?c ph?c v? và tu v?n</strong></p>
                                <h3><span>HOTLINE</span></h3>
                                <p class="num"><strong>0969 52 33 77<br>0909 10 89 69</strong></p>
                            </div>
                        </div>
                    </div>
                    <!-- /Hotline -->
                    
                    <!-- >Login -->
                    <a id="login" class="hd-common-bg login-btn col-03 fl-l" href="">ÐANG NH?P</a>
                    <div id="loginContent" class="clearfix">
                    	<div class="rel-pos">
                        	<div class="point-arrow"></div>
                            <div class="login-content rounded-4 shadow clearfix">
                            	<form id="loginForm" method="" action="">
                                	<fieldset>
                                    	<div class="input-set clearfix">
                                        	<input class="input-txt" type="text" placeholder="Email" />
                                            <input class="input-txt" type="password" placeholder="M?t kh?u" />
                                            
                                            
                                        </div>
                                        <div class="input-set clearfix">
                                        	<a class="fl-r" href="">Quên m?t kh?u?</a>
                                        	<label class="check-box"><input class="checkbox" type="checkbox" />Ghi nh?</label>
                                        </div>
                                        <div class="submit-ctn"><a class="hd-common-bg signin-btn" href="">Ðang nh?p</a></div>
                                        <h3><span>Ho?c dang nh?p v?i</span></h3>
                                        <div class="social-login clearfix">
                                        	<a class="hd-common-bg fb fl-l" href="" title="Ðang nh?p v?i tài kho?n Facebook">Facebook</a>
                                            <a class="hd-common-bg gg-plus fl-l" href="" title="Ðang nh?p v?i tài kho?n Google+">Google+</a>
                                            <a class="hd-common-bg yahoo fl-l" href="" title="Ðang nh?p v?i tài kho?n Yahoo">Yahoo</a>
                                            <a class="hd-common-bg gg fl-l" href="" title="Ðang nh?p v?i tài kho?n Google">Google</a>
                                        </div>
                                        <h3><strong>B?n chua có tài kho?n?</strong></h3>
                                        <div class="reg-ctn"><a class="hd-common-bg reg-btn" href="">Ðang ký</a></div>
                                    </fieldset>
                                </form>
                            </div>
                        </div>
                    </div>
                    <!-- /Login -->
                    
                    <!-- >Language Selector -->
                    <div id="lang">
   						<!-- add class "disabled" when it is not selected -->
                        <a id="en" class="lang-icon en-flag fl-r disabled" title="English"><img src="<%= ResolveUrl("~/Content/images/us.png") %>" width="22" height="16" alt="English" /></a>
                        <a id="vn" class="lang-icon vn-flag fl-r" title="Ti?ng Vi?t"><img src="<%= ResolveUrl("~/Content/images/vn.png") %>" width="22" height="16" alt="Ti?ng Vi?t" /></a>
                    </div>
                    <!-- /Language Selector -->
                    
                </div>
                
                <!-- > Main Menu-->
                <div id="topNav" class="fl-r">
                    <ul>
                        <li class="first"><a href="">Trang ch?</a></li>
                        <li><a href="">Gi?i thi?u</a></li>
                        <li><a href="">Ki?m tra vé</a></li>
                        <li><a href="">Nhà xe</a>
                            <ul class="submenu">
                            	<li class="first">VEXERE.com liên k?t v?i hon 1000 nhà xe kh?p 3 mi?n</li>
                                <li><a href="">Xe Phuong Trang</a></li>
                                <li><a href="">Xe Thành Bu?i</a></li>
                                <li><a href="">Xe Hu? Nghia</a></li>
                                <li><a href="">Xe Mai Linh</a></li>
                                <li><a href="">Xe Phu?ng Hoàng</a></li>
                                <li><a href="">Xe Hoa Mai</a></li>
                                <li><a href="">Xe Hoàng Long</a></li>
                                <li><a href="">Xe Chín Nghia</a></li>
                                <li><a href="">Xe Thu?n Th?o</a></li>
                                <li><a href="">Xe Vi?t Tân Phát</a></li>
                                <li><a href="">Xe H?nh Cafe</a></li>
                                <li><a href="">Xe Kumho Samco</a></li>
                                <li><a href="">Xe Cúc Tùng</a></li>
                                <li><a href="">Xe Sinh Tourist</a></li>
                                <li><a href="">Xe Van Lang</a></li>
                                <li><a href="">Xe Gia Phúc</a></li>
                                <li><a href="">Xe Ti?n Oanh</a></li>
                                <li><a href="">Xe Minh Th?ng</a></li>
                                <li><a href="">Xe Hà Linh</a></li>
                                <li><a href="">Xe Ki?u Nga</a></li>
                            </ul>
                        </li>
                        <li><a href="#">Tin t?c</a></li>
                        <li class="last"><a href="#">Liên h?</a></li>
                    </ul>
                </div>
                <!-- /Main Menu-->
              </div> 
            </div>
            <!-- /header -->
            
            <!--Breadcumbs-->
            <div id="breadcumbs">
            	<div class="content-inner">
                    <a href="">Trang ch?</a> &gt; <span>Vé xe t? <span ID="FromTitle" runat="server"></span> di Hà N?i</span>
               	</div>
            </div>
            <!--/Breadcumbs-->
            
            <!-- >main content -->
            <div id="main" class="clearfix">
            
            	<!-- Case 1: 2 Ads banners-->
                <div class="content-inner ads-ctn clearfix pd-tb-20">
                	<a href="" class="fl-l"><img src="<%= ResolveUrl("~/Content/images/ads-banner-01.jpg") %>" alt="" /></a>
                    <a href="" class="fl-r"><img src="<%= ResolveUrl("~/Content/images/ads-banner-02.jpg") %>" alt="" /></a>
                </div>
                <!-- /Case 1: Ads banners-->
                
                <!-- Case 2: single Ads banner-->
                <div class="ads-ctn content-inner clearfix pd-tb-20" style="display: none;">
                	<a href="" class="fl-l"><img src="<%= ResolveUrl("~/Content/images/ads-banner-full.jpg") %>" alt="" /></a>
                </div>
                <!-- /Case 2: single Ads banner-->
                
                <!-- Ticket Search Guide-->
                <div class="search-guide content-inner rounded-3 rel-pos clearfix">
                	<h3 class="guide-tt"><span class="font-18">Hu?ng d?n tìm vé c?a</span> <strong class="hl-txt font-16">VeXeRe.com</strong> – <strong class="or-txt font-14">H? th?ng vé xe l?n nh?t Vi?t Nam</strong></h3>
                    <div class="guide-content clearfix">
                    	<div class="initial-guide">
                        	<p>B?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-booking.png") %>" alt="" /> d? ch?n gh? và d?t vé tr?c tuy?n ho?c b?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-phone.png")%>"  alt="" />d? xem s? di?n tho?i hãng xe b?n mu?n d?t vé.</p>
                            <a href="" class="switch-btn rounded-4 read-more">Xem thêm</a>
                        </div>
                        <div class="full-guide">
                        	<p>Luu ý: <strong>B?ng giá vé du?i du?c áp d?ng cho ngày 22/11/2013</strong>, Ð? xem giá vé c?a các ngày khác vui lòng ch?n ngày di ? m?c ch?nh s?a tìm ki?m bên du?i và b?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-search.png")%>" alt="" /> ho?c nút   <img src="<%= ResolveUrl("~/Content/images/guide-btn-prev-date.png")%>"  alt="" />ho?c <img src="<%= ResolveUrl("~/Content/images/guide-btn-nxt-date.png")%>"  alt="" /> </p>
                        	<p>B?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-booking.png")%>" alt="" /> d? ch?n gh? và d?t vé tr?c tuy?n ho?c b?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-phone.png") %>"  alt="" />d? xem s? di?n tho?i hãng xe b?n mu?n d?t vé.</p>
                            <p>Thay d?i k?t qu? tìm ki?m b?ng cách nh?p vào <strong>Noi di</strong>: Ví d?: <img src="<%= ResolveUrl("~/Content/images/guide-btn-place-01.png")%>"  alt="" /> và <strong>Noi d?n</strong>: Ví d?: <img src="<%= ResolveUrl("~/Content/images/guide-btn-place-02.png")%>"  alt="" /> r?i b?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-search.png") %>" alt="" /></p>
                            <p>Rê chu?t lên các bi?u tu?ng <img src="<%= ResolveUrl("~/Content/images/guide-btn-benefit-icons.png")%>"  alt="" /> d? xem các ti?n ích mi?n phí dành cho hành khách c?a hãng xe.</p>
                            <p>B?m ch?n gi? kh?i hành b?ng cách nh?p chu?t và ch?n: <img src="<%= ResolveUrl("~/Content/images/guide-btn-hour-slt.png")%>"  alt="" /> <strong class="hl-txt">Vexere.com</strong> s? cho bi?t gi? d?n ? c?t Noi d?n: <img src="<%= ResolveUrl("~/Content/images/guide-btn-hour-day-slt.png")%>"  alt="" /></p>
                            <p>Rê chu?t lên các bi?u tu?ng <img src="<%= ResolveUrl("~/Content/images/guide-btn-rate.png")%>"  alt="" /> d? xem dánh giá v? ch?t lu?ng nhà xe. Nh?p chu?t lên nút nhu <span class="hl-txt">5 dánh giá</span> <img src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>"  alt="" />d? xem dánh giá chi ti?t.  Ð? vi?t dánh giá ch?t lu?ng nhà xe n?u quý khách dã t?ng du?c ph?c v?, vui lòng nh?p lên nút  <img src="<%= ResolveUrl("~/Content/images/guide-btn-comment.png") %>"  alt="" /></p>
                            <p>B?m ch?n lên liên k?t: <u class="hl-txt">L?ch trình</u> | <u class="hl-txt">Hình ?nh</u> | <u class="hl-txt">B?n d?</u> d? xem thêm chi ti?t thông tin c?a hành trình.</p>
                            <a href="" class="switch-btn rounded-4 close">Ðóng l?i</a>
                        </div>
                    </div>
                	
                </div>
                <!-- /Ticket Search Guide-->

                <!-- ticket search filter -->
                <div id="ticketSearchFilter" class="ticket-search-filter common-bg mg-tb-20 pd-tb-10 clearfix">
                	<div class="content-inner clearfix">
                        <div class="search-content">
                            <form id="filterForm" method="" action="">
                                <fieldset>  
                                    <div class="input-set col-06 fl-l">
                                        <label for="departPlace">Noi di</label>
                                        <input id="departPlace" type="text" class="input-txt place" placeholder="Ch?n noi di" accesskey="1" tabindex="1" />
                                        
                                        <!-- On focus show block below, temporarily used js to show/hide, need to implement this as current site-->
                                        <div id="departPlaceSelector" class="place-selector rounded-5 clearfix" style="display:none;">
                                            <div class="inner rel-pos">
                                                <a id="closeDept" class="close" href="">Ðóng</a>
                                                <div class="region-col first fl-l clearfix">
                                                    <h3>Mi?n B?c</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>Hà N?i</strong></a></li>
                                                        <li class="city"><a href=""><strong>H?i Phòng</strong></a></li>
                                                        <li class="city"><a href=""><strong>H? Long - Qu?ng Ninh</strong></a></li>
                                                        <li class="city"><a href="">B?c Giang</a></li>
                                                        <li class="city"><a href="">B?c K?n</a></li>
                                                        <li class="city"><a href="">B?c Ninh</a></li>
                                                        <li class="city"><a href="">Cao B?ng</a></li>
                                                        <li class="city"><a href="">Ði?n Biên</a></li>
                                                        <li class="city"><a href="">Hà Giang</a></li>
                                                        <li class="city"><a href="">Hà Nam</a></li>
                                                        <li class="city"><a href="">H?i Duong</a></li>
                                                        <li class="city"><a href="">Hòa Bình</a></li>
                                                    </ul>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href="">Hung Yên</a></li>
                                                        <li class="city"><a href="">Lai Châu</a></li>
                                                        <li class="city"><a href="">L?ng Son</a></li>
                                                        <li class="city"><a href="">Lào Cai</a></li>
                                                        <li class="city"><a href="">Nam Ð?nh</a></li>
                                                        <li class="city"><a href="">Ninh Bình</a></li>
                                                        <li class="city"><a href="">Phú Th?</a></li>
                                                        <li class="city"><a href="">Son La</a></li>
                                                        <li class="city"><a href="">Thái Bình</a></li>
                                                        <li class="city"><a href="">Tuyên Quang</a></li>
                                                        <li class="city"><a href="">Vinh Phúc</a></li>
                                                        <li class="city"><a href="">Yên Bái</a></li>
                                                    </ul>
                                                </div>
                                                
                                                <div class="region-col fl-l clearfix">
                                                    <h3>Mi?n TRUNG - Tây Nguyên</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>Ðà N?ng</strong></a></li>
                                                        <li class="city"><a href=""><strong>Qu?ng Ngãi</strong></a></li>
                                                        <li class="city"><a href=""><strong>Nha Trang-Khánh Hòa</strong></a></li>
                                                        <li class="city"><a href=""><strong>Th?a Thiên-Hu?</strong></a></li>
                                                        <li class="city"><a href=""><strong>Ðà L?t - Lâm Ð?ng</strong></a></li>
                                                        <li class="city"><a href="">Bình Ð?nh</a></li>
                                                        <li class="city"><a href="">Bình Thu?n</a></li>
                                                        <li class="city"><a href="">Ð?k L?k</a></li>
                                                        <li class="city"><a href="">Ðak Nông</a></li>
                                                        <li class="city"><a href="">Gia Lai</a></li>
                                                        
                                                        
                                                    </ul>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href="">Hà Tinh</a></li>
                                                        <li class="city"><a href="">Kon Tum</a></li>
                                                        <li class="city"><a href="">Ninh Thu?n</a></li>
                                                        <li class="city"><a href="">Ngh? An</a></li>
                                                        <li class="city"><a href="">Phú Yên</a></li>
                                                        <li class="city"><a href="">Qu?ng Bình</a></li>
                                                        <li class="city"><a href="">Qu?ng Nam</a></li>
                                                        <li class="city"><a href="">Qu?ng Tr?</a></li>
                                                        <li class="city"><a href="">Thanh Hóa</a></li>
                                                    </ul>
                                                </div>
                                                
                                                 <div class="region-col last fl-l clearfix">
                                                    <h3>Mi?n nam</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>TP. H? Chí Minh</strong></a></li>
                                                        <li class="city"><a href=""><strong>C?n Tho</strong></a></li>
                                                        <li class="city"><a href=""><strong>Bà R?a-Vung Tàu</strong></a></li>
                                                        <li class="city"><a href=""><strong>Cà Mau</strong></a></li>
                                                        <li class="city"><a href="">An Giang</a></li>
                                                        <li class="city"><a href="">B?c Liêu</a></li>
                                                        <li class="city"><a href="">B?n Tre</a></li>
                                                        <li class="city"><a href="">Bình Duong</a></li>
                                                        <li class="city"><a href="">Bình Phu?c</a></li>
                                                        <li class="city"><a href="">Ð?ng Nai</a></li>
                                                        <li class="city"><a href="">Ð?ng Tháp</a></li>
                                                        <li class="city"><a href="">H?u Giang</a></li>
                                                    </ul>
                                                    <ul class="city-list fl-l">                                   	
                                                        <li class="city"><a href="">Kiên Giang</a></li>
                                                        <li class="city"><a href="">Long An</a></li>
                                                        <li class="city"><a href="">Sóc Trang</a></li>
                                                        <li class="city"><a href="">Tây Ninh</a></li>
                                                        <li class="city"><a href="">Ti?n Giang</a></li>
                                                        <li class="city"><a href="">Trà Vinh</a></li>
                                                        <li class="city"><a href="">Vinh Long</a></li>
                                                    </ul>
                                                </div>
                                                
                                            </div>
                                        </div>
                                    </div>
                                    <div class="input-set col-06 mg-l-20 fl-l">
                                        <label for="destination">Noi d?n</label>
                                        <input id="destination" type="text" class="input-txt place" placeholder="Ch?n noi d?n" accesskey="2" tabindex="2"  />
                                        <!-- On focus show block below, temporarily used js to show/hide, need to implement this as current site-->
                                        <div id="destinationSelector" class="place-selector rounded-5 clearfix" style="display:none;">
                                            <div class="inner rel-pos">
                                                <a id="closeDest" class="close" href="" title="Ðóng">Ðóng</a>
                                                <div class="region-col first fl-l clearfix">
                                                    <h3>Mi?n B?c</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>Hà N?i</strong></a></li>
                                                        <li class="city"><a href=""><strong>H?i Phòng</strong></a></li>
                                                        <li class="city"><a href=""><strong>H? Long - Qu?ng Ninh</strong></a></li>
                                                        <li class="city"><a href="">B?c Giang</a></li>
                                                        <li class="city"><a href="">B?c K?n</a></li>
                                                        <li class="city"><a href="">B?c Ninh</a></li>
                                                        <li class="city"><a href="">Cao B?ng</a></li>
                                                        <li class="city"><a href="">Ði?n Biên</a></li>
                                                        <li class="city"><a href="">Hà Giang</a></li>
                                                        <li class="city"><a href="">Hà Nam</a></li>
                                                        <li class="city"><a href="">H?i Duong</a></li>
                                                        <li class="city"><a href="">Hòa Bình</a></li>
                                                    </ul>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href="">Hung Yên</a></li>
                                                        <li class="city"><a href="">Lai Châu</a></li>
                                                        <li class="city"><a href="">L?ng Son</a></li>
                                                        <li class="city"><a href="">Lào Cai</a></li>
                                                        <li class="city"><a href="">Nam Ð?nh</a></li>
                                                        <li class="city"><a href="">Ninh Bình</a></li>
                                                        <li class="city"><a href="">Phú Th?</a></li>
                                                        <li class="city"><a href="">Son La</a></li>
                                                        <li class="city"><a href="">Thái Bình</a></li>
                                                        <li class="city"><a href="">Tuyên Quang</a></li>
                                                        <li class="city"><a href="">Vinh Phúc</a></li>
                                                        <li class="city"><a href="">Yên Bái</a></li>
                                                    </ul>
                                                </div>
                                                
                                                <div class="region-col fl-l clearfix">
                                                    <h3>Mi?n TRUNG - Tây Nguyên</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>Ðà N?ng</strong></a></li>
                                                        <li class="city"><a href=""><strong>Qu?ng Ngãi</strong></a></li>
                                                        <li class="city"><a href=""><strong>Nha Trang-Khánh Hòa</strong></a></li>
                                                        <li class="city"><a href=""><strong>Th?a Thiên-Hu?</strong></a></li>
                                                        <li class="city"><a href=""><strong>Ðà L?t - Lâm Ð?ng</strong></a></li>
                                                        <li class="city"><a href="">Bình Ð?nh</a></li>
                                                        <li class="city"><a href="">Bình Thu?n</a></li>
                                                        <li class="city"><a href="">Ð?k L?k</a></li>
                                                        <li class="city"><a href="">Ðak Nông</a></li>
                                                        <li class="city"><a href="">Gia Lai</a></li>
                                                        
                                                        
                                                    </ul>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href="">Hà Tinh</a></li>
                                                        <li class="city"><a href="">Kon Tum</a></li>
                                                        <li class="city"><a href="">Ninh Thu?n</a></li>
                                                        <li class="city"><a href="">Ngh? An</a></li>
                                                        <li class="city"><a href="">Phú Yên</a></li>
                                                        <li class="city"><a href="">Qu?ng Bình</a></li>
                                                        <li class="city"><a href="">Qu?ng Nam</a></li>
                                                        <li class="city"><a href="">Qu?ng Tr?</a></li>
                                                        <li class="city"><a href="">Thanh Hóa</a></li>
                                                    </ul>
                                                </div>
                                                
                                                 <div class="region-col last fl-l clearfix">
                                                    <h3>Mi?n nam</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>TP. H? Chí Minh</strong></a></li>
                                                        <li class="city"><a href=""><strong>C?n Tho</strong></a></li>
                                                        <li class="city"><a href=""><strong>Bà R?a-Vung Tàu</strong></a></li>
                                                        <li class="city"><a href=""><strong>Cà Mau</strong></a></li>
                                                        <li class="city"><a href="">An Giang</a></li>
                                                        <li class="city"><a href="">B?c Liêu</a></li>
                                                        <li class="city"><a href="">B?n Tre</a></li>
                                                        <li class="city"><a href="">Bình Duong</a></li>
                                                        <li class="city"><a href="">Bình Phu?c</a></li>
                                                        <li class="city"><a href="">Ð?ng Nai</a></li>
                                                        <li class="city"><a href="">Ð?ng Tháp</a></li>
                                                        <li class="city"><a href="">H?u Giang</a></li>
                                                    </ul>
                                                    <ul class="city-list fl-l">                                   	
                                                        <li class="city"><a href="">Kiên Giang</a></li>
                                                        <li class="city"><a href="">Long An</a></li>
                                                        <li class="city"><a href="">Sóc Trang</a></li>
                                                        <li class="city"><a href="">Tây Ninh</a></li>
                                                        <li class="city"><a href="">Ti?n Giang</a></li>
                                                        <li class="city"><a href="">Trà Vinh</a></li>
                                                        <li class="city"><a href="">Vinh Long</a></li>
                                                    </ul>
                                                </div>
                                                
                                            </div>
                                        </div>
                                    </div>
                                    <div class="input-set col-04 mg-l-20   fl-l">
                                        <label for="departDate">Ngày di</label>
                                        <input id="departDate" type="text" class="input-txt date" placeholder="Ch?n ngày di" accesskey="3" tabindex="3"  />
                                    </div>
                                    <div class="input-set col-03 mg-l-20  fl-l">
                                        <label for="returnDate">S? hành khách</label>
                                        <select id="passengerNum" class="styled wd-100 fl-l" accesskey="5"  tabindex="5" >
                                            <option selected="selected">1</option>
                                            <option>2</option>
                                            <option>3</option>
                                            <option>4</option>
                                            <option>5</option>
                                            <option>6</option>
                                            <option>7</option>
                                            <option>8</option>
                                            <option>9</option>
                                            <option>10</option>
                                        </select>
                                    </div>
                                    <div class="input-set fl-r clearfix">
                                        <input id="searchSubmit" type="submit" class="submit-btn search-btn fl-r" value="Tìm Vé"  tabindex="6"  />
                                    </div>
                                    
                                </fieldset>
                            </form>
                        </div>
                	</div>
                </div>
                <!-- / ticket search filter -->
                
                <!-- search result list -->
                <div id="searchResults" class="content-inner clearfix">
                    <!-- search result header -->
                    <div class="search-result-header clearfix">
                        <h1 class="hd-tt fl-l"><img src="images/bus-icon-02.png" alt="" />Vé xe t? <span class="from">TP. H? Chí Minh</span> di <span class="to">Hà N?i</span></h1>
                        <div class="date-picker-nav col-08 clearfix fl-r">  
                            <a class="date-nav-btn rounded-4 prev fl-l" href="">Ngày tru?c</a>
                            <span class="current-date wd-90 fl-l">22/11/2013</span>
                            <a class="date-nav-btn rounded-4 next fl-r" href="">Ngày k? ti?p</a>
                        </div>
                    </div>
                    <!-- /search result header -->
                    
                    <!-- search results filter-->
                    <div class="searh-result-filter pd-tb-15 clearfix">
                        <div class="input-set wd-160 fl-l">
                            <select id="trasporter-list-nav" multiple="multiple">
                                <option value="240">Hòa Thu?n Anh</option>
                                <option value="562">Gia Phúc - Cam Ranh</option>
                                <option value="146">Hà Linh - Q1</option>
                                <option value="167">Minh Dung</option>
                                <option value="563">Nam Phuong</option>
                                <option value="282">Hoàng Long</option>
                                <option value="21">Sinh Tourist</option>
                                <option value="99">Quang H?nh</option>
                                <option value="119">Liên Hung</option>
                                <option value="148">Vi?t Nh?t</option>
                                <option value="195">Cúc Tùng </option>
                                <option value="316">Trà Lan Viên</option>
                                <option value="420">Hanh Cafe</option>
                                <option value="314">TM Brother</option>
                                <option value="4">Phuong Trang</option>
                                <option value="500">An Phú</option>
                                <option value="530">Tâm H?nh</option>
                            </select>
                         </div>
                         <div class="input-set wd-200 mg-l-15 fl-l">
                                <select id="benefit-list-nav" multiple="multiple">
                                    <option value="1">Gh? m?m</option>
                                    <option value="2">Máy l?nh</option>
                                    <option value="3">An trua</option>
                                </select>
                         </div>
                         <div class="input-set wd-150 mg-l-15 fl-l">
                            <select id="start-point-list-nav" multiple="multiple">
                                <option value="1">Hà N?i</option>
                                <option value="2">H?i Phòng</option>
                                <option value="3">Hu?</option>
                            </select>
                         </div>
                         <div class="input-set wd-150 mg-l-15 fl-l">
                            <select id="end-point-list-nav" multiple="multiple">
                                <option value="1">Hà N?i</option>
                                <option value="2">Vinh</option>
                                <option value="3">Ngh? An</option>
                            </select>
                          </div>
                          <div class="input-set wd-130 mg-l-15 fl-l">
                            <select id="raty-nav-input">
                                <option selected="selected" value="">Ðánh giá</option>
                                <option value="1">Gi?m d?n</option>
                                <option value="2">Tang d?n</option>
                            </select>
                          </div>
                          <div class="input-set wd-130 mg-l-15 fl-l">
                            <select id="price-sub-nav">
                                <option selected="selected" value="1">Giá vé</option>
                                <option value="1">Tang d?n</option>
                                <option value="2">Gi?m d?n</option>
                            </select>
                          </div>
                    </div>
                    <!-- /search results filter-->
                    
                    <!-- Results list-->
                    <div class="result-list clearfix">
                        <!-- Result item row-->
                        <div class="result-item clearfix">
                        
                            <!-- Transporter info-->
                            <div class="transporter-col wd-160 fl-l">
                                <p class="transporter-name">AN BÌNH</p>
                                <p class="route">Sài Gòn - Hà N?i</p>
                                <a class="cancelation-policy" href="" original-title="? Tr? vé  tru?c lúc kh?i hành 3 ngày: 5%.<br/>? Tr? vé  tru?c lúc kh?i hành 1 ngày: 10%.<br/>? Tr? vé  tru?c lúc kh?i hành 12 gi?: 50%.<br/>? Tr? vé  trong vòng 12 gi?  tru?c lúc kh?i hành : không hoàn ti?n l?i, tuy nhiên chúng tôi khuy?n khích quý khách h?y vé khi không di d? dành cho cho ngu?i khác và nâng cao uy tín c?a mình trong các l?n mua ti?p theo.   ">Chính sách hu? vé <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                            </div>
                            <!-- /Transporter info-->
                            
                            <!-- /Benefit info-->
                            <div class="benefit-col wd-200 mg-l-15 fl-l">
                            
                                <div class="benefit-icons pd-b-10 clearfix">
                                	
                                    <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                    <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                    <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                    <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                    <div class="more rel-pos fl-l">
                                        <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                        <!--more benefits popover -->
                                        <div class="tip-popover more-benefits-popover clearfix">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                <div class="benefit-label clearfix">
                                                    <div class="beneits-col col-03 mg-l-10 fl-l">
                                                        <p class="icon benefit-drink">Nu?c u?ng</p>
                                                        <p class="icon benefit-aircon">Ði?u hòa</p>
                                                        <p class="icon benefit-blanket">Chan d?p</p>
                                                        <p class="icon benefit-food">Th?c an</p>
                                                        <p class="icon benefit-tissue">Khan l?nh</p>
                                                        <p class="icon benefit-dvd">DVD</p>
                                                    </div>
                                                    <div class="beneits-col col-04 fl-l">
                                                        <p class="icon benefit-wifi">Wifi</p>  
                                                        <p class="icon benefit-charger">X?c pin</p>
                                                        <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                        <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                        <p class="icon benefit-toilet">Toilet</p>
                                                    </div>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                        <!--/more benefits popover -->
                                    </div>
                                </div>
                                
                                
                                
                                <p class="seat-info">Giu?ng n?m 40 ch?</p>
    
                                <p class="more-options">
                                    <a class="detail-info" href="">L?ch trình</a> |
                                    <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                    <a class="ticket-detail-maps" href="">B?n d?</a>
                                </p>
                                
                            </div>
                            <!-- /Benefit info-->
                            
                            <!-- Depart info-->
                            <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                
                                <div class="depart-station rel-pos fl-l">
                                    <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                    TP. H? Chí Minh<br/>
                                                    Ði?n tho?i: 08.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Kh?i hành:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="20:00">20:00</option>
                                        <option value="20:30">20:30</option>
                                   </select>
                                </div>
                                
                                <p class="clr">S? gh? tr?ng: 2</p>
                                
                            </div>
                            <!-- /Depart Info-->
                            
                            <!-- Destination info-->
                            <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                <div class="destination-station rel-pos fl-l">
                                    <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover dest-station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Giáp Bát</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                    Hà N?i<br/>
                                                    Ði?n tho?i: 04.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Ð?n:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                        <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                   </select>
                                </div>
                                
                                <p class="clr">T?ng th?i gian: 32h 15''</p>
    
                            </div>
                            <!-- /Destination info-->
                            
                            <!-- Rating info-->
                            <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                <div class="rating mg-b-10 fl-l">
                                    <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                </div>
                                <div class="rating-info fl-l clr">
                                    <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                    <div class="tip-popover rating-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                <ul class="clearfix">
                                                	<!-- RATINGS AVERAGE RULES using class
                                                        stars-0 (0/5)
                                                        stars-1 (1/5)
                                                        stars-1-half (1.5/5)
                                                        stars-2 (2/5)
                                                        stars-2-half (2.5/5)
                                                        stars-3 (3/5)
                                                        stars-3-half (3.5/5)
                                                        stars-4 (4/5)
                                                        stars-4-half (4.5/5)
                                                        stars-5 (5/5)
                                                        -->
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        T?ng quan:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ch?t lu?ng xe:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ðúng gi?:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        Thái d? ph?c v?:
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                
                                
                            </div>
                            <!-- /Rating info-->
                            
                            <!-- Price info-->
                            <div class="price-col wd-130 mg-l-15 fl-l">
                                <p class="price"><span class="now">950,000<small>d</small></span></p>
                                <a class="ticket-ac-btn booking-btn closed" href="" title="Nh?p d? d?t vé">Ð?t vé</a>
                                <!-- When open the detail info, change to this button-->
                                <a class="ticket-ac-btn open" href="" title="Nh?p d? dóng l?i" style="display: none;">Ðóng l?i</a>
                            </div>
                            <!-- /Price info-->
                            
                            <!-- Ticket Booking Details -->
                            <div class="ticket-booking-details info-block rel-pos rounded-4 clearfix">
                            	<div class="point-arrow push-04"></div>
                                <a class="close tip" href="" title="Ðóng l?i"></a>
                                <form action="" id="frmSeatSelection" method="post">
                                	<fieldset>
                                        <div class="block-inner clearfix">
                                            <!-- Seat selector-->
                                            <div class="seat-selector col-16 fl-l">
                                                <h3 class="section-tt clearfix">CH?N GH?/GIU?NG N?M</h3>
                                                <div class="section-content mg-tb-15 pd-lr-20 clearfix">
                                                    <p>B?m vào gh? tr?ng d? l?a ch?n, b?m vào l?n n?a d? h?y b? l?a ch?n.</p>
                        
                                                    <div class="detail-seat-template-specific-container">
                                                        <div class="detail-seat-template-specific" id="template-1">
                                                        
                                                            <div class="detail-seat-template-specific-child" id="coach-2">
                                                                <div class="coach-name">T?ng 2</div>
                                                                                
                                                                <ul id="Row-1">
                                                                    <li class="  " data-seat-code="IND" data-seat-num="0" title="Gh? s?: IND | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li><li></li><li></li>
                                                                    <li class="  " data-seat-code="DRV" data-seat-num="0" title="Gh? s?: DRV | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-2">
                                                                    <li class="label-seathasSleeper" data-seat-code="C2" data-seat-num="23" title="Gh? s?: C2 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li class="label-seat"><span class="s-d"></span></li>
                                                                    <li class="label-seathasSleeper" data-seat-code="B2" data-seat-num="22" title="Gh? s?: B2 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li class="label-seat"><span class="s-b"></span></li>
                                                                    <li class="label-seathasSleeper" data-seat-code="A2" data-seat-num="21" title="Gh? s?: A2 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">1</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-3">
                                                                    <li class="hasSleeper" data-seat-code="C4" data-seat-num="26" title="Gh? s?: C4 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B4" data-seat-num="25" title="Gh? s?: B4 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A4" data-seat-num="24" title="Gh? s?: A4 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">2</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-4">
                                                                    <li class="hasSleeper" data-seat-code="C6" data-seat-num="29" title="Gh? s?: C6 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B6" data-seat-num="28" title="Gh? s?: B6 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A6" data-seat-num="27" title="Gh? s?: A6 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">3</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-5">
                                                                    <li class="hasSleeper" data-seat-code="C8" data-seat-num="32" title="Gh? s?: C8 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B8" data-seat-num="31" title="Gh? s?: B8 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A8" data-seat-num="30" title="Gh? s?: A8 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">4</span></li>
                                                                </ul>
                                                                <ul id="Row-6">
                                                                    <li class="hasSleeper" data-seat-code="C10" data-seat-num="35" title="Gh? s?: C10 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B10" data-seat-num="34" title="Gh? s?: B10 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A10" data-seat-num="33" title="Gh? s?: A10 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">5</span></li>
                                                                </ul>
                                                                <ul id="Row-7">
                                                                    <li class="hasSleeper" data-seat-code="D10" data-seat-num="40" title="Gh? s?: D10 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D8" data-seat-num="39" title="Gh? s?: D8 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-d"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D6" data-seat-num="38" title="Gh? s?: D6 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D4" data-seat-num="37" title="Gh? s?: D4 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-b"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D2" data-seat-num="36" title="Gh? s?: D2 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">6</span></li>
                                                                </ul>
                                                            </div>
                                                            <div class="detail-seat-template-specific-child" id="coach-1">
                                                                <div class="coach-name">T?ng 1</div>
                                                                <span class="entry-door">C?a lên</span>
                                                                <span class="driver"></span>
                                                                
                                                                <ul id="Row-1">
                                                                    <li class="  " data-seat-code="IND" data-seat-num="0" title="Gh? s?: IND | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li></li>
                                                                    <li></li>
                                                                    <li class="  " data-seat-code="DRV" data-seat-num="0" title="Gh? s?: DRV | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-2">
                                                                    <li class="label-seathasSleeper" data-seat-code="C1" data-seat-num="3" title="Gh? s?: C1 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li class="label-seat"><span class="s-d"></span></li>
                                                                    <li class="label-seathasSleeper" data-seat-code="B1" data-seat-num="2" title="Gh? s?: B1 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li class="label-seat"><span class="s-b"></span></li>
                                                                    <li class="label-seathasSleeper" data-seat-code="A1" data-seat-num="1" title="Gh? s?: A1 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">1</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-3">
                                                                    <li class="hasSleeper" data-seat-code="C3" data-seat-num="6" title="Gh? s?: C3 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B3" data-seat-num="5" title="Gh? s?: B3 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeperseat-avail" data-seat-code="A3" data-seat-num="4" title="Gh? s?: A3 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">2</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-4">
                                                                    <li class="hasSleeper" data-seat-code="C5" data-seat-num="9" title="Gh? s?: C5 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B5" data-seat-num="8" title="Gh? s?: B5 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A5" data-seat-num="7" title="Gh? s?: A5 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">3</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-5">
                                                                    <li class="hasSleeper" data-seat-code="C7" data-seat-num="12" title="Gh? s?: C7 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B7" data-seat-num="11" title="Gh? s?: B7 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A7" data-seat-num="10" title="Gh? s?: A7 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">4</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-6">
                                                                    <li class="hasSleeper" data-seat-code="C9" data-seat-num="15" title="Gh? s?: C9 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B9" data-seat-num="14" title="Gh? s?: B9 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A9" data-seat-num="13" title="Gh? s?: A9 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">5</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-7">
                                                                    <li class="hasSleeper" data-seat-code="D9" data-seat-num="20" title="Gh? s?: D9 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D7" data-seat-num="19" title="Gh? s?: D7 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-d"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D5" data-seat-num="18" title="Gh? s?: D5 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D3" data-seat-num="17" title="Gh? s?: D3 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-b"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D1" data-seat-num="16" title="Gh? s?: D1 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">6</span></li>
                                                                </ul>
                                                            </div>
                                                            
                                                        </div>
                                                    </div>
                                                    
                                                    <ul class="seat-indicator fl-r">
                                                        <li><span class="available-seat">Gh? tr?ng</span></li>
                                                        <li><span class="booked-seat">Gh? dã d?t</span></li>
                                                        <li><span class="select-seat">Ðang ch?n</span></li>
                                                    </ul>
                                                    
                                                </div>    
                                                
                                            </div>
                                           
                                            <!-- /Seat selector-->
                                            
                                            <!-- > Ticket info-->
                                            <div id="ticket-info" class="ticket-info clearfix fl-r">
                                                <h3 class="section-tt clearfix">Thông tin vé xe</h3>
                                                <div class="section-content mg-tb-15 pd-lr-20">
                                                    <table class="info-table" width="100%" border="0" cellpadding="0">
                                                        <tr>
                                                          <td>Chi?u di:</td>
                                                          <td><strong>Sài Gòn - Mui Né </strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Xu?t phát:</td>
                                                          <td><strong>Khu ph? Tây</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Ðích d?n:</td>
                                                          <td><strong>VP Mui Né</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Gi? xu?t phát:</td>
                                                          <td><strong>08:00</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Gi? d?n:</td>
                                                          <td><strong>13:00</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>S? gh?:</td>
                                                          <td><strong>A1,B1</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Giá vé:</td>
                                                          <td><strong>950,000/ngu?i</strong></td>
                                                        </tr>
                                                        <tr class="total">
                                                            <td width="43%" class="total-tt">T?ng ti?n: </td>
                                                            <td width="57%" class="amount">1,900,000 VNÐ</td>
                                                        </tr>
                                                    </table>
                                                    
                                                    <a class="action-btn cont-btn mg-t-20 fl-r" href="">Ti?p t?c</a>
                                                </div>
                                            </div>
                                            <!--/Ticket info-->
                                            
                                        </div>
                                        
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                	</fieldset>
                                </form>
                                
                            </div>
                            
                            <!-- /Ticket Booking Details -->
                            
                        </div>
                        <!-- /Result item row-->
                        
                        <!-- Result item row-->
                        <div class="result-item clearfix">
                        
                            <!-- Transporter info-->
                            <div class="transporter-col wd-160 fl-l">
                                <p class="transporter-name">AN BÌNH</p>
                                <p class="route">Sài Gòn - Hà N?i</p>
                                <a class="cancelation-policy" href="" original-title="? Tr? vé  tru?c lúc kh?i hành 3 ngày: 5%.<br/>? Tr? vé  tru?c lúc kh?i hành 1 ngày: 10%.<br/>? Tr? vé  tru?c lúc kh?i hành 12 gi?: 50%.<br/>? Tr? vé  trong vòng 12 gi?  tru?c lúc kh?i hành : không hoàn ti?n l?i, tuy nhiên chúng tôi khuy?n khích quý khách h?y vé khi không di d? dành cho cho ngu?i khác và nâng cao uy tín c?a mình trong các l?n mua ti?p theo.   ">Chính sách hu? vé <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                            </div>
                            <!-- /Transporter info-->
                            
                            <!-- /Benefit info-->
                            <div class="benefit-col wd-200 mg-l-15 fl-l">
                            
                                <div class="benefit-icons pd-b-10 clearfix">
                                    <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                    <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                    <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                    <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                    <div class="more rel-pos fl-l">
                                        <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                        <!--more benefits popover -->
                                        <div class="tip-popover more-benefits-popover clearfix">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                <div class="benefit-label clearfix">
                                                    <div class="beneits-col col-03 mg-l-10 fl-l">
                                                        <p class="icon benefit-drink">Nu?c u?ng</p>
                                                        <p class="icon benefit-aircon">Ði?u hòa</p>
                                                        <p class="icon benefit-blanket">Chan d?p</p>
                                                        <p class="icon benefit-food">Th?c an</p>
                                                        <p class="icon benefit-tissue">Khan l?nh</p>
                                                        <p class="icon benefit-dvd">DVD</p>
                                                    </div>
                                                    <div class="beneits-col col-04 fl-l">
                                                        <p class="icon benefit-wifi">Wifi</p>  
                                                        <p class="icon benefit-charger">X?c pin</p>
                                                        <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                        <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                        <p class="icon benefit-toilet">Toilet</p>
                                                    </div>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                        <!--/more benefits popover -->
                                    </div>
                                </div>
                                
                                
                                
                                <p class="seat-info">Giu?ng n?m 40 ch?</p>
    
                                <p class="more-options">
                                    <a class="detail-info" href="">L?ch trình</a> |
                                    <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                    <a class="ticket-detail-maps" href="">B?n d?</a>
                                </p>
                                
                            </div>
                            <!-- /Benefit info-->
                            
                            <!-- Depart info-->
                            <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                
                                <div class="depart-station rel-pos fl-l">
                                    <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                    TP. H? Chí Minh<br/>
                                                    Ði?n tho?i: 08.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Kh?i hành:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="20:00">20:00</option>
                                        <option value="20:30">20:30</option>
                                   </select>
                                </div>
                                
                                <p class="clr">S? gh? tr?ng: 0</p>
                                
                            </div>
                            <!-- /Depart Info-->
                            
                            <!-- Destination info-->
                            <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                <div class="destination-station rel-pos fl-l">
                                    <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover dest-station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Giáp Bát</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                    Hà N?i<br/>
                                                    Ði?n tho?i: 04.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Ð?n:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                        <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                   </select>
                                </div>
                                
                                <p class="clr">T?ng th?i gian: 32h 15''</p>
    
                            </div>
                            <!-- /Destination info-->
                            
                            <!-- Rating info-->
                            <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                <div class="rating mg-b-10 fl-l">
                                    <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                </div>
                                <div class="rating-info fl-l clr">
                                    <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                    <div class="tip-popover rating-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                <ul class="clearfix">
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        T?ng quan:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ch?t lu?ng xe:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ðúng gi?:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        Thái d? ph?c v?:
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                
                                
                            </div>
                            <!-- /Rating info-->
                            
                            <!-- Price info-->
                            <div class="price-col wd-130 mg-l-15 fl-l">
                                <p class="price">950,000<small>d</small></p>
                                <span class="no-ticket rounded-4">H?t vé</span>
                            </div>
                            <!-- /Price info-->
                            
                        </div>
                        <!-- /Result item row-->
                        
                        <!-- Result item row-->
                        <div class="result-item clearfix">
                        
                            <!-- Transporter info-->
                            <div class="transporter-col wd-160 fl-l">
                                <p class="transporter-name">AN BÌNH</p>
                                <p class="route">Sài Gòn - Hà N?i</p>
                                <a class="cancelation-policy" href="" original-title="? Tr? vé  tru?c lúc kh?i hành 3 ngày: 5%.<br/>? Tr? vé  tru?c lúc kh?i hành 1 ngày: 10%.<br/>? Tr? vé  tru?c lúc kh?i hành 12 gi?: 50%.<br/>? Tr? vé  trong vòng 12 gi?  tru?c lúc kh?i hành : không hoàn ti?n l?i, tuy nhiên chúng tôi khuy?n khích quý khách h?y vé khi không di d? dành cho cho ngu?i khác và nâng cao uy tín c?a mình trong các l?n mua ti?p theo.   ">Chính sách hu? vé <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                            </div>
                            <!-- /Transporter info-->
                            
                            <!-- /Benefit info-->
                            <div class="benefit-col wd-200 mg-l-15 fl-l">
                            
                                <div class="benefit-icons pd-b-10 clearfix">
                                    <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                    <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                    <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                    <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                    <div class="more rel-pos fl-l">
                                        <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                        <!--more benefits popover -->
                                        <div class="tip-popover more-benefits-popover clearfix">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                <div class="benefit-label clearfix">
                                                    <div class="beneits-col col-03 mg-l-10 fl-l">
                                                        <p class="icon benefit-drink">Nu?c u?ng</p>
                                                        <p class="icon benefit-aircon">Ði?u hòa</p>
                                                        <p class="icon benefit-blanket">Chan d?p</p>
                                                        <p class="icon benefit-food">Th?c an</p>
                                                        <p class="icon benefit-tissue">Khan l?nh</p>
                                                        <p class="icon benefit-dvd">DVD</p>
                                                    </div>
                                                    <div class="beneits-col col-04 fl-l">
                                                        <p class="icon benefit-wifi">Wifi</p>  
                                                        <p class="icon benefit-charger">X?c pin</p>
                                                        <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                        <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                        <p class="icon benefit-toilet">Toilet</p>
                                                    </div>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                        <!--/more benefits popover -->
                                    </div>
                                </div>
                                
                                
                                
                                <p class="seat-info">Giu?ng n?m 40 ch?</p>
    
                                <p class="more-options">
                                    <a class="detail-info" href="">L?ch trình</a> |
                                    <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                    <a class="ticket-detail-maps" href="">B?n d?</a>
                                </p>
                                
                            </div>
                            <!-- /Benefit info-->
                            
                            <!-- Depart info-->
                            <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                
                                <div class="depart-station rel-pos fl-l">
                                    <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                    TP. H? Chí Minh<br/>
                                                    Ði?n tho?i: 08.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Kh?i hành:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="20:00">20:00</option>
                                        <option value="20:30">20:30</option>
                                   </select>
                                </div>
                                
                                <p class="clr">S? gh? tr?ng: 2</p>
                                
                            </div>
                            <!-- /Depart Info-->
                            
                            <!-- Destination info-->
                            <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                <div class="destination-station rel-pos fl-l">
                                    <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover dest-station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Giáp Bát</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                    Hà N?i<br/>
                                                    Ði?n tho?i: 04.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Ð?n:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                        <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                   </select>
                                </div>
                                
                                <p class="clr">T?ng th?i gian: 32h 15''</p>
    
                            </div>
                            <!-- /Destination info-->
                            
                            <!-- Rating info-->
                            <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                <div class="rating mg-b-10 fl-l">
                                    <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                </div>
                                <div class="rating-info fl-l clr">
                                    <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                    <div class="tip-popover rating-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                <ul class="clearfix">
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        T?ng quan:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ch?t lu?ng xe:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ðúng gi?:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        Thái d? ph?c v?:
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                
                                
                            </div>
                            <!-- /Rating info-->
                            
                            <!-- Price info-->
                            <div class="price-col wd-130 mg-l-15 fl-l">
                                <p class="price"><span class="now">950,000<small>d</small></span></p>
                                <a class="ticket-ac-btn closed" href="" title="Nh?p vào dây d? xem s? di?n tho?i d?t vé">Ði?n tho?i</a>
                                <!-- When open the detail info, change to this button-->
                                <a class="ticket-ac-btn open" href="" title="Nh?p d? dóng l?i" style="display: none;">Ðóng l?i</a>
                            </div>
                            <!-- /Price info-->
                            
                            <!-- Phone Booking Details -->
                            <div class="ticket-booking-details info-block rel-pos rounded-4 clearfix">
                            	<div class="point-arrow push-04"></div>
                                <a class="close tip" href="" title="Ðóng l?i"></a>
                                <div class="block-inner clearfix">
                                 
                                    <!-- > Ticket info-->
                                    <div id="ticket-info" class="ticket-info clearfix fl-l">
                                        <h3 class="section-tt clearfix">Thông tin vé xe</h3>
                                        <div class="section-content mg-tb-15 pd-lr-20">
                                            <table class="info-table" width="100%" border="0" cellpadding="0">
                                                <tr>
                                                  <td>Chi?u di:</td>
                                                  <td><strong>Sài Gòn - Mui Né </strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Xu?t phát:</td>
                                                  <td><strong>Khu ph? Tây</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Ðích d?n:</td>
                                                  <td><strong>VP Mui Né</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Gi? xu?t phát:</td>
                                                  <td><strong>08:00</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Gi? d?n:</td>
                                                  <td><strong>13:00</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>S? gh?:</td>
                                                  <td><strong>A1,B1</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Giá vé:</td>
                                                  <td><strong>950,000/ngu?i</strong></td>
                                                </tr>
                                                <tr class="total">
                                                    <td width="43%" class="total-tt">T?ng ti?n: </td>
                                                    <td width="57%" class="amount">1,900,000 VNÐ</td>
                                                </tr>
                                            </table>
                                     
                                        </div>
                                    </div>
                                    <!--/Ticket info-->
                                    
                                    <!-- Transporter Phones-->
                                    <div class="phones-list clearfix fl-l">
                                    	<h3 class="section-tt clearfix">ÐI?N THO?I Ð?T VÉ</h3>
                                        <div class="section-content mg-tb-15 pd-lr-20 clearfix">
                                        	<h4>HÃNG XE THU KHUYÊN</h4>
                                            <p>B?n xe Mi?n Ðông</p>
                                            <p class="font-18 or-txt pd-b-5">0988 881 112<br>0982 111 777</p>
                                            <p>B?n xe Giáp Bát</p>
                                            <p class="font-18 or-txt pd-b-5">0988 881 112<br>0982 111 777</p>
                                        </div>
                                    </div>
                                    <!-- Transporter Phones-->
                                    
                                    <!-- Feedback-->
                                    <div class="client-feedback clearfix fl-l">
                                    	<h3 class="section-tt clearfix">PH?N H?I C?A KHÁCH HÀNG</h3>
                                        <div class="section-content mg-tb-15 pd-lr-20 clearfix">
                                            <p class="font-16 bolder-txt al-c">Thông tin vé chính xác?</p>
                                            <form action="" method="post" id="route-info-review-form" >
                                            	<fieldset>
                                                    <input value="" name="" type="hidden" />
                                                    <input name="VoteUp" id="rir-vote-up" type="hidden">
                                                    <div class="feedback-btns clearfix">
                                                    	<!-- When user click one of these buttons, the other button must hide-->
                                                        <a class="tip feedback-like-button fl-l" href="" title="Nh?p d? ph?n h?i thông tin Chính xác">Chính xác</a>
                                                        <a class="tip feedback-dislike-button fl-l" href="" title="Nh?p d? ph?n h?i thông tin không chính xác">Không chính xác</a>
                                                    </div>
                                                    
                                                    <!--like reply, show when click on like button-->
                                                    <div class="feedback-response rounded-4 pd-10-15" style="display: none;">
                                                    	<div class="point-arrow"></div>
														<p> C?m on b?n dã g?i thông tin ph?n h?i v? nhà xe, tuy?n du?ng. vexere.com luôn c? g?ng h?t s?c d? cung c?p thông tin v? các nhà xe chính xác nh?t có th?! </p>
													</div>
                                                    <!--/like reply-->
                                                    
                                                    <!--dislike-feedback, show when click on button-->
                                                    <div class="dislike-feedback rounded-4 pd-10-15 clearfix"  style="display: none;">
                                                    	<div class="point-arrow red"></div>
                                                        <label>
                                                            <input name="FareVoteDown" id="FareVoteDown" value="false" type="checkbox" />Giá vé không chính xác
                                                        </label>
                                                        <label>
                                                            <input name="TimeVoteDown" id="TimeVoteDown" value="false" type="checkbox" />Th?i gian ch?y không chính xác
                                                        </label>
                                                        <label>
                                                            <input name="NotAnswerVoteDown" id="NotAnswerVoteDown" type="checkbox" />
Ði?n tho?i không b?t máy
                                                        </label>
                                                        <label>
                                                            <input name="PhoneVoteDown" id="PhoneVoteDown" type="checkbox" />
                                                            S? phone không chính xác
                                                        </label>
                                                        <label>Thông tin khác :</label>
                                                        <textarea cols="10" rows="4" name="Comment"></textarea>
                                                        
                                                        <a class="action-btn feedback-send-button" href="#">G?i</a>
                                                    </div>
                                                    <!-- /dislike-feedback-->
                                            	</fieldset>
                                            </form>
                                            
                                        </div>
                                    </div>
                                    <!-- /Feedback-->
                                    <div class="section-note col-15 pd-lr-20 clr clearfix">
                                    	<p>Luu ý: m?t s? nhà xe thay d?i chính sách giá vé thu?ng xuyên do dó thông tin có th? không chính xác, mong các b?n thông c?m. Chúng tôi luôn vui lòng nh?n góp ý và ph?n h?i c?a c?ng d?ng d? luôn có thông tin nhanh và chính xác nh?t. Xin c?m on!</p>
                                    </div>
                                    
                                </div>
                                
                                <div class="section-footer">
                                    <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                </div>
                                
                            </div>
                            
                            <!-- /Phone Booking Details -->
                            
                        </div>
                        <!-- /Result item row-->
                        
                        <!-- Result item row-->
                        <div class="result-item promo clearfix">
                        	<div class="item-content clearfix">
                                <!-- Transporter info-->
                                <div class="transporter-col wd-160 fl-l">
                                    <p class="transporter-name">AN BÌNH</p>
                                    <p class="route">Sài Gòn - Thái Bình</p>
                                    <a class="cancelation-policy" href="" original-title="? Tr? vé  tru?c lúc kh?i hành 3 ngày: 5%.<br/>? Tr? vé  tru?c lúc kh?i hành 1 ngày: 10%.<br/>? Tr? vé  tru?c lúc kh?i hành 12 gi?: 50%.<br/>? Tr? vé  trong vòng 12 gi?  tru?c lúc kh?i hành : không hoàn ti?n l?i, tuy nhiên chúng tôi khuy?n khích quý khách h?y vé khi không di d? dành cho cho ngu?i khác và nâng cao uy tín c?a mình trong các l?n mua ti?p theo.">Chính sách hu? vé <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                </div>
                                <!-- /Transporter info-->
                                
                                <!-- /Benefit info-->
                                <div class="benefit-col wd-200 mg-l-15 fl-l">
                                
                                    <div class="benefit-icons pd-b-10 clearfix">
                                        <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                        <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                        <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                        <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                        <div class="more rel-pos fl-l">
                                            <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                            <!--more benefits popover -->
                                            <div class="tip-popover more-benefits-popover clearfix">
                                                <div class="tip-inner rounded-4 rel-pos clearfix">
                                                    <div class="tip-arrow"></div>
                                                    <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                    <div class="benefit-label clearfix">
                                                        <div class="beneits-col col-03 mg-l-10 fl-l">
                                                            <p class="icon benefit-drink">Nu?c u?ng</p>
                                                            <p class="icon benefit-aircon">Ði?u hòa</p>
                                                            <p class="icon benefit-blanket">Chan d?p</p>
                                                            <p class="icon benefit-food">Th?c an</p>
                                                            <p class="icon benefit-tissue">Khan l?nh</p>
                                                            <p class="icon benefit-dvd">DVD</p>
                                                        </div>
                                                        <div class="beneits-col col-04 fl-l">
                                                            <p class="icon benefit-wifi">Wifi</p>  
                                                            <p class="icon benefit-charger">X?c pin</p>
                                                            <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                            <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                            <p class="icon benefit-toilet">Toilet</p>
                                                        </div>
                                                    </div>
                                                    <div class="popover-footer">
                                                        <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                        H? th?ng vé xe l?n nh?t Vi?t Nam
                                                    </div>
                                                </div>
                                            </div>
                                            <!--/more benefits popover -->
                                        </div>
                                    </div>
                                    
                                    
                                    
                                    <p class="seat-info">Giu?ng n?m 40 ch?</p>
        
                                    <p class="more-options">
                                        <a class="detail-info" href="">L?ch trình</a> |
                                        <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                        <a class="ticket-detail-maps" href="">B?n d?</a>
                                    </p>
                                    
                                </div>
                                <!-- /Benefit info-->
                                
                                <!-- Depart info-->
                                <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                    
                                    <div class="depart-station rel-pos fl-l">
                                        <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                        <div class="tip-popover station-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                    <p class="address">
                                                        Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                        TP. H? Chí Minh<br/>
                                                        Ði?n tho?i: 08.38.123.456<br/>
                                                        Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                        V? trí di?m dón khách: C?ng A - Khu A1 
                                                    </p>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                            
                                        </div>
                                    </div>
                                   
                                   <div class="input-set rel-pos clearfix clr">
                                       <label class="fl-l">Kh?i hành:</label>
                                       <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                            <option selected="selected" value="20:00">20:00</option>
                                            <option value="20:30">20:30</option>
                                       </select>
                                    </div>
                                    
                                    <p class="clr">S? gh? tr?ng: 2</p>
                                    
                                </div>
                                <!-- /Depart Info-->
                                
                                <!-- Destination info-->
                                <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                    <div class="destination-station rel-pos fl-l">
                                        <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                        <div class="tip-popover dest-station-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p><strong>B?n xe Giáp Bát</strong></p>
                                                    <p class="address">
                                                        Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                        Hà N?i<br/>
                                                        Ði?n tho?i: 04.38.123.456<br/>
                                                        Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                        V? trí di?m dón khách: C?ng A - Khu A1 
                                                    </p>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                            
                                        </div>
                                    </div>
                                   
                                   <div class="input-set rel-pos clearfix clr">
                                       <label class="fl-l">Ð?n:</label>
                                       <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                            <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                            <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                       </select>
                                    </div>
                                    
                                    <p class="clr">T?ng th?i gian: 32h 15''</p>
        
                                </div>
                                <!-- /Destination info-->
                                
                                <!-- Rating info-->
                                <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                    <div class="rating mg-b-10 fl-l">
                                        <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                    </div>
                                    <div class="rating-info fl-l clr">
                                        <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                        <div class="tip-popover rating-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                    <ul class="clearfix">
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                            </div>
                                                            T?ng quan:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                            </div>
                                                            Ch?t lu?ng xe:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                            </div>
                                                            Ðúng gi?:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                            </div>
                                                            Thái d? ph?c v?:
                                                        </li>
                                                    </ul>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                    
                                    
                                </div>
                                <!-- /Rating info-->
                                
                                <!-- Price info-->
                                <div class="price-col rel-pos wd-130 mg-l-15 fl-l">
                                    <p class="promo-tag">-<span class="font-18">30</span>%</p>
                                    <p class="price">
                                        <s class="old">950,000d</s>
                                        <span class="now">950,000<small>d</small></span>
                                    </p>
                                    <a class="ticket-ac-btn closed" href=""  title="Nh?p vào dây d? xem s? di?n tho?i d?t vé">Ði?n tho?i</a>
                                    <!-- When open the detail info, change to this button-->
                                    <a class="ticket-ac-btn open" href="" title="Nh?p d? dóng l?i" style="display: none;">Ðóng l?i</a>
                                </div>
                                <!-- /Price info-->
                             </div>
                             
                             <!--  Routes, Photos, Rating Tabs content-->
                             <div class="ticket-detail-tabs rel-pos clearfix" style="display: block;">
                             	<a class="tabs-close-btn" href="" title="Ðóng l?i">Ðóng l?i</a>
                                <div class="tab-list-container">
                                
                                    <ul class="tabs-list">
                                        <li><a href="" title="L?ch trình xe An Bình" rel="tab1" class="tip tabs ticket-route-tab active">L?ch trình</a></li>
                                        <li><a href="" title="B?n d?" rel="tab2" class="tip tabs ticket-map-tab">B?n d?</a></li>
                                        <li><a href="" title="Hình ?nh xe An Bình" rel="tab3" class="tip  tabs ticket-images-tab">Hình ?nh</a></li>
                                        <li><a href="" title="Ðánh giá xe An Bình" rel="tab4" class="tip tabs ticket-review-tab">Ðánh giá</a></li>
                                    </ul>
                                    
                                    <div class="loading">
                                        <img src="images/loading.gif"  alt=""/>
                                        Ðang t?i n?i dung...
                                    </div>
                                    
                                    <!-- Route Schedule tab content-->
                                    <div class="tab-pane tab1 current">
                                   		<div class="tab-content-inner">
                                            <h2 class="hd-tt">L?ch trình xe Camel Travel t? <span class="from">Sài Gòn</span> di <span class="to">Hà N?i</span></h2>
                                            <table class="list-route-table" cellpadding="0" cellspacing="0">
                                                <thead>
                                                    <tr>
                                                        <th style="width: 20%;">Ði?m di (d?n)</th>
                                                        <th style="width: 30%;">Ði?n tho?i</th>
                                                        <th style="width: 35%;">Ð?a ch?</th>
                                                        <th style="width: 15%;">Th?i gian di (d?n)</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                        <tr>
                                                            <td>B?n xe Mi?n Ðông</td>
                                                            <td>
                                        04 36 250 739  - 04 36 250 659                                    <br>
                                                            </td>
                                                            <td>292 Ðinh B? Linh - Bình Th?nh - H? Chí Minh</td>
                                                            <td>
                                                                <div class="input-set">
                                                                    <select class="boardingTime styled-02">
                                                                        <option selected="selected" value="0">19:00</option>
                                                                    </select>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>Phan Thi?t</td>
                                                            <td>04 36 250 739  - 04 36 250 659</td>
                                                            <td>Phan Thi?t - Bình Thu?n</td>
                                                            <td><span class="time">21:30</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>Nha Trang</td>
                                                            <td>04 36 250 739  - 04 36 250 659</td>
                                                            <td>Nha Trang - Khánh Hoà</td>
                                                            <td><span class="time">07:00 + 1n</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>Hà N?i</td>
                                                            <td>04 36 250 659 - 04 36 250 739</td>
                                                            <td>459 Tr?n Khát Chân - Hai Bà Trung - Hà N?i</td>
                                                            <td>
                                                                <div class="input-set">
                                                                    <select class="boardingTime styled-02">
                                                                        <option selected="selected" value="0">21:00 +1n</option>
                                                                    </select>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                    </div>
                                    <!-- Route Schedule tab content-->
                                    
                                    <!-- Map tab content-->
                                    <div class="tab-pane tab2">
                                   		<div class="map-container pd-15">
                                        	<!-- place map here-->
                                        	<div class="map_canvas" id="map-canvas-1334-0" style="width: 100%; height: 480px; position: relative; background-color: rgb(229, 227, 223);"></div>
                                            <!-- place map here-->
                                            
                                        </div>
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                    </div>
                                    <!-- Map tab content-->
                                    
                                    <!-- Photos tab content-->
                                    <div class="tab-pane tab3">
                                   		<div class="tab-content-inner">
                                            <h2 class="hd-tt al-c">Hình ?nh hãng xe <span class="from">An Bình</span></h2>
                                            <!-- if no photo-->
                                            <p class="no-photo hl-txt pd-15 al-c" style="display: none">www.VeXeRe.com dang liên h? nhà xe An Bình d? có du?c nh?ng hình ?nh th?c t? nh?t cho quý khách...</p>
                                            <!-- /if no photo-->
                                            
                                            <!-- Photo gallery-->
                                            <div class="photo-slider">
                                                <div class="slider-wrapper rounded-4">
                                                    <div class="transporter-photo nivoSlider clearfix">
                                                        <img alt="slide1" src="photos/1.jpg" width="640" height="400"  data-transition="fade" />
                                                        <img alt="slide2" src="photos/2.jpg" width="640" height="400" data-transition="fade" />
                                                        <img alt="slide3" src="photos/3.jpg" width="640" height="400" data-transition="fade" />
                                                        <img alt="slide4" src="photos/4.jpg" width="640" height="400" data-transition="fade" />
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- /Photo gallery-->
                                            
                                            
                                        </div>
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                    </div>
                                    <!-- /Photos tab content-->
                                    
                                    <!-- Rating tab content-->
                                    <div class="tab-pane tab4">
                                   		<div class="tab-content-inner">
                                            <h2 class="hd-tt">Ðánh giá t?ng th? nhà xe <span class="from">An Bình</span></h2>
                                            
                                            <!-- general rating -->
                                            <div class="general-rating clearfix">
                                            
                                            	<div class="rate-result-box-large col-08 fl-l">
                                                	<div class="clearfix">
                                                        <div class="total-rate col-03 or-txt fl-l">4.0</div>
                                                        <div class="col-04 fl-l clearfix">
                                                            <p class="col-03 al-c font-16 mg-b-5">Trên <strong class="font-22 or-txt">5.0</strong></p>
                                                            <div class="rating-large">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                                <!-- RATINGS AVERAGE RULES using class
                                                                stars-0 (0/5)
                                                                stars-1 (1/5)
                                                                stars-1-half (1.5/5)
                                                                stars-2 (2/5)
                                                                stars-2-half (2.5/5)
                                                                stars-3 (3/5)
                                                                stars-3-half (3.5/5)
                                                                stars-4 (4/5)
                                                                stars-4-half (4.5/5)
                                                                stars-5 (5/5)
                                                                -->
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <p class="rate-result-footer al-c">Ðánh giá c?a <strong class="or-txt">50</strong> khách hàng dã di chuy?n xe này</p>
                                                	
                                                </div>
                                                <ul class="rating-rank-list-large col-04 fl-l">
                                                    <li>Ch?t lu?ng xe:<span class="fl-r">4.0</span></li>
                                                    <li>Ðúng gi?:<span class="fl-r">3.6</span></li>
                                                    <li>Thái d? ph?c v?:<span class="fl-r">4.5</span></li>
                                                </ul>
                                            </div>
                                            <!-- /general rating -->
                                            
                                            <!-- Comments list-->
                                            <div class="client-comment-list clearfix">
                                            	<h2 class="hd-tt clearfix">
                                                	<a class="comment-btn fl-r" href="">
                                                    Vi?t dánh giá c?a b?n</a>Ðánh giá c?a t?ng khách hàng
                                                </h2>
                                                <ul class="comments-list clearfix">
                                                	
                                                    <li class="comment-item clearfix">
                                                    	<div class="col-04 fl-l">
                                                        	<div class="rating with-num">
                                                            	<span class="fl-r"><strong class="font-14 or-txt">4</strong>/<strong class="font-14 or-txt">5.0</strong></span>
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                                
                                                            </div>
                                                            <ul class="rating-rank-list-small fl-l">
                                                                <li>Ch?t lu?ng xe:<span class="fl-r">4.0</span></li>
                                                                <li>Ðúng gi?:<span class="fl-r">3.6</span></li>
                                                                <li>Thái d? ph?c v?:<span class="fl-r">4.5</span></li>
                                                            </ul>
                                                        </div>
                                                        
                                                      	<div class="comment-item-content clearfix">
                                                        	<h3 class="comment-author"><em class="fl-r">Chuy?n di ngày: 01/06/2013 - Ðang ngày: 08/12/2013</em><span class="author">H. An</span></h3>
                                                            <p>Chuy?n di cung khá an toàn, ph?c v? cung t?t. Nhung dôi khi xe ch?y hoi nguy hi?m (tôi c?m th?y hoi nhanh) và ph?c v? dôi lúc không du?c l?ch s?, vui v? và hoà nhã cho l?m. C?n có nh?ng bu?i tu tu?ng cho nhân viên b?i hành khách luôn c?n du?c tôn tr?ng nên thái d? ph?c v? c?n ph?i d?t lên hàng d?u. Ð?ng th?i tài x? cung c?n có thái d? h?p tác hon không ch? v?i nhân viên </p>
                                                            <div class="comment-footer clearfix">
                                                            	<p class="check fl-l">Ðã du?c Vexere.com xác nh?n ngu?i dánh giá dã di chuy?n xe này.</p>
                                                                <p class="comment-share fl-r">
                                                                	<a class="tip social-link zing fl-r" title="Chia s? trên Zing" href=""></a>
                                                                    
                                                                    <a class="tip social-link gg-plus fl-r" title="Chia s? trên Google+" href=""></a>
                                                                    <a class="tip social-link fb fl-r" title="Chia s? trên Facebook" href=""></a>
                                                                    Chia s?
                                								</p>
                                                            </div>
                                                        </div>
                                                        
                                                    </li>
                                                    
                                                    <li class="comment-item clearfix">
                                                    	<div class="col-04 fl-l">
                                                        	<div class="rating with-num">
                                                            	<span class="fl-r"><strong class="font-14 or-txt">4</strong>/<strong class="font-14 or-txt">5.0</strong></span>
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                                
                                                            </div>
                                                            <ul class="rating-rank-list-small fl-l">
                                                                <li>Ch?t lu?ng xe:<span class="fl-r">4.0</span></li>
                                                                <li>Ðúng gi?:<span class="fl-r">3.6</span></li>
                                                                <li>Thái d? ph?c v?:<span class="fl-r">4.5</span></li>
                                                            </ul>
                                                        </div>
                                                        
                                                      	<div class="comment-item-content clearfix">
                                                        	<h3 class="comment-author"><em class="fl-r">Chuy?n di ngày: 01/06/2013 - Ðang ngày: 08/12/2013</em><span class="author">L. Ng?c</span></h3>
                                                            <p>Chuy?n di cung khá an toàn, ph?c v? cung t?t. Nhung dôi khi xe ch?y hoi nguy hi?m (tôi c?m th?y hoi nhanh) và ph?c v? dôi lúc không du?c l?ch s?, vui v? và hoà nhã cho l?m. C?n có nh?ng bu?i tu tu?ng cho nhân viên b?i hành khách luôn c?n du?c tôn tr?ng nên thái d? ph?c v? c?n ph?i d?t lên hàng d?u. Ð?ng th?i tài x? cung c?n có thái d? h?p tác hon không ch? v?i nhân viên </p>
                                                            <div class="comment-footer clearfix">
                                                            	<p class="check fl-l">Ðã du?c Vexere.com xác nh?n ngu?i dánh giá dã di chuy?n xe này.</p>
                                                                <p class="comment-share fl-r">
                                                                	<a class="tip social-link zing fl-r" title="Chia s? trên Zing" href=""></a>
                                                                    
                                                                    <a class="tip social-link gg-plus fl-r" title="Chia s? trên Google+" href=""></a>
                                                                    <a class="tip social-link fb fl-r" title="Chia s? trên Facebook" href=""></a>
                                                                    Chia s?
                                								</p>
                                                            </div>
                                                        </div>
                                                        
                                                    </li>
                                                    
                                                </ul>
                                                
                                                <h2 class="pd-t-10 clearfix">
                                                	<a class="comment-btn fl-r" href="">Vi?t dánh giá c?a b?n</a>
                                                </h2>
                                                
                                            </div>
                                            <!-- /Comments list-->
                                            
                                        </div>
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                    </div>
                                    <!-- /Rating tab content-->
                                    
                                </div>
                            </div>
                             
                             <!-- / Routes, Photos, Rating Tabs content-->
                             
                             <div class="item-footer clearfix">
                                <div class="brand fl-l">Duy nh?t có t?i <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="vexere.com" /> <span>H? th?ng vé xe l?n nh?t Vi?t Nam</span></div>
                                <div class="share fl-r">
                                    <a class="email-share fl-r" href=""><img src="<%= ResolveUrl("~/Content/images/email-icon.png")%>" alt="" /> Email</a>
                                    <div class="sc-like fl-r"><img src="<%= ResolveUrl("~/Content/images/gg-like.png")%>" alt="" /></div>
                                    <div class="sc-like fl-r"><img src="<%= ResolveUrl("~/Content/images/fb-like.png")%>" alt="" /></div>
                                    Chia s? thông tin gi?m giá v?i b?n bè 
                                </div>
                            </div>
                        	
                        </div>
                        <!-- /Result item row-->
                        
                        <!-- Result item row-->
                        <div class="result-item clearfix">
                        	<div class="item-content clearfix">
                                <!-- Transporter info-->
                                <div class="transporter-col wd-160 fl-l">
                                    <p class="transporter-name">AN BÌNH</p>
                                    <p class="route">Sài Gòn - Thái Bình</p>
                                </div>
                                <!-- /Transporter info-->
                                
                                <!-- /Benefit info-->
                                <div class="benefit-col wd-200 mg-l-15 fl-l">
                                
                                    <div class="benefit-icons pd-b-10 clearfix">
                                        <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                        <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                        <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                        <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                        <div class="more rel-pos fl-l">
                                            <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                            <!--more benefits popover -->
                                            <div class="tip-popover more-benefits-popover clearfix">
                                                <div class="tip-inner rounded-4 rel-pos clearfix">
                                                    <div class="tip-arrow"></div>
                                                    <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                    <div class="benefit-label clearfix">
                                                        <div class="beneits-col col-03 mg-l-10 fl-l">
                                                            <p class="icon benefit-drink">Nu?c u?ng</p>
                                                            <p class="icon benefit-aircon">Ði?u hòa</p>
                                                            <p class="icon benefit-blanket">Chan d?p</p>
                                                            <p class="icon benefit-food">Th?c an</p>
                                                            <p class="icon benefit-tissue">Khan l?nh</p>
                                                            <p class="icon benefit-dvd">DVD</p>
                                                        </div>
                                                        <div class="beneits-col col-04 fl-l">
                                                            <p class="icon benefit-wifi">Wifi</p>  
                                                            <p class="icon benefit-charger">X?c pin</p>
                                                            <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                            <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                            <p class="icon benefit-toilet">Toilet</p>
                                                        </div>
                                                    </div>
                                                    <div class="popover-footer">
                                                        <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                        H? th?ng vé xe l?n nh?t Vi?t Nam
                                                    </div>
                                                </div>
                                            </div>
                                            <!--/more benefits popover -->
                                        </div>
                                    </div>
                                    
                                    
                                    
                                    <p class="seat-info">Giu?ng n?m 40 ch?</p>
        
                                    <p class="more-options">
                                        <a class="detail-info" href="">L?ch trình</a> |
                                        <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                        <a class="ticket-detail-maps" href="">B?n d?</a>
                                    </p>
                                    
                                </div>
                                <!-- /Benefit info-->
                                
                                <!-- Depart info-->
                                <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                    
                                    <div class="depart-station rel-pos fl-l">
                                        <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                        <div class="tip-popover station-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                    <p class="address">
                                                        Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                        TP. H? Chí Minh<br/>
                                                        Ði?n tho?i: 08.38.123.456<br/>
                                                        Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                        V? trí di?m dón khách: C?ng A - Khu A1 
                                                    </p>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                            
                                        </div>
                                    </div>
                                   
                                   <div class="input-set rel-pos clearfix clr">
                                       <label class="fl-l">Kh?i hành:</label>
                                       <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                            <option selected="selected" value="20:00">20:00</option>
                                            <option value="20:30">20:30</option>
                                       </select>
                                    </div>
                                    
                                    <p class="clr">S? gh? tr?ng: 2</p>
                                    
                                </div>
                                <!-- /Depart Info-->
                                
                                <!-- Destination info-->
                                <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                    <div class="destination-station rel-pos fl-l">
                                        <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                        <div class="tip-popover dest-station-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p><strong>B?n xe Giáp Bát</strong></p>
                                                    <p class="address">
                                                        Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                        Hà N?i<br/>
                                                        Ði?n tho?i: 04.38.123.456<br/>
                                                        Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                        V? trí di?m dón khách: C?ng A - Khu A1 
                                                    </p>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                            
                                        </div>
                                    </div>
                                   
                                   <div class="input-set rel-pos clearfix clr">
                                       <label class="fl-l">Ð?n:</label>
                                       <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                            <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                            <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                       </select>
                                    </div>
                                    
                                    <p class="clr">T?ng th?i gian: 32h 15''</p>
        
                                </div>
                                <!-- /Destination info-->
                                
                                <!-- Rating info-->
                                <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                    <div class="rating mg-b-10 fl-l">
                                        <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                    </div>
                                    <div class="rating-info fl-l clr">
                                        <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                        <div class="tip-popover rating-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                    <ul class="clearfix">
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                            </div>
                                                            T?ng quan:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                            </div>
                                                            Ch?t lu?ng xe:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                            </div>
                                                            Ðúng gi?:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                            </div>
                                                            Thái d? ph?c v?:
                                                        </li>
                                                    </ul>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                    
                                    
                                </div>
                                <!-- /Rating info-->
                                
                                <!-- Price info-->
                                <div class="price-col rel-pos wd-130 mg-l-15 fl-l">
                                    <p class="price">
                                        <span class="updating">Ðang c?p nh?t giá</span>
                                    </p>
                                    <a class="ticket-ac-btn closed" href="" title="Nh?p vào dây d? xem s? di?n tho?i d?t vé">Ði?n tho?i</a>
                                    <!-- When open the detail info, change to this button-->
                                    <a class="ticket-ac-btn open" href="" style="display: none;">Ðóng l?i</a>
                                </div>
                                <!-- /Price info-->
                             </div>
                        	
                        </div>
                        <!-- /Result item row-->
                        
                    </div>
                    <!-- Search result list -->
                    
          		</div>
                
                <!-- More transporters  -->
                <div class="content-inner pd-tb-10 clearfix">
                    <h2 class="hd-tt">Xem thêm các chuy?n xe khác t? <span class="from">TP. H? Chí Minh</span> di <span class="to"> Hà N?i</span></h2>
                    <ul class="link-list">
                        <li><a href="">Xe Mai Linh</a></li>
                        <li><a href="">Xe Phu?ng Hoàng</a></li>
                        <li><a href="">Xe Hi?n Phu?c</a></li>
                        <li><a href="">Xe Phuong Trang</a></li>
                        <li><a href="">Xe Phuong Trang</a></li>
                        <li><a href="">Xe Kumho</a></li>
                        <li><a href="">Xe Sinh Tourist</a></li>
                        <li><a href="">Xe Hoàng Long</a></li>
                        <li><a href="">Xe A Ba</a></li>
                        <li><a href="">Xe Hà Linh</a></li>  
                    </ul>
                </div>
                <!-- More transporters  -->
                
                <!-- Route info  -->
                <div class="route-info common-border content-inner rounded-4 clearfix">
                    <h2 class="hd-tt mg-15"> <img src="images/route-icon.png" alt="" />Thông tin tuy?n du?ng <span class="from">TP. H? Chí Minh</span> - <span class="to">Hà N?i</span></h2>
                    <div class="route-illus clearfix">
                        <div class="start-point col-07 al-c fl-l">
                            <p class="bolder-txt font-14">TP H? Chí Minh</p>
                            <p class="hl-txt">B?n xe Mi?n Ðông</p>
                        </div>
                        <div class="distance col-09 al-c fl-l">
                            <p class="bolder-txt font-14">L? trình 1729 km</p>
                            <p>T?ng th?i gian hành trình: <strong class="font-14">32h</strong></p>
                            <p>Giá vé trung bình: <strong class="or-txt font-16">950.000 d/vé</strong></p>
                        </div>
                        <div class="end-point col-06 al-c fl-l">
                            <p class="bolder-txt font-14">Hà N?i</p>
                            <p class="hl-txt">B?n xe Giáp Bát</p>
                        </div>
                    </div>
                    
                    <p class="route-desc pd-15-20">Tuy?n TP H? Chí Minh - Hà N?i dài kho?ng 1725 km, qua 17 t?nh, thành d?c qu?c l? 1A. Trung bình m?i ngày có kho?ng 20 chuy?n xe khách ch?y tuy?n du?ng này b?t d?u t? 5h d?n11h30 do 7 nhà xe, An Bình, A Ba, Camel Travel, Thu Khuyên,  The Sinh Tourist, Hoàng Long và H?nh Cafe v?n hành. Th?i gian di chuy?n trên ch?ng kho?ng 32 gi? d?ng h?. Giá vé trên tuy?n du?ng này dao d?ng kho?ng 900.000-1.200.000 d?ng</p>
                
                </div>
                <!-- Route info  -->
                
                <!-- Back links-->
                <div class="back-links odd-row clearfix">
                    <div class="content-inner">
                        <h2>Liên k?t</h2>
                        <ul id="transporters" class="link-list">
                            <li><a href="">Xe Mai Linh</a></li>
                            <li><a href="">Xe Phu?ng Hoàng</a></li>
                            <li><a href="">Xe Hi?n Phu?c</a></li>
                            <li><a href="">Xe Phuong Trang</a></li>
                            <li><a href="">Xe Phuong Trang</a></li>
                            <li><a href="">Xe Kumho</a></li>
                            <li><a href="">Xe Sinh Tourist</a></li>
                            <li><a href="">Xe Hoàng Long</a></li>
                            <li><a href="">Xe A Ba</a></li>
                            <li><a href="">Xe Hà Linh</a></li>
                            <li><a href="">Xe Hu? Nghia</a></li>
                            <li><a href="">Xe Chín Nghia</a></li>
                            <li><a href="">Xe Thành Bu?i</a></li>
                            <li><a href="">Xe Hoàng Oanh</a></li>
                            <li><a href="">Xe Thu?n Th?o</a></li>
                            <li><a href="">Xe Cúc Tùng</a></li>
                            <li><a href="">Xe Van Lang</a></li>
                            <li><a href="">Xe Minh Th?ng</a></li>
                        </ul>
                        
                        <ul id="stations" class="link-list">
                            <li><a href="">B?n xe Mi?n Ðông</a></li>
                            <li><a href="">B?n xe Mi?n Tây</a></li>
                            <li><a href="">B?n xe Giáp Bát</a></li>
                            <li><a href="">B?n xe M? Ðình</a></li>
                            <li><a href="">B?n xe Gia Lâm</a></li>
                            <li><a href="">B?n xe Nu?c Ng?m</a></li>
                            <li><a href="">B?n xe 91B C?n Tho</a></li>
                            <li><a href="">B?n xe TT Ðà N?ng</a></li>
                            <li><a href="">B?n xe Ðà N?ng</a></li>
                            <li><a href="">B?n xe Tam B?c</a></li>
                            <li><a href="">B?n xe Ni?m Nghia</a></li>
                            <li><a href="">B?n xe C?u Rào</a></li>
                            <li><a href="">B?n xe Vinh</a></li>
                            <li><a href="">B?n xe Thanh Hoá</a></li>
                            <li><a href="">B?n xe Nha Trang</a></li>
                        </ul>
                        
                        <ul id="tickets	" class="link-list">
                            <li><a href="">Vé xe T?t</a></li>
                            <li><a href="">Giá vé xe T?t</a></li>
                            <li><a href="">Vé xe Thu?n Th?o T?t 2014</a></li>
                            <li><a href="">Vé xe Phuong Trang T?t 2014</a></li>
                            <li><a href="">Vé xe Thành Bu?i T?t 2014</a></li>
                            <li><a href="">Vé xe Hoàng Long T?t 2014</a></li>
                            <li><a href="">Vé xe Vi?t Tân Phát T?t 2014</a></li>
                            <li><a href="">Vé xe Chín Nghia T?t 2014</a></li>
                            <li><a href="">Vé xe Cúc Tùng T?t 2014</a></li>
                            <li><a href="">Vé xe T?t B?n xe Mi?n Ðông</a></li>
                            <li><a href="">Vé xe T?t B?n xe Mi?n Tây</a></li>
                            <li><a href="">Vé xe T?t B?n xe M? Ðình</a></li>
                            <li><a href="">Vé xe T?t B?n xe Giáp Bát</a></li>
                        </ul>
                    </div>
                </div>
                <!-- Back links-->
            </div>
            <!-- footer-->
            <div id="footer">
            	<div class="content-inner clearfix">
                	<div class="semi-footer clearfix">
              			<div class="col-06 fl-l">
                        	<h3 class="h3-tt">V? chúng tôi</h3>
                            <ul class="footer-links">
                            	<li><a href="">Tin t?c</a></li>
                                <li><a href="">Gi?i thi?u</a></li>
                                <li><a href="">Liên h?</a></li>
                                <li><a href="">Ði?u kho?n & Ði?u ki?n</a></li>
                            </ul>
                        </div>
                        
                        <div class="alt col-06 fl-l">
                        	<h3 class="h3-tt">H? tr?</h3>
                            <ul class="footer-links">
                            	<li><a href="">Hu?ng d?n thanh toán</a></li>
                                <li><a href="">Co ch? gi?i quy?t tranh ch?p</a></li>
                                <li><a href="">Quy ch? Vé Xe R?</a></li>
                            </ul>
                        </div>
                        
                        <div class="alt col-08 fl-r">
                        	<h3 class="h3-tt">K?t n?i v?i chúng tôi</h3>
                            
                        	<div class="social col-08 clearfix">
                                <a class="social-icon fb" title="Facebook" href="">Facebook</a>
                                <a class="social-icon google-plus" title="Google+" href="">Google+</a>
                                <a class="social-icon zing" title="Zing" href="">Zing</a>
                                <a class="social-icon tw" title="Twitter" href="">Twitter</a>
                                <a class="social-icon yt" title="Youtube" href="">Youtube</a> 
                            </div>
                            
                            <div class="hotline-ctn col-08 clearfix">
                                <span class="hotline">Hotline:</span> <span class="hotline-num">0969.52.33.77 - 0909.10.89.69</span>
                            </div>
                            
                            <div class="input-set rel-pos clearfix">
                            	<input class="input-txt" placeholder="Nh?p d?a ch? email c?a b?n" />
                                <button class="submit">G?i</button>
                            </div>
                            
                     	</div>
                        
                     </div>
                     
                     <div id="copyright" class="clearfix">
                        <a class="logo-footer fl-l mg-r-30" href=""><img src="<%= ResolveUrl("~/Content/images/logo-footer.png")%>" alt="" /></a>
                        <div class="copyright-txt col-14 fl-l mg-r-10">
                            <p>B?n quy?n © 2012 thu?c v? VeXeRe.Com</p>
                            <p>Ð?a ch?: 8C Ch? Ð?ng T?, P.7, Q.Tân Bình, TP. H? Chí Minh, Vi?t Nam - ÐT: 0909 108 969<br />
                            Gi?y ch?ng nh?n ÐKKD s? 0312387105 do S? KH& ÐT TP. H? Chí Minh c?p l?n d?u ngày 25/7/2013</p>
                        </div>
                        <div class="register fl-l"><a href=""><img src="<%= ResolveUrl("~/Content/images/dk.png")%>" alt="" /></a></div>
                        <a id="chat" class="chat-btn" href="">Chat with us</a>
                    </div>
                
              </div>
            
            </div>
            <!-- /footer-->
        </div>
	</div>
    
    <!-- JS-->
    <!--script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script-->
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery-1.10.2.min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery-ui.js") %>"></script>
	<script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.customSelect.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.tipsy.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.nivo.slider.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jcarousellite.min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.watermark.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/ui.dropdownchecklist-1.4-min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/vxr.js") %>"></script>
    
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Vxr.Front.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>VeXeRe.com</title>
<link rel="stylesheet" type="text/css" media="screen" href="<%= ResolveUrl("~/Content/css/reset.css") %>" />
<link rel="stylesheet" type="text/css" media="print" href="<%= ResolveUrl("~/Content/css/print.css") %>" />
<link rel="stylesheet" type="text/css" media="screen" href="<%= ResolveUrl("~/Content/css/ui-css.css") %>" />
<link rel="stylesheet" type="text/css" media="screen" href="<%= ResolveUrl("~/Content/css/styles.css") %>"/>
<link rel="stylesheet" type="text/css" media="screen" href="<%= ResolveUrl("~/Content/css/nivo-slider.css") %>" />

</head>

<body>
<!--These lines are used to detect any specific browser on even specific OS (Mac, Window, Linux) without using css hacking-->
	<!--[if gt IE 8]><div class="ie ie9"><![endif]-->
    <!--[if IE 8]><div class="ie ie8"><![endif]-->
    <!--[if IE 7]><div class="ie ie7"><![endif]-->
    <!--[if IE 6]><div class="ie ie6"><![endif]-->
    <!--[if lt IE 6]><div class="ie ie5"><![endif]-->
    <!--[if !IE]>--><div class="ie0"><!--<![endif]-->
        <div id="page">
            <!-- >header -->
            <div id="header" class="clearfix">
              <div class="content-inner clearfix">
                <a class="logo mg-t-20 col-08 fl-l" href="" title="vexere.com"><img src="<%= ResolveUrl("~/Content/images/logo.png") %>" width="311" height="75" alt="vexere.com" /></a>
                
                <div class="top-header rel-pos clearfix fl-r">
                	<div class="sc-like col-03 fl-l"><img src="<%= ResolveUrl("~/Content/images/fb-like.png") %>" alt="" /></div> <!-- To be replaced with fb like frame-->
                    <div class="sc-like col-02 fl-l"><img src="<%= ResolveUrl("~/Content/images/gg-like.png") %>" alt="" /></div> <!-- To be replaced with google like frame-->
                    <!-- >Hotline -->
                    <a id="hotline" class="hd-common-bg hotline-btn col-03 fl-l" href="">Hotline</a>
                    <div id="hotlineContent" class="clearfix">
                    	<div class="rel-pos">
                        	<div class="point-arrow col-01"></div>
                            <div class="hotline-content col-05 rounded-4 shadow clearfix">
                            	<p class="al-c"><strong>Vui lòng g?i cho chúng tôi d? du?c ph?c v? và tu v?n</strong></p>
                                <h3><span>HOTLINE</span></h3>
                                <p class="num"><strong>0969 52 33 77<br>0909 10 89 69</strong></p>
                            </div>
                        </div>
                    </div>
                    <!-- /Hotline -->
                    
                    <!-- >Login -->
                    <a id="login" class="hd-common-bg login-btn col-03 fl-l" href="">ÐANG NH?P</a>
                    <div id="loginContent" class="clearfix">
                    	<div class="rel-pos">
                        	<div class="point-arrow"></div>
                            <div class="login-content rounded-4 shadow clearfix">
                            	<form id="loginForm" method="" action="">
                                	<fieldset>
                                    	<div class="input-set clearfix">
                                        	<input class="input-txt" type="text" placeholder="Email" />
                                            <input class="input-txt" type="password" placeholder="M?t kh?u" />
                                            
                                            
                                        </div>
                                        <div class="input-set clearfix">
                                        	<a class="fl-r" href="">Quên m?t kh?u?</a>
                                        	<label class="check-box"><input class="checkbox" type="checkbox" />Ghi nh?</label>
                                        </div>
                                        <div class="submit-ctn"><a class="hd-common-bg signin-btn" href="">Ðang nh?p</a></div>
                                        <h3><span>Ho?c dang nh?p v?i</span></h3>
                                        <div class="social-login clearfix">
                                        	<a class="hd-common-bg fb fl-l" href="" title="Ðang nh?p v?i tài kho?n Facebook">Facebook</a>
                                            <a class="hd-common-bg gg-plus fl-l" href="" title="Ðang nh?p v?i tài kho?n Google+">Google+</a>
                                            <a class="hd-common-bg yahoo fl-l" href="" title="Ðang nh?p v?i tài kho?n Yahoo">Yahoo</a>
                                            <a class="hd-common-bg gg fl-l" href="" title="Ðang nh?p v?i tài kho?n Google">Google</a>
                                        </div>
                                        <h3><strong>B?n chua có tài kho?n?</strong></h3>
                                        <div class="reg-ctn"><a class="hd-common-bg reg-btn" href="">Ðang ký</a></div>
                                    </fieldset>
                                </form>
                            </div>
                        </div>
                    </div>
                    <!-- /Login -->
                    
                    <!-- >Language Selector -->
                    <div id="lang">
   						<!-- add class "disabled" when it is not selected -->
                        <a id="en" class="lang-icon en-flag fl-r disabled" title="English"><img src="<%= ResolveUrl("~/Content/images/us.png") %>" width="22" height="16" alt="English" /></a>
                        <a id="vn" class="lang-icon vn-flag fl-r" title="Ti?ng Vi?t"><img src="<%= ResolveUrl("~/Content/images/vn.png") %>" width="22" height="16" alt="Ti?ng Vi?t" /></a>
                    </div>
                    <!-- /Language Selector -->
                    
                </div>
                
                <!-- > Main Menu-->
                <div id="topNav" class="fl-r">
                    <ul>
                        <li class="first"><a href="">Trang ch?</a></li>
                        <li><a href="">Gi?i thi?u</a></li>
                        <li><a href="">Ki?m tra vé</a></li>
                        <li><a href="">Nhà xe</a>
                            <ul class="submenu">
                            	<li class="first">VEXERE.com liên k?t v?i hon 1000 nhà xe kh?p 3 mi?n</li>
                                <li><a href="">Xe Phuong Trang</a></li>
                                <li><a href="">Xe Thành Bu?i</a></li>
                                <li><a href="">Xe Hu? Nghia</a></li>
                                <li><a href="">Xe Mai Linh</a></li>
                                <li><a href="">Xe Phu?ng Hoàng</a></li>
                                <li><a href="">Xe Hoa Mai</a></li>
                                <li><a href="">Xe Hoàng Long</a></li>
                                <li><a href="">Xe Chín Nghia</a></li>
                                <li><a href="">Xe Thu?n Th?o</a></li>
                                <li><a href="">Xe Vi?t Tân Phát</a></li>
                                <li><a href="">Xe H?nh Cafe</a></li>
                                <li><a href="">Xe Kumho Samco</a></li>
                                <li><a href="">Xe Cúc Tùng</a></li>
                                <li><a href="">Xe Sinh Tourist</a></li>
                                <li><a href="">Xe Van Lang</a></li>
                                <li><a href="">Xe Gia Phúc</a></li>
                                <li><a href="">Xe Ti?n Oanh</a></li>
                                <li><a href="">Xe Minh Th?ng</a></li>
                                <li><a href="">Xe Hà Linh</a></li>
                                <li><a href="">Xe Ki?u Nga</a></li>
                            </ul>
                        </li>
                        <li><a href="#">Tin t?c</a></li>
                        <li class="last"><a href="#">Liên h?</a></li>
                    </ul>
                </div>
                <!-- /Main Menu-->
              </div> 
            </div>
            <!-- /header -->
            
            <!--Breadcumbs-->
            <div id="breadcumbs">
            	<div class="content-inner">
                    <a href="">Trang ch?</a> &gt; <span>Vé xe t? <span ID="FromTitle" runat="server"></span> di Hà N?i</span>
               	</div>
            </div>
            <!--/Breadcumbs-->
            
            <!-- >main content -->
            <div id="main" class="clearfix">
            
            	<!-- Case 1: 2 Ads banners-->
                <div class="content-inner ads-ctn clearfix pd-tb-20">
                	<a href="" class="fl-l"><img src="<%= ResolveUrl("~/Content/images/ads-banner-01.jpg") %>" alt="" /></a>
                    <a href="" class="fl-r"><img src="<%= ResolveUrl("~/Content/images/ads-banner-02.jpg") %>" alt="" /></a>
                </div>
                <!-- /Case 1: Ads banners-->
                
                <!-- Case 2: single Ads banner-->
                <div class="ads-ctn content-inner clearfix pd-tb-20" style="display: none;">
                	<a href="" class="fl-l"><img src="<%= ResolveUrl("~/Content/images/ads-banner-full.jpg") %>" alt="" /></a>
                </div>
                <!-- /Case 2: single Ads banner-->
                
                <!-- Ticket Search Guide-->
                <div class="search-guide content-inner rounded-3 rel-pos clearfix">
                	<h3 class="guide-tt"><span class="font-18">Hu?ng d?n tìm vé c?a</span> <strong class="hl-txt font-16">VeXeRe.com</strong> – <strong class="or-txt font-14">H? th?ng vé xe l?n nh?t Vi?t Nam</strong></h3>
                    <div class="guide-content clearfix">
                    	<div class="initial-guide">
                        	<p>B?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-booking.png") %>" alt="" /> d? ch?n gh? và d?t vé tr?c tuy?n ho?c b?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-phone.png")%>"  alt="" />d? xem s? di?n tho?i hãng xe b?n mu?n d?t vé.</p>
                            <a href="" class="switch-btn rounded-4 read-more">Xem thêm</a>
                        </div>
                        <div class="full-guide">
                        	<p>Luu ý: <strong>B?ng giá vé du?i du?c áp d?ng cho ngày 22/11/2013</strong>, Ð? xem giá vé c?a các ngày khác vui lòng ch?n ngày di ? m?c ch?nh s?a tìm ki?m bên du?i và b?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-search.png")%>" alt="" /> ho?c nút   <img src="<%= ResolveUrl("~/Content/images/guide-btn-prev-date.png")%>"  alt="" />ho?c <img src="<%= ResolveUrl("~/Content/images/guide-btn-nxt-date.png")%>"  alt="" /> </p>
                        	<p>B?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-booking.png")%>" alt="" /> d? ch?n gh? và d?t vé tr?c tuy?n ho?c b?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-phone.png") %>"  alt="" />d? xem s? di?n tho?i hãng xe b?n mu?n d?t vé.</p>
                            <p>Thay d?i k?t qu? tìm ki?m b?ng cách nh?p vào <strong>Noi di</strong>: Ví d?: <img src="<%= ResolveUrl("~/Content/images/guide-btn-place-01.png")%>"  alt="" /> và <strong>Noi d?n</strong>: Ví d?: <img src="<%= ResolveUrl("~/Content/images/guide-btn-place-02.png")%>"  alt="" /> r?i b?m nút <img src="<%= ResolveUrl("~/Content/images/guide-btn-search.png") %>" alt="" /></p>
                            <p>Rê chu?t lên các bi?u tu?ng <img src="<%= ResolveUrl("~/Content/images/guide-btn-benefit-icons.png")%>"  alt="" /> d? xem các ti?n ích mi?n phí dành cho hành khách c?a hãng xe.</p>
                            <p>B?m ch?n gi? kh?i hành b?ng cách nh?p chu?t và ch?n: <img src="<%= ResolveUrl("~/Content/images/guide-btn-hour-slt.png")%>"  alt="" /> <strong class="hl-txt">Vexere.com</strong> s? cho bi?t gi? d?n ? c?t Noi d?n: <img src="<%= ResolveUrl("~/Content/images/guide-btn-hour-day-slt.png")%>"  alt="" /></p>
                            <p>Rê chu?t lên các bi?u tu?ng <img src="<%= ResolveUrl("~/Content/images/guide-btn-rate.png")%>"  alt="" /> d? xem dánh giá v? ch?t lu?ng nhà xe. Nh?p chu?t lên nút nhu <span class="hl-txt">5 dánh giá</span> <img src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>"  alt="" />d? xem dánh giá chi ti?t.  Ð? vi?t dánh giá ch?t lu?ng nhà xe n?u quý khách dã t?ng du?c ph?c v?, vui lòng nh?p lên nút  <img src="<%= ResolveUrl("~/Content/images/guide-btn-comment.png") %>"  alt="" /></p>
                            <p>B?m ch?n lên liên k?t: <u class="hl-txt">L?ch trình</u> | <u class="hl-txt">Hình ?nh</u> | <u class="hl-txt">B?n d?</u> d? xem thêm chi ti?t thông tin c?a hành trình.</p>
                            <a href="" class="switch-btn rounded-4 close">Ðóng l?i</a>
                        </div>
                    </div>
                	
                </div>
                <!-- /Ticket Search Guide-->

                <!-- ticket search filter -->
                <div id="ticketSearchFilter" class="ticket-search-filter common-bg mg-tb-20 pd-tb-10 clearfix">
                	<div class="content-inner clearfix">
                        <div class="search-content">
                            <form id="filterForm" method="" action="">
                                <fieldset>  
                                    <div class="input-set col-06 fl-l">
                                        <label for="departPlace">Noi di</label>
                                        <input id="departPlace" type="text" class="input-txt place" placeholder="Ch?n noi di" accesskey="1" tabindex="1" />
                                        
                                        <!-- On focus show block below, temporarily used js to show/hide, need to implement this as current site-->
                                        <div id="departPlaceSelector" class="place-selector rounded-5 clearfix" style="display:none;">
                                            <div class="inner rel-pos">
                                                <a id="closeDept" class="close" href="">Ðóng</a>
                                                <div class="region-col first fl-l clearfix">
                                                    <h3>Mi?n B?c</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>Hà N?i</strong></a></li>
                                                        <li class="city"><a href=""><strong>H?i Phòng</strong></a></li>
                                                        <li class="city"><a href=""><strong>H? Long - Qu?ng Ninh</strong></a></li>
                                                        <li class="city"><a href="">B?c Giang</a></li>
                                                        <li class="city"><a href="">B?c K?n</a></li>
                                                        <li class="city"><a href="">B?c Ninh</a></li>
                                                        <li class="city"><a href="">Cao B?ng</a></li>
                                                        <li class="city"><a href="">Ði?n Biên</a></li>
                                                        <li class="city"><a href="">Hà Giang</a></li>
                                                        <li class="city"><a href="">Hà Nam</a></li>
                                                        <li class="city"><a href="">H?i Duong</a></li>
                                                        <li class="city"><a href="">Hòa Bình</a></li>
                                                    </ul>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href="">Hung Yên</a></li>
                                                        <li class="city"><a href="">Lai Châu</a></li>
                                                        <li class="city"><a href="">L?ng Son</a></li>
                                                        <li class="city"><a href="">Lào Cai</a></li>
                                                        <li class="city"><a href="">Nam Ð?nh</a></li>
                                                        <li class="city"><a href="">Ninh Bình</a></li>
                                                        <li class="city"><a href="">Phú Th?</a></li>
                                                        <li class="city"><a href="">Son La</a></li>
                                                        <li class="city"><a href="">Thái Bình</a></li>
                                                        <li class="city"><a href="">Tuyên Quang</a></li>
                                                        <li class="city"><a href="">Vinh Phúc</a></li>
                                                        <li class="city"><a href="">Yên Bái</a></li>
                                                    </ul>
                                                </div>
                                                
                                                <div class="region-col fl-l clearfix">
                                                    <h3>Mi?n TRUNG - Tây Nguyên</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>Ðà N?ng</strong></a></li>
                                                        <li class="city"><a href=""><strong>Qu?ng Ngãi</strong></a></li>
                                                        <li class="city"><a href=""><strong>Nha Trang-Khánh Hòa</strong></a></li>
                                                        <li class="city"><a href=""><strong>Th?a Thiên-Hu?</strong></a></li>
                                                        <li class="city"><a href=""><strong>Ðà L?t - Lâm Ð?ng</strong></a></li>
                                                        <li class="city"><a href="">Bình Ð?nh</a></li>
                                                        <li class="city"><a href="">Bình Thu?n</a></li>
                                                        <li class="city"><a href="">Ð?k L?k</a></li>
                                                        <li class="city"><a href="">Ðak Nông</a></li>
                                                        <li class="city"><a href="">Gia Lai</a></li>
                                                        
                                                        
                                                    </ul>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href="">Hà Tinh</a></li>
                                                        <li class="city"><a href="">Kon Tum</a></li>
                                                        <li class="city"><a href="">Ninh Thu?n</a></li>
                                                        <li class="city"><a href="">Ngh? An</a></li>
                                                        <li class="city"><a href="">Phú Yên</a></li>
                                                        <li class="city"><a href="">Qu?ng Bình</a></li>
                                                        <li class="city"><a href="">Qu?ng Nam</a></li>
                                                        <li class="city"><a href="">Qu?ng Tr?</a></li>
                                                        <li class="city"><a href="">Thanh Hóa</a></li>
                                                    </ul>
                                                </div>
                                                
                                                 <div class="region-col last fl-l clearfix">
                                                    <h3>Mi?n nam</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>TP. H? Chí Minh</strong></a></li>
                                                        <li class="city"><a href=""><strong>C?n Tho</strong></a></li>
                                                        <li class="city"><a href=""><strong>Bà R?a-Vung Tàu</strong></a></li>
                                                        <li class="city"><a href=""><strong>Cà Mau</strong></a></li>
                                                        <li class="city"><a href="">An Giang</a></li>
                                                        <li class="city"><a href="">B?c Liêu</a></li>
                                                        <li class="city"><a href="">B?n Tre</a></li>
                                                        <li class="city"><a href="">Bình Duong</a></li>
                                                        <li class="city"><a href="">Bình Phu?c</a></li>
                                                        <li class="city"><a href="">Ð?ng Nai</a></li>
                                                        <li class="city"><a href="">Ð?ng Tháp</a></li>
                                                        <li class="city"><a href="">H?u Giang</a></li>
                                                    </ul>
                                                    <ul class="city-list fl-l">                                   	
                                                        <li class="city"><a href="">Kiên Giang</a></li>
                                                        <li class="city"><a href="">Long An</a></li>
                                                        <li class="city"><a href="">Sóc Trang</a></li>
                                                        <li class="city"><a href="">Tây Ninh</a></li>
                                                        <li class="city"><a href="">Ti?n Giang</a></li>
                                                        <li class="city"><a href="">Trà Vinh</a></li>
                                                        <li class="city"><a href="">Vinh Long</a></li>
                                                    </ul>
                                                </div>
                                                
                                            </div>
                                        </div>
                                    </div>
                                    <div class="input-set col-06 mg-l-20 fl-l">
                                        <label for="destination">Noi d?n</label>
                                        <input id="destination" type="text" class="input-txt place" placeholder="Ch?n noi d?n" accesskey="2" tabindex="2"  />
                                        <!-- On focus show block below, temporarily used js to show/hide, need to implement this as current site-->
                                        <div id="destinationSelector" class="place-selector rounded-5 clearfix" style="display:none;">
                                            <div class="inner rel-pos">
                                                <a id="closeDest" class="close" href="" title="Ðóng">Ðóng</a>
                                                <div class="region-col first fl-l clearfix">
                                                    <h3>Mi?n B?c</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>Hà N?i</strong></a></li>
                                                        <li class="city"><a href=""><strong>H?i Phòng</strong></a></li>
                                                        <li class="city"><a href=""><strong>H? Long - Qu?ng Ninh</strong></a></li>
                                                        <li class="city"><a href="">B?c Giang</a></li>
                                                        <li class="city"><a href="">B?c K?n</a></li>
                                                        <li class="city"><a href="">B?c Ninh</a></li>
                                                        <li class="city"><a href="">Cao B?ng</a></li>
                                                        <li class="city"><a href="">Ði?n Biên</a></li>
                                                        <li class="city"><a href="">Hà Giang</a></li>
                                                        <li class="city"><a href="">Hà Nam</a></li>
                                                        <li class="city"><a href="">H?i Duong</a></li>
                                                        <li class="city"><a href="">Hòa Bình</a></li>
                                                    </ul>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href="">Hung Yên</a></li>
                                                        <li class="city"><a href="">Lai Châu</a></li>
                                                        <li class="city"><a href="">L?ng Son</a></li>
                                                        <li class="city"><a href="">Lào Cai</a></li>
                                                        <li class="city"><a href="">Nam Ð?nh</a></li>
                                                        <li class="city"><a href="">Ninh Bình</a></li>
                                                        <li class="city"><a href="">Phú Th?</a></li>
                                                        <li class="city"><a href="">Son La</a></li>
                                                        <li class="city"><a href="">Thái Bình</a></li>
                                                        <li class="city"><a href="">Tuyên Quang</a></li>
                                                        <li class="city"><a href="">Vinh Phúc</a></li>
                                                        <li class="city"><a href="">Yên Bái</a></li>
                                                    </ul>
                                                </div>
                                                
                                                <div class="region-col fl-l clearfix">
                                                    <h3>Mi?n TRUNG - Tây Nguyên</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>Ðà N?ng</strong></a></li>
                                                        <li class="city"><a href=""><strong>Qu?ng Ngãi</strong></a></li>
                                                        <li class="city"><a href=""><strong>Nha Trang-Khánh Hòa</strong></a></li>
                                                        <li class="city"><a href=""><strong>Th?a Thiên-Hu?</strong></a></li>
                                                        <li class="city"><a href=""><strong>Ðà L?t - Lâm Ð?ng</strong></a></li>
                                                        <li class="city"><a href="">Bình Ð?nh</a></li>
                                                        <li class="city"><a href="">Bình Thu?n</a></li>
                                                        <li class="city"><a href="">Ð?k L?k</a></li>
                                                        <li class="city"><a href="">Ðak Nông</a></li>
                                                        <li class="city"><a href="">Gia Lai</a></li>
                                                        
                                                        
                                                    </ul>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href="">Hà Tinh</a></li>
                                                        <li class="city"><a href="">Kon Tum</a></li>
                                                        <li class="city"><a href="">Ninh Thu?n</a></li>
                                                        <li class="city"><a href="">Ngh? An</a></li>
                                                        <li class="city"><a href="">Phú Yên</a></li>
                                                        <li class="city"><a href="">Qu?ng Bình</a></li>
                                                        <li class="city"><a href="">Qu?ng Nam</a></li>
                                                        <li class="city"><a href="">Qu?ng Tr?</a></li>
                                                        <li class="city"><a href="">Thanh Hóa</a></li>
                                                    </ul>
                                                </div>
                                                
                                                 <div class="region-col last fl-l clearfix">
                                                    <h3>Mi?n nam</h3>
                                                    <ul class="city-list fl-l">
                                                        <li class="city"><a href=""><strong>TP. H? Chí Minh</strong></a></li>
                                                        <li class="city"><a href=""><strong>C?n Tho</strong></a></li>
                                                        <li class="city"><a href=""><strong>Bà R?a-Vung Tàu</strong></a></li>
                                                        <li class="city"><a href=""><strong>Cà Mau</strong></a></li>
                                                        <li class="city"><a href="">An Giang</a></li>
                                                        <li class="city"><a href="">B?c Liêu</a></li>
                                                        <li class="city"><a href="">B?n Tre</a></li>
                                                        <li class="city"><a href="">Bình Duong</a></li>
                                                        <li class="city"><a href="">Bình Phu?c</a></li>
                                                        <li class="city"><a href="">Ð?ng Nai</a></li>
                                                        <li class="city"><a href="">Ð?ng Tháp</a></li>
                                                        <li class="city"><a href="">H?u Giang</a></li>
                                                    </ul>
                                                    <ul class="city-list fl-l">                                   	
                                                        <li class="city"><a href="">Kiên Giang</a></li>
                                                        <li class="city"><a href="">Long An</a></li>
                                                        <li class="city"><a href="">Sóc Trang</a></li>
                                                        <li class="city"><a href="">Tây Ninh</a></li>
                                                        <li class="city"><a href="">Ti?n Giang</a></li>
                                                        <li class="city"><a href="">Trà Vinh</a></li>
                                                        <li class="city"><a href="">Vinh Long</a></li>
                                                    </ul>
                                                </div>
                                                
                                            </div>
                                        </div>
                                    </div>
                                    <div class="input-set col-04 mg-l-20   fl-l">
                                        <label for="departDate">Ngày di</label>
                                        <input id="departDate" type="text" class="input-txt date" placeholder="Ch?n ngày di" accesskey="3" tabindex="3"  />
                                    </div>
                                    <div class="input-set col-03 mg-l-20  fl-l">
                                        <label for="returnDate">S? hành khách</label>
                                        <select id="passengerNum" class="styled wd-100 fl-l" accesskey="5"  tabindex="5" >
                                            <option selected="selected">1</option>
                                            <option>2</option>
                                            <option>3</option>
                                            <option>4</option>
                                            <option>5</option>
                                            <option>6</option>
                                            <option>7</option>
                                            <option>8</option>
                                            <option>9</option>
                                            <option>10</option>
                                        </select>
                                    </div>
                                    <div class="input-set fl-r clearfix">
                                        <input id="searchSubmit" type="submit" class="submit-btn search-btn fl-r" value="Tìm Vé"  tabindex="6"  />
                                    </div>
                                    
                                </fieldset>
                            </form>
                        </div>
                	</div>
                </div>
                <!-- / ticket search filter -->
                
                <!-- search result list -->
                <div id="searchResults" class="content-inner clearfix">
                    <!-- search result header -->
                    <div class="search-result-header clearfix">
                        <h1 class="hd-tt fl-l"><img src="images/bus-icon-02.png" alt="" />Vé xe t? <span class="from">TP. H? Chí Minh</span> di <span class="to">Hà N?i</span></h1>
                        <div class="date-picker-nav col-08 clearfix fl-r">  
                            <a class="date-nav-btn rounded-4 prev fl-l" href="">Ngày tru?c</a>
                            <span class="current-date wd-90 fl-l">22/11/2013</span>
                            <a class="date-nav-btn rounded-4 next fl-r" href="">Ngày k? ti?p</a>
                        </div>
                    </div>
                    <!-- /search result header -->
                    
                    <!-- search results filter-->
                    <div class="searh-result-filter pd-tb-15 clearfix">
                        <div class="input-set wd-160 fl-l">
                            <select id="trasporter-list-nav" multiple="multiple">
                                <option value="240">Hòa Thu?n Anh</option>
                                <option value="562">Gia Phúc - Cam Ranh</option>
                                <option value="146">Hà Linh - Q1</option>
                                <option value="167">Minh Dung</option>
                                <option value="563">Nam Phuong</option>
                                <option value="282">Hoàng Long</option>
                                <option value="21">Sinh Tourist</option>
                                <option value="99">Quang H?nh</option>
                                <option value="119">Liên Hung</option>
                                <option value="148">Vi?t Nh?t</option>
                                <option value="195">Cúc Tùng </option>
                                <option value="316">Trà Lan Viên</option>
                                <option value="420">Hanh Cafe</option>
                                <option value="314">TM Brother</option>
                                <option value="4">Phuong Trang</option>
                                <option value="500">An Phú</option>
                                <option value="530">Tâm H?nh</option>
                            </select>
                         </div>
                         <div class="input-set wd-200 mg-l-15 fl-l">
                                <select id="benefit-list-nav" multiple="multiple">
                                    <option value="1">Gh? m?m</option>
                                    <option value="2">Máy l?nh</option>
                                    <option value="3">An trua</option>
                                </select>
                         </div>
                         <div class="input-set wd-150 mg-l-15 fl-l">
                            <select id="start-point-list-nav" multiple="multiple">
                                <option value="1">Hà N?i</option>
                                <option value="2">H?i Phòng</option>
                                <option value="3">Hu?</option>
                            </select>
                         </div>
                         <div class="input-set wd-150 mg-l-15 fl-l">
                            <select id="end-point-list-nav" multiple="multiple">
                                <option value="1">Hà N?i</option>
                                <option value="2">Vinh</option>
                                <option value="3">Ngh? An</option>
                            </select>
                          </div>
                          <div class="input-set wd-130 mg-l-15 fl-l">
                            <select id="raty-nav-input">
                                <option selected="selected" value="">Ðánh giá</option>
                                <option value="1">Gi?m d?n</option>
                                <option value="2">Tang d?n</option>
                            </select>
                          </div>
                          <div class="input-set wd-130 mg-l-15 fl-l">
                            <select id="price-sub-nav">
                                <option selected="selected" value="1">Giá vé</option>
                                <option value="1">Tang d?n</option>
                                <option value="2">Gi?m d?n</option>
                            </select>
                          </div>
                    </div>
                    <!-- /search results filter-->
                    
                    <!-- Results list-->
                    <div class="result-list clearfix">
                        <!-- Result item row-->
                        <div class="result-item clearfix">
                        
                            <!-- Transporter info-->
                            <div class="transporter-col wd-160 fl-l">
                                <p class="transporter-name">AN BÌNH</p>
                                <p class="route">Sài Gòn - Hà N?i</p>
                                <a class="cancelation-policy" href="" original-title="? Tr? vé  tru?c lúc kh?i hành 3 ngày: 5%.<br/>? Tr? vé  tru?c lúc kh?i hành 1 ngày: 10%.<br/>? Tr? vé  tru?c lúc kh?i hành 12 gi?: 50%.<br/>? Tr? vé  trong vòng 12 gi?  tru?c lúc kh?i hành : không hoàn ti?n l?i, tuy nhiên chúng tôi khuy?n khích quý khách h?y vé khi không di d? dành cho cho ngu?i khác và nâng cao uy tín c?a mình trong các l?n mua ti?p theo.   ">Chính sách hu? vé <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                            </div>
                            <!-- /Transporter info-->
                            
                            <!-- /Benefit info-->
                            <div class="benefit-col wd-200 mg-l-15 fl-l">
                            
                                <div class="benefit-icons pd-b-10 clearfix">
                                	
                                    <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                    <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                    <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                    <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                    <div class="more rel-pos fl-l">
                                        <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                        <!--more benefits popover -->
                                        <div class="tip-popover more-benefits-popover clearfix">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                <div class="benefit-label clearfix">
                                                    <div class="beneits-col col-03 mg-l-10 fl-l">
                                                        <p class="icon benefit-drink">Nu?c u?ng</p>
                                                        <p class="icon benefit-aircon">Ði?u hòa</p>
                                                        <p class="icon benefit-blanket">Chan d?p</p>
                                                        <p class="icon benefit-food">Th?c an</p>
                                                        <p class="icon benefit-tissue">Khan l?nh</p>
                                                        <p class="icon benefit-dvd">DVD</p>
                                                    </div>
                                                    <div class="beneits-col col-04 fl-l">
                                                        <p class="icon benefit-wifi">Wifi</p>  
                                                        <p class="icon benefit-charger">X?c pin</p>
                                                        <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                        <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                        <p class="icon benefit-toilet">Toilet</p>
                                                    </div>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                        <!--/more benefits popover -->
                                    </div>
                                </div>
                                
                                
                                
                                <p class="seat-info">Giu?ng n?m 40 ch?</p>
    
                                <p class="more-options">
                                    <a class="detail-info" href="">L?ch trình</a> |
                                    <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                    <a class="ticket-detail-maps" href="">B?n d?</a>
                                </p>
                                
                            </div>
                            <!-- /Benefit info-->
                            
                            <!-- Depart info-->
                            <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                
                                <div class="depart-station rel-pos fl-l">
                                    <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                    TP. H? Chí Minh<br/>
                                                    Ði?n tho?i: 08.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Kh?i hành:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="20:00">20:00</option>
                                        <option value="20:30">20:30</option>
                                   </select>
                                </div>
                                
                                <p class="clr">S? gh? tr?ng: 2</p>
                                
                            </div>
                            <!-- /Depart Info-->
                            
                            <!-- Destination info-->
                            <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                <div class="destination-station rel-pos fl-l">
                                    <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover dest-station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Giáp Bát</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                    Hà N?i<br/>
                                                    Ði?n tho?i: 04.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Ð?n:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                        <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                   </select>
                                </div>
                                
                                <p class="clr">T?ng th?i gian: 32h 15''</p>
    
                            </div>
                            <!-- /Destination info-->
                            
                            <!-- Rating info-->
                            <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                <div class="rating mg-b-10 fl-l">
                                    <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                </div>
                                <div class="rating-info fl-l clr">
                                    <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                    <div class="tip-popover rating-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                <ul class="clearfix">
                                                	<!-- RATINGS AVERAGE RULES using class
                                                        stars-0 (0/5)
                                                        stars-1 (1/5)
                                                        stars-1-half (1.5/5)
                                                        stars-2 (2/5)
                                                        stars-2-half (2.5/5)
                                                        stars-3 (3/5)
                                                        stars-3-half (3.5/5)
                                                        stars-4 (4/5)
                                                        stars-4-half (4.5/5)
                                                        stars-5 (5/5)
                                                        -->
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        T?ng quan:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ch?t lu?ng xe:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ðúng gi?:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        Thái d? ph?c v?:
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                
                                
                            </div>
                            <!-- /Rating info-->
                            
                            <!-- Price info-->
                            <div class="price-col wd-130 mg-l-15 fl-l">
                                <p class="price"><span class="now">950,000<small>d</small></span></p>
                                <a class="ticket-ac-btn booking-btn closed" href="" title="Nh?p d? d?t vé">Ð?t vé</a>
                                <!-- When open the detail info, change to this button-->
                                <a class="ticket-ac-btn open" href="" title="Nh?p d? dóng l?i" style="display: none;">Ðóng l?i</a>
                            </div>
                            <!-- /Price info-->
                            
                            <!-- Ticket Booking Details -->
                            <div class="ticket-booking-details info-block rel-pos rounded-4 clearfix">
                            	<div class="point-arrow push-04"></div>
                                <a class="close tip" href="" title="Ðóng l?i"></a>
                                <form action="" id="frmSeatSelection" method="post">
                                	<fieldset>
                                        <div class="block-inner clearfix">
                                            <!-- Seat selector-->
                                            <div class="seat-selector col-16 fl-l">
                                                <h3 class="section-tt clearfix">CH?N GH?/GIU?NG N?M</h3>
                                                <div class="section-content mg-tb-15 pd-lr-20 clearfix">
                                                    <p>B?m vào gh? tr?ng d? l?a ch?n, b?m vào l?n n?a d? h?y b? l?a ch?n.</p>
                        
                                                    <div class="detail-seat-template-specific-container">
                                                        <div class="detail-seat-template-specific" id="template-1">
                                                        
                                                            <div class="detail-seat-template-specific-child" id="coach-2">
                                                                <div class="coach-name">T?ng 2</div>
                                                                                
                                                                <ul id="Row-1">
                                                                    <li class="  " data-seat-code="IND" data-seat-num="0" title="Gh? s?: IND | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li><li></li><li></li>
                                                                    <li class="  " data-seat-code="DRV" data-seat-num="0" title="Gh? s?: DRV | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-2">
                                                                    <li class="label-seathasSleeper" data-seat-code="C2" data-seat-num="23" title="Gh? s?: C2 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li class="label-seat"><span class="s-d"></span></li>
                                                                    <li class="label-seathasSleeper" data-seat-code="B2" data-seat-num="22" title="Gh? s?: B2 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li class="label-seat"><span class="s-b"></span></li>
                                                                    <li class="label-seathasSleeper" data-seat-code="A2" data-seat-num="21" title="Gh? s?: A2 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">1</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-3">
                                                                    <li class="hasSleeper" data-seat-code="C4" data-seat-num="26" title="Gh? s?: C4 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B4" data-seat-num="25" title="Gh? s?: B4 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A4" data-seat-num="24" title="Gh? s?: A4 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">2</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-4">
                                                                    <li class="hasSleeper" data-seat-code="C6" data-seat-num="29" title="Gh? s?: C6 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B6" data-seat-num="28" title="Gh? s?: B6 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A6" data-seat-num="27" title="Gh? s?: A6 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">3</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-5">
                                                                    <li class="hasSleeper" data-seat-code="C8" data-seat-num="32" title="Gh? s?: C8 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B8" data-seat-num="31" title="Gh? s?: B8 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A8" data-seat-num="30" title="Gh? s?: A8 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">4</span></li>
                                                                </ul>
                                                                <ul id="Row-6">
                                                                    <li class="hasSleeper" data-seat-code="C10" data-seat-num="35" title="Gh? s?: C10 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B10" data-seat-num="34" title="Gh? s?: B10 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A10" data-seat-num="33" title="Gh? s?: A10 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">5</span></li>
                                                                </ul>
                                                                <ul id="Row-7">
                                                                    <li class="hasSleeper" data-seat-code="D10" data-seat-num="40" title="Gh? s?: D10 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D8" data-seat-num="39" title="Gh? s?: D8 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-d"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D6" data-seat-num="38" title="Gh? s?: D6 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D4" data-seat-num="37" title="Gh? s?: D4 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-b"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D2" data-seat-num="36" title="Gh? s?: D2 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">6</span></li>
                                                                </ul>
                                                            </div>
                                                            <div class="detail-seat-template-specific-child" id="coach-1">
                                                                <div class="coach-name">T?ng 1</div>
                                                                <span class="entry-door">C?a lên</span>
                                                                <span class="driver"></span>
                                                                
                                                                <ul id="Row-1">
                                                                    <li class="  " data-seat-code="IND" data-seat-num="0" title="Gh? s?: IND | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li></li>
                                                                    <li></li>
                                                                    <li class="  " data-seat-code="DRV" data-seat-num="0" title="Gh? s?: DRV | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-2">
                                                                    <li class="label-seathasSleeper" data-seat-code="C1" data-seat-num="3" title="Gh? s?: C1 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li class="label-seat"><span class="s-d"></span></li>
                                                                    <li class="label-seathasSleeper" data-seat-code="B1" data-seat-num="2" title="Gh? s?: B1 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li class="label-seat"><span class="s-b"></span></li>
                                                                    <li class="label-seathasSleeper" data-seat-code="A1" data-seat-num="1" title="Gh? s?: A1 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">1</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-3">
                                                                    <li class="hasSleeper" data-seat-code="C3" data-seat-num="6" title="Gh? s?: C3 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B3" data-seat-num="5" title="Gh? s?: B3 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeperseat-avail" data-seat-code="A3" data-seat-num="4" title="Gh? s?: A3 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">2</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-4">
                                                                    <li class="hasSleeper" data-seat-code="C5" data-seat-num="9" title="Gh? s?: C5 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B5" data-seat-num="8" title="Gh? s?: B5 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A5" data-seat-num="7" title="Gh? s?: A5 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">3</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-5">
                                                                    <li class="hasSleeper" data-seat-code="C7" data-seat-num="12" title="Gh? s?: C7 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B7" data-seat-num="11" title="Gh? s?: B7 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A7" data-seat-num="10" title="Gh? s?: A7 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">4</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-6">
                                                                    <li class="hasSleeper" data-seat-code="C9" data-seat-num="15" title="Gh? s?: C9 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="B9" data-seat-num="14" title="Gh? s?: B9 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li></li>
                                                                    <li class="hasSleeper" data-seat-code="A9" data-seat-num="13" title="Gh? s?: A9 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">5</span></li>
                                                                </ul>
                                                                
                                                                <ul id="Row-7">
                                                                    <li class="hasSleeper" data-seat-code="D9" data-seat-num="20" title="Gh? s?: D9 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-e"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D7" data-seat-num="19" title="Gh? s?: D7 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-d"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D5" data-seat-num="18" title="Gh? s?: D5 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-c"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D3" data-seat-num="17" title="Gh? s?: D3 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-b"></span></li>
                                                                    <li class="hasSleeper" data-seat-code="D1" data-seat-num="16" title="Gh? s?: D1 | Giá: 1.520.000 d" data-fare="1520000"><span class="s-a"></span></li>
                                                                    <li class="label-seat"><span class="seat-num">6</span></li>
                                                                </ul>
                                                            </div>
                                                            
                                                        </div>
                                                    </div>
                                                    
                                                    <ul class="seat-indicator fl-r">
                                                        <li><span class="available-seat">Gh? tr?ng</span></li>
                                                        <li><span class="booked-seat">Gh? dã d?t</span></li>
                                                        <li><span class="select-seat">Ðang ch?n</span></li>
                                                    </ul>
                                                    
                                                </div>    
                                                
                                            </div>
                                           
                                            <!-- /Seat selector-->
                                            
                                            <!-- > Ticket info-->
                                            <div id="ticket-info" class="ticket-info clearfix fl-r">
                                                <h3 class="section-tt clearfix">Thông tin vé xe</h3>
                                                <div class="section-content mg-tb-15 pd-lr-20">
                                                    <table class="info-table" width="100%" border="0" cellpadding="0">
                                                        <tr>
                                                          <td>Chi?u di:</td>
                                                          <td><strong>Sài Gòn - Mui Né </strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Xu?t phát:</td>
                                                          <td><strong>Khu ph? Tây</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Ðích d?n:</td>
                                                          <td><strong>VP Mui Né</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Gi? xu?t phát:</td>
                                                          <td><strong>08:00</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Gi? d?n:</td>
                                                          <td><strong>13:00</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>S? gh?:</td>
                                                          <td><strong>A1,B1</strong></td>
                                                        </tr>
                                                        <tr>
                                                          <td>Giá vé:</td>
                                                          <td><strong>950,000/ngu?i</strong></td>
                                                        </tr>
                                                        <tr class="total">
                                                            <td width="43%" class="total-tt">T?ng ti?n: </td>
                                                            <td width="57%" class="amount">1,900,000 VNÐ</td>
                                                        </tr>
                                                    </table>
                                                    
                                                    <a class="action-btn cont-btn mg-t-20 fl-r" href="">Ti?p t?c</a>
                                                </div>
                                            </div>
                                            <!--/Ticket info-->
                                            
                                        </div>
                                        
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                	</fieldset>
                                </form>
                                
                            </div>
                            
                            <!-- /Ticket Booking Details -->
                            
                        </div>
                        <!-- /Result item row-->
                        
                        <!-- Result item row-->
                        <div class="result-item clearfix">
                        
                            <!-- Transporter info-->
                            <div class="transporter-col wd-160 fl-l">
                                <p class="transporter-name">AN BÌNH</p>
                                <p class="route">Sài Gòn - Hà N?i</p>
                                <a class="cancelation-policy" href="" original-title="? Tr? vé  tru?c lúc kh?i hành 3 ngày: 5%.<br/>? Tr? vé  tru?c lúc kh?i hành 1 ngày: 10%.<br/>? Tr? vé  tru?c lúc kh?i hành 12 gi?: 50%.<br/>? Tr? vé  trong vòng 12 gi?  tru?c lúc kh?i hành : không hoàn ti?n l?i, tuy nhiên chúng tôi khuy?n khích quý khách h?y vé khi không di d? dành cho cho ngu?i khác và nâng cao uy tín c?a mình trong các l?n mua ti?p theo.   ">Chính sách hu? vé <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                            </div>
                            <!-- /Transporter info-->
                            
                            <!-- /Benefit info-->
                            <div class="benefit-col wd-200 mg-l-15 fl-l">
                            
                                <div class="benefit-icons pd-b-10 clearfix">
                                    <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                    <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                    <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                    <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                    <div class="more rel-pos fl-l">
                                        <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                        <!--more benefits popover -->
                                        <div class="tip-popover more-benefits-popover clearfix">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                <div class="benefit-label clearfix">
                                                    <div class="beneits-col col-03 mg-l-10 fl-l">
                                                        <p class="icon benefit-drink">Nu?c u?ng</p>
                                                        <p class="icon benefit-aircon">Ði?u hòa</p>
                                                        <p class="icon benefit-blanket">Chan d?p</p>
                                                        <p class="icon benefit-food">Th?c an</p>
                                                        <p class="icon benefit-tissue">Khan l?nh</p>
                                                        <p class="icon benefit-dvd">DVD</p>
                                                    </div>
                                                    <div class="beneits-col col-04 fl-l">
                                                        <p class="icon benefit-wifi">Wifi</p>  
                                                        <p class="icon benefit-charger">X?c pin</p>
                                                        <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                        <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                        <p class="icon benefit-toilet">Toilet</p>
                                                    </div>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                        <!--/more benefits popover -->
                                    </div>
                                </div>
                                
                                
                                
                                <p class="seat-info">Giu?ng n?m 40 ch?</p>
    
                                <p class="more-options">
                                    <a class="detail-info" href="">L?ch trình</a> |
                                    <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                    <a class="ticket-detail-maps" href="">B?n d?</a>
                                </p>
                                
                            </div>
                            <!-- /Benefit info-->
                            
                            <!-- Depart info-->
                            <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                
                                <div class="depart-station rel-pos fl-l">
                                    <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                    TP. H? Chí Minh<br/>
                                                    Ði?n tho?i: 08.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Kh?i hành:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="20:00">20:00</option>
                                        <option value="20:30">20:30</option>
                                   </select>
                                </div>
                                
                                <p class="clr">S? gh? tr?ng: 0</p>
                                
                            </div>
                            <!-- /Depart Info-->
                            
                            <!-- Destination info-->
                            <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                <div class="destination-station rel-pos fl-l">
                                    <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover dest-station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Giáp Bát</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                    Hà N?i<br/>
                                                    Ði?n tho?i: 04.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Ð?n:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                        <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                   </select>
                                </div>
                                
                                <p class="clr">T?ng th?i gian: 32h 15''</p>
    
                            </div>
                            <!-- /Destination info-->
                            
                            <!-- Rating info-->
                            <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                <div class="rating mg-b-10 fl-l">
                                    <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                </div>
                                <div class="rating-info fl-l clr">
                                    <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                    <div class="tip-popover rating-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                <ul class="clearfix">
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        T?ng quan:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ch?t lu?ng xe:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ðúng gi?:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        Thái d? ph?c v?:
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                
                                
                            </div>
                            <!-- /Rating info-->
                            
                            <!-- Price info-->
                            <div class="price-col wd-130 mg-l-15 fl-l">
                                <p class="price">950,000<small>d</small></p>
                                <span class="no-ticket rounded-4">H?t vé</span>
                            </div>
                            <!-- /Price info-->
                            
                        </div>
                        <!-- /Result item row-->
                        
                        <!-- Result item row-->
                        <div class="result-item clearfix">
                        
                            <!-- Transporter info-->
                            <div class="transporter-col wd-160 fl-l">
                                <p class="transporter-name">AN BÌNH</p>
                                <p class="route">Sài Gòn - Hà N?i</p>
                                <a class="cancelation-policy" href="" original-title="? Tr? vé  tru?c lúc kh?i hành 3 ngày: 5%.<br/>? Tr? vé  tru?c lúc kh?i hành 1 ngày: 10%.<br/>? Tr? vé  tru?c lúc kh?i hành 12 gi?: 50%.<br/>? Tr? vé  trong vòng 12 gi?  tru?c lúc kh?i hành : không hoàn ti?n l?i, tuy nhiên chúng tôi khuy?n khích quý khách h?y vé khi không di d? dành cho cho ngu?i khác và nâng cao uy tín c?a mình trong các l?n mua ti?p theo.   ">Chính sách hu? vé <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                            </div>
                            <!-- /Transporter info-->
                            
                            <!-- /Benefit info-->
                            <div class="benefit-col wd-200 mg-l-15 fl-l">
                            
                                <div class="benefit-icons pd-b-10 clearfix">
                                    <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                    <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                    <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                    <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                    <div class="more rel-pos fl-l">
                                        <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                        <!--more benefits popover -->
                                        <div class="tip-popover more-benefits-popover clearfix">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                <div class="benefit-label clearfix">
                                                    <div class="beneits-col col-03 mg-l-10 fl-l">
                                                        <p class="icon benefit-drink">Nu?c u?ng</p>
                                                        <p class="icon benefit-aircon">Ði?u hòa</p>
                                                        <p class="icon benefit-blanket">Chan d?p</p>
                                                        <p class="icon benefit-food">Th?c an</p>
                                                        <p class="icon benefit-tissue">Khan l?nh</p>
                                                        <p class="icon benefit-dvd">DVD</p>
                                                    </div>
                                                    <div class="beneits-col col-04 fl-l">
                                                        <p class="icon benefit-wifi">Wifi</p>  
                                                        <p class="icon benefit-charger">X?c pin</p>
                                                        <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                        <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                        <p class="icon benefit-toilet">Toilet</p>
                                                    </div>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                        <!--/more benefits popover -->
                                    </div>
                                </div>
                                
                                
                                
                                <p class="seat-info">Giu?ng n?m 40 ch?</p>
    
                                <p class="more-options">
                                    <a class="detail-info" href="">L?ch trình</a> |
                                    <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                    <a class="ticket-detail-maps" href="">B?n d?</a>
                                </p>
                                
                            </div>
                            <!-- /Benefit info-->
                            
                            <!-- Depart info-->
                            <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                
                                <div class="depart-station rel-pos fl-l">
                                    <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                    TP. H? Chí Minh<br/>
                                                    Ði?n tho?i: 08.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Kh?i hành:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="20:00">20:00</option>
                                        <option value="20:30">20:30</option>
                                   </select>
                                </div>
                                
                                <p class="clr">S? gh? tr?ng: 2</p>
                                
                            </div>
                            <!-- /Depart Info-->
                            
                            <!-- Destination info-->
                            <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                <div class="destination-station rel-pos fl-l">
                                    <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                    <div class="tip-popover dest-station-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p><strong>B?n xe Giáp Bát</strong></p>
                                                <p class="address">
                                                    Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                    Hà N?i<br/>
                                                    Ði?n tho?i: 04.38.123.456<br/>
                                                    Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                    V? trí di?m dón khách: C?ng A - Khu A1 
                                                </p>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                               
                               <div class="input-set rel-pos clearfix clr">
                                   <label class="fl-l">Ð?n:</label>
                                   <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                        <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                        <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                   </select>
                                </div>
                                
                                <p class="clr">T?ng th?i gian: 32h 15''</p>
    
                            </div>
                            <!-- /Destination info-->
                            
                            <!-- Rating info-->
                            <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                <div class="rating mg-b-10 fl-l">
                                    <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                </div>
                                <div class="rating-info fl-l clr">
                                    <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                    <div class="tip-popover rating-popover">
                                        <div class="tip-inner rounded-4 rel-pos clearfix">
                                            <div class="tip-arrow"></div>
                                            <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                            <div class="station-info pd-5-10">
                                                <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                <ul class="clearfix">
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        T?ng quan:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ch?t lu?ng xe:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                        </div>
                                                        Ðúng gi?:
                                                    </li>
                                                    <li>
                                                        <div class="rating fl-r">
                                                            <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                        </div>
                                                        Thái d? ph?c v?:
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="popover-footer">
                                                <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                H? th?ng vé xe l?n nh?t Vi?t Nam
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                
                                
                            </div>
                            <!-- /Rating info-->
                            
                            <!-- Price info-->
                            <div class="price-col wd-130 mg-l-15 fl-l">
                                <p class="price"><span class="now">950,000<small>d</small></span></p>
                                <a class="ticket-ac-btn closed" href="" title="Nh?p vào dây d? xem s? di?n tho?i d?t vé">Ði?n tho?i</a>
                                <!-- When open the detail info, change to this button-->
                                <a class="ticket-ac-btn open" href="" title="Nh?p d? dóng l?i" style="display: none;">Ðóng l?i</a>
                            </div>
                            <!-- /Price info-->
                            
                            <!-- Phone Booking Details -->
                            <div class="ticket-booking-details info-block rel-pos rounded-4 clearfix">
                            	<div class="point-arrow push-04"></div>
                                <a class="close tip" href="" title="Ðóng l?i"></a>
                                <div class="block-inner clearfix">
                                 
                                    <!-- > Ticket info-->
                                    <div id="ticket-info" class="ticket-info clearfix fl-l">
                                        <h3 class="section-tt clearfix">Thông tin vé xe</h3>
                                        <div class="section-content mg-tb-15 pd-lr-20">
                                            <table class="info-table" width="100%" border="0" cellpadding="0">
                                                <tr>
                                                  <td>Chi?u di:</td>
                                                  <td><strong>Sài Gòn - Mui Né </strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Xu?t phát:</td>
                                                  <td><strong>Khu ph? Tây</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Ðích d?n:</td>
                                                  <td><strong>VP Mui Né</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Gi? xu?t phát:</td>
                                                  <td><strong>08:00</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Gi? d?n:</td>
                                                  <td><strong>13:00</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>S? gh?:</td>
                                                  <td><strong>A1,B1</strong></td>
                                                </tr>
                                                <tr>
                                                  <td>Giá vé:</td>
                                                  <td><strong>950,000/ngu?i</strong></td>
                                                </tr>
                                                <tr class="total">
                                                    <td width="43%" class="total-tt">T?ng ti?n: </td>
                                                    <td width="57%" class="amount">1,900,000 VNÐ</td>
                                                </tr>
                                            </table>
                                     
                                        </div>
                                    </div>
                                    <!--/Ticket info-->
                                    
                                    <!-- Transporter Phones-->
                                    <div class="phones-list clearfix fl-l">
                                    	<h3 class="section-tt clearfix">ÐI?N THO?I Ð?T VÉ</h3>
                                        <div class="section-content mg-tb-15 pd-lr-20 clearfix">
                                        	<h4>HÃNG XE THU KHUYÊN</h4>
                                            <p>B?n xe Mi?n Ðông</p>
                                            <p class="font-18 or-txt pd-b-5">0988 881 112<br>0982 111 777</p>
                                            <p>B?n xe Giáp Bát</p>
                                            <p class="font-18 or-txt pd-b-5">0988 881 112<br>0982 111 777</p>
                                        </div>
                                    </div>
                                    <!-- Transporter Phones-->
                                    
                                    <!-- Feedback-->
                                    <div class="client-feedback clearfix fl-l">
                                    	<h3 class="section-tt clearfix">PH?N H?I C?A KHÁCH HÀNG</h3>
                                        <div class="section-content mg-tb-15 pd-lr-20 clearfix">
                                            <p class="font-16 bolder-txt al-c">Thông tin vé chính xác?</p>
                                            <form action="" method="post" id="route-info-review-form" >
                                            	<fieldset>
                                                    <input value="" name="" type="hidden" />
                                                    <input name="VoteUp" id="rir-vote-up" type="hidden">
                                                    <div class="feedback-btns clearfix">
                                                    	<!-- When user click one of these buttons, the other button must hide-->
                                                        <a class="tip feedback-like-button fl-l" href="" title="Nh?p d? ph?n h?i thông tin Chính xác">Chính xác</a>
                                                        <a class="tip feedback-dislike-button fl-l" href="" title="Nh?p d? ph?n h?i thông tin không chính xác">Không chính xác</a>
                                                    </div>
                                                    
                                                    <!--like reply, show when click on like button-->
                                                    <div class="feedback-response rounded-4 pd-10-15" style="display: none;">
                                                    	<div class="point-arrow"></div>
														<p> C?m on b?n dã g?i thông tin ph?n h?i v? nhà xe, tuy?n du?ng. vexere.com luôn c? g?ng h?t s?c d? cung c?p thông tin v? các nhà xe chính xác nh?t có th?! </p>
													</div>
                                                    <!--/like reply-->
                                                    
                                                    <!--dislike-feedback, show when click on button-->
                                                    <div class="dislike-feedback rounded-4 pd-10-15 clearfix"  style="display: none;">
                                                    	<div class="point-arrow red"></div>
                                                        <label>
                                                            <input name="FareVoteDown" id="FareVoteDown" value="false" type="checkbox" />Giá vé không chính xác
                                                        </label>
                                                        <label>
                                                            <input name="TimeVoteDown" id="TimeVoteDown" value="false" type="checkbox" />Th?i gian ch?y không chính xác
                                                        </label>
                                                        <label>
                                                            <input name="NotAnswerVoteDown" id="NotAnswerVoteDown" type="checkbox" />
Ði?n tho?i không b?t máy
                                                        </label>
                                                        <label>
                                                            <input name="PhoneVoteDown" id="PhoneVoteDown" type="checkbox" />
                                                            S? phone không chính xác
                                                        </label>
                                                        <label>Thông tin khác :</label>
                                                        <textarea cols="10" rows="4" name="Comment"></textarea>
                                                        
                                                        <a class="action-btn feedback-send-button" href="#">G?i</a>
                                                    </div>
                                                    <!-- /dislike-feedback-->
                                            	</fieldset>
                                            </form>
                                            
                                        </div>
                                    </div>
                                    <!-- /Feedback-->
                                    <div class="section-note col-15 pd-lr-20 clr clearfix">
                                    	<p>Luu ý: m?t s? nhà xe thay d?i chính sách giá vé thu?ng xuyên do dó thông tin có th? không chính xác, mong các b?n thông c?m. Chúng tôi luôn vui lòng nh?n góp ý và ph?n h?i c?a c?ng d?ng d? luôn có thông tin nhanh và chính xác nh?t. Xin c?m on!</p>
                                    </div>
                                    
                                </div>
                                
                                <div class="section-footer">
                                    <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                </div>
                                
                            </div>
                            
                            <!-- /Phone Booking Details -->
                            
                        </div>
                        <!-- /Result item row-->
                        
                        <!-- Result item row-->
                        <div class="result-item promo clearfix">
                        	<div class="item-content clearfix">
                                <!-- Transporter info-->
                                <div class="transporter-col wd-160 fl-l">
                                    <p class="transporter-name">AN BÌNH</p>
                                    <p class="route">Sài Gòn - Thái Bình</p>
                                    <a class="cancelation-policy" href="" original-title="? Tr? vé  tru?c lúc kh?i hành 3 ngày: 5%.<br/>? Tr? vé  tru?c lúc kh?i hành 1 ngày: 10%.<br/>? Tr? vé  tru?c lúc kh?i hành 12 gi?: 50%.<br/>? Tr? vé  trong vòng 12 gi?  tru?c lúc kh?i hành : không hoàn ti?n l?i, tuy nhiên chúng tôi khuy?n khích quý khách h?y vé khi không di d? dành cho cho ngu?i khác và nâng cao uy tín c?a mình trong các l?n mua ti?p theo.">Chính sách hu? vé <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                </div>
                                <!-- /Transporter info-->
                                
                                <!-- /Benefit info-->
                                <div class="benefit-col wd-200 mg-l-15 fl-l">
                                
                                    <div class="benefit-icons pd-b-10 clearfix">
                                        <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                        <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                        <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                        <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                        <div class="more rel-pos fl-l">
                                            <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                            <!--more benefits popover -->
                                            <div class="tip-popover more-benefits-popover clearfix">
                                                <div class="tip-inner rounded-4 rel-pos clearfix">
                                                    <div class="tip-arrow"></div>
                                                    <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                    <div class="benefit-label clearfix">
                                                        <div class="beneits-col col-03 mg-l-10 fl-l">
                                                            <p class="icon benefit-drink">Nu?c u?ng</p>
                                                            <p class="icon benefit-aircon">Ði?u hòa</p>
                                                            <p class="icon benefit-blanket">Chan d?p</p>
                                                            <p class="icon benefit-food">Th?c an</p>
                                                            <p class="icon benefit-tissue">Khan l?nh</p>
                                                            <p class="icon benefit-dvd">DVD</p>
                                                        </div>
                                                        <div class="beneits-col col-04 fl-l">
                                                            <p class="icon benefit-wifi">Wifi</p>  
                                                            <p class="icon benefit-charger">X?c pin</p>
                                                            <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                            <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                            <p class="icon benefit-toilet">Toilet</p>
                                                        </div>
                                                    </div>
                                                    <div class="popover-footer">
                                                        <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                        H? th?ng vé xe l?n nh?t Vi?t Nam
                                                    </div>
                                                </div>
                                            </div>
                                            <!--/more benefits popover -->
                                        </div>
                                    </div>
                                    
                                    
                                    
                                    <p class="seat-info">Giu?ng n?m 40 ch?</p>
        
                                    <p class="more-options">
                                        <a class="detail-info" href="">L?ch trình</a> |
                                        <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                        <a class="ticket-detail-maps" href="">B?n d?</a>
                                    </p>
                                    
                                </div>
                                <!-- /Benefit info-->
                                
                                <!-- Depart info-->
                                <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                    
                                    <div class="depart-station rel-pos fl-l">
                                        <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                        <div class="tip-popover station-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                    <p class="address">
                                                        Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                        TP. H? Chí Minh<br/>
                                                        Ði?n tho?i: 08.38.123.456<br/>
                                                        Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                        V? trí di?m dón khách: C?ng A - Khu A1 
                                                    </p>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                            
                                        </div>
                                    </div>
                                   
                                   <div class="input-set rel-pos clearfix clr">
                                       <label class="fl-l">Kh?i hành:</label>
                                       <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                            <option selected="selected" value="20:00">20:00</option>
                                            <option value="20:30">20:30</option>
                                       </select>
                                    </div>
                                    
                                    <p class="clr">S? gh? tr?ng: 2</p>
                                    
                                </div>
                                <!-- /Depart Info-->
                                
                                <!-- Destination info-->
                                <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                    <div class="destination-station rel-pos fl-l">
                                        <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                        <div class="tip-popover dest-station-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p><strong>B?n xe Giáp Bát</strong></p>
                                                    <p class="address">
                                                        Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                        Hà N?i<br/>
                                                        Ði?n tho?i: 04.38.123.456<br/>
                                                        Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                        V? trí di?m dón khách: C?ng A - Khu A1 
                                                    </p>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                            
                                        </div>
                                    </div>
                                   
                                   <div class="input-set rel-pos clearfix clr">
                                       <label class="fl-l">Ð?n:</label>
                                       <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                            <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                            <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                       </select>
                                    </div>
                                    
                                    <p class="clr">T?ng th?i gian: 32h 15''</p>
        
                                </div>
                                <!-- /Destination info-->
                                
                                <!-- Rating info-->
                                <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                    <div class="rating mg-b-10 fl-l">
                                        <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                    </div>
                                    <div class="rating-info fl-l clr">
                                        <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                        <div class="tip-popover rating-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                    <ul class="clearfix">
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                            </div>
                                                            T?ng quan:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                            </div>
                                                            Ch?t lu?ng xe:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                            </div>
                                                            Ðúng gi?:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                            </div>
                                                            Thái d? ph?c v?:
                                                        </li>
                                                    </ul>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                    
                                    
                                </div>
                                <!-- /Rating info-->
                                
                                <!-- Price info-->
                                <div class="price-col rel-pos wd-130 mg-l-15 fl-l">
                                    <p class="promo-tag">-<span class="font-18">30</span>%</p>
                                    <p class="price">
                                        <s class="old">950,000d</s>
                                        <span class="now">950,000<small>d</small></span>
                                    </p>
                                    <a class="ticket-ac-btn closed" href=""  title="Nh?p vào dây d? xem s? di?n tho?i d?t vé">Ði?n tho?i</a>
                                    <!-- When open the detail info, change to this button-->
                                    <a class="ticket-ac-btn open" href="" title="Nh?p d? dóng l?i" style="display: none;">Ðóng l?i</a>
                                </div>
                                <!-- /Price info-->
                             </div>
                             
                             <!--  Routes, Photos, Rating Tabs content-->
                             <div class="ticket-detail-tabs rel-pos clearfix" style="display: block;">
                             	<a class="tabs-close-btn" href="" title="Ðóng l?i">Ðóng l?i</a>
                                <div class="tab-list-container">
                                
                                    <ul class="tabs-list">
                                        <li><a href="" title="L?ch trình xe An Bình" rel="tab1" class="tip tabs ticket-route-tab active">L?ch trình</a></li>
                                        <li><a href="" title="B?n d?" rel="tab2" class="tip tabs ticket-map-tab">B?n d?</a></li>
                                        <li><a href="" title="Hình ?nh xe An Bình" rel="tab3" class="tip  tabs ticket-images-tab">Hình ?nh</a></li>
                                        <li><a href="" title="Ðánh giá xe An Bình" rel="tab4" class="tip tabs ticket-review-tab">Ðánh giá</a></li>
                                    </ul>
                                    
                                    <div class="loading">
                                        <img src="images/loading.gif"  alt=""/>
                                        Ðang t?i n?i dung...
                                    </div>
                                    
                                    <!-- Route Schedule tab content-->
                                    <div class="tab-pane tab1 current">
                                   		<div class="tab-content-inner">
                                            <h2 class="hd-tt">L?ch trình xe Camel Travel t? <span class="from">Sài Gòn</span> di <span class="to">Hà N?i</span></h2>
                                            <table class="list-route-table" cellpadding="0" cellspacing="0">
                                                <thead>
                                                    <tr>
                                                        <th style="width: 20%;">Ði?m di (d?n)</th>
                                                        <th style="width: 30%;">Ði?n tho?i</th>
                                                        <th style="width: 35%;">Ð?a ch?</th>
                                                        <th style="width: 15%;">Th?i gian di (d?n)</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                        <tr>
                                                            <td>B?n xe Mi?n Ðông</td>
                                                            <td>
                                        04 36 250 739  - 04 36 250 659                                    <br>
                                                            </td>
                                                            <td>292 Ðinh B? Linh - Bình Th?nh - H? Chí Minh</td>
                                                            <td>
                                                                <div class="input-set">
                                                                    <select class="boardingTime styled-02">
                                                                        <option selected="selected" value="0">19:00</option>
                                                                    </select>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>Phan Thi?t</td>
                                                            <td>04 36 250 739  - 04 36 250 659</td>
                                                            <td>Phan Thi?t - Bình Thu?n</td>
                                                            <td><span class="time">21:30</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>Nha Trang</td>
                                                            <td>04 36 250 739  - 04 36 250 659</td>
                                                            <td>Nha Trang - Khánh Hoà</td>
                                                            <td><span class="time">07:00 + 1n</span></td>
                                                        </tr>
                                                        <tr>
                                                            <td>Hà N?i</td>
                                                            <td>04 36 250 659 - 04 36 250 739</td>
                                                            <td>459 Tr?n Khát Chân - Hai Bà Trung - Hà N?i</td>
                                                            <td>
                                                                <div class="input-set">
                                                                    <select class="boardingTime styled-02">
                                                                        <option selected="selected" value="0">21:00 +1n</option>
                                                                    </select>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                    </div>
                                    <!-- Route Schedule tab content-->
                                    
                                    <!-- Map tab content-->
                                    <div class="tab-pane tab2">
                                   		<div class="map-container pd-15">
                                        	<!-- place map here-->
                                        	<div class="map_canvas" id="map-canvas-1334-0" style="width: 100%; height: 480px; position: relative; background-color: rgb(229, 227, 223);"></div>
                                            <!-- place map here-->
                                            
                                        </div>
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                    </div>
                                    <!-- Map tab content-->
                                    
                                    <!-- Photos tab content-->
                                    <div class="tab-pane tab3">
                                   		<div class="tab-content-inner">
                                            <h2 class="hd-tt al-c">Hình ?nh hãng xe <span class="from">An Bình</span></h2>
                                            <!-- if no photo-->
                                            <p class="no-photo hl-txt pd-15 al-c" style="display: none">www.VeXeRe.com dang liên h? nhà xe An Bình d? có du?c nh?ng hình ?nh th?c t? nh?t cho quý khách...</p>
                                            <!-- /if no photo-->
                                            
                                            <!-- Photo gallery-->
                                            <div class="photo-slider">
                                                <div class="slider-wrapper rounded-4">
                                                    <div class="transporter-photo nivoSlider clearfix">
                                                        <img alt="slide1" src="photos/1.jpg" width="640" height="400"  data-transition="fade" />
                                                        <img alt="slide2" src="photos/2.jpg" width="640" height="400" data-transition="fade" />
                                                        <img alt="slide3" src="photos/3.jpg" width="640" height="400" data-transition="fade" />
                                                        <img alt="slide4" src="photos/4.jpg" width="640" height="400" data-transition="fade" />
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- /Photo gallery-->
                                            
                                            
                                        </div>
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                    </div>
                                    <!-- /Photos tab content-->
                                    
                                    <!-- Rating tab content-->
                                    <div class="tab-pane tab4">
                                   		<div class="tab-content-inner">
                                            <h2 class="hd-tt">Ðánh giá t?ng th? nhà xe <span class="from">An Bình</span></h2>
                                            
                                            <!-- general rating -->
                                            <div class="general-rating clearfix">
                                            
                                            	<div class="rate-result-box-large col-08 fl-l">
                                                	<div class="clearfix">
                                                        <div class="total-rate col-03 or-txt fl-l">4.0</div>
                                                        <div class="col-04 fl-l clearfix">
                                                            <p class="col-03 al-c font-16 mg-b-5">Trên <strong class="font-22 or-txt">5.0</strong></p>
                                                            <div class="rating-large">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                                <!-- RATINGS AVERAGE RULES using class
                                                                stars-0 (0/5)
                                                                stars-1 (1/5)
                                                                stars-1-half (1.5/5)
                                                                stars-2 (2/5)
                                                                stars-2-half (2.5/5)
                                                                stars-3 (3/5)
                                                                stars-3-half (3.5/5)
                                                                stars-4 (4/5)
                                                                stars-4-half (4.5/5)
                                                                stars-5 (5/5)
                                                                -->
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <p class="rate-result-footer al-c">Ðánh giá c?a <strong class="or-txt">50</strong> khách hàng dã di chuy?n xe này</p>
                                                	
                                                </div>
                                                <ul class="rating-rank-list-large col-04 fl-l">
                                                    <li>Ch?t lu?ng xe:<span class="fl-r">4.0</span></li>
                                                    <li>Ðúng gi?:<span class="fl-r">3.6</span></li>
                                                    <li>Thái d? ph?c v?:<span class="fl-r">4.5</span></li>
                                                </ul>
                                            </div>
                                            <!-- /general rating -->
                                            
                                            <!-- Comments list-->
                                            <div class="client-comment-list clearfix">
                                            	<h2 class="hd-tt clearfix">
                                                	<a class="comment-btn fl-r" href="">
                                                    Vi?t dánh giá c?a b?n</a>Ðánh giá c?a t?ng khách hàng
                                                </h2>
                                                <ul class="comments-list clearfix">
                                                	
                                                    <li class="comment-item clearfix">
                                                    	<div class="col-04 fl-l">
                                                        	<div class="rating with-num">
                                                            	<span class="fl-r"><strong class="font-14 or-txt">4</strong>/<strong class="font-14 or-txt">5.0</strong></span>
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                                
                                                            </div>
                                                            <ul class="rating-rank-list-small fl-l">
                                                                <li>Ch?t lu?ng xe:<span class="fl-r">4.0</span></li>
                                                                <li>Ðúng gi?:<span class="fl-r">3.6</span></li>
                                                                <li>Thái d? ph?c v?:<span class="fl-r">4.5</span></li>
                                                            </ul>
                                                        </div>
                                                        
                                                      	<div class="comment-item-content clearfix">
                                                        	<h3 class="comment-author"><em class="fl-r">Chuy?n di ngày: 01/06/2013 - Ðang ngày: 08/12/2013</em><span class="author">H. An</span></h3>
                                                            <p>Chuy?n di cung khá an toàn, ph?c v? cung t?t. Nhung dôi khi xe ch?y hoi nguy hi?m (tôi c?m th?y hoi nhanh) và ph?c v? dôi lúc không du?c l?ch s?, vui v? và hoà nhã cho l?m. C?n có nh?ng bu?i tu tu?ng cho nhân viên b?i hành khách luôn c?n du?c tôn tr?ng nên thái d? ph?c v? c?n ph?i d?t lên hàng d?u. Ð?ng th?i tài x? cung c?n có thái d? h?p tác hon không ch? v?i nhân viên </p>
                                                            <div class="comment-footer clearfix">
                                                            	<p class="check fl-l">Ðã du?c Vexere.com xác nh?n ngu?i dánh giá dã di chuy?n xe này.</p>
                                                                <p class="comment-share fl-r">
                                                                	<a class="tip social-link zing fl-r" title="Chia s? trên Zing" href=""></a>
                                                                    
                                                                    <a class="tip social-link gg-plus fl-r" title="Chia s? trên Google+" href=""></a>
                                                                    <a class="tip social-link fb fl-r" title="Chia s? trên Facebook" href=""></a>
                                                                    Chia s?
                                								</p>
                                                            </div>
                                                        </div>
                                                        
                                                    </li>
                                                    
                                                    <li class="comment-item clearfix">
                                                    	<div class="col-04 fl-l">
                                                        	<div class="rating with-num">
                                                            	<span class="fl-r"><strong class="font-14 or-txt">4</strong>/<strong class="font-14 or-txt">5.0</strong></span>
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                                
                                                            </div>
                                                            <ul class="rating-rank-list-small fl-l">
                                                                <li>Ch?t lu?ng xe:<span class="fl-r">4.0</span></li>
                                                                <li>Ðúng gi?:<span class="fl-r">3.6</span></li>
                                                                <li>Thái d? ph?c v?:<span class="fl-r">4.5</span></li>
                                                            </ul>
                                                        </div>
                                                        
                                                      	<div class="comment-item-content clearfix">
                                                        	<h3 class="comment-author"><em class="fl-r">Chuy?n di ngày: 01/06/2013 - Ðang ngày: 08/12/2013</em><span class="author">L. Ng?c</span></h3>
                                                            <p>Chuy?n di cung khá an toàn, ph?c v? cung t?t. Nhung dôi khi xe ch?y hoi nguy hi?m (tôi c?m th?y hoi nhanh) và ph?c v? dôi lúc không du?c l?ch s?, vui v? và hoà nhã cho l?m. C?n có nh?ng bu?i tu tu?ng cho nhân viên b?i hành khách luôn c?n du?c tôn tr?ng nên thái d? ph?c v? c?n ph?i d?t lên hàng d?u. Ð?ng th?i tài x? cung c?n có thái d? h?p tác hon không ch? v?i nhân viên </p>
                                                            <div class="comment-footer clearfix">
                                                            	<p class="check fl-l">Ðã du?c Vexere.com xác nh?n ngu?i dánh giá dã di chuy?n xe này.</p>
                                                                <p class="comment-share fl-r">
                                                                	<a class="tip social-link zing fl-r" title="Chia s? trên Zing" href=""></a>
                                                                    
                                                                    <a class="tip social-link gg-plus fl-r" title="Chia s? trên Google+" href=""></a>
                                                                    <a class="tip social-link fb fl-r" title="Chia s? trên Facebook" href=""></a>
                                                                    Chia s?
                                								</p>
                                                            </div>
                                                        </div>
                                                        
                                                    </li>
                                                    
                                                </ul>
                                                
                                                <h2 class="pd-t-10 clearfix">
                                                	<a class="comment-btn fl-r" href="">Vi?t dánh giá c?a b?n</a>
                                                </h2>
                                                
                                            </div>
                                            <!-- /Comments list-->
                                            
                                        </div>
                                        <div class="section-footer">
                                            <img src="<%= ResolveUrl("~/Content/images/logo-med.png")%>" alt="Vexere.com" /> H? th?ng vé xe l?n nh?t Vi?t Nam
                                        </div>
                                    </div>
                                    <!-- /Rating tab content-->
                                    
                                </div>
                            </div>
                             
                             <!-- / Routes, Photos, Rating Tabs content-->
                             
                             <div class="item-footer clearfix">
                                <div class="brand fl-l">Duy nh?t có t?i <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="vexere.com" /> <span>H? th?ng vé xe l?n nh?t Vi?t Nam</span></div>
                                <div class="share fl-r">
                                    <a class="email-share fl-r" href=""><img src="<%= ResolveUrl("~/Content/images/email-icon.png")%>" alt="" /> Email</a>
                                    <div class="sc-like fl-r"><img src="<%= ResolveUrl("~/Content/images/gg-like.png")%>" alt="" /></div>
                                    <div class="sc-like fl-r"><img src="<%= ResolveUrl("~/Content/images/fb-like.png")%>" alt="" /></div>
                                    Chia s? thông tin gi?m giá v?i b?n bè 
                                </div>
                            </div>
                        	
                        </div>
                        <!-- /Result item row-->
                        
                        <!-- Result item row-->
                        <div class="result-item clearfix">
                        	<div class="item-content clearfix">
                                <!-- Transporter info-->
                                <div class="transporter-col wd-160 fl-l">
                                    <p class="transporter-name">AN BÌNH</p>
                                    <p class="route">Sài Gòn - Thái Bình</p>
                                </div>
                                <!-- /Transporter info-->
                                
                                <!-- /Benefit info-->
                                <div class="benefit-col wd-200 mg-l-15 fl-l">
                                
                                    <div class="benefit-icons pd-b-10 clearfix">
                                        <span title="Nu?c u?ng" class="icon benefit-drink fl-l" original-title=""></span>
                                        <span title="Ði?u hòa" class="icon benefit-aircon fl-l"></span>
                                        <span title="Chan d?p" class="icon benefit-blanket fl-l"></span>
                                        <span title="Th?c an" class="icon benefit-food fl-l"></span>
                                        <div class="more rel-pos fl-l">
                                            <span class="icon benefit-more benefit-drink-plus fl-l"></span>
                                            <!--more benefits popover -->
                                            <div class="tip-popover more-benefits-popover clearfix">
                                                <div class="tip-inner rounded-4 rel-pos clearfix">
                                                    <div class="tip-arrow"></div>
                                                    <h3 class="tip-tt"><span>TI?N ÍCH T? NHÀ XE</span></h3>
                                                    <div class="benefit-label clearfix">
                                                        <div class="beneits-col col-03 mg-l-10 fl-l">
                                                            <p class="icon benefit-drink">Nu?c u?ng</p>
                                                            <p class="icon benefit-aircon">Ði?u hòa</p>
                                                            <p class="icon benefit-blanket">Chan d?p</p>
                                                            <p class="icon benefit-food">Th?c an</p>
                                                            <p class="icon benefit-tissue">Khan l?nh</p>
                                                            <p class="icon benefit-dvd">DVD</p>
                                                        </div>
                                                        <div class="beneits-col col-04 fl-l">
                                                            <p class="icon benefit-wifi">Wifi</p>  
                                                            <p class="icon benefit-charger">X?c pin</p>
                                                            <p class="icon benefit-pickup-start">Xe dua dón chi?u di</p>
                                                            <p class="icon benefit-pickup-return">Xe dua dón chi?u v?</p>
                                                            <p class="icon benefit-toilet">Toilet</p>
                                                        </div>
                                                    </div>
                                                    <div class="popover-footer">
                                                        <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                        H? th?ng vé xe l?n nh?t Vi?t Nam
                                                    </div>
                                                </div>
                                            </div>
                                            <!--/more benefits popover -->
                                        </div>
                                    </div>
                                    
                                    
                                    
                                    <p class="seat-info">Giu?ng n?m 40 ch?</p>
        
                                    <p class="more-options">
                                        <a class="detail-info" href="">L?ch trình</a> |
                                        <a class="ticket-detail-images" href="">Hình ?nh</a> |
                                        <a class="ticket-detail-maps" href="">B?n d?</a>
                                    </p>
                                    
                                </div>
                                <!-- /Benefit info-->
                                
                                <!-- Depart info-->
                                <div class="depart-info-col wd-150 mg-l-15 fl-l clearfix">
                                    
                                    <div class="depart-station rel-pos fl-l">
                                        <p class="place"><strong>TP. H? Chí Minh</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                        <div class="tip-popover station-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>Thông tin ÐI?M XU?T PHÁT</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p><strong>B?n xe Mi?n Ðông</strong></p>
                                                    <p class="address">
                                                        Ð?a ch?: 292 Ðinh B? Linh - Bình Th?nh - 
                                                        TP. H? Chí Minh<br/>
                                                        Ði?n tho?i: 08.38.123.456<br/>
                                                        Website: <a href="" target="_blank">http://benxemiendong.com.vn</a><br/>
                                                        V? trí di?m dón khách: C?ng A - Khu A1 
                                                    </p>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                            
                                        </div>
                                    </div>
                                   
                                   <div class="input-set rel-pos clearfix clr">
                                       <label class="fl-l">Kh?i hành:</label>
                                       <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                            <option selected="selected" value="20:00">20:00</option>
                                            <option value="20:30">20:30</option>
                                       </select>
                                    </div>
                                    
                                    <p class="clr">S? gh? tr?ng: 2</p>
                                    
                                </div>
                                <!-- /Depart Info-->
                                
                                <!-- Destination info-->
                                <div class="destination-info-col wd-150 mg-l-15 fl-l">
                                    <div class="destination-station rel-pos fl-l">
                                        <p class="dest-place"><strong>Hà N?i</strong> <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></p>
                                        <div class="tip-popover dest-station-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>Thông tin di?m d?n</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p><strong>B?n xe Giáp Bát</strong></p>
                                                    <p class="address">
                                                        Ð?a ch?: 292 Giáp Bát - Hoàng Mai - 
                                                        Hà N?i<br/>
                                                        Ði?n tho?i: 04.38.123.456<br/>
                                                        Website: <a href="" target="_blank">http://benxegiapbat.com.vn</a><br/>
                                                        V? trí di?m dón khách: C?ng A - Khu A1 
                                                    </p>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                            
                                        </div>
                                    </div>
                                   
                                   <div class="input-set rel-pos clearfix clr">
                                       <label class="fl-l">Ð?n:</label>
                                       <select class="start-time-drop styled-02 fl-l" id="FromTimes" name="FromTimes">
                                            <option selected="selected" value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                            <option value="00:15 + 1 ngày">00:15 + 1ngày</option>
                                       </select>
                                    </div>
                                    
                                    <p class="clr">T?ng th?i gian: 32h 15''</p>
        
                                </div>
                                <!-- /Destination info-->
                                
                                <!-- Rating info-->
                                <div class="rating-col wd-130 mg-l-15 fl-l clearfix">
                                    <div class="rating mg-b-10 fl-l">
                                        <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                    </div>
                                    <div class="rating-info fl-l clr">
                                        <a class="rating-link" href="">5 dánh giá <img class="arrow-bl" src="<%= ResolveUrl("~/Content/images/arrow-07.png")%>" alt="" /></a>
                                        <div class="tip-popover rating-popover">
                                            <div class="tip-inner rounded-4 rel-pos clearfix">
                                                <div class="tip-arrow"></div>
                                                <h3 class="tip-tt"><span>ÐÁNH GIÁ NHÀ XE</span></h3>
                                                <div class="station-info pd-5-10">
                                                    <p>Ðánh giá nhà xe c?a 10 hành khách</p>
                                                    <ul class="clearfix">
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                            </div>
                                                            T?ng quan:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                            </div>
                                                            Ch?t lu?ng xe:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4" title="Ðánh giá 4/5"></span>
                                                            </div>
                                                            Ðúng gi?:
                                                        </li>
                                                        <li>
                                                            <div class="rating fl-r">
                                                                <span class="star-img stars-4-half" title="Ðánh giá 4.5/5"></span>
                                                            </div>
                                                            Thái d? ph?c v?:
                                                        </li>
                                                    </ul>
                                                </div>
                                                <div class="popover-footer">
                                                    <img src="<%= ResolveUrl("~/Content/images/logo-small.png")%>" alt="Vexere.com" /><br>
                                                    H? th?ng vé xe l?n nh?t Vi?t Nam
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <a class="cmt-btn fl-l clr" href="">Vi?t dánh giá</a>
                                    
                                    
                                </div>
                                <!-- /Rating info-->
                                
                                <!-- Price info-->
                                <div class="price-col rel-pos wd-130 mg-l-15 fl-l">
                                    <p class="price">
                                        <span class="updating">Ðang c?p nh?t giá</span>
                                    </p>
                                    <a class="ticket-ac-btn closed" href="" title="Nh?p vào dây d? xem s? di?n tho?i d?t vé">Ði?n tho?i</a>
                                    <!-- When open the detail info, change to this button-->
                                    <a class="ticket-ac-btn open" href="" style="display: none;">Ðóng l?i</a>
                                </div>
                                <!-- /Price info-->
                             </div>
                        	
                        </div>
                        <!-- /Result item row-->
                        
                    </div>
                    <!-- Search result list -->
                    
          		</div>
                
                <!-- More transporters  -->
                <div class="content-inner pd-tb-10 clearfix">
                    <h2 class="hd-tt">Xem thêm các chuy?n xe khác t? <span class="from">TP. H? Chí Minh</span> di <span class="to"> Hà N?i</span></h2>
                    <ul class="link-list">
                        <li><a href="">Xe Mai Linh</a></li>
                        <li><a href="">Xe Phu?ng Hoàng</a></li>
                        <li><a href="">Xe Hi?n Phu?c</a></li>
                        <li><a href="">Xe Phuong Trang</a></li>
                        <li><a href="">Xe Phuong Trang</a></li>
                        <li><a href="">Xe Kumho</a></li>
                        <li><a href="">Xe Sinh Tourist</a></li>
                        <li><a href="">Xe Hoàng Long</a></li>
                        <li><a href="">Xe A Ba</a></li>
                        <li><a href="">Xe Hà Linh</a></li>  
                    </ul>
                </div>
                <!-- More transporters  -->
                
                <!-- Route info  -->
                <div class="route-info common-border content-inner rounded-4 clearfix">
                    <h2 class="hd-tt mg-15"> <img src="images/route-icon.png" alt="" />Thông tin tuy?n du?ng <span class="from">TP. H? Chí Minh</span> - <span class="to">Hà N?i</span></h2>
                    <div class="route-illus clearfix">
                        <div class="start-point col-07 al-c fl-l">
                            <p class="bolder-txt font-14">TP H? Chí Minh</p>
                            <p class="hl-txt">B?n xe Mi?n Ðông</p>
                        </div>
                        <div class="distance col-09 al-c fl-l">
                            <p class="bolder-txt font-14">L? trình 1729 km</p>
                            <p>T?ng th?i gian hành trình: <strong class="font-14">32h</strong></p>
                            <p>Giá vé trung bình: <strong class="or-txt font-16">950.000 d/vé</strong></p>
                        </div>
                        <div class="end-point col-06 al-c fl-l">
                            <p class="bolder-txt font-14">Hà N?i</p>
                            <p class="hl-txt">B?n xe Giáp Bát</p>
                        </div>
                    </div>
                    
                    <p class="route-desc pd-15-20">Tuy?n TP H? Chí Minh - Hà N?i dài kho?ng 1725 km, qua 17 t?nh, thành d?c qu?c l? 1A. Trung bình m?i ngày có kho?ng 20 chuy?n xe khách ch?y tuy?n du?ng này b?t d?u t? 5h d?n11h30 do 7 nhà xe, An Bình, A Ba, Camel Travel, Thu Khuyên,  The Sinh Tourist, Hoàng Long và H?nh Cafe v?n hành. Th?i gian di chuy?n trên ch?ng kho?ng 32 gi? d?ng h?. Giá vé trên tuy?n du?ng này dao d?ng kho?ng 900.000-1.200.000 d?ng</p>
                
                </div>
                <!-- Route info  -->
                
                <!-- Back links-->
                <div class="back-links odd-row clearfix">
                    <div class="content-inner">
                        <h2>Liên k?t</h2>
                        <ul id="transporters" class="link-list">
                            <li><a href="">Xe Mai Linh</a></li>
                            <li><a href="">Xe Phu?ng Hoàng</a></li>
                            <li><a href="">Xe Hi?n Phu?c</a></li>
                            <li><a href="">Xe Phuong Trang</a></li>
                            <li><a href="">Xe Phuong Trang</a></li>
                            <li><a href="">Xe Kumho</a></li>
                            <li><a href="">Xe Sinh Tourist</a></li>
                            <li><a href="">Xe Hoàng Long</a></li>
                            <li><a href="">Xe A Ba</a></li>
                            <li><a href="">Xe Hà Linh</a></li>
                            <li><a href="">Xe Hu? Nghia</a></li>
                            <li><a href="">Xe Chín Nghia</a></li>
                            <li><a href="">Xe Thành Bu?i</a></li>
                            <li><a href="">Xe Hoàng Oanh</a></li>
                            <li><a href="">Xe Thu?n Th?o</a></li>
                            <li><a href="">Xe Cúc Tùng</a></li>
                            <li><a href="">Xe Van Lang</a></li>
                            <li><a href="">Xe Minh Th?ng</a></li>
                        </ul>
                        
                        <ul id="stations" class="link-list">
                            <li><a href="">B?n xe Mi?n Ðông</a></li>
                            <li><a href="">B?n xe Mi?n Tây</a></li>
                            <li><a href="">B?n xe Giáp Bát</a></li>
                            <li><a href="">B?n xe M? Ðình</a></li>
                            <li><a href="">B?n xe Gia Lâm</a></li>
                            <li><a href="">B?n xe Nu?c Ng?m</a></li>
                            <li><a href="">B?n xe 91B C?n Tho</a></li>
                            <li><a href="">B?n xe TT Ðà N?ng</a></li>
                            <li><a href="">B?n xe Ðà N?ng</a></li>
                            <li><a href="">B?n xe Tam B?c</a></li>
                            <li><a href="">B?n xe Ni?m Nghia</a></li>
                            <li><a href="">B?n xe C?u Rào</a></li>
                            <li><a href="">B?n xe Vinh</a></li>
                            <li><a href="">B?n xe Thanh Hoá</a></li>
                            <li><a href="">B?n xe Nha Trang</a></li>
                        </ul>
                        
                        <ul id="tickets	" class="link-list">
                            <li><a href="">Vé xe T?t</a></li>
                            <li><a href="">Giá vé xe T?t</a></li>
                            <li><a href="">Vé xe Thu?n Th?o T?t 2014</a></li>
                            <li><a href="">Vé xe Phuong Trang T?t 2014</a></li>
                            <li><a href="">Vé xe Thành Bu?i T?t 2014</a></li>
                            <li><a href="">Vé xe Hoàng Long T?t 2014</a></li>
                            <li><a href="">Vé xe Vi?t Tân Phát T?t 2014</a></li>
                            <li><a href="">Vé xe Chín Nghia T?t 2014</a></li>
                            <li><a href="">Vé xe Cúc Tùng T?t 2014</a></li>
                            <li><a href="">Vé xe T?t B?n xe Mi?n Ðông</a></li>
                            <li><a href="">Vé xe T?t B?n xe Mi?n Tây</a></li>
                            <li><a href="">Vé xe T?t B?n xe M? Ðình</a></li>
                            <li><a href="">Vé xe T?t B?n xe Giáp Bát</a></li>
                        </ul>
                    </div>
                </div>
                <!-- Back links-->
            </div>
            <!-- footer-->
            <div id="footer">
            	<div class="content-inner clearfix">
                	<div class="semi-footer clearfix">
              			<div class="col-06 fl-l">
                        	<h3 class="h3-tt">V? chúng tôi</h3>
                            <ul class="footer-links">
                            	<li><a href="">Tin t?c</a></li>
                                <li><a href="">Gi?i thi?u</a></li>
                                <li><a href="">Liên h?</a></li>
                                <li><a href="">Ði?u kho?n & Ði?u ki?n</a></li>
                            </ul>
                        </div>
                        
                        <div class="alt col-06 fl-l">
                        	<h3 class="h3-tt">H? tr?</h3>
                            <ul class="footer-links">
                            	<li><a href="">Hu?ng d?n thanh toán</a></li>
                                <li><a href="">Co ch? gi?i quy?t tranh ch?p</a></li>
                                <li><a href="">Quy ch? Vé Xe R?</a></li>
                            </ul>
                        </div>
                        
                        <div class="alt col-08 fl-r">
                        	<h3 class="h3-tt">K?t n?i v?i chúng tôi</h3>
                            
                        	<div class="social col-08 clearfix">
                                <a class="social-icon fb" title="Facebook" href="">Facebook</a>
                                <a class="social-icon google-plus" title="Google+" href="">Google+</a>
                                <a class="social-icon zing" title="Zing" href="">Zing</a>
                                <a class="social-icon tw" title="Twitter" href="">Twitter</a>
                                <a class="social-icon yt" title="Youtube" href="">Youtube</a> 
                            </div>
                            
                            <div class="hotline-ctn col-08 clearfix">
                                <span class="hotline">Hotline:</span> <span class="hotline-num">0969.52.33.77 - 0909.10.89.69</span>
                            </div>
                            
                            <div class="input-set rel-pos clearfix">
                            	<input class="input-txt" placeholder="Nh?p d?a ch? email c?a b?n" />
                                <button class="submit">G?i</button>
                            </div>
                            
                     	</div>
                        
                     </div>
                     
                     <div id="copyright" class="clearfix">
                        <a class="logo-footer fl-l mg-r-30" href=""><img src="<%= ResolveUrl("~/Content/images/logo-footer.png")%>" alt="" /></a>
                        <div class="copyright-txt col-14 fl-l mg-r-10">
                            <p>B?n quy?n © 2012 thu?c v? VeXeRe.Com</p>
                            <p>Ð?a ch?: 8C Ch? Ð?ng T?, P.7, Q.Tân Bình, TP. H? Chí Minh, Vi?t Nam - ÐT: 0909 108 969<br />
                            Gi?y ch?ng nh?n ÐKKD s? 0312387105 do S? KH& ÐT TP. H? Chí Minh c?p l?n d?u ngày 25/7/2013</p>
                        </div>
                        <div class="register fl-l"><a href=""><img src="<%= ResolveUrl("~/Content/images/dk.png")%>" alt="" /></a></div>
                        <a id="chat" class="chat-btn" href="">Chat with us</a>
                    </div>
                
              </div>
            
            </div>
            <!-- /footer-->
        </div>
	</div>
    
    <!-- JS-->
    <!--script type="text/javascript" src="http://code.jquery.com/jquery-latest.min.js"></script-->
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery-1.10.2.min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery-ui.js") %>"></script>
	<script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.customSelect.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.tipsy.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.nivo.slider.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jcarousellite.min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/jquery.watermark.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/ui.dropdownchecklist-1.4-min.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveUrl("~/Content/js/vxr.js") %>"></script>
    
</body>
</html>
', NULL, NULL, NULL, CAST(0x0000A3FE00C4946C AS DateTime), CAST(0x0000A3FE00C4946C AS DateTime), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[gc_Template] OFF
/****** Object:  Index [IXFK_gc_Function_Input_gc_Function]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Function_Input]') AND name = N'IXFK_gc_Function_Input_gc_Function')
CREATE NONCLUSTERED INDEX [IXFK_gc_Function_Input_gc_Function] ON [dbo].[gc_Function_Input]
(
	[FunctionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_gc_Function_Output_gc_Function]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Function_Output]') AND name = N'IXFK_gc_Function_Output_gc_Function')
CREATE NONCLUSTERED INDEX [IXFK_gc_Function_Output_gc_Function] ON [dbo].[gc_Function_Output]
(
	[FunctionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_gc_Page_gc_App]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Page]') AND name = N'IXFK_gc_Page_gc_App')
CREATE NONCLUSTERED INDEX [IXFK_gc_Page_gc_App] ON [dbo].[gc_Page]
(
	[AppId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_gc_Page_Param_gc_Page]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Page_Param]') AND name = N'IXFK_gc_Page_Param_gc_Page')
CREATE NONCLUSTERED INDEX [IXFK_gc_Page_Param_gc_Page] ON [dbo].[gc_Page_Param]
(
	[PageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_gc_Page_Template_gc_Page]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Page_Template]') AND name = N'IXFK_gc_Page_Template_gc_Page')
CREATE NONCLUSTERED INDEX [IXFK_gc_Page_Template_gc_Page] ON [dbo].[gc_Page_Template]
(
	[PageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_gc_Page_Template_gc_Template]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Page_Template]') AND name = N'IXFK_gc_Page_Template_gc_Template')
CREATE NONCLUSTERED INDEX [IXFK_gc_Page_Template_gc_Template] ON [dbo].[gc_Page_Template]
(
	[TemplateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_gc_Event_gc_Template]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Template_Event]') AND name = N'IXFK_gc_Event_gc_Template')
CREATE NONCLUSTERED INDEX [IXFK_gc_Event_gc_Template] ON [dbo].[gc_Template_Event]
(
	[TemplateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_gc_Template_Event_gc_Function]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Template_Event]') AND name = N'IXFK_gc_Template_Event_gc_Function')
CREATE NONCLUSTERED INDEX [IXFK_gc_Template_Event_gc_Function] ON [dbo].[gc_Template_Event]
(
	[FunctionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_gc_Template_Slot_gc_Template]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Template_Slot]') AND name = N'IXFK_gc_Template_Slot_gc_Template')
CREATE NONCLUSTERED INDEX [IXFK_gc_Template_Slot_gc_Template] ON [dbo].[gc_Template_Slot]
(
	[TemplateId1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IXFK_gc_Template_Slot_gc_Template_02]    Script Date: 12/12/2014 11:54:43 AM ******/
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[gc_Template_Slot]') AND name = N'IXFK_gc_Template_Slot_gc_Template_02')
CREATE NONCLUSTERED INDEX [IXFK_gc_Template_Slot_gc_Template_02] ON [dbo].[gc_Template_Slot]
(
	[TemplateId2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_App__Type__0F975522]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_App] ADD  DEFAULT ((1)) FOR [Type]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_App__isPrgCre__108B795B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_App] ADD  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_App__isPrgUpd__117F9D94]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_App] ADD  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Functi__isPrg__1367E606]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Function] ADD  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Functi__isPrg__145C0A3F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Function] ADD  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Functi__isPrg__173876EA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Function_Input] ADD  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Functi__isPrg__182C9B23]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Function_Input] ADD  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Functi__isPrg__1A14E395]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Function_Output] ADD  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Functi__isPrg__1B0907CE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Function_Output] ADD  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Page__Type__1CF15040]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page] ADD  CONSTRAINT [DF__gc_Page__Type__1CF15040]  DEFAULT ((2)) FOR [Type]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Page__isPrgCr__1DE57479]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page] ADD  CONSTRAINT [DF__gc_Page__isPrgCr__1DE57479]  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Page__isPrgUp__1ED998B2]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page] ADD  CONSTRAINT [DF__gc_Page__isPrgUp__1ED998B2]  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Page_P__isPrg__20C1E124]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page_Param] ADD  CONSTRAINT [DF__gc_Page_P__isPrg__20C1E124]  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Page_P__isPrg__21B6055D]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page_Param] ADD  CONSTRAINT [DF__gc_Page_P__isPrg__21B6055D]  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Page_T__IsAct__239E4DCF]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page_Template] ADD  DEFAULT ((1)) FOR [IsActive]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Page_T__isPrg__24927208]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page_Template] ADD  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Page_T__isPrg__25869641]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page_Template] ADD  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_gc_Page_RegEx_isPrgCreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page_URLFormat] ADD  CONSTRAINT [DF_gc_Page_RegEx_isPrgCreatedDate]  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_gc_Page_RegEx_isPrgUpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Page_URLFormat] ADD  CONSTRAINT [DF_gc_Page_RegEx_isPrgUpdatedDate]  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Templat__Type__276EDEB3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Template] ADD  DEFAULT ((1)) FOR [Type]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Templa__isPrg__286302EC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Template] ADD  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Templa__isPrg__29572725]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Template] ADD  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Templa__IsAct__2B3F6F97]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Template_Event] ADD  DEFAULT ((1)) FOR [IsActive]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Templa__isPrg__2C3393D0]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Template_Event] ADD  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Templa__isPrg__2D27B809]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Template_Event] ADD  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Templat__Type__2F10007B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Template_Slot] ADD  DEFAULT ((1)) FOR [Type]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Templa__isPrg__300424B4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Template_Slot] ADD  DEFAULT (getdate()) FOR [isPrgCreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__gc_Templa__isPrg__30F848ED]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[gc_Template_Slot] ADD  DEFAULT (getdate()) FOR [isPrgUpdatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Function_Input_gc_Function]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Function_Input]'))
ALTER TABLE [dbo].[gc_Function_Input]  WITH CHECK ADD  CONSTRAINT [FK_gc_Function_Input_gc_Function] FOREIGN KEY([FunctionId])
REFERENCES [dbo].[gc_Function] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Function_Input_gc_Function]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Function_Input]'))
ALTER TABLE [dbo].[gc_Function_Input] CHECK CONSTRAINT [FK_gc_Function_Input_gc_Function]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Function_Output_gc_Function]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Function_Output]'))
ALTER TABLE [dbo].[gc_Function_Output]  WITH CHECK ADD  CONSTRAINT [FK_gc_Function_Output_gc_Function] FOREIGN KEY([FunctionId])
REFERENCES [dbo].[gc_Function] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Function_Output_gc_Function]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Function_Output]'))
ALTER TABLE [dbo].[gc_Function_Output] CHECK CONSTRAINT [FK_gc_Function_Output_gc_Function]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_gc_App]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page]'))
ALTER TABLE [dbo].[gc_Page]  WITH CHECK ADD  CONSTRAINT [FK_gc_Page_gc_App] FOREIGN KEY([AppId])
REFERENCES [dbo].[gc_App] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_gc_App]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page]'))
ALTER TABLE [dbo].[gc_Page] CHECK CONSTRAINT [FK_gc_Page_gc_App]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_Param_gc_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page_Param]'))
ALTER TABLE [dbo].[gc_Page_Param]  WITH CHECK ADD  CONSTRAINT [FK_gc_Page_Param_gc_Page] FOREIGN KEY([PageId])
REFERENCES [dbo].[gc_Page] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_Param_gc_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page_Param]'))
ALTER TABLE [dbo].[gc_Page_Param] CHECK CONSTRAINT [FK_gc_Page_Param_gc_Page]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_Template_gc_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page_Template]'))
ALTER TABLE [dbo].[gc_Page_Template]  WITH CHECK ADD  CONSTRAINT [FK_gc_Page_Template_gc_Page] FOREIGN KEY([PageId])
REFERENCES [dbo].[gc_Page] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_Template_gc_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page_Template]'))
ALTER TABLE [dbo].[gc_Page_Template] CHECK CONSTRAINT [FK_gc_Page_Template_gc_Page]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_Template_gc_Template]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page_Template]'))
ALTER TABLE [dbo].[gc_Page_Template]  WITH CHECK ADD  CONSTRAINT [FK_gc_Page_Template_gc_Template] FOREIGN KEY([TemplateId])
REFERENCES [dbo].[gc_Template] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_Template_gc_Template]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page_Template]'))
ALTER TABLE [dbo].[gc_Page_Template] CHECK CONSTRAINT [FK_gc_Page_Template_gc_Template]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_RegEx_gc_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page_URLFormat]'))
ALTER TABLE [dbo].[gc_Page_URLFormat]  WITH CHECK ADD  CONSTRAINT [FK_gc_Page_RegEx_gc_Page] FOREIGN KEY([PageId])
REFERENCES [dbo].[gc_Page] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Page_RegEx_gc_Page]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Page_URLFormat]'))
ALTER TABLE [dbo].[gc_Page_URLFormat] CHECK CONSTRAINT [FK_gc_Page_RegEx_gc_Page]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Event_gc_Template]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Template_Event]'))
ALTER TABLE [dbo].[gc_Template_Event]  WITH CHECK ADD  CONSTRAINT [FK_gc_Event_gc_Template] FOREIGN KEY([TemplateId])
REFERENCES [dbo].[gc_Template] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Event_gc_Template]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Template_Event]'))
ALTER TABLE [dbo].[gc_Template_Event] CHECK CONSTRAINT [FK_gc_Event_gc_Template]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Template_Event_gc_Function]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Template_Event]'))
ALTER TABLE [dbo].[gc_Template_Event]  WITH CHECK ADD  CONSTRAINT [FK_gc_Template_Event_gc_Function] FOREIGN KEY([FunctionId])
REFERENCES [dbo].[gc_Function] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Template_Event_gc_Function]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Template_Event]'))
ALTER TABLE [dbo].[gc_Template_Event] CHECK CONSTRAINT [FK_gc_Template_Event_gc_Function]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Template_Slot_gc_Template]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Template_Slot]'))
ALTER TABLE [dbo].[gc_Template_Slot]  WITH CHECK ADD  CONSTRAINT [FK_gc_Template_Slot_gc_Template] FOREIGN KEY([TemplateId1])
REFERENCES [dbo].[gc_Template] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Template_Slot_gc_Template]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Template_Slot]'))
ALTER TABLE [dbo].[gc_Template_Slot] CHECK CONSTRAINT [FK_gc_Template_Slot_gc_Template]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Template_Slot_gc_Template_02]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Template_Slot]'))
ALTER TABLE [dbo].[gc_Template_Slot]  WITH CHECK ADD  CONSTRAINT [FK_gc_Template_Slot_gc_Template_02] FOREIGN KEY([TemplateId2])
REFERENCES [dbo].[gc_Template] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_gc_Template_Slot_gc_Template_02]') AND parent_object_id = OBJECT_ID(N'[dbo].[gc_Template_Slot]'))
ALTER TABLE [dbo].[gc_Template_Slot] CHECK CONSTRAINT [FK_gc_Template_Slot_gc_Template_02]
GO
USE [master]
GO
ALTER DATABASE [gCore] SET  READ_WRITE 
GO
