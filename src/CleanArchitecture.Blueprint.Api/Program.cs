using CleanArchitecture.Blueprint.Api.Brokers.LoggingBroker;
using CleanArchitecture.Blueprint.Api.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<ILoggingBroker, LoggingBroker>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("BlueprintDb"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

public partial class Program
{
}
