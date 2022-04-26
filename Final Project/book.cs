using System;
using System.Collections.Generic;
using System.Linq;

class Book{
  public string ISBN {get;set;}
  public string Title {get;set;}
  public string AuthorInfo {get;set;}
  public DateTime PublishedOn {get;set;}
  public string PublishedBy {get;set;}

  public Book(string isbn, string title, string authorinfo)
  {
    ISBN = isbn;
    Title = title;
    AuthorInfo = authorinfo;
    PublishedOn = DateTime.Today;
    PublishedBy = "Unknown";
  }

  public Book(string isbn, string title, string authorinfo, DateTime publishedon, string publishedby)
  {
    ISBN = isbn;
    Title = title;
    AuthorInfo = authorinfo;
    PublishedOn = publishedon;
    PublishedBy = publishedby;
  }

  public void display()
  {
    Console.WriteLine("Book " + Title + " was written by " + AuthorInfo + " and published on " + PublishedOn);
  }

}
