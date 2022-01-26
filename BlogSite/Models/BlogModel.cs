using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class BlogModel
    {
        public Guid UserId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogDescription { get; set; }
        public string BlogType { get; set; }
        public int BlogCategoryId { get; set; }
    }
}