using System;
using System.Windows.Forms;

namespace Assessment3
{
    public partial class AccountForm : BrandingParentForm
    {
        Account account;

        public AccountForm(Everyday everyday)
        {
            MessageBox.Show(everyday.GetInterestRate().ToString());
            //account = everyday;
            InitializeComponent();
            //this.accountIDLabel.Text = account.getAccountID().ToString();
        }

        //public AccountForm(Investment investment)
        //{
        //    InitializeComponent();
        //    this.accountIDLabel.Text = investment.getAccountID().ToString();
        //}

        //public AccountForm(Omni omni)
        //{
        //    InitializeComponent();
        //    this.accountIDLabel.Text = omni.getAccountID().ToString();
        //}

        private void calculateinterestButton_Click(object sender, EventArgs e)
        {

        }
    }
}
