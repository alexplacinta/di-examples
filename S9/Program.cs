using S9.Services.Implementation;
using S9.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Type/Interface
builder.Services.AddScoped<Service1>();
builder.Services.AddScoped<IService1, Service1>();

// Multi implementation
builder.Services.AddScoped<IService, Service1>();
builder.Services.AddScoped<IService, Service2>();
builder.Services.AddScoped<IService, Service3>();

// Multi interface
builder.Services.AddScoped<IReader, ReaderWriter>();
builder.Services.AddScoped<IWriter, ReaderWriter>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();