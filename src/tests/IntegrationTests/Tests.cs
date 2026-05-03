namespace AsyncAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AsyncAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ASYNC_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : Environment.GetEnvironmentVariable("ASYNCAI_API_KEY") is { Length: > 0 } asyncAiKeyValue
                ? asyncAiKeyValue
                : throw new AssertInconclusiveException("ASYNC_API_KEY or ASYNCAI_API_KEY environment variable is not found.");

        var client = new AsyncAIClient(apiKey);
        
        return client;
    }
}
