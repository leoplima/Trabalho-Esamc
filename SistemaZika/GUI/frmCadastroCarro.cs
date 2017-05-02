using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;

namespace GUI
{
    public partial class frmCadastroCarro : Form
    {
        private object cbMarca;

        public frmCadastroCarro()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            //Para limpar os campos
            //txtCodigo.Clear();
            //txtCodigo.Text = "";
            //txtCodigo.Text = string.Empty;

            foreach(TextBox control in this.Controls.OfType<TextBox>())
            {
                control.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Carro objCarro = new Carro();
            objCarro.DsMarca = cbMarca.ToString();
            objCarro.DsModelo = txtModelo.Text;
            objCarro.DsCor = txtCor.Text;

            CarroDAL cDAL = new CarroDAL();
            cDAL.InserirCarro(objCarro);

            LimparCampos();

            CarregarCarros();

            MessageBox.Show("Carro inserido com sucesso");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Carro objCarro = new Carro();
            objCarro.CdCarro = Convert.ToInt32(txtCodigo.Text);
            objCarro.DsMarca = cbMarca.ToString();
            objCarro.DsModelo = txtModelo.Text;
            objCarro.DsCor = txtCor.Text;

            CarroDAL cDAL = new CarroDAL();
            cDAL.AtualizarCarro(objCarro);

            LimparCampos();

            CarregarCarros();

            ControlarComponentes(true, false, false, true, true);

            MessageBox.Show("Carro Atualizado com sucesso");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);

            CarroDAL cDAL = new CarroDAL();

            Carro c = cDAL.SelecionarCarroPeloCodigo(codigo);

            if (c == null)
            {
                MessageBox.Show("Carro não encontrado");
            }
            else
            {
                cbMarca= c.DsMarca;
                txtModelo.Text = c.DsModelo;
                txtCor.Text = c.DsCor;

                ControlarComponentes(false, true, true, false, false);
            }
        }


        private void ControlarComponentes(bool adicionar,
            bool atualizar, bool excluir, bool buscar, bool codigo)
        {
            btnAdicionar.Enabled = adicionar;
            btnAtualizar.Enabled = atualizar;
            btnExcluir.Enabled = excluir;
            btnBuscar.Enabled = buscar;
            txtCodigo.Enabled = codigo;
        }

        private void CarregarCarros()
        {
            CarroDAL cDAL = new CarroDAL();

            dgvCarros.DataSource = cDAL.SelecionarTodosCarros();
        }

        private void frmCadastroCarro_Load(object sender, EventArgs e)
        {
            CarregarCarros();
            carregarMarcas();
        }

        private void carregarMarcas()
        {
            MarcaDAL mDAL = new MarcaDAL();
            cbMarcas.DataSource = mDAL.SelecionarCarrosFiltros();// acertar o metodo para carregar todos
            cbMarcas.DisplayMember = "DsMarca";
            cbMarcas.ValueMember = "CdMarca";
            
            
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CarregarCarros();
        }

        private void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
