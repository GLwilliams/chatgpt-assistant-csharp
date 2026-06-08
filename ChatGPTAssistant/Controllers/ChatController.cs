using Microsoft.AspNetCore.Mvc;
using ChatGPTAssistant.Interfaces;
using ChatGPTAssistant.Models;

namespace ChatGPTAssistant.Controllers
{
    public class ChatController : Controller
    {
        private readonly IOpenAIService _openAIService;

        public ChatController(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        [HttpPost]
        public async Task<IActionResult> Ask(ChatRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Prompt))
            {
                ViewBag.Response = "Digite uma pergunta válida.";

                return View("~/Views/Home/Index.cshtml");
            }

            var response =
                await _openAIService.SendMessageAsync(request.Prompt);

            ViewBag.Response = response;

            return View("~/Views/Home/Index.cshtml");
        }
    }
}