using MauiContextMenu.ViewModels;

namespace MauiApp1;

public partial class Page2 : ContentPage
{
	public Page2(Page2ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}