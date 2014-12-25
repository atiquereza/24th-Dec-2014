using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperation
{
    public partial class Form1 : Form
    {
        List<AccountHolder> allAccountHolders = new List<AccountHolder>();
        AccountHolder anHolder1 = new AccountHolder();
        //AccountHolder anHolder1;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            AccountHolder anHolder = new AccountHolder();
            anHolder.customerName = nameTextBox.Text;
            anHolder.accountNumber = accountNumberTextBox.Text;
            anHolder.account_Create(anHolder,allAccountHolders);
            nameTextBox.Text = "";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
           // anHolder1 = new AccountHolder();
            anHolder1.deposit_Account(accountNumberTextBox.Text, Convert.ToInt32(amountTextBox.Text), allAccountHolders);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            anHolder1.withdraw_Account(accountNumberTextBox.Text, Convert.ToInt32(amountTextBox.Text), allAccountHolders);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            anHolder1.report_Generation(accountNumberTextBox.Text, allAccountHolders);
        }
    }
}
