using Microsoft.AspNetCore.Mvc;
using S9.Services.Implementation;
using S9.Services.Interfaces;

namespace S9.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{
    private Service1 _service1;
    private IService1 _service11;
    private IEnumerable<IService> _services;
    private IReader _reader;
    private IWriter _writer;

    public Controller(Service1 service1, IService1 service11, IEnumerable<IService> services, IReader reader, IWriter writer)
    {
        _service1 = service1;
        _service11 = service11;
        _services = services;
        _reader = reader;
        _writer = writer;
    }

}