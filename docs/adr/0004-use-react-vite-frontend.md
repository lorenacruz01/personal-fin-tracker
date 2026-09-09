# ADR 0004: Utilização de React com Vite no frontend

* **Status:** Accepted
* **Data:** 2026-09-08

## Contexto

O frontend do Personal Fin Tracker será uma aplicação web interativa, principalmente composta por telas autenticadas, dashboards, formulários, listagens e componentes de gerenciamento financeiro.

O backend será disponibilizado separadamente por meio de uma API ASP.NET Core.

Não há, no escopo inicial, necessidade de Server-Side Rendering ou de uma aplicação full stack JavaScript.

## Decisão

O frontend será desenvolvido utilizando:

* React;
* TypeScript;
* Vite;
* Tailwind CSS.

A aplicação será estruturada como uma SPA, consumindo a API REST do backend.

Não será utilizado DaisyUI ou outro framework de componentes inicialmente.

Os componentes de interface deverão ser construídos de forma reutilizável quando houver necessidade.

## Consequências

### Benefícios

* Arquitetura frontend simples e adequada ao produto.
* Separação clara entre frontend e backend.
* Desenvolvimento direto com React.
* Vite oferece um ambiente de desenvolvimento e build adequado para uma SPA.
* TypeScript fornece tipagem estática.
* Tailwind reduz o esforço de estilização sem impor uma biblioteca de componentes completa.

### Custos e riscos

* Recursos de SSR disponíveis em frameworks como Next.js não estarão disponíveis.
* Algumas funcionalidades precisarão ser implementadas ou escolhidas explicitamente no frontend.
* A equipe será responsável pela definição e manutenção dos componentes visuais.

### Ações decorrentes

* Utilizar React Router ou solução equivalente para roteamento.
* Implementar comunicação com a API por HTTP.
* Separar componentes de apresentação de regras de negócio quando apropriado.
* Manter uma estrutura de componentes reutilizáveis.

## Alternativas consideradas

### Next.js

Não foi escolhido porque o backend já será fornecido por uma API .NET separada e o produto não possui, inicialmente, uma necessidade significativa de SSR, SSG ou SEO.

### DaisyUI

Não foi adotado inicialmente porque o projeto busca manter controle sobre seus componentes visuais e evitar dependências adicionais que não sejam necessárias.

[← Voltar para o índice de ADRs](README.md)
