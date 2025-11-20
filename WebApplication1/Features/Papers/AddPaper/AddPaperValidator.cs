using FluentValidation;
using WebApplication1.Data;

namespace WebApplication1.Features.Papers.AddPaper;

public class AddPaperValidator : AbstractValidator<Paper>
{
    public AddPaperValidator()
    {
        RuleFor(p=>p.Title).NotEmpty().MaximumLength(200);
        RuleFor(p=>p.Author).NotEmpty().MaximumLength(100);
        RuleFor(p=>p.PublishedOn).LessThanOrEqualTo(DateTime.Today);
    }
}