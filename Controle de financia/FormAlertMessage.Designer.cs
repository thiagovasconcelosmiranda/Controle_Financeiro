namespace Controle_de_financia2
{
    partial class FormAlertMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlertMessage));
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.pbNegativo = new System.Windows.Forms.PictureBox();
            this.pbPositivo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNegativo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPositivo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Blue;
            this.lbMessage.Location = new System.Drawing.Point(1, 94);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(374, 24);
            this.lbMessage.TabIndex = 6;
            this.lbMessage.Text = "MENSSAGEM";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(245, 140);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 45);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pbNegativo
            // 
            this.pbNegativo.Image = global::Controle_de_financia2.Properties.Resources.polegares_para_baixo;
            this.pbNegativo.Location = new System.Drawing.Point(142, 12);
            this.pbNegativo.Name = "pbNegativo";
            this.pbNegativo.Size = new System.Drawing.Size(67, 66);
            this.pbNegativo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNegativo.TabIndex = 7;
            this.pbNegativo.TabStop = false;
            this.pbNegativo.Visible = false;
            // 
            // pbPositivo
            // 
            this.pbPositivo.Image = global::Controle_de_financia2.Properties.Resources.polegar_para_cima;
            this.pbPositivo.Location = new System.Drawing.Point(156, 12);
            this.pbPositivo.Name = "pbPositivo";
            this.pbPositivo.Size = new System.Drawing.Size(77, 66);
            this.pbPositivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPositivo.TabIndex = 5;
            this.pbPositivo.TabStop = false;
            this.pbPositivo.Visible = false;
            // 
            // FormAlertMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(374, 241);
            this.Controls.Add(this.pbNegativo);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.pbPositivo);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlertMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALERTA";
            ((System.ComponentModel.ISupportInitialize)(this.pbNegativo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPositivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNegativo;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.PictureBox pbPositivo;
        private System.Windows.Forms.Button btnOk;
    }
}