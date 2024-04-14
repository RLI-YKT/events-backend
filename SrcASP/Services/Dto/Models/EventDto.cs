namespace SrcASP.Services.Dto.Models;

public class EventDto
{
    public int Id { get; set; }
    public string EventType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Number { get; set; }
    public string? Mail { get; set; }
    public string? Url { get; set; }
    public List<EventDateDto> EventPhotos { get; set; }
}