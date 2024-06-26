using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        var userInfo = new
        {
            Name = "Encisa,Aumar Tristan",
            Section = "32E3",
            Course = "BSIT",
            FunFacts = new string[]
            {
                "I'm Currently Studying At Lyceum of Alabang",
                "BSIT 3rd Year Student",
                "I'm 23 Years Old",
                "Loves To Play Online Games",
                
            }
        };

        return Ok(userInfo);
    }
}