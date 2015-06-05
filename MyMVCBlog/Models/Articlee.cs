using System;
using System.Collections.Generic;

namespace MyMVCBlog.Models
{
    public partial class Articlee
    {
        public Articlee()
        {
            this.ArticleImages = new List<ArticleImage>();
            this.ArticleImages1 = new List<ArticleImage>();
            this.Comments = new List<Comment>();
            this.Tags = new List<Tag>();
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public System.DateTime DateTime { get; set; }
        public int CategoryID { get; set; }
        public int ArticleTypeID { get; set; }
        public System.Guid WriterID { get; set; }
        public int ImageID { get; set; }
        public int Like { get; set; }
        public int SeenTimes { get; set; }
        public bool Active { get; set; }
        public virtual ArticleType ArticleType { get; set; }
        public virtual Category Category { get; set; }
        public virtual Image Image { get; set; }
        public virtual Writer Writer { get; set; }
        public virtual Writer Writer1 { get; set; }
        public virtual ICollection<ArticleImage> ArticleImages { get; set; }
        public virtual ICollection<ArticleImage> ArticleImages1 { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
