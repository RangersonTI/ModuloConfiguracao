using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PermissaoDAL
    {
        public void Inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Permissao(Descricao)VALUE(@descricao)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@descricao", _permissao.Descricao);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa ao inserir uma descricão. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }


        public void Atualizar(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Permissao SET Descricao=@descricao WHERE Id=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _permissao.Id_permi);
                cmd.Parameters.AddWithValue("@descricao", _permissao.Descricao);
                
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa de atualizar o usuário. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Deletar(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Permissao WHERE Id=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa de excluir um usuário. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Permissao> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id,Descricao FROM Permissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                   while(ler.Read())
                   {
                        permissao = new Permissao();
                        permissao.Id_permi = Convert.ToInt32(ler["Id"]);
                        permissao.Descricao = (ler["Descricao"]).ToString();
                        permissoes.Add(permissao);
                   }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa na busca dos dados de 'Permissão'. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Permissao> BuscarporDescricao(string _descricao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao = new Permissao();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao FROM Permissao WHERE Descricao LIKE=@descricao ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@descricao", _descricao);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    {
                        permissao.Id_permi = Convert.ToInt32(ler["Id_permi"]);
                        permissao.Descricao = (ler["Descricao"]).ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa de buscar os dados. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Permissao> BuscarporId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao = new Permissao();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao FROM Permissão WHERE Id=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    { 
                        permissao.Id_permi = Convert.ToInt32(ler["Id"]);
                        permissao.Descricao = (ler["Descricao"]).ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa de buscar os dados. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        
    }
} 