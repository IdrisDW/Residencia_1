USE [master]
GO
/****** Object:  Database [AnalisisResidencia]    Script Date: 24/3/2020 21:48:45 ******/
CREATE DATABASE [AnalisisResidencia] ON  PRIMARY 
( NAME = N'AnalisisResidencia', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\AnalisisResidencia.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AnalisisResidencia_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\AnalisisResidencia_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AnalisisResidencia] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AnalisisResidencia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AnalisisResidencia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET ARITHABORT OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AnalisisResidencia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AnalisisResidencia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AnalisisResidencia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AnalisisResidencia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AnalisisResidencia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AnalisisResidencia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AnalisisResidencia] SET  MULTI_USER 
GO
ALTER DATABASE [AnalisisResidencia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AnalisisResidencia] SET DB_CHAINING OFF 
GO
USE [AnalisisResidencia]
GO
/****** Object:  Table [dbo].[Compound]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compound](
	[id_Compound] [int] IDENTITY(1,1) NOT NULL,
	[CompoundName] [varchar](150) NULL,
 CONSTRAINT [PK_Compound] PRIMARY KEY CLUSTERED 
(
	[id_Compound] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[id_Doctor] [int] IDENTITY(1,1) NOT NULL,
	[DoctorName] [varchar](150) NULL,
	[DoctorLastName] [varchar](150) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[id_Doctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[User] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[id_Material] [int] IDENTITY(1,1) NOT NULL,
	[MaterialName] [varchar](150) NULL,
	[MaterialQuantity] [int] NULL,
	[MaterialExpDate] [date] NULL,
	[MaterialUnits] [decimal](18, 2) NULL,
	[idSupplier] [int] NULL,
	[MaterialQuantityPres] [varchar](20) NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[id_Material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[id_Medicine] [int] IDENTITY(1,1) NOT NULL,
	[MedicineName] [varchar](150) NULL,
	[MedicineQuantity] [int] NULL,
	[MedicineUnits] [decimal](18, 2) NULL,
	[MedicineDosQuan] [decimal](18, 2) NULL,
	[MedicineDosUnits] [decimal](18, 2) NULL,
	[MedicineExpDate] [date] NULL,
	[idSupplier] [int] NULL,
	[MedicineUnitsType] [varchar](20) NULL,
	[MedicineQuantityPres] [varchar](20) NULL,
 CONSTRAINT [PK_Medicine] PRIMARY KEY CLUSTERED 
(
	[id_Medicine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicineCompound]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicineCompound](
	[idMedicine] [int] NULL,
	[idCompound] [int] NULL,
	[CompoundQuantity_Units] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[id_patient] [int] IDENTITY(1,1) NOT NULL,
	[patientName] [varchar](150) NULL,
	[patientLastName] [varchar](150) NULL,
	[patientEmail] [varchar](150) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[id_patient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id_Product] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](150) NULL,
	[ProductQuantity] [int] NULL,
	[ProductExpDate] [date] NULL,
	[ProductUnits] [decimal](18, 2) NULL,
	[idSupplier] [int] NULL,
	[ProductUnitType] [varchar](20) NULL,
	[ProductQuantityPres] [varchar](20) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservationT]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservationT](
	[id_Reservation] [int] IDENTITY(1,1) NOT NULL,
	[idDoctor] [int] NULL,
	[idPatient] [int] NULL,
	[ResStartTime] [time](7) NULL,
	[ResFinishTime] [time](7) NULL,
	[ResDate] [date] NULL,
 CONSTRAINT [PK_ReservationT] PRIMARY KEY CLUSTERED 
(
	[id_Reservation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 24/3/2020 21:48:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[id_Supplier] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [varchar](150) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[id_Supplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Material]  WITH CHECK ADD  CONSTRAINT [FK_Material_Supplier] FOREIGN KEY([idSupplier])
REFERENCES [dbo].[Supplier] ([id_Supplier])
GO
ALTER TABLE [dbo].[Material] CHECK CONSTRAINT [FK_Material_Supplier]
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_Supplier] FOREIGN KEY([idSupplier])
REFERENCES [dbo].[Supplier] ([id_Supplier])
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_Supplier]
GO
ALTER TABLE [dbo].[MedicineCompound]  WITH CHECK ADD  CONSTRAINT [FK_MedicineCompound_Compound] FOREIGN KEY([idCompound])
REFERENCES [dbo].[Compound] ([id_Compound])
GO
ALTER TABLE [dbo].[MedicineCompound] CHECK CONSTRAINT [FK_MedicineCompound_Compound]
GO
ALTER TABLE [dbo].[MedicineCompound]  WITH CHECK ADD  CONSTRAINT [FK_MedicineCompound_Medicine] FOREIGN KEY([idMedicine])
REFERENCES [dbo].[Medicine] ([id_Medicine])
GO
ALTER TABLE [dbo].[MedicineCompound] CHECK CONSTRAINT [FK_MedicineCompound_Medicine]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([idSupplier])
REFERENCES [dbo].[Supplier] ([id_Supplier])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
ALTER TABLE [dbo].[ReservationT]  WITH CHECK ADD  CONSTRAINT [FK_ReservationT_Doctor] FOREIGN KEY([idDoctor])
REFERENCES [dbo].[Doctor] ([id_Doctor])
GO
ALTER TABLE [dbo].[ReservationT] CHECK CONSTRAINT [FK_ReservationT_Doctor]
GO
ALTER TABLE [dbo].[ReservationT]  WITH CHECK ADD  CONSTRAINT [FK_ReservationT_Patient] FOREIGN KEY([idPatient])
REFERENCES [dbo].[Patient] ([id_patient])
GO
ALTER TABLE [dbo].[ReservationT] CHECK CONSTRAINT [FK_ReservationT_Patient]
GO
USE [master]
GO
ALTER DATABASE [AnalisisResidencia] SET  READ_WRITE 
GO
