using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormNovoUsuario : Form
    {
        private int _authId;
        public FormNovoUsuario()
        {
            InitializeComponent();
            tbNovoPassword.PasswordChar = '*';
            tbRepetePassword.PasswordChar = '*';
            this.AcceptButton = btnAddAdicionar;
        }
     
        private User getUser()
        {
            User user = new User();
            user.firstname = tbAddName.Text;
            user.lastname = tbAddSobrenome.Text;
            user.cpf = mtbAddCpf.MaskFull ? mtbAddCpf.Text : "";
            user.cnpj = mtAddCnpj.MaskFull ? mtAddCnpj.Text : "";
            user.authId = this._authId;
            user.birst = mtbAddDataNascimento.Text;
            user.sex = cbAddSexo.Text;
            user.created_at = DateTime.Now;
            user.updated_at = DateTime.Now;
            return user;
        }

        private Work getWork()
        {
            Work work = new Work();
            work.establishment = tbAddEstabelecimento.Text;
            work.wage = Components.convertRealInt(tbAddSalario.Text);
            work.situation = cbAddSituacao.Text;
            work.position = tbAddCargo.Text;
            work.created_at = DateTime.Now;
            work.updated_at = DateTime.Now;
            work.authId = this._authId;
           
            return work;

        }
        public Auth getAuth()
        {
            Auth auth = new Auth();
            auth.email = tbAddEmail.Text;
            auth.password = Components.HashPassword(tbNovoPassword.Text);
            auth.question = cbNovoPergunta.Text;
            auth.response = Components.HashPassword(tbNovaResposta.Text);
            auth.created_at = DateTime.Now;
            auth.updated_at = DateTime.Now;
           
            return auth;
        }

        private void tbAddSalario_TextChanged_1(object sender, EventArgs e)
        {
            ComponentText.converterRealMasked(tbAddSalario);

        }

        private void tbAddSalario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Components.InDecimal(sender, e);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void cbMaiusculo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbMaiusculo.Checked == true)
            {
                Components.CaracterUpper(panel1);
                return;
            }

            Components.CaracterLower(panel1);
        }

        private void btnAddAdicionar_Click_1(object sender, EventArgs e)
        {
            btnAddAdicionar.Enabled = false;

            ComponentText.checkTextbox(tbAddName, lbErrorName);
            ComponentText.checkTextbox(tbAddSobrenome, lbErrorSobrenome);
            ComponentText.chechComboBox(cbAddSexo, lbErrorSexo);
            ComponentText.checkTextbox(tbAddEmail, lbErrorEmail);
            ComponentText.checkMaskedBoxText(mtbAddDataNascimento, lbErrorDataNascimento);
            ComponentText.checkTextbox(tbNovoPassword, lbErrorNovoPassword);
            ComponentText.checkTextbox(tbRepetePassword, lbErrorRepetePassword);
            ComponentText.chechComboBox(cbNovoPergunta, lbErrorPergunta);
            ComponentText.checkTextbox(tbNovaResposta, lbErrorResposta);
            ComponentText.checkTextbox(tbAddEstabelecimento, lbErrorEstabelecimento);
            ComponentText.checkTextbox(tbAddCargo, lbErrorCargo);
            ComponentText.chechComboBox(cbAddSituacao, lbErrorSituacao);
            ComponentText.checkTextbox(tbAddSalario, lbErrorSalario);
           
            int count = 0;

            foreach (Control c in panelCpf.Controls)
            {
                if (c is MaskedTextBox mt && !mt.MaskFull)
                {
                    count++;
                    
                }
            }

            if (count > 1)
            {
                btnAddAdicionar.Enabled = true;
                lbErrorOption.Visible = true;
                return;
            }
            else
            {
                btnAddAdicionar.Enabled = false;
                lbErrorOption.Visible = false;
            }

            if (ComponentText.checkTexts(panel1) == false)
            {
                btnAddAdicionar.Enabled = true;
                return;
            }

            if (tbNovoPassword.Text != tbRepetePassword.Text)
            {
                lbErrorNovoPassword.Visible = true;
                lbErrorNovoPassword.Text = "Senha não confere*";
                btnAddAdicionar.Enabled = true;
                return;
            }
            UserDb userDb = new UserDb();
            AuthDB authDB = new AuthDB();
            WorkDb workDb = new WorkDb();

            int authId = authDB.adicionar(getAuth());

            if (authId > 0)
            {
                this._authId = authId;
                
               if (userDb.adicionar(getUser()) > 0)
               {
                   if (workDb.adicionar(getWork()) > 0)
                   {
                        new FormAlertMessage("Conta criada com sucesso!", true).ShowDialog();

                        this.Close();
                       return;
                   }
                  
               }
            }
            else
            {
                new FormAlertMessage("Erro ao adicionar", false).ShowDialog();

            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAddSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            Components.InDecimal(sender, e);
        }

        private void tbAddSalario_TextChanged(object sender, EventArgs e)
        {
            ComponentText.converterRealMasked(tbAddSalario);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbAddSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAddSituacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbNovoPergunta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCpf.Checked)
            {
                mtbAddCpf.Enabled = true;
                mtAddCnpj.Enabled = false;
            }
          
        }

        private void rbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCnpj.Checked == true)
            {
                mtbAddCpf.Enabled = false;
                mtAddCnpj.Enabled = true;

            }
           
        }

        private void mtAddCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pbMostrarNovoPassword_Click(object sender, EventArgs e)
        {
            pbMostrarNovoPassword.Visible = false;
            pbOcutarNovoPassword.Visible = true;
            tbNovoPassword.PasswordChar = '\0';

        }

        private void pbOcutarNovoPassword_Click(object sender, EventArgs e)
        {
            pbMostrarNovoPassword.Visible = true;
            pbOcutarNovoPassword.Visible = false;
            tbNovoPassword.PasswordChar = '*';
        }

        private void pbMostrarRepetePassword_Click(object sender, EventArgs e)
        {
            pbMostrarRepetePassword.Visible = false;
            pbOcutarRepetePassword.Visible = true;
            tbRepetePassword.PasswordChar = '\0';

        }

        private void pbOcutarRepetePassword_Click(object sender, EventArgs e)
        {
            pbMostrarRepetePassword.Visible = true;
            pbOcutarRepetePassword.Visible = false;
            tbRepetePassword.PasswordChar = '*';
        }

    }
}
