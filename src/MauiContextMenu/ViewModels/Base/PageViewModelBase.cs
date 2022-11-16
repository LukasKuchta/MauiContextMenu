using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiContextMenu.Services.Dialog;
using MauiContextMenu.Services.Navigation;
using MauiContextMenu.Services.Settings;

namespace MauiContextMenu.ViewModels.Base;

public abstract partial class PageViewModelBase : ObservableObject, IViewModelBase, IDisposable
{
    private readonly SemaphoreSlim _isBusyLock = new(1, 1);
    private bool _disposedValue;

    public INavigationService NavigationService { get; init; }
    public IDialogService DialogService { get; init; }
    public ISettingsService SettingsService { get; init; }

    public PageViewModelBase(ISettingsService settingsService, INavigationService navigationService, IDialogService dialogService)
    {
        SettingsService = settingsService;
        NavigationService = navigationService;
        DialogService = dialogService;
    }

    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    private bool _isInitialized;

    [ObservableProperty]
    private string _title;

    public virtual Task InitializeAsync()
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// Back button on the top bar left side icon
    /// </summary>
    /// <returns></returns>
    [RelayCommand]
    private async Task GoBack()
    {
        await NavigationService.PopAsync();
    }

    public async Task IsBusyFor(Func<Task> unitOfWork)
    {
        await _isBusyLock.WaitAsync();

        try
        {
            IsBusy = true;

            await unitOfWork();
        }
        finally
        {
            IsBusy = false;
            _isBusyLock.Release();
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                _isBusyLock?.Dispose();
            }

            _disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

