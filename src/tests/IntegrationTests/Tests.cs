namespace TencentTokenHub.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TencentTokenHubClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TOKENHUB_API_KEY") is { Length: > 0 } tokenHubKeyValue
                ? tokenHubKeyValue
                : Environment.GetEnvironmentVariable("TENCENTTOKENHUB_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("TOKENHUB_API_KEY or TENCENTTOKENHUB_API_KEY environment variable is not found.");

        var client = new TencentTokenHubClient(apiKey);
        
        return client;
    }
}
