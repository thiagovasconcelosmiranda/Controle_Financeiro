
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Controle_de_financia2.Relatorios
{
    public partial class FormRelatorioContas : Form
    {
        private int _userId;
        private int ano = 0;
        private int mes = 0;

        public FormRelatorioContas(int userId)
        {
            InitializeComponent();
            this._userId = userId;
            int ano = Convert.ToInt32(DateTime.Now.Year);
            int mes = Convert.ToInt32(DateTime.Now.Month);

            this.ano = ano;
            this.mes = mes;

            this. _getFluxoContas(mes, ano);
        }

       
        private void _getFluxoContas(int mes, int ano)
        {

            FluxoContaDb fluxoConta = new FluxoContaDb();

            DataTable dt = fluxoConta.getRelatorioFluxoContaMensal(
                this._userId, ano, mes);

            reportViewerMensal.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            reportViewerMensal.LocalReport.DataSources.Add(rds);

            reportViewerMensal.RefreshReport();
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._getFluxoContas(Convert.ToInt32(cbMes.Text), this.ano);
            reportViewerMensal.RefreshReport();
        }

       
        private void cbMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._getFluxoContas(this.mes, Convert.ToInt32(cbAno.Text));
            reportViewerMensal.RefreshReport();
        }

        private void FormRelatorioContas_Load(object sender, EventArgs e)
        {

        }

        private void reportViewerMensal_Load(object sender, EventArgs e)
        {

        }
    }
}
