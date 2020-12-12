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
        }

        private void everydayButton_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to create a new everyday account?", "Create Account", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                currentCustomer.AccountList.Add(new Everyday(1, startBalance));
                MessageBox.Show("Everyday account successfully created");
                this.Close(); // Close form and return to ManageAccountForm

                CustomerRepository customerRepo = new CustomerRepository();
                customerRepo.EditCustomer(currentCustomer, currentCustomer.CustomerNumber);
            }
        }

        private void investmentButton_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to create a new investment account?", "Create Account", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                currentCustomer.AccountList.Add(new Investment(1, startBalance, interestRate, failFee));
                MessageBox.Show("Investment account successfully created");
                this.Close(); // Close form and return to ManageAccountForm

                CustomerRepository customerRepo = new CustomerRepository();
                customerRepo.EditCustomer(currentCustomer, currentCustomer.CustomerNumber);
            }
        }

        private void omniButton_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to create a new omni account?", "Create Account", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                currentCustomer.AccountList.Add(new Omni(1, startBalance, interestRate, failFee, omniRequiredBalance, omniOverdraftLimit));
                MessageBox.Show("Omni account successfully created");
                this.Close(); // Close form and return to ManageAccountForm

                CustomerRepository customerRepo = new CustomerRepository();
                customerRepo.EditCustomer(currentCustomer, currentCustomer.CustomerNumber);
            }
        }
    }
}
