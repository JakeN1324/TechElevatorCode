namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public BankAccount(string accountHolderName, string accountNumber)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;

        }

        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; } = 0M;



        public decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual decimal Withdraw(decimal amountToWithdraw)
        {


            Balance -= amountToWithdraw;
            return Balance;
        }
    }
}
