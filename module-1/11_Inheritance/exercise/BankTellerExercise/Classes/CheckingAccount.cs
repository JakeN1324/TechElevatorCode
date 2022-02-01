namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {
            
        }


        public override decimal Withdraw(decimal amountToWithdraw)
        {
            
            decimal currentBalance = Balance;
            
            if (Balance - amountToWithdraw > -100)
            {
                currentBalance = base.Withdraw(amountToWithdraw);
                if (currentBalance < 0M && currentBalance > -100M)
                {
                    currentBalance = base.Withdraw(10M);

                }
            }
            
            

            return currentBalance;
        }
    }
}
