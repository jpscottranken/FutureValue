using System;
using System.Windows.Forms;

namespace FutureValueV1Chapter07
{
    public partial class frmCh7FutureValue01 : Form
    {
        public frmCh7FutureValue01()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateFutureValue();
        }

        private void CalculateFutureValue()
        {

            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int years = Convert.ToInt32(txtNumberOfYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtMonthlyInvestment.Text  = "";
            txtYearlyInterestRate.Text = "";
            txtNumberOfYears.Text      = "";
            txtFutureValue.Text        = "";
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

        private void txtMonthlyInvestment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYearlyInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberOfYears_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFutureValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMonthlyInvestment_Click(object sender, EventArgs e)
        {

        }

        private void lblYearlyInterestRate_Click(object sender, EventArgs e)
        {

        }

        private void lblNumberOfYears_Click(object sender, EventArgs e)
        {

        }

        private void lblFutureValue_Click(object sender, EventArgs e)
        {

        }
    }
}
