using SrcASP.Models.EventModels;

namespace SrcASP.Services.RepositoriesInterfaces.EventRepositories;

public interface IEventRepository : IRepository<Event>
{
    Task<IEnumerable<Event>> GetByEventType(EventType eventType);
}