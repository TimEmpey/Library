using Microsoft.AspNetCore.Identity;
using Library.Models;
using System.Collections.Generic;

namespace Library.Models
{
  public class ApplicationUser : IdentityUser
  {
    public ApplicationUser()
    {
      this.Borrowed = new HashSet<Book>();
    }
    [PersonalData]
    public virtual ICollection<Book> Borrowed { get; set; }
    
  }
}