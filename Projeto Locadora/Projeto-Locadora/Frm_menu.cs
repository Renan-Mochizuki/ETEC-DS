using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Locadora
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }

        private void btn_cad_cliente_Click(object sender, EventArgs e)
        {
            Frm_cliente novo = new Frm_cliente();
            novo.Show();
            this.Hide();
        }

        private void btn_cad_cargo_Click(object sender, EventArgs e)
        {
            Frm_cargo novo = new Frm_cargo();
            novo.Show();
            this.Hide();
        }

        private void btn_cad_modelo_marca_Click(object sender, EventArgs e)
        {
            Frm_marca_modelo novo = new Frm_marca_modelo();
            novo.Show();
            this.Hide();
        }

        private void btn_cad_funcionario_Click(object sender, EventArgs e)
        {
            Frm_funcionario novo = new Frm_funcionario();
            novo.Show();
            this.Hide();
        }

        private void btn_cad_automovel_Click(object sender, EventArgs e)
        {
            Frm_automovel novo = new Frm_automovel();
            novo.Show();
            this.Hide();
        }

        private void btn_cad_locacao_Click(object sender, EventArgs e)
        {
            Frm_locacao novo = new Frm_locacao();
            novo.Show();
            this.Hide();
        }

        private void Frm_menu_Load(object sender, EventArgs e)
        {
            // Definindo borda branca nos botões
            btn_cad_cargo.FlatStyle = FlatStyle.Flat;
            btn_cad_cargo.FlatAppearance.BorderColor = Color.White;
            btn_cad_cargo.FlatAppearance.BorderSize = 3;
            btn_cad_automovel.FlatStyle = FlatStyle.Flat;
            btn_cad_automovel.FlatAppearance.BorderColor = Color.White;
            btn_cad_automovel.FlatAppearance.BorderSize = 3;
            btn_cad_cliente.FlatStyle = FlatStyle.Flat;
            btn_cad_cliente.FlatAppearance.BorderColor = Color.White;
            btn_cad_cliente.FlatAppearance.BorderSize = 3;
            btn_cad_locacao.FlatStyle = FlatStyle.Flat;
            btn_cad_locacao.FlatAppearance.BorderColor = Color.White;
            btn_cad_locacao.FlatAppearance.BorderSize = 3;
            btn_cad_modelo_marca.FlatStyle = FlatStyle.Flat;
            btn_cad_modelo_marca.FlatAppearance.BorderColor = Color.White;
            btn_cad_modelo_marca.FlatAppearance.BorderSize = 3;
            btn_cad_funcionario.FlatStyle = FlatStyle.Flat;
            btn_cad_funcionario.FlatAppearance.BorderColor = Color.White;
            btn_cad_funcionario.FlatAppearance.BorderSize = 3;
        }
    }
}
