using System;

class Program {
  public static void Main (string[] args) {
  SavingsAccount s1 = new SavingsAccount();
    s1.Deposit(2000);
    s1.Withdraw(5000);
    s1.CalculateInterest();
    s1.Withdraw(500);

  CheckingAccount c1 = new CheckingAccount();
    c1.Deposit(2000);
    c1.Withdraw(5000);
    c1.CalculateInterest();
    c1.Withdraw(500);
}
}
