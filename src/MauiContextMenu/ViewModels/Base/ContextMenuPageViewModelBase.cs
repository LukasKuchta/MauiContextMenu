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
        ) : base(settingsService, navigationService, dialogService)
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
                    if ((it is ItemContextMenuViewModel i) && i.IsExpanded)
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
    public virtual async Task<bool> OnItemMenuTapped(ItemContextMenuViewModel item)
    {
        if (item.HideContextMenuAfterTap)
        {
            IsContextMenuVisible = false;
        }

        foreach (ContextMenuItemViewModelBase baseItem in ContextMenuViewModel.MenuItems)
        {
            // tap on sub-item with expanded parent
            if (item.ParentItem is not null && item.ParentItem.IsExpanded)
            {
                continue;
            }

            if (baseItem is ItemContextMenuViewModel it)
            {
                if (it != item && it.IsExpanded)
                {
                    it.IsExpanded = false;
                }
            }
        }

        if (item.HasSubMenu)
        {
            item.IsExpanded = !item.IsExpanded;
        }

        if (item.MenuItemTappedAction is not null)
        {
            await item.MenuItemTappedAction.Invoke();
            return true;
        }

        return false;
    }

    /// <summary>
    /// Async initializer
    /// </summary>
    /// <returns></returns>
    public override async Task InitializeAsync()
    {
        ContextMenuViewModel = await Task.Run(async () =>
        {
            // keep navigation run fluently
            await Task.Delay(500);
            return CreateMenu();
        });
    }

    private Task AddDynamicItem()
    {
        // create content
        int contentId = new Random().Next(1000);
        // add item
        ContextMenuViewModel.AddSubMenuItem((ItemContextMenuViewModel)(ContextMenuViewModel.MenuItems[1]), new DynamicMenuItem("Dynamic ...", async () =>
        {
            await Task.Delay(100);
            Console.WriteLine($"Dynamic {contentId}");
        })
        { ContentId = contentId, });

        return Task.CompletedTask;
    }

    public virtual ContextMenuViewModelBase CreateMenu()
    {
        Builder builder = Builder.CreateBuilder();
        builder.AddHeaderItem("Shared menu title");
        builder.AddMenuItem(new ShareWithFriendsMenuItem())
                    .AddSubMenuItem(new AddSubItemMenuItem(AddDynamicItem));
        builder.AddMenuItem(new FilterByMenuItem())
                    .AddSubMenuItem(new GoToPage3MenuItem(NavigationService))
                    .AddSubMenuItem(new FilterByWeekMenuItem())
                    .AddSubMenuItem(new FilterByMonthMenuItem())
                    .AddSubMenuItem(new FilterByYearMenuItem());
        builder.AddMenuItem(new GoBackMenuItem(NavigationService));

        return builder.Build();
    }
}
