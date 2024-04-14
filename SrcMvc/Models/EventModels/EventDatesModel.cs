namespace SrcMvc.Models.EventModels;

public class EventDatesModel
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public DateOnly Date { get; set; }
    public string Description { get; set; }
}