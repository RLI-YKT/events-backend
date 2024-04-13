namespace src_asp.Models;

public class EventModel
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public EventEnum EvenType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}