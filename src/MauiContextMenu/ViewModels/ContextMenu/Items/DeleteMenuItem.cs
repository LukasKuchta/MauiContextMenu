namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class DeleteMenuItem : ContextMenuItemViewModel
{
    public DeleteMenuItem()
    {
        Icon = "ic1";
        Name = "Delete";
        IsDangerous = true;
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(DeleteMenuItem);

}

