-----------------------------------------------------------------------------------------------------------
/*PROCEDURES*/

/*Procedures Genericas*/

USE LojaInformatica
GO
--1-Procedure para Deletar registros
create procedure spDelete
				(
					@id int ,
					@tabela varchar(max)
				)
				as
				begin
					declare @sql varchar(max);
					set @sql = ' delete ' + @tabela +
					' where id = ' + cast(@id as varchar(max))
					exec(@sql)
				end
GO
------------------------------------
--2-Procedure para Consultar registros
create procedure spConsulta
(
@id int ,
@tabela varchar(max)
)
as
begin
declare @sql varchar(max);
set @sql = 'select * from ' + @tabela +
' where id = ' + cast(@id as varchar(max))
exec(@sql)
end
GO
--------------------------------
--3-Procedure para retornar uma lista com todos os registros da tabela
create procedure spListagem
(
	@tabela varchar(max),
	@ordem varchar(max))
as
begin
exec('select * from ' + @tabela +
' order by ' + @ordem)
end
GO
-------------------------------------------
--4-Procedure que sugere o proximo Id
create procedure spProximoId
(@tabela varchar(max))
as
begin
exec('select isnull(max(id) +1, 1) as MAIOR from '
+@tabela)
end
GO

---------------------------/*Procedures Insert e Update Cliente*/-----------------------------------------------------------
--Procedure para inserir Cliente
--Procedure para inserir Categoria
--Procedure para inserir Produto
--Procedure para Inserir Marca

--5-Procedure para inserir Cliente
create procedure SpInsert_Cliente
				(@id int, 
				 @nome varchar (100),
				 @email varchar (60),
				 @endereco varchar (100),
				 @id_estado int, 
				 @cpf varchar(11),
				 @bonus decimal(10,2),
				 @senha varchar (8)
				) as
begin
	insert into Cliente(id,nome,email,endereco,id_estado,CPF,bonus,senha)
	values (@id,@nome,@email,@endereco,@id_estado,@cpf,@bonus,@senha)
end
GO

---------------------------------------------------------------------------
--6-Procedure para inserir Produto
create procedure SpInsert_Produto
				(@id int, 
				 @imagem varbinary(max),
				 @descricao varchar (30),
				 @id_categoria int,
				 @preco decimal (10,2),
				 @id_marca int,
				 @qtd_estoque int
				) as
begin
	insert into Produto(imagem,descricao,id_categoria,preco,id_marca,qtd_estoque)
	values (@imagem,@descricao,@id_categoria,@preco,@id_marca,@qtd_estoque)

end
GO

-------------------------------------------------------------------------------
--7-Procedure para Inserir Marca
create procedure SpInsert_Marca
				(
				@id int,
				@marca varchar (30)
				) as
			begin
				insert into Marca (id,marca) 
				values (@id,@marca)
			end
GO
-------------------------------------------/*Procedures Update */-----------------------------------------------------------
--Procedure para atualizar Cliente
--Procedure para atualizar Categoria(Não)
--Procedure para atualizar Produto
--Procedure para atualizar Marca

--8-Procedure para atualizar Cliente
create procedure SpUpdate_Cliente
				(@id int, 
				 @nome varchar (100),
				 @email varchar (60),
				 @endereco varchar (100),
				 @id_estado int, 
				 @cpf varchar(11),
				 @bonus decimal(10,2),
				 @senha varchar (8)
				) as
begin
	update  Cliente set nome = @nome,
						email = @email,
						endereco = @endereco,
						id_estado = @id_estado,
						CPF = @cpf,
						bonus = @bonus,
						senha = @senha
						where  id = @id	
end
go

-----------------------------------------------------------------------------------
--9-Procedure para atualizar Produto
create procedure SpUpdate_Produto
				(@id int, 
				 @imagem varbinary(max),
				 @descricao varchar (30),
				 @id_categoria int,
				 @preco decimal (10,2),
				 @id_marca int,
				 @qtd_estoque int
				) as

begin
	update Produto set imagem = @imagem,
					   descricao = @descricao,
					   id_categoria = @id_categoria,
					   preco = @preco,
					   id_marca = @id_marca,
					   qtd_estoque = @qtd_estoque
					   where id = @id
end
go

----------------------------------------------------------------------------
--10-Procedure para atualizar Marca
create procedure SpUpdate_Marca
				(
				@id int,
				@marca varchar (30)
				) as
			begin
				update Marca set marca=@marca
				where id=@id				
			end
GO

----------------------------------------------------------
--11-procedure para validar CPF
create procedure spValidaCPF (@CPF as varchar(11) )
as
BEGIN
-- declaração das variáveis locais
	declare @n int
	declare @soma int
	declare @multi int
	declare @digito1 int
	declare @digito2 int
	if len(rtrim(ltrim(@CPF))) <> 11
	begin
	Return 0 -- sai da stored procedure caso o CPF esteja no tamanho incorreto
	end
	-- calculando o primeiro digito...
	set @soma = 0
	set @multi = 10
	set @n = 1
	
	WHILE (@n <= 9 )
	begin
		set @soma = @soma + cast(SUBSTRING(@cpf, @n, 1) as int) * @multi;
		set @multi = @multi -1;
		set @n = @n + 1
	end
	set @soma = @soma % 11 -- % -> módulo
	if @soma <=1
		set @digito1 = 0
	else
		set @digito1 = 11 - @soma
	--calculando o segundo digito...
	set @soma = 0
	set @multi = 11
	set @n = 1
	WHILE (@n <= 9 )
	begin
		set @soma = @soma + cast(SUBSTRING(@cpf, @n, 1) as int) * @multi;
		set @multi = @multi -1;
		set @n = @n + 1
	end
	set @soma = (@soma + @digito1 * @multi);
	set @soma = @soma % 11 -- % -> módulo
	if @soma <=1
		set @digito2 = 0
	else
	set @digito2 = 11 - @soma
	--comparando os digitos digitados com os calculados...
	--print 'digito 1: ' + cast( @digito1 as varchar)
	--print 'digito 2: ' + cast( @digito2 as varchar)
	--print char(13) -- pula uma linha!!!
	declare @ValidoOuNao int
	if (cast(SUBSTRING(@cpf, 10, 1) as int) = @digito1) and
		(cast(SUBSTRING(@cpf, 11, 1) as int) = @digito2)
	set @ValidoOuNao = 1
	else
	set @ValidoOuNao =  0
	select @ValidoOuNao
	return
END
GO

-------------------------------------------------------------------------------------
--12-Procedure para ver se CPF já existe no Banco
create procedure spConsultaCpf
(
	@cpf varchar(11)
)
as
begin
	declare @verCPF int;
	set @verCPF = (select count(*) from Cliente
		where cpf = @cpf)		
	select @verCPF
	return
end
GO

--------------------------------------------------------------------------------
--13-Consulta para saber se o e-mail existe ou não, para não repetir
create procedure spConsultaEmail
(
@id int,
@email varchar(max)
)
as
begin
	declare @valEmail int
	declare @valId int
	declare @result int

	set @valEmail = (select count(*) from cliente c where email = @email)
	set @valId = (select count(*) from cliente c where id = @id and email=@email)

	if(@valId = 0 and @valEmail >= 1)
		set @result = -1
	else
		set @result = 1	
	select @result
	return		
	--exec(@sql)
end
GO

---------------------------------------------------------------
--14-Valida senha ou usuário
create procedure spTesteLogin
(
@email2 varchar(max),
@senha varchar(8)
)
as
begin
	declare @r int
	declare @testeEmail int = (select count(email) from Cliente where email=@email2)
	declare @testeSenha int = (select count(senha) from Cliente where senha=@senha)
	if(@testeEmail=0)
	begin
		set @r = -1
	end
	else begin
		if(@testeSenha=0)
			set @r = 0
		else 
			set @r= 1
	end
	select @r
	return
end
GO

------------------------------------------------------------------------------------
--15-Procedure para verificar existencia ou não da marca
create procedure spExisteMarca
(
	@id int,
	@marca varchar(max)
) 
as
begin	
	declare @valMarca int
	declare @valId int
	declare @result int

	set @valMarca = (select count(*) from marca m where marca = @marca)
	set @valId = (select count(*) from marca m where id = @id and marca=@marca)

	if(@valId = 0 and @valMarca >= 1)
		set @result = -1
	else
		set @result = 1	
	select @result
	return		
end
GO

--------------------------------------------------
--16-Procedure pra não deixar repetir imagem do produto
create procedure spConsultaImagem
(
	@operacao varchar(1),
	@imagem varbinary(max)
)
as
begin
	declare @verImagem int
	declare @resultado int = 1
	set @verImagem = (select count(*) from Produto where imagem = @imagem)	
	if(@operacao='I' and @verImagem>=1)begin		
		set @resultado=-1	
	end
	if(@operacao='A' and @verImagem>1)
		set @resultado=-1	
			
	select @resultado
	return
end
GO
---------------------------------------------------------
--17-Procedure SimulaAumento de Preços -- Usando Cursores

create procedure SP_SimulaAumento
								(@por decimal(10,2)) as
	begin
	CREATE TABLE #Produto(
	[id] [int] NOT NULL primary key,
	[imagem] [varbinary] (max),
	[descricao] [varchar] (30) NOT NULL,
	[id_categoria] [int] NOT NULL foreign key references categoria (id),
	[preco] [decimal] (10,2) NOT NULL,
	[id_marca] [int] NOT NULL foreign key references marca (id),
	[qtd_estoque] [int] NOT NULL,	
	);
	--criar o cursor 
	declare cursor_func cursor static for
			select id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque
			from Produto
	--criar variaveis para receber os dados de cada registro do cursor
	declare @id int
	declare @imagem varbinary (max)
	declare @descricao varchar (30)
	declare @id_categoria int
	declare @preco decimal (10,2)
	declare @id_marca int
	declare @qtd_estoque int

	--abre o cursor
	open cursor_func

	--leitura do 1º registro
	fetch next from cursor_func
		into @id,@imagem,@descricao,@id_categoria,@preco,@id_marca,@qtd_estoque

	--enquanto a leitura estiver ok, faça o loop
	while(@@FETCH_STATUS = 0) begin

			insert into #Produto(id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) 
					values (@id,@imagem,@descricao,@id_categoria,@preco* (1+@por/100),@id_marca,@qtd_estoque)
	--outros processos
	--leitura do Registro
	fetch next from cursor_func
		into @id,@imagem,@descricao,@id_categoria,@preco,@id_marca,@qtd_estoque
	end
	--fecha o cursor
	close cursor_func

	--elimina o cursor da memória
	deallocate cursor_func

	select * from #Produto
	end
	GO

	---------------------------------------------------
--18-Procedure para inserir Venda
create procedure SpInsert_Venda
				(@id int, 
				 @data_venda smalldatetime,
				 @id_cliente int,
				 @data_entrega smalldatetime,
				 @id_estadoEntrega int
				) as
begin
	insert into Venda(data_venda,id_cliente,data_entrega,id_estadoEntrega)
	values (@data_venda,@id_cliente,@data_entrega,@id_estadoEntrega)
end
GO

-------------------------------------------------------
--19-Procedure para inserir Itens da Venda
create procedure SpInsert_ItensVenda
				(@id int, 
				 @id_venda int,	
				 @id_produto int,
				 @quantidade int,
				 @preco decimal (10,2)
				) as
begin
	insert into ItensVenda(id_venda,id_produto,quantidade,preco)
	values (@id_venda,@id_produto,@quantidade,@preco)
end
GO

-------------------------------------------------
--20-Procedure para Consultar qual cliente está logado
create procedure spConsultaClienteLogado
(
@email varchar(max)
--@tabela varchar(max)
)
as
begin
--declare @sql varchar(max)

select c.* into #tempCli from cliente c where email= @email
select * from #tempCli
return 
end
GO

select * from ItensVenda
--------------------------------------------------------------------
--21 - Trigger para tirar produto do estoque
alter trigger trg_insere_ItensVenda
				on ItensVenda for insert as
begin 
	declare @qtEstoque int

	
	--criar o cursor 
	declare cursor_func cursor static for
					select id, id_venda,id_produto,quantidade,preco
					from Inserted
			    declare @codigo int
				declare @id_venda int
				declare @id_produto int
				declare @quantidade int
				declare @preco decimal (10,2)
				

	--abre o cursor
	open cursor_func

	--leitura do 1º registro
	fetch next from cursor_func
		into @codigo,@id_venda,@id_produto,@quantidade,@preco

	--enquanto a leitura estiver ok, faça o loop
	while(@@FETCH_STATUS = 0) begin
				set  @qtEstoque = (select qtd_estoque from Produto where id = @id_produto)
					if @quantidade > @qtEstoque begin
						raiserror ('Quantidade em Estoque insuficiente para essa compra do produto',16,1)
						rollback transaction

					end

				else
				update Produto set qtd_estoque = qtd_estoque - @quantidade where id=@id_produto
--outros processos
	--leitura do Registro
	fetch next from cursor_func
		into @codigo,@id_venda,@id_produto,@quantidade,@preco

		end
	--fecha o cursor
	close cursor_func

	--elimina o cursor da memória
	deallocate cursor_func
end

---------------------------------------------------
--22 Procedure para Filtro em Produto
alter procedure sp_FiltroProduto
(
	@idCategoria int,
	@idMarca int,
	@preco decimal(10,2)
) as
begin
	declare @cat int=(select count(*) from Produto where id_categoria=@idCategoria)
	declare @marc int=(select count(*) from Produto where id_marca=@idMarca)
	--declare @pre int=(select count(*) from Produto where preco<@preco)
	--create table #temp1

	if(@preco=0)begin
		if(@cat=0 and @marc=0)
		begin
			select * from Produto
			return 
		end
		if(@cat=0 and @marc>=1)
		begin
			select * from Produto where id_marca=@idMarca
			return
		end
		if(@cat>=1 and @marc=0)
		begin
			select * from Produto where id_categoria=@idCategoria
			return
		end
		if(@cat>=1 and @marc>=1)
		begin
			select * from Produto where id_marca=@idmarca and id_categoria=@idCategoria
			return
		end
	end
	else begin
		if(@cat=0 and @marc=0)
		begin
			select * from Produto where preco<=@preco
			return 
		end
		if(@cat=0 and @marc>=1)
		begin
			select * from Produto where id_marca=@idMarca and preco<=@preco
			return
		end
		if(@cat>=1 and @marc=0)
		begin
			select * from Produto where id_categoria=@idCategoria and preco<=@preco
			return
		end
		if(@cat>=1 and @marc>=1)
		begin
			select * from Produto where id_marca=@idmarca 
			and id_categoria=@idCategoria and preco<=@preco
			return
		end
	end
end




