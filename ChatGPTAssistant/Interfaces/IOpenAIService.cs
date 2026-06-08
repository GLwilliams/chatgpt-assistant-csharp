namespace ChatGPTAssistant.Interfaces
{
    public interface IOpenAIService
    {
        Task<string> SendMessageAsync(string prompt);
    }
}