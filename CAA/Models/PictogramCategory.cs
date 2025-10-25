namespace CAA.Models;

public class PictogramCategory
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = "#FFFFFF";
    public string Icon { get; set; } = "??";
    public List<Pictogram> Pictograms { get; set; } = new();
}

public class Pictogram
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Text { get; set; } = string.Empty;
  public string Symbol { get; set; } = "??";
    public string Color { get; set; } = "#FFFFFF";
    public string AudioPhrase { get; set; } = string.Empty;
    public int Order { get; set; }
}

public class CommunicationPhrase
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateTime Timestamp { get; set; } = DateTime.Now;
    public List<Pictogram> SelectedPictograms { get; set; } = new();
 public string FinalPhrase { get; set; } = string.Empty;
}
