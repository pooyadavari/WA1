using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Product:BaseEntity
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }
}