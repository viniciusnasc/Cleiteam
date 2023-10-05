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

**Configuração do banco de dados**

Após adicionar as connections strings dos projetos, abir o Console do Gerenciador de Pacotes em: Ferramentas > Gerenciador de pacotes do NuGet.  
No console, selecionar o projeto em Cleiteam.API 'padrão projeto' e executar os comandos `add-migration first`, seguido de `update-database`.  
Realizar o mesmo procedimento para o projeto Cleiteam.Identidade.API.  

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

## User Stories  

### Épico: GU - Gestão de usuários

GU1: Necessário realizar cadastro de usuário.  
Critérios de aceite: Utilizar e-mail para cadastrar o usuário.  

GU2: O usuário poderá configurar o range de distância para receber notifições, se deseja receber a notificações, e seu nome de usuário.  
Critérios de aceite: Ao editar as informações, elas deverão persistir no banco de dados.  

### Épico: GO - Gestão de ocorrências  

GO1: Um usuário pode registrar uma ocorrência, que será atrelado a seu perfil.  
Critérios de aceite: O usuário logado deve ter a possibilidade de realizar o registro, que deve ser persistido no banco de dados. Esta ocorrência deve obrigatoriamente conter uma imagem.  

GO2: É necessário retornar todos as ocorrências em um range a ser definido, a partir de um ponto no mapa.  
Critérios de aceite: Renderizar no mapa todas as ocorrências presentes no banco de dados retornados da pesquisa.  

GO3: Uma ocorrência deve conter uma ou varias imagens, ao selecionar uma ocorrência, deverá retornar todas as imagens atreladas a ela.  
Critérios de aceite: Permitir a um usuário qualquer a adicionar uma imagem em uma ocorrência já existente.  

GO4: Permitir somente ao usuário que adicionou a imagem poder excluir ela.  
Critérios de aceite: Permitir a deleção de uma imagem, desde que o usuário que esteja tentando deletar seja o mesmo que a tenha inserido.  

GO5: Possibilitar a inserção de comentários em uma imagem.  
Critérios de aceite: Um usuário pode comentar várias vezes em uma imagem.

GO6: Somente o proprio usuário pode excluir um comentário.  
Critérios de aceite: Somente o usuário que inseriu o comentário conseguirá deletá-lo.

### Épico: TO - Tipos de ocorrência  

TO1: É necessário o insert automatico dos tipos de ocorrência e seus subtipos, de acordo com os discutidos em reuniões.
Critérios de aceite: Necessário que ao ser configurado o banco de dados, seja inseridos os dados automaticamente.  

TO2: É necessário relacionar todos os tipos de ocorrência e seus subtipos para renderização do front end.  
Critérios de aceite: Relacionar em uma rota todos dados de tipo de ocorrência presentes no banco de dados.  
