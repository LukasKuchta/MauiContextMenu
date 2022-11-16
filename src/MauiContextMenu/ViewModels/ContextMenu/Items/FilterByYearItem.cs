namespace MauiContextMenu.ViewModels.ContextMenu.Items;

internal class FilterByYearMenuItem
: ContextMenuItemViewModel
{
    public FilterByYearMenuItem()
    {
        Icon = "ic2";
        Name = "By year";
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(FilterByYearMenuItem);
}
