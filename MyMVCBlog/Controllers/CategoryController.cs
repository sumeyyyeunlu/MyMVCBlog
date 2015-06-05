using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCBlog.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/
        MyMVCBlog.Models.BlogContext context = new MyMVCBlog.Models.BlogContext();
        public ActionResult Index(int id)
        {
            return View(id);
        }
        public ActionResult ArticleeList(int id)
        {
            var data = context.Articlees.Where(x => x.CategoryID == id);
            return View("ArticleeList",data);
        }

    }
}
