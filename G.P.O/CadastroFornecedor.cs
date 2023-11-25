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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void combo_tipo_TextChanged(object sender, EventArgs e)
        {
            if(combo_tipo.Text == "Pessoa Física")
            {
                txt_cnpj.Visible = false;
                txt_ie.Visible = false;

                txt_cnpj.Text = "";
                txt_ie.Text = "";
            }
            else
            {
                txt_cnpj.Visible = true;
                txt_ie.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if(combo_tipo.Text == "Pessoa Jurídica")
            {
                if (txt_nome.Text == "" || txt_contato.Text == "" || txt_fone.Text == "" || txt_endereco.Text == "" || txt_numero.Text == "" || txt_pais.Text == "" || txt_estado.Text == "" || txt_email.Text == "")
                {
                    MessageBox.Show("Preencha os campos obrigatórios!");
                }
                else
                {
                    MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
                    try
                    {
                        conexao.Open();

                        String tipo = combo_tipo.Text;
                        String nome = txt_nome.Text;
                        String contato = txt_contato.Text;
                        String fone = txt_fone.Text;
                        String ramal = txt_ramal.Text;
                        String cpf = txt_cpf.Text;
                        String rg = txt_rg.Text;
                        String cnpj = txt_cnpj.Text;
                        String ie = txt_ie.Text;
                        String data = txt_data.Text;
                        String sexo = combo_sexo.Text;
                        String cep = txt_cep.Text;
                        String endereco = txt_endereco.Text;
                        String numero = txt_numero.Text;
                        String pais = txt_pais.Text;
                        String cidade = txt_cidade.Text;
                        String bairro = txt_bairro.Text;
                        String estado = txt_estado.Text;
                        String observacao = txt_obs.Text;
                        String fone2 = txt_fone2.Text;
                        String fone3 = txt_fone3.Text;
                        String fax = txt_fax.Text;
                        String email = txt_email.Text;
                        String site = txt_site.Text;

                        if (observacao == "")
                        {
                            observacao = "Nenhuma observação.";
                        }
                        if (fone2 == "")
                        {
                            fone2 = "-";
                        }
                        if (fone3 == "")
                        {
                            fone3 = "-";
                        }
                        if (fax == "")
                        {
                            fax = "-";
                        }
                        if (site == "")
                        {
                            site = "-";
                        }
                        if (ramal == "")
                        {
                           ramal  = "-";
                        }
                        if (cpf == "")
                        {
                           cpf  = "-";
                        }
                        if (rg == "")
                        {
                            rg = "-";
                        }
                        if (cnpj == "")
                        {
                           cnpj  = "-";
                        }
                        if (ie == "")
                        {
                            ie = "-";
                        }
                        if (data == "")
                        {
                           data  = "-";
                        }
                        if (cidade == "")
                        {
                            cidade = "-";
                        }
                        if (bairro == "")
                        {
                            bairro = "-";
                        }
                        if (cep == "")
                        {
                            cep = "-";
                        }



                        String SQL = "insert into fornecedores (fornecedor, tipo, contato, fone, ramal, cpf, rg, cgc_cnpj, IE, data_n, sexo, cep, endereco, numero, pais, cidade, bairro, estado, fone_2, fone_3, fax, email, site, observacao)";
                        SQL += " values ('" + nome + "','" + tipo + "','" + contato + "','" + fone + "','" + ramal + "','" + cpf + "','" + rg + "','" + cnpj + "','" + ie + "','" + data + "','" + sexo + "','" + cep + "','" + endereco + "','" + numero + "','" + pais + "','" + cidade + "','" + bairro + "','" + estado + "','" + fone2 + "','" + fone3 + "','" + fax + "','" + email + "','" + site + "','" + observacao +"')";

                        MySqlCommand executa = new MySqlCommand(SQL, conexao);
                        executa.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor cadastrado com sucesso!");

                        txt_nome.Clear();
                        combo_tipo.SelectedIndex = 0;
                        txt_contato.Clear();
                        txt_fone.Clear();
                        txt_ramal.Clear();
                        txt_cpf.Clear();
                        txt_rg.Clear();
                        txt_cnpj.Clear();
                        txt_ie.Clear();
                        txt_data.Clear();
                        combo_sexo.SelectedIndex = 0;
                        txt_cep.Clear();
                        txt_endereco.Clear();
                        txt_numero.Clear();
                        txt_pais.Clear();
                        txt_cidade.Clear();
                        txt_bairro.Clear();
                        txt_estado.Clear();
                        txt_obs.Clear();
                        txt_email.Clear();
                        txt_fone2.Clear();
                        txt_fone3.Clear();
                        txt_fax.Clear();
                        txt_site.Clear();

                        txt_nome.Focus();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao cadastrar o fornecedor: " + erro.Message);
                    }
                }
            }


            else if(combo_tipo.Text == "Pessoa Física")
            {
                if (txt_nome.Text == "" || txt_contato.Text == "" || txt_fone.Text == "" || txt_ramal.Text == "" || txt_cpf.Text == "" || txt_rg.Text == "" || txt_data.Text == "" || txt_cep.Text == "" || txt_endereco.Text == "" || txt_numero.Text == "" || txt_pais.Text == "" || txt_cidade.Text == "" || txt_bairro.Text == "" || txt_estado.Text == "" || txt_email.Text == "")
                {
                    MessageBox.Show("Preencha os campos obrigatórios!");
                }
                else
                {

                    MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
                    try
                    {
                        conexao.Open();

                        String tipo = combo_tipo.Text;
                        String nome = txt_nome.Text;
                        String contato = txt_contato.Text;
                        String fone = txt_fone.Text;
                        String ramal = txt_ramal.Text;
                        String cpf = txt_cpf.Text;
                        String rg = txt_rg.Text;
                        String cnpj = ".";
                        String ie = ".";
                        String data = txt_data.Text;
                        String sexo = combo_sexo.Text;
                        String cep = txt_cep.Text;
                        String endereco = txt_endereco.Text;
                        String numero = txt_numero.Text;
                        String pais = txt_pais.Text;
                        String cidade = txt_cidade.Text;
                        String bairro = txt_bairro.Text;
                        String estado = txt_estado.Text;
                        String observacao = txt_obs.Text;
                        String fone2 = txt_fone2.Text;
                        String fone3 = txt_fone3.Text;
                        String fax = txt_fax.Text;
                        String email = txt_email.Text;
                        String site = txt_site.Text;

                        String SQL = "insert into fornecedores (fornecedor, tipo, contato, fone, ramal, cpf, rg, cgc_cnpj, IE, data_n, sexo, cep, endereco, numero, pais, cidade, bairro, estado, fone_2, fone_3, fax, email, site, observacao)";
                        SQL += " values ('" + nome + "','" + tipo + "','" + contato + "','" + fone + "','" + ramal + "','" + cpf + "','" + rg + "','" + cnpj + "','" + ie + "','" + data + "','" + sexo + "','" + cep + "','" + endereco + "','" + numero + "','" + pais + "','" + cidade + "','" + bairro + "','" + estado + "','" + fone2 + "','" + fone3 + "','" + fax + "','" + email + "','" + site + "','" + observacao + "')";

                        MySqlCommand executa = new MySqlCommand(SQL, conexao);
                        executa.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor cadastrado com sucesso!");

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao cadastrar o fornecedor: " + erro.Message);

                        txt_nome.Clear();

                        txt_nome.Focus();
                    }



                }
            }


        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {
            lbl1.Parent = pictureBox1;
            combo_tipo.SelectedIndex = 0;
            combo_sexo.SelectedIndex = 0;
        }
    }
}
