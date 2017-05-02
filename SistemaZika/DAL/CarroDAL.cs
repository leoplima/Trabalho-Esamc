using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class CarroDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDZikaConnectionString"].ConnectionString;
        //string connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=BDZika; Integrated Security=true";

       /* public List<Carro> SelecionarCarros()
        {
            List<Carro> objCarros = new List<Carro>();

            Carro c1 = new Carro(1, "Chevrolet", "Celta", "Prata");
            Carro c2 = new Carro(2, "VW", "Gol", "Preto");
            Carro c3 = new Carro(3, "Fiat", "Uno", "Vermelho");
            Carro c4 = new Carro(4, "Ferrari", "F-40", "Vermelho");
            Carro c5 = new Carro(5, "Mitsubishi", "Lancer", "Cinza");
            Carro c6 = new Carro(6, "Honda", "Civic", "Branco");
            Carro c7 = new Carro(7, "Jeep", "Renegade", "Dourado");

            objCarros.Add(c1);
            objCarros.Add(c2);
            objCarros.Add(c3);
            objCarros.Add(c4);
            objCarros.Add(c5);
            objCarros.Add(c6);
            objCarros.Add(c7);

            return objCarros;
        }
        */
        public void InserirCarro(Carro c)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Carros VALUES (@ma, @mo, @cor)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", c.DsMarca);
                cmd.Parameters.AddWithValue("@mo", c.DsModelo);
                cmd.Parameters.AddWithValue("@cor", c.DsCor);

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

        public void AtualizarCarro(Carro c)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"UPDATE Carros SET DsMarca=@ma, DsModelo=@mo,
                                DsCor=@co WHERE CdCarro=@c";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", c.DsMarca);
                cmd.Parameters.AddWithValue("@mo", c.DsModelo);
                cmd.Parameters.AddWithValue("@co", c.DsCor);
                cmd.Parameters.AddWithValue("@c", c.CdCarro);

                cmd.ExecuteNonQuery();
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
        }

        public Carro SelecionarCarroPeloCodigo(int codigo)
        {
            Carro objCarro = null;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Carros WHERE CdCarro=@cod";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cod", codigo);
                
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows && dr.Read())
                {
                    objCarro = new Carro();
                    objCarro.CdCarro = codigo;
                    objCarro.DsMarca = dr["DsMarca"].ToString();
                    objCarro.DsModelo = dr["DsModelo"].ToString();
                    objCarro.DsCor = dr["DsCor"].ToString();
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

            return objCarro;
        }

        public List<Carro> SelecionarTodosCarros()
        {
            List<Carro> lista = new List<Carro>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Carros";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    Carro c;
                    while(dr.Read())
                    {
                        c = new Carro();
                        c.CdCarro = Convert.ToInt32(dr["CdCarro"]);
                        c.DsMarca = dr["DsMarca"].ToString();
                        c.DsModelo = dr["DsModelo"].ToString();
                        c.DsCor = dr["DsCor"].ToString();

                        lista.Add(c);
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

            return lista;
        }


        public List<Carro> SelecionarCarrosFiltros(string marca,
            string modelo, string cor)
        {
            List<Carro> listaCarros = new List<Carro>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                /*
                string sql = "SELECT * FROM Carros";

                string filtro = "";

                if (marca != "")
                {
                    filtro = "DsMarca = @marca";
                }
                if (modelo != "")
                {
                    if (filtro != "") filtro += " AND ";
                    filtro += "DsModelo = @modelo";
                }
                if (cor != "")
                {
                    if (filtro != "") filtro += " AND ";
                    filtro += "DsCor = @cor";
                }

                if (filtro != "") sql += " WHERE " + filtro;
                */

                string sql = @"SELECT * FROM Carros WHERE DsMarca LIKE @marca AND 
                           DsModelo LIKE @modelo AND DsCor LIKE @cor";
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@marca", "%"+ marca + "%");
                cmd.Parameters.AddWithValue("@modelo", "%" + modelo + "%");
                cmd.Parameters.AddWithValue("@cor", "%" + cor + "%");

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Carro c = null;
                    while(dr.Read())
                    {
                        c = new Carro();
                        c.CdCarro = Convert.ToInt32(dr["CdCarro"]);
                        c.DsMarca = dr["DsMarca"].ToString();
                        c.DsModelo = dr["DsModelo"].ToString();
                        c.DsCor = dr["DsCor"].ToString();

                        listaCarros.Add(c);
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

            return listaCarros;
        }
    }
}
