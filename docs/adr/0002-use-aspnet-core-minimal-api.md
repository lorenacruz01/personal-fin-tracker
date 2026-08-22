# ADR 0002: Adotar ASP.NET Core Minimal API

- **Status:** Accepted
- **Data:** 2026-08-18

## Contexto

O projeto necessita de uma interface HTTP para disponibilizar os casos de uso financeiros ao frontend React. A API deve permitir autenticação, autorização, validação, tratamento consistente de erros e evolução incremental, sem introduzir estrutura desnecessária na camada de entrada.

Como o frontend será desenvolvido separadamente do backend, a API será responsável exclusivamente pela exposição HTTP e pela comunicação com a camada `Application`, mantendo as regras de negócio independentes da tecnologia utilizada na interface.

## Decisão

Será utilizado **ASP.NET Core Minimal API** como tecnologia de exposição HTTP do backend.

Os endpoints deverão permanecer finos: receber e validar a requisição, obter o contexto autenticado, acionar os casos de uso da camada `Application` e converter o resultado em uma resposta HTTP.

Regras de negócio e acesso direto à persistência não serão implementados nos endpoints.

A organização dos endpoints deverá acompanhar a evolução do projeto, podendo utilizar agrupamento por funcionalidades para manter a estrutura organizada conforme a quantidade de recursos aumentar.

## Consequências

- A camada HTTP terá uma configuração inicial simples e adequada à evolução incremental.
- Recursos do ASP.NET Core, como middleware, autenticação, autorização, validação e injeção de dependência, continuarão disponíveis.
- A separação entre a API e o frontend permitirá que as duas camadas evoluam de forma independente.
- A organização por grupos de rotas, convenções de respostas e documentação de endpoints precisará ser definida à medida que a API crescer.
- A adoção de Minimal API não impede a evolução da aplicação para uma estrutura mais complexa, caso novas necessidades arquiteturais surjam.
- Caso seja identificada uma necessidade que justifique a mudança da tecnologia ou do modelo de exposição HTTP, a decisão poderá ser reavaliada em um novo ADR.

## Alternativas consideradas

- **ASP.NET Core MVC com Controllers:** oferece convenções e uma estrutura mais prescritiva para organização dos endpoints, mas adiciona uma quantidade de estrutura que não é necessária para o estágio atual do projeto.

- **ASP.NET Core Minimal API:** escolhida por oferecer uma camada HTTP mais enxuta, mantendo os recursos necessários do ASP.NET Core e permitindo que a complexidade da aplicação permaneça concentrada nas camadas de aplicação e domínio.

[← Voltar ao guia de ADRs](README.md)
