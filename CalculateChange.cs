using CalculateChangeWinforms.Model;

namespace CalculateChangeWinforms
{
    public partial class CalculateChange : Form
    {
        public CalculateChange()
        {
            InitializeComponent();
            cbCurrency.Items.AddRange(Currencies.GetCurrencyCodes());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculator calculator = new();
            if (
                !calculator.CheckCurrencyInput(cbCurrency) &&
                !calculator.CheckPriceInput(tbPrice) &&
                !calculator.CheckMoneyGivenInput(tbMoneyGiven)
                )
            {
                if (!calculator.CheckIfChangeShouldBeGiven())
                {
                    lblDisplayInfo.Text = calculator.ReturnInput()
                                        + calculator.ReturnCalculation();
                }
            }
            else
            {
                MessageBox.Show(
                        "Somethng went wrong.\n" +
                        "Either you have not selected a currency\n" +
                        "or you did not enter whole numbers\n" +
                        "or you entered a number so large that " +
                        "application cannot handle it."
                        );
            }
        }
    }
}
