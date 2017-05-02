using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class CadastroPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarPessoas();
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.NmPessoa = txtNome.Text;
            p.DsEmail = txtEmail.Text;
            p.DsSexo = rblSexo.SelectedValue;
            p.DsEstadoCivil = ddlEC.SelectedValue;
            p.BtRecebeSMS = chkRecebeSMS.Checked;
            p.BtRecebeEmail = chkRecebeEmail.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.InserirPessoa(p);

            LimparTela();

            CarregarPessoas();

            ExibirMensagem("Inserido com sucesso");
        }

        private void ExibirMensagem(string mensagem)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(),
                "Mensagem", "alert('" + mensagem + "')", true);
        }

        private void LimparTela()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rblSexo.SelectedIndex = 0;
            ddlEC.SelectedIndex = 0;
            chkRecebeSMS.Checked = false;
            chkRecebeEmail.Checked = false;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.CdPessoa = Convert.ToInt32(txtCodigo.Text);
            p.NmPessoa = txtNome.Text;
            p.DsEmail = txtEmail.Text;
            p.DsSexo = rblSexo.SelectedValue;
            p.DsEstadoCivil = ddlEC.SelectedValue;
            p.BtRecebeSMS = chkRecebeSMS.Checked;
            p.BtRecebeEmail = chkRecebeEmail.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.AtualizarPessoa(p);

            LimparTela();

            CarregarPessoas();

            ExibirMensagem("Atualizado com sucesso");
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);


            PessoaDAL pDAL = new PessoaDAL();
            pDAL.ExcluirPessoa(codigo);
            LimparTela();

            CarregarPessoas();

            ExibirMensagem("Excluído com sucesso");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            buscarPessoa(codigo);
            
        }

        private void buscarPessoa(int codigo)
        {
            PessoaDAL pDAL = new PessoaDAL();

            Pessoa p = pDAL.SelecionarPessoaPeloCodigo(codigo);

            if (p != null)
            {
                txtCodigo.Text = p.CdPessoa.ToString();
                txtNome.Text = p.NmPessoa;
                txtEmail.Text = p.DsEmail;
                rblSexo.SelectedValue = p.DsSexo;
                ddlEC.SelectedValue = p.DsEstadoCivil;
                chkRecebeSMS.Checked = p.BtRecebeSMS;
                chkRecebeEmail.Checked = p.BtRecebeEmail;
            }
            else
            {
                ExibirMensagem("Pessoa não foi encontrada!");
            }
        }

        private void CarregarPessoas()
        {
            PessoaDAL pDAL = new PessoaDAL();

            grvPessoas.DataSource = pDAL.ListarPessoas();
            grvPessoas.DataBind();
        }

        protected void grvPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(grvPessoas.SelectedValue);
            buscarPessoa(codigo);
        }
    }
}