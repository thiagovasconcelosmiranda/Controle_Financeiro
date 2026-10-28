using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_financia2
{
    public class FluxoConta
    {
        public int id { get; set; }
        public string estabelecimento { get; set; }
        public string tipo_conta { get; set; }
        public string data_venc { get; set; }
        public int valor { get; set; }
        public int userId { get; set; }
        public string status { get; set; }
        public int ano_reference { get; set; }
        public int mes_reference { get; set; }
        public string file { get; set; }
        public string description { get; set; }
        public int parc { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

    }
}
