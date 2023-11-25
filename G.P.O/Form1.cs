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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();

            this.Text = "Bom dia "+global.usuario+"! Hoje é "+ DateTime.Now.ToLongDateString();
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaProdutos janelaEntradaProdutos = new EntradaProdutos();

            Form janelaEntradaP = Application.OpenForms["EntradaProdutos"];

            if (janelaEntradaP != null)
            {
                janelaEntradaP.Close();
            }

            janelaEntradaProdutos.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadastroProdutos janelaCadastroProdutos = new CadastroProdutos();

            Form janelaCadastroP = Application.OpenForms["CadastroProdutos"];

            if (janelaCadastroP != null)
            {
                janelaCadastroP.Close();
            }

            janelaCadastroProdutos.Show();
        }

        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProdutos janelaConsultaProdutos = new ConsultaProdutos();

            Form janelaConsultaP = Application.OpenForms["ConsultaProdutos"];

            if (janelaConsultaP != null)
            {
                janelaConsultaP.Close();
            }

            janelaConsultaProdutos.Show();
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaidaProdutos janelaSaidaProdutos = new SaidaProdutos();

            Form janelaSaidaP = Application.OpenForms["SaidaProdutos"];

            if (janelaSaidaP != null)
            {
                janelaSaidaP.Close();
            }

            janelaSaidaProdutos.Show();
        }
        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String usuario = global.usuario;

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "Select * from usuarios where usuario ='" + usuario + "'";
                MySqlCommand executar = new MySqlCommand(SQL, conexao);
                MySqlDataReader Resultado = executar.ExecuteReader();

                try
                {
                    Resultado.Read();
                    String admUSER = Resultado.GetString("adm").ToString();
                    if (admUSER == "Sim")
                    {
                        CadastroUsuarios janelaCadastroUsuarios = new CadastroUsuarios();

                        Form janelaCadastroU = Application.OpenForms["CadastroUsuarios"];

                        if (janelaCadastroU != null)
                        {
                            janelaCadastroU.Close();
                        }

                        janelaCadastroUsuarios.Show();
                    }
                    else
                    {
                        MessageBox.Show("Apenas um administrador pode acessar esta página.");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro:");
                }
            }
            catch
            {

            }
        }

        private void gerenciarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String usuario = global.usuario;

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "Select * from usuarios where usuario ='" + usuario + "'";
                MySqlCommand executar = new MySqlCommand(SQL, conexao);
                MySqlDataReader Resultado = executar.ExecuteReader();

                try
                {
                    Resultado.Read();
                    String admUSER = Resultado.GetString("adm").ToString();
                    if (admUSER == "Sim")
                    {
                        GerenciarUsuarios janelaGerenciarUsuarios = new GerenciarUsuarios();

                        Form janelaGerenciarU = Application.OpenForms["GerenciarUsuarios"];

                        if (janelaGerenciarU != null)
                        {
                            janelaGerenciarU.Close();
                        }

                        janelaGerenciarUsuarios.Show();
                    }
                    else
                    {
                        MessageBox.Show("Apenas um administrador pode acessar esta página.");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro:");
                }
            }
            catch
            {

            }
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Hide();
        }

        private void btn_entrada_MouseEnter(object sender, EventArgs e)
        {
            btn_entrada.Size = new Size(80, 80);

            //btn_entrada.Left -= 5;

            //btn_entrada.Top -= 5;

            toolTip1.SetToolTip(btn_entrada, "Entrada de produtos");
        }

        private void btn_entrada_MouseLeave(object sender, EventArgs e)
        {
            btn_entrada.Size = new Size(70, 70);

            //btn_entrada.Left += 5;

            //btn_entrada.Top += 5;
        }

        private void btn_saida_MouseEnter(object sender, EventArgs e)
        {
            btn_saida.Size = new Size(80, 80);

            //btn_saida.Left -= 5;

            //btn_saida.Top -= 5;

            toolTip1.SetToolTip(btn_saida, "Saída de produtos");
        }

        private void btn_saida_MouseLeave(object sender, EventArgs e)
        {
            btn_saida.Size = new Size(70, 70);

            //btn_saida.Left += 5;

            //btn_saida.Top += 5;
        }

        private void btn_estoque_MouseEnter(object sender, EventArgs e)
        {
            btn_estoque.Size = new Size(80, 80);

            //btn_estoque.Left -= 5;

            //btn_estoque.Top -= 5;

            toolTip1.SetToolTip(btn_estoque, "Consultar Estoque");
        }

        private void btn_estoque_MouseLeave(object sender, EventArgs e)
        {
            btn_estoque.Size = new Size(70, 70);

            //btn_estoque.Left += 5;

            //btn_estoque.Top += 5;
        }

        private void btn_cadastraprod_MouseEnter(object sender, EventArgs e)
        {
            btn_cadastraprod.Size = new Size(80, 80);

            //btn_cadastraprod.Left -= 5;

           // btn_cadastraprod.Top -= 5;

            toolTip1.SetToolTip(btn_cadastraprod, "Cadastrar novo produto");
        }

        private void btn_cadastraprod_MouseLeave(object sender, EventArgs e)
        {
            btn_cadastraprod.Size = new Size(70, 70);

            //btn_cadastraprod.Left += 5;

            //btn_cadastraprod.Top += 5;
        }

        private void btn_entrada_Click(object sender, EventArgs e)
        {
            EntradaProdutos janelaEntradaProdutos = new EntradaProdutos();

            Form janelaEntradaP = Application.OpenForms["EntradaProdutos"];

            if (janelaEntradaP != null)
            {
                janelaEntradaP.Close();
            }

            janelaEntradaProdutos.Show();
        }

        private void btn_saida_Click(object sender, EventArgs e)
        {
            SaidaProdutos janelaSaidaProdutos = new SaidaProdutos();

            Form janelaSaidaP = Application.OpenForms["SaidaProdutos"];

            if (janelaSaidaP != null)
            {
                janelaSaidaP.Close();
            }

            janelaSaidaProdutos.Show();
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            ConsultaProdutos janelaConsultaProdutos = new ConsultaProdutos();

            Form janelaConsultaP = Application.OpenForms["ConsultaProdutos"];

            if (janelaConsultaP != null)
            {
                janelaConsultaP.Close();
            }

            janelaConsultaProdutos.Show();
        }

        private void btn_cadastraprod_Click(object sender, EventArgs e)
        {
            CadastroProdutos janelaCadastroProdutos = new CadastroProdutos();

            Form janelaCadastroP = Application.OpenForms["CadastroProdutos"];

            if (janelaCadastroP != null)
            {
                janelaCadastroP.Close();
            }

            janelaCadastroProdutos.Show();
        }

        private void btn_cadastrauser_Click(object sender, EventArgs e)
        {
            String usuario = global.usuario;

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "Select * from usuarios where usuario ='" + usuario + "'";
                MySqlCommand executar = new MySqlCommand(SQL, conexao);
                MySqlDataReader Resultado = executar.ExecuteReader();

                try
                {
                    Resultado.Read();
                    String admUSER = Resultado.GetString("adm").ToString();
                    if (admUSER == "Sim")
                    {
                        CadastroUsuarios janelaCadastroUsuarios = new CadastroUsuarios();

                        Form janelaCadastroU = Application.OpenForms["CadastroUsuarios"];

                        if (janelaCadastroU != null)
                        {
                            janelaCadastroU.Close();
                        }

                        janelaCadastroUsuarios.Show();
                    }
                    else
                    {
                        MessageBox.Show("Apenas um administrador pode acessar esta página.");
                    }
                }
                catch(Exception erro)
                {
                    MessageBox.Show("Erro:" + erro.Message);
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro:" + erro.Message);
            }
        }

        private void btn_colsultauser_Click(object sender, EventArgs e)
        {
            String usuario = global.usuario;

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "Select * from usuarios where usuario ='" + usuario + "'";
                MySqlCommand executar = new MySqlCommand(SQL, conexao);
                MySqlDataReader Resultado = executar.ExecuteReader();

                try
                {
                    Resultado.Read();
                    String admUSER = Resultado.GetString("adm").ToString();
                    if (admUSER == "Sim")
                    {
                        GerenciarUsuarios janelaGerenciarUsuarios = new GerenciarUsuarios();

                        Form janelaGerenciarU = Application.OpenForms["GerenciarUsuarios"];

                        if (janelaGerenciarU != null)
                        {
                            janelaGerenciarU.Close();
                        }

                        janelaGerenciarUsuarios.Show();
                    }
                    else
                    {
                        MessageBox.Show("Apenas um administrador pode acessar esta página.");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro:");
                }
            }
            catch
            {

            }
        }

        private void btn_trocauser_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();

            this.Hide();
        }

        private void btn_cadastrauser_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_cadastrauser, "Cadastrar usuário");
        }

        private void btn_colsultauser_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_colsultauser, "Consultar usuários");
        }

        private void btn_trocauser_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_trocauser, "Trocar usuário");
        }

        private void consultarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor janelaConsultaFornecedor = new ConsultaFornecedor();

            Form janelaConsultaF = Application.OpenForms["ConsultaFornecedor"];

            if (janelaConsultaF != null)
            {
                janelaConsultaF.Close();
            }

            janelaConsultaFornecedor.Show();
        }

        private void cadastrarNovoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor janelaCadastroFornecedor = new CadastroFornecedor();

            Form janelaCadastroF = Application.OpenForms["CadastroFornecedor"];

            if (janelaCadastroF != null)
            {
                janelaCadastroF.Close();
            }

            janelaCadastroFornecedor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor janelaConsultaFornecedor = new ConsultaFornecedor();

            Form janelaConsultaF = Application.OpenForms["ConsultaFornecedor"];

            if (janelaConsultaF != null)
            {
                janelaConsultaF.Close();
            }

            janelaConsultaFornecedor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroFornecedor janelaCadastroFornecedor = new CadastroFornecedor();

            Form janelaCadastroF = Application.OpenForms["CadastroFornecedor"];

            if (janelaCadastroF != null)
            {
                janelaCadastroF.Close();
            }

            janelaCadastroFornecedor.Show();
        }

        private void históricoDeAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String usuario = global.usuario;

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "Select * from usuarios where usuario ='" + usuario + "'";
                MySqlCommand executar = new MySqlCommand(SQL, conexao);
                MySqlDataReader Resultado = executar.ExecuteReader();

                try
                {
                    Resultado.Read();
                    String admUSER = Resultado.GetString("adm").ToString();
                    if (admUSER == "Sim")
                    {
                        historico janelahistorico = new historico();

                        Form janelahistoricof = Application.OpenForms["historico"];

                        if (janelahistoricof != null)
                        {
                            janelahistoricof.Close();
                        }

                        janelahistorico.Show();
                    }
                    else
                    {
                        MessageBox.Show("Apenas um administrador pode acessar esta página.");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro:");
                }
            }
            catch
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String usuario = global.usuario;

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();

                String SQL = "Select * from usuarios where usuario ='" + usuario + "'";
                MySqlCommand executar = new MySqlCommand(SQL, conexao);
                MySqlDataReader Resultado = executar.ExecuteReader();

                try
                {
                    Resultado.Read();
                    String admUSER = Resultado.GetString("adm").ToString();
                    if (admUSER == "Sim")
                    {
                        historico janelahistorico = new historico();

                        Form janelahistoricof = Application.OpenForms["historico"];

                        if (janelahistoricof != null)
                        {
                            janelahistoricof.Close();
                        }

                        janelahistorico.Show();
                    }
                    else
                    {
                        MessageBox.Show("Apenas um administrador pode acessar esta página.");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro:");
                }
            }
            catch
            {

            }
        }

        private void btn_cadastraf_MouseEnter(object sender, EventArgs e)
        {
            btn_cadastraf.Size = new Size(80, 80);

            //btn_cadastraprod.Left -= 5;

            // btn_cadastraprod.Top -= 5;

            toolTip1.SetToolTip(btn_cadastraf, "Cadastrar novo fornecedor");
        }

        private void btn_cadastraf_MouseLeave(object sender, EventArgs e)
        {
            btn_cadastraf.Size = new Size(70, 70);

            //btn_estoque.Left += 5;

            //btn_estoque.Top += 5;
        }

        private void btn_fornecedor_MouseEnter(object sender, EventArgs e)
        {
            btn_fornecedor.Size = new Size(80, 80);

            //btn_cadastraprod.Left -= 5;

            // btn_cadastraprod.Top -= 5;

            toolTip1.SetToolTip(btn_fornecedor, "Consultar Fornecedores");
        }

        private void btn_fornecedor_MouseLeave(object sender, EventArgs e)
        {
            btn_fornecedor.Size = new Size(70, 70);

            //btn_estoque.Left += 5;

            //btn_estoque.Top += 5;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new Size(80, 80);

            //btn_cadastraprod.Left -= 5;

            // btn_cadastraprod.Top -= 5;

            toolTip1.SetToolTip(button1, "Histórico de Atividade");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(70, 70);

            //btn_estoque.Left += 5;

            //btn_estoque.Top += 5;
        }
    }
}
