using System;
using System.Collections.Generic;

namespace MyMVCBlog.Models
{
    public partial class Comment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ArticleID { get; set; }
        public System.DateTime AddedDate { get; set; }
        public bool Active { get; set; }
        public Nullable<System.Guid> WriterID { get; set; }
        public virtual Articlee Articlee { get; set; }
        public virtual Writer Writer { get; set; }
        public virtual Writer Writer1 { get; set; }
    }
}
