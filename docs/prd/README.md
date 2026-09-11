# Product Requirements Documents (PRDs)

Os PRDs descrevem os requisitos funcionais e não funcionais do Personal Fin Tracker, definindo **o que deve ser construído**, por que a funcionalidade existe e quais condições determinam que uma implementação está concluída.

Enquanto os ADRs registram **decisões arquiteturais**, os PRDs registram **requisitos e comportamento esperado do produto**.

Os PRDs servem como referência para o desenvolvimento manual.

## Convenções

* Nomeie os arquivos como `NNNN-titulo-curto-em-kebab-case.md`.
* A numeração é sequencial e não deve ser reutilizada.
* Um PRD deve representar uma funcionalidade, capacidade ou etapa de desenvolvimento suficientemente coesa.
* Requisitos devem ser objetivos, verificáveis e independentes de detalhes desnecessários de implementação.
* Critérios de aceitação devem permitir determinar objetivamente se um requisito foi atendido.
* Funcionalidades explicitamente fora de escopo devem ser registradas na seção correspondente.
* Decisões arquiteturais relevantes devem ser registradas nos ADRs, e não apenas no PRD.
* Quando um PRD depender de uma decisão arquitetural, faça referência ao ADR correspondente.
* Alterações significativas nos requisitos devem ser refletidas no PRD antes da implementação.

## Princípios para os PRDs

Os PRDs devem priorizar:

* Clareza sobre completude.
* Requisitos pequenos e implementáveis.
* Critérios de aceitação verificáveis.
* Escopo controlado.
* Separação entre requisito e implementação.
* Evolução incremental do produto.
* Ausência de complexidade não justificada.

Um PRD não deve prescrever uma implementação específica quando houver mais de uma solução tecnicamente adequada, exceto quando a implementação for determinada por um ADR ou quando houver uma restrição explícita do produto.

## Status

Os PRDs podem utilizar os seguintes status:

* **Draft** — Em elaboração.
* **Ready** — Requisitos definidos e prontos para implementação.
* **In Progress** — Implementação em andamento.
* **Completed** — Critérios de aceitação atendidos.
* **Superseded** — Substituído por outro PRD.
* **Deprecated** — Não é mais aplicável ao produto.

## Estrutura

Cada PRD deve conter, no mínimo:

* Título
* Status
* Contexto
* Objetivo
* Escopo
* Requisitos
* Critérios de aceitação
* Fora de escopo

Quando aplicável, também pode conter:

* Dependências
* Regras de negócio
* Considerações de segurança
* Considerações técnicas
* ADRs relacionados
* Questões em aberto

Use o [template](template.md) para criar novos PRDs.

## Índice

| PRD                                       | Funcionalidade                        | Status |
| ----------------------------------------- | ------------------------------------- | ------ |
| [0001](0001-project-foundation.md)        | Fundação do projeto                   | Ready  |
| [0002](0002-user-authentication.md)       | Autenticação e usuários               | Ready  |
| [0003](0003-expenses.md)                  | Gerenciamento de despesas             | Draft  |
| [0004](0004-credit-cards.md)              | Gerenciamento de cartões de crédito   | Draft  |
| [0005](0005-recurring-expenses.md)        | Gerenciamento de despesas recorrentes | Draft  |
| [0006](0006-purchase-planning.md)         | Planejamento de compras               | Draft  |
| [0007](0007-financial-dashboard.md)       | Dashboard financeiro                  | Draft  |
| [0008](0008-google-sheets-integration.md) | Integração com Google Sheets          | Draft  |
| [0009](0009-quality-and-delivery.md)      | Qualidade, testes e entrega           | Draft  |

---

[← Voltar para o README do projeto](../README.md)
