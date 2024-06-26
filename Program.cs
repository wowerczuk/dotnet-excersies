using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Programowanie;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.MapGet("/products", () =>
{
    
})
.WithName("GetProducts")
.WithOpenApi();


app.MapPost("/products", () =>
{

})
.WithName("PostProducts")
.WithOpenApi();

app.Run();

