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

        //When the Calculate button is clicked, values are passed from
        //the input fields to the Calculator object and, if inputs are vaid,
        //the change is calculated and displayed. If not valid, errors are shown.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculator calculator = new();
            calculator.Currency = cbCurrency.Text;
            calculator.Price = tbPrice.Text;
            calculator.MoneyGiven = tbMoneyGiven.Text;

            if (calculator.InputErrors == null)
            {
                if (calculator.ShouldChangeBeGiven())
                {
                    lblDisplayInput.Text = "";
                    lblDisplayInfo.Text = calculator.ReturnCalculation();
                    btnCopy.Enabled = true; //Copy button only enabled when there are results to copy.
                }
            }
            else
            {
                MessageBox.Show(calculator.InputErrors, "Error");
                calculator.InputErrors = "";
            }
        }

        //Button to clear input fields before a new calculation.
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPrice.Clear();
            tbMoneyGiven.Clear();
            lblDisplayInfo.Text = "";
            btnCopy.Enabled = false;
            lblDisplayInput.Text = "Fill in the input fields and press 'Calculate'.";
        }

        //Button to copy the displayed calculation results.
        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(lblDisplayInfo.Text);
        }

        //Button to quit the program.
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}