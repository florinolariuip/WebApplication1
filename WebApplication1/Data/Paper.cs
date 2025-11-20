namespace WebApplication1.Data;

public class Paper
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Author { get; set; } = default!;
    public DateTime PublishedOn { get; set; }
}
