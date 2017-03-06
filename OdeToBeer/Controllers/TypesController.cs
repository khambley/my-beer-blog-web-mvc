using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToBeer.Controllers
{
    public class TypesController : Controller
    {
        // GET: Types
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);

            return Content(message);
        }
    }
}