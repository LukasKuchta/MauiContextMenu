using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiContextMenu.Services;

namespace MauiContextMenu.ViewModels.ContextMenu.Base;
public abstract partial class ContextMenuPageViewModelBase : ObservableObject
{
    protected INavigationService NavigationService { get; init; }

    public ContextMenuPageViewModelBase(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    [ObservableProperty]
    private bool _isContextMenuVisible = false;

    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private ContextMenuViewModelBase _contextMenuViewModel;

    [RelayCommand]
    private void ToggleContextMenu()
    {
        if (ContextMenuViewModel != null && ContextMenuViewModel.MenuItems != null)
        {
            ContextMenuViewModel.MenuItems
                .ToList()
                .ForEach(it =>
                {
                    if ((it is ContextMenuItemViewModel i) && i.IsExpanded)
                    {
                        i.IsExpanded = false;
                    }
                });
        }

        IsContextMenuVisible = !IsContextMenuVisible;
    }

    [RelayCommand]
    private async Task GoBack()
    {
        await NavigationService.PopAsync();
    }

    public bool HasContextMenu { get => ContextMenuViewModel != null; }

    public virtual Task OnItemMenuTapped(ContextMenuItemViewModel item)
    {
        if (!item.HasSubMenu)
        {
            IsContextMenuVisible = false;
        }

        return Task.CompletedTask;
    }
}

