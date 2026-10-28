using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_financia2
{
    public class User
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public string birst { get; set; }
        public int authId { get; set; }
        public string sex { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string question { get; set; }
        public string response { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
