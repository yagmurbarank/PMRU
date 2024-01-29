using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Options;
using PMRU.BlazorUI;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Handlers;
using PMRU.BlazorUI.Localization;
using PMRU.BlazorUI.Providers;
using PMRU.BlazorUI.Services;
using PMRU.BlazorUI.Services.Base;
using System.Reflection;
using static PMRU.BlazorUI.Services.DoctorService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<JwtAuthorizationMessageHandler>();
builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri("http://localhost:5000"))
    .AddHttpMessageHandler<JwtAuthorizationMessageHandler>();

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddScoped<IAvailabilityService, AvailabilityService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

builder.Services.AddLocalization(options=>
{
    options.ResourcesPath = "Resources";
});


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

var host = builder.Build();
await host.SetDefaultCulture();
await host.RunAsync();

