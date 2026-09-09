# ADR 0006: Integração com Google Sheets como funcionalidade externa

* **Status:** Accepted
* **Data:** 2026-09-08

## Contexto

O projeto inicialmente considerava o Google Sheets como mecanismo principal para armazenamento dos dados financeiros.

Essa abordagem faria com que a aplicação dependesse do Google Drive e da autorização OAuth para operações básicas de persistência.

Após a adoção do PostgreSQL, tornou-se possível tratar os serviços Google como uma integração externa opcional.

A integração ainda é relevante para o projeto porque permite explorar OAuth 2.0, gerenciamento de tokens e comunicação com APIs externas.

## Decisão

A integração com **Google Drive / Google Sheets** será implementada em uma etapa posterior do projeto.

O Google Sheets não será utilizado como banco de dados principal.

O PostgreSQL continuará sendo a fonte de verdade dos dados.

A integração permitirá, inicialmente, funcionalidades como:

* Exportação dos dados financeiros para uma planilha;
* Atualização de uma planilha previamente vinculada;
* Sincronização, caso seja definida como requisito posterior.

A autorização para acesso aos recursos Google será realizada por meio de **OAuth 2.0**, utilizando os menores escopos necessários.

A integração deverá ser isolada na camada Infrastructure e não poderá tornar o funcionamento básico da aplicação dependente do Google.

## Consequências

### Benefícios

* Mantém a aplicação independente de serviços externos.
* Permite demonstrar experiência com OAuth 2.0.
* Permite demonstrar integração com APIs externas.
* Mantém PostgreSQL como fonte de verdade.
* Permite adicionar a funcionalidade posteriormente sem alterar o núcleo da aplicação.

### Custos e riscos

* OAuth adicionará complexidade à aplicação.
* Tokens e credenciais deverão ser armazenados e protegidos adequadamente.
* APIs externas podem sofrer indisponibilidade ou alteração.
* Sincronização poderá introduzir conflitos entre dados locais e externos.

### Ações decorrentes

* Criar abstrações para a integração Google.
* Implementar OAuth somente quando a funcionalidade for desenvolvida.
* Utilizar escopos mínimos.
* Tratar expiração e renovação de tokens.
* Tratar erros e indisponibilidade do serviço externo.
* Definir claramente a direção da sincronização antes de implementar sincronização bidirecional.

## Alternativas consideradas

### Google Sheets como banco principal

Não foi escolhido porque criaria uma dependência externa para a persistência básica da aplicação.

### Não implementar integração Google

Seria a opção mais simples, porém perderia uma oportunidade relevante de demonstrar integração com API externa e OAuth 2.0.

A integração foi mantida como funcionalidade futura.

[← Voltar para o índice de ADRs](README.md)
