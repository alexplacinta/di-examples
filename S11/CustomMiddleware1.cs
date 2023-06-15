namespace S11;

public class CustomMiddleware1
{
    private readonly RequestDelegate next;

    public CustomMiddleware1(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine("CustomMiddleware1->BEFORE");
        
        await next.Invoke(context);
        
        Console.WriteLine("CustomMiddleware1->AFTER");
    }
}