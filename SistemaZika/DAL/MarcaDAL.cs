using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MarcaDAL

    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDZikaConnectionString"].ConnectionString;

        public List<Marca> SelecionarCarrosFiltros()
        {
            List<Marca> listaMarcas = new List<Marca>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();


                string sql = "SELECT * FROM Marcas";

                SqlCommand cmd = new SqlCommand(sql, conn);
                                

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Marca m = null;
                    while (dr.Read())
                    {
                        m = new Marca();
                        m.CdMarca = Convert.ToInt32(dr["CdMarca"]);
                        m.DsDescricao = dr["DsMarca"].ToString();
                        

                        listaMarcas.Add(m);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            return listaMarcas;
        }

        public void inserirMarca(Marca objMarca)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INT Marcas values (@dsMarca)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@dsMarca", objMarca.CdMarca);
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
