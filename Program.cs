using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;
using EventEase.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton<EventService>();
builder.Services.AddSingleton<AttendanceService>();
builder.Services.AddScoped<SessionService>();

await builder.Build().RunAsync();
