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
    public partial class frm_Sobre : Form
    {
        public frm_Sobre()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Sobre_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/5528999021611");
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gmail.com/");
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://riscadin.github.io/prtifolioDDSricardo/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
