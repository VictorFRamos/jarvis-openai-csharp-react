using Microsoft.AspNetCore.Mvc;
using Jarvis.API.Services;
using Jarvis.API.Models;

namespace Jarvis.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly OpenAIService _service;

    public ChatController(OpenAIService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ChatRequest request)
    {
        var response = await _service.GetResponse(request.Message);
        return Ok(new { response });
    }
}