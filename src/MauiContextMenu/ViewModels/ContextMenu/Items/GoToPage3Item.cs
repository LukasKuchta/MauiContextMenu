using MauiContextMenu.Services.Navigation;
using MauiContextMenu.ViewModels.Page;

namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class GoToPage3MenuItem : ItemContextMenuViewModel
{
    public GoToPage3MenuItem(INavigationService navigationService)
    {
        Icon = "ic4";
        Name = "Go to page3";
        MenuItemTappedAction = async () => { await navigationService.NavigateToAsync(nameof(Page3ViewModel)); };
    }
}
