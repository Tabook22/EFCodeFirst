using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string PostDate { get; set; }

        //this means each post belongs to only one blog
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}