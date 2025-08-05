// File: Infrastructure/MyPortfolio.Infrastructure/Persistence/MongoDbSettings.cs
namespace MyPortfolio.Infrastructure.Persistence;

public class MongoDbSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
}