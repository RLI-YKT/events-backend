namespace SrcMvc.Models.EventModels;

public class CommentModel
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    public string Comment { get; set; }
    public DateTime Date { get; set; }
    public MessageStatus Status { get; set; }
}