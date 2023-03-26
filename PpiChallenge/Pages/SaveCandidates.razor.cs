using Blazored.FluentValidation;
using FluentValidation;
using Microsoft.AspNetCore.Components;
using Models;

namespace PpiChallenge.Pages
{

    public partial class SaveCandidates
    {
        [Inject] public IValidator<CandidateModel>? Validator { get; set; }
        private CandidateModel candidateModel { get; set; } = new();
        private FluentValidationValidator? _fluentValidationValidator;

    }
}
