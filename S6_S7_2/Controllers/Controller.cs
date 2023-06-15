using Microsoft.AspNetCore.Mvc;
using S6_S7_2.Services.Interfaces;

namespace S6_S7_2.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{
    private readonly IService1 _service1A;
    private readonly IService1 _service1B;
    
    private readonly IService2 _service2A;
    private readonly IService2 _service2B;
    
    private readonly IService3 _service3;


    public Controller(IService1 service1A, IService1 service1B, IService2 service2A, IService2 service2B, IService3 service3)
    {
        _service1A = service1A;
        _service1B = service1B;
        _service2A = service2A;
        _service2B = service2B;
        _service3 = service3;
    }

    public string Id { get; } = Guid.NewGuid().ToString();

    public void Get()
    {
        Console.WriteLine("====================================== NEW REQUEST ============================================");
        Console.WriteLine($"Controller(SCOPED by default): {Id}");
        Console.WriteLine();
        Console.WriteLine($"TRANSIENT:");
        Console.WriteLine($"Service1A(Transient): {_service1A.Id}");
        Console.WriteLine($"Service1B(Transient): {_service1B.Id}");
        Console.WriteLine();
        Console.WriteLine($"SCOPED:");
        Console.WriteLine($"Service2A(Scoped): {_service2A.Id}");
        Console.WriteLine($"Service2B(Scoped): {_service2B.Id}");
        Console.WriteLine();
        Console.WriteLine($"SINGLETON:");
        Console.WriteLine($"Service3B(Singleton): {_service3.Id}");
        Console.WriteLine();
    }
}