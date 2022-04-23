using System;

class CheckingAccount : BankAccount
{
  override public void CalculateInterest()
  {
    double Interest = 0.005*Balance;
    Balance = Balance + Interest;
    Console.WriteLine("The current balance is $ " + Balance);
  }

  public override void Withdraw(double amount)
  {
    base.Withdraw(amount);
  }


}
