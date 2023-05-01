using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class Frm_automovel : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        int codigo, ano_fab, modelo, marca, red;
        string nome, cor, status;
        double valor_d, km;

        public void ListarTodosAutomoveis()
        {
            try
            {
                // Bloqueando redirecionamento do combobox
                red = 0;

                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select_automovel = @"    SELECT f.TB_AUTOMOVEL_ID,
                                                           f.TB_AUTOMOVEL_NOME,
                                                           f.TB_AUTOMOVEL_ANO_FAB,
                                                           f.TB_AUTOMOVEL_COR,  
                                                           f.TB_AUTOMOVEL_KM,
                                                           f.TB_AUTOMOVEL_VALOR_D ,
                                                           f.TB_AUTOMOVEL_STATUS, 
                                                           ma.TB_MARCA_NOME,
                                                           mo.TB_MODELO_DESC from tb_automovel as f
                                                  inner join tb_modelo as mo on (f.TB_MODELO_ID = mo.TB_MODELO_ID)
                                                  inner join tb_marca as ma on (f.TB_MARCA_ID = ma.TB_MARCA_ID)
                                                  order by f.TB_AUTOMOVEL_ID";

                MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);

                con.Open();
                executacmdMySql_select_automovel.ExecuteNonQuery();
                con.Close();

                DataTable tabela_automovel = new DataTable();

                MySqlDataAdapter do_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
                do_automovel.Fill(tabela_automovel);

                dgv_automovel.DataSource = tabela_automovel;

                // Combobox marca
                string sqlselectmarca = "select * from tb_marca order by tb_marca_nome";

                MySqlDataAdapter damarca = new MySqlDataAdapter(sqlselectmarca, con);

                DataTable dtResultadomarca = new DataTable();
                damarca.Fill(dtResultadomarca);

                DataRow drmarca = dtResultadomarca.NewRow();
                drmarca["TB_MARCA_ID"] = 0;
                drmarca["TB_MARCA_NOME"] = "Cadastrar uma nova";

                dtResultadomarca.Rows.InsertAt(drmarca, 0);

                // Define o combobox como não digitável
                cb_marca_automovel.DropDownStyle = ComboBoxStyle.DropDownList;

                cb_marca_automovel.DataSource = dtResultadomarca;
                cb_marca_automovel.ValueMember = "TB_MARCA_ID";
                cb_marca_automovel.DisplayMember = "TB_MARCA_NOME";

                // Combobox marca
                string sqlselectmodelo = "select * from tb_modelo order by tb_modelo_desc";

                MySqlDataAdapter damodelo = new MySqlDataAdapter(sqlselectmodelo, con);

                DataTable dtResultadomodelo = new DataTable();
                damodelo.Fill(dtResultadomodelo);

                DataRow drmodelo = dtResultadomodelo.NewRow();
                drmodelo["TB_MODELO_ID"] = 0;
                drmodelo["TB_MODELO_DESC"] = "Cadastrar um novo";

                dtResultadomodelo.Rows.InsertAt(drmodelo, 0);

                // Define o combobox como não digitável
                cb_modelo_automovel.DropDownStyle = ComboBoxStyle.DropDownList;

                cb_modelo_automovel.DataSource = dtResultadomodelo;
                cb_modelo_automovel.ValueMember = "TB_MODELO_ID";
                cb_modelo_automovel.DisplayMember = "TB_MODELO_DESC";

                //Exibir as tabelas com outro nome e tamanho
                dgv_automovel.Columns[0].HeaderText = "ID";
                dgv_automovel.Columns[1].HeaderText = "NOME";
                dgv_automovel.Columns[2].HeaderText = "ANO FABRICAÇÃO";
                dgv_automovel.Columns[3].HeaderText = "COR";
                dgv_automovel.Columns[4].HeaderText = "KM";
                dgv_automovel.Columns[5].HeaderText = "VALOR DIÁRIA";
                dgv_automovel.Columns[6].HeaderText = "STATUS";
                dgv_automovel.Columns[7].HeaderText = "MARCA";
                dgv_automovel.Columns[8].HeaderText = "MODELO";

                dgv_automovel.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_automovel.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_automovel.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_automovel.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_automovel.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_automovel.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_automovel.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_automovel.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv_automovel.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

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
            txt_id_automovel.Text = null;
            txt_km_automovel.Text = null;
            txt_nome_automovel.Text = null;
            txt_valor_automovel.Text = null;
            txt_ano_fab_automovel.Text = null;
            cb_cor_automovel.Text = null;
            cb_marca_automovel.Text = null;
            cb_modelo_automovel.Text = null;
            rb_ativado.Checked = true;
        }

        private void Btn_cadastrar_automovel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_automovel.Text) || string.IsNullOrEmpty(cb_cor_automovel.Text) || string.IsNullOrEmpty(cb_marca_automovel.Text) || string.IsNullOrEmpty(cb_modelo_automovel.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_insert = @"insert into tb_automovel
                                    (
                                      TB_AUTOMOVEL_NOME, 
                                      TB_AUTOMOVEL_COR, 
                                      TB_AUTOMOVEL_KM,
                                      TB_AUTOMOVEL_ANO_FAB,
                                      TB_AUTOMOVEL_STATUS, 
                                      TB_AUTOMOVEL_VALOR_D, 
                                      TB_MARCA_ID, 
                                      TB_MODELO_ID
                                    )VALUE (
                                        @TB_AUTOMOVEL_NOME, 
                                        @TB_AUTOMOVEL_COR, 
                                        @TB_AUTOMOVEL_KM,
                                        @TB_AUTOMOVEL_ANO_FAB,
                                        @TB_AUTOMOVEL_STATUS, 
                                        @TB_AUTOMOVEL_VALOR_D,  
                                        @TB_MARCA_ID, 
                                        @TB_MODELO_ID
                                    )";

                MySqlCommand executarcmdMySql_insert = new MySqlCommand(sql_insert, con);

                if (rb_ativado.Checked)
                {
                    status = "DISPONÍVEL";
                }
                else
                {
                    status = "INDISPONÍVEL";
                }

                nome = txt_nome_automovel.Text.ToUpper();
                cor = cb_cor_automovel.Text.ToUpper();
                modelo = int.Parse(cb_modelo_automovel.SelectedValue.ToString());
                marca = int.Parse(cb_marca_automovel.SelectedValue.ToString());

                executarcmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_NOME", nome);
                executarcmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_COR", cor);
                executarcmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_STATUS", status);
                executarcmdMySql_insert.Parameters.AddWithValue("@TB_MARCA_ID", marca);
                executarcmdMySql_insert.Parameters.AddWithValue("@TB_MODELO_ID", modelo);

                // Inserindo valor null caso não for digitado o valor
                if (string.IsNullOrEmpty(txt_km_automovel.Text))
                {
                    executarcmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_KM", DBNull.Value);
                }
                else
                {
                    km = double.Parse(txt_km_automovel.Text);
                    executarcmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_KM", km);
                }
                if (string.IsNullOrEmpty(txt_ano_fab_automovel.Text))
                {
                    executarcmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_ANO_FAB", DBNull.Value);
                }
                else
                {
                    ano_fab = int.Parse(txt_ano_fab_automovel.Text);
                    executarcmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_ANO_FAB", ano_fab);
                }
                if (string.IsNullOrEmpty(txt_valor_automovel.Text))
                {
                    executarcmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_VALOR_D", DBNull.Value);
                }
                else
                {
                    valor_d = double.Parse(txt_valor_automovel.Text);
                    executarcmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_VALOR_D", valor_d);
                }

                con.Open();
                executarcmdMySql_insert.ExecuteNonQuery();
                con.Close();

                ListarTodosAutomoveis();

                MessageBox.Show("Automóvel cadastrado com sucesso!");
            }
        }

        private void Btn_excluir_automovel_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = int.Parse(txt_id_automovel.Text);

                MySqlConnection con = new MySqlConnection(conexao);

                string sql_delete = @"delete from tb_automovel
                                    where TB_AUTOMOVEL_ID = @codigo";

                MySqlCommand executacmdMysql_delete = new MySqlCommand(sql_delete, con);

                executacmdMysql_delete.Parameters.AddWithValue("@codigo", codigo);

                con.Open();
                executacmdMysql_delete.ExecuteNonQuery();
                con.Close();

                ListarTodosAutomoveis();

                MessageBox.Show("Automóvel deletado com sucesso!");
            }
            catch (Exception erro)
            {
                string title = "Não foi possível deletar o automóvel";
                if (MessageBox.Show("Esse registro está anexado à outro", title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    MessageBox.Show(erro.ToString(), "Erro:");
                }
            }
        }

        public Frm_automovel()
        {
            InitializeComponent();
        }

        private void Dgv_automovel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_id_automovel.Value = int.Parse(dgv_automovel.CurrentRow.Cells[0].Value.ToString());
                txt_nome_automovel.Text = dgv_automovel.CurrentRow.Cells[1].Value.ToString();
                txt_ano_fab_automovel.Text = dgv_automovel.CurrentRow.Cells[2].Value.ToString();
                cb_cor_automovel.Text = dgv_automovel.CurrentRow.Cells[3].Value.ToString();
                txt_km_automovel.Text = dgv_automovel.CurrentRow.Cells[4].Value.ToString();
                txt_valor_automovel.Text = dgv_automovel.CurrentRow.Cells[5].Value.ToString();
                cb_marca_automovel.Text = dgv_automovel.CurrentRow.Cells[7].Value.ToString();
                cb_modelo_automovel.Text = dgv_automovel.CurrentRow.Cells[8].Value.ToString();

                if (dgv_automovel.CurrentRow.Cells[6].Value.ToString() == "DISPONÍVEL")
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

        private void Btn_atualizar_automovel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome_automovel.Text) || string.IsNullOrEmpty(cb_cor_automovel.Text) || string.IsNullOrEmpty(cb_marca_automovel.Text) || string.IsNullOrEmpty(cb_modelo_automovel.Text))
            {
                // Se os campos estiverem incompletos
                MessageBox.Show("Complete todos os campos obrigatórios");
            }
            else
            {
                if (txt_id_automovel.Value == 0 || string.IsNullOrEmpty(txt_id_automovel.Text))
                {
                    // Se não for digitado o id
                    MessageBox.Show("Insira um código válido");
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    string sql_update = @"update tb_automovel
                                    set TB_AUTOMOVEL_NOME = @nome,
                                        TB_AUTOMOVEL_ANO_FAB = @dt_fab,
                                        TB_AUTOMOVEL_COR = @cor,
                                        TB_AUTOMOVEL_KM = @km,
                                        TB_AUTOMOVEL_VALOR_D = @valor_d,
                                        TB_MARCA_ID = @marca,
                                        TB_MODELO_ID = @modelo
                                  where TB_AUTOMOVEL_ID = @id";

                    MySqlCommand executacmdMySql_update = new MySqlCommand(sql_update, con);

                    codigo = int.Parse(txt_id_automovel.Text);
                    nome = txt_nome_automovel.Text.ToUpper();
                    cor = cb_cor_automovel.Text.ToUpper();
                    modelo = int.Parse(cb_modelo_automovel.SelectedValue.ToString());
                    marca = int.Parse(cb_marca_automovel.SelectedValue.ToString());

                    if (rb_ativado.Checked)
                    {
                        status = "DISPONÍVEL";
                    }
                    else
                    {
                        status = "INDISPONÍVEL";
                    }

                    executacmdMySql_update.Parameters.AddWithValue("@nome", nome);
                    executacmdMySql_update.Parameters.AddWithValue("@cor", cor);
                    executacmdMySql_update.Parameters.AddWithValue("@marca", marca);
                    executacmdMySql_update.Parameters.AddWithValue("@modelo", modelo);
                    executacmdMySql_update.Parameters.AddWithValue("@status", status);
                    executacmdMySql_update.Parameters.AddWithValue("@id", codigo);
                    // Inserindo valor null caso não for digitado o valor
                    if (string.IsNullOrEmpty(txt_km_automovel.Text))
                    {
                        executacmdMySql_update.Parameters.AddWithValue("@km", DBNull.Value);
                    }
                    else
                    {
                        km = double.Parse(txt_km_automovel.Text);
                        executacmdMySql_update.Parameters.AddWithValue("@km", km);
                    }
                    if (string.IsNullOrEmpty(txt_ano_fab_automovel.Text))
                    {
                        executacmdMySql_update.Parameters.AddWithValue("@dt_fab", DBNull.Value);
                    }
                    else
                    {
                        ano_fab = int.Parse(txt_ano_fab_automovel.Text);
                        executacmdMySql_update.Parameters.AddWithValue("@dt_fab", ano_fab);
                    }
                    if (string.IsNullOrEmpty(txt_valor_automovel.Text))
                    {
                        executacmdMySql_update.Parameters.AddWithValue("@valor_d", DBNull.Value);
                    }
                    else
                    {
                        valor_d = double.Parse(txt_valor_automovel.Text);
                        executacmdMySql_update.Parameters.AddWithValue("@valor_d", valor_d);
                    }

                    con.Open();
                    executacmdMySql_update.ExecuteNonQuery();
                    con.Close();

                    ListarTodosAutomoveis();
                    
                    MessageBox.Show("Automóvel atualizado com sucesso!");
                }
            }
        }

        private void mnt_cadastrar_locacao_Click(object sender, EventArgs e)
        {
            Frm_locacao novo = new Frm_locacao();
            novo.Show();
            this.Hide();
        }

        private void Frm_automovel_Load(object sender, EventArgs e)
        {
            ListarTodosAutomoveis();
        }

        private void cb_marca_automovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (red == 1)
            {
                if (cb_marca_automovel.Text == "Cadastrar uma nova")
                {
                    Frm_marca_modelo marca = new Frm_marca_modelo();
                    marca.Show();
                    this.Hide();
                    red = 0;
                }
            }
        }

        private void cb_modelo_automovel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (red == 1)
            {
                if (cb_modelo_automovel.Text == "Cadastrar um novo")
                {
                    Frm_marca_modelo modelo = new Frm_marca_modelo();
                    modelo.Show();
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

        private void mnt_cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            Frm_funcionario novo = new Frm_funcionario();
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
    }
}
