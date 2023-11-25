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
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_usuario.Text == "" || txt_senha.Text == "" || txt_confirma.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                if (txt_senha.Text == txt_confirma.Text)
                {
                    MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
                    try
                    {
                        conexao.Open();
                        String usuario = txt_usuario.Text.Trim();
                        String senha = txt_senha.Text.Trim();
                        String adm = comboBox1.Text;

                        txt_usuario.Clear();
                        txt_senha.Clear();
                        txt_confirma.Clear();

                        txt_usuario.Focus();
                        comboBox1.SelectedIndex = 0;

                        String SQL = "insert into usuarios (usuario, senha, adm)";
                        SQL += " values ('" + usuario + "','" + senha + "','" + adm + "')";

                        MySqlCommand executa = new MySqlCommand(SQL, conexao);
                        executa.ExecuteNonQuery();

                        MessageBox.Show("Usuario cadastrado com sucesso!");

                        txt_usuario.Clear();
                        txt_senha.Clear();
                        txt_confirma.Clear();

                        txt_usuario.Focus();
                        comboBox1.SelectedIndex = 0;
                    }
                    catch(Exception erro)
                    {
                        MessageBox.Show("Erro ao cadastrar o usuário: " + erro.Message);

                        txt_usuario.Clear();
                        txt_senha.Clear();
                        txt_confirma.Clear();

                        txt_usuario.Focus();
                        comboBox1.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não correspondem!");

                    MessageBox.Show(txt_senha.Text + "/" + txt_confirma.Text);
                }
            }
        }

        private void CadastroUsuarios_Load(object sender, EventArgs e)
        {
            lbl1.Parent = pictureBox1;
            comboBox1.SelectedIndex = 0;

            txt_senha.PasswordChar = '*';
            txt_confirma.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected void txt_confirma_TextChanged(object sender, EventArgs e)
        {
            if(txt_senha.Text != txt_confirma.Text)
            {
                lbl_confirma.ForeColor = System.Drawing.Color.Red;
                lbl_confirma.Text = "Senhas não correspondem";
            }
            else
            {
                lbl_confirma.ForeColor = System.Drawing.Color.ForestGreen;
                lbl_confirma.Text = "Senhas correspondem";
            }
        }
    }
}
