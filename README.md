<div align="center">

# 🧠 AI Applications Collection

### Practical, production-minded applications built on Large Language Models

Each project in this collection explores a different way of building with AI:<br>
**Prompt Engineering**, **Fine-Tuning**, **Retrieval-Augmented Generation (RAG)**, and **AI Agents**.

</div>

---

## 📚 Projects at a Glance

| # | Project | Approach | Status | Live Demo |
|---|---------|----------|--------|-----------|
| 1 | AI Chat by Prompt Engineering | Prompt Engineering | ✅ Live | [🔗 Open demo](https://ai-chat-demo-qflts2unc-amany-hesham.vercel.app/) |
| 2 | Luna Boutique | AI shopping assistant (Fine-Tuning Project) | ✅ Live | [🔗 Open demo](http://luna-boutique-amany.runasp.net/) |
| 3 | RAG Project | Retrieval-Augmented Generation | 🚧 Coming soon | — |
| 4 | AI Agent Project | AI Agents | 🚧 Coming soon | — |

---

## 1️⃣ AI Chat by Prompt Engineering

| | |
|---|---|
| 🌐 **Live Demo** | [Open the application](https://ai-chat-demo-qflts2unc-amany-hesham.vercel.app/) |
| 📂 **Folder** | `AI Chat by Prompt Engineering` |
| ☁️ **Hosting** | Vercel |

**What it is:** A full-featured AI chat website where users talk to an AI assistant, shape its behavior with their own system prompt, and attach PDFs or images for the AI to read and analyze. It demonstrates how prompt design controls the quality, tone, and usefulness of an LLM's answers.

**Key features**
- 💬 Multiple conversations with rename, pin, and search (`Ctrl+K`)
- 🧠 Custom **system prompt** to steer the AI's behavior
- 📄 PDF reading (text extracted in the browser with PDF.js)
- 🖼️ Image understanding through a vision model
- 🎙️ Voice input and 🔊 text-to-speech
- 🔖 Bookmarked messages and chat export
- 🌗 Light and dark themes
- 🛡️ Global error handling so the interface never freezes
- 💾 Conversations saved in the browser (`localStorage`)

**Technologies**

| Layer | Stack |
|-------|-------|
| Frontend | HTML, CSS, Vanilla JavaScript, PDF.js |
| AI | Groq API — `openai/gpt-oss-120b` (chat), `meta-llama/llama-4-scout-17b-16e-instruct` (vision) |
| Hosting | Vercel |

---

## 2️⃣ Luna Boutique

| | |
|---|---|
| 🌐 **Live Demo** | [Open the application](http://luna-boutique-amany.runasp.net/) |
| 📂 **Folder** | `Fine-Tuning Project/LunaBoutique` |
| ☁️ **Hosting** | MonsterASP.NET (free ASP.NET hosting) |

**What it is:** An ASP.NET Core MVC boutique website with a built-in AI shopping assistant named **Noor**. She answers customers in Egyptian Arabic about prices, delivery, returns, payment methods, and offers, with short and well-structured replies — reducing the need for manual customer support.

**Key features**
- 🛍️ Boutique web application built on the **MVC pattern**
- 🤖 AI chat assistant with a defined persona and store policies
- 🗣️ Conversation history sent with each request so Noor keeps context
- 🧩 Clean service layer (`IAnthropicService` / `AnthropicService`) wired through **dependency injection**
- 🔐 Groq API key read from server configuration (`Groq:ApiKey`), never hard-coded
- ⚠️ Friendly handling of timeouts, invalid keys, and service outages

**Technologies**

| Layer | Stack |
|-------|-------|
| Backend | C#, ASP.NET Core MVC, `IHttpClientFactory`, Newtonsoft.Json |
| Frontend | JavaScript chat widget (`luna-chat.js`) using `fetch` |
| AI | Groq API — `openai/gpt-oss-120b` |
| Hosting | MonsterASP.NET |

---

## 3️⃣ RAG Project — 🚧 Coming Soon

A project that will be added to this repository to apply **Retrieval-Augmented Generation**, where the AI answers from the content of custom documents instead of relying only on its built-in knowledge.

---

## 4️⃣ AI Agent Project — 🚧 Coming Soon

A project that will be added to this repository to apply an **AI Agent** that can plan steps and use tools to complete tasks.

---

## 🔐 Security Note

API keys are **never** stored in this repository. Each project reads its key from configuration or environment variables.

---

<div align="center">

## ✍️ Author

# *Amany Hesham Salah*

**Junior Software Engineer · AI Application Developer**

</div>
