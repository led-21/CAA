using Microsoft.Extensions.Logging;
using CAA.Services;
using CAA.ViewModels;
using CAA.Views;

namespace CAA
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
         var builder = MauiApp.CreateBuilder();
        builder
  .UseMauiApp<App>()
.ConfigureFonts(fonts =>
         {
  fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
       fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
})
        // Registrar Services
              .Services
       .AddSingleton<ITextToSpeechService, TextToSpeechService>()
          .AddSingleton<ICommunicationDataService, CommunicationDataService>()
                // Registrar ViewModels
              .AddSingleton<CommunicationViewModel>()
                  .AddSingleton<HistoryViewModel>()
      // Registrar Pages
         .AddSingleton<CommunicationPage>()
         .AddSingleton<HistoryPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

        return builder.Build();
        }
    }
}
