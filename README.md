# Personal Fin Tracker

Aplicação de gestão de finanças pessoais voltada a oferecer uma visão clara da saúde financeira por meio do acompanhamento de despesas, gerenciamento de cartões de crédito, despesas recorrentes e planejamento de compras.

O projeto está sendo desenvolvido como **portfólio pessoal e projeto de aprendizado**, com ênfase em arquitetura de software, desenvolvimento de APIs, segurança, autenticação, autorização, persistência de dados e integração com serviços externos.

---

## Objetivos do projeto

O objetivo principal do Personal Fin Tracker é oferecer uma visão centralizada das finanças pessoais, ajudando usuários a entender como seus gastos afetam o orçamento mensal e o planejamento financeiro.

A aplicação permitirá:

* Acompanhar despesas pessoais.
* Gerenciar cartões de crédito e suas despesas.
* Registrar despesas recorrentes e fixas.
* Planejar compras futuras.
* Avaliar o impacto de compras planejadas no orçamento disponível.
* Visualizar uma visão geral da saúde financeira.

O projeto também tem como objetivo demonstrar a construção de uma aplicação full stack utilizando práticas e tecnologias relevantes para o mercado.

---

## Arquitetura

O backend seguirá os princípios da **Clean Architecture**, mantendo as regras de negócio independentes da infraestrutura, do banco de dados e de serviços externos.

O projeto será estruturado nas seguintes camadas:

* **Domain** — Entidades, value objects e regras de negócio.
* **Application** — Casos de uso, contratos e orquestração da aplicação.
* **Infrastructure** — Persistência, implementações de serviços e integrações externas.
* **API** — Interface HTTP, configuração da aplicação e composição das dependências.

O frontend será desenvolvido separadamente utilizando React e TypeScript.

A direção das dependências seguirá os princípios da Clean Architecture, evitando que o domínio dependa de detalhes de infraestrutura.

---

## Estrutura da solução

```text
src/
├── PersonalFinTracker.Domain/          # Entidades e regras de domínio
├── PersonalFinTracker.Application/     # Casos de uso e abstrações
├── PersonalFinTracker.Infrastructure/  # Persistência e integrações externas
└── PersonalFinTracker.Api/             # API HTTP e composição da aplicação
```

As dependências devem respeitar a seguinte direção:

```text
Domain
   ↑
Application
   ↑
Infrastructure
   ↑
API
```

A camada `Application` poderá definir abstrações necessárias para os casos de uso, enquanto `Infrastructure` fornecerá suas implementações.

A API será responsável pela composição das dependências e pela exposição dos endpoints HTTP.

---

## Tecnologias

### Backend

* .NET 8
* C#
* ASP.NET Core Minimal APIs
* Entity Framework Core
* Clean Architecture
* REST

### Frontend

* React
* TypeScript
* Vite
* Tailwind CSS

### Banco de dados

* PostgreSQL
* Entity Framework Core
* EF Core Code First
* EF Core Migrations

O PostgreSQL será a **fonte de verdade dos dados da aplicação**, incluindo os dados financeiros e os dados necessários para o funcionamento da autenticação e autorização.

O Entity Framework Core será utilizado seguindo a abordagem **Code First**.

O modelo de dados será definido e mantido no código da aplicação, enquanto o schema do PostgreSQL será criado e evoluído por meio de **EF Core Migrations** versionadas.

Configurações de entidades deverão ser mantidas de forma organizada, utilizando mecanismos como `IEntityTypeConfiguration<T>` quando apropriado.

A persistência deverá permanecer isolada das regras de negócio, evitando acoplamento das camadas internas ao PostgreSQL ou ao Entity Framework Core.

### Autenticação e segurança

* Autenticação baseada em credenciais
* Autorização
* JWT
* Claims
* OAuth 2.0
* OpenID Connect
* CORS
* Validação de entrada
* Gerenciamento seguro de configurações e segredos

OAuth 2.0 e OpenID Connect serão utilizados posteriormente para a integração com serviços Google, não constituindo inicialmente o mecanismo principal de autenticação da aplicação.

### Integrações externas

A aplicação poderá ser integrada futuramente ao **Google Drive / Google Sheets** para permitir que o usuário exporte ou sincronize seus dados financeiros com uma planilha.

Essa integração será tratada como uma funcionalidade externa à persistência principal da aplicação.

O PostgreSQL continuará sendo a fonte de verdade dos dados. A planilha do Google não será utilizada como banco de dados da aplicação.

---

## Persistência

A persistência principal seguirá o seguinte modelo:

```text
                    ┌─────────────────────┐
                    │      PostgreSQL     │
                    │                     │
                    │ Usuários            │
                    │ Dados financeiros   │
                    │ Cartões             │
                    │ Categorias          │
                    │ Planejamentos       │
                    │ etc.                │
                    └─────────────────────┘
                              ▲
                              │
                    Entity Framework Core
                       Code First
                              ▲
                              │
                    Infrastructure
```

O fluxo de evolução do banco seguirá:

```text
Entidades / Configurações
        ↓
   EF Core Model
        ↓
 EF Core Migration
        ↓
    PostgreSQL
```

As migrations deverão ser versionadas junto ao código-fonte.

O banco de dados será responsável pela persistência dos dados necessários para a aplicação funcionar de forma independente de serviços externos.

A integração com o Google será adicionada posteriormente:

```text
Personal Fin Tracker
        │
        ├── PostgreSQL
        │      └── Fonte de verdade
        │
        └── Google Sheets
               └── Exportação / sincronização
```

A integração externa não deverá alterar as regras fundamentais do domínio nem tornar o funcionamento básico da aplicação dependente do Google.

---

## Segurança

Segurança é um dos principais objetivos de aprendizado deste projeto.

A API explorará conceitos como:

* Autenticação
* Autorização
* JWT
* Claims
* OAuth 2.0
* OpenID Connect
* Controle de acesso a recursos
* Configuração segura
* Gerenciamento de segredos
* Validação de entrada
* CORS
* Tratamento consistente de erros
* Proteção de dados sensíveis

A aplicação nunca deverá depender exclusivamente de identificadores fornecidos pelo cliente para determinar quais recursos podem ser acessados.

A identidade do usuário deverá ser obtida a partir do contexto autenticado, e o acesso aos recursos deverá ser validado no backend.

---

## Funcionalidades planejadas

### MVP

* [ ] Cadastro de usuário
* [ ] Login
* [ ] Autenticação baseada em token
* [ ] Autorização
* [ ] Gerenciamento de despesas
* [ ] Gerenciamento de categorias
* [ ] Gerenciamento de cartões de crédito
* [ ] Gerenciamento de despesas recorrentes
* [ ] Painel financeiro
* [ ] Resumos financeiros

### Planejamento financeiro

* [ ] Planejamento de compras
* [ ] Análise de impacto das compras no orçamento
* [ ] Projeções financeiras
* [ ] Indicadores financeiros

### Integrações

* [ ] Integração com Google OAuth 2.0
* [ ] Integração com Google Sheets API
* [ ] Exportação de dados para Google Sheets
* [ ] Atualização/sincronização de dados com Google Sheets
* [ ] Gerenciamento de autorização e tokens da integração

### Qualidade e infraestrutura

* [ ] Testes unitários
* [ ] Testes de integração
* [ ] Testes de API
* [ ] Docker
* [ ] Docker Compose para ambiente local
* [ ] Pipeline de CI/CD
* [ ] Documentação da API
* [ ] Observabilidade básica

---

## Objetivos de aprendizado

Este projeto busca proporcionar experiência prática com:

* Clean Architecture
* Princípios de Domain-Driven Design
* Desenvolvimento de APIs REST
* ASP.NET Core Minimal APIs
* C#
* Entity Framework Core
* Code First
* EF Core Migrations
* PostgreSQL
* Modelagem de dados
* Autenticação e autorização
* JWT
* Claims
* OAuth 2.0
* OpenID Connect
* Segurança de APIs
* React
* TypeScript
* Vite
* Tailwind CSS
* Integração com APIs externas
* Testes automatizados
* Containerização
* CI/CD

O projeto priorizará **fundamentos sólidos e práticas utilizadas no mercado**, evitando complexidade arquitetural que não agregue valor ao produto.

---

## Princípios de desenvolvimento

Durante o desenvolvimento, algumas diretrizes deverão ser observadas:

1. **O domínio não deve depender de infraestrutura.**
2. **O PostgreSQL é a fonte de verdade dos dados da aplicação.**
3. **O Entity Framework Core será utilizado seguindo a abordagem Code First.**
4. **As alterações no schema do banco deverão ser realizadas por meio de EF Core Migrations versionadas.**
5. **Integrações externas devem ser isoladas atrás de abstrações apropriadas.**
6. **A API é responsável por aplicar autenticação e autorização.**
7. **O cliente nunca deve ser considerado uma fonte confiável para decisões de autorização.**
8. **Regras de negócio devem permanecer fora dos endpoints HTTP sempre que possível.**
9. **Não introduzir complexidade arquitetural sem uma necessidade concreta.**
10. **Novas decisões arquiteturais relevantes devem ser documentadas por ADRs.**
11. **Funcionalidades devem ser implementadas de forma incremental e testável.**
12. **O funcionamento básico da aplicação não deve depender de serviços externos de terceiros.**

---

## Integração com Google

A integração com Google será desenvolvida em uma etapa posterior do projeto.

O objetivo será permitir que o usuário autorize explicitamente a aplicação a acessar recursos necessários do Google Drive/Google Sheets.

O fluxo deverá utilizar **OAuth 2.0** e, quando aplicável, **OpenID Connect**.

A integração deverá considerar:

* Consentimento explícito do usuário.
* Escopos mínimos necessários.
* Armazenamento seguro das credenciais e tokens necessários.
* Expiração e renovação de tokens.
* Revogação da autorização.
* Tratamento de falhas da API externa.
* Separação entre os dados locais e os dados sincronizados.

A integração não deverá transformar o Google Sheets em requisito para o funcionamento da aplicação.

---

## Status do projeto

**Em desenvolvimento.**

A implementação será realizada de forma incremental, seguindo os requisitos definidos e as decisões arquiteturais documentadas no projeto.

Decisões técnicas relevantes deverão ser registradas em **Architecture Decision Records (ADRs)**.

Mudanças significativas de escopo ou requisitos deverão ser refletidas na documentação correspondente antes da implementação.

---

## Licença

Este projeto é licenciado sob a licença MIT.
