using System;
 
abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DteCreated { get; set; }

        public BankAccount():this(1000)
        {
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
          Balance = Balance + amount;
          Console.WriteLine("The current balance is $ " + Balance);
        }

        public virtual void Withdraw(double amount)
        {
          if(Balance > amount)
          {
            Balance = Balance - amount;
            Console.WriteLine("The current balance is $ " + Balance);
          }
          else{
            Console.WriteLine("Error occurs.");
          }
        }
        public abstract void CalculateInterest();

    }
