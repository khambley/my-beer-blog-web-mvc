using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToBeer.Models
{
    public class MyBeerBlogDb : DbContext
    {
        public MyBeerBlogDb() : base("name=DefaultConnection")
        {

        }
        public DbSet<Beer> Beer { get; set; } // select * in SQL Server
        public DbSet<BeerReviews> Reviews { get; set; }

    }
}