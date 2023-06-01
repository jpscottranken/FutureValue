﻿namespace FutureValueV1Chapter07
{
    partial class frmCh7FutureValue01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtYearlyInterestRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.lblMonthlyInvestment = new System.Windows.Forms.Label();
            this.lblYearlyInterestRate = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.lblFutureValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(91, 503);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 64);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(316, 503);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 64);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(543, 503);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 64);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(426, 54);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(265, 44);
            this.txtMonthlyInvestment.TabIndex = 0;
            this.txtMonthlyInvestment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonthlyInvestment.TextChanged += new System.EventHandler(this.txtMonthlyInvestment_TextChanged);
            // 
            // txtYearlyInterestRate
            // 
            this.txtYearlyInterestRate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearlyInterestRate.Location = new System.Drawing.Point(426, 166);
            this.txtYearlyInterestRate.Name = "txtYearlyInterestRate";
            this.txtYearlyInterestRate.Size = new System.Drawing.Size(265, 44);
            this.txtYearlyInterestRate.TabIndex = 1;
            this.txtYearlyInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYearlyInterestRate.TextChanged += new System.EventHandler(this.txtYearlyInterestRate_TextChanged);
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfYears.Location = new System.Drawing.Point(426, 284);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(265, 44);
            this.txtNumberOfYears.TabIndex = 2;
            this.txtNumberOfYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumberOfYears.TextChanged += new System.EventHandler(this.txtNumberOfYears_TextChanged);
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFutureValue.Location = new System.Drawing.Point(426, 401);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(265, 44);
            this.txtFutureValue.TabIndex = 6;
            this.txtFutureValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFutureValue.TextChanged += new System.EventHandler(this.txtFutureValue_TextChanged);
            // 
            // lblMonthlyInvestment
            // 
            this.lblMonthlyInvestment.BackColor = System.Drawing.Color.Lime;
            this.lblMonthlyInvestment.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyInvestment.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyInvestment.Location = new System.Drawing.Point(88, 54);
            this.lblMonthlyInvestment.Name = "lblMonthlyInvestment";
            this.lblMonthlyInvestment.Size = new System.Drawing.Size(318, 44);
            this.lblMonthlyInvestment.TabIndex = 7;
            this.lblMonthlyInvestment.Text = "Monthly Investment:";
            this.lblMonthlyInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMonthlyInvestment.Click += new System.EventHandler(this.lblMonthlyInvestment_Click);
            // 
            // lblYearlyInterestRate
            // 
            this.lblYearlyInterestRate.BackColor = System.Drawing.Color.Lime;
            this.lblYearlyInterestRate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearlyInterestRate.ForeColor = System.Drawing.Color.Black;
            this.lblYearlyInterestRate.Location = new System.Drawing.Point(88, 169);
            this.lblYearlyInterestRate.Name = "lblYearlyInterestRate";
            this.lblYearlyInterestRate.Size = new System.Drawing.Size(318, 41);
            this.lblYearlyInterestRate.TabIndex = 8;
            this.lblYearlyInterestRate.Text = "Yearly Interest Rate::";
            this.lblYearlyInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYearlyInterestRate.Click += new System.EventHandler(this.lblYearlyInterestRate_Click);
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.BackColor = System.Drawing.Color.Lime;
            this.lblNumberOfYears.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfYears.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfYears.Location = new System.Drawing.Point(88, 284);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(318, 44);
            this.lblNumberOfYears.TabIndex = 9;
            this.lblNumberOfYears.Text = "Number Of Years:";
            this.lblNumberOfYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumberOfYears.Click += new System.EventHandler(this.lblNumberOfYears_Click);
            // 
            // lblFutureValue
            // 
            this.lblFutureValue.BackColor = System.Drawing.Color.Lime;
            this.lblFutureValue.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFutureValue.ForeColor = System.Drawing.Color.Black;
            this.lblFutureValue.Location = new System.Drawing.Point(88, 401);
            this.lblFutureValue.Name = "lblFutureValue";
            this.lblFutureValue.Size = new System.Drawing.Size(318, 44);
            this.lblFutureValue.TabIndex = 10;
            this.lblFutureValue.Text = "FutureValue:";
            this.lblFutureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFutureValue.Click += new System.EventHandler(this.lblFutureValue_Click);
            // 
            // frmCh7FutureValue01
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.lblFutureValue);
            this.Controls.Add(this.lblNumberOfYears);
            this.Controls.Add(this.lblYearlyInterestRate);
            this.Controls.Add(this.lblMonthlyInvestment);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtYearlyInterestRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmCh7FutureValue01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value With No Error Handling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtYearlyInterestRate;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Label lblMonthlyInvestment;
        private System.Windows.Forms.Label lblYearlyInterestRate;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.Label lblFutureValue;
    }
}

