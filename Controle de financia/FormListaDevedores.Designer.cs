namespace Controle_de_financia2
{
    partial class FormListaDevedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaDevedores));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckboxTodos = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btDeletarselecionado = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btAlterar = new System.Windows.Forms.Button();
            this.btTransferirConta = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSomar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbAbrir = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbViewsPago = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbListViewTotalNaoPago = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPagos = new System.Windows.Forms.RadioButton();
            this.rbNaoPagos = new System.Windows.Forms.RadioButton();
            this.rbAtual = new System.Windows.Forms.RadioButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrir)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "loading-arrow.png");
            this.imageList2.Images.SetKeyName(1, "plus.png");
            this.imageList2.Images.SetKeyName(2, "save-file.png");
            this.imageList2.Images.SetKeyName(3, "financa.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.ckboxTodos);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.btDeletarselecionado);
            this.panel2.Controls.Add(this.btAlterar);
            this.panel2.Controls.Add(this.btTransferirConta);
            this.panel2.Location = new System.Drawing.Point(29, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 261);
            this.panel2.TabIndex = 44;
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
            this.listView1.Size = new System.Drawing.Size(758, 158);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
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
            this.btDeletarselecionado.ImageKey = "delete.png";
            this.btDeletarselecionado.ImageList = this.imageList3;
            this.btDeletarselecionado.Location = new System.Drawing.Point(22, 196);
            this.btDeletarselecionado.Name = "btDeletarselecionado";
            this.btDeletarselecionado.Size = new System.Drawing.Size(107, 44);
            this.btDeletarselecionado.TabIndex = 47;
            this.btDeletarselecionado.Text = "DELETAR";
            this.btDeletarselecionado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDeletarselecionado.UseVisualStyleBackColor = false;
            this.btDeletarselecionado.Click += new System.EventHandler(this.btDeletarselecionado_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "loading-arrow.png");
            this.imageList3.Images.SetKeyName(1, "plus.png");
            this.imageList3.Images.SetKeyName(2, "save-file.png");
            this.imageList3.Images.SetKeyName(3, "exchange.png");
            this.imageList3.Images.SetKeyName(4, "delete.png");
            this.imageList3.Images.SetKeyName(5, "back.png");
            this.imageList3.Images.SetKeyName(6, "logout.png");
            this.imageList3.Images.SetKeyName(7, "undo.png");
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
            this.btAlterar.ImageIndex = 2;
            this.btAlterar.ImageList = this.imageList3;
            this.btAlterar.Location = new System.Drawing.Point(264, 196);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(104, 44);
            this.btAlterar.TabIndex = 21;
            this.btAlterar.Text = "ALTERAR";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btTransferirConta
            // 
            this.btTransferirConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btTransferirConta.FlatAppearance.BorderSize = 0;
            this.btTransferirConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransferirConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransferirConta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTransferirConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTransferirConta.ImageKey = "exchange.png";
            this.btTransferirConta.ImageList = this.imageList3;
            this.btTransferirConta.Location = new System.Drawing.Point(134, 196);
            this.btTransferirConta.Name = "btTransferirConta";
            this.btTransferirConta.Size = new System.Drawing.Size(124, 44);
            this.btTransferirConta.TabIndex = 46;
            this.btTransferirConta.Text = "TRANSFERIR";
            this.btTransferirConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTransferirConta.UseVisualStyleBackColor = false;
            this.btTransferirConta.Click += new System.EventHandler(this.btTransferirConta_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pngegg (1).png");
            this.imageList1.Images.SetKeyName(1, "pngegg.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSomar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(20, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 89);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da lista";
            // 
            // lbSomar
            // 
            this.lbSomar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSomar.AutoSize = true;
            this.lbSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSomar.Location = new System.Drawing.Point(31, 43);
            this.lbSomar.Name = "lbSomar";
            this.lbSomar.Size = new System.Drawing.Size(44, 20);
            this.lbSomar.TabIndex = 33;
            this.lbSomar.Text = "0,00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "TOTAL NA LISTA:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.pbAbrir);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnVoltar);
            this.panel3.Controls.Add(this.btnAtualizar);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(29, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 157);
            this.panel3.TabIndex = 46;
            // 
            // pbAbrir
            // 
            this.pbAbrir.Image = global::Controle_de_financia2.Properties.Resources.pdf;
            this.pbAbrir.Location = new System.Drawing.Point(264, 18);
            this.pbAbrir.Name = "pbAbrir";
            this.pbAbrir.Size = new System.Drawing.Size(42, 50);
            this.pbAbrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbrir.TabIndex = 45;
            this.pbAbrir.TabStop = false;
            this.pbAbrir.Visible = false;
            this.pbAbrir.Click += new System.EventHandler(this.pbAbrir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.lbViewsPago);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbListViewTotalNaoPago);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(375, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 131);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(199, 21);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(193, 101);
            this.chart1.TabIndex = 47;
            this.chart1.Text = "chart1";
            // 
            // lbViewsPago
            // 
            this.lbViewsPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbViewsPago.AutoSize = true;
            this.lbViewsPago.BackColor = System.Drawing.Color.Transparent;
            this.lbViewsPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewsPago.ForeColor = System.Drawing.Color.Green;
            this.lbViewsPago.Location = new System.Drawing.Point(10, 43);
            this.lbViewsPago.Name = "lbViewsPago";
            this.lbViewsPago.Size = new System.Drawing.Size(44, 20);
            this.lbViewsPago.TabIndex = 46;
            this.lbViewsPago.Text = "0,00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "TOTAL NÃO PAGOS:";
            // 
            // lbListViewTotalNaoPago
            // 
            this.lbListViewTotalNaoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbListViewTotalNaoPago.AutoSize = true;
            this.lbListViewTotalNaoPago.BackColor = System.Drawing.Color.Transparent;
            this.lbListViewTotalNaoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListViewTotalNaoPago.ForeColor = System.Drawing.Color.Red;
            this.lbListViewTotalNaoPago.Location = new System.Drawing.Point(10, 102);
            this.lbListViewTotalNaoPago.Name = "lbListViewTotalNaoPago";
            this.lbListViewTotalNaoPago.Size = new System.Drawing.Size(44, 20);
            this.lbListViewTotalNaoPago.TabIndex = 44;
            this.lbListViewTotalNaoPago.Text = "0,00";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "TOTAL DE PAGAMENTO:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.ImageKey = "undo.png";
            this.btnVoltar.ImageList = this.imageList3;
            this.btnVoltar.Location = new System.Drawing.Point(22, 100);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 38);
            this.btnVoltar.TabIndex = 38;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.ImageKey = "loading-arrow.png";
            this.btnAtualizar.ImageList = this.imageList3;
            this.btnAtualizar.Location = new System.Drawing.Point(133, 100);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(115, 38);
            this.btnAtualizar.TabIndex = 39;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(33, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "Por nome:";
            // 
            // rbPagos
            // 
            this.rbPagos.AutoSize = true;
            this.rbPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPagos.ForeColor = System.Drawing.Color.Blue;
            this.rbPagos.Location = new System.Drawing.Point(455, 91);
            this.rbPagos.Name = "rbPagos";
            this.rbPagos.Size = new System.Drawing.Size(74, 22);
            this.rbPagos.TabIndex = 73;
            this.rbPagos.Text = "Pagos";
            this.rbPagos.UseVisualStyleBackColor = true;
            this.rbPagos.CheckedChanged += new System.EventHandler(this.rbPagos_CheckedChanged);
            // 
            // rbNaoPagos
            // 
            this.rbNaoPagos.AutoSize = true;
            this.rbNaoPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbNaoPagos.Location = new System.Drawing.Point(535, 91);
            this.rbNaoPagos.Name = "rbNaoPagos";
            this.rbNaoPagos.Size = new System.Drawing.Size(108, 22);
            this.rbNaoPagos.TabIndex = 74;
            this.rbNaoPagos.Text = "Não pagos";
            this.rbNaoPagos.UseVisualStyleBackColor = true;
            this.rbNaoPagos.CheckedChanged += new System.EventHandler(this.rbNaoPagos_CheckedChanged);
            // 
            // rbAtual
            // 
            this.rbAtual.AutoSize = true;
            this.rbAtual.Checked = true;
            this.rbAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtual.ForeColor = System.Drawing.Color.Blue;
            this.rbAtual.Location = new System.Drawing.Point(649, 93);
            this.rbAtual.Name = "rbAtual";
            this.rbAtual.Size = new System.Drawing.Size(63, 22);
            this.rbAtual.TabIndex = 75;
            this.rbAtual.TabStop = true;
            this.rbAtual.Text = "Atual";
            this.rbAtual.UseVisualStyleBackColor = true;
            this.rbAtual.CheckedChanged += new System.EventHandler(this.rbAtual_CheckedChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbSearch.Location = new System.Drawing.Point(36, 87);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(161, 26);
            this.tbSearch.TabIndex = 78;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            "2028"});
            this.cbAno.Location = new System.Drawing.Point(215, 87);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(81, 28);
            this.cbAno.TabIndex = 79;
            this.cbAno.SelectedIndexChanged += new System.EventHandler(this.cbAno_SelectedIndexChanged);
            this.cbAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAno_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(212, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 80;
            this.label6.Text = "Por ano:";
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
            this.cbMes.Location = new System.Drawing.Point(314, 87);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(117, 28);
            this.cbMes.TabIndex = 81;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            this.cbMes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbMes_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(311, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 82;
            this.label9.Text = "Por mês";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbMes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbAno);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.rbAtual);
            this.panel1.Controls.Add(this.rbNaoPagos);
            this.panel1.Controls.Add(this.rbPagos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(29, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 164);
            this.panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_financia2.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(36, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.ImageKey = "financa.png";
            this.label5.ImageList = this.imageList2;
            this.label5.Location = new System.Drawing.Point(241, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 37);
            this.label5.TabIndex = 68;
            this.label5.Text = "LISTA DE DEVEDORES";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "pdf.png");
            // 
            // FormListaDevedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(860, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaDevedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTA DE DEVEDORES";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckboxTodos;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btDeletarselecionado;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btTransferirConta;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbSomar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbViewsPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbListViewTotalNaoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPagos;
        private System.Windows.Forms.RadioButton rbNaoPagos;
        private System.Windows.Forms.RadioButton rbAtual;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.PictureBox pbAbrir;
    }
}