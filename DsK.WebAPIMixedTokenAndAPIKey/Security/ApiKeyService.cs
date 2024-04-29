using DsK.WebAPIMixedTokenAndAPIKey.Entity;
using Microsoft.EntityFrameworkCore;

namespace DsK.WebAPIMixedTokenAndAPIKey.Security;
public class ApiKeyService : IApiKeyService
{
    private readonly MyAppDbContext _context;

    public ApiKeyService(MyAppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> IsValidApiKeyAsync(string apiKey)
    {
        return await _context.ApiKeys.AnyAsync(k => k.Key == apiKey);
    }
}
