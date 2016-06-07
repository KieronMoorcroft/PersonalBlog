using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PersonalBlog.Models
{
    public class PersonalBlogPostModel
    {

        // Model properties

        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }

        public DateTime CreateTime { get; set; }


    }
  
}