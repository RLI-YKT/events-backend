using Microsoft.EntityFrameworkCore;
using SrcASP.Models.EventModels;
using SrcASP.Services.RepositoriesInterfaces.EventRepositories;

namespace SrcASP.Repositories.EventRepositories;

public class EventRepository : BaseRepository<Event>, IEventRepository
{
    public EventRepository(DbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Event>> GetByEventType(EventType eventType)
    {
        return await _entities.Where(e => e.EventType == eventType).ToListAsync();
    }
}