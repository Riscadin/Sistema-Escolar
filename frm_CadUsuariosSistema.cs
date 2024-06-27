using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
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
    public partial class frm_CadUsuariosSistema : Form
    {

        string senhaCriptografada;
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;
        public string cargo = "";
        private int flag = 0;


        int matriDoUsuario = 0;
        public frm_CadUsuariosSistema()
        {
            InitializeComponent();
        }

        private void frm_CadUsuariosSistema_Load(object sender, EventArgs e)
        {
            //SELECT MAX(CodigoUsuario) FROM t_usuarios;
            conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");

            strSQL = "SELECT MAX(CodigoUsuario) FROM t_usuarios";
            comando = new MySqlCommand(strSQL, conexao);

            conexao.Open();

            dr = comando.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtMatriculaUser.Text = Convert.ToString(dr["MAX(CodigoUsuario)"]);
                }
            }

            matriDoUsuario = (int)(1 + Convert.ToInt64(txtMatriculaUser.Text));
            txtMatriculaUser.Text = Convert.ToString(matriDoUsuario);

            conexao.Close();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            metodoLimparCampos();
        }
        private void metodoLimparCampos()
        {
            txtDigNovamenteSenha.Text = "Digite a Senha Novamente";
            txtNomeUser.Text = "Nome do Usuário";
            txtSenha.Text = "Senha";
            cbxCargo.Text = "Cargo";
            
        }

        private void txtMatriculaUser_Enter(object sender, EventArgs e)
        {
            //
        }

        private void txtNomeUser_Enter(object sender, EventArgs e)
        {
            if(txtNomeUser.Text == "Nome do Usuário")
            {
                txtNomeUser.Text = "";
            }
        }

        private void txtNomeUser_Leave(object sender, EventArgs e)
        {
            if (txtNomeUser.Text == "")
            {
                txtNomeUser.Text = "Nome do Usuário";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if(txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtDigNovamenteSenha.Text == "Digite a Senha Novamente")
            {
                txtDigNovamenteSenha.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtDigNovamenteSenha.Text == "")
            {
                txtDigNovamenteSenha.Text = "Digite a Senha Novamente";
            }
        }

        private void cbxCargo_Enter(object sender, EventArgs e)
        {
            if (cbxCargo.Text == "Cargo")
            {
                cbxCargo.Text = "";
            }
        }

        private void cbxCargo_Leave(object sender, EventArgs e)
        {
            if (cbxCargo.Text == "")
            {
                cbxCargo.Text = "Cargo";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            salvarUser();
            metodoLimparCampos();
        }

        private void salvarUser()
        {
            int flag1 = 0;

            try
            {
                char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '8', '9', '0' };
                char[] caracteresEspeciais = { '@', '!', '#', '$', '%', '¨', '&', '*', '(', ')', '-', '_', '+', '=', '§', '{', '}', '[', ']', '?', '/', '.', ',', '>', '<', ':', ';', '"' };
                foreach (char c in txtNomeUser.Text)
                {
                    if (nums.Contains(c) || caracteresEspeciais.Contains(c))
                    {
                        flag = 1;
                        break;
                    }

                }
                foreach (char c in txtNomeUser.Text)
                {
                    if (nums.Contains(c) || caracteresEspeciais.Contains(c))
                    {
                        flag1 = 1;
                        break;
                    }

                }
                if (flag == 1 || flag1 == 1)
                {
                    MessageBox.Show("Você digitou algo inválido no seu nome ou no Cargo.", "Erro de digitação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    if (txtDigNovamenteSenha.Text != "" && txtSenha.Text != "" && txtNomeUser.Text != "" && cbxCargo.Text != "")
                    {
                        conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");

                        strSQL = "insert into t_usuarios(NomeUsuario,SenhaUsuario,cargo) values(@nome,@senha,@cargo)";
                        comando = new MySqlCommand(strSQL, conexao);
                        comando.Parameters.AddWithValue("@nome", txtNomeUser.Text);
                        comando.Parameters.AddWithValue("@cargo", cbxCargo.Text);

                        Criptografia c = new Criptografia(SHA512.Create());

                        senhaCriptografada = c.CriptografarSenha(txtSenha.Text);

                        if (txtSenha.Text == txtDigNovamenteSenha.Text)
                        {
                            comando.Parameters.AddWithValue("@senha", senhaCriptografada);
                        }

                        conexao.Open();

                        comando.ExecuteReader();

                        MessageBox.Show("Usuário Cadastrado!!", "Sucesso", MessageBoxButtons.OK);
                        matriDoUsuario = 1 + matriDoUsuario;
                        txtMatriculaUser.Text = Convert.ToString(matriDoUsuario);
                    }
                }
                
                

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
