using Common;
namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 [ Person ]
            Person person1 = new Person();
            person1.FirstName = "Asmaa";
            person1.LastName = "El Sayed";
            person1.Country = "Egypt";
            person1.MobileNo = "0102215";

            Person person2 = new Person();
            person2.FirstName = "Ahmed";
            person2.LastName = "Mohamed";
            person2.Country = "Egypt";
            person2.MobileNo = "0122385";

            Console.WriteLine(person1);
            person1.PrintData();
            
            Console.WriteLine(person2);
            person2.PrintData();
            #endregion

            #region Example 2 [ BankAccount ]

            BankAccount MyAccount = new BankAccount();
            MyAccount.BankName = "Deutsche Bank";
            MyAccount.BranchName = "Dresden";
            MyAccount.BranchAddress = "142 Hauptstrasse";
            MyAccount.AccountCurrency = "USD";
            MyAccount.Balance = 1250;

            Console.WriteLine(MyAccount.BankName);
            Console.WriteLine(MyAccount.Balance);

            MyAccount.Withdraw(1750);
            MyAccount.Deposit(250);

            BankAccount bankAccount = new BankAccount("Deutsche Bank", "Dresden", "142 Hauptstrasse", "12452", "USD", 12500);

            bankAccount.Withdraw(1750);
            bankAccount.Deposit(250);

            #endregion

            #region Example 3 [  ]
            Car car;
            #endregion


        }
    }
}
 