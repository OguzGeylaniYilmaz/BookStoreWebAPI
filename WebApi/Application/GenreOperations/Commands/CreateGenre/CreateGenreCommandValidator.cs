using FluentValidation;

namespace WebApi.Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommandValidator: AbstractValidator<CreateGenreModel>
    {
        public CreateGenreCommandValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().MinimumLength(4);
        }
    }
}
