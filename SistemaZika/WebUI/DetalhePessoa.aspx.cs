using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace WebUI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!Page.IsPostBack)
            {

                if (Request.QueryString["codigo"] != null)
                {
                    int cdPessoa = Convert.ToInt32(Request.QueryString["codigo"]);

                    PessoaDAL pDAL = new PessoaDAL();
                    Pessoa objPessoa = pDAL.SelecionarPessoaPeloCodigo(cdPessoa);

                    lblNome.Text = objPessoa.NmPessoa;
                    lblEmail.Text = objPessoa.DsEmail;
                    lblSexo.Text = objPessoa.DsSexo;
                    lblEstCivil.Text = objPessoa.DsEstadoCivil;
                    cbRecebeEmail.Checked = objPessoa.BtRecebeEmail;
                    cbRecebeSMS.Checked= objPessoa.BtRecebeSMS;
                }
            }
        }
    }
}