using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Library.Controllers
{
  [Authorize]
  public class BooksController : Controller
  {
    private readonly LibraryContext _db;

    public BooksController(LibraryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Book> model = _db.Books.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Book book)
    {
      _db.Books.Add(book);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisBook = _db.Books
          .FirstOrDefault(book => book.BookId == id);
      return View(thisBook);
    }
    public ActionResult Edit(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      return View(thisBook);
    }

    [HttpPost]
    public ActionResult Edit(Book book)
    {
      _db.Entry(book).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      return View(thisBook);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      _db.Books.Remove(thisBook);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

      [HttpPost]
      public ActionResult AddToUser(string UserName, int BookId)
      {
        var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        Book myBook = _db.Books.FirstOrDefault(book => book.BookId == BookId);
        myBook.Borrower = userId;
        _db.Entry(myBook).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Details", "Account");
    }

    [HttpPost]
    public ActionResult RemoveFromUser (int BookId)
    {
        Book myBook = _db.Books.FirstOrDefault(book => book.BookId == BookId);
        myBook.Borrower = null;
        _db.Entry(myBook).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Details", "Account");
    }
  }
}