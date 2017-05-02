using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class UsuarioDAL
    {
        string connectionString = "Data Source=localhost; Initial Catalog=BDZika; User Id=sa ; Password=3s4mc";

        public bool AutenticaUsuario (string usuario, string senha)
        {
            bool autenticado = false;

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Usuarios where Dsusuario=@usu and DsSenha=@senha";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@usu", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);

                SqlDataReader dr = cmd.ExecuteReader();

                autenticado = dr.HasRows;

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }


            return autenticado;
        }

        public void InserirUsuario(Usuario u)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Usuarios VALUES (@usu, @senha)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@usu", u.DsUsuario);
                cmd.Parameters.AddWithValue("@senha", u.DsSenha);
                

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

    }
}
