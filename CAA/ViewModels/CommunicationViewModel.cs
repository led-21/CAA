using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CAA.Models;
using CAA.Services;

namespace CAA.ViewModels;

public partial class CommunicationViewModel : ObservableObject
{
    private readonly ICommunicationDataService _dataService;
    private readonly ITextToSpeechService _textToSpeechService;

    [ObservableProperty]
 public ObservableCollection<PictogramCategory> categories = new();

  [ObservableProperty]
   public ObservableCollection<Pictogram> selectedPictograms = new();

   [ObservableProperty]
    public string communicationText = string.Empty;

 [ObservableProperty]
    public bool isLoading = false;

    public CommunicationViewModel(ICommunicationDataService dataService, ITextToSpeechService textToSpeechService)
    {
       _dataService = dataService;
   _textToSpeechService = textToSpeechService;
   }

    [RelayCommand]
  public async Task LoadCategories()
    {
   try
        {
 IsLoading = true;
       var categories = await _dataService.GetCategoriesForLuizaAsync();
  Categories = new ObservableCollection<PictogramCategory>(categories);
   }
catch (Exception ex)
      {
          System.Diagnostics.Debug.WriteLine($"Erro ao carregar categorias: {ex.Message}");
        }
     finally
    {
       IsLoading = false;
          }
    }

    [RelayCommand]
   public async Task SelectPictogram(Pictogram pictogram)
  {
      if (pictogram == null) return;

      SelectedPictograms.Add(pictogram);
        UpdateCommunicationText();
    }

  [RelayCommand]
   public void RemovePictogram(Pictogram pictogram)
  {
     if (pictogram == null) return;

  SelectedPictograms.Remove(pictogram);
        UpdateCommunicationText();
  }

  [RelayCommand]
 public async Task Speak()
 {
     if (string.IsNullOrEmpty(CommunicationText)) return;

       var phrases = SelectedPictograms
     .Select(p => p.AudioPhrase)
          .Where(p => !string.IsNullOrEmpty(p))
    .ToList();

      if (phrases.Count > 0)
        {
  var fullPhrase = string.Join(" ", phrases);
  await _textToSpeechService.SpeakAsync(fullPhrase);
      }
    }

  [RelayCommand]
 public void Clear()
    {
 SelectedPictograms.Clear();
       UpdateCommunicationText();
    }

  private void UpdateCommunicationText()
  {
  CommunicationText = string.Join(" ", SelectedPictograms.Select(p => p.Text));
   }
}
