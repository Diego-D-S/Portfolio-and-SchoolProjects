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

namespace G.P.O
{
    public partial class ConsultaProdutos : Form
    {
        public ConsultaProdutos()
        {
            InitializeComponent();

        }

        private void ConsultaProdutos_Load(object sender, EventArgs e)
        {
            lbl1.Parent = pictureBox2;
            comboBox1.SelectedIndex = 0;

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
            String SQL = "select * from produtos order by codigo";
            try
            {
                conexao.Open();

                DataSet resultado = new DataSet();

                MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                executa.Fill(resultado, "produtos");

                dataGridView1.DataSource = resultado;
                dataGridView1.DataMember = "produtos";

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[9].ReadOnly = true;

                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 250;
                dataGridView1.Columns[2].Width = 40;
                dataGridView1.Columns[3].Width = 60;
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].Width = 80;
                dataGridView1.Columns[9].Width = 80;
                dataGridView1.Columns[10].Width = 350;

                dataGridView1.Columns[0].HeaderText = "Código";
                dataGridView1.Columns[1].HeaderText = "Descrição";
                dataGridView1.Columns[2].HeaderText = "Ala";
                dataGridView1.Columns[3].HeaderText = "Prateleira";
                dataGridView1.Columns[4].HeaderText = "Fornecedor";
                dataGridView1.Columns[5].HeaderText = "Custo de Compra";
                dataGridView1.Columns[6].HeaderText = "Custo de Venda";
                dataGridView1.Columns[7].HeaderText = "Garantia";
                dataGridView1.Columns[8].HeaderText = "Quantidade Mínima";
                dataGridView1.Columns[9].HeaderText = "Estoque";
                dataGridView1.Columns[10].HeaderText = "Observações";

                try
                {
                    //Checar estoque mínimo.
                    int contador = 0;
                    int linhas = dataGridView1.Rows.Count;
                    for (contador = 0; contador < linhas; contador++)
                    {
                        String estoqueatual = dataGridView1[9, contador].Value.ToString();
                        int estoqueatualI = Int32.Parse(estoqueatual);

                        String estoqueminimo = dataGridView1[8, contador].Value.ToString();
                        int estoqueminimoI = Int32.Parse(estoqueminimo);

                        if (estoqueatualI < estoqueminimoI)
                        {
                            dataGridView1[9, contador].Style.BackColor = Color.Red;
                        }
                        //
                    }
                }
                catch
                {
                    MessageBox.Show("Erro");
                }
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "";

                if (txt_pesquisa.Text.Equals(""))
                {
                    SQL = "select * from produtos order by codigo";

                    //Checar estoque mínimo.
                    int contador = 0;
                    int linhas = dataGridView1.Rows.Count;
                    for (contador = 0; contador < linhas; contador++)
                    {
                        String estoqueatual = dataGridView1[9, contador].Value.ToString();
                        int estoqueatualI = Int32.Parse(estoqueatual);

                        String estoqueminimo = dataGridView1[8, contador].Value.ToString();
                        int estoqueminimoI = Int32.Parse(estoqueminimo);

                        if (estoqueatualI < estoqueminimoI)
                        {
                            dataGridView1[9, contador].Style.BackColor = Color.Red;
                        }
                        //
                    }
                }
                else if (comboBox1.Text.Equals("Código"))
                {
                    SQL = "select * from produtos where codigo like '%" + txt_pesquisa.Text + "%'";

                    //Checar estoque mínimo.
                    int contador = 0;
                    int linhas = dataGridView1.Rows.Count;
                    for (contador = 0; contador < linhas; contador++)
                    {
                        String estoqueatual = dataGridView1[9, contador].Value.ToString();
                        int estoqueatualI = Int32.Parse(estoqueatual);

                        String estoqueminimo = dataGridView1[8, contador].Value.ToString();
                        int estoqueminimoI = Int32.Parse(estoqueminimo);

                        if (estoqueatualI < estoqueminimoI)
                        {
                            dataGridView1[9, contador].Style.BackColor = Color.Red;
                        }
                        //
                    }
                }
                else if (comboBox1.Text.Equals("Nome"))
                {
                    SQL = "select * from produtos where descricao like '%" + txt_pesquisa.Text + "%'";

                    //Checar estoque mínimo.
                    int contador = 0;
                    int linhas = dataGridView1.Rows.Count;
                    for (contador = 0; contador < linhas; contador++)
                    {
                        String estoqueatual = dataGridView1[9, contador].Value.ToString();
                        int estoqueatualI = Int32.Parse(estoqueatual);

                        String estoqueminimo = dataGridView1[8, contador].Value.ToString();
                        int estoqueminimoI = Int32.Parse(estoqueminimo);

                        if (estoqueatualI < estoqueminimoI)
                        {
                            dataGridView1[9, contador].Style.BackColor = Color.Red;
                        }
                        //
                    }
                }
                else if (comboBox1.Text.Equals("Ala"))
                {
                    SQL = "select * from produtos where ala like '%" + txt_pesquisa.Text + "%'";

                    //Checar estoque mínimo.
                    int contador = 0;
                    int linhas = dataGridView1.Rows.Count;
                    for (contador = 0; contador < linhas; contador++)
                    {
                        String estoqueatual = dataGridView1[9, contador].Value.ToString();
                        int estoqueatualI = Int32.Parse(estoqueatual);

                        String estoqueminimo = dataGridView1[8, contador].Value.ToString();
                        int estoqueminimoI = Int32.Parse(estoqueminimo);

                        if (estoqueatualI < estoqueminimoI)
                        {
                            dataGridView1[9, contador].Style.BackColor = Color.Red;
                        }
                        //
                    }
                }
                else if (comboBox1.Text.Equals("Fornecedor"))
                {
                    SQL = "select * from produtos where fornecedor like '%" + txt_pesquisa.Text + "%'";

                    //Checar estoque mínimo.
                    int contador = 0;
                    int linhas = dataGridView1.Rows.Count;
                    for (contador = 0; contador < linhas; contador++)
                    {
                        String estoqueatual = dataGridView1[9, contador].Value.ToString();
                        int estoqueatualI = Int32.Parse(estoqueatual);

                        String estoqueminimo = dataGridView1[8, contador].Value.ToString();
                        int estoqueminimoI = Int32.Parse(estoqueminimo);

                        if (estoqueatualI < estoqueminimoI)
                        {
                            dataGridView1[9, contador].Style.BackColor = Color.Red;
                        }
                        //
                    }
                }
                DataSet resultado = new DataSet();

                MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                executa.Fill(resultado, "produtos");

                dataGridView1.DataSource = resultado;
                dataGridView1.DataMember = "produtos";

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;
                dataGridView1.Columns[9].ReadOnly = true;

                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 250;
                dataGridView1.Columns[2].Width = 40;
                dataGridView1.Columns[3].Width = 60;
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].Width = 80;
                dataGridView1.Columns[9].Width = 80;
                dataGridView1.Columns[10].Width = 350;

                dataGridView1.Columns[0].HeaderText = "Código";
                dataGridView1.Columns[1].HeaderText = "Descrição";
                dataGridView1.Columns[2].HeaderText = "Ala";
                dataGridView1.Columns[3].HeaderText = "Prateleira";
                dataGridView1.Columns[4].HeaderText = "Fornecedor";
                dataGridView1.Columns[5].HeaderText = "Custo de Compra";
                dataGridView1.Columns[6].HeaderText = "Custo de Venda";
                dataGridView1.Columns[7].HeaderText = "Garantia";
                dataGridView1.Columns[8].HeaderText = "Quantidade Mínima";
                dataGridView1.Columns[9].HeaderText = "Estoque";
                dataGridView1.Columns[10].HeaderText = "Observações";

                try
                {
                    int contador = 0;
                    int linhas = dataGridView1.Rows.Count;
                    for (contador = 0; contador < linhas; contador++)
                    {
                        String estoqueatual = dataGridView1[9, contador].Value.ToString();
                        int estoqueatualI = Int32.Parse(estoqueatual);

                        String estoqueminimo = dataGridView1[8, contador].Value.ToString();
                        int estoqueminimoI = Int32.Parse(estoqueminimo);

                        if (estoqueatualI < estoqueminimoI)
                        {
                            dataGridView1[9, contador].Style.BackColor = Color.Red;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Erro");
                }

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dataGridView1.CurrentRow.Index;

                String codigo = dataGridView1[0, linha].Value.ToString();
                String descricao = dataGridView1[1, linha].Value.ToString();
                String ala = dataGridView1[2, linha].Value.ToString();
                String prateleira = dataGridView1[3, linha].Value.ToString();
                String custoc = dataGridView1[5, linha].Value.ToString();
                String custov = dataGridView1[6, linha].Value.ToString();
                String garantia = dataGridView1[7, linha].Value.ToString();
                String qtdminima = dataGridView1[8, linha].Value.ToString();
                String obs = dataGridView1[10, linha].Value.ToString();

                if (descricao == "" || ala == "" || prateleira == "" || custoc == "" || custov == "" || garantia == "" || qtdminima == "" || obs == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {

                    String SQL = "update produtos set descricao ='" + descricao + "',ala='" + ala + "',prateleira='" + prateleira + "',custo_c='" + custoc + "',custo_v='" + custov + "',garantia='" + garantia + "',qtd_minima='" + qtdminima + "',observacoes='" + obs + "' where codigo ='" + codigo + "'";

                    MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
                    try
                    {
                        conexao.Open();
                        MySqlCommand executa = new MySqlCommand(SQL, conexao);
                        executa.ExecuteNonQuery();

                        MessageBox.Show("Produto atualizado com sucesso!");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro = " + erro.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dataGridView1.CurrentRow.Index;

                String codigo = dataGridView1[0, linha].Value.ToString();
                String SQL = "delete from produtos where codigo ='" + codigo + "'";

                MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
                try
                {
                    conexao.Open();
                    MySqlCommand executa = new MySqlCommand(SQL, conexao);
                    executa.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(linha);
                    MessageBox.Show("Produto excluido com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro = " + erro.Message);
                }
            }
            catch
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

                try
                {
                    conexao.Open();

                    String SQL = "";

                    if (txt_pesquisa.Text.Equals(""))
                    {
                        SQL = "select * from produtos order by codigo";
                    }
                    else if (comboBox1.Text.Equals("Código"))
                    {
                        SQL = "select * from produtos where codigo like '%" + txt_pesquisa.Text + "%'";
                    }
                    else if (comboBox1.Text.Equals("Nome"))
                    {
                        SQL = "select * from produtos where descricao like '%" + txt_pesquisa.Text + "%'";
                    }
                    else if (comboBox1.Text.Equals("Ala"))
                    {
                        SQL = "select * from produtos where ala like '%" + txt_pesquisa.Text + "%'";
                    }
                    else if (comboBox1.Text.Equals("Fornecedor"))
                    {
                        SQL = "select * from produtos where fornecedor like '%" + txt_pesquisa.Text + "%'";
                    }
                    DataSet resultado = new DataSet();

                    MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                    executa.Fill(resultado, "produtos");

                    dataGridView1.DataSource = resultado;
                    dataGridView1.DataMember = "produtos";

                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[4].ReadOnly = true;
                    dataGridView1.Columns[9].ReadOnly = true;

                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[5].Width = 120;
                    dataGridView1.Columns[6].Width = 120;
                    dataGridView1.Columns[8].Width = 130;
                    dataGridView1.Columns[10].Width = 350;

                    dataGridView1.Columns[0].HeaderText = "Código";
                    dataGridView1.Columns[1].HeaderText = "Descrição";
                    dataGridView1.Columns[2].HeaderText = "Ala";
                    dataGridView1.Columns[3].HeaderText = "Prateleira";
                    dataGridView1.Columns[4].HeaderText = "Fornecedor";
                    dataGridView1.Columns[5].HeaderText = "Custo de Compra";
                    dataGridView1.Columns[6].HeaderText = "Custo de Venda";
                    dataGridView1.Columns[7].HeaderText = "Garantia";
                    dataGridView1.Columns[8].HeaderText = "Quantidade Mínima";
                    dataGridView1.Columns[9].HeaderText = "Estoque";
                    dataGridView1.Columns[10].HeaderText = "Observações";


                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
            }
        }
    }
}
