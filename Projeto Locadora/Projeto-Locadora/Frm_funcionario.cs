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

namespace Projeto_Locadora
{
    public partial class Frm_funcionario : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        int codigo, cargo_id, red;
        string fun_nome, fun_telefone, status;
        DateTime fun_dt_contrato;

        public Frm_funcionario()
        {
            InitializeComponent();
        }
        public void ListarTodosFuncionarios()
        {
            try
            {
                // Bloqueando redirecionamento do combobox
                red = 0;

                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select_funcionario = @"SELECT   f.TB_FUNCIONARIO_ID, 
                                                           f.TB_FUNCIONARIO_NOME,  
                                                           f.TB_FUNCIONARIO_TEL, 
                                                           f.TB_FUNCIONARIO_DT_CONTRATO, 
                                                           f.TB_FUNCIONARIO_STATUS, 
                                                           c.TB_CARGO_NOME  from tb_funcionario as f
       
                                                  inner join tb_cargo as c on (f.TB_CARGO_ID = c.TB_CARGO_ID)
                                                order by f.TB_FUNCIONARIO_ID";

                MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);

                con.Open();
                executacmdMySql_select_funcionario.ExecuteNonQuery();
                con.Close();

                DataTable tabela_funcionario = new DataTable();

                MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
                da_funcionario.Fill(tabela_funcionario);

                dgv_funcionario.DataSource = tabela_funcionario;

                // Combobox cargo
                string sqlselect = "select * from tb_cargo order by tb_cargo_nome";

                MySqlDataAdapter da = new MySqlDataAdapter(sqlselect, con);

                DataTable dtResultado = new DataTable();
                da.Fill(dtResultado);

                DataRow dr = dtResultado.NewRow();
                dr["TB_CARGO_ID"] = 0;
                dr["TB_CARGO_NOME"] = "Cadastrar um novo";

                dtResultado.Rows.InsertAt(dr, 0);

                // Define o combobox como não digitável
                cb_cargo_funcionario.DropDownStyle = ComboBoxStyle.DropDownList;

                cb_cargo_funcionario.DataSource = dtResultado;
                cb_cargo_funcionario.ValueMember = "TB_CARGO_ID";
                cb_cargo_funcionario.DisplayMember = "TB_CARGO_NOME";

                //Exibir as tabelas com outro nome e tamanho
                dgv_funcionario.Columns[0].HeaderText = "ID";
                dgv_funcionario.Columns[1].HeaderText = "NOME";
                dgv_funcionario.Columns[2].HeaderText = "TELEFONE";
                dgv_funcionario.Columns[3].HeaderText = "DATA CONTRATO";
                dgv_funcionario.Columns[4].HeaderText = "STATUS";
                dgv_funcionario.Columns[5].HeaderText = "CARGO";

                dgv_funcionario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_funcionario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_funcionario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_funcionario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_funcionario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_funcionario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                Limpar();

                // Permitindo redirecionamento do combobox
                red = 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        public void Limpar()
        {
            // Limpando os campos
            txt_nome_funcionario.Text = null;
            txt_tel_funcionario.Text = null;
            cb_cargo_funcionario.Text = null;
            txt_id_funcionario.Text = null;
            rb_ativado.Checked = true;
        }
        private void Btn_cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_funcionario.Text) || string.IsNullOrEmpty(cb_cargo_funcionario.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_insert = @"insert into tb_funcionario
                                    (
                                      TB_FUNCIONARIO_NOME, TB_FUNCIONARIO_TEL, TB_FUNCIONARIO_DT_CONTRATO, TB_FUNCIONARIO_STATUS, TB_CARGO_ID
                                    )VALUE (
                                        @TB_FUNCIONARIO_NOME, @TB_FUNCIONARIO_TEL, @TB_FUNCIONARIO_DT_CONTRATO, @TB_FUNCIONARIO_STATUS, @TB_CARGO_ID
                                    )";

                MySqlCommand executarcmdMySql_insert = new MySqlCommand(sql_insert, con);

                if (rb_ativado.Checked)
                {
                    status = "ATIVADO";
                }
                else
                {
                    status = "DESATIVADO";
                }

                fun_nome = txt_nome_funcionario.Text.ToUpper();
                fun_dt_contrato = Convert.ToDateTime(dtp_contrato_funcionario.Text);
                cargo_id = int.Parse(cb_cargo_funcionario.SelectedValue.ToString());

                executarcmdMySql_insert.Parameters.AddWithValue("@TB_FUNCIONARIO_NOME", fun_nome);
                executarcmdMySql_insert.Parameters.AddWithValue("@TB_FUNCIONARIO_DT_CONTRATO", fun_dt_contrato);
                executarcmdMySql_insert.Parameters.AddWithValue("@TB_FUNCIONARIO_STATUS", status);
                executarcmdMySql_insert.Parameters.AddWithValue("@TB_CARGO_ID", cargo_id);

                // Inserindo valor null caso não for digitado o valor
                if (string.IsNullOrEmpty(txt_tel_funcionario.Text))
                {
                    executarcmdMySql_insert.Parameters.AddWithValue("@TB_FUNCIONARIO_TEL", DBNull.Value);
                }
                else
                {
                    fun_telefone = txt_tel_funcionario.Text;
                    executarcmdMySql_insert.Parameters.AddWithValue("@TB_FUNCIONARIO_TEL", fun_telefone);
                }

                con.Open();
                executarcmdMySql_insert.ExecuteNonQuery();
                con.Close();

                ListarTodosFuncionarios();

                MessageBox.Show("Funcionario cadastrado com sucesso!");
            }
        }

        private void Frm_funcionario_Load(object sender, EventArgs e)
        {
            ListarTodosFuncionarios();
        }

        private void btn_atualizar_funcionario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_funcionario.Text) || string.IsNullOrEmpty(cb_cargo_funcionario.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                if (txt_id_funcionario.Value == 0 || string.IsNullOrEmpty(txt_id_funcionario.Text))
                {
                    // Se não for digitado o id
                    MessageBox.Show("Insira um código válido");
                }
                else
                {
                    codigo = int.Parse(txt_id_funcionario.Text);
                    fun_nome = txt_nome_funcionario.Text.ToUpper();
                    fun_dt_contrato = Convert.ToDateTime(dtp_contrato_funcionario.Text);
                    cargo_id = int.Parse(cb_cargo_funcionario.SelectedValue.ToString());

                    if (rb_ativado.Checked)
                    {
                        status = "ATIVADO";
                    }
                    else
                    {
                        status = "DESATIVADO";
                    }

                    MySqlConnection con = new MySqlConnection(conexao);

                    string sql_update_funcionario = @"update tb_funcionario
                                         set TB_FUNCIONARIO_NOME = @nome, 
                                             TB_FUNCIONARIO_TEL = @telefone,
                                             TB_FUNCIONARIO_DT_CONTRATO = @dt_contrato,
                                             TB_FUNCIONARIO_STATUS = @status,
                                             TB_CARGO_ID = @id
                                         where TB_FUNCIONARIO_ID = @codigo";

                    MySqlCommand executarcmdMySql_update_funcionario = new MySqlCommand(sql_update_funcionario, con);

                    executarcmdMySql_update_funcionario.Parameters.AddWithValue("@codigo", codigo);
                    executarcmdMySql_update_funcionario.Parameters.AddWithValue("@nome", fun_nome);
                    executarcmdMySql_update_funcionario.Parameters.AddWithValue("@dt_contrato", fun_dt_contrato);
                    executarcmdMySql_update_funcionario.Parameters.AddWithValue("@status", status);
                    executarcmdMySql_update_funcionario.Parameters.AddWithValue("@id", cargo_id);

                    // Inserindo valor null caso não for digitado o valor
                    if (string.IsNullOrEmpty(txt_tel_funcionario.Text))
                    {
                        executarcmdMySql_update_funcionario.Parameters.AddWithValue("@telefone", DBNull.Value);
                    }
                    else
                    {
                        fun_telefone = txt_tel_funcionario.Text;
                        executarcmdMySql_update_funcionario.Parameters.AddWithValue("@telefone", fun_telefone);
                    }

                    con.Open();
                    executarcmdMySql_update_funcionario.ExecuteNonQuery();
                    con.Close();

                    ListarTodosFuncionarios();

                    MessageBox.Show("Funcionário atualizado com sucesso!");
                }
            }
        }

        private void btn_excluir_funcionario_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = int.Parse(txt_id_funcionario.Text);

                MySqlConnection con = new MySqlConnection(conexao);

                string sql_delete_funcionario = @"delete from tb_funcionario where TB_FUNCIONARIO_ID = @codigo";

                MySqlCommand executarcmdMySql_delete_funcionario = new MySqlCommand(sql_delete_funcionario, con);

                executarcmdMySql_delete_funcionario.Parameters.AddWithValue("@codigo", codigo);

                con.Open();
                executarcmdMySql_delete_funcionario.ExecuteNonQuery();
                con.Close();

                ListarTodosFuncionarios();

                MessageBox.Show("Funcionario deletado com sucesso!");
            }
            catch (Exception erro)
            {
                string title = "Não foi possível deletar o funcionário";
                if (MessageBox.Show("Esse registro está anexado à outro", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    MessageBox.Show(erro.ToString(), "Erro:");
                }
            }
        }

        private void Dgv_funcionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id_funcionario.Text = dgv_funcionario.CurrentRow.Cells[0].Value.ToString();
                txt_nome_funcionario.Text = dgv_funcionario.CurrentRow.Cells[1].Value.ToString();
                txt_tel_funcionario.Text = dgv_funcionario.CurrentRow.Cells[2].Value.ToString();
                dtp_contrato_funcionario.Text = dgv_funcionario.CurrentRow.Cells[3].Value.ToString();
                cb_cargo_funcionario.Text = dgv_funcionario.CurrentRow.Cells[5].Value.ToString();

                if (dgv_funcionario.CurrentRow.Cells[4].Value.ToString() == "ATIVADO")
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

        private void mnt_cadastrar_cargo_Click(object sender, EventArgs e)
        {
            Frm_cargo novo = new Frm_cargo();
            novo.Show();
            this.Hide();
        }

        private void mnt_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            Frm_cliente novo = new Frm_cliente();
            novo.Show();
            this.Hide();
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

        private void cb_cargo_funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (red == 1)
            {
                if (cb_cargo_funcionario.Text == "Cadastrar um novo")
                {
                    Frm_cargo cargo = new Frm_cargo();
                    cargo.Show();
                    this.Hide();
                    red = 0;
                }
            }
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

        private void mnt_home_Click(object sender, EventArgs e)
        {
            Frm_menu novo = new Frm_menu();
            novo.Show();
            this.Hide();
        }
    }
}
