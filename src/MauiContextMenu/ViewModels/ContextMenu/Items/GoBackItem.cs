namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class GoBackMenuItem : ContextMenuItemViewModel
{
    public GoBackMenuItem()
    {
        Icon = "ic5";
        Name = "Back";
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(GoBackMenuItem);
}
