using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Locadora
{
    public partial class Frm_login : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario, senha;

            usuario = txt_usuario.Text;
            senha = txt_senha.Text;

            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_senha.Text))
            {
                MessageBox.Show("Insira as informações");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select = @"select * from tb_login";

                MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select, con);

                con.Open();
                executacmdMySql_select.ExecuteNonQuery();
                con.Close();

                DataTable dt = new DataTable();

                MySqlDataAdapter adap = new MySqlDataAdapter(executacmdMySql_select);
                adap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr.Field<string>("TB_LOGIN_USUARIO") == usuario && dr.Field<string>("TB_LOGIN_SENHA") == senha)
                    {
                        Frm_menu novo = new Frm_menu();
                        novo.Show();
                        this.Hide();
                    }
                    else if(dr.Field<string>("TB_LOGIN_USUARIO") == usuario)
                    {
                        MessageBox.Show("Senha incorreta");
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado");
                    }
                }
            }
        }
    }
}
