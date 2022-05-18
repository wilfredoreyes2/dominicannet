using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace presentacion.Controllers
{
    public class indexController : Controller
    {
        // GET: index
        public ActionResult home()
        {
            return View();
        }
    }
}