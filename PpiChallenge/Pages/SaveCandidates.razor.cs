using Blazored.FluentValidation;
using CurrieTechnologies.Razor.SweetAlert2;
using FluentValidation;
using Microsoft.AspNetCore.Components;
using Models;
using PpiChallenge.Services;

namespace PpiChallenge.Pages
{

    public partial class SaveCandidates
    {
        [Inject] public IValidator<CandidateModel>? Validator { get; set; }
        [Inject] AppState State { get; set; } = new();
        [Inject] NavigationManager? NavigationManager { get; set; }
        private FluentValidationValidator? _fluentValidationValidator;
        private CandidateModel candidateModel { get; set; } = new();

        private async void OnSubmit()
        {
            try
            {
                if (!await _fluentValidationValidator!.ValidateAsync())
                {
                    return;
                }

                var candidates = State.Candidates.ToList();

                candidates.Add(candidateModel);

                State.Candidates = candidates;

                StateHasChanged();

                await Swal.FireAsync(new SweetAlertOptions
                {
                    Title = "Success!",
                    Icon = SweetAlertIcon.Success
                });

                NavigationManager?.NavigateTo("/");

            }
            catch
            {

                await Swal.FireAsync(new SweetAlertOptions
                {
                    Title = "Something wrong happened",
                    Icon = SweetAlertIcon.Error
                });
            }
        }


    }
}
