using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCBlog.Controllers
{
    public class WriterController : Controller
    {
        MyMVCBlog.Models.BlogContext context = new MyMVCBlog.Models.BlogContext();

        public ActionResult Index(Guid id)
        {
            return View();
        }
        public ActionResult ArticleeList(Guid id)
        {
            var data = context.Articlees.Where(x => x.WriterID==id);
            return View("ArticleeList",data);
        }
    }
}
