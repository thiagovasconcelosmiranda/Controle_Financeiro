using Controle_de_financia2.Relatorios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Controle_de_financia2
{
    public partial class FormMain : Form
    {
        Thread nt;
        private int _id;
        private int _userId = 0;
        private decimal _salario;
        private decimal _gastos;

        public FormMain(int id)
        {
            this._id = id;
            

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            this._getSalario(id);
            this._getUser(id);
            this._totalPagar();
            this._formateDate();
            this._viewGrafico();
            this._gerarGraficoGastos();
            this._getCotação("USD-BRL", "DÓLAR");
            this._getDevedores();

        }
  
        private void novaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new formAuthAdicionar(this._userId).ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            new FormListaContas(this._userId, this._id).ShowDialog();
        }  

        private void _getSalario(int id)
        {
            WorkDb workDb = new WorkDb();

            if (id > 0)
            {
                Work work = workDb.getWorkAuthId(id);
                if (work == null) return;
                this._salario = (work.wage / 100m);
                lbSalario.Text = (work.wage / 100m).ToString("C2");
            }
        }

        private void _getUser(int id)
        {
            UserDb userDb = new UserDb();
            User user = (User)userDb.getUserAuthId(id);
            if (user == null)
                return;

            this._userId = user.id;

            lbUserFirthname.Text = user.firstname.ToString();
        }

        public void _totalPagar()
        {
            FluxoContaDb fc = new FluxoContaDb();
            List<FluxoConta> fluxoContas = fc.getFluxoContaAll(
                Convert.ToInt32(DateTime.Now.Year),
                Convert.ToInt32(DateTime.Now.Month),
                this._userId
                );

            decimal sum = 0;
            if (fluxoContas == null) return;

            foreach (FluxoConta f in fluxoContas)
            {
                sum += (f.valor / 100m); 
            }

            
            lbTotalPagar.Text = sum.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            
            decimal sobra = (this._salario - sum);
            this._gastos = sum;

            lbSobra.Text = sobra.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));

            if (sum > this._salario)
            {
                lbTotalPagar.ForeColor = Color.Red;
            }
            else
            {
                lbTotalPagar.ForeColor = Color.Black;
            }
               

            if (sobra < 0)
            {
                lbSobra.ForeColor = Color.Red;
                lbAviso.Visible = true;
            } else
            {
                lbSobra.ForeColor = Color.Green;
                lbAviso.Visible = false;
            }

            decimal porc = Components.calcSalario(this._salario, sum);

            lbPorc.Text = "VOCÊ USOU "+ porc.ToString() + "% DO SALÁRIO";

            lbSalario.Text = this._salario.ToString("C2");

            if (porc >= 100)
                lbPorc.ForeColor = Color.Red;
        }

        private void _formateDate()
        {
            DateTime hoje = DateTime.Today;

            lbDateAtual.Text = hoje.ToString("dd/MM/yyyy");
        }


        private void _getDevedores()
        {
            int mes = Convert.ToInt16(DateTime.Now.Month);
            int ano = Convert.ToInt16(DateTime.Now.Year);

            DebtorsDb debtorsDb = new DebtorsDb();
            decimal valorNotPago = debtorsDb.getDbtorsStatusValor(mes, ano, "não pago", this._userId);
            decimal valorPago = debtorsDb.getDbtorsStatusValor(mes, ano, "pago", this._userId);
            decimal convertValorPago = (valorPago / 100m);
            decimal convertValorNaoPago = (valorNotPago / 100m);

            lbDevedoresPago.Text = convertValorPago.ToString("C2");
            lbDevedoresNaoPago.Text = convertValorNaoPago.ToString("C2");

            this._graficoViewDevedores(convertValorNaoPago, convertValorPago);
        }

        private void toolStripAlterarConta_Click(object sender, EventArgs e)
        {
            new FormAlterarUsuario(this._id, this._userId).ShowDialog();
        }

        private void _gerarGraficoColunas(List<string> items)
        {
            Title title = new Title();
          
            title.Font = new Font("ARIAL", 14, FontStyle.Bold);
            title.ForeColor = Color.Brown;
           

            if (!chartGastoSalario.Series.IsUniqueName("contas"))
                chartGastoSalario.Series.Remove(chartGastoSalario.Series["contas"]);
            
            chartGastoSalario.Series.Add("contas");

            chartGastoSalario.Legends.Clear();
            chartGastoSalario.Legends.Add(new Legend("LegendaPrincipal"));

            chartGastoSalario.Series["contas"].ChartType =
                 System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
      
            foreach (string group in items)
            {
                string[] item =  group.Split('|');
         
                double valor = Double.Parse(item[1]);

                chartGastoSalario.Series["contas"].BorderWidth = 4;
                chartGastoSalario.Series["contas"].Points.AddXY(item[0], valor);

            }
        }

        private void _gerarGraficoGastos()
        {
            ComponentText.gerarGrafico(ChartGastos, this._gastos, this._salario, "Despesas", "Salário", "Gastos");

        }

        private void _graficoViewDevedores(decimal valor1, decimal valor2)
            
        {
            ComponentText.gerarGrafico(chart1, valor1, valor2, "Credito", "Não pago", "Pago");

        }
        public void btnAtualizar_Click(object sender, EventArgs e)
        {
            this._atualizar();
        }

        public void _atualizar()
        {
            this._viewGrafico();
            this._getSalario(this._id);
            this._getUser(this._id);
            this._totalPagar();
            this._formateDate();
            this._viewGrafico();
            this._getDevedores();
        }
        private void rbMes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMes.Checked == true)
                _viewGrafico(); 
        }

        private void _viewGrafico()
        {
            FluxoContaDb fc = new FluxoContaDb();

            string[] mes = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho",
                "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            List<String> items = new List<String>();


            for (int i = 0; i <= 11; i++)
            {
                
                decimal valor = fc.GetSomaFluxoContasMes(i, this._userId);
                string newTable = mes[i] + "|" + valor.ToString();

                items.Add(newTable);
            }

            this._gerarGraficoColunas(items);
        }

       private void _viewGraficoAnual()
        {
            FluxoContaDb fc = new FluxoContaDb();
            string[] ano = { "2024", "2023", "2026", "2027", "2028", "2029" };
            List<String> items = new List<String>();

            for (int i = 1; i < 6; i++)
            {
                decimal valor = fc.GetSomaFluxoContasAno(Convert.ToInt32(ano[i]), this._userId);
                string newTable = ano[i] + "|" + valor.ToString();
                items.Add(newTable);
            }
            this._gerarGraficoColunas(items);
        }


        private void rbAno_CheckedChanged(object sender, EventArgs e)
        {
            _viewGraficoAnual();
            
        }

        private void contaMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRelatorioContas(this._userId).ShowDialog();
            ;
        }

        private void atalhoConsultar_Click(object sender, EventArgs e)
        {
            new FormListaContas(this._userId, this._id).ShowDialog();
        }

        private void consultarRelatorio_Click(object sender, EventArgs e)
        {
            new FormRelatorioContas(this._userId).ShowDialog();
        }

        private void atalhoNovoUsuario_Click(object sender, EventArgs e)
        {
            new formAuthAdicionar(this._userId).ShowDialog();
        }

        private void atalhoConsultar_MouseEnter(object sender, EventArgs e)
        {
            atalhoConsultar.Size = new Size(50, 50);
        }

        private void atalhoConsultar_MouseLeave(object sender, EventArgs e)
        {
            atalhoConsultar.Size = new Size(46, 41);
        }

        private void consultarRelatorio_MouseEnter(object sender, EventArgs e)
        {
            consultarRelatorio.Size = new Size(50, 50);
        }

        private void consultarRelatorio_MouseLeave(object sender, EventArgs e)
        {
            consultarRelatorio.Size = new Size(46, 41);
        }

        private void atalhoNovoUsuario_MouseEnter(object sender, EventArgs e)
        {
            atalhoNovoUsuario.Size = new Size(50, 50);
        }

        private void atalhoNovoUsuario_MouseLeave(object sender, EventArgs e)
        {
            atalhoNovoUsuario.Size = new Size(46, 41);
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
              "Tem certeza que deseja sair?",
              "Confirmar saída",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
             );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void toolStripNovoDedor_Click(object sender, EventArgs e)
        {
            new FormAdicionarDevedores(this._userId).ShowDialog();
        }

        private void toolStripConsultar_Click(object sender, EventArgs e)
        {
            new FormListaDevedores(this._userId).ShowDialog();
        }

        private async void _getCotação(string cotacao, string moeda)
        {
            CotacaoApi api = new CotacaoApi();
            Cotacao c = await api.getMoedaAsunc(cotacao);
            if (c == null)
            {
                lbCotacaoMoeda.Visible = false;
                return;
            }

            lbCotacaoMoeda.Text = $"COTAÇÃO DO {moeda} - R$ {c.cotacao}";
            lbCotacaoMoeda.ForeColor = Color.Black;
        }

        private void devedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormRelatorioDevedores(this._userId).ShowDialog();
        }

        private void picListaDevedores_Click(object sender, EventArgs e)
        {
            new FormListaDevedores(this._userId).ShowDialog();
        }

        private void picListaContas_Click(object sender, EventArgs e)
        {
           new FormListaContas(this._userId, this._id).ShowDialog();
        }

        private void cbCotacao_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string cotacao = "";
            string moeda = "";

            switch (cbCotacao.Text) 
            {
                
                case "DÓLAR":
                    cotacao = "USD-BRL";
                    moeda = cbCotacao.Text;
                    break;

                case "EURO":
                    cotacao = "EUR-BRL";
                    moeda = cbCotacao.Text;
                    break;
            }

            this._getCotação(cotacao, moeda);
        }

        private void cbCotacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void picListaDevedores_MouseLeave(object sender, EventArgs e)
        {
            picListaDevedores.Size = new Size(48, 50);
        }

        private void picListaDevedores_MouseEnter(object sender, EventArgs e)
        {
            picListaDevedores.Size = new Size(51, 53);
        }

        private void picListaContas_MouseEnter(object sender, EventArgs e)
        {
            picListaContas.Size = new Size(51, 53);
        }

        private void picListaContas_MouseLeave(object sender, EventArgs e)
        {
            picListaContas.Size = new Size(48, 50);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            User user =  new UserDb().getUserAuthId(this._id);
       
            string date =  new Components().converterDateInt(user.birst.Replace("/", "-").ToString().Trim());

            if (Components.verificaAniversario(date))
            new FormAniversario(user.firstname).ShowDialog();
        }
    }
}

