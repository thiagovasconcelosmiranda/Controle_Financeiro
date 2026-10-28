using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_financia2
{
    public class ChartCalculoGasto
    {

        public string setor { set; get; }
        public decimal valor { get; set; }
        public short mensal { set; get; }

        public ChartCalculoGasto(short ano, string setor, decimal valor)
        {
            ano = ano;
            setor = setor;
            valor = valor;
        }


    }
}
