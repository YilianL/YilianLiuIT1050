using System;

class SavingsAccount : BankAccount
    {
      override public void CalculateInterest()
      {
        double Interest = 0.05*Balance;
        Balance = Balance + Interest;
        Console.WriteLine("The current balance is $ " + Balance);
      }
    
      public override void Withdraw(double amount)
      {
        if(Balance < 2000)
        {
          Console.WriteLine("Insufficient Balance.");
        }
        else{
          base.Withdraw(amount);
        }
      }

      
    }
