using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class FixedAccount : Account
    {
        private int accRunningYear;

        public int AccRunningYear
        {
            get { return accRunningYear; }
            set { accRunningYear = value; }
        }
        private int tenureYear=3;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }

        public FixedAccount()
        {

        }
        public FixedAccount(string name, string id, double balance, int accRunningYear) : base(name, id, balance)

        {
            this.accRunningYear = accRunningYear;
            
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine(" ");

            if ( accRunningYear <= tenureYear && amount - this.Balance > this.Balance)
            {

                this.Balance -= amount;

                Console.WriteLine("After Widraw " + amount + " balance is : " + Balance);


            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Account is not not matured ");
                Console.WriteLine("Requre account age for matured is " + tenureYear + " your account age is  "+accRunningYear);
            }


        }
        
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Account  year is : " + accRunningYear);
            Console.WriteLine("Account tenure  year is : " + tenureYear);

        }
    }
}