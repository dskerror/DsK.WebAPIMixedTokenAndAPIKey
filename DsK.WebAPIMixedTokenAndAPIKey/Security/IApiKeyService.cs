namespace DsK.WebAPIMixedTokenAndAPIKey.Security;
public interface IApiKeyService
{
    Task<bool> IsValidApiKeyAsync(string apiKey);
}
