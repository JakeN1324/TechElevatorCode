using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<IAccountable> accounts { get; set; }
        public bool IsVip
        {
            get
            {
                decimal sum = 0;
                foreach (IAccountable item in accounts)
                {
                    sum += item.Balance;
                    
                }
                if (sum >= 25000M)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }




        public BankCustomer()
        {
            accounts = new List<IAccountable>();
        }

        public void AddAccount(IAccountable newAccount)
        {
            accounts.Add(newAccount);
        }

       public IAccountable[] GetAccounts()
        {
            return accounts.ToArray();
        }
    }
}
