# ADR 0001: Adoção de Clean Architecture

* **Status:** Accepted
* **Data:** 2026-09-08

## Contexto

O Personal Fin Tracker será desenvolvido como uma aplicação full stack com regras de negócio, persistência de dados, interface HTTP e integrações com serviços externos.

O projeto possui também um objetivo de aprendizado e portfólio, buscando demonstrar conhecimento em arquitetura de software e boas práticas de desenvolvimento.

É necessário evitar que as regras de negócio fiquem diretamente acopladas ao framework web, ao banco de dados ou a serviços externos, permitindo que essas preocupações possam evoluir de forma independente.

## Decisão

O backend adotará os princípios da **Clean Architecture**, organizando a aplicação nas seguintes camadas:

* **Domain** — entidades, value objects e regras de negócio;
* **Application** — casos de uso, contratos e orquestração;
* **Infrastructure** — persistência e integrações externas;
* **API** — interface HTTP e composição da aplicação.

As dependências deverão apontar para dentro da aplicação, mantendo o domínio independente de detalhes de infraestrutura.

A infraestrutura poderá implementar abstrações definidas pelas camadas internas quando necessário.

A arquitetura não deverá ser utilizada como justificativa para introduzir abstrações ou complexidade sem uma necessidade concreta.

## Consequências

### Benefícios

* Separação clara de responsabilidades.
* Maior independência das regras de negócio em relação à infraestrutura.
* Facilita testes unitários das regras de negócio.
* Facilita a substituição ou evolução de componentes externos.
* Demonstra conhecimento de arquitetura de software relevante para o objetivo do projeto.

### Custos e riscos

* Maior quantidade de projetos, interfaces e abstrações.
* Possível aumento de complexidade para funcionalidades simples.
* Risco de overengineering caso os princípios sejam aplicados de forma excessivamente rígida.

### Ações decorrentes

* Manter o domínio independente de frameworks e infraestrutura.
* Centralizar casos de uso na camada Application.
* Isolar persistência e integrações na Infrastructure.
* Revisar novas dependências para garantir que respeitem a direção arquitetural.

## Alternativas consideradas

### Arquitetura em camadas tradicional

Poderia simplificar a estrutura inicial, mas ofereceria menor isolamento entre regras de negócio e infraestrutura.

Não foi escolhida porque o projeto possui como objetivo explícito demonstrar conhecimentos de arquitetura e separação de responsabilidades.

### Monólito sem separação arquitetural

Seria a alternativa mais simples, porém dificultaria a evolução e o teste isolado das regras de negócio.

Não foi escolhida.


[← Voltar para o índice de ADRs](README.md)