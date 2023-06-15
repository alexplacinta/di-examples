using Microsoft.AspNetCore.Mvc;

namespace S11.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{

    public void Get()
    {
        Console.WriteLine("Endpoint");
    }
}