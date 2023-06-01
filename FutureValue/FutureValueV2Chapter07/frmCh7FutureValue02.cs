using System;
using System.Windows.Forms;

namespace FutureValueV2Chapter07
{
    public partial class frmCh7FutureValue02 : Form
    {
        public frmCh7FutureValue02()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            GetFutureValue();
        }

        private void GetFutureValue()
        {
            try
            {
                decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
                decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
                int years = Convert.ToInt32(txtNumberOfYears.Text);

                int months = years * 12;
                decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                decimal futureValue = CalculateFutureValue(
                    monthlyInvestment, monthlyInterestRate, months);

                txtFutureValue.Text = futureValue.ToString("c");
                txtMonthlyInvestment.Focus();
            }
            catch (FormatException fe)
            {
                ShowMessage(fe.Message, "ENTRY ERROR");
            }

            catch (OverflowException oe)
            {
                ShowMessage(oe.Message, "ENTRY ERROR");
            }

            catch (Exception ex)
            {
                ShowMessage(ex.Message, "ENTRY ERROR");
            }
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
