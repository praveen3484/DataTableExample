using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DATATABLEANDJQUEry.Models
{
    public class Context : DbContext
    {
        public Context() : base("MyNewEntity")
        {

        }
        public DbSet<Students3> Students3 { get; set; }
        //public DbSet<Students3Details> Students3Details { get; set; }

    }
}