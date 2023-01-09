using Accounts.Base;

namespace Accounts
{

    public class SavingsAccount : BaseAccount
    {
        public override void withdrawBalance(double withdraw)
        {
            if (balanceValidator(withdraw).Equals(true))
            {
                this.Balance -= (withdraw - 4.00);
                Console.WriteLine("Saque bem sucedido!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                Console.ReadKey();
            }
        }
    }
}