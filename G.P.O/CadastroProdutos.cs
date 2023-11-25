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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cadastra_Click(object sender, EventArgs e)
        {
          
                if (txt_nome.Text == "" || txt_inicial.Text == "" || txt_minimo.Text == "")
                {
                    MessageBox.Show("Forneça um nome!");
                }
                else
                {

                    MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
                    try
                    {
                    conexao.Open();
                    String nome = txt_nome.Text;
                    String prateleira = txt_prateleira.Text;
                    String ala = txt_ala.Text;
                    String inicial = txt_inicial.Text;
                    String minimo = txt_minimo.Text;
                    String precoc = txt_precoc.Text;
                    String precov = txt_precov.Text;
                    String garantia = txt_garantia.Text;
                    String observacoes = txt_observacoes.Text;
                    String fornecedor = comboBox1.Text;

                    if(observacoes == "")
                    {
                        observacoes = "Nenhuma.";
                    }
                    if (prateleira == "")
                    {
                        prateleira = "-";
                    }
                    if (ala == "")
                    {
                        ala = "-";
                    }
                    if (precoc == "")
                    {
                        precoc = "Não definido.";
                    }
                    if (precov == "")
                    {
                        precov = "Não definido.";
                    }
                    if (garantia == "")
                    {
                        garantia = "Não especificado.";
                    }


                    String SQL = "insert into produtos (descricao, ala, prateleira, fornecedor, custo_c, custo_v, garantia, qtd_minima, estoque, observacoes)";
                        SQL += " values ('" + nome + "','" + ala + "','" + prateleira + "','" + fornecedor + "','" + precoc + "','" + precov + "','" + garantia + "','" + minimo + "','" + inicial + "','" + observacoes +"')";

                        MySqlCommand executa = new MySqlCommand(SQL, conexao);
                        executa.ExecuteNonQuery();

                        MessageBox.Show("Produto cadastrado com sucesso!");

                    txt_nome.Clear();
                    txt_prateleira.Clear();
                    txt_precoc.Clear();
                    txt_precov.Clear();
                    txt_ala.Clear();
                    txt_inicial.Clear();
                    txt_minimo.Clear();
                    txt_garantia.Clear();
                    txt_observacoes.Clear();
                    

                    txt_nome.Focus();


                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao cadastrar o produto: " + erro.Message);
                    }
            }
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            lbl1.Parent = pictureBox2;
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "select * from fornecedores order by fornecedor";

                DataSet resultado = new DataSet();

                MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                executa.Fill(resultado, "fornecedores");


                comboBox1.DisplayMember = "fornecedor";
                comboBox1.ValueMember = "fornecedor";
                comboBox1.DataSource = resultado.Tables[0];

            }
            catch(Exception erro)
            {
                MessageBox.Show("erro: "+ erro.Message);
            }
            if (comboBox1.Text == "")
            {
                btn_cadastra.Enabled = false;
                MessageBox.Show("Para poder cadastrar um produto, cadastre um fornecedor primeiro!");
            }
        }
        private void txt_minimo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_inicial_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
