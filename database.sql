USE [master]
GO
/****** Object:  Database [dmrstock]    Script Date: 12/17/2023 7:33:48 PM ******/
CREATE DATABASE [dmrstock]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dmrstock', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dmrstock.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dmrstock_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dmrstock_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dmrstock] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dmrstock].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dmrstock] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dmrstock] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dmrstock] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dmrstock] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dmrstock] SET ARITHABORT OFF 
GO
ALTER DATABASE [dmrstock] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dmrstock] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dmrstock] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dmrstock] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dmrstock] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dmrstock] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dmrstock] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dmrstock] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dmrstock] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dmrstock] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dmrstock] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dmrstock] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dmrstock] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dmrstock] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dmrstock] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dmrstock] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dmrstock] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dmrstock] SET RECOVERY FULL 
GO
ALTER DATABASE [dmrstock] SET  MULTI_USER 
GO
ALTER DATABASE [dmrstock] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dmrstock] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dmrstock] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dmrstock] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dmrstock] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dmrstock] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dmrstock] SET QUERY_STORE = OFF
GO
USE [dmrstock]
GO
/****** Object:  Table [dbo].[client]    Script Date: 12/17/2023 7:33:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[n_client] [int] IDENTITY(1,1) NOT NULL,
	[ice] [nchar](20) NULL,
	[nom_client] [nchar](120) NULL,
	[respnsable] [nchar](100) NULL,
	[tel] [nchar](20) NULL,
	[email] [nchar](30) NULL,
	[adresse] [nchar](100) NULL,
	[ville] [nchar](30) NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[n_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dentree]    Script Date: 12/17/2023 7:33:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dentree](
	[n entree] [int] NOT NULL,
	[n produit] [nchar](50) NOT NULL,
	[qte] [int] NOT NULL,
 CONSTRAINT [PK_dentree] PRIMARY KEY CLUSTERED 
(
	[n entree] ASC,
	[n produit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dfacture]    Script Date: 12/17/2023 7:33:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dfacture](
	[N_facture] [int] NOT NULL,
	[N_sortie] [int] NOT NULL,
 CONSTRAINT [PK_dfacture] PRIMARY KEY CLUSTERED 
(
	[N_facture] ASC,
	[N_sortie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dsortie]    Script Date: 12/17/2023 7:33:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dsortie](
	[n sortie] [int] NOT NULL,
	[n produit] [nchar](50) NOT NULL,
	[qte] [int] NOT NULL,
	[prix_vente] [float] NULL,
 CONSTRAINT [PK_dsortie] PRIMARY KEY CLUSTERED 
(
	[n sortie] ASC,
	[n produit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entree]    Script Date: 12/17/2023 7:33:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entree](
	[n entre] [int] IDENTITY(1,1) NOT NULL,
	[type piece] [nchar](50) NULL,
	[n piece] [nchar](100) NULL,
	[date entre] [date] NULL,
	[entree par] [nchar](50) NULL,
 CONSTRAINT [PK_entre] PRIMARY KEY CLUSTERED 
(
	[n entre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facture]    Script Date: 12/17/2023 7:33:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facture](
	[N_facture] [int] IDENTITY(1,1) NOT NULL,
	[Date_facture] [date] NULL,
	[paye] [int] NULL,
	[mode reglement] [nchar](30) NULL,
	[taux_remise] [float] NULL,
 CONSTRAINT [PK_facture] PRIMARY KEY CLUSTERED 
(
	[N_facture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produit]    Script Date: 12/17/2023 7:33:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produit](
	[n produit] [nchar](50) NOT NULL,
	[libelle] [nchar](50) NULL,
	[stock] [int] NULL,
	[prix achat] [float] NULL,
	[prix vente] [float] NULL,
 CONSTRAINT [PK_produit] PRIMARY KEY CLUSTERED 
(
	[n produit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sortie ]    Script Date: 12/17/2023 7:33:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sortie ](
	[n_sortie] [int] IDENTITY(1,1) NOT NULL,
	[n_client] [int] NOT NULL,
	[nom_client] [nchar](120) NULL,
	[date sortie] [date] NULL,
	[sortie_par] [nchar](20) NULL,
	[facture] [int] NOT NULL,
 CONSTRAINT [PK_sortie 2] PRIMARY KEY CLUSTERED 
(
	[n_sortie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 12/17/2023 7:33:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilisateur](
	[email] [nchar](50) NOT NULL,
	[login] [nchar](20) NULL,
	[mot de passe] [nchar](10) NULL,
	[type] [nchar](20) NULL,
 CONSTRAINT [PK_utilisateur] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[facture] ADD  CONSTRAINT [DF_facture_paye]  DEFAULT ((0)) FOR [paye]
GO
ALTER TABLE [dbo].[sortie ] ADD  CONSTRAINT [DF_sortie _facture]  DEFAULT ((0)) FOR [facture]
GO
ALTER TABLE [dbo].[dentree]  WITH CHECK ADD  CONSTRAINT [FK_dentree_entree] FOREIGN KEY([n entree])
REFERENCES [dbo].[entree] ([n entre])
GO
ALTER TABLE [dbo].[dentree] CHECK CONSTRAINT [FK_dentree_entree]
GO
ALTER TABLE [dbo].[dentree]  WITH CHECK ADD  CONSTRAINT [FK_dentree_produit] FOREIGN KEY([n produit])
REFERENCES [dbo].[produit] ([n produit])
GO
ALTER TABLE [dbo].[dentree] CHECK CONSTRAINT [FK_dentree_produit]
GO
ALTER TABLE [dbo].[dsortie]  WITH CHECK ADD  CONSTRAINT [FK_dsortie_produit] FOREIGN KEY([n produit])
REFERENCES [dbo].[produit] ([n produit])
GO
ALTER TABLE [dbo].[dsortie] CHECK CONSTRAINT [FK_dsortie_produit]
GO
ALTER TABLE [dbo].[dsortie]  WITH CHECK ADD  CONSTRAINT [FK_dsortie_sortie 1] FOREIGN KEY([n sortie])
REFERENCES [dbo].[sortie ] ([n_sortie])
GO
ALTER TABLE [dbo].[dsortie] CHECK CONSTRAINT [FK_dsortie_sortie 1]
GO
ALTER TABLE [dbo].[sortie ]  WITH CHECK ADD  CONSTRAINT [FK_sortie _client1] FOREIGN KEY([n_client])
REFERENCES [dbo].[client] ([n_client])
GO
ALTER TABLE [dbo].[sortie ] CHECK CONSTRAINT [FK_sortie _client1]
GO
USE [master]
GO
ALTER DATABASE [dmrstock] SET  READ_WRITE 
GO
