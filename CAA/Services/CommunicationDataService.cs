using CAA.Models;
using System.Text.Json;

namespace CAA.Services;

public interface ICommunicationDataService
{
    Task<List<PictogramCategory>> GetCategoriesForLuizaAsync();
    Task SaveCommunicationAsync(CommunicationPhrase phrase);
    Task<List<CommunicationPhrase>> GetHistoryAsync();
}

public class CommunicationDataService : ICommunicationDataService
{
    private const string HistoryKey = "communication_history";

    public Task<List<PictogramCategory>> GetCategoriesForLuizaAsync()
    {
        var categories = new List<PictogramCategory>
        {
    // CATEGORIA 1: PEDIDOS (Função: pedir objetos/ações)
            new PictogramCategory
            {
                Name = "Pedidos",
                Color = "#FF6B6B",
     Icon = "🛒",
                Pictograms = new List<Pictogram>
                {
        new() { Text = "Água", Symbol = "💧", Color = "#ADD8E6", AudioPhrase = "Quero água", Order = 1 },
        new() { Text = "Comida", Symbol = "🍔", Color = "#FFD700", AudioPhrase = "Quero comer", Order = 2 },
        new() { Text = "Brincar", Symbol = "🧸", Color = "#FF69B4", AudioPhrase = "Quero brincar", Order = 3 },
        new() { Text = "Desenhar", Symbol = "🎨", Color = "#FF1493", AudioPhrase = "Quero desenhar", Order = 4 },
        new() { Text = "Música", Symbol = "🎵", Color = "#9370DB", AudioPhrase = "Quero ouvir música", Order = 5 },
        new() { Text = "Descansar", Symbol = "😴", Color = "#87CEEB", AudioPhrase = "Quero descansar", Order = 6 },
        new() { Text = "Ajuda", Symbol = "🙏", Color = "#FF4500", AudioPhrase = "Preciso de ajuda", Order = 7 },
        new() { Text = "Banheiro", Symbol = "🚽", Color = "#A9A9A9", AudioPhrase = "Preciso ir ao banheiro", Order = 8 },
        new() { Text = "Carro", Symbol = "🚗", Color = "#00BFFF", AudioPhrase = "Eu quero passear de carro", Order = 9 },
        new() { Text = "Chocolate", Symbol = "🍫", Color = "#8B4513", AudioPhrase = "Eu quero chocolate", Order = 10 },
        new() { Text = "Transilvania", Symbol = "🎬", Color = "#800080", AudioPhrase = "Eu quero assistir Hotel Transilvania", Order = 11 },
     }
       },

  // CATEGORIA 2: SOCIALIZAÇÃO (Funções: cumprimentos, interação)
   new PictogramCategory
            {
   Name = "Socialização",
    Color = "#4ECDC4",
          Icon = "👋",
         Pictograms = new List<Pictogram>
        {
        new() { Text = "Olá", Symbol = "👋", Color = "#FFD700", AudioPhrase = "Olá", Order = 1 },
        new() { Text = "Tchau", Symbol = "👋", Color = "#FFD700", AudioPhrase = "Tchau", Order = 2 },
        new() { Text = "Obrigada", Symbol = "🙏", Color = "#90EE90", AudioPhrase = "Obrigada", Order = 3 },
        new() { Text = "Por favor", Symbol = "🙏", Color = "#FFB6C1", AudioPhrase = "Por favor", Order = 4 },
        new() { Text = "Legal!", Symbol = "👍", Color = "#FFD700", AudioPhrase = "Que legal", Order = 5 },
        new() { Text = "Não gosto", Symbol = "👎", Color = "#FF6347", AudioPhrase = "Não gosto", Order = 6 },
     }
    },

       // CATEGORIA 3: INFORMAÇÃO (Funções: expressar opinião, trocar informações)
    new PictogramCategory
   {
     Name = "Informação",
     Color = "#FFE66D",
                Icon = "ℹ️",
     Pictograms = new List<Pictogram>
    {
            new() { Text = "Sim", Symbol = "✅", Color = "#90EE90", AudioPhrase = "Sim", Order = 1 },
            new() { Text = "Não", Symbol = "❌", Color = "#FF6347", AudioPhrase = "Não", Order = 2 },
            new() { Text = "Gosto", Symbol = "❤️", Color = "#FF1493", AudioPhrase = "Eu gosto", Order = 3 },
            new() { Text = "Cansada", Symbol = "😴", Color = "#A9A9A9", AudioPhrase = "Estou cansada", Order = 4 },
            new() { Text = "Feliz", Symbol = "😊", Color = "#FFD700", AudioPhrase = "Estou feliz", Order = 5 },
            new() { Text = "Triste", Symbol = "😢", Color = "#87CEEB", AudioPhrase = "Estou triste", Order = 6 },
            new() { Text = "Dói", Symbol = "🤕", Color = "#FF6347", AudioPhrase = "Dói", Order = 7 },
            new() { Text = "Medo", Symbol = "😨", Color = "#8B008B", AudioPhrase = "Tenho medo", Order = 8 },
    }
            },

            // CATEGORIA 4: AÇÕES DO DIA A DIA
       new PictogramCategory
            {
        Name = "Rotina",
        Color = "#95E1D3",
        Icon = "📅",
        Pictograms = new List<Pictogram>
       {
           new() { Text = "Manhã", Symbol = "☀️", Color = "#FFD700", AudioPhrase = "Bom dia", Order = 1 },
           new() { Text = "Tarde", Symbol = "🌇", Color = "#FFA500", AudioPhrase = "Boa tarde", Order = 2 },
           new() { Text = "Noite", Symbol = "🌙", Color = "#191970", AudioPhrase = "Boa noite", Order = 3 },
           new() { Text = "Escola", Symbol = "🏫", Color = "#8B4513", AudioPhrase = "Vamos para a escola", Order = 4 },
           new() { Text = "Casa", Symbol = "🏠", Color = "#FF69B4", AudioPhrase = "Vamos para casa", Order = 5 },
           new() { Text = "Banho", Symbol = "🛀", Color = "#87CEEB", AudioPhrase = "Hora do banho", Order = 6 },
           new() { Text = "Dormir", Symbol = "😴", Color = "#696969", AudioPhrase = "Hora de dormir", Order = 7 },
  }
            }
        };

        return Task.FromResult(categories);
    }

    public async Task SaveCommunicationAsync(CommunicationPhrase phrase)
    {
        var history = await GetHistoryAsync();
        history.Add(phrase);
        var json = JsonSerializer.Serialize(history);
        Preferences.Set(HistoryKey, json);
    }

    public Task<List<CommunicationPhrase>> GetHistoryAsync()
    {
        var json = Preferences.Get(HistoryKey, string.Empty);
        if (string.IsNullOrEmpty(json))
            return Task.FromResult(new List<CommunicationPhrase>());
        try
        {
            var history = JsonSerializer.Deserialize<List<CommunicationPhrase>>(json);
            return Task.FromResult(history ?? new List<CommunicationPhrase>());
        }
        catch
        {
            return Task.FromResult(new List<CommunicationPhrase>());
        }
    }
}
