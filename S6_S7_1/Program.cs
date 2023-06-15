using Microsoft.Extensions.DependencyInjection;
using S6_S7_1.Services.Implementation;
using S6_S7_1.Services.Interfaces;

IServiceCollection serviceCollection = new ServiceCollection()
    .AddTransient<IService1, Service1>()
    .AddScoped<IService2, Service2>()
    .AddSingleton<IService3, Service3>();

IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

Console.WriteLine("TRANSIENT:");
Console.WriteLine(serviceProvider.GetRequiredService<IService1>().Id);
Console.WriteLine(serviceProvider.GetRequiredService<IService1>().Id);
Console.WriteLine(serviceProvider.GetRequiredService<IService1>().Id);

Console.WriteLine(); // used in Requests
Console.WriteLine("SCOPED1:");
var scope1 = serviceProvider.CreateScope();
Console.WriteLine(scope1.ServiceProvider.GetRequiredService<IService2>().Id);
Console.WriteLine(scope1.ServiceProvider.GetRequiredService<IService2>().Id);
Console.WriteLine(scope1.ServiceProvider.GetRequiredService<IService2>().Id);
Console.WriteLine("SCOPED2:");
var scope2 = serviceProvider.CreateScope();
Console.WriteLine(scope2.ServiceProvider.GetRequiredService<IService2>().Id);
Console.WriteLine(scope2.ServiceProvider.GetRequiredService<IService2>().Id);
Console.WriteLine(scope2.ServiceProvider.GetRequiredService<IService2>().Id);

Console.WriteLine();
Console.WriteLine("SINGLETON:");
Console.WriteLine(serviceProvider.GetRequiredService<IService3>().Id);
Console.WriteLine(serviceProvider.GetRequiredService<IService3>().Id);
Console.WriteLine(serviceProvider.GetRequiredService<IService3>().Id);