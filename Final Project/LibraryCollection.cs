using System;
using System.Collections.Generic;
using System.Linq;

class LibraryCollection{
  private List<Patron> PatronList = new List<Patron>();
  public List<Book> BookList = new List<Book>();

  public void AddPatron(Patron p)
  {
    PatronList.Add(p);
    Console.WriteLine("Added Successfully " + p.FirstName + " " + p.LastName);
  }
  public void RemovePatron(Patron p)
  {
    Patron pt = PatronList.Find(pt=>pt.LibraryID == p.LibraryID);
    PatronList.Remove(pt);
    Console.WriteLine("Remove Successfully " + p.FirstName + " " + p.LastName);
  }
  public void DisplayPatronInfo()
  {
    foreach(Patron p in PatronList){
      p.Display();
    }
  }

  public void AddToCollection(Book b)
  {
    BookList.Add(b);
    Console.WriteLine("Added book successfully!");
  }
  public void RemoveFromCollection(Book b)
  {
    Book x = BookList.Find(x=>x.ISBN ==b.ISBN);
    BookList.Remove(x);
    Console.WriteLine("Removed book Successfully!");
  }
  public void DisplayCollection()
  {
    foreach(Book b in BookList){
      b.display();
    }
  }

  public void ProcessRental(Patron p)
  { //work on rental cart of patron p
    foreach (Rental r in p.RentalCart){
      //We have the rental in r
      //Now we will have to find a match in BookList that matches the book in r
      Book bookRented = BookList.Find(b=>b.ISBN == r.BookRented.ISBN);
      Console.WriteLine("Processed rental for " + r.BookRented.Title);
      BookList.Remove(bookRented);
    }
  }

  public void ProcessReturn(Patron p, Book b)
  {
    foreach (Rental r in p.RentalCart){
      Rental Return = p.RentalCart.Find(r=>r.BookRented.ISBN == b.ISBN);
      if ((DateTime.Compare(DateTime.Today,r.DateDue)>0)){
        p.FineAmountDue = p.FineAmountDue +10;
        Console.WriteLine("There is a fine of $ 10.");
      }
      p.RentalCart.Remove(Return);
      BookList.Add(b);
      Console.WriteLine("Processed rental for " + b.Title);
    }
  }

}
