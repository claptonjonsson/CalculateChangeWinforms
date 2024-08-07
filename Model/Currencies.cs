namespace CalculateChangeWinforms.Model

{
    public static class Currencies
    {
        //Here currencies are added/removed.
        //Currency code, the highest valued coin (values are counted as bills above this number)
        //and the currency values (bills and coins) constitue a currency.
        private static List<Currency> currencies = new()
        {
            new Currency {CurrencyName = "euro", CurrencyCode = "EUR", HighestCoin = 2, Values = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 } },            /*https://www.ecb.europa.eu/euro/coins/html/index.en.html*/
            new Currency {CurrencyName = "krona", CurrencyCode = "SEK", HighestCoin = 10, Values = new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 } }, /*https://archive.riksbank.se/sv/Sedlar--mynt/Mynt/index.html*/
            new Currency {CurrencyName = "dollar", CurrencyCode = "USD", HighestCoin = 0, Values = new int[] { 100, 50, 20, 10, 5, 2, 1 } }                  /*https://www.bep.gov/currency/circulating-currency*/
        };

        //Passes the currency codes to the Currency combobox.
        public static string[] GetCurrencyCodes()
        {
            List<string> currencyCodes = new();
            foreach (Currency currency in currencies)
            {
                currencyCodes.Add(currency.CurrencyCode);
            }
            string[] currencyCodesArray = currencyCodes.ToArray();
            Array.Sort(currencyCodesArray);
            return currencyCodesArray;
        }

        //Passes the name of selected currency to the Currency property of the Calculator class.
        public static string GetCurrencyName(string currencyCode)
        {
            Currency currency = currencies.First(c => c.CurrencyCode == currencyCode);
            return currency.CurrencyName.ToLower();
        }

        //Passes the highest coin value to the Currency property of the Calculator class.
        public static int GetHighestCoin(string currencyCode)
        {
            Currency currency = currencies.First(c => c.CurrencyCode == currencyCode);
            return currency.HighestCoin;
        }

        //Passes the specic values for the chosen currency to the CalculateChange() method in the Calculator class.
        public static int[] GetCurrencyValues(string currencyCode)
        {
            Currency currency = currencies.First(c => c.CurrencyCode == currencyCode);
            int[] values = currency.Values;
            Array.Sort(values);
            //The values must be sorted in decending order so that the highest one is processed first in the CalculateChange() method in the Calculator class.
            Array.Reverse(values);
            return values;
        }
    }
}