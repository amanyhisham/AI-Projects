using System.Text;
using LunaBoutique.Models;
using Newtonsoft.Json;

namespace LunaBoutique.Services
{
    public class AnthropicService : IAnthropicService
    {
        private readonly HttpClient _httpClient;

        public AnthropicService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<string> GetResponseAsync(string message, List<ChatMessage> history, string apiKey)
        {
            var messages = new List<object>
            {
 new { role = "system", content = @"انتِ نور، مساعدة الموضة في Luna Boutique. بتردي بالعامية المصرية دايماً.

قواعد مهمة:
- لما حد يقول بكام أو السعر أو كام يعني بيسأل عن السعر
- متردي بس على اللي اتسأل عنه
- ردك قصير ومنظم دايماً
- كل نقطة في سطر لوحدها تبدأ بـ •
- سطر فاضل بين كل جزء
- سؤال واحد بس في الآخر
- متقوليش السعر غير لما يسألوا عنه صراحة

شكل الرد:
جملة واحدة بس في الأول

- نقطة 1
- نقطة 2
- نقطة 3

سؤال واحد؟

معلومات المتجر:
- أسعار من 320 لـ 2800 جنيه
- توصيل 2-5 أيام ومجاني فوق 500 جنيه
- إرجاع 14 يوم
- دفع: كاش أو كارت أو InstaPay
- خصم 20% على الكوليكشن الجديد" }     };

            foreach (var h in history)
                messages.Add(new { role = h.Role, content = h.Content });

            messages.Add(new { role = "user", content = message });

            var requestBody = new
            {
                model = "openai/gpt-oss-120b",
                messages = messages,
                max_tokens = 500
            };

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using var request = new HttpRequestMessage(HttpMethod.Post, "https://api.groq.com/openai/v1/chat/completions")
            {
                Content = content
            };
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

            using var response = await _httpClient.SendAsync(request);

            var responseString = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            dynamic result = JsonConvert.DeserializeObject(responseString)!;
            var responseMessage = result?.choices?[0]?.message?.content?.ToString();
            if (string.IsNullOrWhiteSpace(responseMessage))
                throw new InvalidOperationException("Groq returned an empty response.");

            return responseMessage;
        }
    }
}