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
    public partial class frm_CadAlunos : Form
    {
        int matriculaAluno = 0;
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
            matriculaAluno = 1 + matriculaAluno;
            frm_CadAlunos myWindow = new frm_CadAlunos();
            myWindow.Dock = DockStyle.Fill;
        }
        private void limparCamposss()
        {
            txtEmail.Clear();
            txtNomeCompleto.Clear();
            mskCpfAluno.Clear();
            mskCpfCliente.Clear();
            mskDataNasc.Clear();
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
    }
}
