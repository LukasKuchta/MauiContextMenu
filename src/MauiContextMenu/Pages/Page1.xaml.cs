using MauiContextMenu.ViewModels;

namespace MauiApp1;

public partial class Page1 : ContentPage
{
	public Page1(Page1ViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}