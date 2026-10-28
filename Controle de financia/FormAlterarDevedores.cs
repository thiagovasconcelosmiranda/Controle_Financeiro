using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormAlterarDevedores : Form
    {
        private int _userId;
        private int _id;
        private string _destFolder ="";
        private string _sourceFile ="";
        private string _destFile = "";
        private string _destFolderDb = "";

        DebtorsDb debtorsDb = new DebtorsDb();


        public FormAlterarDevedores(int id, int userId)
        {
            InitializeComponent();
            this._userId = userId;
            this._destFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ComprovantesDeevedores/{this._userId}");
            this._setDebtor(debtorsDb.GetDebtorId(id, userId));

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool errorPanel = true;

            btnAlterar.Enabled = false;

            if (panelNomeSobrenome.Enabled != false)
            {
                ComponentText.checkTextbox(tbAlterNome, lbErrorNome);
                ComponentText.checkTextbox(tbAlterarSobrenome, lbErrorSobrenome);
                errorPanel = false;
            }

            if (panelEstabelecimento.Enabled != false)
            {
                ComponentText.checkTextbox(tbAlterEstabelecimento, lbErrorEstabelecimento);
                errorPanel = false;
            }

            ComponentText.checkTextbox(tbAlteraValor, lbErrorValor);

            if(ComponentText.checkTexts(panel1) == false  && errorPanel == true)
            {
                btnAlterar.Enabled = false;
                return;
            }

            if (debtorsDb.update(this._getDebtor()) > 0)
            {
                file();
                FormListaDevedores formLista = Application.OpenForms["FormListaDevedores"] as FormListaDevedores;
                
                if (formLista != null)
                {
                    formLista._activeAtual();
                }

                btnAlterar.Enabled = true;
                this.Close();
            }
        }

        private void _setDebtor(Debtor debtor)
        {
            Components components = new Components();
            this._id = debtor.id;
            tbAlterNome.Text = debtor.firstname.Trim();
            tbAlterEstabelecimento.Text = debtor.establishment;
            tbAlterarSobrenome.Text = debtor.lastname.Trim();
            mtAlteraDataOperacional.Text = components.converterDateBR(debtor.date_operation.Trim());
            tbAlteraValor.Text = debtor.price.ToString();
            cbAlteraAnoReferencia.Text = debtor.ano_reference.ToString();
            cbAlteraMesReferencia.Text = debtor.mes_reference.ToString();
            cbAlteraStatus.Text = debtor.status.ToString();
            lbName.Text = debtor.file.Trim() != "" ? "Trocar arquivo" : "Novo arquivo";
            cbAlterParc.Text = (debtor.parc + "X");
            this._destFolderDb = debtor.file.Trim();

            if (debtor.establishment != "")
            {
                rbEstabelecimento.Checked = true;
                return;
            }
            rbUsuario.Checked = true;
            rtbAlterDescricao.Text = debtor.description;
        }

        private Debtor _getDebtor()
        {
            Components components = new Components();

            string date = DateTime.Now.ToString().Split(' ')[0].Replace("/", "-");
            string newDate = components.converterDateInt(date);


            Debtor debtor = new Debtor();

               debtor.id = this._id;
               debtor.firstname = tbAlterNome.Text != "" ? tbAlterNome.Text : "";
               debtor.lastname = tbAlterarSobrenome.Text != "" ? tbAlterarSobrenome.Text : "";
               debtor.establishment = tbAlterEstabelecimento.Text;
               debtor.date_operation = mtAlteraDataOperacional.MaskFull ?
                components.converterDateInt(mtAlteraDataOperacional.Text.Replace("/", "-"))
                : newDate;
               debtor.userId = this._userId;
               debtor.price = Components.convertRealInt(tbAlteraValor.Text);

               debtor.ano_reference = cbAlteraAnoReferencia.Text != "" ?
                 Convert.ToInt32(cbAlteraAnoReferencia.Text) :
                 Convert.ToInt32(DateTime.Now.Year);

                debtor.mes_reference = cbAlteraMesReferencia.Text != "" ?
                  Convert.ToInt32(cbAlteraMesReferencia.Text.Split('-')[0]) :
                  Convert.ToInt32(DateTime.Now.Month);

                debtor.parc = Components._charArray(cbAlterParc);

                debtor.updated_at = DateTime.Now;

                debtor.status = cbAlteraStatus.Text != "" ?
                   cbAlteraStatus.Text : debtor.status;
                debtor.file = this._destFile != "" ? this._destFile : this._destFolderDb;
            debtor.description = rtbAlterDescricao.Text;

            return debtor;
        }

       

        private void tbAlteraValor_TextChanged(object sender, EventArgs e)
        {
            ComponentText.converterRealMasked(tbAlteraValor);

        }

        private void tbAlteraValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Components.InDecimal(sender, e);
        }

    

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAlteraMesReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAlteraAnoReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAlteraStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void file()
        {
            if(this._destFile != "")
            { 
                string[] file = this._destFolderDb.Replace("\\", "/").Split('/');
                int countFile  = file.Length - 1;

                string destFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ComprovantesDeevedores/{this._userId}/{file[countFile]}");

                if (File.Exists(destFile))
                
                    File.Delete(destFile);

            
                if (!Directory.Exists(this._destFolder))
                {
                    Directory.CreateDirectory(this._destFolder);
                }

                File.Copy(this._sourceFile, this._destFile, true);
            }
        }

        private void ptAlterUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos (*.jpg;*.pdf)|*.jpg;*.pdf|Todos os arquivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFileDialog.FileName;
                    string destFile = Path.Combine(this._destFolder, Path.GetFileName(sourceFile));

                    this._sourceFile = sourceFile;
                    this._destFile = destFile;

                    lbName.Text = "Aquivo anexado";
                    lbName.ForeColor = Color.Green;
                    return;
                }
            }
        }

        private void ptAlterUpload_MouseEnter(object sender, EventArgs e)
        {
            ptAlterUpload.Size = new Size(45,42);
        }

        private void ptAlterUpload_MouseLeave(object sender, EventArgs e)
        {
            ptAlterUpload.Size = new Size(43, 39);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuario.Checked == true)
            {
                tbAlterEstabelecimento.Text = "";
                panelNomeSobrenome.Enabled = true;
                panelEstabelecimento.Enabled = false;
                lbErrorEstabelecimento.Visible = false;   

            }
        }

        private void rbEstabelecimento_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbEstabelecimento.Checked == true)
            {
                tbAlterNome.Text = "";
                tbAlterarSobrenome.Text = "";
                panelEstabelecimento.Enabled = true;
                panelNomeSobrenome.Enabled = false;
                lbErrorNome.Visible = false;
                lbErrorSobrenome.Visible = false;

            }
        }

        private void FormAlterarDevedores_Load(object sender, EventArgs e)
        {

        }
    }
}
