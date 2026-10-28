using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Controle_de_financia2.Relatorios
{
    
    public partial class FormRelatorioDevedores : Form
    {
        private int _userId;
        private int ano = 0;
        private int mes = 0;
        public FormRelatorioDevedores(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            int ano = Convert.ToInt32(DateTime.Now.Year);
            int mes = Convert.ToInt32(DateTime.Now.Month);
            this.ano = ano;
            this.mes = mes;

            this._getDebtorRelatorio(ano, mes);
        }

        private void FormRelatorioDevedores_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void _getDebtorRelatorio(int ano,int mes)
        {

            DebtorsDb debtorsDb = new DebtorsDb();

            DataTable dt = debtorsDb.getRelatorioDebtor(
                this._userId, ano, mes);

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._getDebtorRelatorio(this.ano, Convert.ToInt32(cbMes.Text));
        }

        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._getDebtorRelatorio(Convert.ToInt32(cbAno.Text), this.mes);
        }
    }
}
