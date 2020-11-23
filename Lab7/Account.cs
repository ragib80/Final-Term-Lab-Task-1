using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    abstract class Account
    {
       
        private string accountName;

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

        private string accountId;

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public Account()
        {
           
        }
        public Account(string accountName, string accountId, double balance)
        {
            this.accountName = accountName;
            this.accountId = accountId;
            this.balance = balance;
        }

        public  void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine("After deposit " + amount + " balance is " + Balance);
        }

        public abstract void Withdraw( double amount);
       virtual public void ShowInfo()
        {
            Console.WriteLine("Account name : " + AccountName);
            Console.WriteLine("Account Id: " + AccountId);
            Console.WriteLine("Balance is : " + Balance);

        }
    }
}
