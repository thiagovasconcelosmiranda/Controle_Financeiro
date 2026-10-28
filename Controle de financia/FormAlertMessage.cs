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
    public partial class FormAlertMessage : Form
    {
        public FormAlertMessage(string message, bool status)
        {
            InitializeComponent();

            lbMessage.Text = message;
            if (status)
            {
                pbPositivo.Visible = true;
                lbMessage.Visible = true;
                lbMessage.ForeColor = Color.Green;
                return;
            }
            pbNegativo.Visible = true;
            lbMessage.Visible = true;
            lbMessage.ForeColor = Color.Red;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
