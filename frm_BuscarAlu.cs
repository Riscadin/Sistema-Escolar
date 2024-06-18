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
    public partial class frm_BuscarAlu : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;

        public frm_BuscarAlu()
        {
            InitializeComponent();
        }

        private void frm_BuscarAlu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            limparCamposss();
            
        }
        private void limparCamposss()
        {
            rdCodAlu.Checked = false;
            rdCodCli.Checked = false;
            rdCpfAlu.Checked = false;
            rdCpfCli.Checked = false;
            txtEmail.Clear();
            txtNomeCompleto.Clear();
            mskCpfAluno.Clear();
            mskCpfCliente.Clear();
            mskDataNasc.Clear();
            mskTelefone.Clear();
            txtGenero.Clear();
            txtBusCodAluno.Clear();
            txtBusCodCliente.Clear();
            mskBusCpfAlu.Clear();
            mskBusCpfCli.Clear();
            txtMatriculaAluno.Clear();
            mskDdd.Clear();
        }
        public void metodoblock()
        {
            if(txtMatriculaAluno.Text != "")
            {
                mskBusCpfAlu.ReadOnly = true;
                mskBusCpfCli.ReadOnly = true;
                txtBusCodCliente.ReadOnly = true;
            }
            else if(mskBusCpfAlu.MaskCompleted)
            {
                mskBusCpfCli.ReadOnly = true;
                txtBusCodCliente.ReadOnly = true;
                txtBusCodAluno.ReadOnly = true;
            }
            else if (mskBusCpfCli.MaskCompleted)
            {
                txtBusCodCliente.ReadOnly = true;
                txtBusCodAluno.ReadOnly = true;
                mskBusCpfAlu.ReadOnly = true;
            }
            else if(txtBusCodCliente.Text != "")
            {
                mskBusCpfCli.ReadOnly = true;
                txtBusCodAluno.ReadOnly = true;
                mskBusCpfAlu.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Alguma coisa está errada na sua busca, certifique se o campo que está ultilizando para buscar está completo. Outro problema pode ser que você esteja usando mais de um campo para buscar o aluno.", "Mais de um campo de busca!");
            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            

            //metodoblock();





            mskBusCpfCli.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara1 = mskBusCpfCli.Text;

            mskBusCpfAlu.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara2 = mskBusCpfAlu.Text;

            mskDataNasc.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara3 = mskDataNasc.Text;

            mskCpfAluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara4 = mskCpfAluno.Text;

            mskCpfCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara5 = mskCpfCliente.Text;

            conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");
            strSQL = "SELECT * FROM Aluno WHERE MatriculaAluno = @matriculaAluno OR CPFAluno = @cpfaluno OR CPFTutor = @cpfTutor OR CodigoCliente = @codTutor ";
            comando = new MySqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@matriculaAluno", txtBusCodAluno.Text);
            comando.Parameters.AddWithValue("@cpfaluno", mskBusCpfAlu.Text);
            comando.Parameters.AddWithValue("@cpfTutor", mskBusCpfCli.Text);
            comando.Parameters.AddWithValue("@codTutor", txtBusCodCliente.Text);


            conexao.Open();

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtMatriculaAluno.Text = Convert.ToString(dr["MatriculaAluno"]);
                    mskDdd.Text = Convert.ToString(dr["TelefoneDDD"]);
                    mskTelefone.Text = Convert.ToString(dr["TelefoneNumero"]);
                    txtGenero.Text = Convert.ToString(dr["Genero"]);
                    txtNomeCompleto.Text = Convert.ToString(dr["NomeCompleto"]);
                    txtEmail.Text = Convert.ToString(dr["Email"]);
                    mskDataNasc.Text = Convert.ToString(dr["DataNascimento"]);
                    mskCpfAluno.Text = Convert.ToString(dr["CPFAluno"]);
                    mskCpfCliente.Text = Convert.ToString(dr["CPFTutor"]);


                }
                MessageBox.Show("ALUNO ENCONTRADO!");


            }
            else
            {
                MessageBox.Show("ESSE ALUNO NÃO PODE SER ENCONTRADO, TALVEZ ESSE ALUNO NÃO EXISTA NO NOSSO SISTEMA!");
            }
            mskBusCpfCli.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mskBusCpfAlu.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mskDataNasc.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mskCpfAluno.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mskCpfCliente.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void btnBuscarOutro_Click(object sender, EventArgs e)
        {
            mskBusCpfCli.ReadOnly = false;
            txtBusCodAluno.ReadOnly = false;
            mskBusCpfAlu.ReadOnly = false;
            txtBusCodCliente.ReadOnly = false;
            limparCamposss();
        }

        private void mskBusCpfCli_Enter(object sender, EventArgs e)
        {
            //if(mskBusCpfAlu != null && txtBusCodCliente.Text != null && txtBusCodAluno.Text != null)
            //{
            //    txtBusCodCliente.ReadOnly = true;
            //    txtBusCodAluno.ReadOnly = true;
            //    mskBusCpfAlu.ReadOnly = true;
            //}
            
        }

        private void mskBusCpfCli_Leave(object sender, EventArgs e)
        {
            //if(mskBusCpfCli.Text != "   .   .   -  ")
            //{
            //    txtBusCodCliente.ReadOnly = false;
            //    txtBusCodAluno.ReadOnly = false;
            //    mskBusCpfAlu.ReadOnly = false;
            //}

        }

        private void txtBusCodCliente_Enter(object sender, EventArgs e)
        {
            //if (mskBusCpfCli != null && mskBusCpfAlu != null && txtBusCodAluno.Text != null)
            //{
            //    mskBusCpfCli.ReadOnly = true;
            //    txtBusCodAluno.ReadOnly = true;
            //    mskBusCpfAlu.ReadOnly = true;
            //}
            
        }

        private void txtBusCodCliente_Leave(object sender, EventArgs e)
        {
            //if (txtBusCodCliente.Text == "")
            //{
            //    mskBusCpfCli.ReadOnly = false;
            //    txtBusCodAluno.ReadOnly = false;
            //    mskBusCpfAlu.ReadOnly = false;
            //}
        }

        private void mskBusCpfAlu_Enter(object sender, EventArgs e)
        {
            //if (mskBusCpfCli != null && txtBusCodCliente.Text != null && txtBusCodAluno.Text != null)
            //{
            //    mskBusCpfCli.ReadOnly = true;
            //    txtBusCodCliente.ReadOnly = true;
            //    txtBusCodAluno.ReadOnly = true;
            //}
            
        }

        private void mskBusCpfAlu_Leave(object sender, EventArgs e)
        {
            //if (mskBusCpfAlu.Text != "   .   .   -  ")
            //{
            //    mskBusCpfCli.ReadOnly = false;
            //    txtBusCodCliente.ReadOnly = false;
            //    txtBusCodAluno.ReadOnly = false;
            //}
        }

        private void txtBusCodAluno_Enter(object sender, EventArgs e)
        {
            //if (mskBusCpfCli != null && mskBusCpfAlu != null && txtBusCodCliente.Text != null)
            //{
            //    mskBusCpfAlu.ReadOnly = true;
            //    mskBusCpfCli.ReadOnly = true;
            //    txtBusCodCliente.ReadOnly = true;
            //}
            
        }

        private void txtBusCodAluno_Leave(object sender, EventArgs e)
        {
            //if (txtMatriculaAluno.Text == "")
            //{
            //    mskBusCpfAlu.ReadOnly = false;
            //    mskBusCpfCli.ReadOnly = false;
            //    txtBusCodCliente.ReadOnly = false;
            //}
        }

        private void rdCpfCli_CheckedChanged(object sender, EventArgs e)
        {
            mskBusCpfCli.ReadOnly = false;
            txtBusCodCliente.ReadOnly = true;
            txtBusCodAluno.ReadOnly = true;
            mskBusCpfAlu.ReadOnly = true;
            txtBusCodCliente.Clear();
            txtBusCodAluno.Clear();
            mskBusCpfAlu.Clear();
        }

        private void rdCodCli_CheckedChanged(object sender, EventArgs e)
        {
            txtBusCodCliente.ReadOnly = false;
            mskBusCpfCli.ReadOnly = true;
            txtBusCodAluno.ReadOnly = true;
            mskBusCpfAlu.ReadOnly = true;
            mskBusCpfCli.Clear();
            txtBusCodAluno.Clear();
            mskBusCpfAlu.Clear();
        }

        private void rdCpfAlu_CheckedChanged(object sender, EventArgs e)
        {
            mskBusCpfAlu.ReadOnly=false;
            mskBusCpfCli.ReadOnly = true;
            txtBusCodCliente.ReadOnly = true;
            txtBusCodAluno.ReadOnly = true;
            mskBusCpfCli.Clear();
            txtBusCodCliente.Clear();
            txtBusCodAluno.Clear();
        }

        private void rdCodAlu_CheckedChanged(object sender, EventArgs e)
        {
            txtBusCodAluno.ReadOnly = false;
            mskBusCpfAlu.ReadOnly = true;
            mskBusCpfCli.ReadOnly = true;
            txtBusCodCliente.ReadOnly = true;
            mskBusCpfAlu.Clear();
            mskBusCpfCli.Clear();
            txtBusCodCliente.Clear();
        }
    }

    

}
