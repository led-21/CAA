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
        var start = DateTime.Now;
        base.OnAppearing();
        if (BindingContext is HistoryViewModel vm)
        {
            await vm.LoadHistoryCommand.ExecuteAsync(null);
        }
        var end = DateTime.Now;
        System.Diagnostics.Debug.WriteLine($"HistoryPage carregada em {(end - start).TotalMilliseconds} ms");
    }
}
