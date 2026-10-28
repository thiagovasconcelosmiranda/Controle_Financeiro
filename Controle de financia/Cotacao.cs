using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Controle_de_financia2
{
    public class Cotacao
    {
        public string cotacao { get; set; } 
        public string data { get; set; }
    }
}
