using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_financia2
{
    public class Debtor
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string establishment { get; set; }
        public string cpf{ get; set; }
        public string cnpj { get; set; }
        public int price{ get; set; }
        public int userId { get; set; }
        public int parc { get; set; }
        public DateTime created_at{ get; set; }
        public DateTime updated_at { get; set; }
        public string date_operation { get; set; }
        public int mes_reference { get; set; }
        public int ano_reference { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string file { get; set; }

    }
}
