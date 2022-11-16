using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.ContextMenu;

public partial class ContextMenuHeaderViewModel : ContextMenuItemViewModelBase
{
    public ContextMenuHeaderViewModel(string naheaderTitleme)
    {
        Name = naheaderTitleme;
    }
}
