using MauiContextMenu.Services.Dialog;
using MauiContextMenu.Services.Navigation;
using MauiContextMenu.Services.Settings;
using MauiContextMenu.ViewModels.ContextMenu;
using MauiContextMenu.ViewModels.ContextMenu.Base;
using MauiContextMenu.ViewModels.ContextMenu.Items;

namespace MauiContextMenu.ViewModels.Page;

public partial class Page1ViewModel : ContextMenuPageViewModelBase
{
    public Page1ViewModel(ISettingsService settingsService, INavigationService navigationService, IDialogService dialogService) : base(settingsService, navigationService, dialogService)
    {
        Title = "Monkey list";
    }

    public override async Task OnItemMenuTapped(ContextMenuItemViewModel item)
    {
        await base.OnItemMenuTapped(item);

        switch (item.Id)
        {
            case GoBackMenuItem.ActionId:
                await GoBackCommand.ExecuteAsync(null);
                break;
            case GoToPage3MenuItem.ActionId:
                await GoToPage3();
                break;
        }
    }

    private async Task GoToPage3()
    {
        await NavigationService.NavigateToAsync(nameof(Page3ViewModel));
    }

}
