using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Controle_de_financia2
{
    public partial class FormListaDevedores : Form
    {
        private int _userId;
        private int ano = 0;
        private int mes = 0;
        public FormListaDevedores(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            this._gerarGrade();
            this._activeAtual();
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain formMain = Application.OpenForms["FormMain"] as FormMain;
            if (formMain != null) {
                formMain._atualizar();
            }
        }

        public void _activeAtual()
        {
            this._popularGrade("", this.ano, this.mes, false);
            rbAtual.Checked = true;
            cbAno.Text = "";
            cbMes.Text = "";
            tbSearch.Text = "";
        }

        private void _gerarGrade()
        {
            listView1.Columns.Add("ID", 130).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("NOME", 200);
            listView1.Columns.Add("ESTABELECIEMNTO", 300);
            listView1.Columns.Add("CPF", 150).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("CNPJ", 150).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("DATA VENC", 150).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("VALOR", 120).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("STATUS", 150).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("MÊS REFERÊNCIA", 100).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("ANO REFERÊNCIA", 100).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("PARCELA TOTAL",300).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("ARQUIVO", 250).TextAlign = HorizontalAlignment.Right;
            listView1.Columns.Add("DESCRIÇÃO", 600).TextAlign = HorizontalAlignment.Right;

            listView1.View = View.Details;

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.MultiSelect = false;

            listView1.SmallImageList = imageList1;
        }

        private void _popularGrade(string search, int ano, int mes, bool status)
        {
            decimal sum = 0;
            Components components = new Components();

            int newAno = ano > 0 ? ano : Convert.ToInt32(DateTime.Now.Year);
            int newMes = mes > 0 ? mes : Convert.ToInt32(DateTime.Now.Month);
            
            DebtorsDb dv = new DebtorsDb();
            
            List<Debtor> debtors = status == false ?
                dv.getSearchDbtors(search, newAno, newMes, this._userId) :
                dv.getSearchDebtorStatusPagos(search, newAno, 
                newMes, this._userId);

            listView1.Items.Clear();

            if (debtors == null) return;

            
            if (debtors == null)
            {
                lbSomar.Text = "R$ 0,00";
                lbListViewTotalNaoPago.Text = "R$ 0,00";
                lbSomar.ForeColor = Color.Black;
                lbListViewTotalNaoPago.ForeColor = Color.Black;
                return;
            }
            
            foreach (Debtor d in debtors)
            {
                string nome = d.firstname + " " + d.lastname;
                int cor = verifyStatus(d.status.Trim());

                string valor = (d.price / 100m).ToString().Replace(".", ",");

                sum += Decimal.Parse(valor);
              
                listView1.Items.Add(new ListViewItem(
                 new string[] {
                     d.id.ToString(),
                     nome,
                     d.establishment,
                     d.cpf,
                     d.cnpj,
                     components.converterDateBR(d.date_operation.Trim()),
                     Convert.ToDecimal(valor).ToString("C2", CultureInfo.GetCultureInfo("pt-BR")),
                     d.status,
                     d.mes_reference.ToString(),
                     d.ano_reference.ToString(),
                     d.parc.ToString(),
                     d.file,
                     d.description.ToString()

            }, cor));
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listView1.Items[i].BackColor = Color.WhiteSmoke;
                }
                else
                {
                    listView1.Items[i].BackColor = Color.PowderBlue;
                }

            }
            this._totalDevedores(sum);
        }


        private void _totalDevedores(decimal sum)
        {
            int mes = Convert.ToInt32(DateTime.Now.Month);
            int ano = Convert.ToInt32(DateTime.Now.Year);

            lbSomar.Text = sum.ToString("C2");

            DebtorsDb debtorsDb = new DebtorsDb();

            decimal priceNotPago = debtorsDb.getDbtorsStatusValor(mes, ano, "não pago", this._userId);
            decimal pricePago = debtorsDb.getDbtorsStatusValor(mes, ano, "pago", this._userId);

            lbListViewTotalNaoPago.Text = (priceNotPago /100m).ToString("C2");
            lbViewsPago.Text = (pricePago / 100m).ToString("C2");

            this._gererGrafico(priceNotPago, pricePago);

        }

        private int verifyStatus(string status)
        {
           return status == "não pago" ? 1 : 0;
        }

        private void _gererGrafico(decimal priceNotPago, decimal pricePago)
        {
            ComponentText.gerarGrafico(chart1, (priceNotPago /100m), (pricePago/100m), "Pagamentos", "Pago", "Não pago");
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 1) return;

            ListViewItem item = listView1.SelectedItems[0];
            int id = Convert.ToInt32(item.SubItems[0].Text);
            new FormAlterarDevedores(id, this._userId).ShowDialog();
        }

        private void btTransferirConta_Click(object sender, EventArgs e)
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
                new FormAlertMessage("Erro: Selecione os items\"", false).ShowDialog();
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Transferir o Devedor para o proximo mês?",
                "Confirmar saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Checked == true)
                    {
                        DebtorsDb debtorsDb = new DebtorsDb();

                        if (debtorsDb.adicionar(getDebtor(Convert.ToInt32(item.SubItems[0].Text))) > 0)
                        {
                            new FormAlertMessage("Debitos transferido no proximo mês!", true).ShowDialog();
                        }

                    }           
                }
            }
        }
        private void deleteFile(string file)
        {
            if (file.Trim() != "")
            { 
                string filename = file.Replace("\\", "/").Split('/')[4];
                string destFolderFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"ComprovantesDeevedor/{this._userId}/{filename}");
                
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

            DialogResult resultado = MessageBox.Show(
              "Tem certeza que deseja excluÍr o devedor?",
              "Confirmar saída",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
   );

            if (resultado == DialogResult.Yes)
            {

                DebtorsDb debtorsDb = new DebtorsDb();

                foreach (ListViewItem item in listView1.Items)
                    if (item.Checked == true)
                    {
                        deleteFile(item.SubItems[11].Text);
                        
                        if (debtorsDb.excluir(Convert.ToInt32(item.SubItems[0].Text), this._userId) > 0)
                            this._activeAtual();  
                    }      
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this._popularGrade(tbSearch.Text, 0, 0, false);
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._popularGrade("", this.ano, Convert.ToInt32(cbMes.Text.Split('-')[0]), false);
        }

        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ano = Convert.ToInt32(cbAno.Text);
            this._popularGrade("", Convert.ToInt32(cbAno.Text),
                this.mes, false);
        }

        private void rbPagos_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPagos.Checked == true)
            {
                this._popularGrade("pago", this.ano, this.mes, true);
            }
        
        }

        private void rbNaoPagos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNaoPagos.Checked == true)
            {
                this._popularGrade("não pago", this.ano, this.mes, true);
            }  
        }

        private void rbAtual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAtual.Checked == true)
            {
                this._popularGrade("", this.ano, this.mes, false);
            } 
        }


        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                btAlterar.Enabled = true;
                ListViewItem item = listView1.SelectedItems[0];
               
                if(item.SubItems[11].Text.Length > 0){
                    pbAbrir.Visible = true;
                }
                return;
            }
           
            btAlterar.Enabled = false;
            pbAbrir.Visible = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this._activeAtual();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Debtor getDebtor(int id)
        {
            Components components = new Components();
            DebtorsDb debtorsDb = new DebtorsDb();
            Debtor db = debtorsDb.GetDebtorId(id, this._userId);
            int mes = Convert.ToInt32(db.date_operation.Split('-')[1]);
            int dia = Convert.ToInt32(db.date_operation.Split('-')[2]);
            int newMes = (db.mes_reference + 1);


            Debtor debtor = new Debtor()
            {
                firstname = db.firstname.Trim(),
                lastname = db.lastname.Trim(),
                price = db.price,
                userId = db.userId,
                cpf = db.cpf,
                cnpj = db.cnpj,
                ano_reference = db.ano_reference,
                mes_reference = newMes,
                date_operation = components.acrecentaDiaMes(db.ano_reference, mes, dia),
                status = "não pago",
                created_at = db.created_at,
                updated_at = db.updated_at,
                parc = db.parc,
                file = db.file,
                establishment = db.establishment,
                description = db.description   
            };
            return debtor;
        }

    
        private Debtor _getDebtorListView(ListViewItem item)
        {
            DebtorsDb debtorsDb = new DebtorsDb();
            Debtor db = debtorsDb.GetDebtorId(Convert.ToInt32(item.SubItems[0].Text), this._userId);
            Debtor debtor = new Debtor()
            {
                id = db.id,
                firstname = db.firstname,
                establishment = db.establishment,
                lastname = db.lastname,
                price = db.price,
                userId = db.userId,
                ano_reference = db.ano_reference,
                mes_reference = db.mes_reference,
                date_operation = db.date_operation,
                status = "pago",
                updated_at = db.updated_at,
                parc = db.parc,
                file = db.file, 
                description = db.description
            };

            return debtor;        
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.Items.Count < 0) return;

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
                    DebtorsDb debtorsDb = new DebtorsDb();
                    ListViewItem item = listView1.SelectedItems[0];
                   
                    if(debtorsDb.update(_getDebtorListView(item)) > 0)
                    {
                        new FormAlertMessage("Devedor pago o débito!", true).ShowDialog();
                        this._activeAtual();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new FormAdicionarDevedores(this._userId).ShowDialog();
        }

        private void cbVencimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbMes_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(37, 37);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(35, 35);
        }

        private void pbAbrir_Click(object sender, EventArgs e)
        {  
            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string nameFile = item.SubItems[11].Text;

                if (nameFile.Length == 0) return;
                
                Process.Start(new ProcessStartInfo
                {
                    FileName = nameFile,
                    UseShellExecute = true
                });    
            }
        }
    }
}
