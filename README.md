# 🤖 Jarvis - Assistente Virtual (.NET + React)

Um assistente virtual completo inspirado no Jarvis, com backend em C# (.NET) e frontend em React.  
O sistema permite interação em linguagem natural com IA, servindo como base para automação, produtividade e aplicações inteligentes.

---

## 🚀 Visão Geral

Este projeto foi desenvolvido com foco em:

- Separação clara entre backend e frontend  
- Arquitetura moderna (API + SPA)  
- Facilidade de expansão (microserviços, integrações, etc)  
- Uso de Inteligência Artificial via OpenAI  

---

## 🧠 Funcionalidades

- 💬 Chat com IA em tempo real  
- 🧠 Assistente estilo Jarvis  
- 🔗 Integração com API OpenAI  
- ⚙️ Backend robusto com .NET  
- 🌐 Interface web com React  
- 📡 Comunicação via HTTP (REST API)  

---

## 📁 Estrutura do Projeto
```
jarvis-openai-csharp-react/
│   .gitignore
│   jarvis-openai-csharp-react.sln
│   LICENSE
│   README.md
│
├───backend
│   └───Jarvis.API
│       │   appsettings.Development.json
│       │   appsettings.json
│       │   Jarvis.API.csproj
│       │   Program.cs
│       ├───bin
│       │   └───Debug
│       │       └───net10.0
│       ├───Controllers
│       │       ChatController.cs
│       ├───Models
│       │       ChatRequest.cs
│       ├───Properties
│       │       launchSettings.json
│       │
│       └───Services
│               OpenAIService.cs
│
└───frontend
    └───jarvis-project
        │   .gitignore
        │   eslint.config.js
        │   index.html
        │   package-lock.json
        │   package.json
        │   README.md
        │   vite.config.js
        ├───public
        │       favicon.svg
        │       icons.svg
        └───src
            │   App.css
            │   App.jsx
            │   index.css
            │   main.jsx
            └───assets
                    hero.png
                    react.svg
                    vite.svg
```
---

## ⚙️ Tecnologias Utilizadas

### Backend
- C#  
- .NET 8  
- ASP.NET Core Web API  
- Swagger  

### Frontend
- React  
- Vite  
- Axios  

### Integrações
- OpenAI API  

---

## 🔐 Configuração

### Backend (.NET)

1. Acesse a pasta:
```
cd backend/Jarvis.API  
```
2. Configure o arquivo `appsettings.json`:
```
{
  "OpenAI": {
    "ApiKey": "SUA_CHAVE_AQUI"
  }
}
```
3. Execute o projeto:
```
dotnet run  
```
4. Acesse o Swagger:
```
http://localhost:5000/swagger  
```
---

### Frontend (React)

1. Acesse a pasta:

```
cd frontend
cd jarvis-project
```
2. Instale as dependências:
```
npm install  
```
3. Execute o projeto:
```
npm run dev  
```
4. Acesse no navegador:
```
http://localhost:5173  
```
---

## 💬 Como usar

- Digite uma mensagem no input  
- O frontend envia para a API  
- O backend consulta a OpenAI  
- A resposta é exibida no chat  

---

## 🔄 Fluxo da aplicação

Usuário → React → API .NET → OpenAI → API → React → Usuário  

---

## 🚀 Melhorias futuras

- 🧠 Memória persistente (banco de dados)  
- 🔐 Autenticação JWT  
- 📋 Sistema de tarefas (CRUD)  
- 🔔 Notificações em tempo real  
- ⚡ WebSockets (SignalR)  
- 🎙 Suporte a voz  
- 📱 Integração com WhatsApp / Telegram  
- 🌐 Deploy em nuvem (AWS / Azure)  

---

## 💡 Possibilidades de uso

- Assistente pessoal  
- Chatbot corporativo  
- Sistema de atendimento  
- Automação de tarefas  
- Base para SaaS  

---

## 📄 Licença

Este projeto é livre para uso e modificação.

---

## ⭐ Contribuição

Se este projeto te ajudou, considere dar uma estrela ⭐  
e contribuir com melhorias!

---
