using SrcASP.Models.EventModels;
using SrcASP.Services.Builders.Interfaces.EventModelsBuilders;

namespace SrcASP.Services.Builders.Implementations.EventModelsBuilders;

public class EventBuilder : IEventBuilder
{
    private EventType? _eventType;
    private string? _name;
    private string? _description;
    private string? _number;
    private string? _mail;
    private string? _url;

    public IEventBuilder SetEventType(EventType eventType)
    {
        _eventType = eventType;
        return this;
    }

    public IEventBuilder SetName(string name)
    {
        _name = name ?? throw new ArgumentNullException(nameof(name));
        return this;
    }

    public IEventBuilder SetDescription(string description)
    {
        _description = description ?? throw new ArgumentNullException(nameof(description));
        return this;
    }

    public IEventBuilder SetNumber(string number)
    {
        _number = number ?? throw new ArgumentNullException(nameof(number));
        return this;
    }

    public IEventBuilder SetMail(string mail)
    {
        _mail = mail ?? throw new ArgumentNullException(nameof(mail));
        return this;
    }

    public IEventBuilder SetUrl(string url)
    {
        _url = url ?? throw new ArgumentNullException(nameof(url));
        return this;
    }

    public async Task<Event> BuildAsync()
    {
        if (_eventType == null)
        {
            throw new InvalidOperationException("EventType must be set before building the event.");
        }

        if (string.IsNullOrEmpty(_name))
        {
            throw new InvalidOperationException("Name must be set before building the event.");
        }

        if (string.IsNullOrEmpty(_description))
        {
            throw new InvalidOperationException("Description must be set before building the event.");
        }

        var newEvent = new Event
        {
            EventType = _eventType.Value,
            Name = _name,
            Description = _description,
            Number = _number,
            Mail = _mail,
            Url = _url
        };

        return newEvent;
    }
}