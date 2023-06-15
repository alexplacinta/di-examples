using Microsoft.Extensions.DependencyInjection;
using P1c;

// // 1 combination
// var customerController1 = new CustomerController(new DBCustomerManager());
// customerController1.DoSomething();
//
// // 2 combination
// var customerController2 = new CustomerController(new InMemoryCustomerManager());
// customerController2.DoSomething();




// 1 combination
IServiceCollection serviceCollection1 = new ServiceCollection()
    .AddSingleton<ICustomerController, CustomerController>()
    .AddSingleton<ICustomerManager, DBCustomerManager>();

IServiceProvider serviceProvider1 = serviceCollection1.BuildServiceProvider();

var customerController1 = serviceProvider1.GetRequiredService<ICustomerController>();
customerController1.DoSomething();

// 2 combination
IServiceCollection serviceCollection2 = new ServiceCollection()
    .AddSingleton<ICustomerController, CustomerController>()
    .AddSingleton<ICustomerManager, InMemoryCustomerManager>();

IServiceProvider serviceProvider2 = serviceCollection2.BuildServiceProvider();

var customerController2 = serviceProvider2.GetRequiredService<ICustomerController>();
customerController2.DoSomething();