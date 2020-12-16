# Projeto_Loja_de_Informatica
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/brunoclaumari/Projeto_Loja_de_Informatica/blob/master/LICENSE)
# Sobre o projeto

Aplicação Web, feita em ASP.Net Core, no 5º semestre do curso de Engenharia da Computação pelos integrantes: 
Alipio Danilo, Bruno de Sousa e Paulo de Tarso

Projeto da disciplina de Linguagem de Programação 1, da Faculdade de Tecnologia Termomecânica que reproduz um sistema de loja de informática onde é possível cadastrar produtos, clientes, e pedidos. Também tem conexão com o banco SQLServer executando as querys que acompanham o programa.

# Layout Web
-Tela Home
![Web 1](https://drive.google.com/file/d/12UligBArp4_VkkmYuYeZIncbb3w51sBA/view?usp=sharing)

-Login (usar esse usuario para poder entrar)
![Web 2](https://drive.google.com/file/d/1Oh5XNGTYc1nbT_lkV9L8nUHPtRVR6-1x/view?usp=sharing)

-Lista de Produtos
![Web 3](https://drive.google.com/file/d/1-VDbJ2tDEk1o6S8dHJWcauaCZAQDHwCT/view?usp=sharing)

# Diagrama do Banco
![Diag 1](https://drive.google.com/file/d/15AMOQdwerpe6ZZdbSCbIjKMfBXpPHBiW/view?usp=sharing)

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
## É necessário configurar o usuario sa 
user id=sa; 
password=123456"

--Para login -> usuario = santos@dominio.com.br / senha = 123456

Ordem de execução das querys

1-Cria_Banco_LojaInformatica_N2-V7
2-Procedures_Banco_LojaInformatica_N2-V9
3-Provoando o banco_N2-V3

