namespace CAA.Services;

public interface ITextToSpeechService
{
    Task SpeakAsync(string text, string locale = "pt-BR");
}

public class TextToSpeechService : ITextToSpeechService
{
    public async Task SpeakAsync(string text, string locale = "pt-BR")
    {
        try
        {
            await TextToSpeech.Default.SpeakAsync(text);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Erro na síntese de fala: {ex.Message}");
        }
    }
}
