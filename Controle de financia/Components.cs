using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Controle_de_financia2
{
    public class Components
    {
        public static int convertRealInt(string valor)
        {
            int newValor = Convert.ToInt32(valor.Split(' ')[1].Replace(".", "").Replace(",",""));
            return newValor;   
        }

        public static int _charArray(ComboBox c)
        {
            if (!string.IsNullOrWhiteSpace(c.Text))
            {

                return Convert.ToInt32(c.Text.Split('X')[0]);

            }
            return 0;
        }

        public static bool verificaAniversario(string date)
        {
            string[] list = date.Split('-');

            int ano = Convert.ToInt32(list[0]);
            int mes = Convert.ToInt32(list[1]);
            int dia = Convert.ToInt32(list[2]);

            DateTime dataNascimento = new DateTime(ano, mes, dia);
            DateTime hoje = DateTime.Today;

            bool aniversarioHoje = (dataNascimento.Day == hoje.Day) &&
                       (dataNascimento.Month == hoje.Month);
            if (aniversarioHoje)
            {
                return true;
            }
           
            return false;
        }

        public static decimal calcSalario(decimal salario, decimal gastos)
        {
            if (salario== 0) return 0;
            decimal result = (gastos / salario);
            decimal porc = Math.Round(result * 100);
            return porc;
        }

        public static bool verifyDate(string date)
        {
            try
            {
                DateTime data = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (data >= DateTime.Today)
                {
                    return true;
                }
            } catch (Exception e) {
                MessageBox.Show($"Erro: {e.Message}");
            }

            return false;
        }

        public static void CaracterUpper(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.CharacterCasing = CharacterCasing.Upper;

                }

            }
        }

        public static void CaracterLower(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.CharacterCasing = CharacterCasing.Lower;

                }

            }
        }

        public static void InDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        public string acrecentaDiaMes(int ano, int mes, int dia)
        {
            try
            {

            
            DateTime dataOriginal = new DateTime(ano, mes, dia);
            DateTime dataMaisUmDia = dataOriginal.AddDays(1).AddMonths(1);

            return dataMaisUmDia.ToString("yyyy-MM-dd");
            }
            catch (Exception e) {
                MessageBox.Show($"Erro: {e.Message}");
            }
            return null;
        }

        public string converterDateBR(string dataOriginal)
        {
            try
            {

            
               DateTime data = DateTime.ParseExact(dataOriginal, "yyyy-MM-dd", CultureInfo.InvariantCulture);
               string dataFormatada = data.ToString("dd/MM/yyyy");
               return dataFormatada;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message}");
            }

            return null;
        }

          public string converterDateInt(string dataOriginal)
        {
            try
            {
                DateTime data = DateTime.ParseExact(dataOriginal, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                string dataFormatada = data.ToString("yyyy-MM-dd");
                return dataFormatada;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de data:" + e.Message);
            }

            return null;
        }
    

        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];

            // gera salt aleatório
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }


            var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                100000,
                HashAlgorithmName.SHA256
            );

            byte[] hash = pbkdf2.GetBytes(32);

            return Convert.ToBase64String(salt) + "." + Convert.ToBase64String(hash);

        }


        public static bool verificarSenha(string senhaDigitada, string senhaSalva)
        {
            var partes = senhaSalva.Split('.');

            byte[] salt = Convert.FromBase64String(partes[0]);
            byte[] hashSalvo = Convert.FromBase64String(partes[1]);

            var pbkdf2 = new Rfc2898DeriveBytes(
        senhaDigitada,
        salt,
        100000,
        HashAlgorithmName.SHA256
    );

            byte[] hashDigitado = pbkdf2.GetBytes(32);

            return hashDigitado.SequenceEqual(hashSalvo);
        }


    }
}
