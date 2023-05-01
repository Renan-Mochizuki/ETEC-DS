namespace Projeto_Locadora
{
    partial class Frm_cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cargo));
            this.btn_excluir_cargo = new System.Windows.Forms.Button();
            this.btn_atualizar_cargo = new System.Windows.Forms.Button();
            this.DgvLIstarCargo = new System.Windows.Forms.DataGridView();
            this.btn_cadastrar_cargo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome_cargo = new System.Windows.Forms.TextBox();
            this.txt_id_cargo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_desativado = new System.Windows.Forms.RadioButton();
            this.rb_ativado = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvLIstarCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_cargo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_excluir_cargo
            // 
            this.btn_excluir_cargo.BackColor = System.Drawing.Color.OldLace;
            this.btn_excluir_cargo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_excluir_cargo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_excluir_cargo.Location = new System.Drawing.Point(756, 604);
            this.btn_excluir_cargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluir_cargo.Name = "btn_excluir_cargo";
            this.btn_excluir_cargo.Size = new System.Drawing.Size(156, 59);
            this.btn_excluir_cargo.TabIndex = 19;
            this.btn_excluir_cargo.Text = "Excluir";
            this.btn_excluir_cargo.UseVisualStyleBackColor = false;
            this.btn_excluir_cargo.Click += new System.EventHandler(this.btn_excluir_cargo_Click);
            // 
            // btn_atualizar_cargo
            // 
            this.btn_atualizar_cargo.BackColor = System.Drawing.Color.OldLace;
            this.btn_atualizar_cargo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_atualizar_cargo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_atualizar_cargo.Location = new System.Drawing.Point(515, 604);
            this.btn_atualizar_cargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atualizar_cargo.Name = "btn_atualizar_cargo";
            this.btn_atualizar_cargo.Size = new System.Drawing.Size(159, 59);
            this.btn_atualizar_cargo.TabIndex = 18;
            this.btn_atualizar_cargo.Text = "Atualizar";
            this.btn_atualizar_cargo.UseVisualStyleBackColor = false;
            this.btn_atualizar_cargo.Click += new System.EventHandler(this.btn_atualizar_cargo_Click);
            // 
            // DgvLIstarCargo
            // 
            this.DgvLIstarCargo.BackgroundColor = System.Drawing.Color.White;
            this.DgvLIstarCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLIstarCargo.Location = new System.Drawing.Point(428, 386);
            this.DgvLIstarCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvLIstarCargo.Name = "DgvLIstarCargo";
            this.DgvLIstarCargo.RowHeadersWidth = 51;
            this.DgvLIstarCargo.Size = new System.Drawing.Size(381, 199);
            this.DgvLIstarCargo.TabIndex = 17;
            this.DgvLIstarCargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLIstarCargo_CellClick);
            // 
            // btn_cadastrar_cargo
            // 
            this.btn_cadastrar_cargo.BackColor = System.Drawing.Color.OldLace;
            this.btn_cadastrar_cargo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btn_cadastrar_cargo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cadastrar_cargo.Location = new System.Drawing.Point(261, 604);
            this.btn_cadastrar_cargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cadastrar_cargo.Name = "btn_cadastrar_cargo";
            this.btn_cadastrar_cargo.Size = new System.Drawing.Size(165, 59);
            this.btn_cadastrar_cargo.TabIndex = 16;
            this.btn_cadastrar_cargo.Text = "Cadastrar";
            this.btn_cadastrar_cargo.UseVisualStyleBackColor = false;
            this.btn_cadastrar_cargo.Click += new System.EventHandler(this.btn_cadastrar_cargo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // txt_nome_cargo
            // 
            this.txt_nome_cargo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nome_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_cargo.Location = new System.Drawing.Point(553, 219);
            this.txt_nome_cargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nome_cargo.Name = "txt_nome_cargo";
            this.txt_nome_cargo.Size = new System.Drawing.Size(256, 34);
            this.txt_nome_cargo.TabIndex = 13;
            // 
            // txt_id_cargo
            // 
            this.txt_id_cargo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_id_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_cargo.Location = new System.Drawing.Point(553, 159);
            this.txt_id_cargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_cargo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_id_cargo.Name = "txt_id_cargo";
            this.txt_id_cargo.Size = new System.Drawing.Size(256, 34);
            this.txt_id_cargo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(417, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 55);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cadastro cargo";
            // 
            // rb_desativado
            // 
            this.rb_desativado.AutoSize = true;
            this.rb_desativado.BackColor = System.Drawing.Color.Transparent;
            this.rb_desativado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_desativado.Location = new System.Drawing.Point(553, 324);
            this.rb_desativado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_desativado.Name = "rb_desativado";
            this.rb_desativado.Size = new System.Drawing.Size(163, 32);
            this.rb_desativado.TabIndex = 55;
            this.rb_desativado.TabStop = true;
            this.rb_desativado.Text = "Desativado";
            this.rb_desativado.UseVisualStyleBackColor = false;
            // 
            // rb_ativado
            // 
            this.rb_ativado.AutoSize = true;
            this.rb_ativado.BackColor = System.Drawing.Color.Transparent;
            this.rb_ativado.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ativado.Location = new System.Drawing.Point(553, 287);
            this.rb_ativado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ativado.Name = "rb_ativado";
            this.rb_ativado.Size = new System.Drawing.Size(124, 32);
            this.rb_ativado.TabIndex = 54;
            this.rb_ativado.TabStop = true;
            this.rb_ativado.Text = "Ativado";
            this.rb_ativado.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 56;
            this.label4.Text = "Status:";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Olive;
            this.label12.Location = new System.Drawing.Point(806, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 28);
            this.label12.TabIndex = 164;
            this.label12.Text = "*";
            // 
            // Frm_cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Locadora.Properties.Resources.novo_fundo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_desativado);
            this.Controls.Add(this.rb_ativado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_cargo);
            this.Controls.Add(this.btn_excluir_cargo);
            this.Controls.Add(this.btn_atualizar_cargo);
            this.Controls.Add(this.DgvLIstarCargo);
            this.Controls.Add(this.btn_cadastrar_cargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome_cargo);
            this.Controls.Add(this.label12);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_cargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLIstarCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id_cargo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_excluir_cargo;
        private System.Windows.Forms.Button btn_atualizar_cargo;
        private System.Windows.Forms.DataGridView DgvLIstarCargo;
        private System.Windows.Forms.Button btn_cadastrar_cargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome_cargo;
        private System.Windows.Forms.NumericUpDown txt_id_cargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_desativado;
        private System.Windows.Forms.RadioButton rb_ativado;
        private System.Windows.Forms.Label label4;
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
    }
}