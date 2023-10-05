# Cleiteam

Este projeto foi desenvolvido para o Hack For Change, Hackathon desenvolvido pela FIAP em parceria com a Alura, com a equipe:  
- Amanda Vasconcelos Neves;  
- Mayara Gomes de Carvalho Sampaio;  
- Paula Correa Silva;  
- Thiago Pereira Alves;  
- Vinicius de Souza Nascimento.    

## Tecnologias

- .Net 7.0;
- ASP .NET Web API;
- SQL Server;
- EntityFrameworkCore;
- AutoMapper;
- FluentValidation;
- Git;

## Detalhes
Esta API é estruturada com base no padrão DDD com projetos do tipo biblioteca de classe, além do projeto do tipo API.  
Apesar de não estar totalmente conforme a Clean Architecture e o Domain Driven Design, buscou-se seguir seus princípios na medida do possível.  
Além disso, a API conta com um repositório genérico.  
Mapeamentos foram feitos com auxílio da biblioteca Automapper e as validações com uso da biblioteca FluentValidation.  
Nosso banco de dados está separado em duas databases, sendo uma delas próprio para a utilização do módulo de identidade, afim de termos uma melhor segurança nos dados sensíveis dos usuários

## Instruções de Utilização:

### Visual Studio

Caso tenha o `git` instalado, é possível clonar este repositório com os seguintes comandos:

```console
$ git clone https://github.com/viniciusnasc/Cleiteam
```

Também é possível baixar o conteúdo em formato `.zip` clicando no botão "Clone" na [homepage](https://github.com/viniciusnasc/Cleiteam) do repositório.

Certifique-se de ter o .NET instalado, caso não tenha, é possível fazer download do .NET 7 [na página oficial](https://dotnet.microsoft.com/download/dotnet) da Microsoft.  
Também é preciso estar com o banco de dados SQL Server instalado, é possível fazer download do SQL Server [na página oficial]([https://www.mongodb.com/](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads))

A string de conexão com o banco deve ser definida. Vá até os arquivos `appsettings.json`, que se encontram em Cleiteam.API e Cleiteam.Identidade.API e edite a ConnectionString da chave DefaultConnection.  

**Compilar e executar com CLI do .NET:**

A seguir, abra o prompt de comando nos diretórios dos projetos Cleiteam.API e Cleiteam.Identidade.API e digite:

```console
$ dotnet run
```

Abra o navegador e acesse `https://localhost:7200/swagger/index.html` para o módulo principal;  
Abra o navegador e acesse `https://localhost:7205/swagger/index.html` para o módulo de segurança;  

**Compilar e executar com Visual Studio:**

Abra o diretório do projeto contendo o arquivo `Cleiteam.sln` e clique duas vezes.  
Isso abrirá a IDE Visual Studio com todos os arquivos pertencentes ao projeto.  
Clique com o botão direito do mouse na solução e clique em Configurar projetos de inicialização...  
Selecione Vários projetos de inicialização e defina os projetos 'Cleiteam.API' e 'Cleiteam.Identidade.API' a serem iniciados.  
Aperte a tecla F5 ou então clique no botão com ícone verde contendo o nome Cleiteam.API ou IIS Express, na barra de ferramentas. O navegador será automaticamente aberto com os URL's `https://localhost:7200/swagger/index.html` e `https://localhost:7205/swagger/index.html`

**Exemplo de utilização da API:**
