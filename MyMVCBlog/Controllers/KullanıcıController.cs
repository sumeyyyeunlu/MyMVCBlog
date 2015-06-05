using MyMVCBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MyMVCBlog.Controllers
{
      
    public class KullanıcıController : Controller
    {
        MyMVCBlog.Models.BlogContext context = new BlogContext();
        //
        // GET: /Kullanıcı/
        [HttpPost]
        public ActionResult GirisYap(string kullaniciAdi,string parola)
        
        {
            if(Membership.ValidateUser(kullaniciAdi , Parola)){
                FromsAuthentication.RedirectFromLoginPage(kullaniciAdi,true);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Mesaj = "Kullanıcı vaya parola yanılş!";
            }
            return View();
        }
            
        
        public ActionResult KayıtOl()
        {
            return View();
        }


        public ActionResult GirisYap()
        {
            return View();
        }
        public ActionResult KayıtOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayıtOl(Writer k,HttpPostedFileBase Image,string parola)
        {

            MembershipUser user = Membership.CreateUser(k.Nick, parola, k.Mail);
            k.ID=(Guid)user.ProviderUSerKey;
            context.Writers.Add(k);
            context.SaveChanges();
            FormsAuthentication.RedirectFromLoginPage(k.Nick,true);

            Session["Writer"] = k;
            return RedirectToAction("Index","Home");
        }
    }
}
