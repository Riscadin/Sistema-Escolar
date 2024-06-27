using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Threading;
using System.Timers;
using MySqlX.XDevAPI.Common;

namespace JanelasMDI
{
    public partial class frm_Principal : Form
    {
        public string cg = "";
        public string sla = "";

        public frm_Principal()
        {
            InitializeComponent();
        }
        public frm_Principal(string cargo, string nome1)
        {
            InitializeComponent();
            cg = cargo;
            sla = nome1;
        }


        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_CadastrarCliente frmcadcli = new frm_CadastrarCliente();
            //frmcadcli.MdiParent = this;
            //frmcadcli.Show();

            try
            {
                metodoCadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

        }

        private void cadastrarAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               metodoVisuUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }
        private void metodoVisuUsers()
        {
            frm_visualizarUsers frmcadanimal = new frm_visualizarUsers();
            frmcadanimal.MdiParent = this;
            frmcadanimal.Show();
        }

        private void buscarAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_BuscarAnimal frmbuscaranimal = new frm_BuscarAnimal();
            //frmbuscaranimal.MdiParent = this;
            //frmbuscaranimal.Show();
        }

        private void agendarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_AgendarConsulta frmagendarconsulta = new frm_AgendarConsulta();
            //frmagendarconsulta.MdiParent = this;
            //frmagendarconsulta.Show();
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Ajuda frmajuda = new frm_Ajuda();
            frmajuda.MdiParent = this;
            frmajuda.Show();

        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sobre frmsobre = new frm_Sobre();
            //frmsobre.MdiParent = this;
            frmsobre.Show();
        }

        private void organizarJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }
           
        }

        private void organizarNaVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
            }

        }

        private void organizarEmCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }
            
        }

        private void fecharTodasJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void metodoCadCliente()
        {
            frmCadClientes cadCli = new frmCadClientes();
            cadCli.MdiParent = this;
            cadCli.Show();
        }
        private void metodoCadUser()
        {
            frm_CadUsuariosSistema cadUser = new frm_CadUsuariosSistema();
            cadUser.MdiParent = this;
            cadUser.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodoListarClientes();
        }

        private void metodoListarClientes()
        {
            frm_ListarCli listar = new frm_ListarCli();
            listar.MdiParent = this;
            listar.Show();
        }
        private void metodoListarAlunos()
        {
            frm_ListarAlu listarAluno = new frm_ListarAlu();
            listarAluno.MdiParent = this;
            listarAluno.Show();
        }

        private void cadClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodoCadCliente();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arquivoToolStripMenuItem.ForeColor = Color.FromArgb(100, 36, 44);
        }

        private void menuStrip2_MouseMove(object sender, MouseEventArgs e)
        {
            //arquivoToolStripMenuItem.BackColor = Color.Black;
            //arquivoToolStripMenuItem.ForeColor = Color.Black;
        }

        private void menuStrip2_MouseLeave(object sender, EventArgs e)
        {
            //arquivoToolStripMenuItem.ForeColor = Color.White;
        }

        private void arquivoToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            arquivoToolStripMenuItem.ForeColor = Color.FromArgb(100, 36, 44);
        }

        private void arquivoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            arquivoToolStripMenuItem.ForeColor = Color.White;
        }

        private void sistemaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            sistemaToolStripMenuItem.ForeColor = Color.FromArgb(100, 36, 44);
        }

        private void sistemaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            sistemaToolStripMenuItem.ForeColor = Color.White;
        }

        private void ferramentasToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            ferramentasToolStripMenuItem.ForeColor = Color.FromArgb(100, 36, 44);
        }

        private void ferramentasToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            //ferramentasToolStripMenuItem.ForeColor = Color.White;
        }

        private void janelaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            janelaToolStripMenuItem.ForeColor = Color.FromArgb(100, 36, 44);
        }

        private void janelaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            janelaToolStripMenuItem.ForeColor = Color.White;
        }

        private void ajudaToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            ajudaToolStripMenuItem.ForeColor = Color.FromArgb(100, 36, 44);
        }

        private void ajudaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ajudaToolStripMenuItem.ForeColor = Color.White;
        }

        private void ferramentasToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ferramentasToolStripMenuItem.ForeColor = Color.White;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadAlu();
        }

        private void cadAlu()
        {
            frm_CadAlunos cadAlu = new frm_CadAlunos();
            cadAlu.MdiParent = this;
            cadAlu.Show();
        }

        private void tsBtnCadCli_Click(object sender, EventArgs e)
        {
            metodoCadCliente();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarCli();
        }

        private void tsBtnBuscarCli_Click(object sender, EventArgs e)
        {
            buscarCli();
        }
        private void buscarCli()
        {
            frm_BuscarCli buscarCliente = new frm_BuscarCli();
            buscarCliente.MdiParent = this;
            buscarCliente.Show();
        }

        private void buscarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarAlu();
        }
        private void buscarAlu()
        {
            frm_BuscarAlu buscarAlu = new frm_BuscarAlu();
            buscarAlu.MdiParent = this;
            buscarAlu.Show();
        }

        private void tsBtnBuscarAlu_Click(object sender, EventArgs e)
        {
            buscarAlu();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            metodoCadUser();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            cadAlu();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            try
            {
                nomeDoUsuárioToolStripMenuItem.Text = sla;
                //bemvindo.Text = sla + " bem vindo ao nosso\r\nsistema de gerenciamento escolar.\r\n";
                //BemVindoTimer.Start();



                if (cg == "Coordenador")
                {
                    
                }
                else
                {
                    sistemaToolStripMenuItem.Visible = false;
                    toolStripButton2.Visible = false;

                }

          
               
            


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metodoListarAlunos();
        }

        private void minimizarTodasJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Minimized;
            }
        }

        private void maximizarTodasJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.WindowState = FormWindowState.Maximized;
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void BemVindoTimer_Tick(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < 11; i++)
            //{
                
            //    Thread.Sleep(1000);
            //    if (i == 10)
            //    {
            //        bemvindo.Text = "";
            //        BemVindoTimer.Stop();
            //    }
            //}

           
            




        }

        private void bemvindo_Click(object sender, EventArgs e)
        {

        }

        private void nomeDoUsuárioToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            nomeDoUsuárioToolStripMenuItem.ForeColor = Color.White;
        }

        private void nomeDoUsuárioToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            nomeDoUsuárioToolStripMenuItem.ForeColor = Color.FromArgb(100, 36, 44);
        }

        private void exibirToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            exibirToolStripMenuItem.ForeColor = Color.White;
        }

        private void exibirToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            exibirToolStripMenuItem.ForeColor = Color.FromArgb(100, 36, 44);
        }

        private void caixaDeFerramentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(toolStrip1.Visible == true)
            {
                toolStrip1.Visible = false;
            }
            else
            {
                toolStrip1.Visible = true;
            }
            
        }

        private void fazerLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Tem certeza que deseja sair para logar com outra conta?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                    this.Hide();
                    frm_Login f = new frm_Login();
                    f.ShowDialog();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO");
            }
        }
    }
}
