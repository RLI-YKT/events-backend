using AutoMapper;
using SrcASP.Models.EventModels;
using SrcASP.Services.Dto.Converters;
using SrcASP.Services.Dto.Models;
using SrcASP.Services.RepositoriesInterfaces.EventRepositories;

namespace SrcASP.Services.Contracts;

public class EventService
{
    private readonly IEventRepository _eventRepository;
    private readonly IEventDateRepository _eventDateRepository;
    private readonly EventConverter _eventConverter;
    private readonly EventDateConverter _eventDateConverter;

    public EventService(IEventRepository eventRepository, IEventDateRepository eventDateRepository, EventConverter eventConverter, EventDateConverter eventDateConverter)
    {
        ArgumentNullException.ThrowIfNull(eventConverter);
        ArgumentNullException.ThrowIfNull(eventRepository);
        ArgumentNullException.ThrowIfNull(eventDateConverter);
        ArgumentNullException.ThrowIfNull(eventDateRepository);
        _eventRepository = eventRepository;
        _eventDateRepository = eventDateRepository;
        _eventConverter = eventConverter;
        _eventDateConverter = eventDateConverter;
    }

    public async Task<EventDto> GetById(int id)
    {
        var eventEntity = await _eventRepository.GetById(id);
        if (eventEntity is null)
        {
            throw new InvalidOperationException("Event not found");
        }
        var eventDates = await _eventDateRepository.GetByEventId(id);
        return _eventConverter.ConvertToDto(eventEntity, eventDates);
    }

    public async Task<IEnumerable<EventDto>> GetAll()
    {
        var result = new List<EventDto>();
        var eventEntities = await _eventRepository.GetAll();
        foreach (var entity in eventEntities)
        {
            var eventDates = await _eventDateRepository.GetByEventId(entity.Id);
            result.Add(_eventConverter.ConvertToDto(entity, eventDates));
        }
        return result;
    }

    public async Task Create(EventDto eventDto)
    {
        var eventEntity = _eventConverter.ConvertToEntity(eventDto);
        await _eventRepository.Add(eventEntity);
    }

    public async Task Update(int id, EventDto eventDto)
    {
        var eventEntity = await _eventRepository.GetById(id);
        if (eventEntity is null)
        {
            throw new InvalidOperationException("Event not found");
        }

        eventEntity = _eventConverter.ConvertToEntity(eventDto);
        eventEntity.Id = id;
        await _eventRepository.Update(eventEntity);
    }

    public async Task Delete(int id)
    {
        await _eventRepository.Delete(id);
    }
}