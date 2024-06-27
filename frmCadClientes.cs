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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JanelasMDI
{
    public partial class frmCadClientes : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;
        public string cargo = "";
        int codigoCli = 0;
        DateTime data;

        private List<Cliente> clientes = new List<Cliente>();

        public List<TextBox> sla = new List<TextBox>();



        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //
        }
        private void metodoAtualizarCod()
        {
            conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");

            strSQL = "select MAX(CodigoCliente) from t_cliente";

            comando = new MySqlCommand(strSQL, conexao);

            conexao.Open();

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtCodCli.Text = Convert.ToString(dr["MAX(CodigoCliente)"]);
                }
            }

            codigoCli = (int)(1 + Convert.ToInt64(txtCodCli.Text));
            txtCodCli.Text = Convert.ToString(codigoCli);

            conexao.Close();
        }
        private void executaBuscaTratada()
        {
            try
            {

                mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara1 = mskCep.Text;

                int c;
                string input = valorSemMascara1;

                if (int.TryParse(input, out c) && input.Length == 8)
                {
                    BuscaCEP buscaCEP = new BuscaCEP(c);

                    if (string.IsNullOrEmpty(buscaCEP.Cep))
                    {
                        limparcamposendereco();
                        MessageBox.Show("CEP não encontrado." + "Verifique o número digitado e tente novamente.", "CEP Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mskCep.Clear();
                        mskCep.Focus();
                    }
                    else
                    {
                        txtRua.Text = buscaCEP.Rua;
                        txtBairro.Text = buscaCEP.Cidade;
                        txtCidade.Text = buscaCEP.Estado;
                        txtEstado.Text = buscaCEP.Ibge;
                    
                    }


                }
                mskCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }
            catch
            {
                limparcamposendereco();
                MessageBox.Show("Por favor, insira um CEP válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCep.Focus();
            }
        }
        private void limparcamposendereco()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtRua.Clear();
            txtEstado.Clear();
            mskCep.Clear();
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            dataNascimento.MaxDate = DateTime.Now;

            sla.Add(txtProfissao);
            sla.Add(txtBairro);
            sla.Add(txtCidade);
            sla.Add(txtEstado);
            sla.Add(txtNome);
            sla.Add(txtPais);
            sla.Add(txtRua);

            metodoAtualizarCod();
            frmCadClientes myWindow = new frmCadClientes();
            myWindow.Dock = DockStyle.Fill;
            metodoAtualizarCod();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void AdicionarClienteAoDataGridView(Cliente cliente)
        {
           //
        }

        private void limparCampos()
        {
            

            txtNome.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            data = DateTime.Now;
            //dataNascimento = Convert.ToDateTime(DateTime.Now.T));
            cbxGenero.Text = "";
            mskCpf.Clear();
            txtProfissao.Clear();
            mskCep.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtNumeroCasa.Clear();
            mskDdd.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //
        }
        private bool ContemCaracteresAlfanumericos(string input)
        {
          
           /* MessageBox.Show(input)*/;
            char[] nums = { '1','2','3','4','5','6','7','8','8','9','0'};

            foreach(char c in input)
            {
                if (nums.Contains(c))
                {
                    return true;
                }
                  
            }

            return false;
        }
        private bool ContemCaracteresEspecial(string input)
        {
            char[] caracteresEspeciais = { '@', '!', '#', '$', '%', '¨', '&', '*', '(', ')', '-', '_', '+', '=', '§', '{', '}', '[', ']', '?', '/', '.', ',', '>', '<', ':', ';', '"' };

            foreach (char c in input)
            {
                if (caracteresEspeciais.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }
        int flag = 0;
        private void SalvarCliente()
        {
            flag = 0;
            data = Convert.ToDateTime(dataNascimento.Text);
           

            string testeEmail2 = txtEmail.Text;

            try
            {

                mskDdd.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara1 = mskDdd.Text;

                mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara2 = mskCep.Text;

                mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara3 = mskTelefone.Text;

                //mskNumeroCasa.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                //var valorSemMascara4 = mskNumeroCasa.Text;

                mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara5 = mskCpf.Text;

                
                    
                foreach (TextBox c in sla)
                {
                    //TextBox textBox = control as TextBox;
                    

                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        MessageBox.Show("Alguns campos estão incompletos!", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        flag++;
                       
                        // Verificar se contém alfanuméricos e se tem algum carater especial.
                        if (ContemCaracteresAlfanumericos(c.Text) || ContemCaracteresEspecial(c.Text))
                        {
                            MessageBox.Show("Você digitou um número em um campo de texto, ou, pode ser que você tenha digitado algum caracter especial.", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                           flag++;
                            if (testeEmail2.Contains("@") && testeEmail2.Contains("."))
                            {

                                flag++;
                                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");

                                strSQL = "INSERT INTO t_cliente (NomeCompleto, EnderecoRua, EnderecoBairro, EnderecoNumero, EnderecoCidade, EnderecoEstado, EnderecoPais, CEP, TelefoneDDD, TelefoneNumero, Email, DataNascimento, Genero, CPF, Profissao) VALUES (@NomeCompleto, @EnderecoRua, @EnderecoBairro, @EnderecoNumero, @EnderecoCidade, @EnderecoEstado, @EnderecoPais, @CEP, @TelefoneDDD, @TelefoneNumero, @Email, @DataNascimento, @Genero, @CPF, @Profissao)";

                                comando = new MySqlCommand(strSQL, conexao);

                                comando.Parameters.AddWithValue("@NomeCompleto", txtNome.Text);
                                comando.Parameters.AddWithValue("@TelefoneDDD", mskDdd.Text);
                                comando.Parameters.AddWithValue("@TelefoneNumero", mskTelefone.Text);
                                comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                                comando.Parameters.AddWithValue("@DataNascimento",data);
                                comando.Parameters.AddWithValue("@Genero", cbxGenero.Text);
                                comando.Parameters.AddWithValue("@EnderecoRua", txtRua.Text);
                                comando.Parameters.AddWithValue("@EnderecoBairro", txtBairro.Text);
                                comando.Parameters.AddWithValue("@EnderecoNumero", txtNumeroCasa.Text);
                                comando.Parameters.AddWithValue("@EnderecoCidade", txtCidade.Text);
                                comando.Parameters.AddWithValue("@EnderecoEstado", txtEstado.Text);
                                comando.Parameters.AddWithValue("@EnderecoPais", txtPais.Text);
                                comando.Parameters.AddWithValue("@CPF", mskCpf.Text);
                                comando.Parameters.AddWithValue("@Profissao", txtProfissao.Text);
                                comando.Parameters.AddWithValue("@CEP", mskCep.Text);



                                //MessageBox.Show(flag.ToString());
                                

                            }
                            else
                            {
                                MessageBox.Show("Seu email está incorreto.");
                                txtEmail.Clear();
                                txtEmail.Focus();
                                return;
                            }
                        }
                    }



                   
                }


                if (flag == 21)
                {
                    conexao.Open();
                    comando.ExecuteReader();

                    MessageBox.Show("Cliente cadastrado com sucesso !!");
                    limparCampos();
                    return;

                    codigoCli = (int)(1 + Convert.ToInt64(txtCodCli.Text));
                    txtCodCli.Text = Convert.ToString(codigoCli);
                }

                mskDdd.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //mskCpfAluno.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //mskNumeroCasa.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //mskDataNasc.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mskTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message, "ERRO!!!");
            }
            finally
            {
                conexao.Close();
            }
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {


            SalvarCliente();
           
            
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            if (mskCep.MaskCompleted)
            {
                executaBuscaTratada();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Text = "allaalla";
            txtEmail.Text = "jsfhsjfh@gmail.com";
            txtNumeroCasa.Text = "31";
            txtPais.Text = "Brasil";
            txtProfissao.Text = "8";
            mskCep.Text = "29306035";
            btnSalvar.Focus();
            mskDdd.Text = "12";
            //dataNascimento.Value = DateTime.Now;
            cbxGenero.Text = "Masculino";
        }
    }
}
