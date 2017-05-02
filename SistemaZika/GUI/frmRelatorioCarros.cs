using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmRelatorioCarros : Form
    {
        public frmRelatorioCarros()
        {
            InitializeComponent();
        }

        private void CarregarCarros()
        {
            CarroDAL cDAL = new CarroDAL();

            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string cor = txtCor.Text;

            dgvCarros.DataSource = cDAL.SelecionarCarrosFiltros(marca, modelo, cor);
        }

        private void frmRelatorioCarros_Load(object sender, EventArgs e)
        {
            CarregarCarros();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarCarros();
        }
    }
}
