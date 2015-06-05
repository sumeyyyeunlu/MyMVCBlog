using System;
using System.Collections.Generic;

namespace MyMVCBlog.Models
{
    public partial class WebChase
    {
        public string Mail { get; set; }
        public Nullable<System.Guid> WriterID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
