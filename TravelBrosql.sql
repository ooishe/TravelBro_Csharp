USE [master]
GO
/****** Object:  Database [TravelBro]    Script Date: 25/09/2024 11:30:16 am ******/
CREATE DATABASE [TravelBro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TravelBro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TravelBro.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TravelBro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\TravelBro_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TravelBro] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TravelBro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TravelBro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TravelBro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TravelBro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TravelBro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TravelBro] SET ARITHABORT OFF 
GO
ALTER DATABASE [TravelBro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TravelBro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TravelBro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TravelBro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TravelBro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TravelBro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TravelBro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TravelBro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TravelBro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TravelBro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TravelBro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TravelBro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TravelBro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TravelBro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TravelBro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TravelBro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TravelBro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TravelBro] SET RECOVERY FULL 
GO
ALTER DATABASE [TravelBro] SET  MULTI_USER 
GO
ALTER DATABASE [TravelBro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TravelBro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TravelBro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TravelBro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TravelBro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TravelBro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TravelBro] SET QUERY_STORE = ON
GO
ALTER DATABASE [TravelBro] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TravelBro]
GO
/****** Object:  Table [dbo].[user_prepack_id]    Script Date: 25/09/2024 11:30:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_prepack_id](
	[u_id] [varchar](50) NOT NULL,
	[pr_id] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_info]    Script Date: 25/09/2024 11:30:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_info](
	[u_id] [varchar](50) NOT NULL,
	[u_name] [varchar](50) NULL,
	[u_pass] [varchar](50) NOT NULL,
	[u_mail] [varchar](50) NULL,
	[u_gender] [varchar](50) NULL,
	[u_phone] [varchar](50) NULL,
	[ad_id] [varchar](50) NOT NULL,
 CONSTRAINT [PK_user_info] PRIMARY KEY CLUSTERED 
(
	[u_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prepack_info]    Script Date: 25/09/2024 11:30:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prepack_info](
	[pr_id] [varchar](50) NOT NULL,
	[pr_dest] [varchar](50) NOT NULL,
	[pr_hotel] [varchar](50) NOT NULL,
	[pr_price] [float] NOT NULL,
	[pr_pcount] [int] NOT NULL,
	[ad_id] [varchar](50) NOT NULL,
	[pr_image] [image] NULL,
	[pr_duration] [varchar](50) NULL,
 CONSTRAINT [PK_prepack_info] PRIMARY KEY CLUSTERED 
(
	[pr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[CustomerPrepackInfoView]    Script Date: 25/09/2024 11:30:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
CREATE VIEW [dbo].[CustomerPrepackInfoView] AS
SELECT 
    uinfo.u_id, 
    uinfo.u_name, 
    pinfo.pr_id,
    pinfo.pr_dest, 
    pinfo.pr_hotel, 
    pinfo.pr_price, 
    pinfo.pr_pcount, 
    pinfo.ad_id, 
    pinfo.pr_image, 
    pinfo.pr_duration
FROM 
    [TravelBro].[dbo].[user_prepack_id] upi
JOIN 
    [TravelBro].[dbo].[prepack_info] pinfo
ON 
    upi.pr_id = pinfo.pr_id
JOIN 
    [TravelBro].[dbo].[user_info] uinfo
ON 
    upi.u_id = uinfo.u_id;

GO
/****** Object:  Table [dbo].[admin_info]    Script Date: 25/09/2024 11:30:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin_info](
	[ad_id] [varchar](50) NOT NULL,
	[ad_name] [varchar](50) NOT NULL,
	[ad_pass] [varchar](50) NOT NULL,
 CONSTRAINT [PK_admin_info] PRIMARY KEY CLUSTERED 
(
	[ad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[agency_info]    Script Date: 25/09/2024 11:30:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[agency_info](
	[ag_id] [varchar](50) NOT NULL,
	[ag_name] [varchar](50) NOT NULL,
	[ag_phone] [varchar](50) NULL,
	[ag_mail] [varchar](50) NULL,
	[ag_loc] [varchar](50) NULL,
	[ad_id] [varchar](50) NOT NULL,
	[ag_pass] [varchar](50) NULL,
 CONSTRAINT [PK_agency_info] PRIMARY KEY CLUSTERED 
(
	[ag_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 25/09/2024 11:30:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ContactID] [int] NOT NULL,
	[Last Name] [nchar](50) NOT NULL,
	[First Name] [nchar](50) NOT NULL,
	[Contact No] [nchar](50) NOT NULL,
	[Gender] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[custompack_info]    Script Date: 25/09/2024 11:30:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[custompack_info](
	[c_id] [varchar](50) NOT NULL,
	[c_dest] [varchar](50) NOT NULL,
	[c_price] [varchar](50) NOT NULL,
	[c_pcount] [float] NOT NULL,
	[ad_id] [varchar](50) NOT NULL,
 CONSTRAINT [PK_custompack_info] PRIMARY KEY CLUSTERED 
(
	[c_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payment_info]    Script Date: 25/09/2024 11:30:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment_info](
	[pay_id] [varchar](50) NOT NULL,
	[pay_through] [varchar](50) NOT NULL,
	[pay_amnt] [float] NOT NULL,
	[ad_id] [varchar](50) NOT NULL,
 CONSTRAINT [PK_payment_info] PRIMARY KEY CLUSTERED 
(
	[pay_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prepack_agency_id]    Script Date: 25/09/2024 11:30:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prepack_agency_id](
	[pr_id] [varchar](50) NOT NULL,
	[ag_id] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_custompack_id]    Script Date: 25/09/2024 11:30:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_custompack_id](
	[u_id] [varchar](50) NOT NULL,
	[c_id] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_payment_id]    Script Date: 25/09/2024 11:30:17 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_payment_id](
	[u_id] [varchar](50) NOT NULL,
	[pay_id] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[agency_info]  WITH CHECK ADD  CONSTRAINT [FK_agency_info_admin_info] FOREIGN KEY([ad_id])
REFERENCES [dbo].[admin_info] ([ad_id])
GO
ALTER TABLE [dbo].[agency_info] CHECK CONSTRAINT [FK_agency_info_admin_info]
GO
ALTER TABLE [dbo].[custompack_info]  WITH CHECK ADD  CONSTRAINT [FK_custompack_info_admin_info] FOREIGN KEY([ad_id])
REFERENCES [dbo].[admin_info] ([ad_id])
GO
ALTER TABLE [dbo].[custompack_info] CHECK CONSTRAINT [FK_custompack_info_admin_info]
GO
ALTER TABLE [dbo].[payment_info]  WITH CHECK ADD  CONSTRAINT [FK_payment_info_admin_info] FOREIGN KEY([ad_id])
REFERENCES [dbo].[admin_info] ([ad_id])
GO
ALTER TABLE [dbo].[payment_info] CHECK CONSTRAINT [FK_payment_info_admin_info]
GO
ALTER TABLE [dbo].[prepack_agency_id]  WITH CHECK ADD  CONSTRAINT [FK_prepcack_agency_id_agency_info] FOREIGN KEY([ag_id])
REFERENCES [dbo].[agency_info] ([ag_id])
GO
ALTER TABLE [dbo].[prepack_agency_id] CHECK CONSTRAINT [FK_prepcack_agency_id_agency_info]
GO
ALTER TABLE [dbo].[prepack_agency_id]  WITH CHECK ADD  CONSTRAINT [FK_prepcack_agency_id_prepack_info] FOREIGN KEY([pr_id])
REFERENCES [dbo].[prepack_info] ([pr_id])
GO
ALTER TABLE [dbo].[prepack_agency_id] CHECK CONSTRAINT [FK_prepcack_agency_id_prepack_info]
GO
ALTER TABLE [dbo].[prepack_info]  WITH CHECK ADD  CONSTRAINT [FK_prepack_info_admin_info] FOREIGN KEY([ad_id])
REFERENCES [dbo].[admin_info] ([ad_id])
GO
ALTER TABLE [dbo].[prepack_info] CHECK CONSTRAINT [FK_prepack_info_admin_info]
GO
ALTER TABLE [dbo].[user_custompack_id]  WITH CHECK ADD  CONSTRAINT [FK_user_custompack_id_custompack_info] FOREIGN KEY([c_id])
REFERENCES [dbo].[custompack_info] ([c_id])
GO
ALTER TABLE [dbo].[user_custompack_id] CHECK CONSTRAINT [FK_user_custompack_id_custompack_info]
GO
ALTER TABLE [dbo].[user_custompack_id]  WITH CHECK ADD  CONSTRAINT [FK_user_custompack_id_user_custompack_id_u_id] FOREIGN KEY([u_id])
REFERENCES [dbo].[user_info] ([u_id])
GO
ALTER TABLE [dbo].[user_custompack_id] CHECK CONSTRAINT [FK_user_custompack_id_user_custompack_id_u_id]
GO
ALTER TABLE [dbo].[user_info]  WITH CHECK ADD  CONSTRAINT [FK_user_info_admin_info] FOREIGN KEY([ad_id])
REFERENCES [dbo].[admin_info] ([ad_id])
GO
ALTER TABLE [dbo].[user_info] CHECK CONSTRAINT [FK_user_info_admin_info]
GO
ALTER TABLE [dbo].[user_payment_id]  WITH CHECK ADD  CONSTRAINT [FK_user_payment_id_payment_info] FOREIGN KEY([pay_id])
REFERENCES [dbo].[payment_info] ([pay_id])
GO
ALTER TABLE [dbo].[user_payment_id] CHECK CONSTRAINT [FK_user_payment_id_payment_info]
GO
ALTER TABLE [dbo].[user_payment_id]  WITH CHECK ADD  CONSTRAINT [FK_user_payment_id_user_info] FOREIGN KEY([u_id])
REFERENCES [dbo].[user_info] ([u_id])
GO
ALTER TABLE [dbo].[user_payment_id] CHECK CONSTRAINT [FK_user_payment_id_user_info]
GO
ALTER TABLE [dbo].[user_prepack_id]  WITH CHECK ADD  CONSTRAINT [FK_user_prepack_id_prepack_info] FOREIGN KEY([pr_id])
REFERENCES [dbo].[prepack_info] ([pr_id])
GO
ALTER TABLE [dbo].[user_prepack_id] CHECK CONSTRAINT [FK_user_prepack_id_prepack_info]
GO
ALTER TABLE [dbo].[user_prepack_id]  WITH CHECK ADD  CONSTRAINT [FK_user_prepack_id_user_info] FOREIGN KEY([u_id])
REFERENCES [dbo].[user_info] ([u_id])
GO
ALTER TABLE [dbo].[user_prepack_id] CHECK CONSTRAINT [FK_user_prepack_id_user_info]
GO
USE [master]
GO
ALTER DATABASE [TravelBro] SET  READ_WRITE 
GO
