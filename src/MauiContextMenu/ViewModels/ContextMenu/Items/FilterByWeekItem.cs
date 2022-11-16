namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class FilterByWeekMenuItem : ContextMenuItemViewModel

{
    public FilterByWeekMenuItem()
    {
        Icon = "ic2";
        Name = "By week";
        IsSeparatorVisible = true;
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(FilterByWeekMenuItem);
}
