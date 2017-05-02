using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (fupArquivo.HasFile)
            {
                string raiz = Server.MapPath("Arquivos\\");
                //lblMensagem.Text = raiz;
                fupArquivo.SaveAs(raiz + fupArquivo.FileName);
            }
        }
    }
}