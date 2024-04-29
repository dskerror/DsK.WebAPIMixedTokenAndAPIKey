namespace DsK.WebAPIMixedTokenAndAPIKey.Security;
public class ApiKeyService : IApiKeyService
{
    private readonly YourDbContext _context;

    public ApiKeyService(YourDbContext context)
    {
        _context = context;
    }

    public async Task<bool> IsValidApiKeyAsync(string apiKey)
    {
        return await _context.ApiKeys.AnyAsync(k => k.Key == apiKey && k.IsActive);
    }
}
