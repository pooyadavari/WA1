using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext():base("DefaultContext")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}