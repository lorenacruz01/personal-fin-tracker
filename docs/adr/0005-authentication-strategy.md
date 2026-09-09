# ADR 0005: Estratégia inicial de autenticação

* **Status:** Accepted
* **Data:** 2026-09-08

## Contexto

A aplicação precisa identificar usuários e controlar o acesso aos seus próprios recursos.

Inicialmente foi considerada a utilização do Google como provedor de identidade e a utilização do Google Sheets como mecanismo de persistência.

Após a definição do PostgreSQL como fonte de verdade, a aplicação não precisa depender de um provedor externo para realizar a autenticação básica.

O projeto também possui como objetivo de aprendizado explorar autenticação, autorização, tokens, claims e segurança de APIs.

## Decisão

A primeira versão da aplicação utilizará **autenticação própria baseada em credenciais**, com armazenamento dos dados necessários no PostgreSQL.

A API utilizará **tokens JWT** para representar a identidade autenticada nas requisições.

A autorização será realizada no backend com base na identidade e nas permissões presentes no contexto autenticado.

A senha do usuário nunca deverá ser armazenada em texto puro.

A integração com Google OAuth 2.0 / OpenID Connect será implementada posteriormente como uma funcionalidade independente da autenticação básica.

## Consequências

### Benefícios

* A aplicação não depende de um provedor externo para autenticação básica.
* Permite estudar o fluxo completo de autenticação e autorização.
* PostgreSQL permanece como fonte de verdade da aplicação.
* OAuth pode ser estudado posteriormente em um contexto real de integração externa.

### Custos e riscos

* A aplicação passa a ser responsável pela implementação e proteção do fluxo de autenticação.
* Senhas e credenciais exigem tratamento seguro.
* JWT exige cuidados com expiração, armazenamento e validação.
* Uma implementação incorreta pode introduzir vulnerabilidades de segurança.

### Ações decorrentes

* Armazenar somente hashes seguros das senhas.
* Definir política de expiração dos tokens.
* Validar assinatura, issuer, audience e validade dos tokens.
* Implementar autorização no backend.
* Não confiar em identificadores de usuário enviados pelo cliente.
* Manter segredos fora do código-fonte.

## Alternativas consideradas

### Google OAuth / OpenID Connect como autenticação principal

Não foi escolhido para a primeira versão porque adicionaria uma dependência externa ao fluxo básico de autenticação.

Será utilizado posteriormente para a integração com serviços Google.

### ASP.NET Core Identity

É uma alternativa válida para gerenciamento de identidade e será considerada durante a implementação da autenticação.

A escolha entre uma implementação baseada diretamente nas capacidades do ASP.NET Core e a utilização do ASP.NET Core Identity deverá ser detalhada em decisão técnica específica caso necessário.

[← Voltar para o índice de ADRs](README.md)
