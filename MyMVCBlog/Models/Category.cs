using System;
using System.Collections.Generic;

namespace MyMVCBlog.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Articlees = new List<Articlee>();
            this.WebChases = new List<WebChase>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Articlee> Articlees { get; set; }
        public virtual ICollection<WebChase> WebChases { get; set; }
    }
}
