# Tryitter

 Projeto final da aceleração C# da Trybe em parceria com a XP. Consiste em criar uma API de uma rede social onde as pessoas estudantes poderão realizar publicações.

## Requisitos técnicos:
* Utilizar C#, SQL Server e Azure;
* Ter rotas autenticadas e rotas anônimas;
* Utilizar os frameworks xUnit e FluentAssertions para criar testes.

## Funcionalidades:
* Implementar um C.R.U.D. para as contas de pessoas estudantes;
* Implementar um C.R.U.D. para um post de uma pessoa estudante;
* Alterar um post depois de publicado.

## Schema
Conforme visto na imagem abaixo, haverá um Front-End que será responsável por interagir com as pessoas estudantes e mandar as muitas requisições para o Back-End, que, por sua vez, será responsável por manter as informações atualizadas em um banco de dados MySQL Server usando o Framework Entity.

![schema](https://user-images.githubusercontent.com/88668590/207732338-b19acaff-e134-446f-bec3-9728c971eaa6.PNG)

## Tecnologias Utilizadas
* C#
* Entity Framework
* Swagger
* Jwt
* SQL

## Swagger
![swagger](https://user-images.githubusercontent.com/88668590/207733131-7c83babb-c557-4db7-948f-564e3168916b.PNG)

## Rodar localmente com Docker :whale:

docker build -t nome-tag-imagem .

docker images

docker container run -p 5000:80 nome-tag-imagem
