using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiContextMenu.Services;

namespace MauiContextMenu.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        [RelayCommand]
        private async Task GoToPage1() 
        {
            await _navigationService.NavigateToAsync(nameof(Page1ViewModel));
        }

        [RelayCommand]
        private async Task GoToPage2()
        {
            
            await _navigationService.NavigateToAsync(nameof(Page2ViewModel));
        }

        [RelayCommand]
        private async Task GoToPage3()
        {
            await _navigationService.NavigateToAsync(nameof(Page3ViewModel));
        }
    }
}
