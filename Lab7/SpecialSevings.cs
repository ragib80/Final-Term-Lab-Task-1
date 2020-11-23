using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class SpecialSevings:Account
    {
        private int transCount = 0;
        public int TransCount
        {
            get { return transCount; }
            set { transCount = value; }
        }
        public SpecialSevings()
        {

        }
        public SpecialSevings(string name, string id, double balance) : base(name, id, balance)
        {

        }


      

        public override void Withdraw(double amount)
        {
            Console.WriteLine("");

            if (Balance - amount >= Balance * 0.2 && transCount <= 8)
            {

                this.Balance -= amount;

                Console.WriteLine("After Widraw " + amount + " current balance is : " + Balance);
                transCount++;
            
            }


            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Widraw " + amount+" is not possible due to  20% of withdraw money is not in account");
                Console.WriteLine("Unsuccessful Widhraw! you requested to widraw "+amount+" ,and");
                Console.WriteLine("Balnce is "+Balance+" require 20 % of balanceis " + Balance * .20);

            }



        }
    }
}
