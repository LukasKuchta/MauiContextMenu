using MauiContextMenu.Services.Dialog;
using MauiContextMenu.Services.Navigation;
using MauiContextMenu.Services.Settings;
using MauiContextMenu.ViewModels.ContextMenu;
using MauiContextMenu.ViewModels.ContextMenu.Base;
using MauiContextMenu.ViewModels.ContextMenu.Items;

namespace MauiContextMenu.ViewModels.Page;

public class Page2ViewModel : ContextMenuPageViewModelBase
{
    public Page2ViewModel(ISettingsService settingsService, INavigationService navigationService, IDialogService dialogService) : base(settingsService, navigationService, dialogService)
    {
        Title = "Business page";
    }

    public override ContextMenuViewModelBase CreateMenu()
    {
        Builder builder = Builder.CreateBuilder();
        builder.AddHeaderItem("Page 2 menu");
        builder.AddMenuItem(new InsertMenuItem());
        builder.AddMenuItem(new UpdateMenuItem());
        builder.AddMenuItem(new DeleteMenuItem());
        builder.AddHeaderItem("Other section");
        builder.AddMenuItem(new GoBackMenuItem());

        return builder.Build();
    }
}
