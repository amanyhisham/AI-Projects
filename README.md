# 🤖 AI Applications Collection

A collection of AI-powered web applications showcasing four core approaches to building with Large Language Models: **Prompt Engineering**, **Fine-Tuning**, **Retrieval-Augmented Generation (RAG)**, and **AI Agents**.

> 🚧 This repository is a work in progress. Two projects are available now; the other two are planned and marked **Coming Soon**.

---

## 📚 Projects Overview

| # | Project | Approach | Status | Live Demo |
|---|---------|----------|--------|-----------|
| 1 | [AI Chat by Prompt Engineering](./AI%20Chat%20by%20Prompt%20Engineering) | Prompt Engineering | ✅ Available | 🔜 Coming soon |
| 2 | [Luna Boutique](./Fine-Tuning%20Project/LunaBoutique) | Fine-Tuning / AI chat assistant | ✅ Available | 🔜 Coming soon |
| 3 | RAG Project | Retrieval-Augmented Generation | 🚧 Planned | 🔜 Coming soon |
| 4 | AI Agent Project | AI Agents | 🚧 Planned | 🔜 Coming soon |

---

## 1️⃣ AI Chat by Prompt Engineering

A browser-based AI chat application built with JavaScript. It connects to the Groq API and uses the `openai/gpt-oss-120b` model for chat, with a separate vision model for image understanding.

**Highlights (from the source code):**
- Streaming chat responses
- Multiple saved conversations stored in the browser (`localStorage`)
- Custom system prompt support
- Light / dark theme
- Bookmarked messages
- Voice input (speech recognition) and text-to-speech
- File / image attachments
- Global error handling so the UI never freezes

**Tech:** HTML, CSS, JavaScript, Groq API

📂 Folder: `AI Chat by Prompt Engineering`
🌐 Live demo: _Coming soon_

---

## 2️⃣ Luna Boutique

An ASP.NET Core MVC web application for a boutique, with an integrated AI chat assistant that generates responses through the Groq API.

**Highlights (from the source code):**
- `ChatController` exposing the chat endpoint
- Service layer (`IAnthropicService` / `AnthropicService`) injected via dependency injection
- Server-side calls to Groq's chat completions endpoint, so the API key stays on the server
- Front-end chat widget in `wwwroot/js/luna-chat.js`
- API key read from configuration (`Groq:ApiKey`)

**Tech:** C#, ASP.NET Core MVC, JavaScript, Groq API

📂 Folder: `Fine-Tuning Project/LunaBoutique`
🌐 Live demo: _Coming soon_

---

## 3️⃣ RAG Project — 🔜 Coming Soon

A Retrieval-Augmented Generation application where the AI answers questions using the content of custom documents instead of relying only on the model's built-in knowledge.

📂 Folder: _Not added yet_
🌐 Live demo: _Coming soon_

---

## 4️⃣ AI Agent Project — 🔜 Coming Soon

An AI agent application where the model can plan steps and use tools to complete tasks.

📂 Folder: _Not added yet_
🌐 Live demo: _Coming soon_

---

## 🔐 Security Note

API keys are **never** stored in this repository. Each project reads its key from configuration or environment variables. See each project's README for setup details.

## 👩‍💻 Author

**Amany Hesham Salah**

## 🔗 GitHub

[github.com/amanyhisham/AI-Projects](https://github.com/amanyhisham/AI-Projects)
