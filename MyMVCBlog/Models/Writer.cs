using System;
using System.Collections.Generic;

namespace MyMVCBlog.Models
{
    public partial class Writer
    {
        public Writer()
        {
            this.Articlees = new List<Articlee>();
            this.Articlees1 = new List<Articlee>();
            this.Comments = new List<Comment>();
            this.Comments1 = new List<Comment>();
            this.Images = new List<Image>();
            this.WebChases = new List<WebChase>();
        }

        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public System.DateTime RecordDate { get; set; }
        public string Nick { get; set; }
        public int ImageID { get; set; }
        public bool Active { get; set; }
        public bool writer1 { get; set; }
        public virtual ICollection<Articlee> Articlees { get; set; }
        public virtual ICollection<Articlee> Articlees1 { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Comment> Comments1 { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual Image Image { get; set; }
        public virtual ICollection<WebChase> WebChases { get; set; }
    }
}
