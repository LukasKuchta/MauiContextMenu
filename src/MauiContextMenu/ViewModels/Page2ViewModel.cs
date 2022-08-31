using MauiContextMenu.Services;
using MauiContextMenu.ViewModels.ContextMenu;
using MauiContextMenu.ViewModels.ContextMenu.Base;
using MauiContextMenu.ViewModels.ContextMenu.Impl;

namespace MauiContextMenu.ViewModels;

public class Page2ViewModel : ContextMenuPageViewModelBase
{
    public Page2ViewModel(INavigationService navigationService) : base(navigationService)
    {
        Title = "Business page";
        ContextMenuViewModel = new CrudContextMenuViewModel("CRUD options");
    }    
}
