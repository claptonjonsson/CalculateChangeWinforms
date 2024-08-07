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
            calculator.Currency = cbCurrency.Text;
            calculator.Price = tbPrice.Text;
            calculator.MoneyGiven = tbMoneyGiven.Text;

            if (calculator.InputErrors == null)
            {
                if (calculator.ShouldChangeBeGiven())
                {
                    lblDisplayInput.Text = "";
                    lblDisplayInfo.Text = calculator.ReturnCalculation();
                    btnCopy.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(calculator.InputErrors, "Error");
                calculator.InputErrors = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPrice.Clear();
            tbMoneyGiven.Clear();
            lblDisplayInfo.Text = "";
            btnCopy.Enabled = false;
            lblDisplayInput.Text = "Fill in the input fields and press 'Calculate'.";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(lblDisplayInfo.Text);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
