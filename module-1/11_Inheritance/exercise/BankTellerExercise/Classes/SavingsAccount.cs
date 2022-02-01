namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }


        public override decimal Withdraw(decimal amountToWithdraw)
        {

            decimal currentBalance = Balance;

            if (amountToWithdraw <= currentBalance - 2)
            {
                currentBalance = base.Withdraw(amountToWithdraw);
                if (currentBalance < 150M)
                {
                    currentBalance = base.Withdraw(2M);
                }
            }
            return currentBalance;



            
        }
    }
}
