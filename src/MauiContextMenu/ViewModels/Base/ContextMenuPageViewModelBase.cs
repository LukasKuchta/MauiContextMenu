using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiContextMenu.Services.Dialog;
using MauiContextMenu.Services.Navigation;
using MauiContextMenu.Services.Settings;
using MauiContextMenu.ViewModels.Base;
using MauiContextMenu.ViewModels.ContextMenu.Items;

namespace MauiContextMenu.ViewModels.ContextMenu.Base;

public abstract partial class ContextMenuPageViewModelBase : PageViewModelBase
{
    public ContextMenuPageViewModelBase(
        ISettingsService settingsService,
        INavigationService navigationService,
        IDialogService dialogService
        ) : base(settingsService,navigationService, dialogService)
    {
        NavigationService = navigationService;
    }

    [ObservableProperty]
    private bool _isContextMenuVisible = false;

    [ObservableProperty]
    private ContextMenuViewModelBase _contextMenuViewModel;

    /// <summary>
    /// Show and
    /// </summary>
    [RelayCommand]
    private void ToggleContextMenu()
    {
        if (ContextMenuViewModel != null && ContextMenuViewModel.MenuItems != null)
        {
            ((List<ContextMenuItemViewModelBase>)ContextMenuViewModel.MenuItems)
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

    /// <summary>
    /// Item tapped handler method.
    /// </summary>
    /// <param name="item">Tapped item</param>
    /// <returns></returns>
    public virtual Task OnItemMenuTapped(ContextMenuItemViewModel item)
    {
        if (!item.HasSubMenu)
        {
            IsContextMenuVisible = false;
        }

        return Task.CompletedTask;
    }

    /// <summary>
    /// Async initializer
    /// </summary>
    /// <returns></returns>
    public override async Task InitializeAsync()
    {
        ContextMenuViewModel = await Task.Run(async () =>
        {
            await Task.Delay(500);
            return CreateMenu();
        });
    }

    public virtual ContextMenuViewModelBase CreateMenu()
    {
        Builder builder = Builder.CreateBuilder();
        builder.AddHeaderItem("Shared menu title");
        builder.AddMenuItem(new ShareWithFriendsMenuItem());
        builder.AddMenuItem(new FilterByMenuItem())
                    .AddSubMenuItem(new FilterByDayMenuItem())
                    .AddSubMenuItem(new FilterByWeekMenuItem())
                    .AddSubMenuItem(new FilterByMonthMenuItem())
                    .AddSubMenuItem(new FilterByYearMenuItem());
        builder.AddMenuItem(new GoBackMenuItem());

        return builder.Build();
    }
}
