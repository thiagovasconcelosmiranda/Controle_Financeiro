using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormAddConection : Form
    {
        public FormAddConection()
        {
            InitializeComponent();
            tbAddPassword.PasswordChar = '*';
                
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = false;

            ComponentText.checkTextbox(tbAddUrl, lbErrorUrl);
            ComponentText.checkTextbox(tbAddPorta, lbErrorPorta);
            ComponentText.checkTextbox(tbAddDataBase, lbErrorDataBase);
            ComponentText.checkTextbox(tbAddUser, lbErrorUser); 
            ComponentText.checkTextbox(tbAddPassword, lbErrorPassword);


            if (ComponentText.checkTexts(panel2) == false)
            {
                btnConectar.Enabled = true;
                return;
            }
            
            string caminhoBase = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoBanco = Path.Combine(caminhoBase, "conexao.txt");

            List<string> listaItens = new List<string> { 
                tbAddPorta.Text, 
                tbAddDataBase.Text, 
                tbAddUser.Text,
                tbAddPassword.Text,
                tbAddUrl.Text
            };

            File.WriteAllLines(caminhoBanco, listaItens);

            new FormAlertMessage("Banco adicionado com sucesso!", true).ShowDialog();
            this.Close();
            
        } 

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbAddPorta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Components.InDecimal(sender, e);
        }
    }
}
