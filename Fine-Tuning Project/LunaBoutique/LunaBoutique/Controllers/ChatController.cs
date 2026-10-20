using LunaBoutique.Models;
using LunaBoutique.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LunaBoutique.Controllers
{
    public class ChatController : Controller
    {
        private readonly IAnthropicService _anthropicService;
        private readonly IConfiguration _configuration;

        public ChatController(IAnthropicService anthropicService, IConfiguration configuration)
        {
            _anthropicService = anthropicService;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Send([FromBody] ChatRequest request)
        {
            var apiKey = string.IsNullOrWhiteSpace(request.ApiKey)
                ? _configuration["Groq:ApiKey"]
                : request.ApiKey.Trim();

            if (string.IsNullOrWhiteSpace(apiKey))
                return Json(new { success = false, code = "missing_api_key", message = "Groq API key is required." });

            try
            {
                var response = await _anthropicService.GetResponseAsync(
                    request.Message,
                    request.History ?? new List<ChatMessage>(),
                    apiKey
                );
                return Json(new { success = true, message = response });
            }
            catch (TaskCanceledException)
            {
                return Json(new { success = false, message = "The AI request timed out. Please try again." });
            }
            catch (HttpRequestException ex) when (ex.StatusCode is HttpStatusCode.Unauthorized or HttpStatusCode.Forbidden)
            {
                return Json(new { success = false, code = "invalid_api_key", message = "The Groq API key was rejected. Please check it and try again." });
            }
            catch (HttpRequestException)
            {
                return Json(new { success = false, message = "The AI service is unavailable right now. Please try again." });
            }
            catch (Exception)
            {
                return Json(new { success = false, message = "The AI response could not be read. Please try again." });
            }
        }
    }
}