# ADR 0002: Adoção do PostgreSQL como banco de dados principal

* **Status:** Accepted
* **Data:** 2026-09-08

## Contexto

O Personal Fin Tracker precisa armazenar dados persistentes da aplicação, incluindo usuários, dados financeiros e demais informações necessárias para seu funcionamento.

Inicialmente foi considerada a utilização de serviços Google, especialmente Google Sheets, como mecanismo de persistência dos dados financeiros.

Essa abordagem exigiria que a aplicação dependesse de autenticação OAuth e de serviços externos para realizar operações básicas de persistência.

Além de aumentar a dependência externa, isso dificultaria a separação entre a aplicação e a integração com o Google.

O projeto também possui como objetivo proporcionar experiência prática com bancos relacionais utilizados no mercado.

## Decisão

O **PostgreSQL será utilizado como banco de dados principal e fonte de verdade dos dados da aplicação**.

Todos os dados necessários para o funcionamento normal do sistema deverão ser persistidos no PostgreSQL.

O acesso ao banco será realizado por meio do Entity Framework Core utilizando a abordagem Code First.

A integração com Google Sheets será tratada separadamente como uma integração externa e não como mecanismo primário de persistência.

## Consequências

### Benefícios

* Banco relacional robusto e amplamente utilizado.
* Independência de serviços externos para o funcionamento básico da aplicação.
* Permite modelagem relacional adequada para os dados financeiros.
* Proporciona experiência prática com PostgreSQL.
* Facilita testes locais e ambientes reproduzíveis.
* Mantém a integração Google desacoplada da persistência principal.

### Custos e riscos

* Exige infraestrutura para execução do PostgreSQL.
* Requer gerenciamento de schema e migrations.
* Adiciona configuração de banco ao ambiente de desenvolvimento.
* Exige cuidados com backup e persistência em ambientes de produção.

### Ações decorrentes

* Utilizar PostgreSQL nos ambientes definidos pelo projeto.
* Utilizar EF Core Code First.
* Versionar migrations.
* Manter credenciais e configurações do banco fora do código-fonte.
* Isolar o acesso ao banco na camada Infrastructure.

## Alternativas consideradas

### SQLite

SQLite possui configuração extremamente simples e seria suficiente para uma aplicação pequena.

Não foi escolhido porque o projeto busca proporcionar experiência prática com PostgreSQL e cenários mais próximos de aplicações de mercado.

### Google Sheets

Foi inicialmente considerada como persistência principal.

Não foi escolhida porque transformaria uma integração externa em dependência fundamental da aplicação e exigiria OAuth para operações básicas do sistema.

### Outros bancos relacionais

MySQL e SQL Server são alternativas viáveis.

Não foram escolhidos porque o PostgreSQL atende aos requisitos do projeto e oferece uma oportunidade adequada de aprendizado.

[← Voltar para o índice de ADRs](README.md)