using ChatGPTAssistant.Services;

namespace ChatGPTAssistant.Tests
{
    public class OpenAIServiceTests
    {
        [Fact]
        public async Task ShouldSendPromptSuccessfully()
        {
            // Arrange
            var service = new OpenAIService();

            var prompt = "Olá IA";

            // Act
            var result =
                await service.SendMessageAsync(prompt);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task ShouldReceiveResponseSuccessfully()
        {
            // Arrange
            var service = new OpenAIService();

            var prompt = "Teste";

            // Act
            var result =
                await service.SendMessageAsync(prompt);

            // Assert
            Assert.Contains("Resposta simulada", result);
        }
    }
}