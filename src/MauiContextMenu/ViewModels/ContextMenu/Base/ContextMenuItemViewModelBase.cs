using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;

namespace MauiContextMenu.ViewModels.ContextMenu.Base;
public abstract partial class ContextMenuItemViewModelBase : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
{
    [ObservableProperty]
    private string _name;
}