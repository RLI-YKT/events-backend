namespace SrcMvc.Models.HackathonModels;

public class HackathonEventModel
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public int OrgId { get; set; }
    public string PrizeFund { get; set; }
    public IList<string> TechnologicalOrientation { get; set; }
}