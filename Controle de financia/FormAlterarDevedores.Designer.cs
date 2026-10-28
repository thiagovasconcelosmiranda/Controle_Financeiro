namespace Controle_de_financia2
{
    partial class FormAlterarDevedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarDevedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbAlterParc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbEstabelecimento = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.panelEstabelecimento = new System.Windows.Forms.Panel();
            this.lbErrorEstabelecimento = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAlterEstabelecimento = new System.Windows.Forms.TextBox();
            this.panelNomeSobrenome = new System.Windows.Forms.Panel();
            this.lbErrorSobrenome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAlterarSobrenome = new System.Windows.Forms.TextBox();
            this.lbErrorNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAlterNome = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ptAlterUpload = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mtAlteraDataOperacional = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbAlteraStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAlteraAnoReferencia = new System.Windows.Forms.ComboBox();
            this.cbAlteraMesReferencia = new System.Windows.Forms.ComboBox();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnAlterar = new System.Windows.Forms.Button();
            this.tbAlteraValor = new System.Windows.Forms.TextBox();
            this.lbErrorValor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rtbAlterDescricao = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelEstabelecimento.SuspendLayout();
            this.panelNomeSobrenome.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAlterUpload)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.rbEstabelecimento);
            this.panel1.Controls.Add(this.rbUsuario);
            this.panel1.Controls.Add(this.panelEstabelecimento);
            this.panel1.Controls.Add(this.panelNomeSobrenome);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnVoltar2);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.tbAlteraValor);
            this.panel1.Controls.Add(this.lbErrorValor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 532);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbAlterParc);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(280, 361);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 82);
            this.panel5.TabIndex = 121;
            // 
            // cbAlterParc
            // 
            this.cbAlterParc.FormattingEnabled = true;
            this.cbAlterParc.Items.AddRange(new object[] {
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
            this.cbAlterParc.Location = new System.Drawing.Point(18, 35);
            this.cbAlterParc.Name = "cbAlterParc";
            this.cbAlterParc.Size = new System.Drawing.Size(60, 24);
            this.cbAlterParc.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(15, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Parcelas";
            // 
            // rbEstabelecimento
            // 
            this.rbEstabelecimento.AutoSize = true;
            this.rbEstabelecimento.ForeColor = System.Drawing.Color.Blue;
            this.rbEstabelecimento.Location = new System.Drawing.Point(343, 230);
            this.rbEstabelecimento.Name = "rbEstabelecimento";
            this.rbEstabelecimento.Size = new System.Drawing.Size(141, 20);
            this.rbEstabelecimento.TabIndex = 120;
            this.rbEstabelecimento.Text = "Estabelecimento";
            this.rbEstabelecimento.UseVisualStyleBackColor = true;
            this.rbEstabelecimento.CheckedChanged += new System.EventHandler(this.rbEstabelecimento_CheckedChanged);
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Checked = true;
            this.rbUsuario.ForeColor = System.Drawing.Color.Blue;
            this.rbUsuario.Location = new System.Drawing.Point(343, 199);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(79, 20);
            this.rbUsuario.TabIndex = 119;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            this.rbUsuario.CheckedChanged += new System.EventHandler(this.rbUsuario_CheckedChanged);
            // 
            // panelEstabelecimento
            // 
            this.panelEstabelecimento.Controls.Add(this.lbErrorEstabelecimento);
            this.panelEstabelecimento.Controls.Add(this.label13);
            this.panelEstabelecimento.Controls.Add(this.tbAlterEstabelecimento);
            this.panelEstabelecimento.Enabled = false;
            this.panelEstabelecimento.Location = new System.Drawing.Point(15, 171);
            this.panelEstabelecimento.Name = "panelEstabelecimento";
            this.panelEstabelecimento.Size = new System.Drawing.Size(311, 100);
            this.panelEstabelecimento.TabIndex = 118;
            // 
            // lbErrorEstabelecimento
            // 
            this.lbErrorEstabelecimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorEstabelecimento.AutoSize = true;
            this.lbErrorEstabelecimento.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEstabelecimento.Location = new System.Drawing.Point(28, 63);
            this.lbErrorEstabelecimento.Name = "lbErrorEstabelecimento";
            this.lbErrorEstabelecimento.Size = new System.Drawing.Size(158, 16);
            this.lbErrorEstabelecimento.TabIndex = 114;
            this.lbErrorEstabelecimento.Text = "Campos obrigaórios *";
            this.lbErrorEstabelecimento.Visible = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(28, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 16);
            this.label13.TabIndex = 113;
            this.label13.Text = "Estabelecimento:";
            // 
            // tbAlterEstabelecimento
            // 
            this.tbAlterEstabelecimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlterEstabelecimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlterEstabelecimento.Location = new System.Drawing.Point(27, 37);
            this.tbAlterEstabelecimento.Name = "tbAlterEstabelecimento";
            this.tbAlterEstabelecimento.Size = new System.Drawing.Size(258, 23);
            this.tbAlterEstabelecimento.TabIndex = 112;
            // 
            // panelNomeSobrenome
            // 
            this.panelNomeSobrenome.Controls.Add(this.lbErrorSobrenome);
            this.panelNomeSobrenome.Controls.Add(this.label5);
            this.panelNomeSobrenome.Controls.Add(this.tbAlterarSobrenome);
            this.panelNomeSobrenome.Controls.Add(this.lbErrorNome);
            this.panelNomeSobrenome.Controls.Add(this.label1);
            this.panelNomeSobrenome.Controls.Add(this.tbAlterNome);
            this.panelNomeSobrenome.Location = new System.Drawing.Point(15, 65);
            this.panelNomeSobrenome.Name = "panelNomeSobrenome";
            this.panelNomeSobrenome.Size = new System.Drawing.Size(474, 100);
            this.panelNomeSobrenome.TabIndex = 116;
            // 
            // lbErrorSobrenome
            // 
            this.lbErrorSobrenome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorSobrenome.AutoSize = true;
            this.lbErrorSobrenome.ForeColor = System.Drawing.Color.Red;
            this.lbErrorSobrenome.Location = new System.Drawing.Point(258, 63);
            this.lbErrorSobrenome.Name = "lbErrorSobrenome";
            this.lbErrorSobrenome.Size = new System.Drawing.Size(158, 16);
            this.lbErrorSobrenome.TabIndex = 117;
            this.lbErrorSobrenome.Text = "Campos obrigaórios *";
            this.lbErrorSobrenome.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(263, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 116;
            this.label5.Text = "Sobrenome:";
            // 
            // tbAlterarSobrenome
            // 
            this.tbAlterarSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlterarSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlterarSobrenome.Location = new System.Drawing.Point(261, 37);
            this.tbAlterarSobrenome.Name = "tbAlterarSobrenome";
            this.tbAlterarSobrenome.Size = new System.Drawing.Size(187, 23);
            this.tbAlterarSobrenome.TabIndex = 115;
            // 
            // lbErrorNome
            // 
            this.lbErrorNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorNome.AutoSize = true;
            this.lbErrorNome.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNome.Location = new System.Drawing.Point(28, 63);
            this.lbErrorNome.Name = "lbErrorNome";
            this.lbErrorNome.Size = new System.Drawing.Size(158, 16);
            this.lbErrorNome.TabIndex = 114;
            this.lbErrorNome.Text = "Campos obrigaórios *";
            this.lbErrorNome.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "Nome:";
            // 
            // tbAlterNome
            // 
            this.tbAlterNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlterNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlterNome.Location = new System.Drawing.Point(27, 37);
            this.tbAlterNome.Name = "tbAlterNome";
            this.tbAlterNome.Size = new System.Drawing.Size(200, 23);
            this.tbAlterNome.TabIndex = 112;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.ptAlterUpload);
            this.panel4.Location = new System.Drawing.Point(15, 369);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 100);
            this.panel4.TabIndex = 115;
            // 
            // lbName
            // 
            this.lbName.ForeColor = System.Drawing.Color.Blue;
            this.lbName.Location = new System.Drawing.Point(3, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(220, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Nome do arquivo";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(6, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Salvar comprovantes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptAlterUpload
            // 
            this.ptAlterUpload.Image = global::Controle_de_financia2.Properties.Resources.pdf2;
            this.ptAlterUpload.Location = new System.Drawing.Point(95, 27);
            this.ptAlterUpload.Name = "ptAlterUpload";
            this.ptAlterUpload.Size = new System.Drawing.Size(36, 39);
            this.ptAlterUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAlterUpload.TabIndex = 0;
            this.ptAlterUpload.TabStop = false;
            this.ptAlterUpload.Click += new System.EventHandler(this.ptAlterUpload_Click);
            this.ptAlterUpload.MouseEnter += new System.EventHandler(this.ptAlterUpload_MouseEnter);
            this.ptAlterUpload.MouseLeave += new System.EventHandler(this.ptAlterUpload_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mtAlteraDataOperacional);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(15, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 66);
            this.panel3.TabIndex = 114;
            // 
            // mtAlteraDataOperacional
            // 
            this.mtAlteraDataOperacional.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtAlteraDataOperacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtAlteraDataOperacional.Location = new System.Drawing.Point(26, 32);
            this.mtAlteraDataOperacional.Mask = "00/00/0000";
            this.mtAlteraDataOperacional.Name = "mtAlteraDataOperacional";
            this.mtAlteraDataOperacional.Size = new System.Drawing.Size(162, 23);
            this.mtAlteraDataOperacional.TabIndex = 114;
            this.mtAlteraDataOperacional.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(24, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 113;
            this.label3.Text = "Data de vencimento:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbAlteraStatus);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbAlteraAnoReferencia);
            this.panel2.Controls.Add(this.cbAlteraMesReferencia);
            this.panel2.Location = new System.Drawing.Point(396, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 166);
            this.panel2.TabIndex = 113;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(10, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 77;
            this.label10.Text = "Extatus:";
            // 
            // cbAlteraStatus
            // 
            this.cbAlteraStatus.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlteraStatus.FormattingEnabled = true;
            this.cbAlteraStatus.Items.AddRange(new object[] {
            "",
            "pago",
            "não pago"});
            this.cbAlteraStatus.Location = new System.Drawing.Point(12, 129);
            this.cbAlteraStatus.Name = "cbAlteraStatus";
            this.cbAlteraStatus.Size = new System.Drawing.Size(74, 23);
            this.cbAlteraStatus.TabIndex = 76;
            this.cbAlteraStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAlteraStatus_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(11, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Ano:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(9, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Mês:";
            // 
            // cbAlteraAnoReferencia
            // 
            this.cbAlteraAnoReferencia.FormattingEnabled = true;
            this.cbAlteraAnoReferencia.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cbAlteraAnoReferencia.Location = new System.Drawing.Point(12, 76);
            this.cbAlteraAnoReferencia.Name = "cbAlteraAnoReferencia";
            this.cbAlteraAnoReferencia.Size = new System.Drawing.Size(74, 24);
            this.cbAlteraAnoReferencia.TabIndex = 1;
            this.cbAlteraAnoReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAlteraAnoReferencia_KeyPress);
            // 
            // cbAlteraMesReferencia
            // 
            this.cbAlteraMesReferencia.FormattingEnabled = true;
            this.cbAlteraMesReferencia.Items.AddRange(new object[] {
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
            this.cbAlteraMesReferencia.Location = new System.Drawing.Point(13, 25);
            this.cbAlteraMesReferencia.Name = "cbAlteraMesReferencia";
            this.cbAlteraMesReferencia.Size = new System.Drawing.Size(73, 24);
            this.cbAlteraMesReferencia.TabIndex = 0;
            this.cbAlteraMesReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAlteraMesReferencia_KeyPress);
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
            this.btnVoltar2.Location = new System.Drawing.Point(15, 484);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(98, 37);
            this.btnVoltar2.TabIndex = 110;
            this.btnVoltar2.Text = "VOLTAR";
            this.btnVoltar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar2.UseVisualStyleBackColor = false;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "save-file.png");
            this.imageList2.Images.SetKeyName(1, "undo.png");
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.ImageKey = "save-file.png";
            this.btnAlterar.ImageList = this.imageList2;
            this.btnAlterar.Location = new System.Drawing.Point(119, 484);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 37);
            this.btnAlterar.TabIndex = 109;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tbAlteraValor
            // 
            this.tbAlteraValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlteraValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlteraValor.Location = new System.Drawing.Point(276, 299);
            this.tbAlteraValor.Name = "tbAlteraValor";
            this.tbAlteraValor.Size = new System.Drawing.Size(218, 23);
            this.tbAlteraValor.TabIndex = 106;
            this.tbAlteraValor.TextChanged += new System.EventHandler(this.tbAlteraValor_TextChanged);
            this.tbAlteraValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlteraValor_KeyPress);
            // 
            // lbErrorValor
            // 
            this.lbErrorValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorValor.AutoSize = true;
            this.lbErrorValor.ForeColor = System.Drawing.Color.Red;
            this.lbErrorValor.Location = new System.Drawing.Point(278, 325);
            this.lbErrorValor.Name = "lbErrorValor";
            this.lbErrorValor.Size = new System.Drawing.Size(158, 16);
            this.lbErrorValor.TabIndex = 102;
            this.lbErrorValor.Text = "Campos obrigaórios *";
            this.lbErrorValor.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(278, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.ImageKey = "financa.ico";
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(137, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 38);
            this.label7.TabIndex = 22;
            this.label7.Text = "ALTERAR  DEVEDOR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "financa.ico");
            // 
            // rtbAlterDescricao
            // 
            this.rtbAlterDescricao.Location = new System.Drawing.Point(533, 55);
            this.rtbAlterDescricao.Name = "rtbAlterDescricao";
            this.rtbAlterDescricao.Size = new System.Drawing.Size(323, 499);
            this.rtbAlterDescricao.TabIndex = 23;
            this.rtbAlterDescricao.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(542, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 18);
            this.label11.TabIndex = 118;
            this.label11.Text = "Descrição (Opcional):";
            // 
            // FormAlterarDevedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 566);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rtbAlterDescricao);
            this.Controls.Add(this.panel1);
            this.Name = "FormAlterarDevedores";
            this.Text = "ALTERAR DEVEDOR";
            this.Load += new System.EventHandler(this.FormAlterarDevedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelEstabelecimento.ResumeLayout(false);
            this.panelEstabelecimento.PerformLayout();
            this.panelNomeSobrenome.ResumeLayout(false);
            this.panelNomeSobrenome.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptAlterUpload)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAlteraAnoReferencia;
        private System.Windows.Forms.ComboBox cbAlteraMesReferencia;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox tbAlteraValor;
        private System.Windows.Forms.Label lbErrorValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAlteraStatus;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox mtAlteraDataOperacional;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ptAlterUpload;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panelNomeSobrenome;
        private System.Windows.Forms.Panel panelEstabelecimento;
        private System.Windows.Forms.Label lbErrorEstabelecimento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAlterEstabelecimento;
        private System.Windows.Forms.Label lbErrorSobrenome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAlterarSobrenome;
        private System.Windows.Forms.Label lbErrorNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlterNome;
        private System.Windows.Forms.RadioButton rbEstabelecimento;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbAlterParc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbAlterDescricao;
        private System.Windows.Forms.Label label11;
    }
}