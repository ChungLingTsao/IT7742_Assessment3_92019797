using System.Windows.Forms;

namespace Assessment3
{
    public partial class AddAccountForm : PopupParentForm
    {
        Customer currentCustomer;

        /* Current Bank Offers  */
        private const double startBalance = 0;
        private const double interestRate = 0.04;
        private const double failFee = 10;
        private const double omniRequiredBalance = 500;
        private const double omniOverdraftLimit = 500;

        public AddAccountForm(Customer c)
        {
            InitializeComponent();
            currentCustomer = c;
            this.titleLabel.Text = "ADD NEW ACCOUNT";
        }

        // User is able to add an everyday account to the customer
        private void everydayButton_Click(object sender, System.EventArgs e)
        {
            int accountCount = currentCustomer.AccountList.Count;
            Everyday newEveryday = new Everyday(accountCount + 1, startBalance);

            DialogResult result = MessageBox.Show("Are you sure you want to create a new everyday account?", "Create Account", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                controller.AddAccount(currentCustomer, newEveryday);
                MessageBox.Show("Everyday account successfully created");

                this.Close(); // Close form and return to ManageAccountForm
            }
        }

        // User is able to add an investment account to the customer
        private void investmentButton_Click(object sender, System.EventArgs e)
        {
            int accountCount = currentCustomer.AccountList.Count;
            Investment newInvestment = new Investment(accountCount + 1, startBalance, interestRate, failFee);

            DialogResult result = MessageBox.Show("Are you sure you want to create a new investment account?", "Create Account", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                controller.AddAccount(currentCustomer, newInvestment);
                MessageBox.Show("Investment account successfully created");

                this.Close(); // Close form and return to ManageAccountForm
            }
        }

        // User is able to add an omni account to the customer
        private void omniButton_Click(object sender, System.EventArgs e)
        {
            int accountCount = currentCustomer.AccountList.Count;
            Omni newOmni = new Omni(accountCount + 1, startBalance, interestRate, failFee, omniRequiredBalance, omniOverdraftLimit);

            DialogResult result = MessageBox.Show("Are you sure you want to create a new omni account?", "Create Account", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                controller.AddAccount(currentCustomer, newOmni);
                MessageBox.Show("Omni account successfully created");

                this.Close(); // Close form and return to ManageAccountForm
            }
        }

        // Close the current dialog form
        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
