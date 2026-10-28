namespace Controle_de_financia2
{
    partial class FormAlterPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterPassword));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterarPassword = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRepetePassword = new System.Windows.Forms.TextBox();
            this.lbErrorRepetePassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNovaPassword = new System.Windows.Forms.TextBox();
            this.lbErrorNovoPassword = new System.Windows.Forms.Label();
            this.pbMostrarOcutar = new System.Windows.Forms.PictureBox();
            this.pbOcutarPassword = new System.Windows.Forms.PictureBox();
            this.pbMostrarRepetPassword = new System.Windows.Forms.PictureBox();
            this.pbOcultarRepetPassword = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarOcutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcutarPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarRepetPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarRepetPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "aceitar.png");
            this.imageList1.Images.SetKeyName(1, "cadeado.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "salvar.png");
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.ImageKey = "financial-statement (1).png";
            this.label7.ImageList = this.imageList3;
            this.label7.Location = new System.Drawing.Point(66, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 64);
            this.label7.TabIndex = 33;
            this.label7.Text = "Controle financeiro";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "financial-statement (1).png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbMostrarRepetPassword);
            this.panel1.Controls.Add(this.pbOcultarRepetPassword);
            this.panel1.Controls.Add(this.pbMostrarOcutar);
            this.panel1.Controls.Add(this.pbOcutarPassword);
            this.panel1.Controls.Add(this.btnAlterarPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbRepetePassword);
            this.panel1.Controls.Add(this.lbErrorRepetePassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbNovaPassword);
            this.panel1.Controls.Add(this.lbErrorNovoPassword);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 246);
            this.panel1.TabIndex = 34;
            // 
            // btnAlterarPassword
            // 
            this.btnAlterarPassword.BackColor = System.Drawing.Color.Gold;
            this.btnAlterarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlterarPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarPassword.ImageKey = "salvar.png";
            this.btnAlterarPassword.ImageList = this.imageList2;
            this.btnAlterarPassword.Location = new System.Drawing.Point(39, 190);
            this.btnAlterarPassword.Name = "btnAlterarPassword";
            this.btnAlterarPassword.Size = new System.Drawing.Size(123, 44);
            this.btnAlterarPassword.TabIndex = 50;
            this.btnAlterarPassword.Text = "Alterar senha";
            this.btnAlterarPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarPassword.UseVisualStyleBackColor = false;
            this.btnAlterarPassword.Click += new System.EventHandler(this.btnAlterarPassword_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Controle_de_financia2.Properties.Resources.cadeado;
            this.pictureBox2.Location = new System.Drawing.Point(39, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_financia2.Properties.Resources.cadeado;
            this.pictureBox1.Location = new System.Drawing.Point(39, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Confirme a senha:";
            // 
            // tbRepetePassword
            // 
            this.tbRepetePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepetePassword.Location = new System.Drawing.Point(81, 130);
            this.tbRepetePassword.Name = "tbRepetePassword";
            this.tbRepetePassword.Size = new System.Drawing.Size(203, 29);
            this.tbRepetePassword.TabIndex = 46;
            // 
            // lbErrorRepetePassword
            // 
            this.lbErrorRepetePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorRepetePassword.AutoSize = true;
            this.lbErrorRepetePassword.ForeColor = System.Drawing.Color.Red;
            this.lbErrorRepetePassword.Location = new System.Drawing.Point(79, 162);
            this.lbErrorRepetePassword.Name = "lbErrorRepetePassword";
            this.lbErrorRepetePassword.Size = new System.Drawing.Size(106, 13);
            this.lbErrorRepetePassword.TabIndex = 45;
            this.lbErrorRepetePassword.Text = "Campos obrigaórios *";
            this.lbErrorRepetePassword.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(35, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Nova senha:";
            // 
            // tbNovaPassword
            // 
            this.tbNovaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNovaPassword.Location = new System.Drawing.Point(81, 40);
            this.tbNovaPassword.Name = "tbNovaPassword";
            this.tbNovaPassword.Size = new System.Drawing.Size(203, 29);
            this.tbNovaPassword.TabIndex = 43;
            // 
            // lbErrorNovoPassword
            // 
            this.lbErrorNovoPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorNovoPassword.AutoSize = true;
            this.lbErrorNovoPassword.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNovoPassword.Location = new System.Drawing.Point(79, 72);
            this.lbErrorNovoPassword.Name = "lbErrorNovoPassword";
            this.lbErrorNovoPassword.Size = new System.Drawing.Size(106, 13);
            this.lbErrorNovoPassword.TabIndex = 42;
            this.lbErrorNovoPassword.Text = "Campos obrigaórios *";
            this.lbErrorNovoPassword.Visible = false;
            // 
            // pbMostrarOcutar
            // 
            this.pbMostrarOcutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbMostrarOcutar.Image = global::Controle_de_financia2.Properties.Resources.olho__1_;
            this.pbMostrarOcutar.Location = new System.Drawing.Point(282, 40);
            this.pbMostrarOcutar.Name = "pbMostrarOcutar";
            this.pbMostrarOcutar.Size = new System.Drawing.Size(27, 29);
            this.pbMostrarOcutar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrarOcutar.TabIndex = 52;
            this.pbMostrarOcutar.TabStop = false;
            this.pbMostrarOcutar.Click += new System.EventHandler(this.pbMostrarOcutar_Click);
            // 
            // pbOcutarPassword
            // 
            this.pbOcutarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbOcutarPassword.Image = global::Controle_de_financia2.Properties.Resources.olho;
            this.pbOcutarPassword.Location = new System.Drawing.Point(282, 40);
            this.pbOcutarPassword.Name = "pbOcutarPassword";
            this.pbOcutarPassword.Size = new System.Drawing.Size(27, 29);
            this.pbOcutarPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOcutarPassword.TabIndex = 51;
            this.pbOcutarPassword.TabStop = false;
            this.pbOcutarPassword.Visible = false;
            this.pbOcutarPassword.Click += new System.EventHandler(this.pbOcutarPassword_Click);
            // 
            // pbMostrarRepetPassword
            // 
            this.pbMostrarRepetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbMostrarRepetPassword.Image = global::Controle_de_financia2.Properties.Resources.olho__1_;
            this.pbMostrarRepetPassword.Location = new System.Drawing.Point(282, 130);
            this.pbMostrarRepetPassword.Name = "pbMostrarRepetPassword";
            this.pbMostrarRepetPassword.Size = new System.Drawing.Size(27, 29);
            this.pbMostrarRepetPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrarRepetPassword.TabIndex = 54;
            this.pbMostrarRepetPassword.TabStop = false;
            this.pbMostrarRepetPassword.Click += new System.EventHandler(this.pbMostrarRepetPassword_Click);
            // 
            // pbOcultarRepetPassword
            // 
            this.pbOcultarRepetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbOcultarRepetPassword.Image = global::Controle_de_financia2.Properties.Resources.olho;
            this.pbOcultarRepetPassword.Location = new System.Drawing.Point(282, 130);
            this.pbOcultarRepetPassword.Name = "pbOcultarRepetPassword";
            this.pbOcultarRepetPassword.Size = new System.Drawing.Size(27, 29);
            this.pbOcultarRepetPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOcultarRepetPassword.TabIndex = 53;
            this.pbOcultarRepetPassword.TabStop = false;
            this.pbOcultarRepetPassword.Visible = false;
            this.pbOcultarRepetPassword.Click += new System.EventHandler(this.pbOcultarRepetPassword_Click);
            // 
            // FormAlterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(374, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlterPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ALTERAR SENHA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarOcutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcutarPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarRepetPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultarRepetPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlterarPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRepetePassword;
        private System.Windows.Forms.Label lbErrorRepetePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNovaPassword;
        private System.Windows.Forms.Label lbErrorNovoPassword;
        private System.Windows.Forms.PictureBox pbMostrarRepetPassword;
        private System.Windows.Forms.PictureBox pbOcultarRepetPassword;
        private System.Windows.Forms.PictureBox pbMostrarOcutar;
        private System.Windows.Forms.PictureBox pbOcutarPassword;
    }
}