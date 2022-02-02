using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount : IAccountable
    {
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Debt { get; private set; }
        public decimal Balance
        {
            get
            {
                return -Debt;
            } 
            private set
            {

            }
        }

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
        }

        

        public decimal Pay(decimal amountToPay)
        {
            Debt -= amountToPay;
            //Balance = Debt * -1; (Also Works but needs to be in every method)

            return Debt;
        }

        public decimal Charge(decimal amountToCharge)
        {
            Debt += amountToCharge;
            //Balance = Debt * -1;
            return Debt;
        }
    }
}
