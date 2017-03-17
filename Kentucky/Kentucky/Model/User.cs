using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentucky.Model
{
    public class User
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public double rating { get; set; }
        public Login login { get; set; }
    }
}
