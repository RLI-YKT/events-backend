using SrcASP.Repositories.EventRepositories;
using SrcASP.Services.RepositoriesInterfaces.EventRepositories;

namespace SrcASP.Repositories.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection collection)
    {
        collection.AddScoped<PostgreSqlContext>();
        collection.AddScoped<IEventRepository, EventRepository>();
        collection.AddScoped<IEventDateRepository, EventDateRepository>();
        return collection;
    }
}