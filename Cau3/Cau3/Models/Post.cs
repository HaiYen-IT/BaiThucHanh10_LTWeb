using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cau3.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string Tille { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string Note { get; set; }
        public string CategoryID { get; set; }
        public Category Category { get; set; }
    }
}