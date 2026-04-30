using Microsoft.AspNetCore.Mvc;

namespace SkillBridge.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class JobController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello from JobController!";
    }
}