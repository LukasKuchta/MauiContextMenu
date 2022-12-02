namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class DynamicMenuItem : ItemContextMenuViewModel
{
    public int ContentId { get; set; }

    public DynamicMenuItem(string name, Func<Task> action)
    {
        Icon = "ic";
        Name = name;
        MenuItemTappedAction = action;
    }

    public override bool HideContextMenuAfterTap => false;
}
