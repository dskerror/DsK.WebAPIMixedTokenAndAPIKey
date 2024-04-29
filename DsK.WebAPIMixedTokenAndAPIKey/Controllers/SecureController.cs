using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DsK.WebAPIMixedTokenAndAPIKey.Controllers;


//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Authorize(AuthenticationSchemes = "Bearer,ApiKey")]
public class SecureController : ControllerBase
{
    public IActionResult Index()
    {
        
    }
}
