namespace CalculateChangeWinforms.Model

{
    public class Calculator
    {
        private string currency;
        private string currencyName;
        private int highestCoin; //Highest coin value to determine if bill or coin.
        private int price;
        private int moneyGiven;
        private string inputErrors = "";

        #region Properties

        //Each property setter handles input validation.
        //If the input is not valid, an error message is passed to the
        //InputErrors property and displayed together with other errors.

        //When a currency is selected, the Currency property uses this value
        //to also get the name of the currency and its highest valued coin.
        public string Currency
        {
            get { return currency; }
            set
            {
                if (value != "")
                {
                    currency = value;
                    currencyName = Currencies.GetCurrencyName(value);
                    highestCoin = Currencies.GetHighestCoin(value);
                }
                else
                {
                    InputErrors += "* Currency: You did not select a currency.\n\n";
                }
            }
        }

        public string Price
        {
            get { return price.ToString(); }
            set
            {
                int num;
                bool isInt = int.TryParse(value, out num);
                if (value != "" && isInt)
                {
                    price = num;
                }
                else
                {
                    InputErrors += "* Price: You did not enter a whole number.\n\n";
                }
            }
        }

        public string MoneyGiven
        {
            get { return moneyGiven.ToString(); }
            set
            {
                int num;
                bool isInt = int.TryParse(value, out num);
                if (value != "" && isInt)
                {
                    moneyGiven = num;
                }
                else
                {
                    InputErrors += "* Money given: You did not enter a whole number.\n\n";
                }
            }
        }

        public string InputErrors { get; set; }

        #endregion Properties

        #region Return data for display

        //Passes on the result of the CalculateChange() method modified for display.
        public string ReturnCalculation()
        {
            string calcResult = "You get back the following "
               + "bills and/or coins:\n\n";
            string[] billsAndCoins = CalculateChange();
            foreach (string billAndCoin in billsAndCoins)
            {
                calcResult += billAndCoin + "\n";
            }
            return calcResult;
        }

        #endregion Return data for display

        #region Calculation-related methods

        //Checks if the money given is lower than or equal to the price of the items.
        public bool ShouldChangeBeGiven()
        {
            if (price > moneyGiven)
            {
                MessageBox.Show("According to the data that you entered, you effectively robbed the store. Either that, or you typed incorrect input. This program will assume incorrect input.\n\n"
                      + "Please try again and enter an amount of money given higher than the price of the purchase.\n", "No change");
                return false;
            }
            else if (price == moneyGiven)
            {
                MessageBox.Show("According to the data entered, you paid the same price as the cost of the purchase. You don't need this application to tell you that you get no change back. Try entering other values.\n", "No change");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Calculates what change should be returned depending on user input and
        //values stored in the Currencies class.
        private string[] CalculateChange()
        {
            int[] values = Currencies.GetCurrencyValues(currency);
            int change = moneyGiven - price;
            List<string> changeOrganized = new();
            foreach (int value in values)
            {
                if (change >= value && change > 0)
                {
                    string returnChange = $"{change / value} x {value}-{currencyName} ";
                    if (value > highestCoin)
                    {
                        returnChange += "bill";
                    }
                    else
                    {
                        returnChange += "coin";
                    }
                    if (change / value > 1)
                    {
                        returnChange += "s\n";
                    }
                    else
                    {
                        returnChange += "\n";
                    }
                    changeOrganized.Add(returnChange);
                    change = change - change / value * value;
                }
            }
            string[] changeToBeReturned = changeOrganized.ToArray();
            return changeToBeReturned;
        }

        #endregion Calculation-related methods
    }
}