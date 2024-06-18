using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanelasMDI
{
    public partial class frm_BuscarCli : Form
    {

        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;
        string tipo = "";

        public frm_BuscarCli()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            txtCodigoCli.Clear();
            mskCpfCli.Clear();
        }
        private void limparCampos()
        {
            txtNome.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtCpff.Clear();
            txtGenero.Clear();
            txtCpff.Clear();
            txtProfissão.Clear();
            txtCep.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtNumero.Clear();
        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            mskCpfCli.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara1 = mskCpfCli.Text;

            conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");
            strSQL = "SELECT * FROM t_cliente WHERE CodigoCliente = @codigo OR CPF = @cpf";
            comando = new MySqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@codigo", txtCodigoCli.Text);
            comando.Parameters.AddWithValue("@cpf", mskCpfCli.Text);


            conexao.Open();

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtCodCli.Text = Convert.ToString(dr["CodigoCliente"]);
                    txtNome.Text = Convert.ToString(dr["NomeCompleto"]);
                    txtEmail.Text = Convert.ToString(dr["Email"]);
                    txtNAscimentoo.Text = Convert.ToString(dr["DataNascimento"]);
                    txtGenero.Text = Convert.ToString(dr["Genero"]);
                    txtProfissão.Text = Convert.ToString(dr["Profissao"]);
                    txtCpff.Text = Convert.ToString(dr["CPF"]);
                    mskDdd.Text = Convert.ToString(dr["TelefoneDDD"]);
                    mskTelefone.Text = Convert.ToString(dr["TelefoneNumero"]);
                    txtCep.Text = Convert.ToString(dr["CEP"]);
                    txtRua.Text = Convert.ToString(dr["EnderecoRua"]);
                    txtNumero.Text = Convert.ToString(dr["EnderecoNumero"]);
                    txtCidade.Text = Convert.ToString(dr["EnderecoCidade"]);
                    txtEstado.Text = Convert.ToString(dr["EnderecoEstado"]);
                    txtPais.Text = Convert.ToString(dr["EnderecoPais"]);
                    txtBairro.Text = Convert.ToString(dr["EnderecoBairro"]);

                }
                MessageBox.Show("CLIENTE ENCONTRADO!");


            }
            else
            {
                MessageBox.Show("ESSE CLIENTE NÃO PODE SER ENCONTRADO, TALVEZ ESSE CLIENTE NÃO EXISTA NO NOSSO SISTEMA!");
            }
            mskCpfCli.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void rdCodCli_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoCli.ReadOnly = false;
            mskCpfCli.ReadOnly = true;
            mskCpfCli.Clear();
        }

        private void rdCpfCli_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoCli.ReadOnly = true;
            mskCpfCli.ReadOnly = false;
            txtCodigoCli.Clear();
        }
    }
}
