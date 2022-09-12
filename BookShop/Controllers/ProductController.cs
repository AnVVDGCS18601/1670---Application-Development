using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.Models;
namespace BookShop.Controllers
{
    public class ProductController : Controller
    {
        BookShopEntities db = new BookShopEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View("Products");
        }
        public ActionResult Products()
        {
            var categories = db.Categories.ToList();
            ViewBag.Categories = categories;

            var products = db.Products.ToList();
            ViewBag.Products = products;
            return PartialView();
        }
    }

}