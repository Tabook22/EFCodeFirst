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
            List<Post> lstPs = db.PostsTable.ToList();
            return View(lstPs);
        }


        public ActionResult Create()
        {
            return View();
        }

       [HttpPost]
        public ActionResult Create(Post pst)
        {
            return View();
        }


        public ActionResult comments()
        {
           // Post ps = db.PostsTable.Where(x=>x.PostId=1);

            return View(db.PostsTable.ToList());
        }

        public ActionResult commentsPost(int id)
        {
            Post ps = db.PostsTable.Find(id);
            // List<Comment> lsCm = db.CommentTable.Where(x => x.PostId == id).ToList();
           
            List<Comment> lstC = (from x in db.CommentTable
                        where x.PostId == id
                        select x).ToList();

            

            viewModelCom vm = new viewModelCom();
            vm.PostId = ps.PostId;
            vm.Title = ps.Title;
            vm.PostDate = ps.PostDate;
            return View(vm);
        }

        [HttpPost]
        public ActionResult addNewCom(viewModelCom vm, int PostId)
        {
            Comment cm = new Comment();
            cm.cTitle = vm.cTitle;
            cm.comments = vm.comments;
            cm.PostId = PostId;

            db.CommentTable.Add(cm);
            db.SaveChanges();

            return View("comments", db.PostsTable.ToList());
        }
    }
}