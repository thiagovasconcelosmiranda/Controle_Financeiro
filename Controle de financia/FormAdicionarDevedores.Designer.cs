namespace Controle_de_financia2
{
    partial class FormAdicionarDevedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarDevedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbAddParc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEstabeleciemnto = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.panelEstabelecimento = new System.Windows.Forms.Panel();
            this.lbErrorEstabelecimento = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEstabelecimento = new System.Windows.Forms.TextBox();
            this.panelNomeSobrenome = new System.Windows.Forms.Panel();
            this.lbErrorSobrenome = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.lbErrorNome = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbFileOk = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ptAddUpload = new System.Windows.Forms.PictureBox();
            this.lbErrorValorDevedor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbCnpj = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.mtAddCnpj = new System.Windows.Forms.MaskedTextBox();
            this.mtAddCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbErrorOption = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mtAddDataOperacional = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbAddValor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAddAnoReferencia = new System.Windows.Forms.ComboBox();
            this.cbAddMesReferencia = new System.Windows.Forms.ComboBox();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbAddDescricao = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelEstabelecimento.SuspendLayout();
            this.panelNomeSobrenome.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAddUpload)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.rbEstabeleciemnto);
            this.panel1.Controls.Add(this.rbUsuario);
            this.panel1.Controls.Add(this.panelEstabelecimento);
            this.panel1.Controls.Add(this.panelNomeSobrenome);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lbErrorValorDevedor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbAddValor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnVoltar2);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 591);
            this.panel1.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbAddParc);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(258, 327);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 82);
            this.panel6.TabIndex = 122;
            // 
            // cbAddParc
            // 
            this.cbAddParc.FormattingEnabled = true;
            this.cbAddParc.Items.AddRange(new object[] {
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
            this.cbAddParc.Location = new System.Drawing.Point(24, 35);
            this.cbAddParc.Name = "cbAddParc";
            this.cbAddParc.Size = new System.Drawing.Size(54, 24);
            this.cbAddParc.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Parcelas";
            // 
            // rbEstabeleciemnto
            // 
            this.rbEstabeleciemnto.AutoSize = true;
            this.rbEstabeleciemnto.ForeColor = System.Drawing.Color.Blue;
            this.rbEstabeleciemnto.Location = new System.Drawing.Point(359, 176);
            this.rbEstabeleciemnto.Name = "rbEstabeleciemnto";
            this.rbEstabeleciemnto.Size = new System.Drawing.Size(141, 20);
            this.rbEstabeleciemnto.TabIndex = 105;
            this.rbEstabeleciemnto.Text = "Estabelecimento";
            this.rbEstabeleciemnto.UseVisualStyleBackColor = true;
            this.rbEstabeleciemnto.CheckedChanged += new System.EventHandler(this.rbEstabeleciemnto_CheckedChanged);
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Checked = true;
            this.rbUsuario.ForeColor = System.Drawing.Color.Blue;
            this.rbUsuario.Location = new System.Drawing.Point(359, 150);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(79, 20);
            this.rbUsuario.TabIndex = 104;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            this.rbUsuario.CheckedChanged += new System.EventHandler(this.rbUsuario_CheckedChanged);
            // 
            // panelEstabelecimento
            // 
            this.panelEstabelecimento.Controls.Add(this.lbErrorEstabelecimento);
            this.panelEstabelecimento.Controls.Add(this.label16);
            this.panelEstabelecimento.Controls.Add(this.tbEstabelecimento);
            this.panelEstabelecimento.Enabled = false;
            this.panelEstabelecimento.Location = new System.Drawing.Point(20, 136);
            this.panelEstabelecimento.Name = "panelEstabelecimento";
            this.panelEstabelecimento.Size = new System.Drawing.Size(324, 72);
            this.panelEstabelecimento.TabIndex = 103;
            // 
            // lbErrorEstabelecimento
            // 
            this.lbErrorEstabelecimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorEstabelecimento.AutoSize = true;
            this.lbErrorEstabelecimento.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEstabelecimento.Location = new System.Drawing.Point(15, 52);
            this.lbErrorEstabelecimento.Name = "lbErrorEstabelecimento";
            this.lbErrorEstabelecimento.Size = new System.Drawing.Size(158, 16);
            this.lbErrorEstabelecimento.TabIndex = 96;
            this.lbErrorEstabelecimento.Text = "Campos obrigaórios *";
            this.lbErrorEstabelecimento.Visible = false;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(10, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 16);
            this.label16.TabIndex = 95;
            this.label16.Text = "Estabelecimento";
            // 
            // tbEstabelecimento
            // 
            this.tbEstabelecimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEstabelecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstabelecimento.Location = new System.Drawing.Point(13, 26);
            this.tbEstabelecimento.Name = "tbEstabelecimento";
            this.tbEstabelecimento.Size = new System.Drawing.Size(292, 23);
            this.tbEstabelecimento.TabIndex = 94;
            // 
            // panelNomeSobrenome
            // 
            this.panelNomeSobrenome.Controls.Add(this.lbErrorSobrenome);
            this.panelNomeSobrenome.Controls.Add(this.label12);
            this.panelNomeSobrenome.Controls.Add(this.tbSobrenome);
            this.panelNomeSobrenome.Controls.Add(this.lbErrorNome);
            this.panelNomeSobrenome.Controls.Add(this.label14);
            this.panelNomeSobrenome.Controls.Add(this.tbNome);
            this.panelNomeSobrenome.Location = new System.Drawing.Point(20, 58);
            this.panelNomeSobrenome.Name = "panelNomeSobrenome";
            this.panelNomeSobrenome.Size = new System.Drawing.Size(473, 72);
            this.panelNomeSobrenome.TabIndex = 102;
            // 
            // lbErrorSobrenome
            // 
            this.lbErrorSobrenome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorSobrenome.AutoSize = true;
            this.lbErrorSobrenome.ForeColor = System.Drawing.Color.Red;
            this.lbErrorSobrenome.Location = new System.Drawing.Point(233, 52);
            this.lbErrorSobrenome.Name = "lbErrorSobrenome";
            this.lbErrorSobrenome.Size = new System.Drawing.Size(158, 16);
            this.lbErrorSobrenome.TabIndex = 99;
            this.lbErrorSobrenome.Text = "Campos obrigaórios *";
            this.lbErrorSobrenome.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(233, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 98;
            this.label12.Text = "Sobrenome:";
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSobrenome.Location = new System.Drawing.Point(236, 26);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(226, 23);
            this.tbSobrenome.TabIndex = 97;
            // 
            // lbErrorNome
            // 
            this.lbErrorNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorNome.AutoSize = true;
            this.lbErrorNome.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNome.Location = new System.Drawing.Point(15, 52);
            this.lbErrorNome.Name = "lbErrorNome";
            this.lbErrorNome.Size = new System.Drawing.Size(158, 16);
            this.lbErrorNome.TabIndex = 96;
            this.lbErrorNome.Text = "Campos obrigaórios *";
            this.lbErrorNome.Visible = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(10, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 95;
            this.label14.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(13, 26);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(195, 23);
            this.tbNome.TabIndex = 94;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbFileOk);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.ptAddUpload);
            this.panel5.Location = new System.Drawing.Point(282, 467);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(211, 110);
            this.panel5.TabIndex = 101;
            // 
            // lbFileOk
            // 
            this.lbFileOk.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbFileOk.ForeColor = System.Drawing.Color.Green;
            this.lbFileOk.Location = new System.Drawing.Point(6, 87);
            this.lbFileOk.Name = "lbFileOk";
            this.lbFileOk.Size = new System.Drawing.Size(205, 16);
            this.lbFileOk.TabIndex = 75;
            this.lbFileOk.Text = "Aqruivo Selecionado";
            this.lbFileOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFileOk.Visible = false;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(7, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Salvar comprovantes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptAddUpload
            // 
            this.ptAddUpload.Image = global::Controle_de_financia2.Properties.Resources.upload;
            this.ptAddUpload.Location = new System.Drawing.Point(88, 29);
            this.ptAddUpload.Name = "ptAddUpload";
            this.ptAddUpload.Size = new System.Drawing.Size(46, 49);
            this.ptAddUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAddUpload.TabIndex = 0;
            this.ptAddUpload.TabStop = false;
            this.ptAddUpload.Click += new System.EventHandler(this.ptAddUpload_Click);
            // 
            // lbErrorValorDevedor
            // 
            this.lbErrorValorDevedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorValorDevedor.AutoSize = true;
            this.lbErrorValorDevedor.ForeColor = System.Drawing.Color.Red;
            this.lbErrorValorDevedor.Location = new System.Drawing.Point(27, 510);
            this.lbErrorValorDevedor.Name = "lbErrorValorDevedor";
            this.lbErrorValorDevedor.Size = new System.Drawing.Size(158, 16);
            this.lbErrorValorDevedor.TabIndex = 100;
            this.lbErrorValorDevedor.Text = "Campos obrigaórios *";
            this.lbErrorValorDevedor.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbCnpj);
            this.panel3.Controls.Add(this.rbCpf);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.mtAddCnpj);
            this.panel3.Controls.Add(this.mtAddCpf);
            this.panel3.Controls.Add(this.lbErrorOption);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(20, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 99);
            this.panel3.TabIndex = 99;
            // 
            // rbCnpj
            // 
            this.rbCnpj.AutoSize = true;
            this.rbCnpj.ForeColor = System.Drawing.Color.Blue;
            this.rbCnpj.Location = new System.Drawing.Point(67, 3);
            this.rbCnpj.Name = "rbCnpj";
            this.rbCnpj.Size = new System.Drawing.Size(64, 20);
            this.rbCnpj.TabIndex = 191;
            this.rbCnpj.Text = "CNPJ";
            this.rbCnpj.UseVisualStyleBackColor = true;
            this.rbCnpj.CheckedChanged += new System.EventHandler(this.rbCnpj_CheckedChanged_1);
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Checked = true;
            this.rbCpf.ForeColor = System.Drawing.Color.Blue;
            this.rbCpf.Location = new System.Drawing.Point(10, 3);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(54, 20);
            this.rbCpf.TabIndex = 190;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "CPF";
            this.rbCpf.UseVisualStyleBackColor = true;
            this.rbCpf.CheckedChanged += new System.EventHandler(this.rbCpf_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(288, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 90;
            this.label9.Text = "CNPJ:";
            // 
            // mtAddCnpj
            // 
            this.mtAddCnpj.Enabled = false;
            this.mtAddCnpj.Location = new System.Drawing.Point(291, 54);
            this.mtAddCnpj.Mask = "00.000.000/0000-00";
            this.mtAddCnpj.Name = "mtAddCnpj";
            this.mtAddCnpj.Size = new System.Drawing.Size(162, 22);
            this.mtAddCnpj.TabIndex = 184;
            this.mtAddCnpj.ValidatingType = typeof(System.DateTime);
            // 
            // mtAddCpf
            // 
            this.mtAddCpf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtAddCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtAddCpf.Location = new System.Drawing.Point(14, 53);
            this.mtAddCpf.Mask = "000.000.000-00";
            this.mtAddCpf.Name = "mtAddCpf";
            this.mtAddCpf.Size = new System.Drawing.Size(117, 23);
            this.mtAddCpf.TabIndex = 89;
            this.mtAddCpf.ValidatingType = typeof(System.DateTime);
            // 
            // lbErrorOption
            // 
            this.lbErrorOption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorOption.AutoSize = true;
            this.lbErrorOption.ForeColor = System.Drawing.Color.Red;
            this.lbErrorOption.Location = new System.Drawing.Point(11, 79);
            this.lbErrorOption.Name = "lbErrorOption";
            this.lbErrorOption.Size = new System.Drawing.Size(164, 16);
            this.lbErrorOption.TabIndex = 88;
            this.lbErrorOption.Text = "Selecione uma opção*";
            this.lbErrorOption.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(11, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "CPF:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.mtAddDataOperacional);
            this.panel4.Controls.Add(this.label3);
            this.panel4.ForeColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(20, 327);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 113);
            this.panel4.TabIndex = 98;
            // 
            // mtAddDataOperacional
            // 
            this.mtAddDataOperacional.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtAddDataOperacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtAddDataOperacional.Location = new System.Drawing.Point(13, 44);
            this.mtAddDataOperacional.Mask = "00/00/0000";
            this.mtAddDataOperacional.Name = "mtAddDataOperacional";
            this.mtAddDataOperacional.Size = new System.Drawing.Size(162, 23);
            this.mtAddDataOperacional.TabIndex = 96;
            this.mtAddDataOperacional.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 95;
            this.label3.Text = "Data de vencimento:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.ImageKey = "financa.png";
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(144, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 48);
            this.label7.TabIndex = 96;
            this.label7.Text = "NOVO DEVEDOR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "financa.png");
            // 
            // tbAddValor
            // 
            this.tbAddValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddValor.Location = new System.Drawing.Point(30, 484);
            this.tbAddValor.Name = "tbAddValor";
            this.tbAddValor.Size = new System.Drawing.Size(200, 23);
            this.tbAddValor.TabIndex = 87;
            this.tbAddValor.TextChanged += new System.EventHandler(this.tbAddValor_TextChanged);
            this.tbAddValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddValor_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbAddAnoReferencia);
            this.panel2.Controls.Add(this.cbAddMesReferencia);
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(374, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 113);
            this.panel2.TabIndex = 95;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Ano:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Mês:";
            // 
            // cbAddAnoReferencia
            // 
            this.cbAddAnoReferencia.FormattingEnabled = true;
            this.cbAddAnoReferencia.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cbAddAnoReferencia.Location = new System.Drawing.Point(34, 76);
            this.cbAddAnoReferencia.Name = "cbAddAnoReferencia";
            this.cbAddAnoReferencia.Size = new System.Drawing.Size(59, 24);
            this.cbAddAnoReferencia.TabIndex = 1;
            this.cbAddAnoReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAddAnoReferencia_KeyPress);
            // 
            // cbAddMesReferencia
            // 
            this.cbAddMesReferencia.FormattingEnabled = true;
            this.cbAddMesReferencia.Items.AddRange(new object[] {
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
            this.cbAddMesReferencia.Location = new System.Drawing.Point(34, 25);
            this.cbAddMesReferencia.Name = "cbAddMesReferencia";
            this.cbAddMesReferencia.Size = new System.Drawing.Size(59, 24);
            this.cbAddMesReferencia.TabIndex = 0;
            this.cbAddMesReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAddMesReferencia_KeyPress);
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar2.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar2.ImageKey = "undo.png";
            this.btnVoltar2.ImageList = this.imageList2;
            this.btnVoltar2.Location = new System.Drawing.Point(30, 540);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(102, 37);
            this.btnVoltar2.TabIndex = 92;
            this.btnVoltar2.Text = "VOLTAR";
            this.btnVoltar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar2.UseVisualStyleBackColor = false;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "undo.png");
            this.imageList2.Images.SetKeyName(1, "lucro-financeiro.png");
            this.imageList2.Images.SetKeyName(2, "plus.png");
            this.imageList2.Images.SetKeyName(3, "save-file.png");
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.BackColor = System.Drawing.Color.Green;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.ImageKey = "save-file.png";
            this.btnAdicionar.ImageList = this.imageList2;
            this.btnAdicionar.Location = new System.Drawing.Point(138, 540);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(95, 37);
            this.btnAdicionar.TabIndex = 91;
            this.btnAdicionar.Text = "SALVAR";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(30, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Valor:";
            // 
            // rtbAddDescricao
            // 
            this.rtbAddDescricao.Location = new System.Drawing.Point(542, 51);
            this.rtbAddDescricao.Name = "rtbAddDescricao";
            this.rtbAddDescricao.Size = new System.Drawing.Size(333, 558);
            this.rtbAddDescricao.TabIndex = 20;
            this.rtbAddDescricao.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(539, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 18);
            this.label5.TabIndex = 121;
            this.label5.Text = "Descrição (Opicional)\r\n";
            // 
            // FormAdicionarDevedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(898, 624);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbAddDescricao);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdicionarDevedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADICINAR DEVEDOR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelEstabelecimento.ResumeLayout(false);
            this.panelEstabelecimento.PerformLayout();
            this.panelNomeSobrenome.ResumeLayout(false);
            this.panelNomeSobrenome.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptAddUpload)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAddValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAddAnoReferencia;
        private System.Windows.Forms.ComboBox cbAddMesReferencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox mtAddDataOperacional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox mtAddCpf;
        private System.Windows.Forms.Label lbErrorOption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtAddCnpj;
        private System.Windows.Forms.RadioButton rbCnpj;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.Label lbErrorValorDevedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbFileOk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox ptAddUpload;
        private System.Windows.Forms.Panel panelNomeSobrenome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Panel panelEstabelecimento;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEstabelecimento;
        private System.Windows.Forms.RadioButton rbEstabeleciemnto;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.Label lbErrorEstabelecimento;
        private System.Windows.Forms.Label lbErrorSobrenome;
        private System.Windows.Forms.Label lbErrorNome;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbAddParc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAddDescricao;
        private System.Windows.Forms.Label label5;
    }
}