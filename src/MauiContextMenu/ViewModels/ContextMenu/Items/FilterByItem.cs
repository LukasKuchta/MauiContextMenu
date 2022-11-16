namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class FilterByMenuItem : ContextMenuItemViewModel
{
    public FilterByMenuItem()
    {
        Icon = "ic4";
        Name = "Filter";
        IsSeparatorVisible = true;
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(FilterByMenuItem);
}
