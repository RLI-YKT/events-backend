namespace SrcASP.Services.Dto.Models;

public class EventDateDto
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public DateOnly Date { get; set; }
    public string Description { get; set; }
}