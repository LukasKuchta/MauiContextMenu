using MauiApp1;

namespace MauiContextMenu.Pages;

public static class PageExtension
{
    public static MauiAppBuilder AddPages(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<Page1>();
        builder.Services.AddTransient<Page2>();
        builder.Services.AddTransient<Page3>();
        builder.Services.AddTransient<AppShell>();

        return builder;
    }
}
