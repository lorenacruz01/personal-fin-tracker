# Architecture Decision Records (ADRs)

Os ADRs registram decisões arquiteturais significativas, o contexto em que foram tomadas e suas consequências. O projeto adota o formato de Michael Nygard.

## Convenções

- Nomeie os arquivos como `NNNN-titulo-curto-em-kebab-case.md`.
- A numeração é sequencial e não deve ser reutilizada.
- Use um dos status: `Proposed`, `Accepted`, `Rejected`, `Superseded` ou `Deprecated`.
- Não altere uma decisão aceita para apagar seu histórico. Caso ela seja substituída, crie um novo ADR e referencie-o no anterior.
- Inclua alternativas somente quando elas forem relevantes para explicar o trade-off.

## Estrutura

Cada ADR deve conter, no mínimo: título, status, contexto, decisão e consequências. Use o [template](template.md) para novos registros.

## Índice

| ADR | Decisão | Status |
| --- | --- | --- |
| [0001](0001-use-clean-architecture.md) | Adotar Clean Architecture no backend | Accepted |
| [0002](0002-use-aspnet-core-minimal-api.md) | Adotar ASP.NET Core Minimal API | Accepted |
| [0003](0003-google-identity-provider.md) | Definir o Google como provedor de identidade inicial | Proposed |
| [0004](0004-persistence-strategy.md) | Definir a estratégia de persistência | Proposed |
