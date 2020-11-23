using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
          Account a = new Savings("Ragib Shahriar", "0233",499);
            Console.WriteLine("-----------------------savings account info -----------------------------------");
            a.ShowInfo();
            a.Deposit(2500);
            a.Withdraw(2500.0);
            a.Deposit(2500);
           a.Withdraw(500);
           a.Withdraw(500);
           a.Withdraw(500);
            a.Withdraw(500);
            a.Withdraw(500);
           a.Withdraw(2500);
            a.Withdraw(500);
            a.Withdraw(500);
            Console.WriteLine("------------------------------------------------------------------------");


            Console.WriteLine("-----------------------fixed account info -----------------------------------");
            Account fa = new FixedAccount("Korim", "026", 3000, 2);
            fa.ShowInfo();
            fa.Withdraw(2000);
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("-----------------------savings account info -----------------------------------");
            Account sa = new SpecialSevings("Hridoy", "684", 1000);
            sa.ShowInfo();
            sa.Withdraw(2000);
            sa.Withdraw(500);
            sa.Withdraw(450);
            Console.WriteLine("");
            Account sa2 = new SpecialSevings("Shahriar", "814", 5000);
            sa2.ShowInfo();
            sa2.Withdraw(4500);
            sa2.Deposit(5000);
            sa2.Withdraw(6000);


            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("-----------------------overdraft account info ---------------------------------");

            Account oa = new Overdraft("Mokles", "236", 9000);
            oa.ShowInfo();
            oa.Withdraw(10000);
            oa.Withdraw(20000);
            Console.WriteLine("------------------------------------------------------------------------");


        }
    }
}
