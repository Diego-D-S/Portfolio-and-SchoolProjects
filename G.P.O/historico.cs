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
    public partial class historico : Form
    {
        public historico()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
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
                    SQL = "select * from pedidos order by numero DESC";
                }
                else if (comboBox1.Text.Equals("Número"))
                {
                    SQL = "select * from pedidos where numero like '%" + txt_pesquisa.Text + "%'";
                }
                else if (comboBox1.Text.Equals("Pedido"))
                {
                    SQL = "select * from pedidos where pedido like '%" + txt_pesquisa.Text + "%'";
                }
                else if (comboBox1.Text.Equals("Data"))
                {
                    SQL = "select * from pedidos where data_p like '%" + txt_pesquisa.Text + "%'";
                }
                else if (comboBox1.Text.Equals("Usuário"))
                {
                    SQL = "select * from pedidos where usuario like '%" + txt_pesquisa.Text + "%'";
                }
                DataSet resultado = new DataSet();

                MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                executa.Fill(resultado, "produtos");

                dataGridView1.DataSource = resultado;
                dataGridView1.DataMember = "produtos";

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;

                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 600;
                dataGridView1.Columns[2].Width = 70;
                dataGridView1.Columns[3].Width = 50;
                dataGridView1.Columns[4].Width = 50;

                dataGridView1.Columns[0].HeaderText = "Número";
                dataGridView1.Columns[1].HeaderText = "Pedido";
                dataGridView1.Columns[2].HeaderText = "Data";
                dataGridView1.Columns[3].HeaderText = "Hora";
                dataGridView1.Columns[4].HeaderText = "Usuário";
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados!");
            }
        }

        private void historico_Load(object sender, EventArgs e)
        {
            lbl1.Parent = pictureBox1;
            comboBox1.SelectedIndex = 0;
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "";

                if (txt_pesquisa.Text.Equals(""))
                {
                    SQL = "select * from pedidos order by numero DESC";
                }
                else if (comboBox1.Text.Equals("Número"))
                {
                    SQL = "select * from pedidos where numero like '%" + txt_pesquisa.Text + "%'";
                }
                else if (comboBox1.Text.Equals("Pedido"))
                {
                    SQL = "select * from pedidos where pedido like '%" + txt_pesquisa.Text + "%'";
                }
                else if (comboBox1.Text.Equals("Data"))
                {
                    SQL = "select * from pedidos where data_p like '%" + txt_pesquisa.Text + "%'";
                }
                else if (comboBox1.Text.Equals("Usuário"))
                {
                    SQL = "select * from pedidos where usuario like '%" + txt_pesquisa.Text + "%'";
                }
                DataSet resultado = new DataSet();

                MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                executa.Fill(resultado, "produtos");

                dataGridView1.DataSource = resultado;
                dataGridView1.DataMember = "produtos";

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;

                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 600;
                dataGridView1.Columns[2].Width = 70;
                dataGridView1.Columns[3].Width = 50;
                dataGridView1.Columns[4].Width = 50;

                dataGridView1.Columns[0].HeaderText = "Número";
                dataGridView1.Columns[1].HeaderText = "Pedido";
                dataGridView1.Columns[2].HeaderText = "Data";
                dataGridView1.Columns[3].HeaderText = "Hora";
                dataGridView1.Columns[4].HeaderText = "Usuário";
            }
            catch
            {
                MessageBox.Show("Erro ao conectar com o Banco de Dados!");
            }
        }
    }
}
