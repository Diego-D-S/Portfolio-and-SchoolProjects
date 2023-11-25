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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String usuario = txt_usuario.Text;
                String Senha = txt_senha.Text;
                String SQL = "Select * from usuarios where usuario ='" + usuario + "'";
                MySqlCommand executar = new MySqlCommand(SQL, conexao);
                MySqlDataReader Resultado = executar.ExecuteReader();

                try
                {
                    Resultado.Read();
                    String SenhaUSER = Resultado.GetString("Senha").ToString();
                    if (SenhaUSER.Equals(Senha))
                    {
                         global.usuario = usuario;

                         PaginaPrincipal GPO = new PaginaPrincipal();

                         GPO.Show();
                        

                         this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario ou Senha Incorretos!");
                    }
                }
                catch
                {
                    MessageBox.Show("Usuário ou Senha Incorretos!");
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar ao Bando de Dados!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_senha.PasswordChar = '*';
        }

        private void txt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

                try
                {
                    conexao.Open();

                    String usuario = txt_usuario.Text;
                    String Senha = txt_senha.Text;
                    String SQL = "Select * from usuarios where usuario ='" + usuario + "'";
                    MySqlCommand executar = new MySqlCommand(SQL, conexao);
                    MySqlDataReader Resultado = executar.ExecuteReader();

                    try
                    {
                        Resultado.Read();
                        String SenhaUSER = Resultado.GetString("Senha").ToString();
                        if (SenhaUSER.Equals(Senha))
                        {
                            global.usuario = usuario;

                            PaginaPrincipal GPO = new PaginaPrincipal();

                            GPO.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario ou Senha Incorretos!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Usuário ou Senha Incorretos!");
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível conectar ao Bando de Dados!");
                }
            }
        }
    }
}
