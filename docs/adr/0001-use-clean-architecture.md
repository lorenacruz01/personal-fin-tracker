# ADR 0001: Adotar Clean Architecture no backend

- **Status:** Accepted
- **Data:** 2026-08-18

## Contexto

O backend precisa evoluir funcionalidades financeiras, autenticação, autorização, persistência e integrações externas sem acoplar as regras de negócio a frameworks ou provedores específicos. O projeto também tem como objetivo praticar separação de responsabilidades, testabilidade e manutenção de longo prazo.

## Decisão

O backend será organizado segundo os princípios de Clean Architecture, inicialmente nos projetos `Domain`, `Application`, `Infrastructure` e `Api`.

- `Domain` conterá entidades, regras e conceitos centrais do domínio financeiro.
- `Application` conterá casos de uso, orquestração e abstrações necessárias.
- `Infrastructure` implementará persistência e integrações externas.
- `Api` exporá os contratos HTTP e fará a composição da aplicação.

As dependências apontarão para dentro: `Domain` não dependerá das demais camadas, e `Application` dependerá de abstrações, não de detalhes de infraestrutura.

## Consequências

- Regras de negócio podem ser testadas sem depender de banco de dados, APIs externas ou HTTP.
- Alterações de persistência ou integrações tendem a ficar isoladas em `Infrastructure`.
- A solução terá mais projetos e contratos explícitos, o que aumenta a disciplina e o custo inicial de organização.
- Abstrações só devem ser adicionadas quando suportarem uma necessidade real do domínio ou de um caso de uso.

## Alternativas consideradas
Foi considerada uma estrutura mais simples de camadas, porém optou-se
pela Clean Architecture devido ao objetivo de manter as regras de negócio
independentes de detalhes de infraestrutura e praticar separação de
responsabilidades.


[← Voltar ao guia de ADRs](README.md)
