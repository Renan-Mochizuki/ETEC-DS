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
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Locadora
{
    public partial class Frm_cliente : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        int codigo;
        string uf, sexo, nome, tel, endereco, complemento, bairro, cidade, email, senha, status;
        DateTime dt_cad, dt_nasc;

        public void ListarTodosClientes()
        {
            try
            {
                string sql_select_cliente = "select * from tb_cliente";

                MySqlConnection con = new MySqlConnection(conexao);

                MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);

                con.Open();
                executacmdMySql_select_cliente.ExecuteNonQuery();
                con.Close();

                DataTable tabela_cliente = new DataTable();

                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
                da_cliente.Fill(tabela_cliente);

                dgv_cliente.DataSource = tabela_cliente;

                //Exibir as tabelas com outro nome e tamanho
                dgv_cliente.Columns[0].HeaderText = "ID";
                dgv_cliente.Columns[1].HeaderText = "NOME";
                dgv_cliente.Columns[2].HeaderText = "TELEFONE";
                dgv_cliente.Columns[3].HeaderText = "SEXO";
                dgv_cliente.Columns[4].HeaderText = "EMAIL";
                dgv_cliente.Columns[5].HeaderText = "SENHA";
                dgv_cliente.Columns[6].HeaderText = "ENDEREÇO";
                dgv_cliente.Columns[7].HeaderText = "COMPLEMENTO";
                dgv_cliente.Columns[8].HeaderText = "BAIRRO";
                dgv_cliente.Columns[9].HeaderText = "CIDADE";
                dgv_cliente.Columns[10].HeaderText = "UF";
                dgv_cliente.Columns[11].HeaderText = "DATA DE NASCIMENTO";
                dgv_cliente.Columns[12].HeaderText = "DATA DE CADASTRO";
                dgv_cliente.Columns[13].HeaderText = "STATUS";

                dgv_cliente.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_cliente.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

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
            txt_id_cliente.Text = null;
            txt_nome_cliente.Text = null;
            txt_tel_cliente.Text = null;
            txt_endereco_cliente.Text = null;
            txt_complemento_cliente.Text = null;
            txt_bairro_cliente.Text = null;
            txt_cidade_cliente.Text = null;
            txt_email_cliente.Text = null;
            txt_senha_cliente.Text = null;
            cb_sexo_cliente.Text = null;
            dtp_cad.Text = DateTime.Now.ToString();
            dtp_nasc.Text = DateTime.Now.ToString();
            cb_uf_cliente.Text = null;
            rb_ativado.Checked = true;
        }

        private void Frm_cliente_Load(object sender, EventArgs e)
        {
            ListarTodosClientes();
            // Define o combobox como não digitável
            cb_uf_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Frm_cliente()
        {
            InitializeComponent();
        }
        
        private void Btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_cliente.Text) || string.IsNullOrEmpty(txt_tel_cliente.Text) || string.IsNullOrEmpty(txt_endereco_cliente.Text) || string.IsNullOrEmpty(txt_bairro_cliente.Text) || string.IsNullOrEmpty(txt_cidade_cliente.Text) || string.IsNullOrEmpty(cb_uf_cliente.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            { 
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_insert = @"insert into tb_cliente
                                      (
                                        TB_CLIENTE_NOME,
                                        TB_CLIENTE_TEL,
                                        TB_CLIENTE_SEXO,
                                        TB_CLIENTE_EMAIL,
                                        TB_CLIENTE_SENHA,
                                        TB_CLIENTE_ENDERECO,
                                        TB_CLIENTE_COMPLEMENTO,
                                        TB_CLIENTE_BAIRRO,
                                        TB_CLIENTE_CIDADE,
                                        TB_CLIENTE_UF,
                                        TB_CLIENTE_DT_NASC,
                                        TB_CLIENTE_DT_CAD,
                                        TB_CLIENTE_STATUS
                                        ) value (
                                        @cliente_nome,
                                        @cliente_tel,
                                        @cliente_sexo,
                                        @cliente_email,
                                        @cliente_senha,
                                        @cliente_endereco,
                                        @cliente_complemento,
                                        @cliente_bairro,
                                        @cliente_cidade,
                                        @cliente_uf,
                                        @cliente_dt_nasc,
                                        @cliente_dt_cad,
                                        @cliente_status
                                        )";

                MySqlCommand execultacmdMySql_insert = new MySqlCommand(sql_insert, con);

                nome = txt_nome_cliente.Text.ToUpper();
                tel = txt_tel_cliente.Text;
                endereco = txt_endereco_cliente.Text.ToUpper();
                bairro = txt_bairro_cliente.Text.ToUpper();
                cidade = txt_cidade_cliente.Text.ToUpper();
                dt_cad = Convert.ToDateTime(dtp_cad.Text);
                dt_nasc = Convert.ToDateTime(dtp_nasc.Text);
                uf = cb_uf_cliente.Text;

                if (rb_ativado.Checked)
                {
                    status = "ATIVADO";
                }
                else
                {
                    status = "DESATIVADO";
                }

                execultacmdMySql_insert.Parameters.AddWithValue("@cliente_nome", nome);
                execultacmdMySql_insert.Parameters.AddWithValue("@cliente_tel", tel);
                execultacmdMySql_insert.Parameters.AddWithValue("@cliente_endereco", endereco);
                execultacmdMySql_insert.Parameters.AddWithValue("@cliente_bairro", bairro);
                execultacmdMySql_insert.Parameters.AddWithValue("@cliente_cidade", cidade);
                execultacmdMySql_insert.Parameters.AddWithValue("@cliente_uf", uf);
                execultacmdMySql_insert.Parameters.AddWithValue("@cliente_dt_nasc", dt_nasc);
                execultacmdMySql_insert.Parameters.AddWithValue("@cliente_dt_cad", dt_cad);
                execultacmdMySql_insert.Parameters.AddWithValue("@cliente_status", status);

                // Inserindo valor null caso não for digitado o valor
                if (string.IsNullOrEmpty(cb_sexo_cliente.Text))
                {
                    execultacmdMySql_insert.Parameters.AddWithValue("@cliente_sexo", DBNull.Value);
                }
                else
                {
                    sexo = cb_sexo_cliente.Text.ToUpper();
                    execultacmdMySql_insert.Parameters.AddWithValue("@cliente_sexo", sexo);
                }
                if (string.IsNullOrEmpty(txt_email_cliente.Text))
                {
                    execultacmdMySql_insert.Parameters.AddWithValue("@cliente_email", DBNull.Value);
                }
                else
                {
                    email = txt_email_cliente.Text.ToUpper();
                    execultacmdMySql_insert.Parameters.AddWithValue("@cliente_email", email);
                }
                if (string.IsNullOrEmpty(txt_senha_cliente.Text))
                {
                    execultacmdMySql_insert.Parameters.AddWithValue("@cliente_senha", DBNull.Value);
                }
                else
                {
                    senha = txt_senha_cliente.Text.ToUpper();
                    execultacmdMySql_insert.Parameters.AddWithValue("@cliente_senha", senha);
                }
                if (string.IsNullOrEmpty(txt_complemento_cliente.Text))
                {
                    execultacmdMySql_insert.Parameters.AddWithValue("@cliente_complemento", DBNull.Value);
                }
                else
                {
                    complemento = txt_complemento_cliente.Text.ToUpper();
                    execultacmdMySql_insert.Parameters.AddWithValue("@cliente_complemento", complemento);
                }

                con.Open();
                execultacmdMySql_insert.ExecuteNonQuery();
                con.Close();

                ListarTodosClientes();

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
        }

        private void Dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id_cliente.Value = int.Parse(dgv_cliente.CurrentRow.Cells[0].Value.ToString());
                txt_nome_cliente.Text = dgv_cliente.CurrentRow.Cells[1].Value.ToString();
                txt_tel_cliente.Text = dgv_cliente.CurrentRow.Cells[2].Value.ToString();
                cb_sexo_cliente.Text = dgv_cliente.CurrentRow.Cells[3].Value.ToString();
                txt_email_cliente.Text = dgv_cliente.CurrentRow.Cells[4].Value.ToString();
                txt_senha_cliente.Text = dgv_cliente.CurrentRow.Cells[5].Value.ToString();
                txt_endereco_cliente.Text = dgv_cliente.CurrentRow.Cells[6].Value.ToString();
                txt_complemento_cliente.Text = dgv_cliente.CurrentRow.Cells[7].Value.ToString();
                txt_bairro_cliente.Text = dgv_cliente.CurrentRow.Cells[8].Value.ToString();
                txt_cidade_cliente.Text = dgv_cliente.CurrentRow.Cells[9].Value.ToString();
                cb_uf_cliente.Text = dgv_cliente.CurrentRow.Cells[10].Value.ToString();
                dtp_cad.Text = dgv_cliente.CurrentRow.Cells[11].Value.ToString();
                dtp_nasc.Text = dgv_cliente.CurrentRow.Cells[12].Value.ToString();

                if (dgv_cliente.CurrentRow.Cells[13].Value.ToString() == "ATIVADO")
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

        private void btn_atualizar_cliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_cliente.Text) || string.IsNullOrEmpty(txt_tel_cliente.Text) || string.IsNullOrEmpty(txt_endereco_cliente.Text) || string.IsNullOrEmpty(txt_bairro_cliente.Text) || string.IsNullOrEmpty(txt_cidade_cliente.Text) || string.IsNullOrEmpty(cb_uf_cliente.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                if (txt_id_cliente.Value == 0 || string.IsNullOrEmpty(txt_id_cliente.Text))
                {
                    // Se não for digitado o id
                    MessageBox.Show("Insira um código válido");
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string sql_update = @"update tb_cliente
                                    set TB_CLIENTE_NOME = @cliente_nome,
                                        TB_CLIENTE_TEL = @cliente_tel,
                                        TB_CLIENTE_SEXO = @cliente_sexo,
                                        TB_CLIENTE_EMAIL = @cliente_email,
                                        TB_CLIENTE_SENHA = @cliente_senha,
                                        TB_CLIENTE_ENDERECO = @cliente_endereco,
                                        TB_CLIENTE_COMPLEMENTO = @cliente_complemento,
                                        TB_CLIENTE_BAIRRO = @cliente_bairro,
                                        TB_CLIENTE_CIDADE = @cliente_cidade,
                                        TB_CLIENTE_UF = @cliente_uf,
                                        TB_CLIENTE_DT_NASC = @cliente_dt_nasc,
                                        TB_CLIENTE_DT_CAD = @cliente_dt_cad,
                                        TB_CLIENTE_STATUS = @cliente_status
                                  where TB_CLIENTE_ID = @id";

                    MySqlCommand execultacmdMySql_update = new MySqlCommand(sql_update, con);

                    codigo = int.Parse(txt_id_cliente.Text);
                    nome = txt_nome_cliente.Text.ToUpper();
                    tel = txt_tel_cliente.Text;
                    endereco = txt_endereco_cliente.Text.ToUpper();
                    bairro = txt_bairro_cliente.Text.ToUpper();
                    cidade = txt_cidade_cliente.Text.ToUpper();
                    dt_cad = Convert.ToDateTime(dtp_cad.Text);
                    dt_nasc = Convert.ToDateTime(dtp_nasc.Text);
                    uf = cb_uf_cliente.Text;

                    if (rb_ativado.Checked)
                    {
                        status = "ATIVADO";
                    }
                    else
                    {
                        status = "DESATIVADO";
                    }

                    execultacmdMySql_update.Parameters.AddWithValue("@cliente_nome", nome);
                    execultacmdMySql_update.Parameters.AddWithValue("@cliente_tel", tel);
                    execultacmdMySql_update.Parameters.AddWithValue("@cliente_endereco", endereco);
                    execultacmdMySql_update.Parameters.AddWithValue("@cliente_bairro", bairro);
                    execultacmdMySql_update.Parameters.AddWithValue("@cliente_cidade", cidade);
                    execultacmdMySql_update.Parameters.AddWithValue("@cliente_uf", uf);
                    execultacmdMySql_update.Parameters.AddWithValue("@cliente_dt_nasc", dt_nasc);
                    execultacmdMySql_update.Parameters.AddWithValue("@cliente_dt_cad", dt_cad);
                    execultacmdMySql_update.Parameters.AddWithValue("@cliente_status", status);
                    execultacmdMySql_update.Parameters.AddWithValue("@id", codigo);

                    // Inserindo valor null caso não for digitado o valor
                    if (string.IsNullOrEmpty(cb_sexo_cliente.Text))
                    {
                        execultacmdMySql_update.Parameters.AddWithValue("@cliente_sexo", DBNull.Value);
                    }
                    else
                    {
                        sexo = cb_sexo_cliente.Text.ToUpper();
                        execultacmdMySql_update.Parameters.AddWithValue("@cliente_sexo", sexo);
                    }
                    if (string.IsNullOrEmpty(txt_email_cliente.Text))
                    {
                        execultacmdMySql_update.Parameters.AddWithValue("@cliente_email", DBNull.Value);
                    }
                    else
                    {
                        email = txt_email_cliente.Text.ToUpper();
                        execultacmdMySql_update.Parameters.AddWithValue("@cliente_email", email);
                    }
                    if (string.IsNullOrEmpty(txt_senha_cliente.Text))
                    {
                        execultacmdMySql_update.Parameters.AddWithValue("@cliente_senha", DBNull.Value);
                    }
                    else
                    {
                        senha = txt_senha_cliente.Text.ToUpper();
                        execultacmdMySql_update.Parameters.AddWithValue("@cliente_senha", senha);
                    }
                    if (string.IsNullOrEmpty(txt_complemento_cliente.Text))
                    {
                        execultacmdMySql_update.Parameters.AddWithValue("@cliente_complemento", DBNull.Value);
                    }
                    else
                    {
                        complemento = txt_complemento_cliente.Text.ToUpper();
                        execultacmdMySql_update.Parameters.AddWithValue("@cliente_complemento", complemento);
                    }

                    con.Open();
                    execultacmdMySql_update.ExecuteNonQuery();
                    con.Close();

                    ListarTodosClientes();

                    MessageBox.Show("Cliente atualizado com sucesso!");
                }
            }
        }

        private void btn_excluir_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = int.Parse(txt_id_cliente.Text);

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_delete = @"delete from tb_cliente
                                    where TB_CLIENTE_ID = @codigo";

                MySqlCommand executacmdMysql_delete = new MySqlCommand(sql_delete, con);

                executacmdMysql_delete.Parameters.AddWithValue("@codigo", codigo);

                executacmdMysql_delete.ExecuteNonQuery();

                ListarTodosClientes();

                MessageBox.Show("Cliente deletado com sucesso!");
                con.Close();
            }
            catch (Exception erro)
            {
                string title = "Não foi possível deletar o cliente";
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

        private void Mnt_cadastrar_modelo_marca_Click(object sender, EventArgs e)
        {
            Frm_marca_modelo novo = new Frm_marca_modelo();
            novo.Show();
            this.Hide();
        }
    }

}

