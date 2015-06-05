using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCBlog.Controllers
{
    public class TagController : Controller
    {
        //
        // GET: /Tag/
        MyMVCBlog.Models.BlogContext context = new MyMVCBlog.Models.BlogContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MakaleListele(int id)
        {
            var data = context.Articlees.Where(x => x.Tags.Any(me => me.ID == id));
            return View("ArticleeList",data);
        }
    }
}
