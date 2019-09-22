using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookManage.Models;

namespace BookManage.Controllers
{
    public class ChitietController : Controller
    {
        BookManageEntities1 db = new BookManageEntities1();
        // GET: Chitiet
        public ActionResult ChitietBook(int? BookID)
        {
            //  Book s = db.Books.Single(n => n.BookId == id);
            Book b = (from p in db.Books where p.BookId == BookID select p).ToArray()[0];

            return View(b);
        }
        public ActionResult ChudeBook(int? CateId)
        {
            ViewBag.name = db.Categories.SingleOrDefault(n => n.CateId == CateId).CateName;
            return View(db.Books.Where(n=>n.CateId== CateId).ToList());
        }
    }
}