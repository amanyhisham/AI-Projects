using LunaBoutique.Models;

namespace LunaBoutique.Services
{
    public interface IAnthropicService
    {
        Task<string> GetResponseAsync(string message, List<ChatMessage> history, string apiKey);
    }
}