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
    public partial class GerenciarUsuarios : Form
    {
        public GerenciarUsuarios()
        {
            InitializeComponent();
        }

        private void GerenciarUsuarios_Load(object sender, EventArgs e)
        {
            lbl1.Parent = pictureBox1;
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "";

                if (txt_pesquisa.Text.Equals(""))
                {
                    SQL = "select * from usuarios order by usuario";
                }
                else
                {
                    SQL = "select * from usuarios where usuario like '%" + txt_pesquisa.Text + "%'";
                }

                DataSet resultado = new DataSet();

                MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                executa.Fill(resultado, "usuarios");



                dataGridView1.DataSource = resultado;
                dataGridView1.DataMember = "usuarios";
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
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
                    SQL = "select * from usuarios order by usuario";
                }
                else
                {
                    SQL = "select * from usuarios where usuario like '%" + txt_pesquisa.Text + "%'";
                }

                DataSet resultado = new DataSet();

                MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                executa.Fill(resultado, "usuarios");



                dataGridView1.DataSource = resultado;
                dataGridView1.DataMember = "usuarios";
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.CurrentRow.Index;



            String usuario = dataGridView1[0, linha].Value.ToString();
            String senha = dataGridView1[1, linha].Value.ToString();
            String adm = dataGridView1[2, linha].Value.ToString();


            String SQL = "update usuarios set senha='" + senha + "',adm='" + adm + "' where usuario = '" + usuario + "'";

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
            try
            {
                conexao.Open();
                MySqlCommand executa = new MySqlCommand(SQL, conexao);
                executa.ExecuteNonQuery();

                MessageBox.Show("Usuário atualizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro = " + erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int linha = dataGridView1.CurrentRow.Index;

            String usuarioD = dataGridView1[0, linha].Value.ToString();
            String SQL = "delete from usuarios where usuario ='" + usuarioD + "'";

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
            try
            {
                conexao.Open();
                MySqlCommand executa = new MySqlCommand(SQL, conexao);
                executa.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(linha);
                MessageBox.Show("Usuário excluido com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro = " + erro.Message);
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
                        SQL = "select * from usuarios order by usuario";
                    }
                    else
                    {
                        SQL = "select * from usuarios where usuario like '%" + txt_pesquisa.Text + "%'";
                    }

                    DataSet resultado = new DataSet();

                    MySqlDataAdapter executa = new MySqlDataAdapter(SQL, conexao);

                    executa.Fill(resultado, "usuarios");



                    dataGridView1.DataSource = resultado;
                    dataGridView1.DataMember = "usuarios";
                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[2].ReadOnly = true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
            }
        }
    }
}
