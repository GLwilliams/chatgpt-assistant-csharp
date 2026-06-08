using ChatGPTAssistant.Interfaces;

namespace ChatGPTAssistant.Services
{
    public class OpenAIService : IOpenAIService
    {
        public async Task<string> SendMessageAsync(string prompt)
        {
            try
            {
                await Task.Delay(500);

                return $"Resposta simulada da IA: {prompt}";
            }
            catch (Exception ex)
            {
                return $"Erro ao processar a mensagem: {ex.Message}";
            }
        }
    }
}