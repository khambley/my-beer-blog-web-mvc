using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToBeer.Models
{
    public class MyBeerBlogDb : DbContext
    {
        public DbSet<Beer> Beers { get; set; }
        public DbSet<BeerReviews> Reviews { get; set; }

    }
}