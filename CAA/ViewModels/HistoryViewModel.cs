using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CAA.Models;
using CAA.Services;

namespace CAA.ViewModels;

public partial class HistoryViewModel : ObservableObject
{
    private readonly ICommunicationDataService _dataService;

    [ObservableProperty]
    public ObservableCollection<CommunicationPhrase> historyCommunications = new();

    [ObservableProperty]
    public bool isLoading = false;

    public HistoryViewModel(ICommunicationDataService dataService)
    {
        _dataService = dataService;
    }

    [RelayCommand]
    public async Task LoadHistory()
    {
        try
        {
            IsLoading = true;
            var history = await _dataService.GetHistoryAsync();
            HistoryCommunications = new ObservableCollection<CommunicationPhrase>(history);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Erro ao carregar histórico: {ex.Message}");
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    public async Task GoBack()
    {
        await Shell.Current.GoToAsync("//CommunicationPage", animate: false);
    }
}
