using CommunityToolkit.Mvvm.ComponentModel;
using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu.Impl;

public partial class CrudContextMenuViewModel : ContextMenuViewModelBase
{
    [ObservableProperty]
    MvvmHelpers.ObservableRangeCollection<ContextMenuItemViewModelBase> _menuItems;

    [ObservableProperty]
    private string _contextMenuTitle;
    public CrudContextMenuViewModel(string contextMenuTitle)
    {
        ContextMenuTitle = contextMenuTitle;

        MenuItems = new MvvmHelpers.ObservableRangeCollection<ContextMenuItemViewModelBase>()
            {
                new ContextMenuHeaderViewModel(contextMenuTitle),
                new ContextMenuItemViewModel{
                    Icon = "ic1",
                    Name = "Insert",
                    ContextMenuAction = ContextMenuActions.DayStats

                },
                new ContextMenuItemViewModel{
                    Icon = "ic2",
                    Name = "Update",
                    ContextMenuAction = ContextMenuActions.WeekStats
                },
                new ContextMenuItemViewModel{
                    Icon = "ic3",
                    Name = "Delete",
                    IsDangerous = true,
                    ContextMenuAction = ContextMenuActions.YearStats
                }
            };
    }
}

