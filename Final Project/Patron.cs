using System;
using System.Collections.Generic;
using System.Linq;

class Patron : Person
{
  public string LibraryID {get;set;}
  public DateTime StartDate {get;set;}
  public DateTime EndDate {get;set;}
  public bool IsAccountActive {get;set;}
  public double FineAmountDue {get;set;}
  private List<Rental> RentalCart = new List<Rental>();

  public Patron(string fname, string lname, string ID) : base(fname,lname)
  {
    LibraryID = ID;
    FineAmountDue = 0;
    IsAccountActive = true;
    StartDate = DateTime.Today;
  }
  public void Display()
  {
    Console.WriteLine("Patron Id= " + LibraryID + " Name = " + FirstName + " " + LastName);
  }
  public void AddToRentalCart(Book b, DateTime DueDate)
  {
    Rental r = new Rental(b, DateTime.Today, DueDate);
    RentalCart.Add(r);
    Console.WriteLine("Added to Rental Cart: " + b.Title + " for Patron " + FirstName + " " + LastName);
  }
  public void RemoveFromRentalCart(Book b)
  {
    Rental bk = RentalCart.Find(bk=>bk.BookRented.ISBN == b.ISBN);
    RentalCart.Remove(bk);
    Console.WriteLine("Removed from Rental Cart: " + b.Title +" for Patron " + FirstName + " " + LastName);
  }
}
