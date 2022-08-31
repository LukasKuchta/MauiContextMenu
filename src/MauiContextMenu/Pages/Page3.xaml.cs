using MauiContextMenu.ViewModels;

namespace MauiApp1;

public partial class Page3 : ContentPage
{
	public Page3(Page3ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}