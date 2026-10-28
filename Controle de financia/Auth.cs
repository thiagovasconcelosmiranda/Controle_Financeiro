using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_financia2
{
    public class Auth
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string question { get; set; }
        public string response { get; set; }
      

    }
}
