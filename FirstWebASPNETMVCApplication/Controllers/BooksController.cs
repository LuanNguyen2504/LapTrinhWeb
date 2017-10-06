using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWebASPNETMVCApplication.Models;

namespace FirstWebASPNETMVCApplication.Controllers
{
    public class BooksController : Controller
    {
        private List<Book> listBooks;
        /// <summary>
        /// Ham khoi tao BooksController
        /// </summary>
        public BooksController()
        {
            listBooks = new List<Book>();
            listBooks.Add(new Book()
            {
                Id = 1,
                Title = "Sach 1",
                Author = "Tac gia sach 1",
                PublicYear = "2017",
                Price=40000,
                Cover = "Content/image/book1.png"
            });
            listBooks.Add(new Book()
            {
                Id = 2,
                Title = "Sach 2",
                Author = "Tác giả sách 2",
                PublicYear = "2017",
                Price = 50000,
                Cover="Content/image/book2.jpg"
            });
            listBooks.Add(new Book()
            {
                Id = 3,
                Title = "Sach 3",
                Author = "Tac gia sach 3",
                PublicYear = "2017",
                Price = 100000,
                Cover = "Content/image/book3.jpg"
            });
        }
        // GET: Books
        public string Index(string myName, string university)
        {
            return "Xin chao, toi la BooksController <br/>My Name: " + myName + "<br/>University: " + university;
        }
        /// <summary>
        /// Lay danh sach Book
        /// </summary>
        /// <returns>Trang xem danh sach Book</returns>
        public ActionResult ListBooks()
        {
            ViewBag.TitlePageName = "List Book";
            return View(listBooks);
        }
    }
}