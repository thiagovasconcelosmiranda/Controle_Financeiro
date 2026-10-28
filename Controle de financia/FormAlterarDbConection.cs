using Controle_de_financia2.infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormAlterarDbConection : Form
    {
       private string caminhoBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "conexao.txt");
        public FormAlterarDbConection()
        {
            InitializeComponent();
            setConnection(getConectionGerar());
            tbAlterPassword.PasswordChar = '*';
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;

            ComponentText.checkTextbox(tbAlterUrl, lbErrorUrl);
            ComponentText.checkTextbox(tbAlterPorta, lbErrorPorta);
            ComponentText.checkTextbox(tbAlterDataBase, lbErrorDataBase);
            ComponentText.checkTextbox(tbAlterPassword, lbErrorPassword);
            ComponentText.checkTextbox(tbAlterUser, lbErrorUser);

            if(ComponentText.checkTexts(panel1) == false)
            {
                btnAlterar.Enabled = true;
                return;
            }

            List<string> listaItens = new List<string> {
                getConnection().port,
                getConnection().dataBase,
                getConnection().username,
                getConnection().password,
                getConnection().host
            };

            File.WriteAllLines(caminhoBanco, listaItens);

            new FormAlertMessage("Banco alterardo com sucesso!", true).ShowDialog();
            this.Close();
        }

        private void setConnection(Conection c)
        {
            tbAlterUrl.Text = c.host;
            tbAlterPorta.Text = c.port;
            tbAlterDataBase.Text = c.dataBase;
            tbAlterPassword.Text = c.password;
            tbAlterUser.Text = c.username;
        }

        private Conection getConnection()
        {
            Conection conn = new Conection()
            {
                port = tbAlterPorta.Text,
                dataBase = tbAlterDataBase.Text,
                password = tbAlterPassword.Text,
                username = tbAlterUser.Text,
                host = tbAlterUrl.Text
            };
            return conn;
        }

        private Conection getConectionGerar()
        {
            string[] linhas = File.ReadAllLines(this.caminhoBanco);

            List<string> listaLida = new List<string>(linhas);

            Conection conection = new Conection()
            {
               port = listaLida[0],
               dataBase = linhas[1],
               username = linhas[2],
               password = linhas[3],
               host = linhas[4],
            };
            return conection;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
