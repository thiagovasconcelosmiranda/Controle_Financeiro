using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Controle_de_financia2
{

    public partial class FormListaContas : Form
    {
        Thread nt;
        private int _userId;
        private decimal _salario;
        private decimal sum;
        private int ano = 0;
        private int mes = 0;


        public FormListaContas(int userId, int authId)
        {
            this._salario = _getSalario(authId);
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;

            this._userId = userId;

            this._gerarGrade();
            this._popularGrade("", this.ano, this.mes, false);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void _gerarGrade()
        {
            listView1.Columns.Add("ID", 130).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("ESTABELECIMENTO", 250);
            listView1.Columns.Add("TIPO CONTA", 200).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("DATA VENC", 100).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("VALOR", 90).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("STATUS", 150).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("MÊS REFERÊNCIA", 100).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("ANO REFERÊNCIA", 100).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("PARCELA TOTAL", 300).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("ARQUIVO", 250).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("DESCRIÇÃO", 600).TextAlign = HorizontalAlignment.Right;

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;

            listView1.SmallImageList = imageList1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain formMain = Application.OpenForms["FormMain"] as FormMain;
            if (formMain != null)
                formMain._atualizar();
        }


        private void _popularGrade(string search, int ano, int mes, bool status)
        {

            int newAno = ano > 0 ? ano : Convert.ToInt32(DateTime.Now.Year);
            int newMes = mes > 0 ? mes : Convert.ToInt32(DateTime.Now.Month);
            Components components = new Components();

            FluxoContaDb fc = new FluxoContaDb();

            List<FluxoConta> fluxoContas = status == false ?
                fc.getSearchFluxoConta(search, newAno, newMes, this._userId) :
                fc.getSearchFluxoContaStatusPagos(search, newAno,
                newMes, this._userId);

            listView1.Items.Clear();

            if (fluxoContas == null)
            {
                lbSomar.Text = "R$ 0,00";
                lbListViewSobra.Text = "R$ 0,00";
                lbSomar.ForeColor = Color.Black;
                lbListViewSobra.ForeColor = Color.Black;
                lbAviso.Visible = false;

                return;
            }
            this.sum = 0;

            foreach (FluxoConta f in fluxoContas)
            {

                int cor = verifyStatus(f.status.Trim());

                string valor = (f.valor / 100m).ToString().Replace(".", ",");


                listView1.Items.Add(new ListViewItem(
                 new string[] {
                     f.id.ToString(),
                     f.estabelecimento,
                     f.tipo_conta.ToString(),
                     components.converterDateBR(f.data_venc.Trim()),
                     Convert.ToDecimal(valor).ToString("C2", CultureInfo.GetCultureInfo("pt-BR")),
                     f.status,
                     f.mes_reference.ToString(),
                     f.ano_reference.ToString(),
                     f.parc.ToString(),
                     f.file,
                     f.description

            }, cor));

                this._totalPagar(f.valor);

            }

            for (int i = 0; i < listView1.Items.Count; i++) {
                if (i % 2 == 0) {
                    listView1.Items[i].BackColor = Color.WhiteSmoke;
                }
                else
                {
                    listView1.Items[i].BackColor = Color.PowderBlue;
                }

            }

        }
        private int verifyStatus(string status)
        {

            if (status == "não pago")
            {
                return 0;
            }
            return 1;

        }
        private FluxoConta _getLisView(string statsPago, int id)
        {
            Components components = new Components();

            FluxoContaDb fluxoContaDb = new FluxoContaDb();

            FluxoConta conta = fluxoContaDb.GetFluxoContaId(id, this._userId);

            FluxoConta fluxo = new FluxoConta()
            {
                id = conta.id,
                estabelecimento = conta.estabelecimento,
                tipo_conta = conta.tipo_conta,
                data_venc = conta.data_venc,
                status = statsPago == "pago" ? "pago" : conta.status,
                ano_reference = conta.ano_reference,
                valor = conta.valor,
                mes_reference = conta.mes_reference,
                created_at = conta.created_at,
                updated_at = conta.updated_at,
                file = conta.file,
                description = conta.description
            };

            return fluxo;
        }

        private void _totalPagar(int valor)
        {
            sum += (valor / 100m);

            lbSomar.Text = sum.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));

            decimal sobra = (this._salario - sum);
            lbListViewSobra.Text = sobra.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));


            if (sobra < 0) {
                lbAviso.Visible = true;
                lbListViewSobra.ForeColor = Color.Red;
                return;
            }
            lbAviso.Visible = false;
            lbListViewSobra.ForeColor = Color.Green;

            decimal porc = Components.calcSalario(this._salario, sum);

            lbSalario.Text = this._salario.ToString("C2");
        }

        private decimal _getSalario(int id)
        {

            WorkDb workDb = new WorkDb();


            Work work = workDb.getWorkAuthId(id);
            if (work == null)
                return 0;

            if (work.id == 0)
                return 0;

            decimal newWork = (work.wage / 100m);

            return newWork;

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1) return;
            ListViewItem item = listView1.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[0].Text);

            FormAlterFluxoConta f = new FormAlterFluxoConta(this._getLisView("not pago", id), this._userId);
            f.Show();

        }

        private FluxoConta getConta(int id) {

            Components components = new Components();

            FluxoContaDb fluxoContaDb = new FluxoContaDb();
            FluxoConta db = fluxoContaDb.GetFluxoContaId(id, this._userId);

            int ano = Convert.ToInt32(db.data_venc.Split('-')[0]);
            int mes = Convert.ToInt32(db.data_venc.Split('-')[1]);
            int dia = Convert.ToInt32(db.data_venc.Split('-')[2]);


            FluxoConta fluxoConta = new FluxoConta()
            {
                estabelecimento = db.estabelecimento.Trim(),
                tipo_conta = db.tipo_conta,
                data_venc = components.acrecentaDiaMes(ano, mes, dia),
                status = "not pago",
                ano_reference = ano,
                mes_reference = mes + 1,
                valor = db.valor,
                userId = this._userId,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                file = db.file,
                description = db.description
            };

            return fluxoConta;

        }


        private void cbTodos_CheckedChanged(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView1.Items)
            {
                if (ckboxTodos.Checked)
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }
            }
        }
        private void _resetItens()
        {
            cbAno.Text = "";
            cbMes.Text = "";
            rbAtual.Checked = true;
            rbPagos.Checked = false;
            ckboxTodos.Checked = false;
            rbNaoPagos.Checked = false;
        }

        private void cbAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void ckboxTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (ckboxTodos.Checked)
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }
            }
        }

        private void rbPagos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPagos.Checked == true)
            {
                this._popularGrade("pago", this.ano, this.mes, true);
                cbMes.Text = "";
                cbAno.Text = "";
                return;
            }

        }

        private void rbAtual_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbAtual.Checked == true)
            {
                this._popularGrade("", this.ano, this.mes, false);
                cbMes.Text = "";
                cbAno.Text = "";
                return;
            }
        }

        private void rbNaoPagos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNaoPagos.Checked == true)
            {
                this._popularGrade("não pago", this.ano, this.mes, true);
                cbMes.Text = "";
                cbAno.Text = "";
                return;
            }
        }
        private void deleteFile(string file)
        {
            if (file.Trim() != "")
            {

                string filename = file.Replace("\\", "/").Split('/')[5];
                string destFolderFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ComprovantesContas/{this._userId}/{filename}");

                if (File.Exists(destFolderFile))
                {
                    File.Delete(destFolderFile);
                }
            }
        }
        private void btDeletarselecionado_Click(object sender, EventArgs e)
        {
            int count = listView1.Items.Count;
            int num = 0;

            if (count == 0)
            {
                new FormAlertMessage("Erro:Não há item na lista!", false).ShowDialog();
                return;
            }

            foreach (ListViewItem item in listView1.Items)
                if (item.Checked == false)
                    num++;

            if (count == num)
            {
                new FormAlertMessage("Erro: Selecione os items", false).ShowDialog();
                return;
            }

            FluxoContaDb fluxo = new FluxoContaDb();

            DialogResult resultado = MessageBox.Show(
              "Tem certeza que deseja excluír a conta?",
              "Confirmar saída",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
   );

            if (resultado == DialogResult.Yes)
            {
                foreach (ListViewItem item in listView1.Items) {
                    if (item.Checked == true)
                    {
                        string filename = item.SubItems[9].Text;
                        this.deleteFile(filename);
                        fluxo.excluir(Convert.ToInt32(item.SubItems[0].Text));

                    }
                }

                new FormAlertMessage("Deletado com sucesso!", true).ShowDialog();
                this._popularGrade("", 0, 0, false);
                ckboxTodos.Checked = false;
                this._resetItens();


            }
        }

        private void btTransferirConta_Click_1(object sender, EventArgs e)
        {

            int count = listView1.Items.Count;
            int num = 0;

            if (count == 0)
            {
                new FormAlertMessage("Erro: Não há item na lista!", false).ShowDialog();
                return;
            }

            foreach (ListViewItem item in listView1.Items)
                if (item.Checked == false)
                    num++;

            if (count == num)
            {
                new FormAlertMessage("Erro: Selecione os items!", false).ShowDialog();
                return;
            }

            DialogResult resultado = MessageBox.Show(
                 "Transferir a conta para o proximo mês?",
                 "Confirmar saída",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                FluxoContaDb fluxo = new FluxoContaDb();

                foreach (ListViewItem item in listView1.Items)
                {

                    if (item.Checked == true)
                    {
                        int id = Convert.ToInt32(item.SubItems[0].Text);
                        fluxo.adicionar(getConta(id));
                    }
                }
                new FormAlertMessage("Criado com sucesso!", true).ShowDialog();
                this._resetItens();
            }
        }


        private void btAlterar_Click_1(object sender, EventArgs e)
        { 

            if (listView1.Items.Count == 0) return;

            ListViewItem item = listView1.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[0].Text);
            FluxoContaDb fluxoContaDb = new FluxoContaDb();

           FluxoConta fluxoConta = fluxoContaDb.GetFluxoContaId(id, this._userId);

            new FormAlterFluxoConta(fluxoConta, this._userId).ShowDialog();
        }

        private void cbAno_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this._popularGrade("", Convert.ToInt32(cbAno.Text), this.mes, false);

            cbMes.Text = "";
            rbAtual.Checked = false;
            rbNaoPagos.Checked = false;
            rbNaoPagos.Checked = false;
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mesSelect = Convert.ToInt32(cbMes.Text.Split('-')[0]);

            this._popularGrade("", this.ano, mesSelect, false);
            cbAno.Text = "";
            rbAtual.Checked = false;
            rbNaoPagos.Checked = false;
            rbNaoPagos.Checked = false;
        }
 
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult resultado = MessageBox.Show(
                 "Alterar a conta como paga?",
                 "Confirmar saída",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                  );

                if (resultado == DialogResult.Yes)
                {
                    FluxoContaDb fluxoConta = new FluxoContaDb();
                    ListViewItem item = listView1.SelectedItems[0];
                    int id = Convert.ToInt32(item.SubItems[0].Text);
                   
                   
                    if (fluxoConta.update(this._getLisView("pago", id)) > 0)
                    {
                        new FormAlertMessage("Status pago!", true).ShowDialog();
                        this._popularGrade("", this.ano, this.mes, false);

                        this._resetItens();
                        rbAtual.Enabled = true;
                    }
                    
                }
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
               ListViewItem listView = listView1.SelectedItems[0];
                btAlterar.Enabled = true;

               if (listView.SubItems[9].Text.Trim().Length > 0)
               {
                  pbAbrirPdf.Visible = true;
                  return;
               }

               pbAbrirPdf.Visible = false;
            

               btAlterar.Enabled = false;
               pbAbrirPdf.Visible = false;

               bool result = Components.verifyDate(listView.SubItems[3].Text);
               string status = listView.SubItems[5].Text;
               lbStatus.Text = "";
               btAlterar.Enabled = true;

               if (status.Trim() == "não pago")
               {
                    groupBox2.Visible = true;

                    if (result == true)
                    {
                        lbStatus.ForeColor = Color.Green;
                        lbStatus.Text = "Fatura em dia";
                        return;
                    }
                    lbStatus.ForeColor = Color.Red;
                    lbStatus.Text = "Fatura vencida";
                }
            }
               
        }

        public void btnAtualizar_Click(object sender, EventArgs e)
        {
            this._atualizar();
            this._resetItens();
        }

        public void _atualizar() 
        {
            this._popularGrade("", 0, 0, false);
            rbAtual.Checked = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           MessageBox.Show("Fechar");
        }

        private void cbAno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbMes_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new formAuthAdicionar(this._userId).ShowDialog();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(37, 37);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(35, 35);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            this._popularGrade(tbSearch.Text, 0, 0, false);
        }

        private void pbAbrirPdf_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                Process.Start(new ProcessStartInfo
                {
                    FileName = item.SubItems[8].Text.Trim(),
                    UseShellExecute = true
                });
            }
        }

        private void pbAbrirPdf_MouseEnter(object sender, EventArgs e)
        {
            pbAbrirPdf.Size = new Size(50, 57);
        }

        private void pbAbrirPdf_MouseLeave(object sender, EventArgs e)
        {
            pbAbrirPdf.Size = new Size(45, 47);
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
