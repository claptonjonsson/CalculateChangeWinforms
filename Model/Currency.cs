namespace CalculateChangeWinforms.Model;

public class Currency
{
    public string CurrencyName {get; set;}
    public string CurrencyCode { get; set; }
    public int HighestCoin { get; set; }
    public int[] Values { get; set; }
}
