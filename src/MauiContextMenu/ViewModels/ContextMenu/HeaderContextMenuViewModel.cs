using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;

public partial class HeaderContextMenuViewModel : ContextMenuItemViewModelBase
{
    public HeaderContextMenuViewModel(string naheaderTitleme)
    {
        Name = naheaderTitleme;
    }
}
