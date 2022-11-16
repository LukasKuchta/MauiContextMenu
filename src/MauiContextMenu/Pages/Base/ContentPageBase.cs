using MauiContextMenu.ViewModels.Base;

namespace MauiContextMenu.Pages.Base;

public  class ContentPageBase : ContentPage
{
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is IViewModelBase ivmb && !ivmb.IsInitialized)
        {
            ivmb.IsInitialized = true;
            await ivmb.InitializeAsync();
        }
    }
}
