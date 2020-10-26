using System;

namespace Assessment2
{
    public partial class StartForm : BrandingParentForm
    {
        public CRUDCustomerForm Form1 = new CRUDCustomerForm();

        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1.ShowDialog();
        }
    }
}
