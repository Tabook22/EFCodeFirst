using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class viewModelCom
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string PostDate { get; set; }

        public int ComId { get; set; }
       public string cTitle { get; set; }
        public string comments { get; set; }

    }
}