namespace P1c;

public interface ICustomerController
{
    void DoSomething();
}

public class CustomerController : ICustomerController
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