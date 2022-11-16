using MauiContextMenu.Pages.Base;
using MauiContextMenu.ViewModels.Page;

namespace MauiApp1;

public partial class Page1 : ContentPageBase
{
    public Page1(Page1ViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}