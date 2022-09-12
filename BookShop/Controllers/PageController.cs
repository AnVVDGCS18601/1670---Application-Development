using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShop.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Testimonial()
        {
            return View();
        }
    }
}