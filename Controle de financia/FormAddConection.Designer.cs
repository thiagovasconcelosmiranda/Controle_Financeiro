namespace Controle_de_financia2
{
    partial class FormAddConection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddConection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnConectar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbErrorUrl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddUrl = new System.Windows.Forms.TextBox();
            this.lbErrorDataBase = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddDataBase = new System.Windows.Forms.TextBox();
            this.lbErrorPassword = new System.Windows.Forms.Label();
            this.lbErrorUser = new System.Windows.Forms.Label();
            this.lbErrorPorta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddPassword = new System.Windows.Forms.TextBox();
            this.tbAddUser = new System.Windows.Forms.TextBox();
            this.tbAddPorta = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 416);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_financia2.Properties.Resources._5ad847c407aa2661ab13d886fcb7087a;
            this.pictureBox1.Location = new System.Drawing.Point(129, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.ImageKey = "aviso.png";
            this.label6.ImageList = this.imageList1;
            this.label6.Location = new System.Drawing.Point(19, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Os dados precisam estar iguais ao banco de dados\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "aviso.png");
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Maroon;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.ImageKey = "logout.png";
            this.btnSair.ImageList = this.imageList2;
            this.btnSair.Location = new System.Drawing.Point(129, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 52);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "save-file.png");
            this.imageList2.Images.SetKeyName(1, "logout.png");
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Green;
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConectar.ImageKey = "save-file.png";
            this.btnConectar.ImageList = this.imageList2;
            this.btnConectar.Location = new System.Drawing.Point(15, 361);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(95, 52);
            this.btnConectar.TabIndex = 10;
            this.btnConectar.Text = "SALVAR";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbErrorUrl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbAddUrl);
            this.panel2.Controls.Add(this.lbErrorDataBase);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbAddDataBase);
            this.panel2.Controls.Add(this.lbErrorPassword);
            this.panel2.Controls.Add(this.lbErrorUser);
            this.panel2.Controls.Add(this.lbErrorPorta);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbAddPassword);
            this.panel2.Controls.Add(this.tbAddUser);
            this.panel2.Controls.Add(this.tbAddPorta);
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
            this.lbErrorUrl.Size = new System.Drawing.Size(120, 15);
            this.lbErrorUrl.TabIndex = 21;
            this.lbErrorUrl.Text = "Campos obrigatório*";
            this.lbErrorUrl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "URL:";
            // 
            // tbAddUrl
            // 
            this.tbAddUrl.Location = new System.Drawing.Point(13, 26);
            this.tbAddUrl.Name = "tbAddUrl";
            this.tbAddUrl.Size = new System.Drawing.Size(322, 21);
            this.tbAddUrl.TabIndex = 19;
            // 
            // lbErrorDataBase
            // 
            this.lbErrorDataBase.AutoSize = true;
            this.lbErrorDataBase.ForeColor = System.Drawing.Color.Red;
            this.lbErrorDataBase.Location = new System.Drawing.Point(179, 117);
            this.lbErrorDataBase.Name = "lbErrorDataBase";
            this.lbErrorDataBase.Size = new System.Drawing.Size(120, 15);
            this.lbErrorDataBase.TabIndex = 18;
            this.lbErrorDataBase.Text = "Campos obrigatório*";
            this.lbErrorDataBase.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "DATABASE:";
            // 
            // tbAddDataBase
            // 
            this.tbAddDataBase.Location = new System.Drawing.Point(182, 93);
            this.tbAddDataBase.Name = "tbAddDataBase";
            this.tbAddDataBase.Size = new System.Drawing.Size(147, 21);
            this.tbAddDataBase.TabIndex = 16;
            // 
            // lbErrorPassword
            // 
            this.lbErrorPassword.AutoSize = true;
            this.lbErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPassword.Location = new System.Drawing.Point(179, 173);
            this.lbErrorPassword.Name = "lbErrorPassword";
            this.lbErrorPassword.Size = new System.Drawing.Size(120, 15);
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
            this.lbErrorUser.Size = new System.Drawing.Size(120, 15);
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
            this.lbErrorPorta.Size = new System.Drawing.Size(120, 15);
            this.lbErrorPorta.TabIndex = 13;
            this.lbErrorPorta.Text = "Campos obrigatório*";
            this.lbErrorPorta.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "PASSWORD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "USER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORTA:";
            // 
            // tbAddPassword
            // 
            this.tbAddPassword.Location = new System.Drawing.Point(182, 149);
            this.tbAddPassword.Name = "tbAddPassword";
            this.tbAddPassword.Size = new System.Drawing.Size(147, 21);
            this.tbAddPassword.TabIndex = 6;
            // 
            // tbAddUser
            // 
            this.tbAddUser.Location = new System.Drawing.Point(13, 149);
            this.tbAddUser.Name = "tbAddUser";
            this.tbAddUser.Size = new System.Drawing.Size(141, 21);
            this.tbAddUser.TabIndex = 5;
            // 
            // tbAddPorta
            // 
            this.tbAddPorta.Location = new System.Drawing.Point(13, 95);
            this.tbAddPorta.Name = "tbAddPorta";
            this.tbAddPorta.Size = new System.Drawing.Size(141, 21);
            this.tbAddPorta.TabIndex = 3;
            this.tbAddPorta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddPorta_KeyPress);
            // 
            // FormAddConection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(408, 440);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddConection";
            this.Text = "NOVA CONEXAO DE BANCO DE DADOS";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbAddPassword;
        private System.Windows.Forms.TextBox tbAddUser;
        private System.Windows.Forms.TextBox tbAddPorta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lbErrorPassword;
        private System.Windows.Forms.Label lbErrorUser;
        private System.Windows.Forms.Label lbErrorPorta;
        private System.Windows.Forms.Label lbErrorDataBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddDataBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddUrl;
        private System.Windows.Forms.Label lbErrorUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList2;
    }
}