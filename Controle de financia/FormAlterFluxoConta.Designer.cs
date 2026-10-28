namespace Controle_de_financia2
{
    partial class FormAlterFluxoConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterFluxoConta));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbAlterParc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbAlterDescricaoConta = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ptAlterUpload = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtAlterDataVenc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAlterYearReference = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAlterMonthReference = new System.Windows.Forms.ComboBox();
            this.cbMaiusculo = new System.Windows.Forms.CheckBox();
            this.cbAlterTipoConta = new System.Windows.Forms.ComboBox();
            this.lbErrorValor = new System.Windows.Forms.Label();
            this.lbErrorConta = new System.Windows.Forms.Label();
            this.lbErrorEstabelecimento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAlterValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAlterEstabelecimento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbAlterDescricao = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterDescricaoConta)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAlterUpload)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(0, "salvar.png");
            this.imageList1.Images.SetKeyName(1, "human.png");
            this.imageList1.Images.SetKeyName(2, "financa.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnVoltar2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.cbMaiusculo);
            this.panel1.Controls.Add(this.cbAlterTipoConta);
            this.panel1.Controls.Add(this.lbErrorValor);
            this.panel1.Controls.Add(this.lbErrorConta);
            this.panel1.Controls.Add(this.lbErrorEstabelecimento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbAlterValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbAlterEstabelecimento);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 535);
            this.panel1.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbAlterParc);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(224, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 82);
            this.panel5.TabIndex = 122;
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
            this.cbAlterParc.Location = new System.Drawing.Point(18, 37);
            this.cbAlterParc.Name = "cbAlterParc";
            this.cbAlterParc.Size = new System.Drawing.Size(54, 21);
            this.cbAlterParc.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(16, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Parcelas";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pbAlterDescricaoConta);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(326, 316);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 66);
            this.panel4.TabIndex = 90;
            // 
            // pbAlterDescricaoConta
            // 
            this.pbAlterDescricaoConta.Image = global::Controle_de_financia2.Properties.Resources.descricao;
            this.pbAlterDescricaoConta.Location = new System.Drawing.Point(58, 27);
            this.pbAlterDescricaoConta.Name = "pbAlterDescricaoConta";
            this.pbAlterDescricaoConta.Size = new System.Drawing.Size(29, 31);
            this.pbAlterDescricaoConta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlterDescricaoConta.TabIndex = 77;
            this.pbAlterDescricaoConta.TabStop = false;
            this.pbAlterDescricaoConta.Click += new System.EventHandler(this.pbAlterDescricaoConta_Click);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(3, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "Descrição (opcional)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.ptAlterUpload);
            this.panel3.ForeColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(326, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 84);
            this.panel3.TabIndex = 89;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(6, 63);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(131, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Nome do arquivo";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Salvar comprovantes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptAlterUpload
            // 
            this.ptAlterUpload.Image = global::Controle_de_financia2.Properties.Resources.pdf3;
            this.ptAlterUpload.Location = new System.Drawing.Point(58, 24);
            this.ptAlterUpload.Name = "ptAlterUpload";
            this.ptAlterUpload.Size = new System.Drawing.Size(36, 36);
            this.ptAlterUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAlterUpload.TabIndex = 0;
            this.ptAlterUpload.TabStop = false;
            this.ptAlterUpload.Click += new System.EventHandler(this.ptAlterUpload_Click);
            this.ptAlterUpload.MouseEnter += new System.EventHandler(this.ptAlterUpload_MouseEnter);
            this.ptAlterUpload.MouseLeave += new System.EventHandler(this.ptAlterUpload_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mtAlterDataVenc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(45, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 66);
            this.panel2.TabIndex = 70;
            // 
            // mtAlterDataVenc
            // 
            this.mtAlterDataVenc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtAlterDataVenc.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtAlterDataVenc.Location = new System.Drawing.Point(6, 29);
            this.mtAlterDataVenc.Mask = "00/00/0000";
            this.mtAlterDataVenc.Name = "mtAlterDataVenc";
            this.mtAlterDataVenc.Size = new System.Drawing.Size(121, 23);
            this.mtAlterDataVenc.TabIndex = 66;
            this.mtAlterDataVenc.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Data vencimento:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.BackColor = System.Drawing.Color.Gold;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.ImageKey = "salvar.png";
            this.btnAlterar.ImageList = this.imageList2;
            this.btnAlterar.Location = new System.Drawing.Point(144, 481);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 42);
            this.btnAlterar.TabIndex = 68;
            this.btnAlterar.Text = "AlLTERAR";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.label5.Location = new System.Drawing.Point(140, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 50);
            this.label5.TabIndex = 16;
            this.label5.Text = "ALTERAR CONTA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar2.BackColor = System.Drawing.Color.Blue;
            this.btnVoltar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar2.ImageKey = "human.png";
            this.btnVoltar2.ImageList = this.imageList2;
            this.btnVoltar2.Location = new System.Drawing.Point(38, 481);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(96, 42);
            this.btnVoltar2.TabIndex = 69;
            this.btnVoltar2.Text = "VOLTAR";
            this.btnVoltar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar2.UseVisualStyleBackColor = false;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbStatus);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbAlterYearReference);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbAlterMonthReference);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(224, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 178);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Estatus de pagamento:";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "",
            "pago",
            "não pago"});
            this.cbStatus.Location = new System.Drawing.Point(34, 145);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(173, 23);
            this.cbStatus.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Ano de referência:";
            // 
            // cbAlterYearReference
            // 
            this.cbAlterYearReference.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlterYearReference.FormattingEnabled = true;
            this.cbAlterYearReference.Items.AddRange(new object[] {
            "",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cbAlterYearReference.Location = new System.Drawing.Point(33, 95);
            this.cbAlterYearReference.Name = "cbAlterYearReference";
            this.cbAlterYearReference.Size = new System.Drawing.Size(174, 23);
            this.cbAlterYearReference.TabIndex = 53;
            this.cbAlterYearReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAlterYearReference_KeyPress_1);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Mês de referência:";
            // 
            // cbAlterMonthReference
            // 
            this.cbAlterMonthReference.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlterMonthReference.FormattingEnabled = true;
            this.cbAlterMonthReference.Items.AddRange(new object[] {
            "",
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
            this.cbAlterMonthReference.Location = new System.Drawing.Point(33, 37);
            this.cbAlterMonthReference.Name = "cbAlterMonthReference";
            this.cbAlterMonthReference.Size = new System.Drawing.Size(174, 23);
            this.cbAlterMonthReference.TabIndex = 51;
            this.cbAlterMonthReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAlterMonthReference_KeyPress_1);
            // 
            // cbMaiusculo
            // 
            this.cbMaiusculo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbMaiusculo.AutoSize = true;
            this.cbMaiusculo.Font = new System.Drawing.Font("Cambria", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaiusculo.ForeColor = System.Drawing.Color.Blue;
            this.cbMaiusculo.Location = new System.Drawing.Point(351, 142);
            this.cbMaiusculo.Name = "cbMaiusculo";
            this.cbMaiusculo.Size = new System.Drawing.Size(115, 20);
            this.cbMaiusculo.TabIndex = 66;
            this.cbMaiusculo.Text = "Texto Maículos";
            this.cbMaiusculo.UseVisualStyleBackColor = true;
            this.cbMaiusculo.CheckedChanged += new System.EventHandler(this.cbMaiusculo_CheckedChanged_1);
            // 
            // cbAlterTipoConta
            // 
            this.cbAlterTipoConta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAlterTipoConta.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlterTipoConta.FormattingEnabled = true;
            this.cbAlterTipoConta.Items.AddRange(new object[] {
            "",
            "PIX",
            "BOLETO BANCÁRIO",
            "NOTA PROMISSÓRIA",
            "FIADO",
            "CARTÃO DE CREDITO",
            "CARNÊ",
            "DÉBITO AUTOMÁTICO",
            "EM DINHEIRO",
            "CARTÃO DE DÉBIITO"});
            this.cbAlterTipoConta.Location = new System.Drawing.Point(45, 188);
            this.cbAlterTipoConta.Name = "cbAlterTipoConta";
            this.cbAlterTipoConta.Size = new System.Drawing.Size(153, 23);
            this.cbAlterTipoConta.TabIndex = 65;
            this.cbAlterTipoConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAlterTipoConta_KeyPress_1);
            // 
            // lbErrorValor
            // 
            this.lbErrorValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorValor.AutoSize = true;
            this.lbErrorValor.ForeColor = System.Drawing.Color.Red;
            this.lbErrorValor.Location = new System.Drawing.Point(46, 421);
            this.lbErrorValor.Name = "lbErrorValor";
            this.lbErrorValor.Size = new System.Drawing.Size(126, 13);
            this.lbErrorValor.TabIndex = 63;
            this.lbErrorValor.Text = "Campos obrigaórios *";
            this.lbErrorValor.Visible = false;
            // 
            // lbErrorConta
            // 
            this.lbErrorConta.AutoSize = true;
            this.lbErrorConta.ForeColor = System.Drawing.Color.Red;
            this.lbErrorConta.Location = new System.Drawing.Point(42, 214);
            this.lbErrorConta.Name = "lbErrorConta";
            this.lbErrorConta.Size = new System.Drawing.Size(126, 13);
            this.lbErrorConta.TabIndex = 61;
            this.lbErrorConta.Text = "Campos obrigaórios *";
            this.lbErrorConta.Visible = false;
            // 
            // lbErrorEstabelecimento
            // 
            this.lbErrorEstabelecimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbErrorEstabelecimento.AutoSize = true;
            this.lbErrorEstabelecimento.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEstabelecimento.Location = new System.Drawing.Point(42, 130);
            this.lbErrorEstabelecimento.Name = "lbErrorEstabelecimento";
            this.lbErrorEstabelecimento.Size = new System.Drawing.Size(126, 13);
            this.lbErrorEstabelecimento.TabIndex = 60;
            this.lbErrorEstabelecimento.Text = "Campos obrigaórios *";
            this.lbErrorEstabelecimento.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(46, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Valor:";
            // 
            // tbAlterValor
            // 
            this.tbAlterValor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbAlterValor.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlterValor.Location = new System.Drawing.Point(49, 395);
            this.tbAlterValor.Name = "tbAlterValor";
            this.tbAlterValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAlterValor.Size = new System.Drawing.Size(121, 23);
            this.tbAlterValor.TabIndex = 58;
            this.tbAlterValor.TextChanged += new System.EventHandler(this.tbAlterValor_TextChanged_1);
            this.tbAlterValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlterValor_KeyPress_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(42, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Tipo de conta:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(42, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Estabelecimento:";
            // 
            // tbAlterEstabelecimento
            // 
            this.tbAlterEstabelecimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlterEstabelecimento.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlterEstabelecimento.Location = new System.Drawing.Point(45, 104);
            this.tbAlterEstabelecimento.Name = "tbAlterEstabelecimento";
            this.tbAlterEstabelecimento.Size = new System.Drawing.Size(421, 23);
            this.tbAlterEstabelecimento.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(535, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 122;
            this.label12.Text = "Descrição:";
            // 
            // rtbAlterDescricao
            // 
            this.rtbAlterDescricao.Location = new System.Drawing.Point(538, 47);
            this.rtbAlterDescricao.Name = "rtbAlterDescricao";
            this.rtbAlterDescricao.Size = new System.Drawing.Size(332, 511);
            this.rtbAlterDescricao.TabIndex = 121;
            this.rtbAlterDescricao.Text = "";
            // 
            // FormAlterFluxoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(893, 570);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rtbAlterDescricao);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlterFluxoConta";
            this.Text = "ALTERAR CONTAS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterDescricaoConta)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptAlterUpload)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAlterYearReference;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAlterMonthReference;
        private System.Windows.Forms.CheckBox cbMaiusculo;
        private System.Windows.Forms.ComboBox cbAlterTipoConta;
        private System.Windows.Forms.Label lbErrorValor;
        private System.Windows.Forms.Label lbErrorConta;
        private System.Windows.Forms.Label lbErrorEstabelecimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAlterValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlterEstabelecimento;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mtAlterDataVenc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ptAlterUpload;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbAlterDescricaoConta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbAlterParc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbAlterDescricao;
    }
}