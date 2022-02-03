using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //FIELD - Automatic Property - No buisness rules

        //Properties
        public int AccountNumber { get; set; }

        public Customer CustCredCarAccount { get; set; }

        public decimal Balance { get; set; }

        public bool IsPastDue { get; set; }

        public decimal AnnualInterestRate { get; set; }

        //Constructor
        public CreditCardAccount(int accountNumber, Customer custCredCarAccount, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustCredCarAccount = custCredCarAccount;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        //Methods

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Account Number: {0:c}\n" +
                "Customer Info: {1}\n" +
                "Balance: {2:c}\n" +
                "Past Due? {3}\n" +
                "Annual Interest Rate: {4}",
                AccountNumber,
                CustCredCarAccount,
                Balance,
                IsPastDue,
                AnnualInterestRate);
              
        }



    }
}
