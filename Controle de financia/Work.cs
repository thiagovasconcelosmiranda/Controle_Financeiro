using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_financia2
{
    public  class Work
    {

        public int id { get; set; }
        public string establishment { get; set;}
        public int wage { get; set; }
        public string situation { get; set; }
        public int authId { get; set; }
        public  DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string position { get; set; }
    }
}
