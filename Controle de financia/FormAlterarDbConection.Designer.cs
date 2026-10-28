namespace Controle_de_financia2
{
    partial class FormAlterarDbConection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarDbConection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbErrorUrl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAlterUrl = new System.Windows.Forms.TextBox();
            this.lbErrorDataBase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAlterDataBase = new System.Windows.Forms.TextBox();
            this.lbErrorPassword = new System.Windows.Forms.Label();
            this.lbErrorUser = new System.Windows.Forms.Label();
            this.lbErrorPorta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlterPassword = new System.Windows.Forms.TextBox();
            this.tbAlterUser = new System.Windows.Forms.TextBox();
            this.tbAlterPorta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 416);
            this.panel1.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Blue;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.ImageKey = "undo.png";
            this.btnSair.ImageList = this.imageList1;
            this.btnSair.Location = new System.Drawing.Point(152, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 52);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save-file.png");
            this.imageList1.Images.SetKeyName(1, "undo.png");
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Yellow;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.ImageKey = "save-file.png";
            this.btnAlterar.ImageList = this.imageList1;
            this.btnAlterar.Location = new System.Drawing.Point(15, 361);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(107, 52);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "SALVAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_financia2.Properties.Resources._5ad847c407aa2661ab13d886fcb7087a;
            this.pictureBox1.Location = new System.Drawing.Point(124, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbErrorUrl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbAlterUrl);
            this.panel2.Controls.Add(this.lbErrorDataBase);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbAlterDataBase);
            this.panel2.Controls.Add(this.lbErrorPassword);
            this.panel2.Controls.Add(this.lbErrorUser);
            this.panel2.Controls.Add(this.lbErrorPorta);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbAlterPassword);
            this.panel2.Controls.Add(this.tbAlterUser);
            this.panel2.Controls.Add(this.tbAlterPorta);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(9, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 220);
            this.panel2.TabIndex = 6;
            // 
            // lbErrorUrl
            // 
            this.lbErrorUrl.AutoSize = true;
            this.lbErrorUrl.ForeColor = System.Drawing.Color.Red;
            this.lbErrorUrl.Location = new System.Drawing.Point(10, 50);
            this.lbErrorUrl.Name = "lbErrorUrl";
            this.lbErrorUrl.Size = new System.Drawing.Size(131, 16);
            this.lbErrorUrl.TabIndex = 21;
            this.lbErrorUrl.Text = "Campos obrigatório*";
            this.lbErrorUrl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "URL:";
            // 
            // tbAlterUrl
            // 
            this.tbAlterUrl.Location = new System.Drawing.Point(13, 26);
            this.tbAlterUrl.Name = "tbAlterUrl";
            this.tbAlterUrl.Size = new System.Drawing.Size(322, 22);
            this.tbAlterUrl.TabIndex = 19;
            // 
            // lbErrorDataBase
            // 
            this.lbErrorDataBase.AutoSize = true;
            this.lbErrorDataBase.ForeColor = System.Drawing.Color.Red;
            this.lbErrorDataBase.Location = new System.Drawing.Point(179, 117);
            this.lbErrorDataBase.Name = "lbErrorDataBase";
            this.lbErrorDataBase.Size = new System.Drawing.Size(131, 16);
            this.lbErrorDataBase.TabIndex = 18;
            this.lbErrorDataBase.Text = "Campos obrigatório*";
            this.lbErrorDataBase.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "DATABASE:";
            // 
            // tbAlterDataBase
            // 
            this.tbAlterDataBase.Location = new System.Drawing.Point(182, 93);
            this.tbAlterDataBase.Name = "tbAlterDataBase";
            this.tbAlterDataBase.Size = new System.Drawing.Size(147, 22);
            this.tbAlterDataBase.TabIndex = 16;
            // 
            // lbErrorPassword
            // 
            this.lbErrorPassword.AutoSize = true;
            this.lbErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPassword.Location = new System.Drawing.Point(179, 173);
            this.lbErrorPassword.Name = "lbErrorPassword";
            this.lbErrorPassword.Size = new System.Drawing.Size(131, 16);
            this.lbErrorPassword.TabIndex = 15;
            this.lbErrorPassword.Text = "Campos obrigatório*";
            this.lbErrorPassword.Visible = false;
            // 
            // lbErrorUser
            // 
            this.lbErrorUser.AutoSize = true;
            this.lbErrorUser.ForeColor = System.Drawing.Color.Red;
            this.lbErrorUser.Location = new System.Drawing.Point(10, 173);
            this.lbErrorUser.Name = "lbErrorUser";
            this.lbErrorUser.Size = new System.Drawing.Size(131, 16);
            this.lbErrorUser.TabIndex = 14;
            this.lbErrorUser.Text = "Campos obrigatório*";
            this.lbErrorUser.Visible = false;
            // 
            // lbErrorPorta
            // 
            this.lbErrorPorta.AutoSize = true;
            this.lbErrorPorta.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPorta.Location = new System.Drawing.Point(10, 117);
            this.lbErrorPorta.Name = "lbErrorPorta";
            this.lbErrorPorta.Size = new System.Drawing.Size(131, 16);
            this.lbErrorPorta.TabIndex = 13;
            this.lbErrorPorta.Text = "Campos obrigatório*";
            this.lbErrorPorta.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "PASSWORD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "USER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORTA:";
            // 
            // tbAlterPassword
            // 
            this.tbAlterPassword.Location = new System.Drawing.Point(182, 149);
            this.tbAlterPassword.Name = "tbAlterPassword";
            this.tbAlterPassword.Size = new System.Drawing.Size(147, 22);
            this.tbAlterPassword.TabIndex = 6;
            // 
            // tbAlterUser
            // 
            this.tbAlterUser.Location = new System.Drawing.Point(13, 149);
            this.tbAlterUser.Name = "tbAlterUser";
            this.tbAlterUser.Size = new System.Drawing.Size(141, 22);
            this.tbAlterUser.TabIndex = 5;
            // 
            // tbAlterPorta
            // 
            this.tbAlterPorta.Location = new System.Drawing.Point(13, 95);
            this.tbAlterPorta.Name = "tbAlterPorta";
            this.tbAlterPorta.Size = new System.Drawing.Size(141, 22);
            this.tbAlterPorta.TabIndex = 3;
            // 
            // FormAlterarDbConection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlterarDbConection";
            this.Text = "ALTERAR CONEXÃO";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbErrorUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlterUrl;
        private System.Windows.Forms.Label lbErrorDataBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAlterDataBase;
        private System.Windows.Forms.Label lbErrorPassword;
        private System.Windows.Forms.Label lbErrorUser;
        private System.Windows.Forms.Label lbErrorPorta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAlterPassword;
        private System.Windows.Forms.TextBox tbAlterUser;
        private System.Windows.Forms.TextBox tbAlterPorta;
        private System.Windows.Forms.ImageList imageList1;
    }
}