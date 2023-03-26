using CurrieTechnologies.Razor.SweetAlert2;
using FluentValidation;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Models;
using Models.Validators;
using PpiChallenge;
using PpiChallenge.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IValidator<CandidateModel>, CandidateValidator>();
builder.Services.AddScoped<AppState>();
builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
