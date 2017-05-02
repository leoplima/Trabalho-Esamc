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
    public partial class RelatorioCarros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarGridCarros();
        }
        
        private void CarregarGridCarros()
        {
            CarroDAL cDAL = new CarroDAL();

            grvCarros.DataSource = cDAL.SelecionarTodosCarros();
            grvCarros.DataBind();
        }

    }
}