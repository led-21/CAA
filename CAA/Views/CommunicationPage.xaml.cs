namespace CAA.Views;

using CAA.ViewModels;

public partial class CommunicationPage : ContentPage
{
   public CommunicationPage(CommunicationViewModel viewModel)
 {
    InitializeComponent();
   BindingContext = viewModel;
    }

   protected override async void OnAppearing()
    {
base.OnAppearing();
        if (BindingContext is CommunicationViewModel vm)
        {
      await vm.LoadCategoriesCommand.ExecuteAsync(null);
   }
  }
}
