namespace MauiContextMenu.ViewModels.ContextMenu.Items;

public class DeleteMenuItem : ItemContextMenuViewModel
{
    public DeleteMenuItem()
    {
        Icon = "ic1";
        Name = "Delete";
        IsDangerous = true;
    }
}

