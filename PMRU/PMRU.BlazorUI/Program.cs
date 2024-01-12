using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PMRU.BlazorUI;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Services;
using PMRU.BlazorUI.Services.Base;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri("http://localhost:5000"));

builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

await builder.Build().RunAsync();
