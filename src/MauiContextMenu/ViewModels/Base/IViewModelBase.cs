using MauiContextMenu.Services.Dialog;
using MauiContextMenu.Services.Navigation;
using MauiContextMenu.Services.Settings;

namespace MauiContextMenu.ViewModels.Base
{
    public interface IViewModelBase
    {
        public IDialogService DialogService { get; }
        public ISettingsService SettingsService { get; }
        public INavigationService NavigationService { get; }

        public bool IsBusy { get; }

        public bool IsInitialized { get; set; }

        Task InitializeAsync();
    }
}
