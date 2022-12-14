using MauiContextMenu.Services.Navigation;

namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class GoBackMenuItem : ItemContextMenuViewModel
{
    public GoBackMenuItem(INavigationService navigationService)
    {
        Icon = "ic5";
        Name = "Back";
        MenuItemTappedAction = async () =>
        {
            await navigationService.PopAsync();
        };
    }
}
