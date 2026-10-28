namespace Controle_de_financia2
{
    partial class FormRespostaSecreta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRespostaSecreta));
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterarPassword = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbResposaVerificada = new System.Windows.Forms.Label();
            this.tbSecrete = new System.Windows.Forms.TextBox();
            this.btnVerificarResposta = new System.Windows.Forms.Button();
            this.lbErrorSecrete = new System.Windows.Forms.Label();
            this.lbPergunta = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbEmailVerificado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbErrorEmail = new System.Windows.Forms.Label();
            this.btnVerificarEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "aceitar.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lupa (1).png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "cadeado.png");
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "financial-statement (1).png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAlterarPassword);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 376);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImageKey = "financial-statement (1).png";
            this.label2.ImageList = this.imageList4;
            this.label2.Location = new System.Drawing.Point(62, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 42);
            this.label2.TabIndex = 39;
            this.label2.Text = "Recuperar senha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAlterarPassword
            // 
            this.btnAlterarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAlterarPassword.Enabled = false;
            this.btnAlterarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarPassword.ImageKey = "cadeado.png";
            this.btnAlterarPassword.ImageList = this.imageList2;
            this.btnAlterarPassword.Location = new System.Drawing.Point(31, 313);
            this.btnAlterarPassword.Name = "btnAlterarPassword";
            this.btnAlterarPassword.Size = new System.Drawing.Size(118, 44);
            this.btnAlterarPassword.TabIndex = 38;
            this.btnAlterarPassword.Text = "Alterar senha";
            this.btnAlterarPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarPassword.UseVisualStyleBackColor = false;
            this.btnAlterarPassword.Click += new System.EventHandler(this.btnAlterarPassword_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbResposaVerificada);
            this.groupBox3.Controls.Add(this.tbSecrete);
            this.groupBox3.Controls.Add(this.btnVerificarResposta);
            this.groupBox3.Controls.Add(this.lbErrorSecrete);
            this.groupBox3.Controls.Add(this.lbPergunta);
            this.groupBox3.Location = new System.Drawing.Point(23, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 93);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // lbResposaVerificada
            // 
            this.lbResposaVerificada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbResposaVerificada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposaVerificada.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbResposaVerificada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbResposaVerificada.ImageKey = "aceitar.png";
            this.lbResposaVerificada.ImageList = this.imageList3;
            this.lbResposaVerificada.Location = new System.Drawing.Point(16, 70);
            this.lbResposaVerificada.Name = "lbResposaVerificada";
            this.lbResposaVerificada.Size = new System.Drawing.Size(121, 13);
            this.lbResposaVerificada.TabIndex = 36;
            this.lbResposaVerificada.Text = "Email verificado";
            this.lbResposaVerificada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbResposaVerificada.Visible = false;
            // 
            // tbSecrete
            // 
            this.tbSecrete.Enabled = false;
            this.tbSecrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecrete.Location = new System.Drawing.Point(16, 36);
            this.tbSecrete.Name = "tbSecrete";
            this.tbSecrete.Size = new System.Drawing.Size(228, 29);
            this.tbSecrete.TabIndex = 34;
            // 
            // btnVerificarResposta
            // 
            this.btnVerificarResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerificarResposta.Enabled = false;
            this.btnVerificarResposta.ImageKey = "lupa (1).png";
            this.btnVerificarResposta.ImageList = this.imageList1;
            this.btnVerificarResposta.Location = new System.Drawing.Point(251, 31);
            this.btnVerificarResposta.Name = "btnVerificarResposta";
            this.btnVerificarResposta.Size = new System.Drawing.Size(48, 37);
            this.btnVerificarResposta.TabIndex = 2;
            this.btnVerificarResposta.UseVisualStyleBackColor = false;
            this.btnVerificarResposta.Click += new System.EventHandler(this.btnVerificarResposta_Click_1);
            // 
            // lbErrorSecrete
            // 
            this.lbErrorSecrete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorSecrete.AutoSize = true;
            this.lbErrorSecrete.ForeColor = System.Drawing.Color.Red;
            this.lbErrorSecrete.Location = new System.Drawing.Point(20, 70);
            this.lbErrorSecrete.Name = "lbErrorSecrete";
            this.lbErrorSecrete.Size = new System.Drawing.Size(106, 13);
            this.lbErrorSecrete.TabIndex = 26;
            this.lbErrorSecrete.Text = "Campos obrigaórios *";
            this.lbErrorSecrete.Visible = false;
            // 
            // lbPergunta
            // 
            this.lbPergunta.AutoSize = true;
            this.lbPergunta.Enabled = false;
            this.lbPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbPergunta.Location = new System.Drawing.Point(15, 13);
            this.lbPergunta.Name = "lbPergunta";
            this.lbPergunta.Size = new System.Drawing.Size(188, 20);
            this.lbPergunta.TabIndex = 35;
            this.lbPergunta.Text = "Responda a pergunta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbEmailVerificado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.lbErrorEmail);
            this.groupBox2.Controls.Add(this.btnVerificarEmail);
            this.groupBox2.Location = new System.Drawing.Point(23, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 100);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // lbEmailVerificado
            // 
            this.lbEmailVerificado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbEmailVerificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailVerificado.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbEmailVerificado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbEmailVerificado.ImageKey = "aceitar.png";
            this.lbEmailVerificado.ImageList = this.imageList3;
            this.lbEmailVerificado.Location = new System.Drawing.Point(16, 71);
            this.lbEmailVerificado.Name = "lbEmailVerificado";
            this.lbEmailVerificado.Size = new System.Drawing.Size(121, 19);
            this.lbEmailVerificado.TabIndex = 32;
            this.lbEmailVerificado.Text = "Email verificado";
            this.lbEmailVerificado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbEmailVerificado.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(16, 39);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(228, 29);
            this.tbEmail.TabIndex = 30;
            // 
            // lbErrorEmail
            // 
            this.lbErrorEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorEmail.AutoSize = true;
            this.lbErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEmail.Location = new System.Drawing.Point(13, 75);
            this.lbErrorEmail.Name = "lbErrorEmail";
            this.lbErrorEmail.Size = new System.Drawing.Size(106, 13);
            this.lbErrorEmail.TabIndex = 29;
            this.lbErrorEmail.Text = "Campos obrigaórios *";
            this.lbErrorEmail.Visible = false;
            // 
            // btnVerificarEmail
            // 
            this.btnVerificarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerificarEmail.ImageKey = "lupa (1).png";
            this.btnVerificarEmail.ImageList = this.imageList1;
            this.btnVerificarEmail.Location = new System.Drawing.Point(251, 35);
            this.btnVerificarEmail.Name = "btnVerificarEmail";
            this.btnVerificarEmail.Size = new System.Drawing.Size(48, 37);
            this.btnVerificarEmail.TabIndex = 29;
            this.btnVerificarEmail.UseVisualStyleBackColor = false;
            this.btnVerificarEmail.Click += new System.EventHandler(this.btnVerificarEmail_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Responsta secreta::";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRespostaSecreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(417, 400);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRespostaSecreta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RECUPERAR PASSWORD";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlterarPassword;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbResposaVerificada;
        private System.Windows.Forms.TextBox tbSecrete;
        private System.Windows.Forms.Button btnVerificarResposta;
        private System.Windows.Forms.Label lbErrorSecrete;
        private System.Windows.Forms.Label lbPergunta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbEmailVerificado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbErrorEmail;
        private System.Windows.Forms.Button btnVerificarEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}