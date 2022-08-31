using MauiContextMenu.Services;
using MauiContextMenu.ViewModels.ContextMenu;
using MauiContextMenu.ViewModels.ContextMenu.Base;
using MauiContextMenu.ViewModels.ContextMenu.Impl;

namespace MauiContextMenu.ViewModels;

public partial class Page1ViewModel : ContextMenuPageViewModelBase
{    
    public Page1ViewModel(INavigationService navigatioService):base(navigatioService)
    {        
        Title = "Monkey list";
        ContextMenuViewModel = new ContextMenuViewModel("Context menu for page1");
    }

    public override async Task OnItemMenuTapped(ContextMenuItemViewModel item) 
    {
        await base.OnItemMenuTapped(item);
        
        switch (item.ContextMenuAction)
        {
            case ContextMenuActions.Back:
                await NavigationService.PopAsync();
                break;
            case ContextMenuActions.GoToPage3:
                await NavigationService.NavigateToAsync(nameof(Page3ViewModel));
                break;
        }        
    }
}
