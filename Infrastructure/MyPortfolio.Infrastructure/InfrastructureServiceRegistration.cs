// File: Infrastructure/MyPortfolio.Infrastructure/InfrastructureServiceRegistration.cs
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyPortfolio.Application.Contracts.Persistence;
using MyPortfolio.Infrastructure.Persistence;
using MyPortfolio.Infrastructure.Persistence.Repositories; // We will create this next

namespace MyPortfolio.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));
        services.AddSingleton<IProjectsRepository, ProjectsRepository>();

        return services;
    }
}