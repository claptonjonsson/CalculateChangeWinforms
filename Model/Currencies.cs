namespace CalculateChangeWinforms.Model

{
    public static class Currencies
    {
        //Here currencies are added/removed. The key is the currency code and the value an array with the values of the bills and coins.
        private static Dictionary<string, int[]> currencyDic = new()
        {
            {"EUR", new int[] {200, 100, 50, 20, 10, 5, 2, 1 }},
            {"SEK", new int[] {1000, 500, 200, 100, 50, 20, 10, 5, 2, 1}},
            {"USD", new int[] {100, 50, 20, 10, 5, 2, 1}}
        };

        //Passes the currency codes in the above dictionary to the CurrencyInput() method in the Calculator class.
        public static string[] GetCurrencyCodes()
        {
            string[] currencyCodesArray = currencyDic.Keys.ToArray();
            Array.Sort(currencyCodesArray);
            return currencyCodesArray;
        }

        //Passes the specic values for the chosen currency to the CalculateChange() method in the Calculator class.
        public static int[] GetCurrencyValues(string currencyCode)
        {
            int[] values;
            //Checking that the argument is a valid key. The relevant input is already checked in the CurrencyInput() method in the Calculator class but it never hurts to be extra careful.
            if (!currencyDic.TryGetValue(currencyCode, out values))
            {
                MessageBox.Show("You entered an incorrect currency.\n");
                return new int[] { 0 };
            }
            Array.Sort(values);
            //The values must be sorted in decending order so that the highest one is used first in the CalculateChange() method in the Calculator class.
            Array.Reverse(values);
            return values;
        }

    }
}
