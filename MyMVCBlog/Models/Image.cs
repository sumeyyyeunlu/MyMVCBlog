using System;
using System.Collections.Generic;

namespace MyMVCBlog.Models
{
    public partial class Image
    {
        public Image()
        {
            this.Articlees = new List<Articlee>();
            this.ArticleImages = new List<ArticleImage>();
            this.ArticleImages1 = new List<ArticleImage>();
            this.Writers = new List<Writer>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string SmallImageWay { get; set; }
        public string MideumImageWay { get; set; }
        public string BigImageWay { get; set; }
        public string VideoWay { get; set; }
        public System.Guid AddedID { get; set; }
        public System.DateTime AddedTime { get; set; }
        public int SeenTimes { get; set; }
        public int Like { get; set; }
        public virtual ICollection<Articlee> Articlees { get; set; }
        public virtual ICollection<ArticleImage> ArticleImages { get; set; }
        public virtual ICollection<ArticleImage> ArticleImages1 { get; set; }
        public virtual Writer Writer { get; set; }
        public virtual ICollection<Writer> Writers { get; set; }

        internal static Image FromStream()
        {
            throw new NotImplementedException();
        }
    }
}
