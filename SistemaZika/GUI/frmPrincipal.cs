using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioCarros tela = new frmRelatorioCarros();
            tela.MdiParent = this;
            tela.Show();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCarro tela = new frmCadastroCarro();
            tela.MdiParent = this;
            tela.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMarcas tela = new frmCadastroMarcas();
            tela.MdiParent = this;
            tela.Show();
        }

        private void criptografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCriptografia tela = new frmCriptografia();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
