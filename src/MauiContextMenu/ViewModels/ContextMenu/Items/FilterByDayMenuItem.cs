namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class FilterByDayMenuItem : ContextMenuItemViewModel
{
    public FilterByDayMenuItem()
    {
        Icon = "ic2";
        Name = "By day";
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(FilterByDayMenuItem);
}
