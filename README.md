# ModeloApi — API de Agenda de Contatos

API REST em **ASP.NET Core** com **Entity Framework Core** e **SQL Server** para cadastrar e gerenciar contatos de uma agenda. Projeto desenvolvido acompanhando as aulas da trilha .NET da DIO, seguindo a implementação feita pelo professor.

## Tecnologias

- C# / ASP.NET Core Web API
- Entity Framework Core (SQL Server) com Migrations
- Swagger (Swashbuckle) para documentação e testes

## Endpoints

### Contato

| Método | Rota | Descrição |
|---|---|---|
| `POST` | `/Contato` | Cria um contato |
| `GET` | `/Contato/{id}` | Busca um contato pelo id |
| `GET` | `/Contato/ObterPorNome?nome=` | Busca contatos cujo nome contém o texto |
| `PUT` | `/Contato/{id}` | Atualiza nome, telefone e status |
| `DELETE` | `/Contato/{id}` | Remove um contato |

### Usuario

| Método | Rota | Descrição |
|---|---|---|
| `GET` | `/Usuario/ObterDataHoraAtual` | Retorna a data e a hora do servidor |
| `GET` | `/Usuario/Apresentar/{nome}` | Retorna uma mensagem de boas-vindas |

## Como executar

Pré-requisitos: [.NET 10 SDK](https://dotnet.microsoft.com/download) e SQL Server (Express ou LocalDB).

1. Ajuste a connection string `ConexaoPadrao` em `appsettings.Development.json` se o seu servidor não for `localhost\sqlExpress`.
2. Crie o banco aplicando as migrations:
   ```bash
   dotnet tool install --global dotnet-ef
   dotnet ef database update
   ```
3. Rode a API:
   ```bash
   dotnet run
   ```
4. Abra o Swagger em `https://localhost:<porta>/swagger`.

## Estrutura

```
Context/      DbContext (AgendaContext)
Controllers/  ContatoController e UsuarioController
Entities/     Entidade Contato
Migrations/   Migrations do EF Core
Models/       Tarefa e EnumStatusTarefa
```
