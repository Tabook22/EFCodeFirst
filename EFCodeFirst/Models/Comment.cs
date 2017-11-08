using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class Comment
    {
        [Key]
        public int ComId { get; set; }
        public string  cTitle { get; set; }
        public string comments { get; set; }

        public int PostId { get; set; }
        public virtual Post post { get; set; }

    }
}