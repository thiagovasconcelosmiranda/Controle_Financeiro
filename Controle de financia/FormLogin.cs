using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormLogin : Form
    {
        Thread nt;
        private string _email = "";
        private string _file;
       

        public FormLogin()
        {
            InitializeComponent();
           

            tbPassword.PasswordChar = '*';
            this.AcceptButton = btnEntrar;

             this._file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logar.txt");
        }

        private void novoUsuario()
        {
            Application.Run(new FormNovoUsuario());
        }

        public Auth getAuth()
        {
            Auth auth = new Auth();
            auth.email = tbEmail.Text.Trim();
            auth.password = tbPassword.Text.Trim();
            auth.created_at = DateTime.Now;
            auth.updated_at = DateTime.Now;
            return auth;
        }

    
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nt = new Thread(novoUsuario);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

     
      
        private void btnEntrar_Click(object sender, EventArgs e)
        { 
            btnEntrar.Enabled = false;
            ComponentText.checkTextbox(tbEmail, lbErrorEmail);
            ComponentText.checkTextbox(tbPassword, lbErrorPassword);

            if (ComponentText.checkTexts(panel1) == false)
            {
                btnEntrar.Enabled = true;
                return;
            }

            AuthDB authDb = new AuthDB();
            Auth auth = authDb.authlogin(getAuth());

            if (auth == null)
            {
                new FormAlertMessage("Erro ao logar!", false).ShowDialog();
                btnEntrar.Enabled = true;
                return;
            }


            if (Components.verificarSenha(tbPassword.Text, auth.password) == false)
            {
                new FormAlertMessage("Email ou senha invalido!", false).ShowDialog();
                btnEntrar.Enabled = true;
                return;
            }

            this._logar();
            FormMain main = new FormMain(auth.id);
            main.Show();
            this.Hide();
        }

        private void _logar()
        {
            
            if (File.Exists(this._file)){
                if(this._email == "")
                   return;
                
                if(cbLogado.Checked == true)
                {
                   File.WriteAllText(this._file, this._email);
                    return;
                }
                File.WriteAllText(_file, "");
            }
        }

        private void linkLbEmail_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormRespostaSecreta().ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormNovoUsuario().ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string caminhoBase = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoBanco = Path.Combine(caminhoBase, "conexao.txt");


            if (File.Exists(caminhoBanco) && new FileInfo(caminhoBanco).Length == 0)
            {
                new FormAddConection().ShowDialog();
            }

            if (File.Exists(this._file))
            {
                string lerConteudo = File.ReadAllText(this._file);
                if(lerConteudo.Length > 0)
                {
                    tbEmail.Text = lerConteudo.Trim();
                    cbLogado.Checked = true;
                }
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void alterarConexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAlterarDbConection().ShowDialog();
        }

        private void cbLogado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLogado.Checked == true)
            {
                if (tbEmail.Text != "")
                   this._email = tbEmail.Text;
                
                return;
            }
        }

        private void pbMostrarOcutar_Click(object sender, EventArgs e)
        {
            pbMostrarOcutar.Visible = false;
            pbOcutarPassword.Visible = true;
            tbPassword.PasswordChar = '\0';
        }

        private void pbOcutarPassword_Click(object sender, EventArgs e)
        {
            pbMostrarOcutar.Visible = true;
            pbOcutarPassword.Visible = false;
            tbPassword.PasswordChar = '*';
        }
    }
}
