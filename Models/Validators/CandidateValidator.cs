using FluentValidation;

namespace Models.Validators
{
    public class CandidateValidator : AbstractValidator<CandidateModel>
    {
        public CandidateValidator()
        {
            RuleFor(candidate => candidate.FirstName).NotEmpty().WithMessage("{PropertyName} must not be empty");
            RuleFor(candidate => candidate.LastName).NotEmpty().WithMessage("{PropertyName} must not be empty");
        }
    }
}
