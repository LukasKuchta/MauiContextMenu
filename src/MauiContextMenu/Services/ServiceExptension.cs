using MauiContextMenu.Services.Dialog;
using MauiContextMenu.Services.Navigation;
using MauiContextMenu.Services.Settings;

namespace MauiContextMenu.Services;

public static class ServiceExptension
{
    public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<INavigationService, NavigationService>();
        builder.Services.AddTransient<IDialogService, DialogService>();
        builder.Services.AddTransient<ISettingsService, SettingsService>();

        return builder;
    }
}
