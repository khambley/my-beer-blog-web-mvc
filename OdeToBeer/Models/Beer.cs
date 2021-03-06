﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToBeer.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Image { get; set; } // http://cpratt.co/file-uploads-in-asp-net-mvc-with-view-models/
        public int CompanyId { get; set; }
        public ICollection<BeerReviews> Reviews { get; set; }

    }
}