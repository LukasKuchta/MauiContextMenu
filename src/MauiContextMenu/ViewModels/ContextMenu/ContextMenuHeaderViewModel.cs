using CommunityToolkit.Mvvm.ComponentModel;
using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;

public partial class ContextMenuHeaderViewModel : ContextMenuItemViewModelBase
{
    [ObservableProperty]
    private string _headerTitle;

    public ContextMenuHeaderViewModel(string naheaderTitleme)
    {
        HeaderTitle = naheaderTitleme;
    }
}
