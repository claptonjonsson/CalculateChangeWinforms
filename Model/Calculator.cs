namespace CalculateChangeWinforms.Model

{
    public class Calculator
    {
        private string currency;
        private int price;
        private int moneyGiven;

        public string Currency {get; set;}
        public int Price {get; set;}
        public int MoneyGiven {get; set;}


        #region Return data for display.

        //Returns user input
        public string ReturnInput()
        {
            return "You purchased products for " +
                   $"{Price} {Currency} and gave {MoneyGiven} {currency}.\n";
        }

        //Prints the result of the CalculateChange() method
        //(which calculates the change to be returned).
        public string ReturnCalculation()
        {
            string calcResult = "You should get back the following "
               + $"bills and/or coins in {Currency}:\n";
            string[] billsAndCoins = CalculateChange();
            foreach (string billAndCoin in billsAndCoins)
            {
               calcResult += billAndCoin + "\n";
            }
            return calcResult;
        }

        #endregion

        #region Values checks

        public bool CheckCurrencyInput(ComboBox comboBox)
        {
            string[] currencyCodes = Currencies.GetCurrencyCodes();
            foreach (string code in currencyCodes)
            {
                if (comboBox.Text == code)
                {
                    Currency = comboBox.Text;
                    return true;
                }
            }
            return false;
        }

        public bool CheckPriceInput(TextBox textBox)
        {
            int num;
            bool isInt = int.TryParse(textBox.Text, out num);
            if (textBox.Text != "" && isInt)
            {
                Price = num;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckMoneyGivenInput(TextBox textBox)
        {
           int num;
           bool isInt = int.TryParse(textBox.Text, out num);
           if (textBox.Text != "" && isInt)
           {
               MoneyGiven = num;
               return true;
           }
           else
           {
               return false;
           }
        }

        #endregion

        #region Calculation related methods.

        //Checks if the money given is not lower than or equal to the price of the items. If it is, calculation is not made until receiving correct input.
        public bool CheckIfChangeShouldBeGiven()
        {
            if (price > moneyGiven)
            {
                MessageBox.Show("According to the data that you entered, you effectively robbed the store. Either that, or you typed incorrect input. This program will assume incorrect input.\n"
                      + "Please try again and enter an amount of money given higher than the price of the purchase.\n");
                return false;
            }
            else if (price == moneyGiven)
            {
                MessageBox.Show("According to the data entered, you paid the same price as the cost of the purchase. You don't need this application to tell you that you get no change back. Try entering different values.\n");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Calculates what change should be returned depending on user input and values stored in the Currencies class dictionary.
        private string[] CalculateChange()
        {
            int[] values = Currencies.GetCurrencyValues(currency);
            int change = moneyGiven - price;
            List<string> changeOrganized = new();
            foreach (int value in values)
            {
                if (change >= value && change > 0)
                {
                    string returnChange = $"{change/value} x {value}\n";
                    changeOrganized.Add(returnChange);
                    change = change-change/value * value;
                }
            }
            string[] changeToBeReturned = changeOrganized.ToArray();
            return changeToBeReturned;
        }

        #endregion

    }
}
