# Architecture Decision Records (ADRs)

Os ADRs registram decisões arquiteturais significativas, o contexto em que foram tomadas e suas consequências. O projeto adota o formato de Michael Nygard.

## Convenções

- Nomeie os arquivos como `NNNN-titulo-curto-em-kebab-case.md`.
- A numeração é sequencial e não deve ser reutilizada.
- Use um dos status: `Proposed`, `Accepted`, `Rejected`, `Superseded` ou `Deprecated`.
- Não altere uma decisão aceita para apagar seu histórico. Caso ela seja substituída, crie um novo ADR e referencie-o no anterior.
- Inclua alternativas somente quando elas forem relevantes para explicar o trade-off.
- Uma decisão arquitetural deve ser registrada quando tiver impacto significativo na estrutura, tecnologias, segurança, persistência, integrações ou evolução do sistema.
- Detalhes de implementação que não representem uma decisão arquitetural relevante não precisam de um ADR.

## Estrutura

Cada ADR deve conter, no mínimo: título, status, contexto, decisão e consequências. Use o [template](template.md) para novos registros.

## Índice

| ADR | Decisão | Status |
| --- | --- | --- |
| [0001](0001-use-clean-architecture.md) | Adotar Clean Architecture no backend | Accepted |
| [0002](0002-use-postgresql.md) | Adotar PostgreSQL como banco de dados principal | Accepted |
| [0003](0003-use-ef-core-code-first.md) | Utilizar Entity Framework Core com Code First e Migrations | Accepted |
| [0004](0004-use-react-vite-frontend.md) | Adotar React com Vite no frontend | Accepted |
| [0005](0005-authentication-strategy.md) | Adotar autenticação própria baseada em credenciais e JWT | Accepted |
| [0006](0006-google-sheets-as-external-integration.md) | Utilizar Google Sheets como integração externa futura | Accepted |