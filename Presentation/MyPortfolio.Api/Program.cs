// File: Presentation/MyPortfolio.Api/Program.cs
using MyPortfolio.Infrastructure; // <-- Important: Add this using statement

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// This single line calls our extension method and sets up MongoDB and the repository
builder.Services.AddInfrastructureServices(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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