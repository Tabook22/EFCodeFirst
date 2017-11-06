using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }

        //This means each blog can have a list of posts
        public virtual List<Post> posts { get; set; }
    }
}