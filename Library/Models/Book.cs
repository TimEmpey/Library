using System.Collections.Generic;

namespace Library.Models
{ 
  public class Book
  {
    public Book()
    {
      this.Borrower = null; //null belongs to library
    }

    public int BookId { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string AuthorFirst { get; set; }
    public string AuthorLast { get; set; }
    public virtual ApplicationUser User { get; set; }
    public string Borrower { get; set; }
  }
}