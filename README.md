# GetFood
## Esse projeto que foi desenvolvido para o 3º período do curso de ADS consiste  na criação de um app desktop para Windows, rodando com banco de dados local, com as seguintes funcionalidades:
<!--ts-->
  * Login
  * Cadastro
  * Controle de estoque
    * Inserir Limento
    * Deletar Alimento
    * Atualizar Alimento
    * Consultar Alimentos
<!--ts-->
# Como Usar
## Como o app foi desenvolvido com um banco de dados Sql local é preciso fazer a configuração do Sql e do Visual Studio manualmente.
### Antes de tudo é presciso dar um git clone no projeto depois basta abrir o Sql management studio e fazer a criação do banco com os seguintes comandos:

```sql

CREATE DATABASE [GetFood_DatBase]
USE [GetFood_DatBase]
GO


CREATE TABLE [dbo].[tabela_Usuarios](
	[idUsuarios] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[senha] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tabela_Usuarios] PRIMARY KEY CLUSTERED 


CREATE TABLE [dbo].[tabela_Alimentos](
	[id_Alimentos] [int] NOT NULL,
	[alimento] [varchar](50) NULL,
	[quantidade] [varchar](50) NULL,
	[dataF] [datetime] NULL,
	[dataV] [datetime] NULL,
 CONSTRAINT [PK_tabela_Alimentos] PRIMARY KEY CLUSTERED 

CREATE PROC [dbo].[Atualizar_Alimento]
@id_Alimentos int,
@alimento varchar(50),
@quantidade varchar(50),
@dataF datetime,
@dataV datetime
as
begin
UPDATE tabela_Alimentos SET alimento =@alimento, quantidade =@quantidade, dataF =@dataF, dataV =@dataV WHERE id_Alimentos =@id_Alimentos
end

CREATE PROC [dbo].[Consultar_Alimento]
@id_Alimentos int
as
begin
SELECT * FROM tabela_Alimentos WHERE id_Alimentos =@id_Alimentos
end

CREATE PROC [dbo].[Deletar_Alimento]
@id_Alimentos int
as
begin
DELETE tabela_Alimentos WHERE id_Alimentos =@id_Alimentos
end

CREATE PROC [dbo].[Inserir_Alimento]
@id_Alimentos int,
@alimento varchar(50),
@quantidade varchar(50),
@dataF datetime,
@dataV datetime
as
begin
INSERT INTO tabela_Alimentos (id_Alimentos,alimento,quantidade,dataF,dataV)
VALUES (@id_Alimentos,@alimento,@quantidade,@dataF,@dataV)
end

CREATE PROC [dbo].[Listar_Alimento]
as
begin
SELECT * FROM tabela_Alimentos
end
```
### Com o banco já criado basta conectar o visual Studio com o banco Sql e trocar a string de conexão que está no inicio do codigo de cada formulário e pronto o projeto já deve está funcionando localmente na sua máquina  
