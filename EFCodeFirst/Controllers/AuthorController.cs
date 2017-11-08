using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    public class AuthorController : Controller
    {
        private BlogContext db = new BlogContext();
        // GET: Author
        public ActionResult Index()
        {

            return View(db.AuthorTable.ToList());
        }

        public ActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creat(Author auth)
        {
            db.AuthorTable.Add(auth);
            db.SaveChanges();
            return View("Index", db.AuthorTable.ToList());
        }
    }
}