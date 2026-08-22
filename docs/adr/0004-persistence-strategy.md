# ADR 0004: Adotar Google Sheets como mecanismo inicial de persistência

- **Status:** Proposed
- **Data:** 2026-08-18

## Contexto

O sistema precisa persistir os dados financeiros de forma que cada usuário possa manter seus próprios dados em uma planilha armazenada em seu Google Drive.

O projeto possui caráter pessoal e de portfólio, tendo também como objetivo explorar integração com serviços externos, autenticação, autorização e arquitetura de software. Nesse contexto, a utilização de uma infraestrutura de banco de dados própria adicionaria complexidade operacional que não é necessária para o estágio inicial do projeto.

A integração com o Google Drive e Google Sheets permite utilizar o armazenamento associado à conta do próprio usuário, evitando a necessidade de manter uma infraestrutura de persistência dedicada para o projeto.

## Decisão

Propõe-se utilizar o **Google Sheets como mecanismo inicial de persistência dos dados financeiros**, com as planilhas armazenadas no Google Drive do próprio usuário.

A aplicação utilizará a **Google Sheets API** para leitura e escrita dos dados e a **Google Drive API** quando for necessário localizar, criar ou gerenciar a planilha associada ao usuário.

A integração deverá permanecer isolada na camada `Infrastructure`, sendo acessada pelas demais camadas por meio de abstrações definidas pela aplicação.

A estrutura do domínio não deverá depender diretamente de conceitos específicos do Google Sheets, como células, intervalos ou abas.

A planilha deverá ser tratada como um detalhe de infraestrutura, permitindo que uma futura substituição por outro mecanismo de persistência ocorra sem alterações relevantes nas regras de negócio.

## Consequências

- O projeto não precisará manter inicialmente uma infraestrutura própria de banco de dados.
- Os dados financeiros poderão permanecer associados à conta Google e armazenados no Google Drive do próprio usuário.
- A solução possui baixo custo operacional para o estágio inicial do projeto, desde que permaneça dentro das cotas e condições de uso dos serviços Google.
- A integração permitirá explorar autenticação, autorização e consumo de APIs externas em um cenário real.
- A aplicação ficará dependente da disponibilidade, limitações e políticas das APIs do Google.
- O Google Sheets não oferece as mesmas garantias e recursos de um banco de dados relacional para consultas complexas, relacionamentos, transações e concorrência.
- Consultas e operações sobre grandes volumes de dados poderão apresentar limitações de desempenho.
- A camada `Application` não deverá depender diretamente da API do Google Sheets.
- A integração com o Google Sheets deverá ser implementada atrás de abstrações, permitindo a substituição futura do mecanismo de persistência.
- Caso os requisitos de volume, concorrência, consultas ou consistência aumentem significativamente, a estratégia de persistência poderá ser reavaliada em um novo ADR.

## Alternativas consideradas

- **Banco de dados relacional com Entity Framework Core:** oferece suporte mais adequado a relacionamentos, consultas complexas, transações, índices e grandes volumes de dados. Entretanto, adiciona infraestrutura e gerenciamento de armazenamento que não são necessários para o estágio inicial do projeto.

- **Google Sheets API:** escolhida como mecanismo inicial por permitir que os dados sejam armazenados no Google Drive do próprio usuário, reduzindo a infraestrutura necessária e alinhando-se aos objetivos de aprendizado e portfólio do projeto.

## Trade-offs

A escolha prioriza **simplicidade operacional, baixo custo inicial e integração com o ecossistema Google** em detrimento de recursos avançados de persistência, como transações complexas, consultas altamente performáticas, relacionamentos nativos e maior capacidade de concorrência.

Essa decisão é considerada adequada ao escopo inicial do projeto, mas não pressupõe que o Google Sheets seja o mecanismo de persistência definitivo.

[← Voltar ao guia de ADRs](README.md)
