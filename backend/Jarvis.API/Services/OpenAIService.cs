using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Jarvis.API.Services;

public class OpenAIService
{
    private readonly HttpClient _http;
    private readonly IConfiguration _config;

    public OpenAIService(HttpClient http, IConfiguration config)
    {
        _http = http;
        _config = config;
    }

    public async Task<string> GetResponse(string message)
    {
        var apiKey = _config["OpenAI:ApiKey"];

        _http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", apiKey);

        var body = new
        {
            model = "gpt-4.1-mini",
            messages = new[]
            {
                new { role = "system", content = "Você é um assistente pessoal estilo Jarvis." },
                new { role = "user", content = message }
            }
        };

        var content = new StringContent(
            JsonSerializer.Serialize(body),
            Encoding.UTF8,
            "application/json"
        );

        var response = await _http.PostAsync("https://api.openai.com/v1/chat/completions", content);

        var json = await response.Content.ReadAsStringAsync();

        using var doc = JsonDocument.Parse(json);
        return doc.RootElement
                  .GetProperty("choices")[0]
                  .GetProperty("message")
                  .GetProperty("content")
                  .GetString()!;
    }
}