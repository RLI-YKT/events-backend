namespace src_asp.Models.OlympiadModels;

public class OlympiadEventModel
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public OlympiadLevel OlympiadLevel { get; set; }
    public string? Opinion { get; set; }
}