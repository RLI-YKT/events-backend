using SrcASP.Models.EventModels;

namespace SrcASP.Services.RepositoriesInterfaces.EventRepositories;

public interface IEventDateRepository : IRepository<EventDate>
{
    Task<IEnumerable<EventDate>> GetByEventId(int eventId);
}