namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class UpdateMenuItem : ContextMenuItemViewModel
{
    public UpdateMenuItem()
    {
        Icon = "ic1";
        Name = "Update";
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(UpdateMenuItem);
}

