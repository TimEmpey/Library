using System.Collections.Generic;

namespace Library.Models
{
  public class Patron 
  {
    public Patron()
    {
      this.JoinBookPat = new HashSet<BookPatron>();
    }


    public int PatronId { get; set; }
    public string PatronFirst { get; set; }
    public string PatronLast { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<BookPatron> JoinBookPat { get; }
  }
}