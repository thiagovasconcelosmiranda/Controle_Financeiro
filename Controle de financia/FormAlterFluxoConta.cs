using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormAlterFluxoConta : Form
    {
        FluxoConta fluxo;
        string status;
        private int _id;
        private int _userId;
        private string _destFolder = "";
        private string _sourceFile = "";
        private string _destFile = "";
        private string _destFolderDb = "";
        public event EventHandler DadosAtulizados;
         


        public FormAlterFluxoConta(FluxoConta f, int userId)
        {
            InitializeComponent();
            setFluxoConta(f);
            this._id = f.id;
            this._userId = userId;
            this.status = f.status;
            this._destFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ComprovantesContas/{userId}");
            
        }

        private void setFluxoConta(FluxoConta f)
        {
            Components components = new Components();

            tbAlterEstabelecimento.Text = f.estabelecimento.ToString().Trim();
            cbAlterTipoConta.Text = f.tipo_conta.ToString();
            mtAlterDataVenc.Text = components.converterDateBR(f.data_venc.Trim()).Replace("/","-");
            tbAlterValor.Text = f.valor.ToString();
            cbAlterYearReference.Text = f.ano_reference.ToString();
            cbAlterMonthReference.Text = alterString(f.mes_reference);
            cbStatus.Text = f.status;
            cbAlterParc.Text = (f.parc+ "X");
            this._destFolderDb = f.file.Trim();
            lbName.Text = this._destFolderDb.Trim() != "" ?
                "Trocar arquivo" : "Novo arquivo";
            rtbAlterDescricao.Text = f.description.Trim();
        }

        private string alterString(int numero)
        {
            if (numero <= 0) return "";

            String[] mes = {"","1-Janeiro", "2-Fevereiro", "3-Março",
                "4-Abril", "5-Maio", "6-Junho", "7-Julho", "8-Agosto","9-Setembro",
                "10-Outubro", "11-Novembro", "12-Deembro"};

            return mes[numero];
        }

        private FluxoConta getFluxoConta()
        {

            Components components = new Components();
     
            string date = DateTime.Now.ToString().Split(' ')[0].Replace("/", "-");
            string newDate = components.converterDateInt(date);
            int valor = Convert.ToInt32(tbAlterValor.Text.Split(' ')[1].Replace(",",""));
            
            FluxoConta fluxo = new FluxoConta();

            fluxo.id = this._id;
            fluxo.estabelecimento = tbAlterEstabelecimento.Text;
            fluxo.tipo_conta = cbAlterTipoConta.Text;
            fluxo.data_venc = mtAlterDataVenc.MaskFull ? 
                components.converterDateInt(mtAlterDataVenc.Text.Replace("/", "-").Trim())
                : newDate;
            fluxo.valor = valor;
            fluxo.ano_reference = Convert.ToInt32(cbAlterYearReference.Text);
            fluxo.mes_reference = Convert.ToInt32(cbAlterMonthReference.Text.Split('-')[0]);
            fluxo.status = cbStatus.Text != "" ? cbStatus.Text.Trim() :  this.status;
            fluxo.parc = this._charArray(cbAlterParc); 
            fluxo.file = this._destFile.Trim() != "" ? this._destFile.Trim() : this._destFolderDb;
            fluxo.description = rtbAlterDescricao.Text != "" ?
               rtbAlterDescricao.Text : "";
            return fluxo;
        }

        public int _charArray(ComboBox c)
        {
            if (!string.IsNullOrWhiteSpace(c.Text))
            {
              
                return Convert.ToInt32(c.Text.Split('X')[0]);

            }
            return 0;
        }

        private void tbAlterValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Components.InDecimal(sender, e);
        }

        private void tbAlterValor_TextChanged(object sender, EventArgs e)
        {
            ComponentText.converterRealMasked(tbAlterValor);
        }


        private void cbAlterMonthReference_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void cbAlterYearReference_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAlterTipoConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void tbAlterValor_TextChanged_1(object sender, EventArgs e)
        {
            ComponentText.converterRealMasked(tbAlterValor);
        }

        private void tbAlterValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Components.InDecimal(sender, e);
        }

        private void btnVoltar2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;

            ComponentText.checkTextbox(tbAlterEstabelecimento, lbErrorEstabelecimento);
            ComponentText.chechComboBox(cbAlterTipoConta, lbErrorConta);
            ComponentText.checkTextbox(tbAlterValor, lbErrorValor);

            if (ComponentText.checkTexts(panel1) == false)
            {
                btnAlterar.Enabled = true;
                return;
            }

            FluxoContaDb fluxoContaDb = new FluxoContaDb();

            int result = fluxoContaDb.update(getFluxoConta());

            if (result > 0)
            {
                new FormAlertMessage("Alterado com sucesso!", true).ShowDialog();
                FormListaContas formLista = new FormListaContas(this._userId, 0);
                this._atualizaForm();
                this.file();
                this.Close();

                return;
            }

            MessageBox.Show("Erro ao alterar");
            new FormAlertMessage("Erro ao alterar!", false).ShowDialog();

            btnAlterar.Enabled = true;
        }

        private void _atualizaForm()
        {
            FormListaContas listaContas = Application.OpenForms["FormListaContas"] as FormListaContas;

            if (listaContas != null)
            {
                listaContas._atualizar();
            }
        }

        private void cbAlterTipoConta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAlterMonthReference_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAlterYearReference_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       

        private void file()
        {

            if (this._destFile.Trim() != "")
            {
                string[]  file = this._destFolderDb.Trim().Replace("\\", "/").Split('/');

                int countFile = file.Length -1;

                string destFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ComprovantesContas/{this._userId}/{file[countFile]}");

                if (File.Exists(destFile))
                    File.Delete(destFile);

                if (!Directory.Exists(this._destFolder))
                    Directory.CreateDirectory(this._destFolder);

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
            ptAlterUpload.Size = new Size(38, 38);
        }

        private void ptAlterUpload_MouseLeave(object sender, EventArgs e)
        {
            ptAlterUpload.Size = new Size(36, 36);
        }

        private void pbAlterDescricaoConta_Click(object sender, EventArgs e)
        {
           new FormModalDescricaoProduto().ShowDialog();
        }
    }
}
