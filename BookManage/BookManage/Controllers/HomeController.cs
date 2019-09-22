using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookManage.Models;

namespace BookManage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        BookManageEntities1 db = new BookManageEntities1();
        public ActionResult Home()
        {
            // Book b = (from p in db.Books where p.BookId == id select p).ToArray()[0];
            //var x = db.Books.ToList();
            //Book b = (from p in db.Books where p.CateId == 1 select p).ToArray()[0];
            //var model = from a in db.Books join z in db.Publishers on a.PubId equals z.PubId where a.PubId = z.PubId
            //            select
            return View(db.Books.Take(18).ToList());
        }
        public PartialViewResult BookSpecialParialView()
        {
           
            return PartialView(db.Books.Where(n=> n.CateId==9).ToList());

        }

    }
}