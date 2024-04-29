using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DsK.WebAPIMixedTokenAndAPIKey.Controllers;

[Authorize(AuthenticationSchemes = "ApiKey")]
public class ApiKeyController : ControllerBase
{
    public IActionResult Index()
    {
        return View();
    }
}
