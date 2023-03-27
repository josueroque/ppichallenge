using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Models;
using PpiChallenge.Services;
using System.Reflection;

namespace PpiChallenge.Pages
{
    public partial class Search
    {
        [Inject] AppState State { get; set; } = new();
        [Inject] NavigationManager? NavigationManager { get; set; }
        private IQueryable<CandidateModel>? Candidates { get; set; }

        private IQueryable<CandidateModel>? SearchResults { get; set; }

        private CandidateModel SearchFilters { get; set; } = new();

        PaginationState pagination = new PaginationState { ItemsPerPage = 5 };

        protected override async Task OnInitializedAsync()
        {
            Candidates = State.Candidates.AsQueryable();
            SearchResults = Candidates.AsQueryable();
            pagination.TotalItemCountChanged += (sender, eventArgs) => StateHasChanged();
            await base.OnInitializedAsync();
        }

        private void ApplyFilters()
        {
            SearchResults = State.Candidates.AsQueryable();

            foreach (PropertyInfo prop in SearchFilters.GetType().GetProperties())
            {
                var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                if (prop.GetValue(SearchFilters, null) != null)
                {

                    var property = prop.GetValue(SearchFilters, null);

                    var propertyValue = property != null ? property.ToString() : string.Empty;

                    if (!string.IsNullOrEmpty(propertyValue))
                    {
                        switch (prop.Name)
                        {
                            case "FirstName":
                                SearchResults = SearchResults?.Where(x => x.FirstName.Contains(propertyValue));
                                break;
                            case "LastName":
                                SearchResults = SearchResults?.Where(x => x.LastName.Contains(propertyValue));
                                break;
                            case "EmailAdress":
                                SearchResults = SearchResults?.Where(x => x.EmailAdress.Contains(propertyValue));
                                break;
                            case "PhoneNumber":
                                SearchResults = SearchResults?.Where(x => x.PhoneNumber.Contains(propertyValue));
                                break;
                            case "ZipCode":
                                SearchResults = SearchResults?.Where(x => x.ZipCode.Contains(propertyValue));
                                break;
                        }
                    }

                }

            }
        }

        private void ClearSearch()
        {
            SearchFilters = new();
            SearchResults = State.Candidates.AsQueryable();
        }

        private void NavigateToCreate()
        {
            NavigationManager?.NavigateTo("SaveCandidate");
        }

    }
}
