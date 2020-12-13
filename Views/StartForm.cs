using System;

namespace Assessment3
{
    public partial class StartForm : BrandingParentForm
    {
        public StartForm()
        {
            InitializeComponent();
            //CustomerRepository.getInstance().ReadBinaryData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CRUDCustomerForm Form1 = new CRUDCustomerForm();
            Form1.ShowDialog();
            this.Close();
        }
    }
}
