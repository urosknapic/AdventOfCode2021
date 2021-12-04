namespace AdventOfCode2021
{
  public class DayFour
  {
    public BingoData GetBingoData(string fileName)
    {
      var text = ReadFile(fileName);

      var partsOfFIle = text.Split("\r\n\r\n");

      var bingoDataModel = new BingoData();
      bingoDataModel.Numbers = partsOfFIle[0].Split(',').Select(num => int.Parse(num)).ToList();
      bingoDataModel.Cards = new List<BingoCards>();

      for (var i = 1; i< partsOfFIle.Length; i++)
      {
        var bingoCard = new BingoCards();
        bingoCard.CardNumbers = new List<List<int>>();


        var cardString = partsOfFIle[i];
        var rows = cardString.Split("\r\n");

        foreach (var row in rows)
        {
          var numbers = row.Split(' ').Where(numString => !string.IsNullOrEmpty(numString)).ToList();
          var intNumbers = numbers.Select(n => int.Parse(n)).ToList();
          bingoCard.CardNumbers.Add(intNumbers);
        }
        bingoDataModel.Cards.Add(bingoCard);
      }
      return bingoDataModel;
    }
    private string ReadFile(string fileName)
    {
      string text = File.ReadAllText(@"C:\uros\adventOfCode2021\AdventOfCode2021\AdventOfCode2021\Utilities\DayFour\" + fileName);
      return text;
    }
  }

  public class BingoData
  {
    public List<int> Numbers { get; set; }
    public List<BingoCards> Cards { get; set; }
  }

  public class BingoCards
  {
    public List<List<int>> CardNumbers { get; set; }
  }
}
