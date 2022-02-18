using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loremgram.Controllers
{
    public class RegisController : Controller
    {
        // GET: Regis
        public ActionResult Index()
        {
            ViewBag.Title = "Regis Page";
            return View();
        }
    }
}