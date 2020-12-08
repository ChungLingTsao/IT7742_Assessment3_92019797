using System;
using System.Windows.Forms;

namespace Assessment3
{
    public partial class ManageAccountsForm : BrandingParentForm
    {
        public ManageAccountsForm(Customer c)
        {
            InitializeComponent();
            //customer initialisation
        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            AddAccountForm addaccform = new AddAccountForm();
            addaccform.ShowDialog(); // ShowDialog used to prevent selecting main form until this form completed
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            AccountForm accform = new AccountForm();
            accform.ShowDialog();
        }
    }
}
