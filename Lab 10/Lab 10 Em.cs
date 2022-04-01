using System;
class Em {
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;
//fields

   public Em()
  {
    FirstName="Unknown";
    LastName="Unknown";
    Id="Unknown";
    age=0;
    EmploymentStatus="active";
  }//Constructor with no parameters
  
  public Em(string fn, string ln, string id2, int age2)
  {
    FirstName=fn;
    LastName=ln;
    Id=id2;
    Age=age2;
    EmploymentStatus="active";
  }//constructor with paramenters

  public string FirstName{get;set;}
  public string LastName{get;set;}
  public string Id{get;set;}
  public string EmploymentStatus{get;set;}
  public int Age{
    get{ return age; }
    set{
      if (value >= 18)
      {
        age = value;
      }
      else{
        age = 18;
      }
    }
  }
  public double YearlySalary{
    get{ return yearlysalary; }
    set{
      if (value <= 1000)
      {
        yearlysalary = 1000;
      }
      else{
        yearlysalary = value;
      }
    }
  }
//properties
  
  public void Intro()
  {
    Console.WriteLine("First name: " + FirstName);
    Console.WriteLine("Last name: " + LastName);
    Console.WriteLine("Id: " + Id);
    Console.WriteLine("Age: " + Age);
    Console.WriteLine("Yearly salary: " + YearlySalary);
  }

  public double IncreaseSalary(double percent)
  {
    if (percent > 0)
    {
      YearlySalary = (YearlySalary * (1 + percent));
      Console.WriteLine("Yearly salary updated to " + YearlySalary);
    }
    else{
      Console.WriteLine("Invalid imput. Yearly salary not unpdated.");
    }
    return YearlySalary;
  }

  public void RemoveEmployee()
  {
    if (EmploymentStatus == "inactive")
    {
      Console.WriteLine("Employee already inactive.");
    }
    else
    {
      EmploymentStatus = "inactive";
      Console.WriteLine("Employee removed successfully!");
    }
  }
  
}
