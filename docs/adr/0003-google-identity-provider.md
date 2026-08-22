# ADR 0003: Definir o Google como provedor de identidade e integração com Drive e Sheets

- **Status:** Proposed
- **Data:** 2026-08-18

## Contexto

O projeto precisa identificar os usuários de forma confiável e permitir que os dados financeiros sejam armazenados em uma planilha localizada no Google Drive do próprio usuário.

Para isso, a aplicação precisa tanto autenticar o usuário quanto obter, mediante autorização, acesso aos recursos do Google necessários para manipular a planilha.

A utilização do ecossistema Google permite centralizar essas necessidades, utilizando o Google como provedor de identidade e as APIs do Google Drive e Google Sheets para acesso aos recursos do usuário.

## Decisão

Propõe-se utilizar o **Google como provedor de identidade inicial**, utilizando **OpenID Connect (OIDC)** sobre OAuth 2.0 para autenticação dos usuários.

A aplicação também utilizará as APIs do **Google Drive** e do **Google Sheets** para localizar, criar e manipular a planilha associada ao usuário, mediante as permissões concedidas durante o processo de autorização.

O backend conduzirá o fluxo de autorização com o Google e validará as respostas de autenticação OIDC, incluindo emissor, audiência, expiração e `nonce`. Tokens de acesso emitidos para as APIs Google não serão aceitos como credenciais da API. Após o login, a aplicação estabelecerá uma sessão segura ou emitirá um token próprio para autorizar chamadas ao backend.

O frontend não será considerado fonte de verdade para a identidade ou autorização do usuário.

Os recursos financeiros deverão ser associados ao identificador estável do usuário autenticado, enquanto as informações necessárias para acessar a planilha deverão ser mantidas de forma segura.

## Consequências

- O usuário poderá utilizar sua conta Google para autenticar-se na aplicação.
- A aplicação poderá acessar a planilha armazenada no Google Drive do usuário, desde que as permissões necessárias tenham sido concedidas.
- A aplicação não precisará implementar inicialmente um sistema próprio de gerenciamento de credenciais e senhas.
- A aplicação ficará dependente da disponibilidade e das políticas dos serviços Google utilizados.
- A adoção do ecossistema Google cria um acoplamento inicial ao provedor, fazendo com que a experiência de autenticação e armazenamento seja inicialmente restrita a usuários que utilizam uma conta Google.
- Os tokens, credenciais e demais informações sensíveis relacionadas à integração deverão ser armazenados de forma segura e permanecer fora do controle de versão.
- Os escopos de acesso solicitados ao usuário deverão ser definidos de acordo com as operações realmente necessárias.
- A integração com o provedor de armazenamento deverá permanecer isolada atrás de abstrações, permitindo a inclusão futura de outros provedores sem alterar as regras de negócio.
- A escolha reduz a complexidade inicial e permite uma integração direta entre identidade e armazenamento, mas limita inicialmente a aplicação ao ecossistema Google.
- O fluxo de autenticação, renovação das autorizações, armazenamento das informações de integração e tratamento da revogação de acesso deverão ser definidos antes da implementação.
- A decisão poderá ser reavaliada caso o projeto passe a exigir suporte a outros provedores de identidade ou armazenamento.

## Alternativas consideradas

- **Autenticação própria e armazenamento local:** permitiria maior controle sobre autenticação e persistência, mas exigiria a implementação e manutenção de gerenciamento de credenciais e não atenderia diretamente à necessidade de acessar os recursos do Google Drive do usuário.

- **Outro provedor de identidade e armazenamento independente:** poderia separar autenticação e armazenamento, mas adicionaria complexidade ao projeto e não aproveitaria diretamente o ecossistema Google que será utilizado para armazenar os dados financeiros.

- **Google como provedor de identidade e integração com Drive/Sheets:** escolhida como abordagem inicial por atender simultaneamente à identificação do usuário e à necessidade de acessar uma planilha armazenada no Google Drive do próprio usuário.

[← Voltar ao guia de ADRs](README.md)
