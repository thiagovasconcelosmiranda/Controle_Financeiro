using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Controle_de_financia2
{
    public partial class FormAlterarUsuario : Form
    {
        private int _id;
        private int _userId;
        private string _secret;
        private string _question;
        private string _password;

        AuthDB authDB = new AuthDB();
        UserDb userDb = new UserDb();
        WorkDb workDb = new WorkDb();
        FluxoContaDb fluxoContaDb = new FluxoContaDb();
        DebtorsDb debtorsDb = new DebtorsDb();

        public FormAlterarUsuario(int authId, int userId)
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
            tbAlterNovoPassword.PasswordChar = '*';
            tbAlterRepetePassword.PasswordChar = '*';
            this.AcceptButton = btnAlter;
         
            this._id = authId;
            this._userId = userId;
            

            User user = userDb.getUserAuthId(authId);
            this._password = user.password;
            this._secret = user.response;
            this._question = user.question;

            this.setUser(user);

            Work work = workDb.getWorkAuthId(authId);
           
            this.setWork(work);   
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain formMain = Application.OpenForms["FormMain"] as FormMain;

            if (formMain != null)
            {
                formMain._atualizar();
            }
        }

        private User getUser()
        {
            User user = new User();
            user.firstname = tbAlterName.Text.Trim();
            user.lastname = tbAlterSobrenome.Text;
            user.sex = cbAlterSexo.Text.Trim();
            user.birst = mtbAlterDataNascimento.Text.Trim();
            user.authId = this._id;
            user.updated_at = DateTime.Now;

            return user;
        }

        private Auth getAuth(string secret, string question)
        {
            string password = tbAlterNovoPassword.Text != "" ?
                 Components.HashPassword(tbAlterNovoPassword.Text) :this._password;

            Auth auth = new Auth();
            auth.password = password;
            auth.email = tbAlterEmail.Text;
            auth.updated_at = DateTime.Now;
            auth.question = cbAlterPergunta.Text != "" ? cbAlterPergunta.Text.Trim() :
                question.Trim();
            auth.response = tbAlterResposta.Text != "" ?
                Components.HashPassword(tbAlterResposta.Text.Trim()) : secret.Trim() ;
            auth.id = this._id;
        
            return auth;
        }

        private Work getWork()
        {
            Work work = new Work();
            work.authId = this._id;
            work.establishment = tbAlterEstabelecimento.Text;
            work.position = tbAlterCargo.Text;
            work.wage = Components.convertRealInt(tbAlterSalario.Text);
            work.situation = cbAlterSituacao.Text;
            work.created_at = DateTime.Now;
            work.updated_at = DateTime.Now;

            return work;
        }

        private void setUser(User user)
        {
            tbAlterName.Text = user.firstname.Trim();
            tbAlterSobrenome.Text = user.lastname.Trim();
            mtbAlterDataNascimento.Text = user.birst.Trim();
            cbAlterSexo.Text = user.sex.Trim();
            mtbAlterDataNascimento.Text = user.birst.Trim();
            tbAlterEmail.Text = user.email.Trim();
        }

        private void setWork(Work work)
        {
            if (work == null)
            {
                btnAlter.Enabled = true;
                return;
            }

            tbAlterEstabelecimento.Text = work.establishment.Trim();
            cbAlterSituacao.Text = work.situation.Trim();
            tbAlterCargo.Text = work.position.Trim();
            tbAlterSalario.Text = work.wage.ToString().Trim();
        }


        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
     

        private void btnAlter_Click(object sender, EventArgs e)
        {
            btnAlter.Enabled = false;
            UserDb userDb = new UserDb();

            ComponentText.checkTextbox(tbAlterName, lbErrorName);
            ComponentText.checkTextbox(tbAlterSobrenome, lbErrorSobrenome);
            ComponentText.checkTextbox(tbAlterEmail, lbErrorEmail);
            ComponentText.checkMaskedBoxText(mtbAlterDataNascimento, lbErrorDataNascimento);
            ComponentText.chechComboBox(cbAlterSexo, lbErrorSexo);
            ComponentText.checkTextbox(tbAlterEstabelecimento, lbErrorEstabelecimento);
            ComponentText.checkTextbox(tbAlterCargo, lbErrorCargo);
            ComponentText.chechComboBox(cbAlterSituacao, lbErrorSituacao);

            if (ComponentText.checkTexts(panel1) == false)
            {
                btnAlter.Enabled = true;
                return;
            }

            if (tbAlterNovoPassword.Text != tbAlterRepetePassword.Text)
            {
                lbErrorNovoPassword.Visible = true;
                lbErrorNovoPassword.Text = "Senha não confere*";
                btnAlter.Enabled = true;
                return;
            }

            if (userDb.update(getUser()) > 0)
                if (authDB.update(getAuth(this._secret, this._question)) > 0)
                    if (workDb.update(getWork()) > 0)
                    {
                        new FormAlertMessage("Dados alterados com sucesso!", true).ShowDialog();
                        this.Close();
                    }
            
        }
        private void file(string file, string diretoryName)
        {
            if(file.Trim() !=""){
                string filename = file.Replace("\\","/").Split('/')[4];
                string destFolderFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{diretoryName}/{this._userId}/{filename}");
                string diretoryUserId= Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{diretoryName}/{this._userId}");

                if (destFolderFile != "")
                {
                    File.Delete(destFolderFile);
                    if (Directory.Exists(diretoryUserId))
                    {
                        Directory.Delete(diretoryUserId);
                    }
                }
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
              " Você perderá todos os seus dados! Tem certeza que excluir sua conta?",
              "Confirmar saída",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
             );

            if (resultado == DialogResult.Yes)
            {
                List<FluxoConta> fluxoContas = fluxoContaDb.listFluxoConta(this._userId);

                if (fluxoContas != null)
                {
                    foreach (FluxoConta f in fluxoContas)
                    {
                        this.file(f.file, "ComprovantesContas");
                        fluxoContaDb.excluir(f.id);
                    }
                }

                List<Debtor> debtors = debtorsDb.GetDebtorsAll(this._userId);

                if (debtors != null)
                {
                    foreach (Debtor d in debtors)
                    {
                        file(d.file, "ComprovantesDeevedores");
                        debtorsDb.excluir(d.id, this._userId);
                    }
                }

                
                if (workDb.delete(this._id) < 1)
                    return;
                 
                if (userDb.excluir(this._id) < 1)
                 return;
                  
                if (authDB.excluir(this._id) < 1)
                  return;
                
                new FormAlertMessage("Usuario deletado com sucesso! \n Obrigado por utilizar nosso serviços!", true).ShowDialog();
                Application.Exit();
         
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAlterSalario_KeyPress(object sender, KeyPressEventArgs e)
        { 
            Components.InDecimal(sender, e);
        }

        private void tbAlterSalario_TextChanged_1(object sender, EventArgs e)
        {
            ComponentText.converterRealMasked(tbAlterSalario);
        }

        private void cbMaiusculo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaiusculo.Checked == true)
            {
                Components.CaracterUpper(panel1);
                return;
            }
            Components.CaracterLower(panel1);
        }

        private void cbAlterSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAlterSituacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAlterPergunta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pbMostrarAlterNovoPassword_Click(object sender, EventArgs e)
        {
            pbMostrarAlterNovoPassword.Visible = false;
            pbOcutarAlterNovoPassword.Visible = true;
            tbAlterNovoPassword.PasswordChar = '\0';

        }

        private void pbOcutarAlterNovoPassword_Click(object sender, EventArgs e)
        {
            pbMostrarAlterNovoPassword.Visible = true;
            pbOcutarAlterNovoPassword.Visible = false;
            tbAlterNovoPassword.PasswordChar = '*';
        }

        private void pbMostarAlterRepetePassword_Click(object sender, EventArgs e)
        {
            pbMostarAlterRepetePassword.Visible = false;
            ptOcutarAlterRepetePassword.Visible = true;
            tbAlterRepetePassword.PasswordChar = '\0';
        }

        private void ptOcutarAlterRepetePassword_Click(object sender, EventArgs e)
        {
            pbMostarAlterRepetePassword.Visible = true;
            ptOcutarAlterRepetePassword.Visible = false;
            tbAlterRepetePassword.PasswordChar = '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
            
}
