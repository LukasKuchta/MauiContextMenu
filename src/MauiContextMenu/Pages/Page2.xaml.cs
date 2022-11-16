using MauiContextMenu.Pages.Base;
using MauiContextMenu.ViewModels.Page;

namespace MauiApp1;

public partial class Page2 : ContentPageBase
{
    public Page2(Page2ViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

}