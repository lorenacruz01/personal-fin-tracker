# PRD 0002: Autenticação e Usuários

* **Status:** Draft

## Contexto

O Personal Fin Tracker precisa identificar de forma segura o usuário que está acessando a aplicação e garantir que cada usuário tenha acesso somente aos seus próprios recursos.

A aplicação utilizará autenticação própria baseada em credenciais, conforme definido no [ADR 0005](../adr/0005-authentication-strategy.md).

Os dados necessários para a autenticação serão mantidos no PostgreSQL. As credenciais do usuário não devem ser armazenadas de forma que permitam recuperar sua senha original.

A autenticação com Google não faz parte deste requisito e será tratada posteriormente como uma integração externa.

## Objetivo

Permitir que usuários criem uma conta, realizem login e acessem os recursos protegidos da aplicação por meio de uma identidade autenticada.

## Escopo

Este PRD contempla:

* Cadastro de usuário.
* Login.
* Armazenamento seguro das credenciais.
* Emissão de token de autenticação.
* Validação do token nas requisições protegidas.
* Identificação do usuário autenticado.
* Autorização básica baseada na identidade do usuário.

## Requisitos

### Cadastro

O sistema deve permitir que um novo usuário crie uma conta utilizando suas credenciais.

O cadastro deve validar os dados obrigatórios antes de criar o usuário.

O endereço de e-mail deve identificar unicamente uma conta dentro da aplicação.

A senha fornecida pelo usuário deve ser armazenada somente em formato seguro, utilizando um mecanismo apropriado de hashing.

O sistema não deve armazenar senhas em texto puro.

### Login

O sistema deve permitir que um usuário cadastrado realize login utilizando suas credenciais.

As credenciais fornecidas devem ser validadas no backend.

Em caso de autenticação bem-sucedida, o sistema deve emitir um token que permita ao cliente realizar requisições aos recursos protegidos.

Credenciais inválidas não devem resultar na emissão de um token válido.

### Autenticação por token

Os endpoints protegidos devem exigir uma identidade autenticada.

O backend deve validar o token recebido antes de permitir o acesso ao recurso.

A identidade do usuário deve ser obtida a partir das informações confiáveis presentes no contexto de autenticação.

O cliente não deve ser responsável por determinar a identidade utilizada para autorização de um recurso.

### Autorização

Os recursos pertencentes a um usuário devem ser acessíveis somente por esse usuário, salvo quando uma regra de negócio posterior definir explicitamente outro comportamento.

O backend deve verificar a relação entre o usuário autenticado e o recurso solicitado.

Um identificador de usuário enviado pelo cliente não deve ser suficiente para conceder acesso a um recurso.

### Dados do usuário

O sistema deve manter no PostgreSQL os dados necessários para identificar e autenticar o usuário.

Os dados armazenados devem ser suficientes para suportar os requisitos de autenticação sem criar dependências desnecessárias de serviços externos.

## Regras de negócio

* Um endereço de e-mail pode estar associado a apenas uma conta.
* Um usuário deve possuir uma credencial válida para realizar login.
* Senhas nunca devem ser armazenadas em texto puro.
* Um usuário autenticado somente pode acessar recursos aos quais possui autorização.
* Recursos financeiros criados posteriormente deverão estar associados ao usuário responsável por eles.

## Segurança

A implementação deve considerar:

* Armazenamento seguro de senhas.
* Validação dos tokens no backend.
* Expiração dos tokens.
* Proteção contra acesso não autorizado.
* Validação dos dados de entrada.
* Não exposição de informações sensíveis em respostas da API.
* Não utilização de dados fornecidos pelo cliente como única fonte para decisões de autorização.

Detalhes específicos da estratégia de autenticação devem permanecer alinhados ao [ADR 0005](../adr/0005-authentication-strategy.md).

## Critérios de aceitação

### Cadastro

* [ ] Um usuário consegue criar uma conta com dados válidos.
* [ ] O sistema rejeita um cadastro utilizando um e-mail já existente.
* [ ] O sistema rejeita dados obrigatórios inválidos.
* [ ] A senha não é armazenada em texto puro.
* [ ] O usuário criado é persistido no PostgreSQL.
* [ ] A resposta da API não expõe a senha ou seu hash.

### Login

* [ ] Um usuário cadastrado consegue realizar login com credenciais válidas.
* [ ] Credenciais inválidas são rejeitadas.
* [ ] Um login bem-sucedido resulta na emissão de um token válido.
* [ ] O token possui informações suficientes para identificar o usuário autenticado.
* [ ] Um token inválido ou expirado não permite acesso a recursos protegidos.

### Autorização

* [ ] Um endpoint protegido rejeita requisições sem autenticação válida.
* [ ] Um usuário autenticado consegue acessar seus próprios recursos.
* [ ] Um usuário não consegue acessar recursos pertencentes a outro usuário.
* [ ] A autorização não depende exclusivamente de um identificador de usuário fornecido pelo cliente.

## Fora de escopo

* Login com Google.
* Google OAuth 2.0.
* OpenID Connect como mecanismo de login.
* Integração com Google Drive.
* Integração com Google Sheets.
* Recuperação de senha por e-mail.
* Autenticação multifator (MFA).
* Login social por outros provedores.
* Gerenciamento avançado de perfis.
* Controle de permissões baseado em papéis (RBAC).
* Administração de usuários.
* Sessões distribuídas.
* Funcionalidades financeiras.

## Dependências

* PRD [0001](0001-project-foundation.md) — Fundação do Projeto.
* ADR [0001](../adr/0001-use-clean-architecture.md) — Adoção de Clean Architecture.
* ADR [0002](../adr/0002-use-postgresql.md) — Adoção do PostgreSQL como banco de dados principal
* ADR [0003](../adr/0003-use-ef-core-code-first.md) —  Utilização do Entity Framework Core com Code First
* ADR [0004](../adr/0004-use-react-vite-frontend.md)  — Utilização de React com Vite no frontend
* ADR [0005](../adr/0004-use-react-vite-frontend.md)  — Estratégia inicial de autenticação

---

[← Voltar para o índice de PRDs](README.md)
