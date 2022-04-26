using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    Author a1 = new Author("Mark", "Twain");
    a1.DisplayInfo();
    Author a2 = new Author("Roadld", "Dahl");
    a2.DisplayInfo();
    
    Book b1 = new Book("1573920398", "The Mysterious Stranger", "Mark Twain");
    Book b2 = new Book("0141371145", "The BFG", "Roald Dahl");
    Book b3 = new Book("0486414264", "Life on the Mississipi", "Mark Twain");
    Book b4 = new Book("0142410314", "Charlie and The Chocolate Factory", "Roald Dahl", Convert.ToDateTime("01/17/1964"), "George Allen & Unwin");
    Book b5 = new Book("0486400778", "The Adventure of Tom Sawyer", "Mark Twain", Convert.ToDateTime("6/1/1876"), "American Publishing Company");
    Book b6 = new Book("0060536276", "Fantastic Mr.Fox", "Roald Dahl", Convert.ToDateTime("06/01/1964"), "George Allen & Unwin");

    a1.AddBook(b1);
    a1.AddBook(b3);
    a1.AddBook(b5);
    a1.DisplayBooks();
    
    a2.AddBook(b2);
    a2.AddBook(b4);
    a2.AddBook(b6);
    a2.DisplayBooks();
    
    a1.Remove(b1);
    a1.DisplayBooks();

    Patron p1 = new Patron("Tim","Smith","1111");
    Patron p2 = new Patron("James","Green","2222");
    Patron p3 = new Patron("Michael","White","3333");
    Patron p4 = new Patron("Mary","Swift","4444");
    Patron p5 = new Patron("Robert","Black","5555");

    p1.AddToRentalCart(b1, Convert.ToDateTime("07/01/2022"));
    p1.RemoveFromRentalCart(b3);
    p1.Display();

  }
}
