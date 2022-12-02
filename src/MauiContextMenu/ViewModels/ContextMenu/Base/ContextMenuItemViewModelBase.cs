using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiContextMenu.ViewModels.ContextMenu.Base;
public abstract partial class ContextMenuItemViewModelBase : ObservableObject
{
    [ObservableProperty]
    private string _name;
}