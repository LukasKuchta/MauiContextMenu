using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;

public class Builder
{
    private ItemContextMenuViewModel _lastItem;
    private ContextMenuViewModelBase _menu;
    private Builder()
    {
        _menu = new ContextMenuViewModelBase();
        _menu.MenuItems = new List<ContextMenuItemViewModelBase>();
    }

    public static Builder CreateBuilder()
    {
        return new Builder();
    }

    public Builder AddHeaderItem(string headerTitle)
    {
        _menu.MenuItems.Add(new HeaderContextMenuViewModel(headerTitle));
        return this;
    }

    public Builder AddSubMenuItem(ItemContextMenuViewModel subMenuItem)
    {
        if (_lastItem is not null)
        {
            _menu.AddSubMenuItem(_lastItem, subMenuItem);
        }

        return this;
    }

    public Builder AddMenuItem(ItemContextMenuViewModel menuItem)
    {
        _lastItem = menuItem;
        _menu.AddMenuItem(menuItem);
        return this;
    }

    public ContextMenuViewModelBase Build()
    {
        _lastItem = null;
        return _menu;
    }
}


