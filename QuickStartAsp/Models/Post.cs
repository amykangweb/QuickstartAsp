using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuickStartAsp.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}