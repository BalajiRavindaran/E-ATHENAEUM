USE [master]
GO
/****** Object:  Database [eathenaeumDB]    Script Date: 11-07-2022 10:47:07 ******/
CREATE DATABASE [eathenaeumDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'eathenaeumDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\eathenaeumDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'eathenaeumDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\eathenaeumDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [eathenaeumDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [eathenaeumDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [eathenaeumDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [eathenaeumDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [eathenaeumDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [eathenaeumDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [eathenaeumDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [eathenaeumDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [eathenaeumDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [eathenaeumDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [eathenaeumDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [eathenaeumDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [eathenaeumDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [eathenaeumDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [eathenaeumDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [eathenaeumDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [eathenaeumDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [eathenaeumDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [eathenaeumDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [eathenaeumDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [eathenaeumDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [eathenaeumDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [eathenaeumDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [eathenaeumDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [eathenaeumDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [eathenaeumDB] SET  MULTI_USER 
GO
ALTER DATABASE [eathenaeumDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [eathenaeumDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [eathenaeumDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [eathenaeumDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [eathenaeumDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [eathenaeumDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [eathenaeumDB] SET QUERY_STORE = OFF
GO
USE [eathenaeumDB]
GO
/****** Object:  Table [dbo].[admin_tbl]    Script Date: 11-07-2022 10:47:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin_tbl](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[full_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_admin_tbl] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[author_tbl]    Script Date: 11-07-2022 10:47:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[author_tbl](
	[author_id] [nvarchar](20) NOT NULL,
	[author_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_author_tbl] PRIMARY KEY CLUSTERED 
(
	[author_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book_issue_tbl]    Script Date: 11-07-2022 10:47:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book_issue_tbl](
	[member_id] [nvarchar](50) NULL,
	[member_name] [nvarchar](50) NULL,
	[book_id] [nvarchar](50) NULL,
	[book_name] [nvarchar](max) NULL,
	[issue_date] [nvarchar](50) NULL,
	[due_date] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book_tbl]    Script Date: 11-07-2022 10:47:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book_tbl](
	[book_id] [nchar](10) NOT NULL,
	[book_name] [nvarchar](max) NULL,
	[genre] [nvarchar](max) NULL,
	[author_name] [nvarchar](max) NULL,
	[publisher_name] [nvarchar](max) NULL,
	[publish_date] [nvarchar](50) NULL,
	[language] [nvarchar](50) NULL,
	[edition] [nvarchar](max) NULL,
	[book_cost] [nchar](10) NULL,
	[no_of_pages] [nchar](10) NULL,
	[book_description] [nvarchar](max) NULL,
	[actual_stock] [nchar](10) NULL,
	[current_stock] [nchar](10) NULL,
	[book_img_link] [nvarchar](max) NULL,
 CONSTRAINT [PK_book_tbl] PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[member_tbl]    Script Date: 11-07-2022 10:47:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member_tbl](
	[full_name] [nvarchar](50) NULL,
	[dob] [nvarchar](50) NULL,
	[contact_no] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[state] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[pincode] [nvarchar](50) NULL,
	[full_address] [nvarchar](max) NULL,
	[member_id] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[account_status] [nvarchar](50) NULL,
 CONSTRAINT [PK_member_tbl] PRIMARY KEY CLUSTERED 
(
	[member_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[publisher_tbl]    Script Date: 11-07-2022 10:47:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[publisher_tbl](
	[publisher_id] [nchar](10) NOT NULL,
	[publisher_name] [nvarchar](max) NULL,
 CONSTRAINT [PK_publisher_tbl] PRIMARY KEY CLUSTERED 
(
	[publisher_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [eathenaeumDB] SET  READ_WRITE 
GO
