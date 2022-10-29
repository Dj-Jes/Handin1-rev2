using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp;
using BlazorApp.Auth;
using BlazorApp.Services;
using BlazorApp.Services.Http;
using Domain.Auth;
using Microsoft.AspNetCore.Components.Authorization;

/*
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
*/

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthProvider>();
builder.Services.AddScoped<IAuthService, JwtAuthService>();


AuthorizationPolicies.AddPolicies(builder.Services);


builder.Services.AddScoped(sp => new HttpClient());
// builder.Services.AddScoped(sp => new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
