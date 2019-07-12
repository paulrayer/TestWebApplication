using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApplication.Controllers
{
    public class OctopusController : Controller
    {
        // GET: Octopus
        public ActionResult Index()
        {
            return View();
        }
    }
}