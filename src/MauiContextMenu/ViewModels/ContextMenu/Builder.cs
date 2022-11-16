using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;

public class Builder
{
    private IList<ContextMenuItemViewModelBase> _menuItems;

    private Builder()
    {
        _menuItems = new List<ContextMenuItemViewModelBase>();
    }

    public static Builder CreateBuilder()
    {
        return new Builder();
    }

    public Builder AddHeaderItem(string headerTitle)
    {
        _menuItems.Add(new ContextMenuHeaderViewModel(headerTitle));
        return this;
    }

    public ContextMenuItemViewModel AddMenuItem(ContextMenuItemViewModel menuItem)
    {
        _menuItems.Add(menuItem);
        return menuItem;
    }

    public ContextMenuViewModelBase Build()
    {
        ContextMenuViewModelBase menu = new ContextMenuViewModelBase();
        menu.MenuItems = _menuItems;
        return menu;
    }
}


