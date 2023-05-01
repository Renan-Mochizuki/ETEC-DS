namespace Projeto_Locadora
{
    partial class Frm_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_funcionario));
            this.txt_tel_funcionario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_funcionario = new System.Windows.Forms.NumericUpDown();
            this.txt_nome_funcionario = new System.Windows.Forms.TextBox();
            this.btn_excluir_funcionario = new System.Windows.Forms.Button();
            this.btn_atualizar_funcionario = new System.Windows.Forms.Button();
            this.btn_cadastrar_funcionario = new System.Windows.Forms.Button();
            this.dgv_funcionario = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_contrato_funcionario = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_cargo_funcionario = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rb_desativado = new System.Windows.Forms.RadioButton();
            this.rb_ativado = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnt_home = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_cargo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_modelo_marca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_automovel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnt_cadastrar_locacao = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tel_funcionario
            // 
            this.txt_tel_funcionario.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tel_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel_funcionario.Location = new System.Drawing.Point(193, 236);
            this.txt_tel_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tel_funcionario.Name = "txt_tel_funcionario";
            this.txt_tel_funcionario.Size = new System.Drawing.Size(235, 30);
            this.txt_tel_funcionario.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(457, 239);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 28);
            this.label14.TabIndex = 75;
            this.label14.Text = "Data Contrato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 65;
            this.label2.Text = "Telefone:";
            // 
            // txt_id_funcionario
            // 
            this.txt_id_funcionario.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_funcionario.Location = new System.Drawing.Point(205, 159);
            this.txt_id_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_funcionario.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_id_funcionario.Name = "txt_id_funcionario";
            this.txt_id_funcionario.Size = new System.Drawing.Size(68, 30);
            this.txt_id_funcionario.TabIndex = 64;
            // 
            // txt_nome_funcionario
            // 
            this.txt_nome_funcionario.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nome_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_funcionario.Location = new System.Drawing.Point(387, 155);
            this.txt_nome_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome_funcionario.Name = "txt_nome_funcionario";
            this.txt_nome_funcionario.Size = new System.Drawing.Size(269, 30);
            this.txt_nome_funcionario.TabIndex = 63;
            // 
            // btn_excluir_funcionario
            // 
            this.btn_excluir_funcionario.BackColor = System.Drawing.Color.OldLace;
            this.btn_excluir_funcionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_excluir_funcionario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_excluir_funcionario.Location = new System.Drawing.Point(759, 612);
            this.btn_excluir_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir_funcionario.Name = "btn_excluir_funcionario";
            this.btn_excluir_funcionario.Size = new System.Drawing.Size(145, 49);
            this.btn_excluir_funcionario.TabIndex = 62;
            this.btn_excluir_funcionario.Text = "Excluir";
            this.btn_excluir_funcionario.UseVisualStyleBackColor = false;
            this.btn_excluir_funcionario.Click += new System.EventHandler(this.btn_excluir_funcionario_Click);
            // 
            // btn_atualizar_funcionario
            // 
            this.btn_atualizar_funcionario.BackColor = System.Drawing.Color.OldLace;
            this.btn_atualizar_funcionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_atualizar_funcionario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_atualizar_funcionario.Location = new System.Drawing.Point(512, 612);
            this.btn_atualizar_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atualizar_funcionario.Name = "btn_atualizar_funcionario";
            this.btn_atualizar_funcionario.Size = new System.Drawing.Size(145, 49);
            this.btn_atualizar_funcionario.TabIndex = 61;
            this.btn_atualizar_funcionario.Text = "Atualizar";
            this.btn_atualizar_funcionario.UseVisualStyleBackColor = false;
            this.btn_atualizar_funcionario.Click += new System.EventHandler(this.btn_atualizar_funcionario_Click);
            // 
            // btn_cadastrar_funcionario
            // 
            this.btn_cadastrar_funcionario.BackColor = System.Drawing.Color.OldLace;
            this.btn_cadastrar_funcionario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_cadastrar_funcionario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cadastrar_funcionario.Location = new System.Drawing.Point(275, 612);
            this.btn_cadastrar_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cadastrar_funcionario.Name = "btn_cadastrar_funcionario";
            this.btn_cadastrar_funcionario.Size = new System.Drawing.Size(145, 49);
            this.btn_cadastrar_funcionario.TabIndex = 60;
            this.btn_cadastrar_funcionario.Text = "Cadastrar";
            this.btn_cadastrar_funcionario.UseVisualStyleBackColor = false;
            this.btn_cadastrar_funcionario.Click += new System.EventHandler(this.Btn_cadastrar_funcionario_Click);
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.BackgroundColor = System.Drawing.Color.White;
            this.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionario.Location = new System.Drawing.Point(124, 315);
            this.dgv_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.RowHeadersWidth = 51;
            this.dgv_funcionario.Size = new System.Drawing.Size(953, 274);
            this.dgv_funcionario.TabIndex = 59;
            this.dgv_funcionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_funcionario_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 58;
            this.label4.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(353, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 51);
            this.label1.TabIndex = 56;
            this.label1.Text = "Cadastro funcionário";
            // 
            // dtp_contrato_funcionario
            // 
            this.dtp_contrato_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_contrato_funcionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_contrato_funcionario.Location = new System.Drawing.Point(660, 236);
            this.dtp_contrato_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_contrato_funcionario.Name = "dtp_contrato_funcionario";
            this.dtp_contrato_funcionario.Size = new System.Drawing.Size(156, 30);
            this.dtp_contrato_funcionario.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(689, 156);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 28);
            this.label10.TabIndex = 71;
            this.label10.Text = "Cargo:";
            // 
            // cb_cargo_funcionario
            // 
            this.cb_cargo_funcionario.BackColor = System.Drawing.SystemColors.Window;
            this.cb_cargo_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cargo_funcionario.FormattingEnabled = true;
            this.cb_cargo_funcionario.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cb_cargo_funcionario.Location = new System.Drawing.Point(787, 154);
            this.cb_cargo_funcionario.Margin = new System.Windows.Forms.Padding(4);
            this.cb_cargo_funcionario.Name = "cb_cargo_funcionario";
            this.cb_cargo_funcionario.Size = new System.Drawing.Size(257, 33);
            this.cb_cargo_funcionario.TabIndex = 83;
            this.cb_cargo_funcionario.SelectedIndexChanged += new System.EventHandler(this.cb_cargo_funcionario_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(856, 239);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 28);
            this.label15.TabIndex = 93;
            this.label15.Text = "Status:";
            // 
            // rb_desativado
            // 
            this.rb_desativado.AutoSize = true;
            this.rb_desativado.BackColor = System.Drawing.Color.Transparent;
            this.rb_desativado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_desativado.Location = new System.Drawing.Point(969, 265);
            this.rb_desativado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_desativado.Name = "rb_desativado";
            this.rb_desativado.Size = new System.Drawing.Size(141, 27);
            this.rb_desativado.TabIndex = 92;
            this.rb_desativado.TabStop = true;
            this.rb_desativado.Text = "Desativado";
            this.rb_desativado.UseVisualStyleBackColor = false;
            // 
            // rb_ativado
            // 
            this.rb_ativado.AutoSize = true;
            this.rb_ativado.BackColor = System.Drawing.Color.Transparent;
            this.rb_ativado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ativado.Location = new System.Drawing.Point(969, 231);
            this.rb_ativado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ativado.Name = "rb_ativado";
            this.rb_ativado.Size = new System.Drawing.Size(108, 27);
            this.rb_ativado.TabIndex = 91;
            this.rb_ativado.TabStop = true;
            this.rb_ativado.Text = "Ativado";
            this.rb_ativado.UseVisualStyleBackColor = false;
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
            this.menuStrip1.TabIndex = 94;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Olive;
            this.label12.Location = new System.Drawing.Point(1043, 156);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 28);
            this.label12.TabIndex = 164;
            this.label12.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(655, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 28);
            this.label5.TabIndex = 165;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(813, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 28);
            this.label6.TabIndex = 166;
            this.label6.Text = "*";
            // 
            // Frm_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Locadora.Properties.Resources.novo_fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rb_desativado);
            this.Controls.Add(this.rb_ativado);
            this.Controls.Add(this.dtp_contrato_funcionario);
            this.Controls.Add(this.cb_cargo_funcionario);
            this.Controls.Add(this.txt_tel_funcionario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id_funcionario);
            this.Controls.Add(this.txt_nome_funcionario);
            this.Controls.Add(this.btn_excluir_funcionario);
            this.Controls.Add(this.btn_atualizar_funcionario);
            this.Controls.Add(this.btn_cadastrar_funcionario);
            this.Controls.Add(this.dgv_funcionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_tel_funcionario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_id_funcionario;
        private System.Windows.Forms.TextBox txt_nome_funcionario;
        private System.Windows.Forms.Button btn_excluir_funcionario;
        private System.Windows.Forms.Button btn_atualizar_funcionario;
        private System.Windows.Forms.Button btn_cadastrar_funcionario;
        private System.Windows.Forms.DataGridView dgv_funcionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_contrato_funcionario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_cargo_funcionario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rb_desativado;
        private System.Windows.Forms.RadioButton rb_ativado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnt_home;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastros;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_cargo;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_cliente;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_modelo_marca;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_funcionario;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_automovel;
        private System.Windows.Forms.ToolStripMenuItem mnt_cadastrar_locacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}