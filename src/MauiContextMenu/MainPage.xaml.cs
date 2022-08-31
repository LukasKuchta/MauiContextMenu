using MauiContextMenu.Services;
using MauiContextMenu.ViewModels;

namespace MauiContextMenu;

public partial class MainPage : ContentPage
{	
	public MainPage()
	{
		InitializeComponent();
		// TODO - shell pages does not support constructor with prameters
		// add ServiceLocator here or better pattern.
		BindingContext = new MainViewModel(new NavigationService());
	}
}

