using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Cau3.Models
{
    public class Context : DbContext
    {
        public Context(): base("name=PostMangerConnection") { }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}