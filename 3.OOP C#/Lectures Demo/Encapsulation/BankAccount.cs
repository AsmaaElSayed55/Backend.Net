using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class BankAccount
    {
        #region Properities
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string AccountNumber { get; set; }
        public string AccountCurrency { get; set; }
        public decimal Balance { get; set; }
        #endregion

        #region Methods

        #region Constructors

        // Default Constructor
        public BankAccount()
        {
            Console.WriteLine("Constructor Is Called ");

        }

        // Parameterized Constructor 
        public BankAccount(string bankName, string branchName, string branchAddress, string accNumber, string accCurr, decimal balance)
        {
            BankName=bankName;
            BranchName=branchName;
            BranchAddress=branchAddress;
            AccountNumber=accNumber;
            AccountCurrency=accCurr;
            Balance = balance;
        }

        // Copy Constructor

        // Private Constructor

        // Static Constructor

        #endregion

        #region Functions
        public void Withdraw(decimal amount)
        {
            decimal NewBalance = Balance - amount;
            if (NewBalance < 0)
                Console.WriteLine("Invalid Transaction");
            else
            {
                Console.WriteLine($"Withdraw Amount Is {amount}");
                Console.WriteLine($"Your New Balance for {AccountNumber} is {NewBalance}");
            }
            Console.WriteLine("");
        }
        public void Deposit(decimal amount)
        {
            Console.WriteLine($"Deposit Amount is {amount}");
            Console.WriteLine($"Your New Balance for Acc . {AccountNumber} is {Balance + amount}");
            Console.WriteLine($"Transaction date is {DateTime.Now}");

        }
        public void Transfer()
        {

        }
        public void ChangePassword()
        {

        }
        public void CreateSubAccount()
        {

        }
        public void PrintStatment()
        {

        } 
        #endregion

        #endregion
    }
}
