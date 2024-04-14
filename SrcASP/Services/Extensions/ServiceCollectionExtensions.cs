using System.Runtime.CompilerServices;
using SrcASP.Services.Builders.Implementations.EventModelsBuilders;
using SrcASP.Services.Builders.Interfaces.EventModelsBuilders;
using SrcASP.Services.Dto.Converters;

namespace SrcASP.Services.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection collection)
    {
        collection.AddScoped<IEventBuilder, EventBuilder>();
        collection.AddScoped<EventDateConverter>();
        collection.AddScoped<EventConverter>();
        return collection;
    }
}