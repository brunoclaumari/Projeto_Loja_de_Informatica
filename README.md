# Projeto_Loja_de_Informatica
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/brunoclaumari/Projeto_Loja_de_Informatica/blob/master/LICENSE)
# Sobre o projeto

Aplicação Web, feita em ASP.Net Core, no 5º semestre do curso de Engenharia da Computação pelos integrantes: 
Alipio Danilo, Bruno de Sousa e Paulo de Tarso

Projeto da disciplina de Linguagem de Programação 1, da Faculdade de Tecnologia Termomecânica que reproduz um sistema de loja de informática onde é possível cadastrar produtos, clientes, e pedidos. Também tem conexão com o banco SQLServer executando as querys que acompanham o programa.

# Layout Web
## Tela Home
![Web 1](https://github.com/brunoclaumari/Projeto_Loja_de_Informatica/blob/master/assets/home.png)

## Login (usar esse usuario para poder entrar -> SENHA = 123456)
![Web 2](https://github.com/brunoclaumari/Projeto_Loja_de_Informatica/blob/master/assets/login.png)

## Lista de Produtos
![Web 3](https://github.com/brunoclaumari/Projeto_Loja_de_Informatica/blob/master/assets/lista_produtos.png)

# Diagrama do Banco
![Diag 1](https://github.com/brunoclaumari/Projeto_Loja_de_Informatica/blob/master/assets/DIAGRAMA%20LOJA%20DE%20INFORM%C3%81TICA.png)

# Tecnologias 
## Backend
-C# 
-ASP.NET core
-TSQL

## FrontEnd
-HTML / CSS / JS
-Razor

## Persistência de Dados
-SQL Server

## Conceito arquitetural
- Arquitetura MVC

# Como executar o projeto

Como no momento não está distribuído na rede, esses são os pré-requisitos:
-Ter o Visual Studio (2017 ou 2019) com suporte a aplicações ASP.NET instalado.
-Ter o SQL Server Express e SQL management Studio instalado, para poder executar os scripts.
-Clonar ou baixar este projeto do github. Se for download, fazer a extração.

--Usar esses parametros no seu SQL Server como 'localhost'. 
## No SQL management Studio, é necessário configurar o usuario sa 
https://www.devmedia.com.br/ativar-usuario-sa-sql-server/20794

user id=sa; 
password=123456"

## Configurar o localhost
https://qastack.com.br/programming/12774827/cant-connect-to-localhost-on-sql-server-express-2012-2016

--Para login -> usuario = santos@dominio.com.br / senha = 123456

Ordem de execução das querys

1-Cria_Banco_LojaInformatica_N2-V7
2-Procedures_Banco_LojaInformatica_N2-V9
3-Provoando o banco_N2-V3

--Depois que todos os procedimentos do banco foram executados: 

### ->Ir na pasta do projeto e clicar 2x no arquivo 'LojaDeInformatica.sln' e aí o Visual Studio vai abrir
### ->Clicar no botão executar do Visual Studio





