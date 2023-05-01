namespace Projeto_Locadora
{
    partial class Frm_locacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_locacao));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnt_home = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_cargo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_modelo_marca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_automovel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_locacao = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_tipo_locacao = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id_locacao = new System.Windows.Forms.NumericUpDown();
            this.btn_excluir_automovel = new System.Windows.Forms.Button();
            this.btn_atualizar_automovel = new System.Windows.Forms.Button();
            this.btn_cadastrar_automovel = new System.Windows.Forms.Button();
            this.dgv_locacao = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_automovel_locacao = new System.Windows.Forms.ComboBox();
            this.cb_funcionario_locacao = new System.Windows.Forms.ComboBox();
            this.cb_cliente_locacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fim_locacao = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio_locacao = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_valor_locacao = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_locacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_locacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_locacao)).BeginInit();
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
            this.menuStrip1.TabIndex = 57;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnt_home
            // 
            this.mnt_home.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.mnt_home.Image = global::Projeto_Locadora.Properties.Resources.icone_carro;
            this.mnt_home.Name = "mnt_home";
            this.mnt_home.Size = new System.Drawing.Size(97, 31);
            this.mnt_home.Text = "Home";
            this.mnt_home.Click += new System.EventHandler(this.mnt_home_Click);
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
            this.mnt_cadastrar_cargo.Click += new System.EventHandler(this.mnt_cadastrar_cargo_Click);
            // 
            // mnt_cadastrar_cliente
            // 
            this.mnt_cadastrar_cliente.Name = "mnt_cadastrar_cliente";
            this.mnt_cadastrar_cliente.Size = new System.Drawing.Size(329, 30);
            this.mnt_cadastrar_cliente.Text = "Gerenciar clientes";
            this.mnt_cadastrar_cliente.Click += new System.EventHandler(this.mnt_cadastrar_cliente_Click);
            // 
            // mnt_cadastrar_modelo_marca
            // 
            this.mnt_cadastrar_modelo_marca.Name = "mnt_cadastrar_modelo_marca";
            this.mnt_cadastrar_modelo_marca.Size = new System.Drawing.Size(329, 30);
            this.mnt_cadastrar_modelo_marca.Text = "Gerenciar modelos e marcas";
            this.mnt_cadastrar_modelo_marca.Click += new System.EventHandler(this.mnt_cadastrar_modelo_marca_Click);
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
            // cb_tipo_locacao
            // 
            this.cb_tipo_locacao.BackColor = System.Drawing.SystemColors.Info;
            this.cb_tipo_locacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_tipo_locacao.FormattingEnabled = true;
            this.cb_tipo_locacao.Items.AddRange(new object[] {
            "DIÁRIA",
            "SEMANAL",
            "MENSAL",
            "ANUAL"});
            this.cb_tipo_locacao.Location = new System.Drawing.Point(121, 237);
            this.cb_tipo_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.cb_tipo_locacao.Name = "cb_tipo_locacao";
            this.cb_tipo_locacao.Size = new System.Drawing.Size(212, 33);
            this.cb_tipo_locacao.TabIndex = 141;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(48, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 28);
            this.label10.TabIndex = 132;
            this.label10.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(35, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 28);
            this.label6.TabIndex = 131;
            this.label6.Text = "Valor:";
            // 
            // txt_id_locacao
            // 
            this.txt_id_locacao.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id_locacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_locacao.Location = new System.Drawing.Point(121, 136);
            this.txt_id_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_locacao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_id_locacao.Name = "txt_id_locacao";
            this.txt_id_locacao.Size = new System.Drawing.Size(65, 30);
            this.txt_id_locacao.TabIndex = 129;
            // 
            // btn_excluir_automovel
            // 
            this.btn_excluir_automovel.BackColor = System.Drawing.Color.OldLace;
            this.btn_excluir_automovel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_excluir_automovel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_excluir_automovel.Location = new System.Drawing.Point(745, 628);
            this.btn_excluir_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir_automovel.Name = "btn_excluir_automovel";
            this.btn_excluir_automovel.Size = new System.Drawing.Size(145, 49);
            this.btn_excluir_automovel.TabIndex = 127;
            this.btn_excluir_automovel.Text = "Excluir";
            this.btn_excluir_automovel.UseVisualStyleBackColor = false;
            this.btn_excluir_automovel.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_atualizar_automovel
            // 
            this.btn_atualizar_automovel.BackColor = System.Drawing.Color.OldLace;
            this.btn_atualizar_automovel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_atualizar_automovel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_atualizar_automovel.Location = new System.Drawing.Point(498, 628);
            this.btn_atualizar_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar_automovel.Name = "btn_atualizar_automovel";
            this.btn_atualizar_automovel.Size = new System.Drawing.Size(145, 49);
            this.btn_atualizar_automovel.TabIndex = 126;
            this.btn_atualizar_automovel.Text = "Atualizar";
            this.btn_atualizar_automovel.UseVisualStyleBackColor = false;
            this.btn_atualizar_automovel.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_cadastrar_automovel
            // 
            this.btn_cadastrar_automovel.BackColor = System.Drawing.Color.OldLace;
            this.btn_cadastrar_automovel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_cadastrar_automovel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cadastrar_automovel.Location = new System.Drawing.Point(261, 628);
            this.btn_cadastrar_automovel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar_automovel.Name = "btn_cadastrar_automovel";
            this.btn_cadastrar_automovel.Size = new System.Drawing.Size(145, 49);
            this.btn_cadastrar_automovel.TabIndex = 125;
            this.btn_cadastrar_automovel.Text = "Cadastrar";
            this.btn_cadastrar_automovel.UseVisualStyleBackColor = false;
            this.btn_cadastrar_automovel.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // dgv_locacao
            // 
            this.dgv_locacao.BackgroundColor = System.Drawing.Color.White;
            this.dgv_locacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_locacao.Location = new System.Drawing.Point(7, 299);
            this.dgv_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_locacao.Name = "dgv_locacao";
            this.dgv_locacao.RowHeadersWidth = 51;
            this.dgv_locacao.Size = new System.Drawing.Size(1163, 321);
            this.dgv_locacao.TabIndex = 124;
            this.dgv_locacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_locacao_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 123;
            this.label4.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(371, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 51);
            this.label1.TabIndex = 121;
            this.label1.Text = "Cadastro locação";
            // 
            // cb_automovel_locacao
            // 
            this.cb_automovel_locacao.BackColor = System.Drawing.SystemColors.Window;
            this.cb_automovel_locacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_automovel_locacao.FormattingEnabled = true;
            this.cb_automovel_locacao.Location = new System.Drawing.Point(542, 237);
            this.cb_automovel_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.cb_automovel_locacao.Name = "cb_automovel_locacao";
            this.cb_automovel_locacao.Size = new System.Drawing.Size(287, 33);
            this.cb_automovel_locacao.TabIndex = 154;
            this.cb_automovel_locacao.SelectedIndexChanged += new System.EventHandler(this.cb_automovel_locacao_SelectedIndexChanged);
            // 
            // cb_funcionario_locacao
            // 
            this.cb_funcionario_locacao.BackColor = System.Drawing.SystemColors.Window;
            this.cb_funcionario_locacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_funcionario_locacao.FormattingEnabled = true;
            this.cb_funcionario_locacao.Location = new System.Drawing.Point(542, 186);
            this.cb_funcionario_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.cb_funcionario_locacao.Name = "cb_funcionario_locacao";
            this.cb_funcionario_locacao.Size = new System.Drawing.Size(287, 33);
            this.cb_funcionario_locacao.TabIndex = 153;
            this.cb_funcionario_locacao.SelectedIndexChanged += new System.EventHandler(this.cb_funcionario_locacao_SelectedIndexChanged);
            // 
            // cb_cliente_locacao
            // 
            this.cb_cliente_locacao.BackColor = System.Drawing.SystemColors.Window;
            this.cb_cliente_locacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_cliente_locacao.FormattingEnabled = true;
            this.cb_cliente_locacao.Location = new System.Drawing.Point(542, 131);
            this.cb_cliente_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.cb_cliente_locacao.Name = "cb_cliente_locacao";
            this.cb_cliente_locacao.Size = new System.Drawing.Size(287, 33);
            this.cb_cliente_locacao.TabIndex = 152;
            this.cb_cliente_locacao.SelectedIndexChanged += new System.EventHandler(this.cb_cliente_locacao_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(366, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 28);
            this.label7.TabIndex = 151;
            this.label7.Text = "Funcionário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(392, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 150;
            this.label5.Text = "Automóvel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(418, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 149;
            this.label2.Text = "Cliente:";
            // 
            // dtp_fim_locacao
            // 
            this.dtp_fim_locacao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fim_locacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fim_locacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fim_locacao.Location = new System.Drawing.Point(1025, 130);
            this.dtp_fim_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fim_locacao.Name = "dtp_fim_locacao";
            this.dtp_fim_locacao.Size = new System.Drawing.Size(132, 30);
            this.dtp_fim_locacao.TabIndex = 158;
            // 
            // dtp_inicio_locacao
            // 
            this.dtp_inicio_locacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio_locacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio_locacao.Location = new System.Drawing.Point(1025, 191);
            this.dtp_inicio_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_inicio_locacao.Name = "dtp_inicio_locacao";
            this.dtp_inicio_locacao.Size = new System.Drawing.Size(132, 30);
            this.dtp_inicio_locacao.TabIndex = 157;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(858, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 28);
            this.label8.TabIndex = 156;
            this.label8.Text = "Data Início:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(897, 191);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 28);
            this.label13.TabIndex = 155;
            this.label13.Text = "Data Fim:";
            // 
            // txt_valor_locacao
            // 
            this.txt_valor_locacao.BackColor = System.Drawing.SystemColors.Info;
            this.txt_valor_locacao.DecimalPlaces = 2;
            this.txt_valor_locacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_locacao.Location = new System.Drawing.Point(121, 189);
            this.txt_valor_locacao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_valor_locacao.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_valor_locacao.Name = "txt_valor_locacao";
            this.txt_valor_locacao.Size = new System.Drawing.Size(212, 30);
            this.txt_valor_locacao.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(825, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 28);
            this.label3.TabIndex = 160;
            this.label3.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(825, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 28);
            this.label9.TabIndex = 161;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(825, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 28);
            this.label11.TabIndex = 162;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Olive;
            this.label12.Location = new System.Drawing.Point(333, 191);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 28);
            this.label12.TabIndex = 163;
            this.label12.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Olive;
            this.label14.Location = new System.Drawing.Point(333, 238);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 28);
            this.label14.TabIndex = 164;
            this.label14.Text = "*";
            // 
            // Frm_locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Locadora.Properties.Resources.novo_fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.txt_valor_locacao);
            this.Controls.Add(this.dtp_fim_locacao);
            this.Controls.Add(this.dtp_inicio_locacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_automovel_locacao);
            this.Controls.Add(this.cb_funcionario_locacao);
            this.Controls.Add(this.cb_cliente_locacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_tipo_locacao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_id_locacao);
            this.Controls.Add(this.btn_excluir_automovel);
            this.Controls.Add(this.btn_atualizar_automovel);
            this.Controls.Add(this.btn_cadastrar_automovel);
            this.Controls.Add(this.dgv_locacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_locacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_locacao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_locacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_locacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_locacao)).EndInit();
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
        private System.Windows.Forms.ComboBox cb_tipo_locacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_id_locacao;
        private System.Windows.Forms.Button btn_excluir_automovel;
        private System.Windows.Forms.Button btn_atualizar_automovel;
        private System.Windows.Forms.Button btn_cadastrar_automovel;
        private System.Windows.Forms.DataGridView dgv_locacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_automovel_locacao;
        private System.Windows.Forms.ComboBox cb_funcionario_locacao;
        private System.Windows.Forms.ComboBox cb_cliente_locacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fim_locacao;
        private System.Windows.Forms.DateTimePicker dtp_inicio_locacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown txt_valor_locacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}