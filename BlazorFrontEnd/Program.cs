using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorFrontEnd;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient with HTTP base address
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5159") }); // Note HTTP here

await builder.Build().RunAsync();
