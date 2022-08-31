using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu.Impl;

public partial class ContextMenuViewModel : ContextMenuViewModelBase
{
    public ContextMenuViewModel(string contextMenuTitle)
    {
        ContextMenuTitle = contextMenuTitle;

        MenuItems = new MvvmHelpers.ObservableRangeCollection<ContextMenuItemViewModelBase>()
            {
                new ContextMenuHeaderViewModel(contextMenuTitle),
                     new ContextMenuItemViewModel{
                        Icon = "ic3",
                        Name = "Filter by",
                        ContextMenuAction = ContextMenuActions.YearStats
                    },
                    new ContextMenuItemViewModel{
                        Icon = "ic1",
                        Name = "Share with friends",
                        ContextMenuAction = ContextMenuActions.ShareWithFriends
                    },
                    new ContextMenuItemViewModel{
                        Icon = "ic2",
                        Name = "Go to page3",
                        ContextMenuAction= ContextMenuActions.GoToPage3
                    },
                    new ContextMenuItemViewModel{
                        Icon = "ic2",
                        Name = "Back",
                        ContextMenuAction= ContextMenuActions.Back
                    }
            };

        ((ContextMenuItemViewModel)MenuItems[1]).SubMenuItems.AddRange(new List<ContextMenuItemViewModel>() {
     new ContextMenuItemViewModel{
                    Icon = "ic4",
                    Name = "Day",
                    ContextMenuAction = ContextMenuActions.DayStats
                },
                new ContextMenuItemViewModel{
                    Icon = "ic5",
                    Name = "Week",
                    ContextMenuAction = ContextMenuActions.WeekStats
                },
                new ContextMenuItemViewModel{
                    Icon = "ic6",
                    Name = "Month",
                    ContextMenuAction = ContextMenuActions.MonthStats
                },
                 new ContextMenuItemViewModel{
                    Icon = "ic6",
                    Name = "Year",
                    ContextMenuAction = ContextMenuActions.YearStats
                }
        });
    }
}

