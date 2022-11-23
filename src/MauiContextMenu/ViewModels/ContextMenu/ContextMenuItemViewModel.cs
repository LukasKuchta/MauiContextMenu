using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiContextMenu.ViewModels.ContextMenu.Base;
using MvvmHelpers;

namespace MauiContextMenu.ViewModels.ContextMenu;
public abstract partial class ContextMenuItemViewModel : ContextMenuItemViewModelBase
{
    [ObservableProperty]
    private bool _isSeparatorVisible = false;

    [ObservableProperty]
    private bool _itemTapped;

    [ObservableProperty]
    private bool _isExpanded;

    [ObservableProperty]
    private string _icon;

    [ObservableProperty]
    private bool _isDangerous;

    public ContextMenuItemViewModel ParentItem { get; set; }

    [ObservableProperty]
    private ObservableRangeCollection<ContextMenuItemViewModelBase> _subMenuItems = new ObservableRangeCollection<ContextMenuItemViewModelBase>();

    public bool HasSubMenu { get => SubMenuItems.Count > 0; }

    public virtual bool HideContextMenuAfterTap { get => !HasSubMenu; }
    public Func<Task> MenuItemTappedAction { get; set; } = null;

    [RelayCommand]
    private async Task MenuItemTapped(ContextMenuPageViewModelBase pageViewModel)
    {
        if (!ItemTapped)
        {
            ItemTapped = true;
            await Task.Run(async () => await Task.Delay(200));

            if (pageViewModel is not null)
            {
                await pageViewModel.OnItemMenuTapped(this);
            }

            ItemTapped = false;
        }
    }
}
