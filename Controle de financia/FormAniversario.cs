using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_financia2
{
    public partial class FormAniversario : Form
    {
        public FormAniversario(string firstname)
        {
            InitializeComponent();

            if (firstname != "")
            {
                lbNome.Text = $"Hoje é seu grande dia {firstname}";
            }
        }

        private void FormAniversario_Load(object sender, EventArgs e)
        {

        }
    }
}
