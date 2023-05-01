namespace Projeto_Locadora
{
    partial class Frm_automovel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_automovel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnt_home = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_cargo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_modelo_marca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_automovel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_locacao = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_km_automovel = new System.Windows.Forms.NumericUpDown();
            this.cb_modelo_automovel = new System.Windows.Forms.ComboBox();
            this.cb_marca_automovel = new System.Windows.Forms.ComboBox();
            this.cb_cor_automovel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rb_desativado = new System.Windows.Forms.RadioButton();
            this.rb_ativado = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_automovel = new System.Windows.Forms.NumericUpDown();
            this.txt_nome_automovel = new System.Windows.Forms.TextBox();
            this.btn_excluir_automovel = new System.Windows.Forms.Button();
            this.btn_atualizar_automovel = new System.Windows.Forms.Button();
            this.btn_cadastrar_automovel = new System.Windows.Forms.Button();
            this.dgv_automovel = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor_automovel = new System.Windows.Forms.NumericUpDown();
            this.txt_ano_fab_automovel = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_km_automovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_automovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_automovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_automovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ano_fab_automovel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_home,
            this.mnt_cadastros});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1179, 35);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnt_home
            // 
            this.mnt_home.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.mnt_home.Image = global::Projeto_Locadora.Properties.Resources.icone_carro;
            this.mnt_home.Name = "mnt_home";
            this.mnt_home.Size = new System.Drawing.Size(97, 31);
            this.mnt_home.Text = "Home";
            this.mnt_home.Click += new System.EventHandler(this.Mnt_home_Click);
            // 
            // mnt_cadastros
            // 
            this.mnt_cadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnt_cadastrar_cargo,
            this.mnt_cadastrar_cliente,
            this.mnt_cadastrar_modelo_marca,
            this.mnt_cadastrar_funcionario,
            this.mnt_cadastrar_automovel,
            this.mnt_cadastrar_locacao});
            this.mnt_cadastros.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnt_cadastros.Name = "mnt_cadastros";
            this.mnt_cadastros.Size = new System.Drawing.Size(191, 31);
            this.mnt_cadastros.Text = "Gerenciar cadastros";
            // 
            // mnt_cadastrar_cargo
            // 
            this.mnt_cadastrar_cargo.Name = "mnt_cadastrar_cargo";
            this.mnt_cadastrar_cargo.Size = new System.Drawing.Size(329, 30);
            this.mnt_cadastrar_cargo.Text = "Gerenciar cargos";
            this.mnt_cadastrar_cargo.Click += new System.EventHandler(this.Mnt_cadastrar_cargo_Click);
            // 
            // mnt_cadastrar_cliente
            // 
            this.mnt_cadastrar_cliente.Name = "mnt_cadastrar_cliente";
            this.mnt_cadastrar_cliente.Size = new System.Drawing.Size(329, 30);
            this.mnt_cadastrar_cliente.Text = "Gerenciar clientes";
            this.mnt_cadastrar_cliente.Click += new System.EventHandler(this.Mnt_cadastrar_cliente_Click);
            // 
            // mnt_cadastrar_modelo_marca
            // 
            this.mnt_cadastrar_modelo_marca.Name = "mnt_cadastrar_modelo_marca";
            this.mnt_cadastrar_modelo_marca.Size = new System.Drawing.Size(329, 30);
            this.mnt_cadastrar_modelo_marca.Text = "Gerenciar modelos e marcas";
            this.mnt_cadastrar_modelo_marca.Click += new System.EventHandler(this.Mnt_cadastrar_modelo_marca_Click);
            // 
            // mnt_cadastrar_funcionario
            // 
            this.mnt_cadastrar_funcionario.Name = "mnt_cadastrar_funcionario";
            this.mnt_cadastrar_funcionario.Size = new System.Drawing.Size(329, 30);
            this.mnt_cadastrar_funcionario.Text = "Gerenciar funcionários";
            this.mnt_cadastrar_funcionario.Click += new System.EventHandler(this.mnt_cadastrar_funcionario_Click);
            // 
            // mnt_cadastrar_automovel
            // 
            this.mnt_cadastrar_automovel.Name = "mnt_cadastrar_automovel";
            this.mnt_cadastrar_automovel.Size = new System.Drawing.Size(329, 30);
            this.mnt_cadastrar_automovel.Text = "Gerenciar automóveis";
            this.mnt_cadastrar_automovel.Click += new System.EventHandler(this.mnt_cadastrar_automovel_Click);
            // 
            // mnt_cadastrar_locacao
            // 
            this.mnt_cadastrar_locacao.Name = "mnt_cadastrar_locacao";
            this.mnt_cadastrar_locacao.Size = new System.Drawing.Size(329, 30);
            this.mnt_cadastrar_locacao.Text = "Gerenciar locações";
            this.mnt_cadastrar_locacao.Click += new System.EventHandler(this.mnt_cadastrar_locacao_Click);
            // 
            // txt_km_automovel
            // 
            this.txt_km_automovel.BackColor = System.Drawing.SystemColors.Info;
            this.txt_km_automovel.DecimalPlaces = 2;
            this.txt_km_automovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_km_automovel.Location = new System.Drawing.Point(263, 129);
            this.txt_km_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_km_automovel.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txt_km_automovel.Name = "txt_km_automovel";
            this.txt_km_automovel.Size = new System.Drawing.Size(144, 30);
            this.txt_km_automovel.TabIndex = 120;
            // 
            // cb_modelo_automovel
            // 
            this.cb_modelo_automovel.BackColor = System.Drawing.SystemColors.Window;
            this.cb_modelo_automovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_modelo_automovel.FormattingEnabled = true;
            this.cb_modelo_automovel.Location = new System.Drawing.Point(535, 235);
            this.cb_modelo_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.cb_modelo_automovel.Name = "cb_modelo_automovel";
            this.cb_modelo_automovel.Size = new System.Drawing.Size(244, 33);
            this.cb_modelo_automovel.TabIndex = 119;
            this.cb_modelo_automovel.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_automovel_SelectedIndexChanged);
            // 
            // cb_marca_automovel
            // 
            this.cb_marca_automovel.BackColor = System.Drawing.SystemColors.Window;
            this.cb_marca_automovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_marca_automovel.FormattingEnabled = true;
            this.cb_marca_automovel.Location = new System.Drawing.Point(535, 182);
            this.cb_marca_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.cb_marca_automovel.Name = "cb_marca_automovel";
            this.cb_marca_automovel.Size = new System.Drawing.Size(244, 33);
            this.cb_marca_automovel.TabIndex = 118;
            this.cb_marca_automovel.SelectedIndexChanged += new System.EventHandler(this.cb_marca_automovel_SelectedIndexChanged);
            // 
            // cb_cor_automovel
            // 
            this.cb_cor_automovel.BackColor = System.Drawing.SystemColors.Window;
            this.cb_cor_automovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_cor_automovel.FormattingEnabled = true;
            this.cb_cor_automovel.Items.AddRange(new object[] {
            "PRETO",
            "BRANCO",
            "VERMELHO",
            "CINZA",
            "PRATA",
            "VERDE",
            "AMARELO",
            "AZUL",
            "ROSA"});
            this.cb_cor_automovel.Location = new System.Drawing.Point(535, 127);
            this.cb_cor_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.cb_cor_automovel.Name = "cb_cor_automovel";
            this.cb_cor_automovel.Size = new System.Drawing.Size(244, 33);
            this.cb_cor_automovel.TabIndex = 117;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(436, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 116;
            this.label7.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(423, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 115;
            this.label5.Text = "Modelo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(811, 184);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 28);
            this.label15.TabIndex = 114;
            this.label15.Text = "Status:";
            // 
            // rb_desativado
            // 
            this.rb_desativado.AutoSize = true;
            this.rb_desativado.BackColor = System.Drawing.Color.Transparent;
            this.rb_desativado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_desativado.Location = new System.Drawing.Point(925, 233);
            this.rb_desativado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_desativado.Name = "rb_desativado";
            this.rb_desativado.Size = new System.Drawing.Size(163, 27);
            this.rb_desativado.TabIndex = 113;
            this.rb_desativado.TabStop = true;
            this.rb_desativado.Text = "Indisponível";
            this.rb_desativado.UseVisualStyleBackColor = false;
            // 
            // rb_ativado
            // 
            this.rb_ativado.AutoSize = true;
            this.rb_ativado.BackColor = System.Drawing.Color.Transparent;
            this.rb_ativado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ativado.Location = new System.Drawing.Point(925, 187);
            this.rb_ativado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ativado.Name = "rb_ativado";
            this.rb_ativado.Size = new System.Drawing.Size(141, 27);
            this.rb_ativado.TabIndex = 112;
            this.rb_ativado.TabStop = true;
            this.rb_ativado.Text = "Disponível";
            this.rb_ativado.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(810, 128);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 28);
            this.label14.TabIndex = 109;
            this.label14.Text = "Ano Fabricação:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(462, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 28);
            this.label10.TabIndex = 108;
            this.label10.Text = "Cor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 28);
            this.label6.TabIndex = 107;
            this.label6.Text = "Valor Diária:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 106;
            this.label2.Text = "Km:";
            // 
            // txt_id_automovel
            // 
            this.txt_id_automovel.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id_automovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_automovel.Location = new System.Drawing.Point(135, 130);
            this.txt_id_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_automovel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_id_automovel.Name = "txt_id_automovel";
            this.txt_id_automovel.Size = new System.Drawing.Size(65, 30);
            this.txt_id_automovel.TabIndex = 105;
            // 
            // txt_nome_automovel
            // 
            this.txt_nome_automovel.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nome_automovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_automovel.Location = new System.Drawing.Point(106, 186);
            this.txt_nome_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome_automovel.Name = "txt_nome_automovel";
            this.txt_nome_automovel.Size = new System.Drawing.Size(301, 30);
            this.txt_nome_automovel.TabIndex = 104;
            // 
            // btn_excluir_automovel
            // 
            this.btn_excluir_automovel.BackColor = System.Drawing.Color.OldLace;
            this.btn_excluir_automovel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_excluir_automovel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_excluir_automovel.Location = new System.Drawing.Point(747, 625);
            this.btn_excluir_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir_automovel.Name = "btn_excluir_automovel";
            this.btn_excluir_automovel.Size = new System.Drawing.Size(145, 49);
            this.btn_excluir_automovel.TabIndex = 103;
            this.btn_excluir_automovel.Text = "Excluir";
            this.btn_excluir_automovel.UseVisualStyleBackColor = false;
            this.btn_excluir_automovel.Click += new System.EventHandler(this.Btn_excluir_automovel_Click);
            // 
            // btn_atualizar_automovel
            // 
            this.btn_atualizar_automovel.BackColor = System.Drawing.Color.OldLace;
            this.btn_atualizar_automovel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_atualizar_automovel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_atualizar_automovel.Location = new System.Drawing.Point(500, 625);
            this.btn_atualizar_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar_automovel.Name = "btn_atualizar_automovel";
            this.btn_atualizar_automovel.Size = new System.Drawing.Size(145, 49);
            this.btn_atualizar_automovel.TabIndex = 102;
            this.btn_atualizar_automovel.Text = "Atualizar";
            this.btn_atualizar_automovel.UseVisualStyleBackColor = false;
            this.btn_atualizar_automovel.Click += new System.EventHandler(this.Btn_atualizar_automovel_Click);
            // 
            // btn_cadastrar_automovel
            // 
            this.btn_cadastrar_automovel.BackColor = System.Drawing.Color.OldLace;
            this.btn_cadastrar_automovel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_cadastrar_automovel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cadastrar_automovel.Location = new System.Drawing.Point(263, 625);
            this.btn_cadastrar_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar_automovel.Name = "btn_cadastrar_automovel";
            this.btn_cadastrar_automovel.Size = new System.Drawing.Size(145, 49);
            this.btn_cadastrar_automovel.TabIndex = 101;
            this.btn_cadastrar_automovel.Text = "Cadastrar";
            this.btn_cadastrar_automovel.UseVisualStyleBackColor = false;
            this.btn_cadastrar_automovel.Click += new System.EventHandler(this.Btn_cadastrar_automovel_Click);
            // 
            // dgv_automovel
            // 
            this.dgv_automovel.BackgroundColor = System.Drawing.Color.White;
            this.dgv_automovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_automovel.Location = new System.Drawing.Point(35, 295);
            this.dgv_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_automovel.Name = "dgv_automovel";
            this.dgv_automovel.RowHeadersWidth = 51;
            this.dgv_automovel.Size = new System.Drawing.Size(1110, 321);
            this.dgv_automovel.TabIndex = 100;
            this.dgv_automovel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_automovel_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 99;
            this.label4.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 98;
            this.label3.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(359, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 51);
            this.label1.TabIndex = 97;
            this.label1.Text = "Cadastro automóvel";
            // 
            // txt_valor_automovel
            // 
            this.txt_valor_automovel.BackColor = System.Drawing.SystemColors.Info;
            this.txt_valor_automovel.DecimalPlaces = 2;
            this.txt_valor_automovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_automovel.Location = new System.Drawing.Point(219, 238);
            this.txt_valor_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_valor_automovel.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_valor_automovel.Name = "txt_valor_automovel";
            this.txt_valor_automovel.Size = new System.Drawing.Size(189, 30);
            this.txt_valor_automovel.TabIndex = 122;
            // 
            // txt_ano_fab_automovel
            // 
            this.txt_ano_fab_automovel.BackColor = System.Drawing.SystemColors.Info;
            this.txt_ano_fab_automovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ano_fab_automovel.Location = new System.Drawing.Point(1024, 128);
            this.txt_ano_fab_automovel.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.txt_ano_fab_automovel.Name = "txt_ano_fab_automovel";
            this.txt_ano_fab_automovel.Size = new System.Drawing.Size(120, 30);
            this.txt_ano_fab_automovel.TabIndex = 131;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Olive;
            this.label12.Location = new System.Drawing.Point(777, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 28);
            this.label12.TabIndex = 164;
            this.label12.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(777, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 28);
            this.label8.TabIndex = 165;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(777, 236);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 28);
            this.label9.TabIndex = 166;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(403, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 28);
            this.label11.TabIndex = 167;
            this.label11.Text = "*";
            // 
            // Frm_automovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Locadora.Properties.Resources.novo_fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.txt_ano_fab_automovel);
            this.Controls.Add(this.txt_valor_automovel);
            this.Controls.Add(this.txt_km_automovel);
            this.Controls.Add(this.cb_modelo_automovel);
            this.Controls.Add(this.cb_marca_automovel);
            this.Controls.Add(this.cb_cor_automovel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rb_desativado);
            this.Controls.Add(this.rb_ativado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_automovel);
            this.Controls.Add(this.txt_nome_automovel);
            this.Controls.Add(this.btn_excluir_automovel);
            this.Controls.Add(this.btn_atualizar_automovel);
            this.Controls.Add(this.btn_cadastrar_automovel);
            this.Controls.Add(this.dgv_automovel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_automovel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_automovel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_km_automovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_automovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_automovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_automovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ano_fab_automovel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnt_home;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastros;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_cargo;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_cliente;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_modelo_marca;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_funcionario;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_automovel;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_locacao;
        private System.Windows.Forms.NumericUpDown txt_km_automovel;
        private System.Windows.Forms.ComboBox cb_modelo_automovel;
        private System.Windows.Forms.ComboBox cb_cor_automovel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rb_desativado;
        private System.Windows.Forms.RadioButton rb_ativado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_id_automovel;
        private System.Windows.Forms.TextBox txt_nome_automovel;
        private System.Windows.Forms.Button btn_excluir_automovel;
        private System.Windows.Forms.Button btn_atualizar_automovel;
        private System.Windows.Forms.Button btn_cadastrar_automovel;
        private System.Windows.Forms.DataGridView dgv_automovel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_valor_automovel;
        private System.Windows.Forms.ComboBox cb_marca_automovel;
        private System.Windows.Forms.NumericUpDown txt_ano_fab_automovel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}