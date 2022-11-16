namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class GoToPage3MenuItem : ContextMenuItemViewModel
{
    public GoToPage3MenuItem(int actionId)
    {
        Icon = "ic4";
        Name = "Go to page3";
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(GoToPage3MenuItem);
}
