using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCBlog.Controllers
{
    public class ArticleeController : Controller
    {
        //
        // GET: /Articlee/
        MyMVCBlog.Models.BlogContext context = new MyMVCBlog.Models.BlogContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TariheGoreListele(int year, int month)
        {
            ViewBag.year = year;
            ViewBag.month = month;
            return View();
        }
        public ActionResult ArticleeList(int year=0 ,int month=0)
        {
            var data = context.Articlees.Where(x => x.DateTime.Year == year && x.DateTime.Month == month);
            return View("ArticleeList",data);
        }
        public ActionResult Detay(int id)
        {
            
                ViewBag.Writer = Session["Writer"];
                MyMVCBlog.Models.Articlee mk = context.Articlees.FirstOrDefault(x => x.ID == id );
                return View(mk);
        }
        [HttpPost]
        public ActionResult YorumYaz(MyMVCBlog.Models.Comment yorum)
        {
            yorum.AddedDate = DateTime.Now;
            yorum.Title="";
            yorum.Active = false;
            context.Comments.Add(yorum);
            context.SaveChanges();
            return RedirectToAction("Detay", new {id=yorum.ArticleID});
        }

    }
}
