using Microsoft.EntityFrameworkCore;
using SrcASP.Models.EventModels;
using SrcASP.Services.RepositoriesInterfaces.EventRepositories;

namespace SrcASP.Repositories.EventRepositories;

public class EventDateRepository : BaseRepository<EventDate>, IEventDateRepository
{
    public EventDateRepository(DbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<EventDate>> GetByEventId(int eventId)
    {
        return await _entities.Where(ed => ed.Event.Id == eventId).ToListAsync();
    }
}