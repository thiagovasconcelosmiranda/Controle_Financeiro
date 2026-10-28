using System;
using System.IO;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormAdicionarDevedores : Form
    {
        private int _userId;
        private string _destFolder = "";
        private string _sourceFile = "";
        private string _destFile = "";


        public FormAdicionarDevedores(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            this._destFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ComprovantesDeevedores/{userId}");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            bool errorPanel = true;
            int count = 0;

            btnAdicionar.Enabled = false;

            if (panelNomeSobrenome.Enabled != false)
            {
                ComponentText.checkTextbox(tbNome, lbErrorNome);
                ComponentText.checkTextbox(tbSobrenome, lbErrorSobrenome);

                if(!string.IsNullOrWhiteSpace(tbNome.Text) && 
                    !string.IsNullOrWhiteSpace(tbSobrenome.Text))
                    errorPanel = false;
            }

            if (panelEstabelecimento.Enabled != false)
            {
                ComponentText.checkTextbox(tbEstabelecimento, lbErrorEstabelecimento);
                lbErrorNome.Visible = false;
            

                if (!string.IsNullOrWhiteSpace(tbEstabelecimento.Text))
                   errorPanel = false;
            }

            ComponentText.checkMaskedBoxText(mtAddCpf, lbErrorOption);
            ComponentText.checkTextbox(tbAddValor, lbErrorValorDevedor);


            if (!ComponentText.checkTexts(panel1) || errorPanel)
            {
                btnAdicionar.Enabled = true;
                return;
            }



          
            foreach (Control c in panel3.Controls)
            {
                if (c is MaskedTextBox mt && !mt.MaskFull)
                {
                    count++;
                }
            }
             

            if (count > 1)
            {
                btnAdicionar.Enabled = true;
                lbErrorOption.Visible = true;
                return;
            }
            
            btnAdicionar.Enabled = false;
            lbErrorOption.Visible = false;

            DebtorsDb debtorsDb = new DebtorsDb();
            int id = debtorsDb.adicionar(this._getDebtor());

            if (id > 0)
            {
                this.createFile();
                btnAdicionar.Enabled = true;
                new FormAlertMessage("Devedor adicinado com sucesso!", true).ShowDialog();
                FormListaDevedores formLista = Application.OpenForms["FormListaDevedores"] as FormListaDevedores;

                if (formLista != null)
                {
                    formLista._activeAtual();
                }
                this._reset();
            }
          
        }

        private void _reset()
        {
            tbNome.Text = "";
            tbSobrenome.Text = "";
            tbAddValor.Text = "";
            mtAddCpf.Text = "";
            mtAddDataOperacional.Text = "";
            rtbAddDescricao.Text = "";
            tbEstabelecimento.Text = "";
            
        }

        private void tbAddValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Components.InDecimal(sender, e);
        }

        private void tbAddValor_TextChanged(object sender, EventArgs e)
        {
            ComponentText.converterRealMasked(tbAddValor);
        }

        private Debtor _getDebtor()
        {
            Components components = new Components();

            string date = DateTime.Now.ToString().Split(' ')[0].Replace("/", "-");
            string newDate = components.converterDateInt(date);


            Debtor debtor = new Debtor()
            {
                firstname = tbNome.Text != "" ? tbNome.Text : "",
                lastname = tbSobrenome.Text != "" ? tbSobrenome.Text : "",
                establishment = tbEstabelecimento.Text != "" ? tbEstabelecimento.Text : "",
                cpf = mtAddCpf.MaskFull ? mtAddCpf.Text : "",
                cnpj = mtAddCnpj.MaskFull ? mtAddCnpj.Text : "",
                price = Components.convertRealInt(tbAddValor.Text),
                date_operation = mtAddDataOperacional.MaskFull ?
                components.converterDateInt(mtAddDataOperacional.Text.Replace("/", "-"))
                : newDate,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                userId = this._userId,
                status = "não pago",

                mes_reference = cbAddMesReferencia.Text != "" ?
                Convert.ToInt32(cbAddMesReferencia.Text.Split('-')[0]) :
                Convert.ToInt32(DateTime.Now.Month),

                ano_reference = cbAddAnoReferencia.Text != "" ?
                Convert.ToInt32(cbAddAnoReferencia.Text) :
                Convert.ToInt32(DateTime.Now.Year),
               
                parc = cbAddParc.Text != "" ? this._charArray(cbAddParc) : 1,
                description = rtbAddDescricao.Text != "" ? rtbAddDescricao.Text : "",
                file = this._sourceFile != "" ? this._sourceFile : ""
            };
  
            return debtor;
        }

        public int _charArray(ComboBox c)
        {
            if (!string.IsNullOrWhiteSpace(c.Text))
            {

                return Convert.ToInt32(c.Text.Split('X')[0]);

            }
            return 0;
        }


        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbAddMesReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAddAnoReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

      
        private void rbCpf_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbCpf.Checked == true)
            {
                mtAddCnpj.Text = "";
                mtAddCpf.Enabled = true;
                mtAddCnpj.Enabled = false;
                lbErrorOption.Visible = false;
               
            }
           
        }

        private void rbCnpj_CheckedChanged_1(object sender, EventArgs e)
        {
            if(rbCnpj.Checked == true)
            {
                mtAddCpf.Text = "";
                mtAddCpf.Enabled = false; 
                mtAddCnpj.Enabled = true;
                lbErrorOption.Visible = false; 
            }
          
        }

        private void ptAddUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos (*.jpg;*.pdf)|*.jpg;*.pdf|Todos os arquivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFileDialog.FileName;
                    this._destFile = Path.Combine(this._destFolder, Path.GetFileName(sourceFile));
                    this._sourceFile = sourceFile;
                    lbFileOk.Visible = true;
                    return;
                }
                lbFileOk.Visible = false;
            }
        }

        private void createFile()
        {

            if (this._sourceFile == "" || this._destFolder == ""|| this._destFile == "")
                return;

            try
            {
                if (!Directory.Exists(this._destFolder))
                {
                    Directory.CreateDirectory(this._destFolder);
                }
                File.Copy(this._sourceFile, this._destFile, true);
            }
            catch (Exception e)
            {
                new FormAlertMessage($"Erro: {e.Message}", false).ShowDialog();

            }
        }

      
        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            panelNomeSobrenome.Enabled = true;
            panelEstabelecimento.Enabled = false;
            _resetTextBoxes(panelEstabelecimento);
            lbErrorEstabelecimento.Visible = false;
        }

        private void rbEstabeleciemnto_CheckedChanged(object sender, EventArgs e)
        {
            panelNomeSobrenome.Enabled = false;
            panelEstabelecimento.Enabled = true;
            _resetTextBoxes(panelNomeSobrenome);
            lbErrorNome.Visible = false;
            lbErrorSobrenome.Visible = false;
        }

        private void _resetTextBoxes(Panel panel)
        {
            foreach(Control control in panel.Controls)
            {
                if (control is TextBox tb)
                    tb.Text= "";
                
            }
        }
    }
}
