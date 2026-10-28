using System;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormRespostaSecreta : Form
    {
        AuthDB authDB = new AuthDB();
        private int _id;
        private string _secrete;
        private Auth auth1;
        public FormRespostaSecreta()
        {
            InitializeComponent();
            this.AcceptButton = btnVerificarResposta;
        }

        private Auth getAuth()
        {
            Auth auth = new Auth()
            {
                email = tbEmail.Text,
            };
            return auth;
        }

        private void btnAlterarPassword_Click_1(object sender, EventArgs e)
        {
            new FormAlterPassword(this.auth1).Show();
            this.Close();
        }

        private void btnVerificarEmail_Click_1(object sender, EventArgs e)
        {
            btnVerificarEmail.Enabled = false;
            ComponentText.checkTextbox(tbEmail, lbErrorEmail);

            if (ComponentText.checkTexts(panel1) == false)
            {
                btnVerificarEmail.Enabled = true;
                return;
            }

            Auth auth = authDB.authlogin(getAuth());


            if (auth == null)
            {
                new FormAlertMessage("Email não encontrado!", false).ShowDialog();
                btnVerificarEmail.Enabled = true;
                return;
            }
            this.auth1 = auth;

            lbPergunta.Enabled = true;
            tbSecrete.Enabled = true;
            btnVerificarResposta.Enabled = true;
            lbEmailVerificado.Visible = true;

            lbPergunta.Text = auth.question.ToString();

            this._secrete = auth.response;

        }

        private void btnVerificarResposta_Click_1(object sender, EventArgs e)
        {
            btnVerificarResposta.Enabled = false;
            ComponentText.checkTextbox(tbSecrete, lbErrorSecrete);

            if (ComponentText.checkTexts(panel1) == false)
            {
                btnVerificarResposta.Enabled = true;
                return;
            }

            if (Components.verificarSenha(tbSecrete.Text.Trim(), this._secrete.Trim()) == false)
            {
                new FormAlertMessage("resposta invalida!", false).ShowDialog();
                btnVerificarResposta.Enabled = true;
                return;
            }

            lbResposaVerificada.Visible = true;
            btnAlterarPassword.Enabled = true;
        }
    }
}
