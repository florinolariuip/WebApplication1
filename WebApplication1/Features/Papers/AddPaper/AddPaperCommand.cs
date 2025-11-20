using MediatR;

namespace WebApplication1.Features.Papers.AddPaper;

public record AddPaperCommand(string Title, string Author, DateTime PublishedOn): IRequest<int>;
