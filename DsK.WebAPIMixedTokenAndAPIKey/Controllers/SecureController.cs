﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DsK.WebAPIMixedTokenAndAPIKey.Controllers;


[ApiController]
[Route("[controller]")]
//[Authorize(AuthenticationSchemes = "Bearer,ApiKey")]
[Authorize(AuthenticationSchemes = "Bearer,ApiKey")]
public class SecureController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "TEST";
    }
}