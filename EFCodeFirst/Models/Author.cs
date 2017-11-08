using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class Author
    {
        [Key]
        public int AuId { get; set; }
        public string Name { get; set; }

        public virtual IList<Post> Posts{ get; set; }
    }
}