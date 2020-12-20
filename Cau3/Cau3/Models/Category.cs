using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cau3.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public string Note { get; set; }
        public DateTime DateCreate { get; set; }
    }
}