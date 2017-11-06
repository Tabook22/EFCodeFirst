using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    
    public class PostController : Controller
    {
        private BlogContext db = new BlogContext();
        // GET: Post
        public ActionResult Index()
        {
            List<Post> lstPs = db.Posts.ToList();
            return View(lstPs);
        }
    }
}