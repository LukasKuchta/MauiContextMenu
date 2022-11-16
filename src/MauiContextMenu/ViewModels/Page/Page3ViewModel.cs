using MauiContextMenu.Services.Dialog;
using MauiContextMenu.Services.Settings;
using MauiContextMenu.Services.Navigation;
using MauiContextMenu.ViewModels.ContextMenu;
using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels.Page
{
    public class Page3ViewModel : ContextMenuPageViewModelBase
    {
        public Page3ViewModel(ISettingsService settingsService, INavigationService navigationService, IDialogService dialogService) : base(settingsService, navigationService, dialogService)
        {
            Title = "King kong";
        }

        public override ContextMenuViewModelBase CreateMenu()
        {
            return null;
        }
    }
}
