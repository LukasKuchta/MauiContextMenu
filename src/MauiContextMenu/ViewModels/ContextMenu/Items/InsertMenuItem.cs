namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class InsertMenuItem : ContextMenuItemViewModel
{
    public InsertMenuItem()
    {
        Icon = "ic3";
        Name = "Insert";
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(InsertMenuItem);
}
