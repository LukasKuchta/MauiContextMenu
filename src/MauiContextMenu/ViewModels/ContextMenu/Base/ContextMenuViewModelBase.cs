using CommunityToolkit.Mvvm.ComponentModel;
using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;

public partial class ContextMenuViewModelBase : ObservableObject
{
    [ObservableProperty]
    private IList<ContextMenuItemViewModelBase> _menuItems;

    public bool AddMenuItem(ContextMenuItemViewModelBase menuItem)
    {
        if (_menuItems is not null)
        {
            _menuItems.Add(menuItem);
            return true;
        }
        return false;
    }

    public bool AddSubMenuItem(ItemContextMenuViewModel root, ItemContextMenuViewModel subItem)
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

