using System;
using System.IO;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormModalDescricaoProduto : Form
    {
        private string _file;

        public FormModalDescricaoProduto()
        {
            InitializeComponent();
            this._file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "descriptionForm.txt");

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (File.Exists(this._file))
            {

                if (rtbAddDescricao.Text != "")
                {
                    this._reset();
                    File.WriteAllText(this._file, rtbAddDescricao.Text);
                    Close();
                    return;
                }
                this._reset();

            }
        }
        private void _reset()
        {
            File.WriteAllText(this._file, "");
        }
    }
}
