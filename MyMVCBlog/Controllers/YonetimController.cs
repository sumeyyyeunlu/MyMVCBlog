using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MyMVCBlog.Controllers
{
    using Models;
    public class YonetimController : Controller
    {
        MyMVCBlog.Models.BlogContext context = new MyMVCBlog.Models.BlogContext();
       

        public ActionResult Index()
        {
            ViewBag.Tip = 1;
            return View();
        }
        public ActionResult MakaleYaz()
        {
            ViewBag.Tip = 1;
            ViewBag.Categories = context.Categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult MakaleYaz(MyMVCBlog.Models.Articlee makale ,HttpPostedFileBase Resim,string Etiketler)
        {
            if(makale !=null){
                MyMVCBlog.Models.Writer aktif=Session["Writer"] as MyMVCBlog.Models.Writer;
                makale.DateTime = DateTime.Now;
                makale.ArticleTypeID = 1;
                makale.WriterID = aktif.ID;
                makale.ImageID = ResimKaydet(Resim);
                context.Articlees.Add(makale);
                context.SaveChanges();

                string[] tags = Etiketler.Split(',');
                foreach(string etiket in tags){
                    Tag etk= context.Tags.FirstOrDefault(x => x.Name.ToLower() == etiket.ToLower().Trim());
                    if (etk == null){
                        
                        etk = new Tag();
                        etk.Name = etiket;
                        makale.Tags.Add(etk);
                        context.SaveChanges();
                        } 
                        makale.Tags.Add(etk);
                        context.SaveChanges();
                        //etiket yok
                 }
                }

              return View();
            }
            
        }

       private int ResimKaydet(HttpPostedFileBase Resim)
        {
          

            int kucukWidth = Convert.ToInt32( ConfigurationManager.AppSettings["kw"]);
            int kucukHeight = Convert.ToInt32(ConfigurationManager.AppSettings["kh"]);
            int ortaWidth = Convert.ToInt32(ConfigurationManager.AppSettings["ow"]);
            int ortakHeight = Convert.ToInt32(ConfigurationManager.AppSettings["oh"]);
            int buyukWidth = Convert.ToInt32(ConfigurationManager.AppSettings["bw"]);
            int buyukHeight = Convert.ToInt32(ConfigurationManager.AppSettings["bh"]);

            String newName = Path.GetFileNameWithoutExtension(Resim.FileName)+"-"+Guid.NewGuid()+Path.GetExtension(Resim.FileName);

            System.Drawing.Image orjRes = System.Drawing.Image.FromStream(Resim.InputStream);
            Bitmap kucukRes = new Bitmap(orjRes, kucukWidth,kucukHeight);
            Bitmap ortaRes = new Bitmap(orjRes, ortaWidth, ortaHeight);
            Bitmap buyukRes = new Bitmap(orjRes, buyukWidth, buyukHeight);

            kucukRes.Save(Server.MapPath("~/Content/Resimler/Kucuk"+newName));
            ortaRes.Save(Server.MapPath("~/Content/Resimler/Orta" + newName));
            buyukRes.Save(Server.MapPath("~/Content/Resimler/Buyuk" + newName));
            
            Writer k=(Writer)Session["Writer"];
            
            Image dbRes = new Image();
            dbRes.Name = Resim.FileName;
            dbRes.BigImageWay = "/Content/Resimler/Buyuk" + newName ;
            dbRes.SmallImageWay = "/Content/Resimler/Kucuk" + newName;
            dbRes.MideumImageWay = "/Content/Resimler/Orta" + newName;

           
           dbRes.AddedID=k.ID;

           context.Images.Add(dbRes);
           context.SaveChanges();

           return dbRes.ID;
           }
       
       
    }
}
