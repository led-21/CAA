namespace CAA.Views;

using CAA.ViewModels;

public partial class HistoryPage : ContentPage
{
   public HistoryPage(HistoryViewModel viewModel)
 {
  InitializeComponent();
   BindingContext = viewModel;
    }

   protected override async void OnAppearing()
 {
       base.OnAppearing();
   if (BindingContext is HistoryViewModel vm)
  {
  await vm.LoadHistoryCommand.ExecuteAsync(null);
    }
    }
}
