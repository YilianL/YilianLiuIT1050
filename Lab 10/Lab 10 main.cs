using System;

class Program {
  public static void Main (string[] args) {
    Em Employee1 = new Em();
    Employee1.Intro();

    Em Employee2 = new Em ("Robert", "Downey", "12321", 12);
    Employee2.YearlySalary = 100;
    Employee2.Intro();

    Em Employee3 = new Em ("John", "Smith", "S0089", 38);
    Employee3.YearlySalary = 50000;
    Employee3.Intro();
    Employee3.IncreaseSalary(-0.02);
    Employee3.RemoveEmployee();

    Em Employee4 = new Em("Maria", "Lambert", "S0100", 26);
    Employee4.YearlySalary = 80000;
    Employee4.Intro();
    Employee4.IncreaseSalary(0.07);
    Employee4.RemoveEmployee();
    Employee4.RemoveEmployee();
  }
}
