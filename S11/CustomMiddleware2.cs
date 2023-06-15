namespace S11;

public class CustomMiddleware2
{
    private readonly RequestDelegate next;

    public CustomMiddleware2(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine("CustomMiddleware2->BEFORE");
        
        await next.Invoke(context);
        
        Console.WriteLine("CustomMiddleware2->AFTER");
    }
}