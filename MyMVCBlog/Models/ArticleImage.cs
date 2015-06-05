using System;
using System.Collections.Generic;

namespace MyMVCBlog.Models
{
    public partial class ArticleImage
    {
        public int ArticleID { get; set; }
        public int ImageID { get; set; }
        public virtual Articlee Articlee { get; set; }
        public virtual Articlee Articlee1 { get; set; }
        public virtual Image Image { get; set; }
        public virtual Image Image1 { get; set; }
    }
}
