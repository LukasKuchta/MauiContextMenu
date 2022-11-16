using MauiContextMenu.Pages.Base;
using MauiContextMenu.ViewModels.Page;

namespace MauiApp1;

public partial class Page3 : ContentPageBase
{
	public Page3(Page3ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}