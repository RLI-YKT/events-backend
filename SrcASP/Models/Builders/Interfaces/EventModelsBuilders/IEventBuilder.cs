using SrcASP.Models.EventModels;

namespace SrcASP.Services.Builders.Interfaces.EventModelsBuilders;

public interface IEventBuilder
{
    IEventBuilder SetEventType(EventType eventType);
    IEventBuilder SetName(string name);
    IEventBuilder SetDescription(string description);
    IEventBuilder SetNumber(string number);
    IEventBuilder SetMail(string mail);
    IEventBuilder SetUrl(string url);
    Task<Event> BuildAsync();
}