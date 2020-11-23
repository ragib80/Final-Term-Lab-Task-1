using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class Savings:Account
    {
       int transCount=0;
       /* public int TransCount
        {
            get { return transCount; }
            set { transCount = value; }
        }*/
        public Savings()
        {

        }
        public Savings(string name,string id,double balance):base(name,id, balance)
        {
           
        }




        override public void Withdraw(double amount)
        {

            if (transCount <= 5 && this.Balance - amount > 500)
            {
                Console.WriteLine(" ");
                this.Balance = this.Balance - amount;
                transCount++;
                Console.Write("after transsection " + amount + " balance is " + Balance);

            }
            else {
                Console.WriteLine(" ");
                Console.WriteLine("Sorry The maximum transaction time commited or Transection limit is over ");
                Console.WriteLine("");
                Console.WriteLine("Sorry Widraw of "+amount+" is Unsucceessful,  Remain balance is : " + Balance );


            }

        }






    }
    }

