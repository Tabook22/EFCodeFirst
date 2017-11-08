using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext db = new BlogContext();
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult Create()
        {
            List<Blog> bb = db.BlogsTable.ToList();
            return View(bb);
        }
        [HttpPost]
        public ActionResult Create(Blog bl)
        {
            db.BlogsTable.Add(bl);
            db.SaveChanges();

            List<Blog> bb = db.BlogsTable.ToList();
            return View(bb);
        }

     
        public ActionResult delBlog(int id)
        {
            Blog bg = new Blog();
            bg = db.BlogsTable.Find(id);
            db.BlogsTable.Remove(bg);
            db.SaveChanges();
            return View("Create",db.BlogsTable.ToList());
        }


        public ActionResult Edit(Blog bg)
        {
            Blog bg2 = db.BlogsTable.Find(bg.BlogId);
            return View(bg2);
        }

        [HttpPost]
        public ActionResult Edit(Blog bl,int BlogId)
        {
            Blog bg = db.BlogsTable.Find(BlogId);
            bg.Name = bl.Name;

            db.SaveChanges();
            
            return View("Create", db.BlogsTable.ToList());
        }
    }
}