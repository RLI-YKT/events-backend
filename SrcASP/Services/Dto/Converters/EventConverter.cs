using SrcASP.Models.EventModels;
using SrcASP.Services.Dto.Models;

namespace SrcASP.Services.Dto.Converters;

public class EventConverter
{
    private EventDateConverter _eventDateConverter;
    
    public EventConverter(EventDateConverter eventDateConverter)
    {
        ArgumentNullException.ThrowIfNull(eventDateConverter);
        _eventDateConverter = eventDateConverter;
    }
    
    public EventDto ConvertToDto(Event entity, IEnumerable<EventDate> dates)
    {
        ArgumentNullException.ThrowIfNull(entity);
        ArgumentNullException.ThrowIfNull(dates);
        return new EventDto
        {
            Id = entity.Id,
            EventType = entity.EventType.ToString(),
            Name = entity.Name,
            Description = entity.Description,
            Number = entity.Number,
            Mail = entity.Mail,
            Url = entity.Url,
            EventPhotos = dates.Select(date => _eventDateConverter.ConvertToDto(date)).ToList()
        };
    }

    public Event ConvertToEntity(EventDto dto)
    {
        return new Event
        {
            Id = dto.Id,
            EventType = Enum.Parse<EventType>(dto.EventType),
            Name = dto.Name,
            Description = dto.Description,
            Number = dto.Number,
            Mail = dto.Mail,
            Url = dto.Url,
        };
    }
}