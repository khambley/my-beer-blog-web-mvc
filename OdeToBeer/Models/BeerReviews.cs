using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToBeer.Models
{
    public class BeerReviews
    {
        public int Id { get; set; }
        public string Rating { get; set; }
        public string Comments { get; set; }
        public int BeerId { get; set; }



    }
}