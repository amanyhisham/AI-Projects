<div align="center">

# 🤖 AI Applications Collection

**Four practical approaches to building with LLMs — Prompt Engineering, Fine-Tuning, RAG, and AI Agents.**

</div>

---

## 📚 Projects at a Glance

| # | Project | Approach | Status | Live Demo |
|---|---------|----------|--------|-----------|
| 1 | [AI Chat by Prompt Engineering](./AI%20Chat%20by%20Prompt%20Engineering) | Prompt Engineering | ✅ Available | [🔗 Open demo](https://ai-chat-demo-qflts2unc-amany-hesham.vercel.app/) |
| 2 | [Luna Boutique](./Fine-Tuning%20Project/LunaBoutique) | Fine-Tuning Project (AI shopping assistant) | ✅ Available | 🔜 Coming soon |
| 3 | RAG Project | Retrieval-Augmented Generation | 🚧 Not added yet | 🔜 Coming soon |
| 4 | AI Agent Project | AI Agents | 🚧 Not added yet | 🔜 Coming soon |

---

## 1️⃣ AI Chat by Prompt Engineering

🌐 **Live Demo:** [Open live demo](https://ai-chat-demo-qflts2unc-amany-hesham.vercel.app/)
📂 **Folder:** [`AI Chat by Prompt Engineering`](./AI%20Chat%20by%20Prompt%20Engineering)

**What it does:** A full-featured AI chat assistant where users hold conversations, customize the AI's behavior with their own system prompt, and attach documents or images for the AI to analyze. It shows how prompt design controls the quality and style of an LLM's answers.

**Key highlights**
- 💬 Multiple conversations, with rename, pin, and search (`Ctrl+K`)
- 🧠 Custom **system prompt** to steer the AI's behavior
- 📄 PDF reading (text extracted in-browser with PDF.js) and 🖼️ image understanding through a vision model
- 🎙️ Voice input and 🔊 text-to-speech
- 🔖 Bookmarked messages and chat export
- 🌗 Light / dark theme
- 🛡️ Global error handling so the UI never freezes
- 💾 Chats saved in the browser (`localStorage`)

**Tech stack**

| Layer | Technologies |
|-------|--------------|
| Frontend | HTML, CSS, Vanilla JavaScript, PDF.js |
| AI | Groq API — `openai/gpt-oss-120b` (chat) and `meta-llama/llama-4-scout-17b-16e-instruct` (vision) |
| Hosting | Vercel |

---

## 2️⃣ Luna Boutique

🌐 **Live Demo:** 🔜 Coming soon
📂 **Folder:** [`Fine-Tuning Project/LunaBoutique`](./Fine-Tuning%20Project/LunaBoutique)

**What it does:** An ASP.NET Core MVC boutique website with an AI shopping assistant named **Noor**. She answers customer questions in Egyptian Arabic about prices, delivery, returns, payment methods, and discounts, keeping replies short and structured.

**Key highlights**
- 🛍️ Boutique web app built with the **MVC pattern**
- 🤖 `ChatController` receives chat messages and returns JSON responses
- 🧩 Service layer (`IAnthropicService` / `AnthropicService`) injected through **dependency injection**
- 🗣️ Conversation history sent with every request, so Noor keeps context
- 🎯 Assistant persona and store policies defined in a system prompt
- 🔐 API key read from server configuration (`Groq:ApiKey`)
- ⚠️ Friendly error handling for timeouts, invalid keys, and service outages

**Tech stack**

| Layer | Technologies |
|-------|--------------|
| Backend | C#, ASP.NET Core MVC, `HttpClient` / `IHttpClientFactory`, Newtonsoft.Json |
| Frontend | JavaScript chat widget (`luna-chat.js`, using `fetch`) |
| AI | Groq API — `openai/gpt-oss-120b` |

---

## 3️⃣ RAG Project

🌐 **Live Demo:** 🔜 Coming soon
📂 **Folder:** _Not added yet_

**Planned:** A project where I will apply **Retrieval-Augmented Generation**, so the AI answers from the content of custom documents instead of relying only on its built-in knowledge.

---

## 4️⃣ AI Agent Project

🌐 **Live Demo:** 🔜 Coming soon
📂 **Folder:** _Not added yet_

**Planned:** A project where I will apply an **AI Agent** that can plan steps and use tools to complete tasks.

---

## 🔐 Security Note

API keys are **never** stored in this repository. Each project reads its key from configuration or environment variables.

## 👩‍💻 Author

**Amany Hesham Salah**
