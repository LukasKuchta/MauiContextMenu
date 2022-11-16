using MauiContextMenu.ViewModels.Page;

namespace MauiContextMenu.ViewModels;

public static class PageExtension
{
    public static MauiAppBuilder AddViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<Page1ViewModel>();
        builder.Services.AddTransient<Page2ViewModel>();
        builder.Services.AddTransient<Page3ViewModel>();
        builder.Services.AddTransient<MainViewModel>();

        return builder;
    }
}
