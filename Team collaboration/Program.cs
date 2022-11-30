using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Team_collaboration;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbDropdownHeaderModule),
        typeof(IgbIconButtonModule),
        typeof(IgbAvatarModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbBadgeModule),
        typeof(IgbListModule),
        typeof(IgbCalendarModule),
        typeof(IgbCardModule)
    );
}