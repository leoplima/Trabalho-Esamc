using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;
using System.Security.Cryptography;
using System.Text;

namespace WebUI
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.DsUsuario = txtUsuario.Text;
            usuario.DsSenha = GetMD5Hash(txtSenha.Text);

            UsuarioDAL uDAL = new UsuarioDAL();
            uDAL.InserirUsuario(usuario);

        }

        public string GetMD5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}