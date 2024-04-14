namespace SrcMvc.Models.EventModels;

public class EventModel
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public EventType EvenType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Contacts
    public string? Number { get; set; }
    public string? Mail { get; set; }
    public string? Url { get; set; }
}