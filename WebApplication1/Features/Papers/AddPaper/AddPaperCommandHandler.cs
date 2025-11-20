using MediatR;
using WebApplication1.Data;

namespace WebApplication1.Features.Papers.AddPaper;

public class AddPaperCommandHandler : IRequestHandler<AddPaperCommand,int>
{
    private readonly AppDbContext _context;
    public AddPaperCommandHandler(AppDbContext context) => _context = context ?? throw new ArgumentNullException(nameof(context));
    
    public Task<int> Handle(AddPaperCommand request, CancellationToken cancellationToken)
    {
        var paper = new Paper
        {
            Title = request.Title,
            Author = request.Author,
            PublishedOn = request.PublishedOn
        };
        _context.Papers.Add(paper);
        _context.SaveChanges();
        return Task.FromResult(paper.Id);
    }
}