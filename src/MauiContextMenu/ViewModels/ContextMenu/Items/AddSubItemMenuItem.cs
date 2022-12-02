namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class AddSubItemMenuItem : ItemContextMenuViewModel
{
    public AddSubItemMenuItem(Func<Task> action)
    {
        Icon = "ic5";
        Name = "Add sub item";
        MenuItemTappedAction = action;
    }

    public override bool HideContextMenuAfterTap => false;
}
