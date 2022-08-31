using MauiContextMenu.Services;
using MauiContextMenu.ViewModels.ContextMenu.Base;

namespace MauiContextMenu.ViewModels
{
    public class Page3ViewModel : ContextMenuPageViewModelBase
    {
        public Page3ViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "King kong";
            ContextMenuViewModel = null; // or keept it as is
        }
    }
}
