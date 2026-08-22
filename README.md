# Personal Fin Tracker

Aplicação de gestão de finanças pessoais voltada a oferecer uma visão clara da saúde financeira por meio do acompanhamento de despesas, gerenciamento de cartões de crédito, despesas recorrentes e planejamento de compras.

O projeto está sendo desenvolvido como portfólio pessoal e projeto de aprendizado, com ênfase em **arquitetura de software, segurança de APIs, autenticação, autorização e integração com serviços externos**.

## Objetivos do projeto

O objetivo principal do Personal Fin Tracker é oferecer uma visão centralizada das finanças pessoais, ajudando usuários a entender como seus gastos afetam o orçamento mensal e o planejamento financeiro.

A aplicação permitirá:

* Acompanhar despesas pessoais.
* Gerenciar cartões de crédito e suas despesas.
* Registrar despesas recorrentes e fixas.
* Planejar compras futuras.
* Avaliar o impacto de compras planejadas no orçamento disponível.
* Visualizar uma visão geral da saúde financeira.

## Arquitetura

O backend seguirá a **Clean Architecture**, mantendo as regras de negócio independentes da infraestrutura e de serviços externos.

O projeto será estruturado nas seguintes camadas:

* **Domain** — Entidades de negócio e regras de domínio.
* **Application** — Casos de uso da aplicação e orquestração de negócio.
* **Infrastructure** — Persistência e integrações com serviços externos.
* **API** — Interface HTTP e ponto de entrada da aplicação.

O frontend será desenvolvido separadamente com React.js.

## Tecnologias

### Backend

* .NET
* C#
* Minimal API
* Clean Architecture

### Frontend

* React.js
* TypeScript
* Vite

### Autenticação e segurança

* Google OAuth / OpenID Connect
* Autenticação
* Autorização
* Acesso seguro à API
* Autenticação baseada em token

### Dados e serviços externos

O projeto avaliará o uso da **Google Sheets API** como mecanismo inicial de persistência, mantendo os dados financeiros associados à própria conta Google do usuário. O **Entity Framework Core** poderá ser explorado futuramente caso a estratégia de persistência evolua para um banco de dados relacional.

## Segurança

Segurança é um dos principais objetivos de aprendizado deste projeto.

A API explorará conceitos como:

* Autenticação
* Autorização
* OAuth 2.0
* OpenID Connect
* Tokens de acesso
* Claims
* Autorização baseada em recurso
* Configuração segura
* Gerenciamento de segredos
* Validação de entrada da API
* CORS
* Tratamento de erros

A aplicação nunca deve depender apenas de identificadores fornecidos pelo cliente para determinar quais recursos de um usuário podem ser acessados. A identidade e as permissões do usuário devem ser obtidas do contexto autenticado.

## Funcionalidades planejadas

* [ ] Autenticação de usuário com Google
* [ ] Autorização de usuário
* [ ] Painel financeiro
* [ ] Gerenciamento de despesas
* [ ] Gerenciamento de cartões de crédito
* [ ] Gerenciamento de despesas recorrentes
* [ ] Planejamento de compras
* [ ] Análise de impacto no orçamento
* [ ] Resumos financeiros
* [ ] Integração com Google Sheets
* [ ] Testes automatizados
* [ ] Suporte a Docker
* [ ] Pipeline de CI/CD

## Objetivos de aprendizado

Este projeto também busca oferecer experiência prática com:

* Clean Architecture
* Conceitos de Domain-Driven Design
* Minimal APIs
* Desenvolvimento de APIs REST
* Autenticação e autorização
* OAuth 2.0 / OpenID Connect
* Segurança de APIs
* Entity Framework Core
* React.js
* Integração com APIs externas
* Testes automatizados
* Containerização
* CI/CD

## Status do projeto

**Em desenvolvimento.**

A arquitetura e as decisões técnicas podem evoluir à medida que o projeto avançar e novos requisitos forem identificados.

## Licença

Este projeto é licenciado sob a licença MIT.
