# 🔐 JWT API com Autenticação e Autorização (ASP.NET Core)

## 📌 Visão Geral

Esta API foi desenvolvida em **ASP.NET Core** e implementa autenticação utilizando **JWT (JSON Web Token)** com controle de acesso baseado em **roles (papéis)**.

O projeto segue boas práticas como:
- Uso de **IConfiguration** para leitura de dados sensíveis
- Validação de **issuer**
- Separação clara entre autenticação e autorização
- Integração com Swagger protegida por Bearer Token

---

## 🚀 Funcionalidades

- ✔️ Login com geração de token JWT
- ✔️ Validação de token com assinatura segura
- ✔️ Controle de acesso baseado em roles
- ✔️ Políticas de autorização
- ✔️ Endpoints protegidos
- ✔️ Swagger com suporte a autenticação

---

## 🔐 Fluxo de Autenticação

1. O cliente envia credenciais para `/Auth/login`
2. A API valida o usuário
3. Um token JWT é gerado contendo:
   - Identidade do usuário (sub)
   - Role (papel)
   - Identificador único (jti)
4. O cliente utiliza o token nas requisições protegidas

---

## Estrutura do Projeto

```bash
JwtApi
├── Controller
│   ├── Auth
│   │   └── AuthController.cs
│   └── Secure
│       └── SecureController.cs
└── Program.cs
