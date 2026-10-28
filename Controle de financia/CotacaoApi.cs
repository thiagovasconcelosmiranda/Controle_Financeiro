using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public class CotacaoApi
    {

        public async Task<Cotacao> getMoedaAsunc(string moeda)
        {
            try
            {
                string url = $"https://economia.awesomeapi.com.br/json/last/{moeda}";
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(url);
                    string newModeda = moeda.Replace("-","");
                    var dados = JsonDocument.Parse(response);
                    var usdbrl = dados.RootElement.GetProperty(newModeda);

                    string data = usdbrl.GetProperty("create_date").GetString();

                    Cotacao c = new Cotacao()
                    {
                        cotacao = usdbrl.GetProperty("bid").GetString(),
                        data = usdbrl.GetProperty("create_date").GetString()
                    };

                    return c;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
            return null;


        }
    }
}
