/* 
 * BankingSystemApp.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: A prototype application for the banking system that allows money to be 
 *              withdrawn/deposited into a single person's accounts.
*/

using Assessment3;
using System;
using System.Windows.Forms;

namespace Assessment3
{
    public partial class BankingSystemApp : Form
    {
        // The prototype does not require the implementation of the 'person' class. 
        // Hence an instance of each account subclass was created for an assumed customer (not bank staff).
        Everyday everyday = new Everyday(325818, 100.00);
        Investment investment = new Investment(321654, 200.00, 0.020, 20);
        Omni omni = new Omni(327161, 200.10, 0.025, 20, 1000, 500);

        public BankingSystemApp()
        {
            InitializeComponent();
            InitializeAccountID();
            UpdateBalanceLabels();
        }

        // Initialises the Account ID text
        private void InitializeAccountID()
        {
            tabeverdayidLabel.Text = $"Account ID: {everyday.getAccountID()}";
            tabinvestmentidLabel.Text = $"Account ID: {investment.getAccountID()}";
            tabomniidLabel.Text = $"Account ID: {omni.getAccountID()}";
        }

        // Updates all labels related to account balance
        private void UpdateBalanceLabels()
        {
            tabeverydaybalanceLabel.Text = $"${everyday.getBalance():F}"; // "F" is used to format double to 2 decimal places
            tabinvestmentbalanceLabel.Text = $"${investment.getBalance():F}";
            tabomnibalanceLabel.Text = $"${omni.getBalance():F}";

            ebalanceLabel.Text = $"${everyday.getBalance():F}"; 
            ibalanceLabel.Text = $"${investment.getBalance():F}";
            obalanceLabel.Text = $"${omni.getBalance():F}";
        }

        /********************
         * Everyday Account *
         ********************/

        // Handles the withdrawl of an inputted amount
        private void tabeverydaywithdrawButton_Click(object sender, EventArgs e)
        {
            // Tries to parse the inputted text as a double. If not, an error message appears
            bool isDouble = Double.TryParse(tabeverydayinputTextBox.Text, out double amount);

            if (isDouble && ((everyday.getBalance() - amount) >= 0)) // Cannot withdraw below 0 or if input text is invalid.
            {
                everyday.Withdraw(amount);
                
                // Creates a transaction
                Transaction transaction = new Transaction(false, amount, everyday, ActionTypes.Withdraw);
                tabeverydayListBox.Items.Add(transaction.ToString());

                UpdateBalanceLabels();
            }
            else
            {
                MessageBox.Show("Please enter a valid withdrawl amount!", "WARNING");
            }
        }

        // Handles the deposit of an inputted amount
        private void tabeverydaydepositButton_Click(object sender, EventArgs e)
        {
            bool isDouble = Double.TryParse(tabeverydayinputTextBox.Text, out double amount);

            if (isDouble)
            {
                everyday.Deposit(amount);

                Transaction transaction = new Transaction(false, amount, everyday, ActionTypes.Deposit);
                tabeverydayListBox.Items.Add(transaction.ToString());

                UpdateBalanceLabels();
            }
            else
            {
                MessageBox.Show("Please enter a valid deposit amount!", "WARNING");
            }

        }

        /****************
         * Omni Account *
         ****************/

        // Calculates the amount of interest the account can earn in a year
        private void tabomnicalculateButton_Click(object sender, EventArgs e)
        {
            double rate = omni.GetInterestRate();
            double balance = omni.getBalance();
            double interestRecieved = rate * balance;

            if (omni.isSufficentBalance()) { 
                MessageBox.Show($"Interest recieved per annum is: ${interestRecieved:F} \n\n" +
                    "Calculated using: \n" +
                    $"Rate: {(rate*100):F}% \n" +
                    $"Balance: ${balance:F}", 
                    "Calculating interest");
            }
            else
            {
                MessageBox.Show("Interest recieved per annum is: $0.00 \n\n" +
                    "This is due to the account not having enough balance. \n" +
                    $"MUST BE GREATER THAN ${omni.getRequiredBalance()}");
            }
        }

        // Handler to add the interest gained over a year. Only applies if the account has more than the required balance.
        private void tabomniaddButton_Click(object sender, EventArgs e)
        {
            double interestRecieved = omni.GetInterestRate() * omni.getBalance();
            if (omni.isSufficentBalance())
            {
                omni.Deposit(interestRecieved);
                Transaction transaction = new Transaction(false, interestRecieved, omni, ActionTypes.Add_Interest);
                tabomniListBox.Items.Add(transaction.ToString());

                UpdateBalanceLabels();
            }
            else
            {
                MessageBox.Show($"Insufficient balance to recieve interest. \n" +
                    $"Balance must be greater than ${omni.getRequiredBalance():F}", "WARNING");
            }

            CheckSufficientOmniBalance();
        }

        // Handles the withdrawl of an inputted amount. If too much is withdrawn (i.e. more than the overdraft limit),
        // a fail fee is deducted from the balance.
        private void tabomniwithdrawButton_Click(object sender, EventArgs e)
        {
            bool transactionFail;
            bool isDouble = Double.TryParse(tabomniinputTextBox.Text, out double amount);

            if (isDouble)
            {
                // Can withdraw below negative balance. Only upto Overdraft limit.
                if (amount > (omni.getBalance() + omni.GetOverdraftLimit())) 
                {
                    MessageBox.Show("FAILED TRANSACTION");
                    transactionFail = true;
                    omni.Withdraw(omni.GetFailFee());
                }
                else
                {
                    transactionFail = false;
                    omni.Withdraw(amount);
                }
                Transaction transaction = new Transaction(transactionFail, amount, omni, ActionTypes.Withdraw);
                tabomniListBox.Items.Add(transaction.ToString());

                UpdateBalanceLabels();
            }
            else
            {
                MessageBox.Show("Please enter a valid withdrawl amount!", "WARNING");
            }

            CheckSufficientOmniBalance();
        }

        // Handles the deposit of an inputted amount
        private void tabomnidepositButton_Click(object sender, EventArgs e)
        {
            bool isDouble = Double.TryParse(tabomniinputTextBox.Text, out double amount);

            if (isDouble)
            {
                omni.Deposit(amount);

                Transaction transaction = new Transaction(false, amount, omni, ActionTypes.Deposit);
                tabomniListBox.Items.Add(transaction.ToString());

                UpdateBalanceLabels();
            }
            else
            {
                MessageBox.Show("Please enter a valid deposit amount!", "WARNING");
            }

            CheckSufficientOmniBalance();
        }

        // Checks to see if the account has more than the required balance to earn interest
        public void CheckSufficientOmniBalance()
        {
            if (omni.getBalance() >= omni.getRequiredBalance())
            {
                omni.setSufficentBalance(true);
            }
            else
            {
                omni.setSufficentBalance(false);
            }
        }

        /**********************
         * Investment Account *
         **********************/

        // Calculates the amount of interest the account can earn in a year
        private void tabinvestmentcalculateButton_Click(object sender, EventArgs e)
        {
            double rate = investment.GetInterestRate();
            double balance = investment.getBalance();
            double interestRecieved = rate * balance;

            MessageBox.Show($"Interest recieved per annum is: ${interestRecieved:F} \n\n" +
                "Calculated using: \n" +
                $"Rate: {(rate * 100):F}% \n" +
                $"Balance: ${balance:F}",
                "Calculating interest");

        }

        // Handler to add the interest gained over a year
        private void tabinvestmentaddButton_Click(object sender, EventArgs e)
        {
            double interestRecieved = investment.GetInterestRate() * investment.getBalance();
            investment.Deposit(interestRecieved);

            Transaction transaction = new Transaction(false, interestRecieved, investment, ActionTypes.Add_Interest);
            tabinvestmentListBox.Items.Add(transaction.ToString());

            UpdateBalanceLabels();
        }

        // Handles the withdrawl of an inputted amount. If too much is withdrawn, a fail fee is deducted from the balance.
        private void tabinvestmentwithdrawButton_Click(object sender, EventArgs e)
        {
            bool transactionFail;
            bool isDouble = Double.TryParse(tabinvestmentinputTextBox.Text, out double amount);

            if (isDouble)
            {
                // Cannot withdraw below negative balance. No overdraft.
                if (amount > investment.getBalance())
                {
                    MessageBox.Show("FAILED TRANSACTION");
                    transactionFail = true;
                    investment.Withdraw(investment.GetFailFee());
                }
                else
                {
                    transactionFail = false;
                    investment.Withdraw(amount);
                }
                Transaction transaction = new Transaction(transactionFail, amount, investment, ActionTypes.Withdraw);
                tabinvestmentListBox.Items.Add(transaction.ToString());

                UpdateBalanceLabels();
            }
            else
            {
                MessageBox.Show("Please enter a valid withdrawl amount!", "WARNING");
            }
        }

        // Handles the deposit of an inputted amount
        private void tabinvestmentdepositButton_Click(object sender, EventArgs e)
        {
            double amount;
            bool isDouble = Double.TryParse(tabinvestmentinputTextBox.Text, out amount);

            if (isDouble)
            {
                investment.Deposit(amount);

                Transaction transaction = new Transaction(false, amount, investment, ActionTypes.Deposit);
                tabinvestmentListBox.Items.Add(transaction.ToString());

                UpdateBalanceLabels();
            }
            else
            {
                MessageBox.Show("Please enter a valid deposit amount!", "WARNING");
            }
        }

        /****************************************************
         * Handlers used for displaying account information *
         ****************************************************/
        private void tabeverydayinfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Account Type: {everyday.getAccountType()} \n" +
                $"Interest Rate: {everyday.GetInterestRate() * 100}% \n" +
                $"Overdraft Limit: ${everyday.GetOverdraftLimit():F} \n"+
                $"Failed Transaction Fee: ${everyday.GetOverdraftLimit():F} \n",
                "Account Information");
        }

        private void tabinvestmentinfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Account Type: {investment.getAccountType()} \n" +
                $"Interest Rate: {investment.GetInterestRate() * 100}% \n" +
                $"Overdraft Limit: ${investment.GetOverdraftLimit():F} \n" +
                $"Failed Transaction Fee: ${investment.GetOverdraftLimit():F} \n",
                "Account Information");

        }

        private void tabomniinfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Account Type: {omni.getAccountType()} \n" +
                $"Interest Rate: {omni.GetInterestRate() * 100}% \n" +
                $"Overdraft Limit: ${omni.GetOverdraftLimit():F} \n" +
                $"Failed Transaction Fee: ${omni.GetOverdraftLimit():F} \n" +
                $"Required Balance for gaining interest: ${omni.getRequiredBalance():F}" ,
                "Account Information");
        }

        /***************************************************
         * Handlers used for navigation between tabs/pages *
         ****************************************************/
        private void everydayButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void investmentButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void omniButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 3;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void tabomnireturnButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void tabinvestmentreturnButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }
    }

    public enum AccountTypes
    {
        Everyday,
        Investment,
        Omni
    }

    public enum ActionTypes
    { 
        Deposit, 
        Withdraw, 
        Add_Interest,
        ViewCurrentBalance
    }
}
