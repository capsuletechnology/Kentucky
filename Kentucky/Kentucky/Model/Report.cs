using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentucky.Model
{
    public class Report
    {
        public int? reportID { get; set; }
        public int postUserID { get; set; }
        public User user { get; set; }
        public Post post { get; set; }
    }
}
