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
    public partial class Frm_cargo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        int codigo;
        string nome, status;

        public void ListarTodosCargos()
        {
            try
            {
                string sql_select_cargo = "select * from tb_cargo";

                MySqlConnection con = new MySqlConnection(conexao);

                MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);

                con.Open();
                executacmdMySql_select_cargo.ExecuteNonQuery();
                con.Close();
                
                DataTable tabela_cargo = new DataTable();
                
                MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                da_cargo.Fill(tabela_cargo);
                
                DgvLIstarCargo.DataSource = tabela_cargo;

                //Exibir as tabelas com outro nome e tamanho
                DgvLIstarCargo.Columns[0].HeaderText = "ID";
                DgvLIstarCargo.Columns[1].HeaderText = "NOME";
                DgvLIstarCargo.Columns[2].HeaderText = "STATUS";

                DgvLIstarCargo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DgvLIstarCargo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DgvLIstarCargo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                Limpar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        public void Limpar()
        {
            // Limpando os campos
            txt_id_cargo.Text = null;
            txt_nome_cargo.Text = null;
            rb_ativado.Checked = true;
        }

        public Frm_cargo()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_cargo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_cargo.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(conexao);

                nome = txt_nome_cargo.Text.ToUpper();

                if (rb_ativado.Checked)
                {
                    status = "ATIVADO";
                }
                else
                {
                    status = "DESATIVADO";
                }

                string sql_insert = @"insert into tb_cargo
                                    (
                                       tb_cargo_nome,
                                       tb_cargo_status
                                    )
                                    values
                                    (
                                      @cargo_nome,
                                      @cargo_status
                                    )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@cargo_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@cargo_status", status);

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                ListarTodosCargos();

                MessageBox.Show("Cargo cadastrado com sucesso!");
            }
        }

        private void Frm_cargo_Load(object sender, EventArgs e)
        {
            ListarTodosCargos();
        }

        private void DgvLIstarCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id_cargo.Text = DgvLIstarCargo.CurrentRow.Cells[0].Value.ToString();
                txt_nome_cargo.Text = DgvLIstarCargo.CurrentRow.Cells[1].Value.ToString();

                if (DgvLIstarCargo.CurrentRow.Cells[2].Value.ToString() == "ATIVADO")
                {
                    rb_ativado.Checked = true;
                }
                else
                {
                    rb_desativado.Checked = true;
                }
            }
            catch
            {
                Limpar();
            }
        }

        private void btn_atualizar_cargo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_cargo.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                if (txt_id_cargo.Value == 0 || string.IsNullOrEmpty(txt_id_cargo.Text))
                {
                    // Se não for digitado o id
                    MessageBox.Show("Insira um código válido");
                }
                else
                {
                    if (rb_ativado.Checked)
                    {
                        status = "ATIVADO";
                    }
                    else
                    {
                        status = "DESATIVADO";
                    }

                    codigo = int.Parse(txt_id_cargo.Text);
                    nome = txt_nome_cargo.Text.ToUpper();

                    MySqlConnection con = new MySqlConnection(conexao);

                    string sql_update_cargo = @"update tb_cargo
                                       set TB_CARGO_NOME = @nome,
                                            TB_CARGO_STATUS = @status
                                       where TB_CARGO_ID = @id";

                    MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);

                    executacmdMySql_update_cargo.Parameters.AddWithValue("@nome", nome);
                    executacmdMySql_update_cargo.Parameters.AddWithValue("@status", status);
                    executacmdMySql_update_cargo.Parameters.AddWithValue("@id", codigo);

                    con.Open();
                    executacmdMySql_update_cargo.ExecuteNonQuery();
                    con.Close();

                    ListarTodosCargos();

                    MessageBox.Show("Cargo atualizado com sucesso!");
                }
            }
        }

        private void btn_excluir_cargo_Click(object sender, EventArgs e)
        {
            try
            { 
                codigo = int.Parse(txt_id_cargo.Text);

                MySqlConnection con = new MySqlConnection(conexao);

                string sql_delete_cargo = @"delete from tb_cargo where TB_CARGO_ID = @codigo";

                MySqlCommand executarcmdMySql_delete_cargo = new MySqlCommand(sql_delete_cargo, con);

                executarcmdMySql_delete_cargo.Parameters.AddWithValue("@codigo", codigo);

                con.Open();
                executarcmdMySql_delete_cargo.ExecuteNonQuery();
                con.Close();

                ListarTodosCargos();

                MessageBox.Show("Cargo deletado com sucesso!");
            }
            catch (Exception erro)
            {
                string title = "Não foi possível deletar o cargo";
                if(MessageBox.Show("Esse registro está anexado à outro", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes){
                    MessageBox.Show(erro.ToString(), "Erro:");
                }
            }
        }

        private void mnt_cadastrar_modelo_marca_Click(object sender, EventArgs e)
        {
            Frm_marca_modelo novo = new Frm_marca_modelo();
            novo.Show();
            this.Hide();
        }

        private void mnt_cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            Frm_funcionario novo = new Frm_funcionario();
            novo.Show();
            this.Hide();
        }

        private void mnt_cadastrar_automovel_Click(object sender, EventArgs e)
        {
            Frm_automovel novo = new Frm_automovel();
            novo.Show();
            this.Hide();
        }

        private void mnt_cadastrar_locacao_Click(object sender, EventArgs e)
        {
            Frm_locacao novo = new Frm_locacao();
            novo.Show();
            this.Hide();
        }

        private void mnt_cadastrar_cargo_Click(object sender, EventArgs e)
        {
            Frm_cargo novo = new Frm_cargo();
            novo.Show();
            this.Hide();
        }

        private void mnt_home_Click(object sender, EventArgs e)
        {
            Frm_menu novo = new Frm_menu();
            novo.Show();
            this.Hide();
        }

        private void mnt_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            Frm_cliente novo = new Frm_cliente();
            novo.Show();
            this.Hide();
        }
    }
}
