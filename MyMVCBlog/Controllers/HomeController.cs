using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        MyMVCBlog.Models.BlogContext context = new MyMVCBlog.Models.BlogContext();
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CategoryWidgetGetir()
        {
            return View(context.Categories);
        }
        public ActionResult PostWidgetGetir()
        {
            ViewBag.Fresh = context.Articlees.OrderByDescending(x => x.DateTime).Take(5); //last last added 5 article
            ViewBag.Popular = context.Articlees.OrderByDescending(x => x.SeenTimes).Take(5);
            return View();
        }
        public ActionResult TagsWidgetGetirr(){
            var tags = context.Tags.ToList();
            return View(tags);
        }
        public ActionResult TumMakalelerGetir()
        {
            var makaleler = context.Articlees.ToList();
            return View("ArticleeList",makaleler);
        }
    }
}
