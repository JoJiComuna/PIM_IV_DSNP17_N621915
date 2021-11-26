CREATE DATABASE [Hotelaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotelaria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Hotelaria.mdf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotelaria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Hotelaria_log.ldf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hotelaria] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [Hotelaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotelaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotelaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotelaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotelaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotelaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotelaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotelaria] SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF)
GO
ALTER DATABASE [Hotelaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotelaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotelaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotelaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotelaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotelaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotelaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotelaria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hotelaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotelaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotelaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotelaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotelaria] SET  READ_WRITE 
GO
ALTER DATABASE [Hotelaria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hotelaria] SET  MULTI_USER 
GO
ALTER DATABASE [Hotelaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotelaria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotelaria] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Hotelaria]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = On;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = Primary;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = Off;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = Primary;
GO
USE [Hotelaria]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [Hotelaria] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO


Create Table ChaveDeSeguranca (
ID_ChavedeSeguranca int identity (1,1),
Nr_ChavedeSeguranca int unique ,
Ds_Status numeric (1),
Primary Key (ID_ChavedeSeguranca),
);

Create Table Usuario (
ID_Usuario int identity (1,1),
Nm_Usuario Varchar (200) Not Null,
Email varChar(100) Unique,
Nr_Documento numeric(11) Unique not null,
Ds_Status numeric (1) ,
Primary Key (ID_Usuario),
);

Create Table LoginUsuario (
ID_LoginUsuario int identity (1,1),
ID_Usuario int Unique,
User_Login varChar(20) unique not null,
Senha varchar (20) not null,
Tipo_Usuario varchar (20)not null,
Ds_Status numeric (1),
Primary Key (ID_LoginUsuario),

Foreign key (ID_Usuario) 
References  Usuario (ID_Usuario)
);

Create Table Hospedes(
ID_Hospede int identity (1,1),
Nm_Hospede Varchar (200) Not Null,
Nr_Documento varchar(12) Unique not null,
Nr_Telefone varchar(13),
Email VarChar(100) Unique Not null,
Ds_Status numeric (1),

Primary Key (ID_Hospede),
);

Create Table Endereco (
ID_Endereco int identity (1,1),
ID_Hospede int Unique Not Null,
Ds_Estado varchar (2) Not Null,
Nm_Cidade varchar (100) Not Null,
Nm_Bairro varchar(100) Not Null,
Nm_Rua varchar (150) Not Null, 
Nr_Endereco int Not Null,
Primary Key (ID_Endereco),
Foreign key (ID_Hospede) 
References  Hospedes (ID_Hospede)
);

Create Table LoginHospede (
ID_LoginHospede int identity (1,1),
ID_Hospede int unique not null ,
Ds_Login varChar(100) unique not null,
Senha varchar (10) not null,
Ds_Status numeric (1) ,
Primary Key (ID_LoginHospede),
Foreign key (ID_Hospede) 
References  Hospedes (ID_Hospede)
);

Create Table TipoQuarto(
ID_TipoQuarto int identity (1,1),
Nm_TipoQuarto Varchar(50),
Max_Adultos int Not Null,
Max_Criancas int Not Null,
Pr_Quarto Numeric (12,2) Not Null ,
Pr_ExtraAdulto Numeric (12,2) Not Null,
Pr_ExtraCrianca Numeric (12,2)Not Null ,
Ds_TipoQuarto Varchar (300) ,
Primary Key (ID_TipoQuarto),
);

Create Table Quartos(
Nr_Quarto int identity (101,1),
ID_TipoQuarto int not null,
Nm_Quarto Varchar (200) Not Null,
Ds_Info Varchar (300) Not Null,
Ds_Status numeric(1) ,
Primary Key (Nr_Quarto),

Foreign key (ID_TipoQuarto) 
References  TipoQuarto (ID_TipoQuarto)
);

Create Table ControledePatrimonio (
ID_Patrimonio int identity (101,1),
Nr_Quarto int not null ,
Nm_Patrimonio Varchar (100) Not Null,
Ds_Status varchar(20),
Primary Key (ID_Patrimonio),
Foreign key (Nr_Quarto) 
References  Quartos (Nr_Quarto)
);

Create Table Hospedagens(
Nr_Hospedagem int identity (10000,1),
ID_Hospede int,
Dt_CheckIn date default getdate(),
Dt_CheckOut date,
Nr_Quarto int,
Qtd_Adultos int,
Qtd_Criancas int,
Ds_Status varchar (20),

CONSTRAINT FK_Hospedes FOREIGN KEY (ID_Hospede) REFERENCES Hospedes (ID_Hospede),
CONSTRAINT FK_Quartos FOREIGN KEY (Nr_Quarto) REFERENCES Quartos (Nr_Quarto),
Primary Key (Nr_Hospedagem),
);

Create Table Pagamentos(
Nr_Pagamento int identity (10000,1),
Nr_Hospedagem int unique not null ,
Dt_Pagamento  date null ,
Tipo_Pagamento Varchar (10) ,
Vl_TotalaPagar Numeric (12,2) ,
Ds_Status varchar(20),

Primary Key (Nr_Pagamento),

Foreign key (Nr_Hospedagem) 
References Hospedagens (Nr_Hospedagem)
);

INSERT INTO Usuario (Nm_Usuario, Nr_Documento, Email, Ds_Status ) VALUES ('System', 45046047080, 'System',1);
INSERT INTO LoginUsuario (ID_Usuario, Tipo_Usuario,User_Login, Senha, Ds_Status) VALUES (1, 'ADM','admin', 'admin',1 );

