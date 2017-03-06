using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToBeer.Models
{
    public class BeerReviews
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }
        public string Type { get; set; }


    }
}