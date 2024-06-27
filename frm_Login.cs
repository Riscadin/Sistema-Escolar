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
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Expect;


namespace JanelasMDI
{

    public partial class frm_Login : Form
    {
        string senhaCriptografada_Banco;
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataReader dr;
        public string cargo = "";
        public string nome1 = "";

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");

                strSQL = "SELECT NomeUsuario,SenhaUsuario,cargo FROM t_usuarios WHERE NomeUsuario = @login";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@login", txtLogin.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        senhaCriptografada_Banco = Convert.ToString(dr["SenhaUsuario"]);
                    }

                    conexao.Close();

                    Criptografia c = new Criptografia(SHA512.Create());
                    bool resultado = c.VerificarSenha(txtSenha.Text, senhaCriptografada_Banco);

                    if (resultado)
                    {
                        conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");

                        strSQL = "SELECT NomeUsuario,SenhaUsuario,cargo FROM t_usuarios WHERE NomeUsuario = @login AND SenhaUsuario = @senha";
                        comando = new MySqlCommand(strSQL, conexao);
                        comando.Parameters.AddWithValue("@login", txtLogin.Text);
                        comando.Parameters.AddWithValue("@senha", senhaCriptografada_Banco);

                        conexao.Open();

                        dr = comando.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                txtTeste.Text = Convert.ToString(dr["cargo"]);
                            }

                            nome1 = txtLogin.Text;
                            cargo = txtTeste.Text;
                            this.Hide();

                            frm_Principal foi = new frm_Principal(cargo,nome1);
                            foi.ShowDialog();


                            conexao.Close();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("NOME OU SENHA INCORRETA!!", "Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            txtLogin.Clear();
                            txtSenha.Clear();
                            txtLogin.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("SENHA INCORRETA!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Clear();
                        txtSenha.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("NOME OU SENHA INCORRETA!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Clear();
                    txtSenha.Clear();
                    txtLogin.Focus();
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
