namespace Controle_de_financia2
{
    partial class formAuthAdicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAuthAdicionar));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbAddEstabelecimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbErrorEstabelecimento = new System.Windows.Forms.Label();
            this.lbErrorConta = new System.Windows.Forms.Label();
            this.lbErrorValorDevedor = new System.Windows.Forms.Label();
            this.cbAddTipoConta = new System.Windows.Forms.ComboBox();
            this.cbMaiusculo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAddYearReference = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAddMonthReference = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtAddDataVenc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbParcela = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbDescricaoConta = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbFileOk = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ptAddUpload = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.rtbAddDescricao = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescricaoConta)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAddUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "human.png");
            this.imageList2.Images.SetKeyName(1, "salvar.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "report.png");
            this.imageList1.Images.SetKeyName(1, "human.png");
            this.imageList1.Images.SetKeyName(2, "salvar.png");
            this.imageList1.Images.SetKeyName(3, "financa.png");
            // 
            // tbAddEstabelecimento
            // 
            this.tbAddEstabelecimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddEstabelecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddEstabelecimento.Location = new System.Drawing.Point(35, 88);
            this.tbAddEstabelecimento.Name = "tbAddEstabelecimento";
            this.tbAddEstabelecimento.Size = new System.Drawing.Size(445, 23);
            this.tbAddEstabelecimento.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Estabelecimento";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(32, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tipo de conta";
            // 
            // tbAddValor
            // 
            this.tbAddValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAddValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddValor.Location = new System.Drawing.Point(41, 324);
            this.tbAddValor.Name = "tbAddValor";
            this.tbAddValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAddValor.Size = new System.Drawing.Size(119, 23);
            this.tbAddValor.TabIndex = 72;
            this.tbAddValor.TextChanged += new System.EventHandler(this.tbAddValor_TextChanged_1);
            this.tbAddValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddValor_KeyPress_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(38, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Valor:";
            // 
            // lbErrorEstabelecimento
            // 
            this.lbErrorEstabelecimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorEstabelecimento.AutoSize = true;
            this.lbErrorEstabelecimento.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEstabelecimento.Location = new System.Drawing.Point(32, 114);
            this.lbErrorEstabelecimento.Name = "lbErrorEstabelecimento";
            this.lbErrorEstabelecimento.Size = new System.Drawing.Size(158, 16);
            this.lbErrorEstabelecimento.TabIndex = 74;
            this.lbErrorEstabelecimento.Text = "Campos obrigaórios *";
            this.lbErrorEstabelecimento.Visible = false;
            // 
            // lbErrorConta
            // 
            this.lbErrorConta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorConta.AutoSize = true;
            this.lbErrorConta.ForeColor = System.Drawing.Color.Red;
            this.lbErrorConta.Location = new System.Drawing.Point(34, 181);
            this.lbErrorConta.Name = "lbErrorConta";
            this.lbErrorConta.Size = new System.Drawing.Size(158, 16);
            this.lbErrorConta.TabIndex = 75;
            this.lbErrorConta.Text = "Campos obrigaórios *";
            this.lbErrorConta.Visible = false;
            // 
            // lbErrorValorDevedor
            // 
            this.lbErrorValorDevedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorValorDevedor.AutoSize = true;
            this.lbErrorValorDevedor.ForeColor = System.Drawing.Color.Red;
            this.lbErrorValorDevedor.Location = new System.Drawing.Point(34, 350);
            this.lbErrorValorDevedor.Name = "lbErrorValorDevedor";
            this.lbErrorValorDevedor.Size = new System.Drawing.Size(158, 16);
            this.lbErrorValorDevedor.TabIndex = 77;
            this.lbErrorValorDevedor.Text = "Campos obrigaórios *";
            this.lbErrorValorDevedor.Visible = false;
            // 
            // cbAddTipoConta
            // 
            this.cbAddTipoConta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAddTipoConta.FormattingEnabled = true;
            this.cbAddTipoConta.Items.AddRange(new object[] {
            "",
            "PIX",
            "BOLETO BANCÁRIO",
            "NOTA PROMISSÓRIA",
            "FIADO",
            "CARTÃO DE CREDITO",
            "CARNÊ",
            "DÉBITO AUTOMÁTICO",
            "EM DINHEIRO",
            "CATÃO DE DÉBITO"});
            this.cbAddTipoConta.Location = new System.Drawing.Point(35, 154);
            this.cbAddTipoConta.Name = "cbAddTipoConta";
            this.cbAddTipoConta.Size = new System.Drawing.Size(198, 24);
            this.cbAddTipoConta.TabIndex = 79;
            this.cbAddTipoConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAddTipoConta_KeyPress_1);
            // 
            // cbMaiusculo
            // 
            this.cbMaiusculo.AutoSize = true;
            this.cbMaiusculo.ForeColor = System.Drawing.Color.Blue;
            this.cbMaiusculo.Location = new System.Drawing.Point(352, 62);
            this.cbMaiusculo.Name = "cbMaiusculo";
            this.cbMaiusculo.Size = new System.Drawing.Size(131, 20);
            this.cbMaiusculo.TabIndex = 80;
            this.cbMaiusculo.Text = "Texto Maículos";
            this.cbMaiusculo.UseVisualStyleBackColor = true;
            this.cbMaiusculo.CheckedChanged += new System.EventHandler(this.cbMaiusculo_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbAddYearReference);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbAddMonthReference);
            this.groupBox2.Location = new System.Drawing.Point(389, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 128);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(10, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ano ";
            // 
            // cbAddYearReference
            // 
            this.cbAddYearReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddYearReference.FormattingEnabled = true;
            this.cbAddYearReference.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cbAddYearReference.Location = new System.Drawing.Point(12, 97);
            this.cbAddYearReference.Name = "cbAddYearReference";
            this.cbAddYearReference.Size = new System.Drawing.Size(60, 25);
            this.cbAddYearReference.TabIndex = 53;
            this.cbAddYearReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAddYearReference_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Mês";
            // 
            // cbAddMonthReference
            // 
            this.cbAddMonthReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddMonthReference.FormattingEnabled = true;
            this.cbAddMonthReference.Items.AddRange(new object[] {
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
            this.cbAddMonthReference.Location = new System.Drawing.Point(13, 31);
            this.cbAddMonthReference.Name = "cbAddMonthReference";
            this.cbAddMonthReference.Size = new System.Drawing.Size(59, 25);
            this.cbAddMonthReference.TabIndex = 51;
            this.cbAddMonthReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAddMonthReference_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mtAddDataVenc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(35, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 75);
            this.panel2.TabIndex = 87;
            // 
            // mtAddDataVenc
            // 
            this.mtAddDataVenc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtAddDataVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtAddDataVenc.Location = new System.Drawing.Point(11, 29);
            this.mtAddDataVenc.Mask = "00/00/0000";
            this.mtAddDataVenc.Name = "mtAddDataVenc";
            this.mtAddDataVenc.Size = new System.Drawing.Size(82, 23);
            this.mtAddDataVenc.TabIndex = 80;
            this.mtAddDataVenc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Data vencimento:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnVoltar2);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.cbMaiusculo);
            this.panel1.Controls.Add(this.cbAddTipoConta);
            this.panel1.Controls.Add(this.lbErrorValorDevedor);
            this.panel1.Controls.Add(this.lbErrorConta);
            this.panel1.Controls.Add(this.lbErrorEstabelecimento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbAddValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbAddEstabelecimento);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(22, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 425);
            this.panel1.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbParcela);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(274, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 82);
            this.panel5.TabIndex = 90;
            // 
            // cbParcela
            // 
            this.cbParcela.FormattingEnabled = true;
            this.cbParcela.Items.AddRange(new object[] {
            "1X",
            "2X",
            "3X",
            "4X",
            "5X",
            "6X",
            "7X",
            "8X",
            "9X",
            "10X"});
            this.cbParcela.Location = new System.Drawing.Point(24, 35);
            this.cbParcela.Name = "cbParcela";
            this.cbParcela.Size = new System.Drawing.Size(54, 24);
            this.cbParcela.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(15, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 74;
            this.label10.Text = "Parcelas";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pbDescricaoConta);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(274, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 66);
            this.panel4.TabIndex = 89;
            // 
            // pbDescricaoConta
            // 
            this.pbDescricaoConta.Image = global::Controle_de_financia2.Properties.Resources.descricao;
            this.pbDescricaoConta.Location = new System.Drawing.Point(87, 23);
            this.pbDescricaoConta.Name = "pbDescricaoConta";
            this.pbDescricaoConta.Size = new System.Drawing.Size(29, 31);
            this.pbDescricaoConta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDescricaoConta.TabIndex = 77;
            this.pbDescricaoConta.TabStop = false;
            this.pbDescricaoConta.Click += new System.EventHandler(this.pbDescricaoConta_Click);
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(6, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 16);
            this.label9.TabIndex = 76;
            this.label9.Text = "Descrição (opcional)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbFileOk);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.ptAddUpload);
            this.panel3.Location = new System.Drawing.Point(274, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 100);
            this.panel3.TabIndex = 88;
            // 
            // lbFileOk
            // 
            this.lbFileOk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFileOk.ForeColor = System.Drawing.Color.Green;
            this.lbFileOk.Location = new System.Drawing.Point(3, 72);
            this.lbFileOk.Name = "lbFileOk";
            this.lbFileOk.Size = new System.Drawing.Size(194, 16);
            this.lbFileOk.TabIndex = 75;
            this.lbFileOk.Text = "Aqruivo Selecionado";
            this.lbFileOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFileOk.Visible = false;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Salvar comprovantes";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptAddUpload
            // 
            this.ptAddUpload.Image = global::Controle_de_financia2.Properties.Resources.upload;
            this.ptAddUpload.Location = new System.Drawing.Point(88, 30);
            this.ptAddUpload.Name = "ptAddUpload";
            this.ptAddUpload.Size = new System.Drawing.Size(37, 39);
            this.ptAddUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAddUpload.TabIndex = 0;
            this.ptAddUpload.TabStop = false;
            this.ptAddUpload.Click += new System.EventHandler(this.ptAddUpload_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.ImageKey = "financa.png";
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(165, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 50);
            this.label5.TabIndex = 86;
            this.label5.Text = "NOVA CONTA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar2.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar2.ImageKey = "human.png";
            this.btnVoltar2.ImageList = this.imageList2;
            this.btnVoltar2.Location = new System.Drawing.Point(25, 383);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(98, 37);
            this.btnVoltar2.TabIndex = 85;
            this.btnVoltar2.Text = "VOLTAR";
            this.btnVoltar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar2.UseVisualStyleBackColor = false;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click_2);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.ImageKey = "salvar.png";
            this.btnAdicionar.ImageList = this.imageList2;
            this.btnAdicionar.Location = new System.Drawing.Point(141, 383);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(92, 37);
            this.btnAdicionar.TabIndex = 84;
            this.btnAdicionar.Text = "SALVAR";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(562, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 18);
            this.label11.TabIndex = 120;
            this.label11.Text = "Descrição (Opicional)\r\n";
            // 
            // rtbAddDescricao
            // 
            this.rtbAddDescricao.Location = new System.Drawing.Point(565, 46);
            this.rtbAddDescricao.Name = "rtbAddDescricao";
            this.rtbAddDescricao.Size = new System.Drawing.Size(323, 402);
            this.rtbAddDescricao.TabIndex = 119;
            this.rtbAddDescricao.Text = "";
            // 
            // formAuthAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(910, 464);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rtbAddDescricao);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAuthAdicionar";
            this.Text = "NOVACONTA";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDescricaoConta)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptAddUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TextBox tbAddEstabelecimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbErrorEstabelecimento;
        private System.Windows.Forms.Label lbErrorConta;
        private System.Windows.Forms.Label lbErrorValorDevedor;
        private System.Windows.Forms.ComboBox cbAddTipoConta;
        private System.Windows.Forms.CheckBox cbMaiusculo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAddYearReference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAddMonthReference;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mtAddDataVenc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox ptAddUpload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbFileOk;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbDescricaoConta;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbParcela;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtbAddDescricao;
    }
}