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
    public partial class frmCadClientes : Form
    {
        int codigoCli = 0;

        private List<Cliente> clientes = new List<Cliente>();

        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //
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
                        limparcampos();
                        MessageBox.Show("CEP não encontrado." + "Verifique o número digitado e tente novamente.", "CEP Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mskCep.Clear();
                        mskCep.Focus();
                    }
                    else
                    {
                        txtRua.Text = buscaCEP.Rua;
                        txtBairro.Text = buscaCEP.Bairro;
                        txtCidade.Text = buscaCEP.Cidade;
                        txtEstado.Text = buscaCEP.Estado;
                    
                    }


                }
                mskCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }
            catch
            {
                limparcampos();
                MessageBox.Show("Por favor, insira um CEP válido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskCep.Focus();
            }
        }
        private void limparcampos()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtRua.Clear();
            txtEstado.Clear();
            mskCep.Clear();
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            codigoCli = 1 + codigoCli;
            txtCodCli.Text = Convert.ToString(codigoCli);
            frmCadClientes myWindow = new frmCadClientes();
            myWindow.Dock = DockStyle.Fill;
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
            mskDataNasc.Clear();
            cbxGenero.Items.Clear();
            mskCpf.Clear();
            txtProfissão.Clear();
            mskCep.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtNumero.Clear();
            mskDdd.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
           //
           
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            if (mskCep.MaskCompleted)
            {
                executaBuscaTratada();
            }
        }
    }
}
