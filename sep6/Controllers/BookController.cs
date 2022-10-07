using sep6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sep6.Controllers
{
    public class BookController : Controller
    {

        static List<Book> BookList = new List<Book>();
        static BookController()
        {
            BookList.Add(new Book { BookId = 1, BookName = "The Great King", Author = "Thor" });

            BookList.Add(new Book { BookId = 2, BookName = "Ponniyin Selvan", Author = "Kalki" });
            BookList.Add(new Book { BookId = 3, BookName = "The New Beginning", Author = "Bharathi" });
        }
        // GET: Book
        public ActionResult Index()
        {
            ViewData["Mybooklist"] = BookList;
            return View(BookList);
        }

        
    }
}