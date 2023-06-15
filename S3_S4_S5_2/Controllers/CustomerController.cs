using Microsoft.AspNetCore.Mvc;
using S3_S4_S5_2.Services;

namespace S3_S4_S5_2.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private ICustomerManager _customerManager;

    public CustomerController(ICustomerManager customerManager)
    {
        _customerManager = customerManager;
    }


    public void DoSomething()
    {
        // do something with _customerManager
    }
}