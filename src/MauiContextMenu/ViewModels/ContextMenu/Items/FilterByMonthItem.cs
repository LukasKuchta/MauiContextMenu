namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class FilterByMonthMenuItem : ContextMenuItemViewModel
{
    public FilterByMonthMenuItem()
    {
        Icon = "ic";
        Name = "By month";
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(FilterByMonthMenuItem);
}
