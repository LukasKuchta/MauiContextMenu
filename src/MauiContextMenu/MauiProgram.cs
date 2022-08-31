using CommunityToolkit.Maui;
using MauiContextMenu.Pages;
using MauiContextMenu.Services;
using MauiContextMenu.ViewModels;

namespace MauiContextMenu;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .AddViewModels()
            .AddPages()
            .AddServices()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Initialise the toolkit
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();

        return builder.Build();
    }
}
