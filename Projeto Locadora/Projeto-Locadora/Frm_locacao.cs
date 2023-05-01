using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Locadora
{
    public partial class Frm_locacao : Form
    {

        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        string tipo;
        double valor;
        DateTime inicio, fim;
        int clid, funid, autom, id, red;
        public void ListarTodasLocacoes()
        {
            try
            {
                // Bloqueando redirecionamento do combobox
                red = 0;

                string sql_select_locacao = @"select TB_LOCACAO_ID, TB_LOCACAO_TIPO, TB_LOCACAO_VALOR, TB_LOCACAO_DT_INICIO, TB_LOCACAO_DT_FIM, TB_CLIENTE.TB_CLIENTE_NOME, tb_funcionario.TB_FUNCIONARIO_NOME, tb_automovel.TB_AUTOMOVEL_NOME from tb_locacao
                                                inner join tb_cliente on TB_LOCACAO.TB_CLIENTE_ID = tb_cliente.TB_CLIENTE_ID
                                                inner join tb_funcionario on tb_locacao.TB_FUNCIONARIO_ID = tb_funcionario.TB_FUNCIONARIO_ID
                                                inner join tb_automovel on tb_locacao.TB_AUTOMOVEL_ID = tb_automovel.TB_AUTOMOVEL_ID
                                                order by TB_LOCACAO_ID;";

                MySqlConnection con = new MySqlConnection(conexao);

                MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);

                con.Open();
                executacmdMySql_select_locacao.ExecuteNonQuery();
                con.Close();

                DataTable tabela_locacao = new DataTable();
                MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
                da_locacao.Fill(tabela_locacao);

                dgv_locacao.DataSource = tabela_locacao;

                // COMBO BOX CLIENTE
                string sql_select_cliente = "select * from tb_cliente";
                MySqlDataAdapter DA_cliente = new MySqlDataAdapter(sql_select_cliente, con);
                DataTable tabela_cliente = new DataTable();

                DA_cliente.Fill(tabela_cliente);

                DataRow drcli = tabela_cliente.NewRow();
                drcli["TB_CLIENTE_ID"] = 0;
                drcli["TB_CLIENTE_NOME"] = "Cadastrar um novo";

                tabela_cliente.Rows.InsertAt(drcli, 0);

                // Define o combobox como não digitável
                cb_cliente_locacao.DropDownStyle = ComboBoxStyle.DropDownList;

                cb_cliente_locacao.DataSource = tabela_cliente;
                cb_cliente_locacao.ValueMember = "TB_CLIENTE_ID";
                cb_cliente_locacao.DisplayMember = "TB_CLIENTE_NOME";
                

                // COMBO BOX AUTOMOVEL

                string sql_select_automovel = "select * from tb_automovel";
                MySqlDataAdapter DA_automovel = new MySqlDataAdapter(sql_select_automovel, con);
                DataTable tabela_automovel = new DataTable();

                DA_automovel.Fill(tabela_automovel);

                DataRow drauto = tabela_automovel.NewRow();
                drauto["TB_AUTOMOVEL_ID"] = 0;
                drauto["TB_AUTOMOVEL_NOME"] = "Cadastrar um novo";

                tabela_automovel.Rows.InsertAt(drauto, 0);

                // Define o combobox como não digitável
                cb_automovel_locacao.DropDownStyle = ComboBoxStyle.DropDownList;

                cb_automovel_locacao.DataSource = tabela_automovel;
                cb_automovel_locacao.ValueMember = "TB_AUTOMOVEL_ID";
                cb_automovel_locacao.DisplayMember = "TB_AUTOMOVEL_NOME";
                

                // COMBO BOX FUNCIONARIO

                string sql_select_funcionario = "select * from tb_funcionario";
                MySqlDataAdapter DA_funcionario = new MySqlDataAdapter(sql_select_funcionario, con);
                DataTable tabela_funcionario = new DataTable();

                DA_funcionario.Fill(tabela_funcionario);

                DataRow drfun = tabela_funcionario.NewRow();
                drfun["TB_FUNCIONARIO_ID"] = 0;
                drfun["TB_FUNCIONARIO_NOME"] = "Cadastrar um novo";

                tabela_funcionario.Rows.InsertAt(drfun, 0);

                // Define o combobox como não digitável
                cb_funcionario_locacao.DropDownStyle = ComboBoxStyle.DropDownList;

                cb_funcionario_locacao.DataSource = tabela_funcionario;
                cb_funcionario_locacao.ValueMember = "TB_FUNCIONARIO_ID";
                cb_funcionario_locacao.DisplayMember = "TB_FUNCIONARIO_NOME";

                //Exibir as tabelas com outro nome e tamanho
                dgv_locacao.Columns[0].HeaderText = "ID";
                dgv_locacao.Columns[1].HeaderText = "TIPO";
                dgv_locacao.Columns[2].HeaderText = "VALOR";
                dgv_locacao.Columns[3].HeaderText = "DATA INÍCIO";
                dgv_locacao.Columns[4].HeaderText = "DATA FIM";
                dgv_locacao.Columns[5].HeaderText = "CLIENTE";
                dgv_locacao.Columns[6].HeaderText = "FUNCIONÁRIO";
                dgv_locacao.Columns[7].HeaderText = "AUTOMÓVEL";

                dgv_locacao.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_locacao.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_locacao.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_locacao.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_locacao.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_locacao.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_locacao.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_locacao.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

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
            cb_cliente_locacao.SelectedItem = null;
            cb_automovel_locacao.SelectedItem = null;
            cb_funcionario_locacao.SelectedItem = null;
            txt_id_locacao.Text = null;
            txt_valor_locacao.Text = null;
            cb_tipo_locacao.Text = null;
            dtp_inicio_locacao.Text = DateTime.Now.ToString();
            dtp_fim_locacao.Text = DateTime.Now.ToString();
        }

        public Frm_locacao()
        {
            InitializeComponent();
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

        private void cb_cliente_locacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (red == 1)
            {
                if (cb_cliente_locacao.Text == "Cadastrar um novo")
                {
                    Frm_cliente redirecionamento = new Frm_cliente();
                    redirecionamento.Show();
                    this.Hide();
                    red = 0;
                }
            }
        }

        private void cb_funcionario_locacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (red == 1)
            {
                if (cb_funcionario_locacao.Text == "Cadastrar um novo")
                {
                    Frm_funcionario redirecionamento = new Frm_funcionario();
                    redirecionamento.Show();
                    this.Hide();
                    red = 0;
                }
            }
        }

        private void cb_automovel_locacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (red == 1)
            {
                if (cb_automovel_locacao.Text == "Cadastrar um novo")
                {
                    Frm_automovel redirecionamento = new Frm_automovel();
                    redirecionamento.Show();
                    this.Hide();
                    red = 0;
                }
            }
        }

        private void Frm_locacao_Load(object sender, EventArgs e)
        {
            ListarTodasLocacoes();
            // Define o combobox como não digitável
            cb_tipo_locacao.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_tipo_locacao.Text) || string.IsNullOrEmpty(txt_valor_locacao.Text) || string.IsNullOrEmpty(cb_automovel_locacao.Text) || string.IsNullOrEmpty(cb_cliente_locacao.Text) || string.IsNullOrEmpty(cb_funcionario_locacao.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_insert_locacao = @"insert into tb_locacao 
                                                (
                                                TB_LOCACAO_TIPO,
                                                TB_LOCACAO_VALOR,
                                                TB_LOCACAO_DT_INICIO,
                                                TB_LOCACAO_DT_FIM,
                                                TB_CLIENTE_ID,
                                                TB_FUNCIONARIO_ID,
                                                TB_AUTOMOVEL_ID
                                                )
                                                values 
                                                (
                                                @locacao_tipo,
                                                @locacao_valor,
                                                @locacao_dt_inicio,
                                                @locacao_dt_fim,
                                                @cliente_id,
                                                @funcionario_id,
                                                @automovel_id
                                                )";

                MySqlCommand executaMySql_insert_locacao = new MySqlCommand(sql_insert_locacao, con);

                tipo = cb_tipo_locacao.Text.ToUpper();
                valor = double.Parse(txt_valor_locacao.Text);
                clid = int.Parse(cb_cliente_locacao.SelectedValue.ToString());
                funid = int.Parse(cb_funcionario_locacao.SelectedValue.ToString());
                autom = int.Parse(cb_automovel_locacao.SelectedValue.ToString());

                executaMySql_insert_locacao.Parameters.AddWithValue("@locacao_tipo", tipo);
                executaMySql_insert_locacao.Parameters.AddWithValue("@locacao_valor", valor);
                executaMySql_insert_locacao.Parameters.AddWithValue("@cliente_id", clid);
                executaMySql_insert_locacao.Parameters.AddWithValue("@funcionario_id", funid);
                executaMySql_insert_locacao.Parameters.AddWithValue("@automovel_id", autom);

                // Inserindo valor null caso não for digitado o valor
                if (string.IsNullOrEmpty(dtp_inicio_locacao.Text))
                {
                    executaMySql_insert_locacao.Parameters.AddWithValue("@locacao_dt_inicio", DBNull.Value);
                }
                else
                {
                    inicio = Convert.ToDateTime(dtp_inicio_locacao.Text);
                    executaMySql_insert_locacao.Parameters.AddWithValue("@locacao_dt_inicio", inicio);
                }
                if (string.IsNullOrEmpty(dtp_fim_locacao.Text))
                {
                    executaMySql_insert_locacao.Parameters.AddWithValue("@locacao_dt_fim", DBNull.Value);
                }
                else
                {
                    fim = Convert.ToDateTime(dtp_fim_locacao.Text);
                    executaMySql_insert_locacao.Parameters.AddWithValue("@locacao_dt_fim", fim);
                }

                con.Open();
                executaMySql_insert_locacao.ExecuteNonQuery();
                con.Close();

                ListarTodasLocacoes();

                MessageBox.Show("Locação cadastrada com sucesso!");
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cb_tipo_locacao.Text) || string.IsNullOrEmpty(txt_valor_locacao.Text) || string.IsNullOrEmpty(cb_automovel_locacao.Text) || string.IsNullOrEmpty(cb_cliente_locacao.Text) || string.IsNullOrEmpty(cb_funcionario_locacao.Text))
            {
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                if (txt_id_locacao.Value == 0 || string.IsNullOrEmpty(txt_id_locacao.Text))
                {
                    // Se não for digitado o id
                    MessageBox.Show("Insira um código válido");
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string sql_update_locacao = @"update tb_locacao 
                                         set TB_LOCACAO_TIPO = @locacao_tipo, 
                                             TB_LOCACAO_VALOR = @locacao_valor,
                                             TB_LOCACAO_DT_INICIO = @locacao_dt_inicio,
                                             TB_LOCACAO_DT_FIM = @locacao_dt_fim,
                                             TB_CLIENTE_ID = @cliente_id,
                                             TB_FUNCIONARIO_ID = @funcionario_id,
                                             TB_AUTOMOVEL_ID = @automovel_id
                                         where TB_LOCACAO_ID = @codigo";

                    MySqlCommand executaMySql_update_locacao = new MySqlCommand(sql_update_locacao, con);

                    id = int.Parse(txt_id_locacao.Text);
                    tipo = cb_tipo_locacao.Text.ToUpper();
                    valor = double.Parse(txt_valor_locacao.Text);
                    clid = int.Parse(cb_cliente_locacao.SelectedValue.ToString());
                    funid = int.Parse(cb_funcionario_locacao.SelectedValue.ToString());
                    autom = int.Parse(cb_automovel_locacao.SelectedValue.ToString());

                    executaMySql_update_locacao.Parameters.AddWithValue("@locacao_tipo", tipo);
                    executaMySql_update_locacao.Parameters.AddWithValue("@locacao_valor", valor);
                    executaMySql_update_locacao.Parameters.AddWithValue("@cliente_id", clid);
                    executaMySql_update_locacao.Parameters.AddWithValue("@funcionario_id", funid);
                    executaMySql_update_locacao.Parameters.AddWithValue("@automovel_id", autom);
                    executaMySql_update_locacao.Parameters.AddWithValue("@codigo", id);

                    // Inserindo valor null caso não for digitado o valor
                    if (string.IsNullOrEmpty(dtp_inicio_locacao.Text))
                    {
                        executaMySql_update_locacao.Parameters.AddWithValue("@locacao_dt_inicio", DBNull.Value);
                    }
                    else
                    {
                        inicio = Convert.ToDateTime(dtp_inicio_locacao.Text);
                        executaMySql_update_locacao.Parameters.AddWithValue("@locacao_dt_inicio", inicio);
                    }
                    if (string.IsNullOrEmpty(dtp_fim_locacao.Text))
                    {
                        executaMySql_update_locacao.Parameters.AddWithValue("@locacao_dt_fim", DBNull.Value);
                    }
                    else
                    {
                        fim = Convert.ToDateTime(dtp_fim_locacao.Text);
                        executaMySql_update_locacao.Parameters.AddWithValue("@locacao_dt_fim", fim);
                    }

                    con.Open();
                    executaMySql_update_locacao.ExecuteNonQuery();
                    con.Close();

                    ListarTodasLocacoes();

                    MessageBox.Show("Locação atualizada com sucesso!");
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(txt_id_locacao.Text);

                MySqlConnection con = new MySqlConnection(conexao);

                string sql_delete_locacao = @" delete from tb_locacao
                                    where TB_LOCACAO_ID = @codigo";

                MySqlCommand executaMySql_delete_locacao = new MySqlCommand(sql_delete_locacao, con);

                executaMySql_delete_locacao.Parameters.AddWithValue("@codigo", id);

                con.Open();
                executaMySql_delete_locacao.ExecuteNonQuery();
                con.Close();

                ListarTodasLocacoes();

                MessageBox.Show("Locação deletada com sucesso!");
            }
            catch (Exception erro)
            {
                string title = "Não foi possível deletar a locação";
                if (MessageBox.Show("Esse registro está anexado à outro", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    MessageBox.Show(erro.ToString(), "Erro:");
                }
            }
        }

        private void dgv_locacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id_locacao.Value = int.Parse(dgv_locacao.CurrentRow.Cells[0].Value.ToString());
                cb_tipo_locacao.Text = dgv_locacao.CurrentRow.Cells[1].Value.ToString();
                txt_valor_locacao.Text = dgv_locacao.CurrentRow.Cells[2].Value.ToString();
                dtp_inicio_locacao.Text = dgv_locacao.CurrentRow.Cells[3].Value.ToString();
                dtp_fim_locacao.Text = dgv_locacao.CurrentRow.Cells[4].Value.ToString();
                cb_cliente_locacao.Text = dgv_locacao.CurrentRow.Cells[5].Value.ToString();
                cb_funcionario_locacao.Text = dgv_locacao.CurrentRow.Cells[6].Value.ToString();
                cb_automovel_locacao.Text = dgv_locacao.CurrentRow.Cells[7].Value.ToString();
            }
            catch
            {
                Limpar();
            }
        }
    }
}
