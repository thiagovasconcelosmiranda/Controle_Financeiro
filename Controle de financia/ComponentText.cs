using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Controle_de_financia2
{
    public static class ComponentText
    {
      public static void converterRealMasked(TextBox textBox)
      {
            string valor = textBox.Text.Replace(",", "").Replace(".", "").Replace("R$", "").Trim();
            if (string.IsNullOrEmpty(valor)) return;

            decimal numero = Convert.ToDecimal(valor) / 100;
            textBox.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", numero);
            textBox.SelectionStart = textBox.Text.Length;
        }

        public static void checkTextbox(TextBox textBox, Label label)
        {
           if(textBox.Text == "")
            {
                label.Visible = true;
                return;
            }
            label.Visible = false;
        }

        public static bool checkTexts(Panel panel)
        {
            bool component = true;
            foreach (Control c in panel.Controls)
            {
               
                if (c is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
                {
                    component = false;
                    tb.Focus();
                }

                if (c is ComboBox cb && string.IsNullOrWhiteSpace(cb.Text))
                {
                    component = false;
                    cb.Focus();
                }
                if (c is MaskedTextBox mt && !mt.MaskFull)
                {
                    component = false;
                    mt.Focus();
                }
            }
            return component;
        }

     
        public static void checkMaskedBoxText(MaskedTextBox masked, Label label)
        {
            if (!masked.MaskFull)
            {
                label.Visible = true;
                return;
            }
            label.Visible = false;
        }

        public static void chechComboBox(ComboBox combo, Label label)
        {
            if (combo.Text == "")
            {
                label.Visible = true;
                return;
            }
            label.Visible = false;
        }

        public static void gerarGrafico(Chart chart, decimal valor1, decimal valor2,string name, string typeValor1, string typeValor2)
        {
            if (!chart.Series.IsUniqueName(name))
                chart.Series.Remove(chart.Series[name]);

            chart.Series.Add(name);
            chart.Series[name].Color = Color.Blue;

            chart.Series[0].ChartType =
                    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
              //chart.ChartAreas[0].Area3DStyle.Enable3D = true;
             //chart.ChartAreas[0].Area3DStyle.Inclination = 60;
            //chart.ChartAreas[0].Area3DStyle.Rotation = 60;
           

            chart.Palette = ChartColorPalette.BrightPastel;
            chart.Legends.Clear();
            chart.Legends.Add(new Legend("LegendaPrincipal"));
            chart.Series[0].IsValueShownAsLabel = true;
            chart.Series[0].Points.AddXY(typeValor1, valor2);
            chart.Series[0].Points.AddXY(typeValor2, valor1);
        }

    }
}
