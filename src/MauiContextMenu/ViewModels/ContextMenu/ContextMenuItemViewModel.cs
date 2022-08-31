using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;
public partial class ContextMenuItemViewModel : ContextMenuItemViewModelBase
{
    [ObservableProperty]
    MvvmHelpers.ObservableRangeCollection<ContextMenuItemViewModelBase> _subMenuItems = new MvvmHelpers.ObservableRangeCollection<ContextMenuItemViewModelBase>();

    [ObservableProperty]
    private bool _itemTapped;

    [RelayCommand]
    private async Task MenuItemTapped(ContextMenuPageViewModelBase pageViewModel)
    {
        if (!ItemTapped)
        {
            ItemTapped = true;
            await Task.Run(async () => await Task.Delay(200));

            if (pageViewModel != null)
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
    private bool _isExpanded;

    [ObservableProperty]
    private string _icon;

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private bool _isDangerous;

    public bool HasSubMenu { get => SubMenuItems.Count > 0; }
    public ContextMenuActions ContextMenuAction { get; init; }
}
