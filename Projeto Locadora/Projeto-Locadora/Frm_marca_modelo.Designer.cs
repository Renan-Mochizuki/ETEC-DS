namespace Projeto_Locadora
{
    partial class Frm_marca_modelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_marca_modelo));
            this.txt_nome_marca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_desc_modelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id_marca = new System.Windows.Forms.NumericUpDown();
            this.txt_id_modelo = new System.Windows.Forms.NumericUpDown();
            this.dgv_marca = new System.Windows.Forms.DataGridView();
            this.dgv_modelo = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar_marca = new System.Windows.Forms.Button();
            this.btn_atualizar_marca = new System.Windows.Forms.Button();
            this.btn_excluir_marca = new System.Windows.Forms.Button();
            this.btn_excluir_modelo = new System.Windows.Forms.Button();
            this.btn_atualizar_modelo = new System.Windows.Forms.Button();
            this.btn_cadastrar_modelo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnt_home = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_cargo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_modelo_marca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_automovel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_locacao = new System.Windows.Forms.ToolStripMenuItem();
            this.rb_desativado_marca = new System.Windows.Forms.RadioButton();
            this.rb_ativado_marca = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_ativado_modelo = new System.Windows.Forms.RadioButton();
            this.rb_desativado_modelo = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_marca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nome_marca
            // 
            this.txt_nome_marca.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nome_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_marca.Location = new System.Drawing.Point(315, 222);
            this.txt_nome_marca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome_marca.Name = "txt_nome_marca";
            this.txt_nome_marca.Size = new System.Drawing.Size(159, 34);
            this.txt_nome_marca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(156, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(671, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadastro modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(216, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(189, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código:";
            // 
            // txt_desc_modelo
            // 
            this.txt_desc_modelo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_desc_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc_modelo.Location = new System.Drawing.Point(812, 222);
            this.txt_desc_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desc_modelo.Name = "txt_desc_modelo";
            this.txt_desc_modelo.Size = new System.Drawing.Size(159, 34);
            this.txt_desc_modelo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(663, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(703, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Código:";
            // 
            // txt_id_marca
            // 
            this.txt_id_marca.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_marca.Location = new System.Drawing.Point(315, 159);
            this.txt_id_marca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_marca.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_id_marca.Name = "txt_id_marca";
            this.txt_id_marca.Size = new System.Drawing.Size(160, 34);
            this.txt_id_marca.TabIndex = 11;
            // 
            // txt_id_modelo
            // 
            this.txt_id_modelo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_modelo.Location = new System.Drawing.Point(812, 161);
            this.txt_id_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_modelo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_id_modelo.Name = "txt_id_modelo";
            this.txt_id_modelo.Size = new System.Drawing.Size(160, 34);
            this.txt_id_modelo.TabIndex = 12;
            // 
            // dgv_marca
            // 
            this.dgv_marca.BackgroundColor = System.Drawing.Color.White;
            this.dgv_marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marca.Location = new System.Drawing.Point(115, 364);
            this.dgv_marca.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_marca.Name = "dgv_marca";
            this.dgv_marca.RowHeadersWidth = 51;
            this.dgv_marca.Size = new System.Drawing.Size(421, 185);
            this.dgv_marca.TabIndex = 13;
            this.dgv_marca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_marca_CellClick);
            // 
            // dgv_modelo
            // 
            this.dgv_modelo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_modelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modelo.Location = new System.Drawing.Point(632, 364);
            this.dgv_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_modelo.Name = "dgv_modelo";
            this.dgv_modelo.RowHeadersWidth = 51;
            this.dgv_modelo.Size = new System.Drawing.Size(416, 185);
            this.dgv_modelo.TabIndex = 14;
            this.dgv_modelo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_modelo_CellClick);
            // 
            // btn_cadastrar_marca
            // 
            this.btn_cadastrar_marca.BackColor = System.Drawing.Color.OldLace;
            this.btn_cadastrar_marca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_marca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cadastrar_marca.Location = new System.Drawing.Point(151, 567);
            this.btn_cadastrar_marca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar_marca.Name = "btn_cadastrar_marca";
            this.btn_cadastrar_marca.Size = new System.Drawing.Size(145, 49);
            this.btn_cadastrar_marca.TabIndex = 15;
            this.btn_cadastrar_marca.Text = "Cadastrar";
            this.btn_cadastrar_marca.UseVisualStyleBackColor = false;
            this.btn_cadastrar_marca.Click += new System.EventHandler(this.Btn_cadastrar_marca_Click);
            // 
            // btn_atualizar_marca
            // 
            this.btn_atualizar_marca.BackColor = System.Drawing.Color.OldLace;
            this.btn_atualizar_marca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar_marca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_atualizar_marca.Location = new System.Drawing.Point(351, 567);
            this.btn_atualizar_marca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar_marca.Name = "btn_atualizar_marca";
            this.btn_atualizar_marca.Size = new System.Drawing.Size(145, 49);
            this.btn_atualizar_marca.TabIndex = 16;
            this.btn_atualizar_marca.Text = "Atualizar";
            this.btn_atualizar_marca.UseVisualStyleBackColor = false;
            this.btn_atualizar_marca.Click += new System.EventHandler(this.Btn_atualizar_marca_Click);
            // 
            // btn_excluir_marca
            // 
            this.btn_excluir_marca.BackColor = System.Drawing.Color.OldLace;
            this.btn_excluir_marca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_marca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_excluir_marca.Location = new System.Drawing.Point(255, 635);
            this.btn_excluir_marca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir_marca.Name = "btn_excluir_marca";
            this.btn_excluir_marca.Size = new System.Drawing.Size(145, 43);
            this.btn_excluir_marca.TabIndex = 17;
            this.btn_excluir_marca.Text = "Excluir";
            this.btn_excluir_marca.UseVisualStyleBackColor = false;
            this.btn_excluir_marca.Click += new System.EventHandler(this.Btn_excluir_marca_Click);
            // 
            // btn_excluir_modelo
            // 
            this.btn_excluir_modelo.BackColor = System.Drawing.Color.OldLace;
            this.btn_excluir_modelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_modelo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_excluir_modelo.Location = new System.Drawing.Point(772, 635);
            this.btn_excluir_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir_modelo.Name = "btn_excluir_modelo";
            this.btn_excluir_modelo.Size = new System.Drawing.Size(145, 43);
            this.btn_excluir_modelo.TabIndex = 21;
            this.btn_excluir_modelo.Text = "Excluir";
            this.btn_excluir_modelo.UseVisualStyleBackColor = false;
            this.btn_excluir_modelo.Click += new System.EventHandler(this.Btn_excluir_modelo_Click);
            // 
            // btn_atualizar_modelo
            // 
            this.btn_atualizar_modelo.BackColor = System.Drawing.Color.OldLace;
            this.btn_atualizar_modelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar_modelo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_atualizar_modelo.Location = new System.Drawing.Point(868, 567);
            this.btn_atualizar_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar_modelo.Name = "btn_atualizar_modelo";
            this.btn_atualizar_modelo.Size = new System.Drawing.Size(145, 49);
            this.btn_atualizar_modelo.TabIndex = 20;
            this.btn_atualizar_modelo.Text = "Atualizar";
            this.btn_atualizar_modelo.UseVisualStyleBackColor = false;
            this.btn_atualizar_modelo.Click += new System.EventHandler(this.Btn_atualizar_modelo_Click);
            // 
            // btn_cadastrar_modelo
            // 
            this.btn_cadastrar_modelo.BackColor = System.Drawing.Color.OldLace;
            this.btn_cadastrar_modelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_modelo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cadastrar_modelo.Location = new System.Drawing.Point(668, 567);
            this.btn_cadastrar_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar_modelo.Name = "btn_cadastrar_modelo";
            this.btn_cadastrar_modelo.Size = new System.Drawing.Size(145, 49);
            this.btn_cadastrar_modelo.TabIndex = 19;
            this.btn_cadastrar_modelo.Text = "Cadastrar";
            this.btn_cadastrar_modelo.UseVisualStyleBackColor = false;
            this.btn_cadastrar_modelo.Click += new System.EventHandler(this.Btn_cadastrar_modelo_Click);
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
            this.menuStrip1.TabIndex = 24;
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
            // rb_desativado_marca
            // 
            this.rb_desativado_marca.AutoSize = true;
            this.rb_desativado_marca.BackColor = System.Drawing.Color.Transparent;
            this.rb_desativado_marca.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_desativado_marca.Location = new System.Drawing.Point(13, 55);
            this.rb_desativado_marca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_desativado_marca.Name = "rb_desativado_marca";
            this.rb_desativado_marca.Size = new System.Drawing.Size(163, 32);
            this.rb_desativado_marca.TabIndex = 57;
            this.rb_desativado_marca.TabStop = true;
            this.rb_desativado_marca.Text = "Desativado";
            this.rb_desativado_marca.UseVisualStyleBackColor = false;
            // 
            // rb_ativado_marca
            // 
            this.rb_ativado_marca.AutoSize = true;
            this.rb_ativado_marca.BackColor = System.Drawing.Color.Transparent;
            this.rb_ativado_marca.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ativado_marca.Location = new System.Drawing.Point(13, 20);
            this.rb_ativado_marca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ativado_marca.Name = "rb_ativado_marca";
            this.rb_ativado_marca.Size = new System.Drawing.Size(124, 32);
            this.rb_ativado_marca.TabIndex = 56;
            this.rb_ativado_marca.TabStop = true;
            this.rb_ativado_marca.Text = "Ativado";
            this.rb_ativado_marca.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(697, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 28);
            this.label7.TabIndex = 60;
            this.label7.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(189, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 28);
            this.label8.TabIndex = 61;
            this.label8.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rb_ativado_marca);
            this.panel1.Controls.Add(this.rb_desativado_marca);
            this.panel1.Location = new System.Drawing.Point(296, 263);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 94);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.rb_ativado_modelo);
            this.panel2.Controls.Add(this.rb_desativado_modelo);
            this.panel2.Location = new System.Drawing.Point(812, 263);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 94);
            this.panel2.TabIndex = 63;
            // 
            // rb_ativado_modelo
            // 
            this.rb_ativado_modelo.AutoSize = true;
            this.rb_ativado_modelo.BackColor = System.Drawing.Color.Transparent;
            this.rb_ativado_modelo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ativado_modelo.Location = new System.Drawing.Point(13, 20);
            this.rb_ativado_modelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ativado_modelo.Name = "rb_ativado_modelo";
            this.rb_ativado_modelo.Size = new System.Drawing.Size(124, 32);
            this.rb_ativado_modelo.TabIndex = 56;
            this.rb_ativado_modelo.TabStop = true;
            this.rb_ativado_modelo.Text = "Ativado";
            this.rb_ativado_modelo.UseVisualStyleBackColor = false;
            // 
            // rb_desativado_modelo
            // 
            this.rb_desativado_modelo.AutoSize = true;
            this.rb_desativado_modelo.BackColor = System.Drawing.Color.Transparent;
            this.rb_desativado_modelo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_desativado_modelo.Location = new System.Drawing.Point(13, 55);
            this.rb_desativado_modelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_desativado_modelo.Name = "rb_desativado_modelo";
            this.rb_desativado_modelo.Size = new System.Drawing.Size(163, 32);
            this.rb_desativado_modelo.TabIndex = 57;
            this.rb_desativado_modelo.TabStop = true;
            this.rb_desativado_modelo.Text = "Desativado";
            this.rb_desativado_modelo.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Olive;
            this.label14.Location = new System.Drawing.Point(471, 226);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 28);
            this.label14.TabIndex = 165;
            this.label14.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(965, 225);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 28);
            this.label9.TabIndex = 166;
            this.label9.Text = "*";
            // 
            // Frm_marca_modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Projeto_Locadora.Properties.Resources.novo_fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_excluir_modelo);
            this.Controls.Add(this.btn_atualizar_modelo);
            this.Controls.Add(this.btn_cadastrar_modelo);
            this.Controls.Add(this.btn_excluir_marca);
            this.Controls.Add(this.btn_atualizar_marca);
            this.Controls.Add(this.btn_cadastrar_marca);
            this.Controls.Add(this.dgv_modelo);
            this.Controls.Add(this.dgv_marca);
            this.Controls.Add(this.txt_id_modelo);
            this.Controls.Add(this.txt_id_marca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_desc_modelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome_marca);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_marca_modelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frm_marca_modelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_marca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modelo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nome_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_desc_modelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_id_marca;
        private System.Windows.Forms.NumericUpDown txt_id_modelo;
        private System.Windows.Forms.DataGridView dgv_marca;
        private System.Windows.Forms.DataGridView dgv_modelo;
        private System.Windows.Forms.Button btn_cadastrar_marca;
        private System.Windows.Forms.Button btn_atualizar_marca;
        private System.Windows.Forms.Button btn_excluir_marca;
        private System.Windows.Forms.Button btn_excluir_modelo;
        private System.Windows.Forms.Button btn_atualizar_modelo;
        private System.Windows.Forms.Button btn_cadastrar_modelo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnt_home;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastros;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_cargo;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_cliente;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_modelo_marca;
        private System.Windows.Forms.RadioButton rb_desativado_marca;
        private System.Windows.Forms.RadioButton rb_ativado_marca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb_ativado_modelo;
        private System.Windows.Forms.RadioButton rb_desativado_modelo;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_funcionario;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_automovel;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_locacao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
    }
}