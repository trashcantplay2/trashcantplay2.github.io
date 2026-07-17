using System.Net.Http;
using System.Threading.Tasks;

namespace myforfeit;

public class TelegramService
{
    private readonly HttpClient _httpClient;

    public TelegramService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> SendMessageAsync(string botToken, string chatId, string message)
    {
        if (string.IsNullOrWhiteSpace(botToken) || string.IsNullOrWhiteSpace(chatId))
            return false;

        var url = $"https://api.telegram.org/bot{botToken}/sendMessage?chat_id={chatId}&text={Uri.EscapeDataString(message)}";
        
        try
        {
            var response = await _httpClient.GetAsync(url);
            return response.IsSuccessStatusCode;
        }
        catch
        {
            return false;
        }
    }
}
