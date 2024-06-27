using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanelasMDI
{
    public partial class frm_CadAlunos : Form
    {


        private string nomeresponsavel;
        private string telefoneCliente;
        private string dddCliente;
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;
        public string cargo = "";
        int matriculaAluno = 0;
        DateTime data;

        public frm_CadAlunos()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatriculaAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_CadAlunos_Load(object sender, EventArgs e)
        {
            dataNascimento.MaxDate = DateTime.Now;
            metodoAtualizarMAtri();
            frm_CadAlunos myWindow = new frm_CadAlunos();
            myWindow.Dock = DockStyle.Fill;
            txtMatriculaAluno.Text = matriculaAluno.ToString();
        }
        private void metodoAtualizarMAtri()
        {
            conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");

            strSQL = "select MAX(MatriculaAluno) from t_aluno";

            comando = new MySqlCommand(strSQL, conexao);

            conexao.Open();

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtMatriculaAluno.Text = Convert.ToString(dr["MAX(MatriculaAluno)"]);
                }
            }

            matriculaAluno = (int)(1 + Convert.ToInt64(txtMatriculaAluno.Text));
            txtMatriculaAluno.Text = Convert.ToString(txtMatriculaAluno);

            conexao.Close();
        }
        private void limparCamposss()
        {
            txtEmail.Clear();
            txtNomeCompleto.Clear();
            mskCpfAluno.Clear();
            mskCpfCliente.Clear();
            //mskDataNasc.Clear();
            mskTelefone.Clear();
            cbxGenero.Items.Clear();
            mskDdd.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCamposss();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mskTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            metodoSalvar();
            
        }
        private void select2()
        {
            mskCpfCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara1 = mskCpfCliente.Text;

            conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");
            strSQL = $"select NomeCliente,TelefoneCliente, DDDCliente from t_cliente join t_aluno on t_cliente.CPF = {mskCpfCliente.Text}";
            comando = new MySqlCommand(strSQL, conexao);
            


            conexao.Open();

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dddCliente = (Convert.ToString(dr["DDDCliente"]));
                    telefoneCliente = (Convert.ToString(dr["TelefoneCliente"]));
                    nomeresponsavel = (Convert.ToString(dr["NomeCliente"]));
                    break;

                }
            }
            mskCpfCliente.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }
        private void Select()
        {
            mskCpfCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara1 = mskCpfCliente.Text;

            conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");
            strSQL = $"select CodigoCliente from t_cliente join t_aluno on t_cliente.CPF = '{mskCpfCliente.Text}';";
            comando = new MySqlCommand(strSQL, conexao);
            //comando.Parameters.AddWithValue("@cpfCliente", );


            conexao.Open();

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    essetxtesse.Text = (Convert.ToString(dr["CodigoCliente"]));
                    break;

                }
            }
            //else
            //{
            //    conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");
            //    strSQL = "select max(CodigoCliente) from t_cliente;";
            //    comando = new MySqlCommand(strSQL, conexao);


            //    conexao.Open();

            //    dr = comando.ExecuteReader();

            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {



            //            int slaa = Convert.ToInt32(dr["max(CodigoCliente)"]);
            //            slaa = slaa + 1;
            //            essetxtesse.Text = slaa.ToString();

            //        }
            //    }
            //}

            mskCpfCliente.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }
       
        private void metodoSalvar()
        {
            int flag = 0;
            int flag1 = 0;
            int flag2 = 0;
            int flag3 = 0;
            try
            {
                select2();
                Select();
                data = Convert.ToDateTime(dataNascimento.Text);

                mskDdd.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara1 = mskDdd.Text;

                mskCpfAluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara2 = mskCpfAluno.Text;

                mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara3 = mskTelefone.Text;

                //mskDataNasc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                //var valorSemMascara4 = mskDataNasc.Text;

                mskCpfCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara5 = mskCpfCliente.Text;


                if(txtNomeCompleto.Text != "" && mskCpfAluno.MaskCompleted && mskCpfCliente.MaskCompleted && mskDdd.MaskCompleted && mskTelefone.MaskCompleted)
                {
                    string testeEmail = txtEmail.Text;
                    if (testeEmail.Contains("@") && testeEmail.Contains("."))
                    {

                        char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '8', '9', '0' };
                        char[] caracteresEspeciais = { '@', '!', '#', '$', '%', '¨', '&', '*', '(', ')', '-', '_', '+', '=', '§', '{', '}', '[', ']', '?', '/', '.', ',', '>', '<', ':', ';', '"' };

                        foreach (char c in txtNomeCompleto.Text)
                        {
                            if (nums.Contains(c))
                            {
                                flag=1;
                            }

                        }
                        foreach (char c in cbxGenero.Text)
                        {
                            if (nums.Contains(c))
                            {
                                flag1 = 1;
                            }

                        }
                        foreach (char c in txtNomeCompleto.Text)
                        {
                            if (caracteresEspeciais.Contains(c))
                            {
                                flag2 = 1;
                            }

                        }
                        foreach (char c in cbxGenero.Text)
                        {
                            if (caracteresEspeciais.Contains(c))
                            {
                                flag3 = 1;
                            }

                        }

                        conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");

                        strSQL = "INSERT INTO t_aluno (NomeCompleto,TelefoneDDD, TelefoneNumero, Email, DataNascimento, Genero, CPFAluno,CodigoCli, CPFTutor, NomeResponsavel, TelefoneResponsavel, DDDresponsavel) VALUES (@NomeCompleto, @TelefoneDDD, @TelefoneNumero, @Email, @DataNascimento, @Genero,@CPFAluno,@CodigoCliente, @CPFTutor, @NomeResponsavel, @TelefoneResponsavel, @DDDresponsavel)";

                        comando = new MySqlCommand(strSQL, conexao);

                        comando.Parameters.AddWithValue("@NomeCompleto", txtNomeCompleto.Text);
                        comando.Parameters.AddWithValue("@TelefoneDDD", mskDdd.Text);
                        comando.Parameters.AddWithValue("@TelefoneNumero", mskTelefone.Text);
                        comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                        comando.Parameters.AddWithValue("@DataNascimento", data);
                        comando.Parameters.AddWithValue("@Genero", cbxGenero.Text);
                        comando.Parameters.AddWithValue("@CPFAluno", mskCpfAluno.Text);
                        comando.Parameters.AddWithValue("@CodigoCliente", essetxtesse.Text);
                        comando.Parameters.AddWithValue("@CPFTutor", mskCpfCliente.Text);
                        comando.Parameters.AddWithValue("@NomeResponsavel", nomeresponsavel);
                        comando.Parameters.AddWithValue("@TelefoneResponsavel", telefoneCliente);
                        comando.Parameters.AddWithValue("@DDDresponsavel", dddCliente);



                        if (flag != 0 || flag1 != 0 || flag2 != 0 || flag3 != 0)
                        {
                            MessageBox.Show("Erro de digitação, você digitou algo inválido!");
                        }
                        else
                        {
                            conexao.Open();

                            comando.ExecuteReader();

                            matriculaAluno = (int)(1 + Convert.ToInt64(txtMatriculaAluno.Text));
                            txtMatriculaAluno.Text = Convert.ToString(matriculaAluno);

                            MessageBox.Show("Aluno cadastrado com sucesso !!");
                            limparCamposss();
                        }

                        
                         

                     


                    }
                    else
                    {
                        MessageBox.Show("Seu email está incorreto.");
                        txtEmail.Clear();
                        txtEmail.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Alguns campos estão incompletos!", "CAMPOS INCOMPLETOS", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

               



                mskDdd.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mskCpfAluno.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mskCpfCliente.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
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
    }
}
