using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class PessoaDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDZikaConnectionString"].ConnectionString;

        public void InserirPessoa(Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Pessoas VALUES (@nome, @email, @sexo, @es, @recebeSMS, @recebeEmail)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", objPessoa.NmPessoa);
                cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
                cmd.Parameters.AddWithValue("@sexo", objPessoa.DsSexo);
                cmd.Parameters.AddWithValue("@es", objPessoa.DsEstadoCivil);
                cmd.Parameters.AddWithValue("@recebeSMS", objPessoa.BtRecebeSMS);
                cmd.Parameters.AddWithValue("@recebeEmail", objPessoa.BtRecebeEmail);
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

        public void AtualizarPessoa(Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = @"UPDATE Pessoas SET NmPessoa = @nome, DsEmail = @email,
                                DsSexo = @sexo, DsEstadoCivil = @es, BtRecebeSMS = @recebeSMS, BtRecebeEmail = @recebeEmail
                                WHERE CdPessoa = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", objPessoa.NmPessoa);
                cmd.Parameters.AddWithValue("@email", objPessoa.DsEmail);
                cmd.Parameters.AddWithValue("@sexo", objPessoa.DsSexo);
                cmd.Parameters.AddWithValue("@es", objPessoa.DsEstadoCivil);
                cmd.Parameters.AddWithValue("@recebeSMS", objPessoa.BtRecebeSMS);
                cmd.Parameters.AddWithValue("@recebeEmail", objPessoa.BtRecebeEmail);
                cmd.Parameters.AddWithValue("@codigo", objPessoa.CdPessoa);
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

        public void ExcluirPessoa(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "DELETE FROM Pessoas WHERE CdPessoa = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

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

        public List<Pessoa> ListarPessoas()
        {
            List<Pessoa> lista = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Pessoas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Pessoa p = null;
                    while (dr.Read())
                    {
                        p = new Pessoa();
                        p.CdPessoa = Convert.ToInt32(dr["CdPessoa"]);
                        p.NmPessoa = dr["DsNome"].ToString();
                        p.DsEmail = dr["DsEmail"].ToString();
                        p.DsSexo = dr["DsSexo"].ToString();
                        p.DsEstadoCivil = dr["DsEstadoCivil"].ToString();
                        p.BtRecebeSMS = Convert.ToBoolean(dr["DsRecebeSMS"]);
                        p.BtRecebeEmail = Convert.ToBoolean(dr["DsRecebeEmail"]);

                        lista.Add(p);
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

        public Pessoa SelecionarPessoaPeloCodigo(int codigo)
        {
            Pessoa p = null;

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Pessoas WHERE CdPessoa = @codigo";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    p = new Pessoa();
                    p.CdPessoa = codigo;
                    p.NmPessoa = dr["DsNome"].ToString();
                    p.DsEmail = dr["DsEmail"].ToString();
                    p.DsSexo = dr["DsSexo"].ToString();
                    p.DsEstadoCivil = dr["DsEstadoCivil"].ToString();
                    p.BtRecebeSMS = Convert.ToBoolean(dr["DsRecebeSMS"]);
                    p.BtRecebeEmail = Convert.ToBoolean(dr["DsRecebeEmail"]);
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

            return p;
        }
    }
}
