using CommunityToolkit.Mvvm.ComponentModel;
using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;

public partial class ContextMenuViewModelBase : ObservableObject
{
    [ObservableProperty]
    private MvvmHelpers.ObservableRangeCollection<ContextMenuItemViewModelBase> _menuItems;

    [ObservableProperty]
    private string _contextMenuTitle;
}

