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
    public partial class ConsultaFornecedor : Form
    {
        public ConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroFornecedor janelaCadastroFornecedor = new CadastroFornecedor();

            Form janelaCadastroF = Application.OpenForms["CadastroFornecedor"];

            if (janelaCadastroF != null)
            {
                janelaCadastroF.Close();
            }

            janelaCadastroFornecedor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "";

                if (txt_pesquisa.Text.Equals(""))
                {
                    SQL = "select * from fornecedores order by fornecedor";
                }
                else if (comboBox1.Text.Equals("Fornecedor"))
                {
                    SQL = "select * from fornecedores where fornecedor like '%" + txt_pesquisa.Text + "%'";
                }
                else if (comboBox1.Text.Equals("Tipo"))
                {
                    SQL = "select * from fornecedores where tipo like '%" + txt_pesquisa.Text + "%'";
                }
                else if (comboBox1.Text.Equals("País"))
                {
                    SQL = "select * from fornecedores where pais like '%" + txt_pesquisa.Text + "%'";
                }
                else if (comboBox1.Text.Equals("CNPJ/CGC"))
                {
                    SQL = "select * from fornecedores where cgc_cnpj like '%" + txt_pesquisa.Text + "%'";
                }
                DataSet resultado = new DataSet();

                MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                executa.Fill(resultado, "fornecedores");

                dataGridView1.DataSource = resultado;
                dataGridView1.DataMember = "fornecedores";

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[21].ReadOnly = true;
                dataGridView1.Columns[14].ReadOnly = true;
                dataGridView1.Columns[15].ReadOnly = true;

                dataGridView1.Columns[0].DisplayIndex = 0;
                dataGridView1.Columns[2].DisplayIndex = 1;
                dataGridView1.Columns[3].DisplayIndex = 2;
                dataGridView1.Columns[21].DisplayIndex = 3;
                dataGridView1.Columns[14].DisplayIndex = 4;
                dataGridView1.Columns[15].DisplayIndex = 5;

                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = true;
                dataGridView1.Columns[15].Visible = true;
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[17].Visible = false;
                dataGridView1.Columns[18].Visible = false;
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[20].Visible = false;
                dataGridView1.Columns[21].Visible = true;
                dataGridView1.Columns[22].Visible = false;
                dataGridView1.Columns[23].Visible = false;

                dataGridView1.Columns[0].HeaderText = "Fornecedor";
                dataGridView1.Columns[2].HeaderText = "Contato";
                dataGridView1.Columns[3].HeaderText = "Fone";
                dataGridView1.Columns[21].HeaderText = "Email";
                dataGridView1.Columns[14].HeaderText = "País";
                dataGridView1.Columns[15].HeaderText = "Estado";
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void ConsultaFornecedor_Load(object sender, EventArgs e)
        {
            lbl1.Parent = pictureBox1;
            comboBox1.SelectedIndex = 0;

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            String SQL = "select * from fornecedores order by fornecedor";
            try
            {
                DataSet resultado = new DataSet();

                MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                executa.Fill(resultado, "fornecedores");

                dataGridView1.DataSource = resultado;
                dataGridView1.DataMember = "fornecedores";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[21].ReadOnly = true;
                dataGridView1.Columns[14].ReadOnly = true;
                dataGridView1.Columns[15].ReadOnly = true;

                dataGridView1.Columns[0].DisplayIndex = 0;
                dataGridView1.Columns[2].DisplayIndex = 1;
                dataGridView1.Columns[3].DisplayIndex = 2;
                dataGridView1.Columns[21].DisplayIndex = 3;
                dataGridView1.Columns[14].DisplayIndex = 4;
                dataGridView1.Columns[15].DisplayIndex = 5;

                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                dataGridView1.Columns[14].Visible = true;
                dataGridView1.Columns[15].Visible = true;
                dataGridView1.Columns[16].Visible = false;
                dataGridView1.Columns[17].Visible = false;
                dataGridView1.Columns[18].Visible = false;
                dataGridView1.Columns[19].Visible = false;
                dataGridView1.Columns[20].Visible = false;
                dataGridView1.Columns[21].Visible = true;
                dataGridView1.Columns[22].Visible = false;
                dataGridView1.Columns[23].Visible = false;

                dataGridView1.Columns[0].HeaderText = "Fornecedor";
                dataGridView1.Columns[2].HeaderText = "Contato";
                dataGridView1.Columns[3].HeaderText = "Fone";
                dataGridView1.Columns[21].HeaderText = "Email";
                dataGridView1.Columns[14].HeaderText = "País";
                dataGridView1.Columns[15].HeaderText = "Estado";
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o Bando de Dados!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int linha = dataGridView1.CurrentRow.Index;
                String fornecedor = dataGridView1[0, linha].Value.ToString();
                global.fornecedor = fornecedor;

                Informacoes janelainfo = new Informacoes();

                Form janelainfos = Application.OpenForms["Informacoes"];

                if (janelainfos != null)
                {
                    janelainfos.Close();
                }

                janelainfo.Show();
            }
            catch
            {
                MessageBox.Show("Selecione um fornecedor!");
            }
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
                        SQL = "select * from fornecedores order by fornecedor";
                    }
                    else if (comboBox1.Text.Equals("Fornecedor"))
                    {
                        SQL = "select * from fornecedores where fornecedor like '%" + txt_pesquisa.Text + "%'";
                    }
                    else if (comboBox1.Text.Equals("Tipo"))
                    {
                        SQL = "select * from fornecedores where tipo like '%" + txt_pesquisa.Text + "%'";
                    }
                    else if (comboBox1.Text.Equals("País"))
                    {
                        SQL = "select * from fornecedores where pais like '%" + txt_pesquisa.Text + "%'";
                    }
                    else if (comboBox1.Text.Equals("CNPJ/CGC"))
                    {
                        SQL = "select * from fornecedores where cgc_cnpj like '%" + txt_pesquisa.Text + "%'";
                    }
                    DataSet resultado = new DataSet();

                    MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                    executa.Fill(resultado, "fornecedores");

                    dataGridView1.DataSource = resultado;
                    dataGridView1.DataMember = "fornecedores";

                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[1].ReadOnly = true;
                    dataGridView1.Columns[7].ReadOnly = true;
                    dataGridView1.Columns[14].ReadOnly = true;
                    dataGridView1.Columns[17].ReadOnly = true;

                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    dataGridView1.Columns[11].Visible = false;
                    dataGridView1.Columns[12].Visible = false;
                    dataGridView1.Columns[13].Visible = false;
                    dataGridView1.Columns[15].Visible = false;
                    dataGridView1.Columns[16].Visible = false;
                    dataGridView1.Columns[18].Visible = false;
                    dataGridView1.Columns[19].Visible = false;
                    dataGridView1.Columns[20].Visible = false;
                    dataGridView1.Columns[21].Visible = false;
                    dataGridView1.Columns[22].Visible = false;
                    dataGridView1.Columns[23].Visible = false;

                    dataGridView1.Columns[0].HeaderText = "Fornecedor";
                    dataGridView1.Columns[1].HeaderText = "Tipo";
                    dataGridView1.Columns[7].HeaderText = "CGC/CNPJ";
                    dataGridView1.Columns[14].HeaderText = "País";
                    dataGridView1.Columns[17].HeaderText = "Estado";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
            }
        }
    }
}
