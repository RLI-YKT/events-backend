using AutoMapper;
using SrcASP.Models.EventModels;
using SrcASP.Services.Dto.Models;

namespace SrcASP.Services.Dto.Converters;

public class EventDateConverter
{
    private readonly IMapper _mapper;

    public EventDateConverter()
    {
        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<EventDate, EventDateDto>();
            cfg.CreateMap<EventDateDto, EventDate>();
        });

        _mapper = configuration.CreateMapper();
    }

    public EventDateDto ConvertToDto(EventDate entity)
    {
        return _mapper.Map<EventDateDto>(entity);
    }

    public EventDate ConvertToEntity(EventDateDto dto)
    {
        return _mapper.Map<EventDate>(dto);
    }
}