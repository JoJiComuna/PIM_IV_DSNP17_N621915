
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
User_Login varChar(100) unique not null,
Senha varchar (10) not null,
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
Hs_Login varChar(100) unique not null,
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


SELECt*
FROM TipoQuarto
INNER JOIN  Quartos
ON Quartos.Nr_Quarto = 100;

SELECT Nm_Hospede
FROM Hospedes as s
WHERE s.ID_Hospede IN (SELECT DISTINCT c.ID_Hospede
                       FROM Hospedagens as C)
;

SELECT Nr_Hospedagem, ID_Hospede FROM [dbo].[Hospedagens] WHERE Nr_Hospedagem = 10001
SELECt Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut, Quartos.Nr_Quarto,
                 TipoQuarto.Nm_TipoQuarto, Qtd_Adultos, Qtd_Criancas, Hospedagens.Ds_Status FROM Quartos 
                INNER JOIN TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto INNER JOIN Hospedagens 
                on Hospedagens.Nr_Quarto = quartos.Nr_Quarto INNER JOIN Hospedes on Hospedagens.ID_Hospede = Hospedes.ID_Hospede
                 WHERE Nr_Hospedagem = 10001 or Nm_Hospede like ''

Select ID_Hospede, Nm_Hospede, Nr_Documento, Nr_Telefone, Email from [dbo].[Hospedes] where Nr_Documento = 44437805862 or Nm_Hospede like '%kamylla%'		
Select ID_Hospede, Nm_Hospede, Nr_Documento from [dbo].[Hospedes] where Nm_Hospede like '%kamylla%' or Nr_Documento = 42139805819 


SELECT *FROM [dbo].[Quartos] INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto where TipoQuarto.Nm_TipoQuarto like'%Luxo%' ;

select  * from Quartos 
inner join TipoQuarto
on Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto
where Nm_TipoQuarto ='Suite Luxo';-- @parametro

select  Quartos.Nr_Quarto,Quartos.Nm_Quarto, Max_Adultos, Max_Criancas, Pr_ExtraAdulto, Pr_ExtraCrianca Pr_Quarto from Quartos inner join TipoQuarto on Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto where Nm_TipoQuarto ='Suite Luxo';-- @parametro


select * from Endereco 
where ID_Hospede =10;


select avg (Vl_TotalaPagar) from Pagamentos;

select * from Hospedes;
select * from Hospedagens;



select * from TipoQuarto;
select * from Quartos;
select * from Pagamentos;

SELECT *FROM [dbo].[Quartos]  INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto
SELECT * FROM [dbo].[Quartos] INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto where Quartos.ID_TipoQuarto = 3 
SELECt*
FROM Quartos 
INNER JOIN  TipoQuarto
ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto ;

SELECt  Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut,Nr_Quarto,Qtd_Adultos, Qtd_Criancas
FROM Hospedes
INNER JOIN  Hospedagens
ON Hospedes.ID_Hospede = Hospedagens.ID_Hospede ;

select * from Hospedes where Nm_Hospede like 'nothing';



SELECT *FROM [dbo].[Hospedes] 
INNER JOIN  Endereco
on Hospedes.ID_Hospede = Endereco.ID_Hospede


Insert Into Usuario (Nm_Usuario, Nr_Documento, Email, Ds_Status ) Values ('Matheus Gustavo', 45046047080, 'matheus@gmail.com',1);


--select * from LoginUsuario where User_Login ='admin' and Senha ='admin'

insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) Values ('Maria dos Santos', 40043015088, 5515998187663,'mariasantos@hotmail.com',1);
insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) Values ('Antonio Silva', 40142805017, 5515989042535,'antonio@hotmail.com',1);
insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) Values ('Claudia Maria ', 45046598761, 5515987352975,'claudiam@hotmail.com',1);
insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status) Values ('Arnaldo Silva', 42139805819, 5515985047529,'arnaldos@hotmail.com',1);
insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) Values ('Romario Lima', 45539805268, 5515991546654,'romariol@hotmail.com',1);
insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) Values ('Kamylla Ribeiro', 44437805862, 5515991346546,'kamylla@hotmail.com',1);
insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) Values ('Luciano Silva', 45378157182, 5515991146382,'lucianol@hotmail.com',1);
insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) Values ('Luiza Padilha', 44437805962, 5515991246954,'luiza@hotmail.com',1);

insert into Hospedes (Nm_Hospede, Nr_Documento, Nr_Telefone, Email, Ds_Status ) Values ('Rubens Silva', 44437805872, 5515997346371,'rubenss@hotmail.com',0) ;
--Insert into Endereco (Ds_Estado, ID_Hospede,Nm_Bairro, Nm_Cidade, Nm_Cidade, Nm_Rua, Nr_Endereco) Values ();
																			 
--------------------------------------------------------------------------------------------
select* from Hospedes
--------------------------------------------------------------------------------------------
select* from Endereco
insert into TipoQuarto ( Nm_TipoQuarto, Max_Adultos, Max_Criancas, Pr_Quarto ,Pr_ExtraAdulto, Pr_ExtraCrianca,Ds_TipoQuarto  ) Values ('Suite Luxo', 2 , 2, 250.00 , 40.00, 20.00, '');
insert into TipoQuarto ( Nm_TipoQuarto, Max_Adultos, Max_Criancas, Pr_Quarto ,Pr_ExtraAdulto, Pr_ExtraCrianca,Ds_TipoQuarto  ) Values ('Suite Master', 3 , 2, 300.00 , 50.00, 25.00, '');
insert into TipoQuarto ( Nm_TipoQuarto, Max_Adultos, Max_Criancas, Pr_Quarto ,Pr_ExtraAdulto, Pr_ExtraCrianca,Ds_TipoQuarto  ) Values ('Suite Premmium', 5 , 2, 370.00 , 60.00, 30.00, '');
insert into TipoQuarto ( Nm_TipoQuarto, Max_Adultos, Max_Criancas, Pr_Quarto ,Pr_ExtraAdulto, Pr_ExtraCrianca,Ds_TipoQuarto  ) Values ('Quarto Comum', 2 , 2, 200.00 , 30.00, 15.00, '');

insert into Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Status) Values (1 ,'Quarto 101',1);
insert into Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Status) Values (2 ,'Quarto 102',1);
insert into Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Status) Values (3 ,'Quarto 103',1);
insert into Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Status) Values (4 ,'Quarto 104',1);
insert into Quartos (ID_TipoQuarto, Nm_Quarto, Ds_Status) Values (4 ,'Quarto 105',1);




insert into Hospedagens(ID_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto,  Qtd_Adultos, Qtd_Criancas, Ds_Status ) Values (3,'31-07-2021','1-08-2021',101 ,1 ,1, 'Check-out' );
insert into Pagamentos (Nr_Hospedagem, Vl_TotalaPagar, Ds_Status ) Values (SCOPE_IDENTITY(),600.00 ,'Pendente');
insert into Hospedagens(ID_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto,  Qtd_Adultos, Qtd_Criancas, Ds_Status ) Values (5,'31-07-2021','1-08-2021',102 ,4 ,2, 'Check-out');
insert into Pagamentos (Nr_Hospedagem, Vl_TotalaPagar, Ds_Status ) Values (SCOPE_IDENTITY(),350.00 ,'Pendente');
insert into Hospedagens(ID_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto,  Qtd_Adultos, Qtd_Criancas, Ds_Status ) Values (6,'31-07-2021','1-08-2021',103 ,2 ,0, 'Check-out');
insert into Pagamentos (Nr_Hospedagem, Vl_TotalaPagar, Ds_Status ) Values (SCOPE_IDENTITY(),500.00 ,'Pendente');

select * from Hospedagens

select * from Hospedes
inner join Hospedagens
on Hospedagens.ID_Hospede = Hospedes.ID_Hospede


select Dt_CheckIn, Dt_CheckOut, Nr_Quarto, Ds_Status  from Hospedagens
WHERE Dt_CheckIn = '2021-09-01'


select * from Hospedagens where Nr_Quarto = 102 and Dt_CheckIn != '27/09/2021' and Dt_CheckOut != '31/07/2021';

SELECT Quartos.Nr_Quarto,Quartos.Nm_Quarto, Max_Adultos, Max_Criancas, 
Pr_ExtraAdulto, Pr_ExtraCrianca,Pr_Quarto from Quartos
inner join TipoQuarto on TipoQuarto.ID_TipoQuarto = Quartos.ID_TipoQuarto
join Hospedagens on Hospedagens.Nr_Quarto != Quartos.Nr_Quarto 
where Nm_TipoQuarto like'Suite Luxo'







Select SCOPE_IDENTITY ();

 select IDENT_CURRENT ('Pagamentos') ;


select * from pagamentos
select * from Hospedagens
UPADATE Pagamentos SET Vl_TotalaPagar = '', WHERE Nr_Hospedagem = '';




SELECT Hospedes.ID_Hospede, Nm_Hospede, Nr_Documento, Nr_Telefone , Email, Ds_Estado, Nm_Cidade, Nm_Bairro, Nm_Rua, Nr_Endereco FROM [dbo].[Hospedes] 
LEFT JOIN [dbo].Endereco
on Endereco.ID_Hospede = Hospedes.ID_Hospede
where Nr_Documento = '41140847899' or Nm_Hospede like '%Matheus'





SELECT * FROM [dbo].[Quartos] INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto where Quartos.ID_TipoQuarto = 3

SELECT *FROM [dbo].[Quartos] INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto where Quartos.Nr_Quarto = 103

SELECT Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut, Hospedagens.Nr_Quarto, Qtd_Adultos, Qtd_Criancas, Pr_ExtraAdulto, Pr_ExtraCrianca, Pr_Quarto  FROM  Hospedes INNER JOIN Hospedagens
on Hospedagens.ID_Hospede = Hospedes.ID_Hospede
INNER JOIN Quartos
on Quartos.Nr_Quarto = Hospedagens.Nr_Quarto
INNER JOIN TipoQuarto
on TipoQuarto.ID_TipoQuarto = Quartos.ID_TipoQuarto
where Hospedagens.Ds_Status = 'Check-out'



--SELECIONAR HOSPEDAGENS E TROCAR IDHOSPEDE POR NMHOSPEDE PARA EXIBIÇÃO, INCLUIR NMTIPOQUARTO EM HOSPEDAGENS  SOMENTE PARA EXIBIÇÃO
SELECt Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut, Quartos.Nr_Quarto,TipoQuarto.Nm_TipoQuarto, Qtd_Adultos, Qtd_Criancas, Hospedagens.Ds_Status FROM Quartos INNER JOIN  TipoQuarto
ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto 
INNER JOIN Hospedagens 
on Hospedagens.Nr_Quarto = quartos.Nr_Quarto
INNER JOIN Hospedes 
on Hospedagens.ID_Hospede = Hospedes.ID_Hospede
where Nr_Hospedagem = 10000

-- SOMAR VALOR A PAGAR DE PAGAMENTO COM BASE NA HOSPEDAGEM


select  sum ((Qtd_Adultos * Pr_ExtraAdulto)+ (Qtd_Criancas * Pr_ExtraCrianca)+ Pr_Quarto) as total
FROM Hospedagens
INNER JOIN  Quartos
ON Quartos.Nr_Quarto = Hospedagens.Nr_Quarto
INNER JOIN TipoQuarto
on Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto
where Nr_Hospedagem = 10000
;


SELECt Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto, Qtd_Adultos, Qtd_Criancas FROM Hospedes INNER JOIN  Hospedagens ON Hospedes.ID_Hospede = Hospedagens.ID_Hospede;





select * from pagamentos where Ds_Status ='Pago'; 


SELECT *FROM [dbo].[Quartos] 
INNER JOIN  TipoQuarto 
ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto 


SELECT  Nm_TipoQuarto FROM Quartos INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto GROUP BY Quartos.ID_TipoQuarto, Nm_TipoQuarto




SELECT *FROM [dbo].[Quartos]  INNER JOIN  TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto



SELECT TOP (1000) [ID_Hospede]
      ,[Nm_Hospede]
      ,[Nr_Documento]
      ,[Nr_Telefone]
      ,[Email]
  FROM [BDHidraHotel].[dbo].[Hospedes]
 
/*
update Hospedes
set Nr_Documento = 45378157128
Where ID_Hospede  = 4537815712;
*/
SELECT  Nr_Telefone FROM dbo.Hospedes
where ID_Hospede =1;

 SELECt Nr_Hospedagem, Quartos.Nr_Quarto,TipoQuarto.Nm_TipoQuarto
FROM Quartos 
INNER JOIN TipoQuarto 
ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto 
INNER JOIN Hospedagens 
on Hospedagens.Nr_Quarto = quartos.Nr_Quarto 

 SELECt TipoQuarto.Nm_TipoQuarto ,Pr_ExtraAdulto, Pr_ExtraCrianca, Pr_Quarto FROM Quartos INNER JOIN TipoQuarto ON Quartos.ID_TipoQuarto = TipoQuarto.ID_TipoQuarto where Nr_Quarto = 101

 select * from Hospedes


SELECt Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut, Nr_Quarto, Qtd_Adultos, Qtd_Criancas FROM Hospedes INNER JOIN  Hospedagens ON Hospedes.ID_Hospede = Hospedagens.ID_Hospede;

SELECt Nr_Hospedagem, Nm_Hospede FROM Hospedes INNER JOIN  Hospedagens ON Hospedes.ID_Hospede = Hospedagens.ID_Hospede

SELECt Nr_Hospedagem, Nm_Hospede FROM Hospedes INNER JOIN  Hospedagens ON Hospedes.ID_Hospede = Hospedagens.ID_Hospede where Hospedagens.Ds_Status != 'Check-out'

SELECT Pagamentos.Nr_Hospedagem, Nm_Hospede, Dt_CheckIn, Dt_CheckOut, Hospedagens.Nr_Quarto, Qtd_Adultos, Qtd_Criancas, Pr_ExtraAdulto, Pr_ExtraCrianca, Pr_Quarto, Pagamentos.Ds_Status  FROM  Hospedes INNER JOIN Hospedagens on Hospedagens.ID_Hospede = Hospedes.ID_Hospede
INNER JOIN Quartos
on Quartos.Nr_Quarto = Hospedagens.Nr_Quarto
INNER JOIN TipoQuarto
on TipoQuarto.ID_TipoQuarto = Quartos.ID_TipoQuarto
INNER JOIN Pagamentos
on Pagamentos.Nr_Hospedagem = Hospedagens.Nr_Hospedagem
where Pagamentos.Ds_Status != 'Pago'
select * from Pagamentos
update Pagamentos set Vl_TotalaPagar = '460.00' where  Nr_Pagamento = 11002

select * from Hospedagens
select * from Pagamentos
select * from Hospedes
select * from Endereco	
insert into Endereco (ID_Hospede, Ds_Estado, Nm_Cidade, Nm_Bairro, Nm_Rua, Nr_Endereco) Values (1, 'SP' ,'Sorocaba', 'Wanel Ville', 'Severo Pereira', '250' )

select * from Hospedes
Inner Join Endereco
on Endereco.ID_Hospede = Hospedes.ID_Hospede