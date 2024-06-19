# MyMicroservice

Exemplo criado para exemplificar como subir uma aplicação .Net com banco de dados SQL Server em container Docker.

# Rodando a aplicação

Para rodar a aplicação executar os comandos abaixo para o SQL e .NET respectivamente:

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=VeryComplex123Password" -p 1433:1433 -v sqlserver_data:/var/opt/mssql/data -d mcr.microsoft.com/mssql/server:2022-latest

docker run -p 3000:8080 microservice

# Testando via postman

Para testar utilize os endpoints abaixo:

GET -> http://localhost:3000/api/person (lista todos)
POST -> http://localhost:3000/api/person (Insere)
  body:
    {
    "firstname": "Lucas",
    "lastname": "Alonso asdf",
    "birthday": "1989-02-02"
    }

PUT -> http://localhost:3000/api/person?id=4
  body:
    {
    "firstname": "Lucas",
    "lastname": "asdf",
    "birthday": "1989-02-02"
    }

DELETE -> http://localhost:3000/api/person?id=4
