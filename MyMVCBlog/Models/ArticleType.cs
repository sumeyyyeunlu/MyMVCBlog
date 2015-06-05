using System;
using System.Collections.Generic;

namespace MyMVCBlog.Models
{
    public partial class ArticleType
    {
        public ArticleType()
        {
            this.Articlees = new List<Articlee>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Articlee> Articlees { get; set; }
    }
}
