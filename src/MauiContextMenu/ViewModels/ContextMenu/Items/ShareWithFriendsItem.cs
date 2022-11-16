namespace MauiContextMenu.ViewModels.ContextMenu.Items;
public class ShareWithFriendsMenuItem : ContextMenuItemViewModel
{
    public ShareWithFriendsMenuItem()
    {
        Icon = "ic2";
        Name = "Share with friends";
        IsSeparatorVisible = true;
    }

    public override string Id => ActionId;
    public const string ActionId = nameof(ShareWithFriendsMenuItem);
}
