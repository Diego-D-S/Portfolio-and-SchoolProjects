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
    public partial class Informacoes : Form
    {
        public Informacoes()
        {
            InitializeComponent();
        }

        private void Informacoes_Load(object sender, EventArgs e)
        {
            lbl1.Parent = pictureBox1;
            lbl2.Parent = pictureBox1;
            combo_sexo.SelectedIndex = 0;
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            try
            {
                conexao.Open();


                String SQL = "select * from fornecedores where fornecedor like '%" + global.fornecedor + "%'";
              
                MySqlCommand executar = new MySqlCommand(SQL, conexao);

                MySqlDataReader Resultado = executar.ExecuteReader();

                Resultado.Read();

                String fornecedor = Resultado.GetString("fornecedor").ToString();
                String tipo = Resultado.GetString("tipo").ToString();
                String contato = Resultado.GetString("contato").ToString();
                String fone = Resultado.GetString("fone").ToString();
                String ramal = Resultado.GetString("ramal").ToString();
                String cpf = Resultado.GetString("cpf").ToString();
                String rg = Resultado.GetString("rg").ToString();
                String cgc_cnpj = Resultado.GetString("cgc_cnpj").ToString();
                String ie = Resultado.GetString("ie").ToString();
                String data_n = Resultado.GetString("data_n").ToString();
                String sexo = Resultado.GetString("sexo").ToString();
                String cep = Resultado.GetString("cep").ToString();
                String endereco = Resultado.GetString("endereco").ToString();
                String numero = Resultado.GetString("numero").ToString();
                String pais = Resultado.GetString("pais").ToString();
                String cidade = Resultado.GetString("cidade").ToString();
                String bairro = Resultado.GetString("bairro").ToString();
                String estado = Resultado.GetString("estado").ToString();
                String fone_2 = Resultado.GetString("fone_2").ToString();
                String fone_3 = Resultado.GetString("fone_3").ToString();
                String fax = Resultado.GetString("fax").ToString();
                String email = Resultado.GetString("email").ToString();
                String site = Resultado.GetString("site").ToString();
                String observacao = Resultado.GetString("observacao").ToString();

                if(fornecedor == "Pessoa Física")
                {
                    lbl_cnpj.Visible = false;
                    lbl_ie.Visible = false;
                }

                lbl_nome.Text = fornecedor;
                lbl_tipo.Text = tipo;
                txt_contato.Text = contato;
                txt_fone.Text = fone;
                txt_ramal.Text = ramal;
                txt_cpf.Text = cpf;
                txt_rg.Text = rg;
                lbl_cnpj.Text = cgc_cnpj;
                lbl_ie.Text = ie;
                txt_data.Text = data_n;
                if(sexo == "M")
                {
                    combo_sexo.SelectedIndex = 0;
                }
                else if(sexo == "F")
                {
                    combo_sexo.SelectedIndex = 1;
                }
                txt_cep.Text = cep;
                txt_endereco.Text = endereco;
                txt_numero.Text = numero;
                txt_pais.Text = pais;
                txt_cidade.Text = cidade;
                txt_bairro.Text = bairro;
                txt_estado.Text = estado;
                txt_fone2.Text = fone_2;
                txt_fone3.Text = fone_3;
                txt_fax.Text = fax;
                txt_email.Text = email;
                txt_site.Text = site;
                txt_obs.Text = observacao;

                button2.Focus();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
            {
                combo_sexo.Enabled = false;
                lbl_nome.Enabled = false;
                lbl_tipo.Enabled = false;
                txt_contato.Enabled = false;
                txt_fone.Enabled = false;
                txt_ramal.Enabled = false;
                txt_cpf.Enabled = false;
                txt_rg.Enabled = false;
                lbl_cnpj.Enabled = false;
                lbl_ie.Enabled = false;
                txt_data.Enabled = false;
                txt_cep.Enabled = false;
                txt_endereco.Enabled = false;
                txt_numero.Enabled = false;
                txt_pais.Enabled = false;
                txt_cidade.Enabled = false;
                txt_bairro.Enabled = false;
                txt_estado.Enabled = false;
                txt_fone2.Enabled = false;
                txt_fone3.Enabled = false;
                txt_fax.Enabled = false;
                txt_email.Enabled = false;
                txt_site.Enabled = false;
                txt_obs.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                combo_sexo.Enabled = true;
                lbl_nome.Enabled = true;
                lbl_tipo.Enabled = true;
                txt_contato.Enabled = true;
                txt_fone.Enabled = true;
                txt_ramal.Enabled = true;
                txt_cpf.Enabled = true;
                txt_rg.Enabled = true;
                lbl_cnpj.Enabled = true;
                lbl_ie.Enabled = true;
                txt_data.Enabled = true;
                txt_cep.Enabled = true;
                txt_endereco.Enabled = true;
                txt_numero.Enabled = true;
                txt_pais.Enabled = true;
                txt_cidade.Enabled = true;
                txt_bairro.Enabled = true;
                txt_estado.Enabled = true;
                txt_fone2.Enabled = true;
                txt_fone3.Enabled = true;
                txt_fax.Enabled = true;
                txt_email.Enabled = true;
                txt_site.Enabled = true;
                txt_obs.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_contato.Text == "" || txt_fone.Text == "" || txt_ramal.Text == "" || txt_cpf.Text == "" || txt_rg.Text == "" || txt_data.Text == "" || txt_cep.Text == "" || txt_endereco.Text == "" || txt_numero.Text == "" || txt_pais.Text == "" || txt_cidade.Text == "" || txt_bairro.Text == "" || txt_estado.Text == "" || txt_email.Text == "")
            {
                MessageBox.Show("Todos os campos devem estar preenchidos!");
            }
            else
            {
                String contato = txt_contato.Text;
                String fone = txt_fone.Text;
                String ramal = txt_ramal.Text;
                String cpf = txt_cpf.Text;
                String rg = txt_rg.Text;
                String data_n = txt_data.Text;
                String sexo = combo_sexo.Text;
                String cep = txt_cep.Text;
                String endereco = txt_endereco.Text;
                String numero = txt_numero.Text;
                String pais = txt_pais.Text;
                String cidade = txt_cidade.Text;
                String bairro = txt_bairro.Text;
                String estado = txt_estado.Text;
                String fone_2 = txt_fone2.Text;
                String fone_3 = txt_fone3.Text;
                String fax = txt_fax.Text;
                String email = txt_email.Text;
                String site = txt_site.Text;
                String observacao = txt_obs.Text;

                String SQL = "update fornecedores set contato ='" + contato + "', fone='" + fone + "',ramal='" + ramal + "', cpf='" + cpf + "',rg='" + rg + "',data_n='" + data_n + "',sexo='" + sexo + "',cep='" + cep + "',endereco='" + endereco + "',numero='" + numero + "',pais='" + pais + "',cidade='" + cidade + "',bairro='" + bairro + "',estado='" + estado + "',fone_2='" + fone_2 + "',fone_3='" + fone_3 + "',fax='" + fax + "',email='" + email + "',site='" + site + "',observacao='" + observacao +"' where fornecedor ='" + lbl_nome.Text + "'";

                MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");
                try
                {
                    conexao.Open();
                    MySqlCommand executa = new MySqlCommand(SQL, conexao);
                    executa.ExecuteNonQuery();

                    MessageBox.Show("Informações atualizadas com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro = " + erro.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String SQL = "delete from fornecedores where fornecedor ='" + lbl_nome.Text + "'";

            MySqlConnection conexao = new MySqlConnection("server=localhost;database=omega;uid=root;pwd=''");

            DialogResult resposta = MessageBox.Show("Deseja excluír este fornecedor?", "G.P.O", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();
                    MySqlCommand executa = new MySqlCommand(SQL, conexao);
                    executa.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor excluido com sucesso!");
                    this.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro = " + erro.Message);
                }
            }
        }
    }
}
