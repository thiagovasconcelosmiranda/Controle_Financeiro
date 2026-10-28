namespace Controle_de_financia2
{
    partial class FormListaContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaContas));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbAtual = new System.Windows.Forms.RadioButton();
            this.rbNaoPagos = new System.Windows.Forms.RadioButton();
            this.rbPagos = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckboxTodos = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btDeletarselecionado = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btTransferirConta = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbAbrirPdf = new System.Windows.Forms.PictureBox();
            this.lbSalario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbAviso = new System.Windows.Forms.Label();
            this.lbListViewSobra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSomar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrirPdf)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "report.png");
            this.imageList2.Images.SetKeyName(1, "human.png");
            this.imageList2.Images.SetKeyName(2, "close.png");
            this.imageList2.Images.SetKeyName(3, "salvar.png");
            this.imageList2.Images.SetKeyName(4, "financial-statement.ico");
            this.imageList2.Images.SetKeyName(5, "refresh.png");
            this.imageList2.Images.SetKeyName(6, "botao-apagar.png");
            this.imageList2.Images.SetKeyName(7, "transferir-dados.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ball-icon-png-4630.png");
            this.imageList1.Images.SetKeyName(1, "glossy-ball-png-26222.png");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "warning.png");
            this.imageList3.Images.SetKeyName(1, "transferir-dados.png");
            this.imageList3.Images.SetKeyName(2, "botao-apagar.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rbAtual);
            this.panel1.Controls.Add(this.rbNaoPagos);
            this.panel1.Controls.Add(this.rbPagos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbMes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbAno);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 130);
            this.panel1.TabIndex = 42;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(43, 86);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(158, 26);
            this.tbSearch.TabIndex = 79;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(40, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 18);
            this.label8.TabIndex = 78;
            this.label8.Text = "Por estabelecimento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_financia2.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // rbAtual
            // 
            this.rbAtual.AutoSize = true;
            this.rbAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtual.ForeColor = System.Drawing.Color.Blue;
            this.rbAtual.Location = new System.Drawing.Point(635, 89);
            this.rbAtual.Name = "rbAtual";
            this.rbAtual.Size = new System.Drawing.Size(63, 22);
            this.rbAtual.TabIndex = 75;
            this.rbAtual.TabStop = true;
            this.rbAtual.Text = "Atual";
            this.rbAtual.UseVisualStyleBackColor = true;
            this.rbAtual.CheckedChanged += new System.EventHandler(this.rbAtual_CheckedChanged_1);
            // 
            // rbNaoPagos
            // 
            this.rbNaoPagos.AutoSize = true;
            this.rbNaoPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbNaoPagos.Location = new System.Drawing.Point(521, 87);
            this.rbNaoPagos.Name = "rbNaoPagos";
            this.rbNaoPagos.Size = new System.Drawing.Size(108, 22);
            this.rbNaoPagos.TabIndex = 74;
            this.rbNaoPagos.TabStop = true;
            this.rbNaoPagos.Text = "Não pagos";
            this.rbNaoPagos.UseVisualStyleBackColor = true;
            this.rbNaoPagos.CheckedChanged += new System.EventHandler(this.rbNaoPagos_CheckedChanged);
            // 
            // rbPagos
            // 
            this.rbPagos.AutoSize = true;
            this.rbPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbPagos.Location = new System.Drawing.Point(441, 86);
            this.rbPagos.Name = "rbPagos";
            this.rbPagos.Size = new System.Drawing.Size(74, 22);
            this.rbPagos.TabIndex = 73;
            this.rbPagos.TabStop = true;
            this.rbPagos.Text = "Pagos";
            this.rbPagos.UseVisualStyleBackColor = true;
            this.rbPagos.CheckedChanged += new System.EventHandler(this.rbPagos_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(317, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "Por mês:";
            // 
            // cbMes
            // 
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "1-Janeiro",
            "2-Fevereiro",
            "3-Março",
            "4-Abril",
            "5-Maio",
            "6-Junho",
            "7-Julho",
            "8-Agosto",
            "9-Setembro",
            "10-Outubro",
            "11-Novembro",
            "12-Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(320, 83);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(101, 28);
            this.cbMes.TabIndex = 71;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            this.cbMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMes_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(227, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "Por ano:";
            // 
            // cbAno
            // 
            this.cbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbAno.Location = new System.Drawing.Point(229, 84);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(81, 28);
            this.cbAno.TabIndex = 69;
            this.cbAno.SelectedIndexChanged += new System.EventHandler(this.cbAno_SelectedIndexChanged_1);
            this.cbAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAno_KeyPress_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.ImageKey = "financial-statement.ico";
            this.label5.ImageList = this.imageList2;
            this.label5.Location = new System.Drawing.Point(279, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 37);
            this.label5.TabIndex = 68;
            this.label5.Text = "CONTA Á PAGAR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.ckboxTodos);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.btDeletarselecionado);
            this.panel2.Controls.Add(this.btAlterar);
            this.panel2.Controls.Add(this.btTransferirConta);
            this.panel2.Location = new System.Drawing.Point(12, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 287);
            this.panel2.TabIndex = 43;
            // 
            // ckboxTodos
            // 
            this.ckboxTodos.AutoSize = true;
            this.ckboxTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxTodos.ForeColor = System.Drawing.Color.Blue;
            this.ckboxTodos.Location = new System.Drawing.Point(21, 4);
            this.ckboxTodos.Name = "ckboxTodos";
            this.ckboxTodos.Size = new System.Drawing.Size(75, 22);
            this.ckboxTodos.TabIndex = 48;
            this.ckboxTodos.Text = "Todos";
            this.ckboxTodos.UseVisualStyleBackColor = true;
            this.ckboxTodos.CheckedChanged += new System.EventHandler(this.ckboxTodos_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(719, 176);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // btDeletarselecionado
            // 
            this.btDeletarselecionado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDeletarselecionado.BackColor = System.Drawing.Color.Maroon;
            this.btDeletarselecionado.FlatAppearance.BorderSize = 0;
            this.btDeletarselecionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletarselecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletarselecionado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDeletarselecionado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletarselecionado.ImageKey = "botao-apagar.png";
            this.btDeletarselecionado.ImageList = this.imageList3;
            this.btDeletarselecionado.Location = new System.Drawing.Point(22, 214);
            this.btDeletarselecionado.Name = "btDeletarselecionado";
            this.btDeletarselecionado.Size = new System.Drawing.Size(107, 44);
            this.btDeletarselecionado.TabIndex = 47;
            this.btDeletarselecionado.Text = "DELETAR";
            this.btDeletarselecionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDeletarselecionado.UseVisualStyleBackColor = false;
            this.btDeletarselecionado.Click += new System.EventHandler(this.btDeletarselecionado_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.AutoSize = true;
            this.btAlterar.BackColor = System.Drawing.Color.Gold;
            this.btAlterar.Enabled = false;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.ForeColor = System.Drawing.Color.Black;
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.ImageKey = "salvar.png";
            this.btAlterar.ImageList = this.imageList2;
            this.btAlterar.Location = new System.Drawing.Point(264, 214);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(104, 44);
            this.btAlterar.TabIndex = 21;
            this.btAlterar.Text = "ALTERAR";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click_1);
            // 
            // btTransferirConta
            // 
            this.btTransferirConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btTransferirConta.FlatAppearance.BorderSize = 0;
            this.btTransferirConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransferirConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransferirConta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTransferirConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTransferirConta.ImageKey = "transferir-dados.png";
            this.btTransferirConta.ImageList = this.imageList3;
            this.btTransferirConta.Location = new System.Drawing.Point(134, 214);
            this.btTransferirConta.Name = "btTransferirConta";
            this.btTransferirConta.Size = new System.Drawing.Size(124, 44);
            this.btTransferirConta.TabIndex = 46;
            this.btTransferirConta.Text = "TRANSFERIR";
            this.btTransferirConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTransferirConta.UseVisualStyleBackColor = false;
            this.btTransferirConta.Click += new System.EventHandler(this.btTransferirConta_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pbAbrirPdf);
            this.panel3.Controls.Add(this.lbSalario);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.lbAviso);
            this.panel3.Controls.Add(this.lbListViewSobra);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbSomar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(12, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 100);
            this.panel3.TabIndex = 44;
            // 
            // pbAbrirPdf
            // 
            this.pbAbrirPdf.Image = global::Controle_de_financia2.Properties.Resources.pdf1;
            this.pbAbrirPdf.Location = new System.Drawing.Point(666, 11);
            this.pbAbrirPdf.Name = "pbAbrirPdf";
            this.pbAbrirPdf.Size = new System.Drawing.Size(45, 47);
            this.pbAbrirPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbrirPdf.TabIndex = 38;
            this.pbAbrirPdf.TabStop = false;
            this.pbAbrirPdf.Visible = false;
            this.pbAbrirPdf.Click += new System.EventHandler(this.pbAbrirPdf_Click);
            this.pbAbrirPdf.MouseEnter += new System.EventHandler(this.pbAbrirPdf_MouseEnter);
            this.pbAbrirPdf.MouseLeave += new System.EventHandler(this.pbAbrirPdf_MouseLeave);
            // 
            // lbSalario
            // 
            this.lbSalario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSalario.AutoSize = true;
            this.lbSalario.BackColor = System.Drawing.Color.Transparent;
            this.lbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario.ForeColor = System.Drawing.Color.Blue;
            this.lbSalario.Location = new System.Drawing.Point(418, 31);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(44, 20);
            this.lbSalario.TabIndex = 37;
            this.lbSalario.Text = "0,00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "SALRIO ATUAL:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Location = new System.Drawing.Point(321, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 35);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "STATUS:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Teal;
            this.lbStatus.Location = new System.Drawing.Point(122, 11);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(30, 24);
            this.lbStatus.TabIndex = 20;
            this.lbStatus.Text = "__";
            // 
            // lbAviso
            // 
            this.lbAviso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Red;
            this.lbAviso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAviso.ImageKey = "warning.png";
            this.lbAviso.ImageList = this.imageList3;
            this.lbAviso.Location = new System.Drawing.Point(44, 65);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(223, 24);
            this.lbAviso.TabIndex = 34;
            this.lbAviso.Text = "Sua divida utrapassou seu salário";
            this.lbAviso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAviso.Visible = false;
            // 
            // lbListViewSobra
            // 
            this.lbListViewSobra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbListViewSobra.AutoSize = true;
            this.lbListViewSobra.BackColor = System.Drawing.Color.Transparent;
            this.lbListViewSobra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListViewSobra.ForeColor = System.Drawing.Color.Green;
            this.lbListViewSobra.Location = new System.Drawing.Point(225, 31);
            this.lbListViewSobra.Name = "lbListViewSobra";
            this.lbListViewSobra.Size = new System.Drawing.Size(44, 20);
            this.lbListViewSobra.TabIndex = 33;
            this.lbListViewSobra.Text = "0,00";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "SOBRA LIQUÍDA :";
            // 
            // lbSomar
            // 
            this.lbSomar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSomar.AutoSize = true;
            this.lbSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSomar.Location = new System.Drawing.Point(44, 31);
            this.lbSomar.Name = "lbSomar";
            this.lbSomar.Size = new System.Drawing.Size(44, 20);
            this.lbSomar.TabIndex = 31;
            this.lbSomar.Text = "0,00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "TOTAL CONTAS:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.btnVoltar);
            this.panel4.Controls.Add(this.btnAtualizar);
            this.panel4.Location = new System.Drawing.Point(12, 572);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 69);
            this.panel4.TabIndex = 45;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImageKey = "human.png";
            this.btnVoltar.ImageList = this.imageList2;
            this.btnVoltar.Location = new System.Drawing.Point(17, 17);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 38);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.ImageKey = "refresh.png";
            this.btnAtualizar.ImageList = this.imageList2;
            this.btnAtualizar.Location = new System.Drawing.Point(125, 17);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 38);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FormListaContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 660);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaContas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTA DE CONTAS À PAGAR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrirPdf)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAtual;
        private System.Windows.Forms.RadioButton rbNaoPagos;
        private System.Windows.Forms.RadioButton rbPagos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckboxTodos;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btDeletarselecionado;
        private System.Windows.Forms.Button btTransferirConta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Label lbListViewSobra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbAbrirPdf;
    }
}