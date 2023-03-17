using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _gpusuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Grupo_Usuario(NomeGurpo)VALUE(@gpnome)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@gpnome", _gpusuario.NomeGrupo);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa ao inserir um novo 'Grupo' no banco de dados. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Atualizar(GrupoUsuario _gpusuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Grupo_Usuario SET NomeGrupo=@nomegp WHERE IDGrupo=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _gpusuario.Id_grupo);
                cmd.Parameters.AddWithValue("@nomegp", _gpusuario.NomeGrupo);

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
                cmd.CommandText = @"DELETE FROM Grupo_Usuario WHERE IDGrupo=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa de excluir um 'Grupo' no banco. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<GrupoUsuario> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<GrupoUsuario> gpusuario = new List<GrupoUsuario>();
            GrupoUsuario grupousuario = new GrupoUsuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IDGrupo,NomeGrupo FROM Grupo_Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    if (ler.Read())
                    {
                        grupousuario.NomeGrupo = (ler["NomeGrupo"]).ToString();
                        grupousuario.Id_grupo = Convert.ToInt32(ler["Id_grupo"]);
                        gpusuario.Add(grupousuario);

                    }
                }
                return gpusuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa na busca dos dados de 'Grupo de Usuarios'. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<GrupoUsuario> BuscarporNome(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<GrupoUsuario> gpusuario = new List<GrupoUsuario>();
            GrupoUsuario grupousuario = new GrupoUsuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IDGrupo,NomeGrupo FROM Grupo_Usuario WHERE NomeGrupo LIKE =@nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", _nome);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    {
                        grupousuario.Id_grupo = Convert.ToInt32(ler["IDgrupo"]);
                        grupousuario.NomeGrupo = (ler["NomeGrupo"]).ToString();
                        gpusuario.Add(grupousuario);
                    }
                }
                return gpusuario;
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

        public List<GrupoUsuario> BuscarporId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<GrupoUsuario> gpusuario = new List<GrupoUsuario>();
            GrupoUsuario grupousuario = new GrupoUsuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT IDgrupo,NomeGrupo FROM Grupo_Usuario WHERE IDgrupo=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    {
                        grupousuario.Id_grupo = Convert.ToInt32(ler["IDgrupo"]);
                        grupousuario.NomeGrupo = (ler["NomeGrupo"]).ToString();
                        gpusuario.Add(grupousuario);
                    }
                }
                return gpusuario;
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