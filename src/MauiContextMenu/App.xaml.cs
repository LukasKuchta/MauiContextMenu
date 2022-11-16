using MauiApp1;
using MauiContextMenu.ViewModels.Page;

namespace MauiContextMenu;

public partial class App : Application
{
	public App(AppShell mainPage)
	{
		InitializeComponent();

		MainPage = mainPage;

        Routing.RegisterRoute(nameof(Page1ViewModel), typeof(Page1));
        Routing.RegisterRoute(nameof(Page2ViewModel), typeof(Page2));
        Routing.RegisterRoute(nameof(Page3ViewModel), typeof(Page3));
    }
}
