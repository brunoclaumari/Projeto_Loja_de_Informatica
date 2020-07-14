

use LojaInformatica

--set dateformat dmy

--Inserindo dados tabela Categoria
insert into Categoria (id,descricao) values (1,'Hardware')
insert into Categoria (id,descricao) values (2,'Software')
insert into Categoria (id,descricao) values (3,'Periférico')
insert into Categoria (id,descricao) values (4,'Computador Desktop')
insert into Categoria (id,descricao) values (5,'Notebook')
insert into Categoria (id,descricao) values (6,'Celular')
insert into Categoria (id,descricao) values (7,'Acessórios Celular')
insert into Categoria (id,descricao) values (8,'Game-Console')
insert into Categoria (id,descricao) values (9,'Game-Acessórios')

--Inserindo dados tabela Regiao
insert into Regiao(id,Sigla,Descricao) values (1,'CO','Centro-Oeste')
insert into Regiao(id,Sigla,Descricao) values (2,'N','Norte')
insert into Regiao(id,Sigla,Descricao) values (3,'NR','Nordeste')
insert into Regiao(id,Sigla,Descricao) values (4,'S','Sul')
insert into Regiao(id,Sigla,Descricao) values (5,'SD','Sudeste')

--Inserindo dados tabela Estado
insert into Estado	(id,Estado,Descricao,id_regiao) values (1,'AC','Acre',2)
insert into Estado	(id,Estado,Descricao,id_regiao) values (2,'AL','Alagoas',3)
insert into Estado	(id,Estado,Descricao,id_regiao) values (3,'AP','Amapá',2)
insert into Estado	(id,Estado,Descricao,id_regiao) values (4,'AM','Amazonas',2)
insert into Estado	(id,Estado,Descricao,id_regiao) values (5,'BA','Bahia',3)
insert into Estado	(id,Estado,Descricao,id_regiao) values (6,'CE','Ceará',3)
insert into Estado	(id,Estado,Descricao,id_regiao) values (7,'DF','Distrito Federal',1)
insert into Estado	(id,Estado,Descricao,id_regiao) values (8,'ES','Espírito Santo',5)
insert into Estado	(id,Estado,Descricao,id_regiao) values (9,'GO','Goiás',1)
insert into Estado	(id,Estado,Descricao,id_regiao) values (10,'MA','Maranhão',3)
insert into Estado	(id,Estado,Descricao,id_regiao) values (11,'MT','Mato Grosso',1)
insert into Estado	(id,Estado,Descricao,id_regiao) values (12,'MS','Mato Grosso do Sul',1)
insert into Estado	(id,Estado,Descricao,id_regiao) values (13,'MG','Minas Gerais',5)
insert into Estado	(id,Estado,Descricao,id_regiao) values (14,'PA','Pará',2)
insert into Estado	(id,Estado,Descricao,id_regiao) values (15,'PB','Paraíba',3)
insert into Estado	(id,Estado,Descricao,id_regiao) values (16,'PR','Paraná',4)
insert into Estado	(id,Estado,Descricao,id_regiao) values (17,'PE','Pernambuco',3)
insert into Estado	(id,Estado,Descricao,id_regiao) values (18,'PI','Piauí',3)
insert into Estado	(id,Estado,Descricao,id_regiao) values (19,'RJ','Rio de Janeiro',5)
insert into Estado	(id,Estado,Descricao,id_regiao) values (20,'RN','Rio Grande do Norte',3)
insert into Estado	(id,Estado,Descricao,id_regiao) values (21,'RS','Rio Grande do Sul',4)
insert into Estado	(id,Estado,Descricao,id_regiao) values (22,'RO','Rondônia',2)
insert into Estado	(id,Estado,Descricao,id_regiao) values (23,'RR','Roraima',2)
insert into Estado	(id,Estado,Descricao,id_regiao) values (24,'SC','Santa Catarina',4)
insert into Estado	(id,Estado,Descricao,id_regiao) values (25,'SP','São Paulo',5)
insert into Estado	(id,Estado,Descricao,id_regiao) values (26,'SE','Sergipe',3)
insert into Estado	(id,Estado,Descricao,id_regiao) values (27,'TO','Tocantins',2)



--Inserindo Clientes
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (1,'Paulo','paulo@paulo','Alvarenga|4001|Assunção', 23,'33820915001',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (2,'Bruno','bruno@bruno','Alvarenga|4001|Assunção', 24,'49411240062',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (3,'Alipio','alipio@alipio','Alvarenga|4001|Assunção', 25,'83940010090',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (4, 'Santos','santos@dominio.com.br','Tuta|1264|Jardim das Rosas',3,'38279595945',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (5, 'Amanda','amanda@dominio.com.br','Yrere|1264|Conjuto E',3,'99002343086',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (6, 'Daniel','daniel@dominio.com.br','Juçara|816|Conjuto F',3,'06380344772',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (7, 'Miguel','daniel@dominio.com.br','Juçara|816|Conjuto F',3,'06380344772',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (8, 'Marcos','marcos@dominio.com.br','Juçara|816|Conjuto F',25,'22881943080',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (9, 'Aurora','aurora@dominio.com.br','Trigo|816|Posto Norte',25,'27363518009',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (10, 'Frederico','frederico@dominio.com.br','Jardinopolis|412|Quadro',25,'95773770415',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (11, 'Marina','marina@dominio.com.br','Ribeiro|269|Conjuto E',24,'95773770415',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (12, 'Isis','isis@dominio.com.br','Leão|1920|Oito',8,'89506454248',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (13, 'Isadora','isadora@dominio.com.br','Leão|1486|João Lima',9,'65717283709',0.00,'123456')
insert into Cliente (id,nome,email,endereco,id_estado,CPF,bonus,senha) values (14, 'Juliana','juliana@dominio.com.br','Martinez|403|Principal',9,'11842002112',0.00,'123456')

--Inserindo Marcas
insert into Marca (id, marca) values (1,'Philips')
insert into Marca (id,marca) values (2,'Seagate')
insert into Marca (id,marca) values (3,'DHL')
insert into Marca (id,marca) values (4,'Corsair')
insert into Marca (id,marca) values (5,'Tp-Link')
insert into Marca (id,marca) values (6,'Samsung')
insert into Marca (id,marca) values (7,'Multilaser')
insert into Marca (id,marca) values (8,'GForce')
insert into Marca (id,marca) values (9,'MSi')

--Inserindo Produtos
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (1,0xFFD8FFE1001845786966000049492A00080000000000000000000000FFEC00114475636B7900010004000000460000FFE10361687474703A2F2F6E732E61646F62652E636F6D2F7861702F312E302F003C3F787061636B657420626567696E3D22EFBBBF222069643D2257354D304D7043656869487A7265537A4E54637A6B,'Fone de Ouvido',1,29.00,1,20)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (2,0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C2132323232323232323232323232323232323232,'Gabite Gamer',1,1800.90,8,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (3,0xFFD8FFE000104A46494600010102004800480000FFE2021C4943435F50524F46494C450001010000020C6C636D73021000006D6E74725247422058595A2007DC00010019000300290039616373704150504C0000000000000000000000000000000000000000000000000000F6D6000100000000D32D6C636D730000000000,'HDD',1,241.29,2,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (4,0xFFD8FFE000104A46494600010100000100010000FFDB0084000906071213121514131316161517181D1719171818201E201A181F1E1818181E1A1F1D2029201B1A251B1A1821312125292B2E2E2E171F3338332D37282D2E2B010A0A0A0E0D0E1A10101A2F2620252F2D2D2D2D2D2D2D2D2D2D2D2D2D2D2D2D2D2D2D2D2D2D,'Teclado DHL',1,100.90,3,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (5,0xFFD8FFE000104A46494600010101006000600000FFE1003A4578696600004D4D002A000000080003511000010000000101000000511100040000000100000B13511200040000000100000B1300000000FFDB0043000201010201010202020202020202030503030303030604040305070607070706070708090B0908080A08,'Memória DDR4',1,80.90,4,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (6,0xFFD8FFE000104A46494600010101006000600000FFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C2132323232323232323232323232323232323232,'Microfone',1,19.90,1,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (7,0xFFD8FFE1001845786966000049492A00080000000000000000000000FFEC00114475636B79000100040000004B0000FFE103F0687474703A2F2F6E732E61646F62652E636F6D2F7861702F312E302F003C3F787061636B657420626567696E3D22EFBBBF222069643D2257354D304D7043656869487A7265537A4E54637A6B,'Modem',1,129.90,5,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (8,0xFFD8FFE000104A46494600010101006000600000FFE1003A4578696600004D4D002A000000080003511000010000000101000000511100040000000100000B13511200040000000100000B1300000000FFDB0043000201010201010202020202020202030503030303030604040305070607070706070708090B0908080A08,'Monitor',1,459.90,6,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (9,0xFFD8FFE000104A46494600010101006000600000FFDB0043000201010201010202020202020202030503030303030604040305070607070706070708090B0908080A0807070A0D0A0A0B0C0C0C0C07090E0F0D0C0E0B0C0C0CFFDB004301020202030303060303060C0807080C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C,'Mouse',1,39.90,7,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (10,0xFFD8FFE1132245786966000049492A000800000011000001030001000000701700000101030001000000A00F00000201030003000000DA0000000601030001000000020000000F01020012000000E0000000100102000C000000F20000001201030001000000010000001501030001000000030000001A01050001000000FE,'Teclado',1,29.90,7,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (11,0xFFD8FFE000104A46494600010101006000600000FFE1003A4578696600004D4D002A000000080003511000010000000101000000511100040000000100000B13511200040000000100000B1300000000FFDB0043000201010201010202020202020202030503030303030604040305070607070706070708090B0908080A08,'Placa de Video',1,529.90,8,10)
insert into  Produto (id,imagem,descricao,id_categoria,preco,id_marca,qtd_estoque) values (12,0xFFD8FFDB00430006040506050406060506070706080A100A0A09090A140E0F0C1017141818171416161A1D251F1A1B231C1616202C20232627292A29191F2D302D283025282928FFDB0043010707070A080A130A0A13281A161A28282828282828282828282828282828282828282828282828282828282828282828282828,'Placa de Video',1,489.90,9,10)

--Inserindo Venda

set dateformat mdy

insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/1/2019',1,'11/8/2019',23)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/2/2019',2,'11/9/2019',24)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/3/2019',3,'11/10/2019',25)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/4/2019',4,'11/11/2019',3)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/5/2019',5,'11/12/2019',3)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/6/2019',6,'11/13/2019',3)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/7/2019',7,'11/14/2019',3)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/8/2019',8,'11/15/2019',3)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/9/2019',9,'11/16/2019',25)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/10/2019',10,'11/17/2019',25)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/11/2019',11,'11/18/2019',25)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/12/2019',12,'11/19/2019',24)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/13/2019',13,'11/20/2019',9)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/14/2019',14,'11/21/2019',9)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/15/2019',1,'11/22/2019',23)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/16/2019',2,'11/23/2019',24)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/17/2019',3,'11/24/2019',25)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/18/2019',4,'11/25/2019',3)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/19/2019',5,'11/26/2019',3)
insert into Venda (data_venda,id_cliente,data_entrega,id_estadoEntrega) values ('11/20/2019',6,'11/27/2019',3)




--select * from Categoria
--select * from Regiao
--select * from Estado


