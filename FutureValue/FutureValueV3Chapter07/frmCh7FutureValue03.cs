using System;
using System.Windows.Forms;

namespace FutureValueV3Chapter07
{
    public partial class frmCh7FutureValue03 : Form
    {
        public frmCh7FutureValue03()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const decimal MININVESTMENT =   10M;
        const decimal MAXINVESTMENT = 1000M;
        const decimal MININTRATE    =    1M;
        const decimal MAXINTRATE    =   20M;
        const int     MINUMYEARS    =    1;
        const int     MAXNUMYEARS   =   40;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            PerformCalculation();
        }

        private void PerformCalculation()
        {
            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment  = Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
                    int     years              = Convert.ToInt32(txtNumberOfYears.Text);

                    int months = years * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, monthlyInterestRate, months);

                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                }
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, "ENTRY ERROR");
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //	Validate the Monthly Investment TextBox
            errorMessage += IsDecimal(txtMonthlyInvestment.Text, "monthlyInvestment");
            errorMessage += IsWithinRange(txtMonthlyInvestment.Text, "monthlyInvestment",
                            MININVESTMENT, MAXINVESTMENT);

            //	Validate the Yearly Interest Rate
            errorMessage += IsDecimal(txtYearlyInterestRate.Text, "yearlyInterestRate");
            errorMessage += IsWithinRange(txtYearlyInterestRate.Text, "yearlyInterestRate",
                            MININTRATE, MAXINTRATE);

            //	Validate the Number Of Years
            errorMessage += IsInt32(txtNumberOfYears.Text, "numberOfYears");
            errorMessage += IsWithinRange(txtNumberOfYears.Text, "numberOfYears",
                            MINUMYEARS, MAXNUMYEARS);

            if (errorMessage != "")
            {
                success = false;
                ShowMessage(errorMessage, "Entry Errors");
            }

            return success;
        }

        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
            }

            return msg;
        }

        private string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg = name + " must be a valid integer value.\n";
            }

            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if ((number < min) || (number > max))
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                }
            }

            return msg;
        }

        private decimal CalculateFutureValue(
                    decimal monthlyInvestment, decimal monthlyInterestRate, decimal months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtMonthlyInvestment.Text = "";
            txtYearlyInterestRate.Text = "";
            txtNumberOfYears.Text = "";
            txtFutureValue.Text = "";
            txtMonthlyInvestment.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
