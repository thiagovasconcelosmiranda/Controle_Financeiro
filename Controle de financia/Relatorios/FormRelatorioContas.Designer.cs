namespace Controle_de_financia2.Relatorios
{
    partial class FormRelatorioContas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioContas));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.reportViewerMensal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "financa.png");
            // 
            // reportViewerMensal
            // 
            this.reportViewerMensal.LocalReport.ReportEmbeddedResource = "Controle_de_financia2.Relatorios.RelContas.rdlc";
            this.reportViewerMensal.Location = new System.Drawing.Point(-1, 99);
            this.reportViewerMensal.Name = "reportViewerMensal";
            this.reportViewerMensal.ServerReport.BearerToken = null;
            this.reportViewerMensal.Size = new System.Drawing.Size(664, 431);
            this.reportViewerMensal.TabIndex = 7;
            this.reportViewerMensal.Load += new System.EventHandler(this.reportViewerMensal_Load);
            // 
            // cbMes
            // 
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMes.Location = new System.Drawing.Point(18, 43);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(110, 28);
            this.cbMes.TabIndex = 8;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            this.cbMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMes_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(145, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "ANUAL";
            // 
            // cbAno
            // 
            this.cbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cbAno.Location = new System.Drawing.Point(149, 43);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(110, 28);
            this.cbAno.TabIndex = 17;
            this.cbAno.SelectedIndexChanged += new System.EventHandler(this.cbAno_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(14, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "MENSAL:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.ImageKey = "financa.png";
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(332, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 55);
            this.label7.TabIndex = 20;
            this.label7.Text = "RELATÓRIO CONTAS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormRelatorioContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.reportViewerMensal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRelatorioContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RELATÓRIO CONTAS";
            this.Load += new System.EventHandler(this.FormRelatorioContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMensal;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}