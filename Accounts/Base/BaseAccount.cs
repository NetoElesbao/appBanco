using ClientEntity;

namespace Accounts.Base
{

    public abstract class BaseAccount
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        protected double Balance { get; set; }

        public BaseAccount()
        {
            this.Balance = 0;
            Random randomNumber = new Random();
            int intRandomNumber = randomNumber.Next(1, 100);
            this.Id = intRandomNumber;
        }

        public virtual void withdrawBalance(double withdraw)
        {
            if (balanceValidator(withdraw).Equals(true))
            {
                this.Balance -= withdraw;
                Console.WriteLine("Saque bem sucedido!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
                Console.ReadKey();
            }
        }

        public bool balanceValidator(double withdraw)
        {
            bool balanceValidator;
            if ((this.Balance - withdraw) < 0)
            {
                balanceValidator = false;
            }
            else
            {
                balanceValidator = true;
            }

            return balanceValidator;
        }

        public void depositBalance(double deposit)
        {
            this.Balance += deposit;
        }
    }
}