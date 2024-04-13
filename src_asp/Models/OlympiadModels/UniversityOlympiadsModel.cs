namespace src_asp.Models.OlympiadModels;

public class UniversityOlympiadsModel
{
    public int Id { get; set; }
    public int UniversityId { get; set; }
    public int EventId { get; set; }
    public OlympiadBenefit Benefit { get; set; }
}