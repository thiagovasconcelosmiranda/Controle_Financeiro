using System;
using System.IO;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class formAuthAdicionar : Form
    {
        private int _userId;
        private string _destFolder = "";
        private string _sourceFile = "";
        private string _destFile ="";

        public formAuthAdicionar(int userId)
        {
            

            InitializeComponent();
            this._destFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ComprovantesContas/{userId}");
            this._userId = userId;
            this.AcceptButton = btnAdicionar;
        }

        private FluxoConta GetFluxoConta()
        { 
            Components components = new Components();
            FluxoConta fluxoConta = new FluxoConta();


            string date = DateTime.Now.ToString().Split(' ')[0].Replace("/","-");
            string newDate = components.converterDateInt(date);

            fluxoConta.estabelecimento = tbAddEstabelecimento.Text;
            fluxoConta.tipo_conta = cbAddTipoConta.Text;
            fluxoConta.data_venc = mtAddDataVenc.MaskFull
                ? components.converterDateInt(mtAddDataVenc.Text.Replace("/", "-")) :
              newDate ;
  
            fluxoConta.valor = Components.convertRealInt(tbAddValor.Text);
            fluxoConta.userId = this._userId;
            fluxoConta.status = "not pago";

            fluxoConta.ano_reference = string.IsNullOrWhiteSpace(cbAddYearReference.Text) ? 
                Convert.ToInt32(DateTime.Now.Year)
                : Convert.ToInt32(cbAddYearReference.Text);

            fluxoConta.mes_reference = string.IsNullOrWhiteSpace(cbAddMonthReference.Text) ?
                Convert.ToInt32(DateTime.Now.Month)
                : Convert.ToInt32(cbAddMonthReference.Text.Split('-')[0]);
            fluxoConta.created_at = DateTime.Now;
            fluxoConta.updated_at = DateTime.Now;
            fluxoConta.file = this._sourceFile !="" ? this._sourceFile : "";
            fluxoConta.parc = !string.IsNullOrWhiteSpace(cbParcela.Text) ?
                Components._charArray(cbParcela) : 1;
            fluxoConta.description = rtbAddDescricao.Text != "" ?
                rtbAddDescricao.Text : "";

            return fluxoConta;
        }

        private void reset()
        {
            tbAddEstabelecimento.Text = "";
            cbAddTipoConta.Text = "";
            tbAddValor.Text = "";
            mtAddDataVenc.Text = "";
            cbAddMonthReference.Text = "";
            cbAddYearReference.Text = "";
            rtbAddDescricao.Text = "";
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAddValor_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbAddValor.Text, out decimal valor)) 
                tbAddValor.Text = string.Format("{0:N2}", valor);  
        }

        private void tbAddValor_TextChanged(object sender, EventArgs e)
        {
            ComponentText.converterRealMasked(tbAddValor);
        }

        private void cbAddTipoConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void btnVoltar2_Click_1(object sender, EventArgs e)
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

        private void tbAddValor_TextChanged_1(object sender, EventArgs e)
        {
            ComponentText.converterRealMasked(tbAddValor);
        }

        private void tbAddValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Components.InDecimal(sender, e);
        }

        private void btnVoltar2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createFile(int id)
        {
            if (this._sourceFile == "" || this._destFolder == "" || this._destFile =="")
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
                new FormAlertMessage($" Erro {e.Message}", false).ShowDialog();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           
            btnAdicionar.Enabled = false;
           
            ComponentText.checkTextbox(tbAddEstabelecimento, lbErrorEstabelecimento);
            ComponentText.chechComboBox(cbAddTipoConta, lbErrorConta);
            ComponentText.checkTextbox(tbAddValor, lbErrorValorDevedor);


            if (ComponentText.checkTexts(panel1) == false)
            {
                btnAdicionar.Enabled = true;
                return;
            }


            FluxoContaDb fluxoContaDb = new FluxoContaDb();
            
           int result = fluxoContaDb.adicionar(GetFluxoConta());

           if (result > 0)
           {
                new FormAlertMessage("Adicionado com sucesso!", true).ShowDialog();
                btnAdicionar.Enabled = true;
                this.createFile(result);

                FormListaContas listaContas = Application.OpenForms["FormListaContas"] as FormListaContas;
                if (listaContas != null)
                    listaContas._atualizar();
                
                reset();
               return;
           }
          
            new FormAlertMessage("Error: não adicionado!", false).ShowDialog();
            btnAdicionar.Enabled = true;
          
        }

        private void cbAddTipoConta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAddMonthReference_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAddYearReference_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void pbDescricaoConta_Click(object sender, EventArgs e)
        {
            new FormModalDescricaoProduto().ShowDialog();
        }
    }
}
