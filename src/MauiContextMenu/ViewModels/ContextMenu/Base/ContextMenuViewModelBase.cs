using CommunityToolkit.Mvvm.ComponentModel;
using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;

public partial class ContextMenuViewModelBase : ObservableObject
{
    [ObservableProperty]
    private IList<ContextMenuItemViewModelBase> _menuItems;

    public bool AddSubMenuItem(ContextMenuItemViewModel root, ContextMenuItemViewModel subItem)
    {
        if (MenuItems is not null)
        {
            subItem.ParentItem = root;
            root.SubMenuItems.Add(subItem);
            return true;
        }

        return false;
    }
}

