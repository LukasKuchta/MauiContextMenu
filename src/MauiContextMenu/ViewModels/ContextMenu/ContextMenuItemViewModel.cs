using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;
public abstract partial class ContextMenuItemViewModel : ContextMenuItemViewModelBase
{
    [RelayCommand]
    private async Task MenuItemTapped(ContextMenuPageViewModelBase pageViewModel)
    {
        if (!ItemTapped)
        {
            ItemTapped = true;
            await Task.Run(async () => await Task.Delay(200));

            if (pageViewModel is not null)
            {
                if (HasSubMenu)
                {
                    IsExpanded = !IsExpanded;
                }
                else
                {
                    await pageViewModel.OnItemMenuTapped(this);
                }
            }
            ItemTapped = false;
        }
    }

    [ObservableProperty]
    private IList<ContextMenuItemViewModelBase> _subMenuItems = new List<ContextMenuItemViewModelBase>();

    [ObservableProperty]
    private bool _itemTapped;

    [ObservableProperty]
    private bool _isExpanded;

    [ObservableProperty]
    private string _icon;   

    [ObservableProperty]
    private bool _isDangerous;

    public abstract string Id { get; }

    public bool HasSubMenu { get => SubMenuItems.Count > 0; }

    public ContextMenuItemViewModel AddSubMenuItem(ContextMenuItemViewModelBase subMenuItem)
    {
        SubMenuItems.Add(subMenuItem);
        return this;
    }
}
