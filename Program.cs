using BlazorWasmOrcamento;
using BlazorWasmOrcamento.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5181/v1/api/") });
builder.Services.AddScoped<IOrcamentoService, OrcamentoService>();

await builder.Build().RunAsync();
