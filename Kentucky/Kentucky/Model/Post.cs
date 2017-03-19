using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentucky.Model
{
    public class Post
    {
        public int? postId { get; set; }
        public string text { get; set; }
        public string color { get; set; }
        public User user { get; set; }
        public List<Report> reports { get; set; }
        public List<Like> likes { get; set; }
        public List<Favorite> favorites { get; set; }
    }
}
