

use master
GO


drop database LojaInformatica
GO

create database LojaInformatica
GO

use lojainformatica
GO

--drop table estado
--drop table cliente

/*Cria Tabela Categoria*/
CREATE TABLE [dbo].[Categoria]
(   id [int] NOT NULL primary key,--id da categoria
	descricao [varchar](50) NULL);
GO

/*Cria tabela região*/

CREATE TABLE [dbo].[Regiao](
	id [int] NOT NULL primary key,
	Sigla [varchar] (2) not null,
	Descricao [varchar] (12)
);
GO

/*Cria tabela Marca #*/
CREATE TABLE [dbo].[Marca](
	id [int] NOT NULL primary key,
	marca [varchar] (30) not null
);
GO


/*Tabela estados*/
CREATE TABLE [dbo].[Estado](
   Id [int] NOT NULL primary key,	
   Estado [varchar] (2) NOT NULL,
   Descricao [varchar] (20),
   id_regiao [int]  foreign key references regiao (id)
);
GO

/*Cria Tabela Cliente #*/
CREATE TABLE [dbo].[Cliente](
	[id] [int] NOT NULL primary key,
	[nome] [varchar](100) NOT NULL,
	[email] [varchar] (60) NOT NULL,
	[endereco] [varchar] (100) NOT NULL,
	[id_estado] [int] NOT NULL foreign key references estado (id),
	[CPF] [varchar] (11) NOT NULL,
	[bonus] [decimal] (10,2),
	[senha] [varchar] (8) NOT NULL
	);
GO

/*Cria Tabela Produto #*/
CREATE TABLE [dbo].[Produto](
	[id] [int] NOT NULL primary key,
	[imagem] [varbinary] (max),
	[descricao] [varchar] (30) NOT NULL,
	[id_categoria] [int] NOT NULL foreign key references categoria (id),
	[preco] [decimal] (10,2) NOT NULL,
	[id_marca] [int] NOT NULL foreign key references marca (id),
	[qtd_estoque] [int] NOT NULL,	
	);
GO

/*Cria a tabela Venda*/
CREATE TABLE [dbo].[Venda](
	[id] [int] identity(1,1) NOT NULL primary key,
	[data_venda] [smalldatetime] NOT NULL ,
	[id_cliente] [int] NOT NULL foreign key references cliente (id),
	[data_entrega] [smalldatetime] NOT NULL ,
	[id_estadoEntrega] [int] NOT NULL foreign key references estado (id)
);
GO


/*Cria a tabela ItensVenda*/
CREATE TABLE [dbo].[ItensVenda](
	[id] [int] identity(1,1) NOT NULL,
	[id_venda] [int] NOT NULL,
	[id_produto] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	[preco] [decimal] (10,2) NOT NULL,
	constraint [PK_ItensVenda] primary key (id),
	FOREIGN KEY ( id_venda ) REFERENCES [Venda] ( Id ),
	FOREIGN KEY ( id_produto ) REFERENCES [Produto] ( Id ) 
);
GO

/*
alter table cliente 
alter column email varchar(60) not null;
*/












