# PRD 0001: Fundação do Projeto

* **Status:** Draft

## Contexto

O Personal Fin Tracker será desenvolvido como uma aplicação web composta por um backend responsável pelas regras de negócio e acesso aos dados e por um frontend responsável pela interface com o usuário.

Antes da implementação das funcionalidades financeiras, é necessário estabelecer uma fundação mínima para que o projeto possa ser executado, desenvolvido e evoluído de forma consistente.

A fundação deve contemplar a estrutura inicial da solução, a comunicação entre frontend e backend e a configuração necessária para execução local.

As decisões arquiteturais relacionadas à estrutura e às tecnologias adotadas estão registradas nos ADRs correspondentes.

## Objetivo

Estabelecer a estrutura inicial e executável do Personal Fin Tracker, preparando o projeto para o desenvolvimento incremental das funcionalidades definidas nos próximos PRDs.

## Escopo

Este PRD contempla:

* Estrutura inicial do backend.
* Estrutura inicial do frontend.
* Configuração da comunicação entre frontend e backend.
* Configuração inicial do banco de dados.
* Configuração necessária para execução local.
* Configurações básicas de desenvolvimento.

## Requisitos

### Backend

O projeto deve possuir uma aplicação backend organizada de acordo com a arquitetura definida nos ADRs.

A solução deve conter as camadas:

* Domain
* Application
* Infrastructure
* API

A API deve ser executável localmente e estar preparada para receber as funcionalidades dos próximos PRDs.

### Frontend

O projeto deve possuir uma aplicação frontend independente do backend, utilizando a stack definida nos ADRs.

O frontend deve ser executável localmente e estar preparado para consumir a API.

### Comunicação

Frontend e backend devem conseguir se comunicar durante a execução local.

A configuração necessária para essa comunicação deve estar definida de forma que o frontend consiga realizar requisições à API.

### Banco de dados

O projeto deve possuir uma configuração inicial para conexão com o PostgreSQL.

A configuração deve permitir que o backend seja executado localmente utilizando o banco de dados definido no projeto.

A estrutura de persistência necessária para funcionalidades específicas será definida nos respectivos PRDs.

### Configuração

As configurações específicas do ambiente não devem ser incorporadas diretamente ao código-fonte quando representarem informações que possam variar entre ambientes ou que sejam sensíveis.

O projeto deve possuir uma configuração adequada para desenvolvimento local.

### Execução

Deve ser possível iniciar o backend e o frontend em ambiente local seguindo as instruções documentadas no projeto.

## Critérios de aceitação

* [ ] A solução possui os projetos `Domain`, `Application`, `Infrastructure` e `API`.
* [ ] O backend é compilável e executável localmente.
* [ ] O frontend é compilável e executável localmente.
* [ ] O frontend consegue realizar uma requisição ao backend.
* [ ] O backend consegue estabelecer conexão com o PostgreSQL configurado para desenvolvimento.
* [ ] As configurações necessárias para execução local estão documentadas.
* [ ] Informações sensíveis ou específicas do ambiente não estão versionadas diretamente no código-fonte.
* [ ] A estrutura criada não implementa funcionalidades financeiras que pertencem a PRDs posteriores.

## Fora de escopo

* Autenticação e gerenciamento de usuários.
* Cadastro e gerenciamento de despesas.
* Gerenciamento de cartões de crédito.
* Despesas recorrentes.
* Planejamento de compras.
* Dashboard financeiro.
* Integração com Google Sheets.
* Funcionalidades de importação ou exportação de dados.
* Regras de negócio financeiras.
* Funcionalidades de notificações.
* Implementação de funcionalidades não necessárias para a fundação definida neste PRD.

## Dependências

* ADR [0001](../adr/0001-use-clean-architecture.md) — Adotar Clean Architecture no backend.
* ADR [0002](../adr/0002-use-postgresql.md) — Adotar PostgreSQL como banco de dados principal.
* ADR [0003](../adr/0003-use-ef-core-code-first.md) — Utilizar Entity Framework Core com Code First e Migrations.
* ADR [0004](../adr/0004-use-react-vite-frontend.md)  — Adotar React com Vite no frontend.

---

[← Voltar para o índice de PRDs](README.md)
