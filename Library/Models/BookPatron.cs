namespace Library.Models
{
  public class BookPatron
  {
    public int BookPatronId { get; set; }
    public int BookId { get; set; }
    public int PatronId { get; set; }
    public virtual Book Book { get; set; }
    public virtual Patron Patron { get; set; }
    }  
}