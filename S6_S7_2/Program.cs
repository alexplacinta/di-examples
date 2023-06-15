using S6_S7_2.Services.Implementation;
using S6_S7_2.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); // will "AddScoped" all controllers

builder.Services.AddTransient<IService1, Service1>();
builder.Services.AddScoped<IService2, Service2>();
builder.Services.AddSingleton<IService3, Service3>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();