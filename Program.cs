using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Globalization;
using Microsoft.JSInterop;
using PolWarmDictionary_Frontend;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("PolWarmDictionary.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("PolWarmDictionary.ServerAPI"));

builder.Services.AddMsalAuthentication(options =>
{
    builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    options.ProviderOptions.DefaultAccessTokenScopes.Add("api://6f1e33fd-dcb9-4da6-a7f2-34dd964950f4/API.Access");
});

builder.Services.AddLocalization();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<Endpoint>();
builder.Services.AddTransient<Sorting>();
builder.Services.AddTransient<RequestMessageGenerator>();
builder.Services.AddMudServices();
builder.Services.AddSessionStorageServices();

var host = builder.Build();

var js = host.Services.GetRequiredService<IJSRuntime>();
var module = await js.InvokeAsync<IJSObjectReference>("import",
            "./Shared/MainLayout.razor.js");
string savedCulture = await module.InvokeAsync<string>("getCulture", "en");

CultureInfo cultureInfo;
if (savedCulture == null)
{
    cultureInfo = new CultureInfo("en");
    await module.InvokeVoidAsync("setCulture", "en");
}
else
{
    cultureInfo = new CultureInfo(savedCulture);
}
if (module is not null) await module.DisposeAsync();

CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

await host.RunAsync();
