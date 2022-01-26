using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class CommentModel
    {
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public int BlogId { get; set; }

    }
}