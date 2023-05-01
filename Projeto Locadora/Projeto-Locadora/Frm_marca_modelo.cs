using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Locadora
{
    public partial class Frm_marca_modelo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        string nome, status, desc;
        int codigo;
        public void ListarTodasMarcas()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select_marca = "select * from tb_marca";

                MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);

                con.Open();
                executacmdMySql_select_marca.ExecuteNonQuery();
                con.Close();

                DataTable tabela_marca = new DataTable();

                MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
                da_marca.Fill(tabela_marca);

                dgv_marca.DataSource = tabela_marca;

                //Exibir as tabelas com outro nome e tamanho
                dgv_marca.Columns[0].HeaderText = "ID";
                dgv_marca.Columns[1].HeaderText = "NOME";
                dgv_marca.Columns[2].HeaderText = "STATUS";

                dgv_marca.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_marca.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_marca.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                LimparMarca();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        public void LimparMarca()
        {
            // Limpando os campos
            txt_nome_marca.Text = null;
            txt_id_marca.Text = null;
            rb_ativado_marca.Checked = true;
        }

        public void ListarTodosModelos()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select_modelo = "select * from tb_modelo";

                MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);

                con.Open();
                executacmdMySql_select_modelo.ExecuteNonQuery();
                con.Close();

                DataTable tabela_modelo = new DataTable();

                MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_modelo);
                da_marca.Fill(tabela_modelo);

                dgv_modelo.DataSource = tabela_modelo;

                //Exibir as tabelas com outro nome e tamanho
                dgv_modelo.Columns[0].HeaderText = "ID";
                dgv_modelo.Columns[1].HeaderText = "DESCRIÇÃO";
                dgv_modelo.Columns[2].HeaderText = "STATUS";

                dgv_modelo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_modelo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_modelo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                LimparModelo();
                }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        public void LimparModelo()
        {
            // Limpando os campos
            txt_desc_modelo.Text = null;
            txt_id_modelo.Text = null;
            rb_ativado_modelo.Checked = true;
        }

        public Frm_marca_modelo()
        {
            InitializeComponent();
        }
        private void Frm_marca_modelo_Load(object sender, EventArgs e)
        {
            ListarTodasMarcas();

            ListarTodosModelos();

        }
        private void Btn_cadastrar_marca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_marca.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(conexao);

                nome = txt_nome_marca.Text.ToUpper();

                if (rb_ativado_marca.Checked)
                {
                    status = "ATIVADO";
                }
                else
                {
                    status = "DESATIVADO";
                }

                string sql_insert = @"insert into tb_marca
                                      (
                                        TB_MARCA_NOME,
                                        TB_MARCA_STATUS
                                      )
                                      value
                                      (
                                        @marca_nome,
                                        @marca_status
                                      )";

                MySqlCommand execultacmdMySql_insert = new MySqlCommand(sql_insert, con);

                execultacmdMySql_insert.Parameters.AddWithValue("@marca_nome", nome);
                execultacmdMySql_insert.Parameters.AddWithValue("@marca_status", status);

                con.Open();
                execultacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                ListarTodasMarcas();

                MessageBox.Show("Marca Cadastrada com sucesso");
            }
        }

        private void Btn_cadastrar_modelo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_desc_modelo.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(conexao);

                desc = txt_desc_modelo.Text.ToUpper();

                if (rb_ativado_marca.Checked)
                {
                    status = "ATIVADO";
                }
                else
                {
                    status = "DESATIVADO";
                }

                string sql_insert = @"insert into tb_modelo
                                      (
                                        TB_MODELO_DESC,
                                        TB_MODELO_STATUS
                                      )
                                      value
                                      (
                                        @modelo_desc,
                                        @modelo_status
                                      )";

                MySqlCommand execultacmdMySql_insert = new MySqlCommand(sql_insert, con);

                execultacmdMySql_insert.Parameters.AddWithValue("@modelo_desc", desc);
                execultacmdMySql_insert.Parameters.AddWithValue("@modelo_status", status);

                con.Open();
                execultacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                ListarTodosModelos();

                MessageBox.Show("Modelo Cadastrado com sucesso");
            }
        }
        private void Btn_atualizar_modelo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_desc_modelo.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete os campos");
            }
            else
            {
                if (txt_id_modelo.Value == 0 || string.IsNullOrEmpty(txt_id_modelo.Text))
                {
                    // Se não for digitado o id
                    MessageBox.Show("Insira um código válido");
                }
                else
                {
                    codigo = int.Parse(txt_id_modelo.Text);
                    desc = txt_desc_modelo.Text.ToUpper();

                    if (rb_ativado_modelo.Checked)
                    {
                        status = "ATIVADO";
                    }
                    else
                    {
                        status = "DESATIVADO";
                    }

                    MySqlConnection con = new MySqlConnection(conexao);

                    string sql_update = @"update tb_modelo
                                  set TB_MODELO_DESC = @desc,
                                        TB_MODELO_STATUS = @status
                                  where TB_MODELO_ID = @id";

                    MySqlCommand execultacmdMySql_update = new MySqlCommand(sql_update, con);

                    execultacmdMySql_update.Parameters.AddWithValue("@desc", desc);
                    execultacmdMySql_update.Parameters.AddWithValue("@status", status);
                    execultacmdMySql_update.Parameters.AddWithValue("@id", codigo);

                    con.Open();
                    execultacmdMySql_update.ExecuteNonQuery();
                    con.Close();

                    ListarTodosModelos();

                    MessageBox.Show("Modelo Atualizado com sucesso");
                }
            }
        }
        private void Btn_atualizar_marca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_marca.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete os campos");
            }
            else
            {
                if (txt_id_marca.Value == 0 || string.IsNullOrEmpty(txt_id_marca.Text))
                {
                    // Se não for digitado o id
                    MessageBox.Show("Insira um código válido");
                }
                else
                {
                    codigo = int.Parse(txt_id_marca.Text);
                    nome = txt_nome_marca.Text.ToUpper();

                    if (rb_ativado_marca.Checked)
                    {
                        status = "ATIVADO";
                    }
                    else
                    {
                        status = "DESATIVADO";
                    }

                    MySqlConnection con = new MySqlConnection(conexao);

                    string sql_update = @"update tb_marca
                                  set TB_MARCA_NOME = @nome,
                                      TB_MARCA_STATUS = @status
                                  where TB_MARCA_ID = @id";

                    MySqlCommand execultacmdMySql_update = new MySqlCommand(sql_update, con);

                    execultacmdMySql_update.Parameters.AddWithValue("@nome", nome);
                    execultacmdMySql_update.Parameters.AddWithValue("@status", status);
                    execultacmdMySql_update.Parameters.AddWithValue("@id", codigo);

                    con.Open();
                    execultacmdMySql_update.ExecuteNonQuery();
                    con.Close();

                    ListarTodasMarcas();

                    MessageBox.Show("Marca Atualizada com sucesso");
                }
            }
        }
        private void Btn_excluir_modelo_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = int.Parse(txt_id_modelo.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                
                string sql_delete = @"delete from tb_modelo where TB_MODELO_ID = @codigo";

                MySqlCommand executacmdMysql_delete = new MySqlCommand(sql_delete, con);

                executacmdMysql_delete.Parameters.AddWithValue("@codigo", codigo);

                con.Open();
                executacmdMysql_delete.ExecuteNonQuery();
                con.Close();

                ListarTodosModelos();

                MessageBox.Show("Modelo deletado com sucesso");
            }
            catch (Exception erro)
            {
                string title = "Não foi possível deletar o modelo";
                if (MessageBox.Show("Esse registro está anexado à outro", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    MessageBox.Show(erro.ToString(), "Erro:");
                }
            }
        }

        private void Dgv_marca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            { 
            txt_id_marca.Value = int.Parse(dgv_marca.CurrentRow.Cells[0].Value.ToString());
            txt_nome_marca.Text = dgv_marca.CurrentRow.Cells[1].Value.ToString();

                if (dgv_marca.CurrentRow.Cells[2].Value.ToString() == "ATIVADO")
                {
                    rb_ativado_marca.Checked = true;
                }
                else
                {
                    rb_desativado_marca.Checked = true;
                }
            }
            catch
            {
                LimparMarca();
            }
        }

        private void Dgv_modelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id_modelo.Value = int.Parse(dgv_modelo.CurrentRow.Cells[0].Value.ToString());
                txt_desc_modelo.Text = dgv_modelo.CurrentRow.Cells[1].Value.ToString();
            if (dgv_modelo.CurrentRow.Cells[2].Value.ToString() == "ATIVADO")
            {
                rb_ativado_modelo.Checked = true;
            }
            else
            {
                rb_desativado_modelo.Checked = true;
            }
        }
            catch
            {
                LimparModelo();
            }
}

        private void Btn_excluir_marca_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = int.Parse(txt_id_marca.Text);

                MySqlConnection con = new MySqlConnection(conexao);

                string sql_delete = @"delete from tb_marca where TB_MARCA_ID = @codigo";

                MySqlCommand executacmdMysql_delete = new MySqlCommand(sql_delete, con);

                executacmdMysql_delete.Parameters.AddWithValue("@codigo", codigo);

                con.Open();
                executacmdMysql_delete.ExecuteNonQuery();
                con.Close();

                ListarTodasMarcas();

                MessageBox.Show("Marca deletada com sucesso");
            }
            catch (Exception erro)
            {
                string title = "Não foi possível deletar a marca";
                if (MessageBox.Show("Esse registro está anexado à outro", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    MessageBox.Show(erro.ToString(), "Erro:");
                }
            }
        }

        private void Mnt_home_Click(object sender, EventArgs e)
        {
            Frm_menu novo = new Frm_menu();
            novo.Show();
            this.Hide();
        }

        private void Mnt_cadastrar_cargo_Click(object sender, EventArgs e)
        {
            Frm_cargo novo = new Frm_cargo();
            novo.Show();
            this.Hide();
        }

        private void Mnt_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            Frm_cliente novo = new Frm_cliente();
            novo.Show();
            this.Hide();
        }

        private void Mnt_cadastrar_modelo_marca_Click(object sender, EventArgs e)
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
    }
}
