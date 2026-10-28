namespace Controle_de_financia2
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMostrarOcutar = new System.Windows.Forms.PictureBox();
            this.pbOcutarPassword = new System.Windows.Forms.PictureBox();
            this.cbLogado = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLbEmail = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lbErrorPassword = new System.Windows.Forms.Label();
            this.lbErrorEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alterarConexãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarOcutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcutarPassword)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "cadeado.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "financeiro.png");
            this.imageList1.Images.SetKeyName(1, "financial-statement.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pbMostrarOcutar);
            this.panel1.Controls.Add(this.pbOcutarPassword);
            this.panel1.Controls.Add(this.cbLogado);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLbEmail);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.lbErrorPassword);
            this.panel1.Controls.Add(this.lbErrorEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Location = new System.Drawing.Point(263, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 290);
            this.panel1.TabIndex = 25;
            // 
            // pbMostrarOcutar
            // 
            this.pbMostrarOcutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbMostrarOcutar.Image = global::Controle_de_financia2.Properties.Resources.olho__1_;
            this.pbMostrarOcutar.Location = new System.Drawing.Point(221, 107);
            this.pbMostrarOcutar.Name = "pbMostrarOcutar";
            this.pbMostrarOcutar.Size = new System.Drawing.Size(27, 23);
            this.pbMostrarOcutar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrarOcutar.TabIndex = 35;
            this.pbMostrarOcutar.TabStop = false;
            this.pbMostrarOcutar.Click += new System.EventHandler(this.pbMostrarOcutar_Click);
            // 
            // pbOcutarPassword
            // 
            this.pbOcutarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbOcutarPassword.Image = global::Controle_de_financia2.Properties.Resources.olho;
            this.pbOcutarPassword.Location = new System.Drawing.Point(221, 107);
            this.pbOcutarPassword.Name = "pbOcutarPassword";
            this.pbOcutarPassword.Size = new System.Drawing.Size(27, 23);
            this.pbOcutarPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOcutarPassword.TabIndex = 34;
            this.pbOcutarPassword.TabStop = false;
            this.pbOcutarPassword.Visible = false;
            this.pbOcutarPassword.Click += new System.EventHandler(this.pbOcutarPassword_Click);
            // 
            // cbLogado
            // 
            this.cbLogado.AutoSize = true;
            this.cbLogado.ForeColor = System.Drawing.Color.Blue;
            this.cbLogado.Location = new System.Drawing.Point(46, 160);
            this.cbLogado.Name = "cbLogado";
            this.cbLogado.Size = new System.Drawing.Size(94, 17);
            this.cbLogado.TabIndex = 33;
            this.cbLogado.Text = "Manter logado";
            this.cbLogado.UseVisualStyleBackColor = true;
            this.cbLogado.CheckedChanged += new System.EventHandler(this.cbLogado_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(42, 107);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(180, 23);
            this.tbPassword.TabIndex = 32;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(42, 205);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 17);
            this.linkLabel2.TabIndex = 31;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Novo usuário";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLbEmail
            // 
            this.linkLbEmail.AutoSize = true;
            this.linkLbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbEmail.Location = new System.Drawing.Point(42, 183);
            this.linkLbEmail.Name = "linkLbEmail";
            this.linkLbEmail.Size = new System.Drawing.Size(149, 17);
            this.linkLbEmail.TabIndex = 30;
            this.linkLbEmail.TabStop = true;
            this.linkLbEmail.Text = "Esqueceu sua senha?";
            this.linkLbEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbEmail_LinkClicked_1);
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = true;
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.ImageKey = "cadeado.png";
            this.btnEntrar.ImageList = this.imageList2;
            this.btnEntrar.Location = new System.Drawing.Point(45, 234);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(117, 44);
            this.btnEntrar.TabIndex = 29;
            this.btnEntrar.Text = "ACESSAR";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lbErrorPassword
            // 
            this.lbErrorPassword.AutoSize = true;
            this.lbErrorPassword.Font = new System.Drawing.Font("Book Antiqua", 9.25F, System.Drawing.FontStyle.Italic);
            this.lbErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPassword.Location = new System.Drawing.Point(39, 133);
            this.lbErrorPassword.Name = "lbErrorPassword";
            this.lbErrorPassword.Size = new System.Drawing.Size(122, 18);
            this.lbErrorPassword.TabIndex = 28;
            this.lbErrorPassword.Text = "Campos obrigaórios *";
            this.lbErrorPassword.Visible = false;
            // 
            // lbErrorEmail
            // 
            this.lbErrorEmail.AutoSize = true;
            this.lbErrorEmail.Font = new System.Drawing.Font("Book Antiqua", 9.25F, System.Drawing.FontStyle.Italic);
            this.lbErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEmail.Location = new System.Drawing.Point(40, 62);
            this.lbErrorEmail.Name = "lbErrorEmail";
            this.lbErrorEmail.Size = new System.Drawing.Size(122, 18);
            this.lbErrorEmail.TabIndex = 27;
            this.lbErrorEmail.Text = "Campos obrigaórios *";
            this.lbErrorEmail.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(36, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(38, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(42, 41);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(206, 23);
            this.tbEmail.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarConexãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alterarConexãoToolStripMenuItem
            // 
            this.alterarConexãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.alterarConexãoToolStripMenuItem.Name = "alterarConexãoToolStripMenuItem";
            this.alterarConexãoToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.alterarConexãoToolStripMenuItem.Text = "Alterar conexão";
            this.alterarConexãoToolStripMenuItem.Click += new System.EventHandler(this.alterarConexãoToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.ImageKey = "financial-statement.png";
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(133, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 64);
            this.label7.TabIndex = 24;
            this.label7.Text = "CONTROLE FINANCEIRO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_financia2.Properties.Resources._17233017_2008_i301_001_personal_data_protection_gdpr_isometric_icons_07;
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "VERSÃO: 1.8";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(538, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN ";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarOcutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcutarPassword)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLbEmail;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lbErrorPassword;
        private System.Windows.Forms.Label lbErrorEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alterarConexãoToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbLogado;
        private System.Windows.Forms.PictureBox pbOcutarPassword;
        private System.Windows.Forms.PictureBox pbMostrarOcutar;
        private System.Windows.Forms.Label label2;
    }
}