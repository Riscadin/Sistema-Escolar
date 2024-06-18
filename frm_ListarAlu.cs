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
    

    public partial class frm_ListarAlu : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        MySqlDataAdapter da;

        public frm_ListarAlu()
        {
            InitializeComponent();
        }

        private void frm_ListarAlu_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = rick ; Pwd = 1205;");
                strSQL = "SELECT * FROM t_aluno";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dtAlunos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO :" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
