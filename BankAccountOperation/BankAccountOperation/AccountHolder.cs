using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperation
{
    class AccountHolder
    {
        public string accountNumber;
        public string customerName;
        public int amount;

        
        public void account_Create(AccountHolder anAccountHolder,List<AccountHolder> allAccountHolders)
        {
            anAccountHolder.amount = 0;
            allAccountHolders.Add(anAccountHolder);

            MessageBox.Show("Account Created");
        }

        public void deposit_Account(string accNo, int amnt, List<AccountHolder> allAccountHolders)
        {
            foreach (AccountHolder eachAccountHolder in allAccountHolders)
            {
                if (eachAccountHolder.accountNumber == accNo)
                {
                    eachAccountHolder.amount += amnt;
                    MessageBox.Show(eachAccountHolder.customerName + ": Your account is deposited with" + amnt +
                                    " and Your Current Balance is: "+eachAccountHolder.amount);
                }
            }

        }

        public void withdraw_Account(string accNo, int amnt, List<AccountHolder> allAccountHolders)
        {
            foreach (AccountHolder eachAccountHolder in allAccountHolders)
            {
                if (eachAccountHolder.accountNumber == accNo)
                {
                    eachAccountHolder.amount -= amnt;
                    MessageBox.Show(eachAccountHolder.customerName + ": Your account is credited with" + amnt +
                                    " and Your Current Balance is: " + eachAccountHolder.amount);
                }
            }

        }

        public void report_Generation(string accNo, List<AccountHolder> allAccountHolders)
        {
            foreach (AccountHolder eachAccountHolder in allAccountHolders)
            {
                if (eachAccountHolder.accountNumber == accNo)
                {
                   // eachAccountHolder.amount -= amnt;
                    MessageBox.Show(eachAccountHolder.customerName +  " Your Account Number is: "+eachAccountHolder.accountNumber+ " Current Balance is: " + eachAccountHolder.amount);
                }
            }
        }

    }
}
