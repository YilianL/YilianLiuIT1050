using System;
using System.Collections.Generic;
using System.Linq;

class Author : Person
{
  private List<Book> Books = new List<Book>();

  public Author() : base()
  {
  }

  public Author(string fname, string lname) : base(fname, lname)
  {
  }

  public void DisplayInfo()
  {
    Console.WriteLine("The name of the author is " + FirstName + " " + LastName);
    Console.WriteLine("The email of the auhtor is " + Email);
  }

  public void DisplayBooks()
  {
    foreach(Book b in Books){
      b.display();
    }
  }
  public void AddBook(Book b)
  {
    Books.Add(b);
  }

  public void Remove(Book b)//No indication of ever taking
  {
     Book x= Books.Find(x=>x.ISBN == b.ISBN);
     Books.Remove(x);
  }

}
