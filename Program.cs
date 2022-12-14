using twitter_vinicius.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvcCore();
builder.Services.AddDbContext<TryitterContext>();
builder.Services.AddScoped<ITryitterContext, TryitterContext>();
builder.Services.AddScoped<ITryitterRepository, TryitterRepository>();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
