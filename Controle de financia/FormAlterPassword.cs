using System;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormAlterPassword : Form
    {
        private Auth _authDb;

        public FormAlterPassword(Auth auth)
        {
            InitializeComponent();
            this._authDb = auth;
            tbNovaPassword.PasswordChar = '*';
            tbRepetePassword.PasswordChar = '*';
        }
       

        private Auth getAuth()
        {
            Auth auth = new Auth()
            {
                id = this._authDb.id,
                email = this._authDb.email,
                password = Components.HashPassword(tbNovaPassword.Text.Trim()),
                question = this._authDb.question,
                response = this._authDb.response,
                updated_at = DateTime.Now
  
            };
            return auth;

        }

        private void btnAlterarPassword_Click_1(object sender, EventArgs e)
        {
            btnAlterarPassword.Enabled = false;

            ComponentText.checkTextbox(tbNovaPassword, lbErrorNovoPassword);
            ComponentText.checkTextbox(tbRepetePassword, lbErrorRepetePassword);

            if (ComponentText.checkTexts(panel1) == false)
            {
                btnAlterarPassword.Enabled = true;
                return;
            }

            if (tbNovaPassword.Text != tbRepetePassword.Text)
            {
                lbErrorRepetePassword.Visible = true;
                lbErrorRepetePassword.Text = "senhas não conferem*";
                btnAlterarPassword.Enabled = true;
                return;
            }

            AuthDB auth = new AuthDB();

            if (auth.update(getAuth()) > 0)
            {
                new FormAlertMessage("Senha alterado com sucesso!", true).ShowDialog();
                this.Close();
            }
        }

        private void pbOcutarPassword_Click(object sender, EventArgs e)
        {
            tbNovaPassword.PasswordChar = '*';
            pbMostrarOcutar.Visible = true;
            pbOcutarPassword.Visible = false;
        }

        private void pbMostrarOcutar_Click(object sender, EventArgs e)
        {
            tbNovaPassword.PasswordChar = '\0';
            pbMostrarOcutar.Visible = false;
            pbOcutarPassword.Visible = true;
        }

        private void pbOcultarRepetPassword_Click(object sender, EventArgs e)
        {
            tbRepetePassword.PasswordChar = '*';
            pbMostrarRepetPassword.Visible = true;
            pbOcultarRepetPassword.Visible = false;
        }

        private void pbMostrarRepetPassword_Click(object sender, EventArgs e)
        {
            tbRepetePassword.PasswordChar = '\0';
            pbMostrarRepetPassword.Visible = false;
            pbOcultarRepetPassword.Visible = true;
        }
    }
}
