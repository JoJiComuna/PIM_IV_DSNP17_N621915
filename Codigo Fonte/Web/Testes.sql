
Drop Table if Exists ChaveDeSeguranca;
Drop Table if Exists LoginUsuario;
Drop Table if Exists Usuario;
Drop Table if Exists Pagamentos;
Drop Table if Exists Hospedagens;
Drop Table if Exists LoginHospede;
Drop Table if Exists Endereco;
Drop Table if Exists Hospedes;
Drop Table if Exists ControledePatrimonio;
Drop Table if Exists Quartos;
Drop Table if Exists TipoQuarto;
Go


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

-- Insert Hospedes
INSERT INTO Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) VALUES ('Maria dos Santos', 40043015088, 5515998187663,'mariasantos@hotmail.com',1);
INSERT INTO Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) VALUES ('Antonio Silva', 40142805017, 5515989042535,'antonio@hotmail.com',1);
--exemplo parametros 
--insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) Values (@nome, @Documento, @Telefone,@Email,@DsStatus);

--Select
SELECT* FROM Hospedes;

--Insert Enderecos
INSERT INTO Endereco (ID_Hospede, Ds_Estado, Nm_Cidade, Nm_Bairro, Nm_Rua, Nr_Endereco) VALUES (1, 'SP', 'Sorocaba', 'Julio de Mesquita', 'Rua dos Alpes', 1500);
INSERT INTO Endereco (ID_Hospede, Ds_Estado, Nm_Cidade, Nm_Bairro, Nm_Rua, Nr_Endereco) VALUES (2, 'RJ', 'Rio das Ostras', 'Realengo', 'Paulo Gustavo', 850);


--Select
SELECT* FROM Endereco;

--Select Composto

SELECT Hospedes.ID_Hospede, Nm_Hospede, Nr_Documento, Nr_Telefone , Email, Ds_Estado, Nm_Cidade, Nm_Bairro, Nm_Rua, Nr_Endereco FROM [dbo].[Hospedes] 
LEFT JOIN [dbo].Endereco
on Endereco.ID_Hospede = Hospedes.ID_Hospede;
--where Nr_Documento = '41140847899' or Nm_Hospede like '%Matheus'


--Procurar Cadastro
Select ID_Hospede, Nm_Hospede, Nr_Documento from [dbo].[Hospedes] where Nm_Hospede like 'nome' or Nr_Documento = 'Documento'-- sem aspas;

INSERT INTO LoginHospede (ID_Hospede, Ds_Login, Senha, Ds_Status) VALUES (1, 'maria123', '123456',1);
Select * from LoginHospede;

--Insert Tipo Quartos
INSERT INTO TipoQuarto ( Nm_TipoQuarto, Max_Adultos, Max_Criancas, Pr_Quarto ,Pr_ExtraAdulto, Pr_ExtraCrianca,Ds_TipoQuarto  ) VALUES ('Suite Luxo', 2 , 2, 250.00 , 40.00, 20.00, '');
INSERT INTO TipoQuarto ( Nm_TipoQuarto, Max_Adultos, Max_Criancas, Pr_Quarto ,Pr_ExtraAdulto, Pr_ExtraCrianca,Ds_TipoQuarto  ) VALUES ('Suite Master', 3 , 2, 300.00 , 50.00, 25.00, '');
INSERT INTO TipoQuarto ( Nm_TipoQuarto, Max_Adultos, Max_Criancas, Pr_Quarto ,Pr_ExtraAdulto, Pr_ExtraCrianca,Ds_TipoQuarto  ) VALUES ('Suite Premmium', 5 , 2, 370.00 , 60.00, 30.00, '');
INSERT INTO TipoQuarto ( Nm_TipoQuarto, Max_Adultos, Max_Criancas, Pr_Quarto ,Pr_ExtraAdulto, Pr_ExtraCrianca,Ds_TipoQuarto  ) VALUES ('Quarto Comum', 2 , 2, 200.00 , 30.00, 15.00, '');

--Select
SELECT * FROM TipoQuarto;

--insert Quartos

INSERT INTO Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Info, Ds_Status) VALUES (1 ,'Quarto 101','Quarto Espaçoso e Luxuoso com vista Incrível com mobilia moderna',1);
INSERT INTO Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Info,Ds_Status) VALUES (2 ,'Quarto 102','Quarto, Quarto com mobilia vintage para você se sentir em casa',1);
INSERT INTO Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Info,Ds_Status) VALUES (3 ,'Quarto 103','Nossa maior suíte, perfeito para quem busca conforto e qualidade',1);
INSERT INTO Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Info,Ds_Status) VALUES (4 ,'Quarto 104','Quarto aconchegante , perfeito para quem deseja passar pouco tempo',1);
INSERT INTO Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Info,Ds_Status) VALUES (4 ,'Quarto 105','Quarto aconchegante , perfeito para quem deseja passar pouco tempo',1);

--Select
SELECT * FROM Quartos;

--Selecionar informações do quarto 
SELECT  Quartos.Nr_Quarto,Quartos.Nm_Quarto, Max_Adultos, Max_Criancas, Pr_ExtraAdulto, Pr_ExtraCrianca, Pr_Quarto FROM Quartos
INNER JOIN TipoQuarto on Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto 
WHERE Nm_TipoQuarto ='Suite Luxo';-- @parametro

--Insert Hospedagens e Pagamentos
--Scope_Identity pega o ultimo ID inserido e uso para criar um pagamento com o ultimo ID no caso Nr Hospedagem e Nr Pagamento sempre vão ter o msm Numero

insert into Hospedagens(ID_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto,  Qtd_Adultos, Qtd_Criancas, Ds_Status ) Values (1,'31-07-2021','1-08-2021',101 ,1 ,1, 'Check-out' );
insert into Pagamentos (Nr_Hospedagem, Vl_TotalaPagar, Ds_Status ) Values (SCOPE_IDENTITY(),600.00 ,'Pendente');
insert into Hospedagens(ID_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto,  Qtd_Adultos, Qtd_Criancas, Ds_Status ) Values (1,'31-07-2021','1-08-2021',102 ,4 ,2, 'Check-out');
insert into Pagamentos (Nr_Hospedagem, Vl_TotalaPagar, Ds_Status ) Values (SCOPE_IDENTITY(),350.00 ,'Pendente');
insert into Hospedagens(ID_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto,  Qtd_Adultos, Qtd_Criancas, Ds_Status ) Values (2,'31-07-2021','1-08-2021',103 ,2 ,0, 'Check-out');
insert into Pagamentos (Nr_Hospedagem, Vl_TotalaPagar, Ds_Status ) Values (SCOPE_IDENTITY(),500.00 ,'Pendente');

--Select Hospedagens Inner JOIN no Hospedes para trocar ID Hospede por nome na exibição

SELECt  Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut,Nr_Quarto,Qtd_Adultos, Qtd_Criancas
FROM Hospedes
INNER JOIN  Hospedagens
ON Hospedes.ID_Hospede = Hospedagens.ID_Hospede ;
--where Nome Hospede like ='' ou outr condição

--Select Normal
SELECT * FROM Hospedagens

--Select Pagamentos
SELECT * FROM Pagamentos;

--UPDATE Pagamentos SET Vl_TotalaPagar = '' WHERE Nr_Hospedagem = '';

--Verificar se a data esta sendo usada
SELECT Dt_CheckIn, Dt_CheckOut, Nr_Quarto, Ds_Status  from Hospedagens WHERE Dt_CheckIn = '2021-09-01';

--Verificar Login
SELECT * FROM LoginUsuario WHERE User_Login ='admin' and Senha ='admin'

--Cad Usuario
INSERT INTO Usuario (Nm_Usuario, Nr_Documento, Email, Ds_Status ) VALUES ('Matheus Gustavo', 45046047080, 'matheus@gmail.com',1);

--Select
SELECT * FROM Usuario;

--Cad Login Usuario
INSERT INTO LoginUsuario (ID_Usuario, Tipo_Usuario,User_Login, Senha, Ds_Status) VALUES (1, 'ADM','admin', 'admin',1 );

--Select
Select * From LoginUsuario

--Verificar Login


SELECT User_Login, Senha FROM LoginUsuario WHere User_Login = 'admin' and Senha = 'admin';



Select * from Hospedes
Inner join Endereco
on Endereco.ID_Hospede = Hospedes.ID_Hospede
Inner JOin LoginHospede
On LoginHospede.ID_Hospede = Hospedes.ID_Hospede

SELECT Hospedagens.Nr_Hospedagem as 'Nº Hospedagem', Dt_CheckIn as 'Check-In',
Dt_CheckOut as 'Check-Out', Nr_Quarto as 'Nº Quarto', 
Qtd_Adultos as 'Adultos Extras', Qtd_Criancas as 'Crianças Extras' ,
Hospedagens.Ds_Status as 'Situação', Pagamentos.Vl_TotalaPagar as 'Valor', 
Pagamentos.Ds_Status as 'Status'
FROM Hospedagens
INNER JOIN Pagamentos 
ON Pagamentos.Nr_Hospedagem = Hospedagens.Nr_Hospedagem
WHERE ID_Hospede = 1;

Select * from Hospedagens
Select * from LoginHospede;
UPDATE LoginHospede SET Senha = '123'
WHERE ID_Hospede = 1;
UPDATE Pagamentos SET Vl_TotalaPagar = '' WHERE Nr_Hospedagem = ''

select * from hospedes

