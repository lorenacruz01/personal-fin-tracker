# ADR 0003: Utilização do Entity Framework Core com Code First

* **Status:** Accepted
* **Data:** 2026-09-08

## Contexto

O projeto necessita de uma estratégia consistente para mapear o modelo da aplicação para o banco PostgreSQL e controlar a evolução do schema.

O projeto também possui como objetivo proporcionar experiência prática com Entity Framework Core e modelagem de dados orientada pelo código.

## Decisão

O projeto utilizará **Entity Framework Core seguindo a abordagem Code First**.

O modelo de persistência será definido no código e o schema do PostgreSQL será criado e evoluído utilizando **EF Core Migrations**.

As configurações de entidades deverão ser organizadas de forma explícita, utilizando `IEntityTypeConfiguration<T>` quando apropriado.

As migrations deverão ser versionadas junto ao código-fonte.

O domínio não deverá depender diretamente do Entity Framework Core.

## Consequências

### Benefícios

* Modelo de dados versionado junto ao código.
* Evolução controlada do schema.
* Integração natural com .NET.
* Facilita criação de ambientes reproduzíveis.
* Proporciona experiência prática com Code First e migrations.

### Custos e riscos

* Alterações incorretas nas migrations podem causar problemas no banco.
* O desenvolvedor precisa compreender tanto o modelo do EF Core quanto o modelo relacional.
* Migrations exigem disciplina de versionamento.

### Ações decorrentes

* Criar migrations para alterações estruturais do banco.
* Não realizar alterações manuais no schema como mecanismo normal de evolução.
* Revisar migrations antes de aplicá-las em ambientes compartilhados ou de produção.
* Manter configurações complexas de entidades separadas das classes de domínio quando apropriado.

## Alternativas consideradas

### Database First

Não foi escolhida porque o modelo será desenvolvido e evoluído junto ao código da aplicação.

### SQL manual / Dapper

Poderia oferecer maior controle sobre as queries, mas aumentaria o trabalho de persistência e reduziria a oportunidade de aprendizado com EF Core.

Não foi escolhida para a primeira versão do projeto.

[← Voltar para o índice de ADRs](README.md)
