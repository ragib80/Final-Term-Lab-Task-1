using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class Overdraft:Account
    {
        private int overdraftLimit = 1;

        public int OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

        public Overdraft(string name, string id, double balance) : base(name, id, balance)
        {

        }

        public override void Withdraw(double amount)
        {

            if (amount >= Balance)
            {
                if (overdraftLimit <= 1)
                {

                    Balance = Balance + amount;
                    Console.WriteLine("After overdraft " + amount + " Your balance is : " + Balance);
                    overdraftLimit++;
                }
                else
                {
                    Console.WriteLine("already over drafed! Please pay your dues Before next month");
                }
            }
            else if (Balance - amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("you have enough amount to widhraw, no need  to over draft!");
                Console.WriteLine("after widthraw  balance is " + Balance);


            }
        }
    }
}
