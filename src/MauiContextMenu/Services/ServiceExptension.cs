namespace MauiContextMenu.Services;

public static class ServiceExptension
{
    public static MauiAppBuilder AddServices(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<INavigationService, NavigationService>();            

        return builder;
    }
}
