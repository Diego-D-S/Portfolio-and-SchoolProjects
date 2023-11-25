using System;
using System.Collections;
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
    public partial class EntradaProdutos : Form
    {
        public EntradaProdutos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "";

                if (txt_codigo.Text.Equals(""))
                {
                    dataGridView1.DataSource = null;
                }
                else
                {
                    SQL = "select * from produtos where codigo like '%" + txt_codigo.Text + "%'";

                    DataSet resultado = new DataSet();

                    MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                    executa.Fill(resultado, "produtos");



                    dataGridView1.DataSource = resultado;
                    dataGridView1.DataMember = "produtos";

                    dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[10].Visible = false;

                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[4].ReadOnly = true;
                    dataGridView1.Columns[9].ReadOnly = true;

                    dataGridView1.Columns[0].HeaderText = "Código";
                    dataGridView1.Columns[1].HeaderText = "Descrição";
                    dataGridView1.Columns[4].HeaderText = "Fornecedor";
                    dataGridView1.Columns[9].HeaderText = "Estoque";

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "";

                if (txt_nome.Text.Equals(""))
                {
                    dataGridView1.DataSource = null;
                }
                else
                {
                    SQL = "select * from produtos where descricao like '%" + txt_nome.Text + "%'";

                    DataSet resultado = new DataSet();

                    MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                    executa.Fill(resultado, "produtos");



                    dataGridView1.DataSource = resultado;
                    dataGridView1.DataMember = "produtos";

                    dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[10].Visible = false;

                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[4].ReadOnly = true;
                    dataGridView1.Columns[9].ReadOnly = true;

                    dataGridView1.Columns[0].HeaderText = "Código";
                    dataGridView1.Columns[1].HeaderText = "Descrição";
                    dataGridView1.Columns[4].HeaderText = "Fornecedor";
                    dataGridView1.Columns[9].HeaderText = "Estoque";

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int linha = dataGridView1.CurrentRow.Index;

                String codigo = dataGridView1[0, linha].Value.ToString();
                String nome = dataGridView1[1, linha].Value.ToString();

                txt_codigo.Text = codigo;
                txt_nome.Text = nome;

                txt_quantidade.Focus();
            }
            catch
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int linhas = dataGridView2.Rows.Count;

            int contador = 0;

            if (linhas == 0)
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
            else
            {
                try
                {

                    for (contador = 0; contador < linhas; contador++)
                    {
                        String codigo = dataGridView2[0, contador].Value.ToString();

                        String estoque = dataGridView2[9, contador].Value.ToString();
                        int estoqueI = Int32.Parse(estoque);

                        String quantidade = dataGridView2[11, contador].Value.ToString();
                        int quantidadeI = Int32.Parse(quantidade);

                        int resultadoI = estoqueI + quantidadeI;

                        String SQL = "update produtos set estoque='" + resultadoI + "' where codigo ='" + codigo + "'";

                        MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
                        try
                        {
                            conexao.Open();
                            MySqlCommand executa = new MySqlCommand(SQL, conexao);
                            executa.ExecuteNonQuery();

                            txt_codigo.Clear();
                            txt_nome.Clear();
                            txt_quantidade.Clear();

                            txt_codigo.Focus();

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro = " + erro.Message);
                        }

                    }
                    int contador2 = 0;

                    String cod = "";
                    String[] pedidoA = new String[linhas+1];
                    String produto = "";
                    String qtd = "";
                    global.pedido = "";

                    for (contador2 = 0; contador2 < linhas; contador2++)
                    {
                        cod = dataGridView2[0, contador2].Value.ToString();
                        qtd = dataGridView2[11, contador2].Value.ToString();
                        produto = dataGridView2[1, contador2].Value.ToString();
                        pedidoA[contador] = "Cod: " + cod + " - " + "Prod: " + produto + " - " + "Adicionado: " + qtd;
                        global.pedido = global.pedido + pedidoA[contador]+ System.Environment.NewLine;
                        //System.Environment.NewLine
                    }
                    MySqlConnection conexao2 = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

                    try
                    {
                        conexao2.Open();
                        String data = DateTime.Now.ToString("dd/MM/yyyy");
                        String hora = DateTime.Now.ToLongTimeString();

                        String SQL = "insert into pedidos (pedido, data_p, hora_p, usuario)";
                        SQL += " values ('" + global.pedido + "','" + data +"','" + hora +"','" + global.usuario +"')";

                        MySqlCommand executa = new MySqlCommand(SQL, conexao2);
                        executa.ExecuteNonQuery();
                    }
                    catch(Exception erro2)
                    {
                        MessageBox.Show("ERRO! Informe o técnico: " + erro2.Message);
                    }

                    dataGridView1.Rows.Clear();
                    dataGridView2.Rows.Clear();
                    MessageBox.Show("Estoque atualizado com sucesso!");
                }
                catch(Exception erro)
                {
                    MessageBox.Show("Erro ao atualizar o estoque!"+ erro.Message);
                }
            }
        }

        private void txt_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int linhas = dataGridView2.Rows.Count;

                int contador = 0;
                String existe = "Não";
                for (contador = 0; contador < linhas; contador++)
                {
                    String codigo = dataGridView2[0, contador].Value.ToString();
                    if (txt_codigo.Text == codigo)
                    {
                        existe = "Sim";
                    }

                }
                if (txt_quantidade.Text == "")
                {
                    MessageBox.Show("Insira uma quantidade!");
                    txt_quantidade.Focus();
                }
                else if (existe == "Sim")
                {
                    MessageBox.Show("Este produto já foi adicionado à lista!");
                }
                else
                {

                    ArrayList adiciona = new ArrayList();

                    foreach (DataGridViewCell cell in dataGridView1.CurrentRow.Cells)
                    {
                        adiciona.Add(cell.Value.ToString());
                    }
                    adiciona.Add(txt_quantidade.Text);
                    dataGridView2.Rows.Add(adiciona.ToArray());

                    txt_codigo.Clear();
                    txt_nome.Clear();
                    txt_quantidade.Clear();

                    txt_codigo.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }

        private void EntradaProdutos_Load(object sender, EventArgs e)
        {
            lbl1.Parent = pictureBox1;
            dataGridView2.Columns.Add("Código", "Código");
            dataGridView2.Columns.Add("Descrição", "Descrição");
            dataGridView2.Columns.Add("Ala", "Ala");
            dataGridView2.Columns.Add("Prateleira", "Prateleira");
            dataGridView2.Columns.Add("Fornecedor", "Fornecedor");
            dataGridView2.Columns.Add("Custo de Compra", "Custo de Compra");
            dataGridView2.Columns.Add("Custo de Venda", "Custo de Venda");
            dataGridView2.Columns.Add("Garantia", "Garantia");
            dataGridView2.Columns.Add("Quantidade Mínima", "Quantidade Mínima");
            dataGridView2.Columns.Add("Estoque", "Estoque");
            dataGridView2.Columns.Add("Observações", "Observações");
            dataGridView2.Columns.Add("Quantidade", "Quantidade");

            dataGridView2.Columns[0].Visible = true;
            dataGridView2.Columns[1].Visible = true;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = true;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].Visible = false;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
            dataGridView2.Columns[11].Visible = true;

            dataGridView2.Columns[0].ReadOnly = true;
            dataGridView2.Columns[1].ReadOnly = true;
            dataGridView2.Columns[4].ReadOnly = true;
            dataGridView2.Columns[11].ReadOnly = true;


        }

        private void txt_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int linha = dataGridView1.CurrentRow.Index;

                    String codigo = dataGridView1[0, linha].Value.ToString();
                    String nome = dataGridView1[1, linha].Value.ToString();

                    txt_codigo.Text = codigo;
                    txt_nome.Text = nome;

                    txt_quantidade.Focus();
                }
                catch
                {
                    MessageBox.Show("Nenhum item selecionado!");
                }
            }
        }

        private void txt_quantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int linhas = dataGridView2.Rows.Count;

                    int contador = 0;
                    String existe = "Não";
                    for (contador = 0; contador < linhas; contador++)
                    {
                        String codigo = dataGridView2[0, contador].Value.ToString();
                        if (txt_codigo.Text == codigo)
                        {
                            existe = "Sim";
                        }

                    }
                    if (txt_quantidade.Text == "")
                    {
                        MessageBox.Show("Insira uma quantidade!");
                        txt_quantidade.Focus();
                    }
                    else if (existe == "Sim")
                    {
                        MessageBox.Show("Este produto já foi adicionado à lista!");
                    }
                    else
                    {

                        ArrayList adiciona = new ArrayList();

                        foreach (DataGridViewCell cell in dataGridView1.CurrentRow.Cells)
                        {
                            adiciona.Add(cell.Value.ToString());
                        }
                        adiciona.Add(txt_quantidade.Text);
                        dataGridView2.Rows.Add(adiciona.ToArray());

                        txt_codigo.Clear();
                        txt_nome.Clear();
                        txt_quantidade.Clear();

                        txt_codigo.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Nenhum item selecionado!");
                }
            }
        }
    }
}
