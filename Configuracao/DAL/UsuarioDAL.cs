using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Usuario(Nome,NomeUsuario,Email,CPF,Senha,Ativo)
                                  VALUES(@Nome,@NomeUsuario,@Email,@CPF,@Senha,@Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa de inserir um usuário. Por favor verifique sua conexão",ex);
            }
            finally
            {
                cn.Close();
            }
        
        }

        public void Atualizar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Usuario SET Nome=@Nome, NomeUsuario=@NomeUsuario, Email=@Email, CPF=@CPF,
                                    Senha=@Senha, Ativo = @Ativo WHERE Id=@id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Parameters.AddWithValue("@id", _usuario.Id);

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
                cmd.CommandText = @"DELETE FROM Usuario WHERE Id=@id";
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

        public List<Usuario> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id,Nome,NomeUsuario,Email,CPF,Senha,Ativo FROM Usuario";
                cmd.CommandType= System.Data.CommandType.Text;
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    {   usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(ler["Id"]);
                        usuario.Nome = (ler["Nome"]).ToString();
                        usuario.NomeUsuario = (ler["NomeUsuario"]).ToString();
                        usuario.Email = (ler["Email"]).ToString();
                        usuario.CPF = (ler["CPF"]).ToString();
                        usuario.Senha = (ler["Senha"]).ToString();
                        usuario.Ativo = Convert.ToBoolean(ler["Ativo"]);
                        usuarios.Add(usuario);

                    }
                }
              return usuarios;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro na tentativa de buscar os dados. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Usuario> BuscarporNome(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id,Nome,NomeUsuario,Email,CPF,Senha,Ativo FROM Usuario WHERE Nome = @nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", _nome);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(ler["Id"]);
                        usuario.Nome = (ler["Nome"]).ToString();
                        usuario.NomeUsuario = (ler["NomeUsuario"]).ToString();
                        usuario.Email = (ler["Email"]).ToString();
                        usuario.CPF = (ler["CPF"]).ToString();
                        usuario.Senha = (ler["Senha"]).ToString();
                        usuario.Ativo = Convert.ToBoolean(ler["Ativo"]);
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
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
        public List<Usuario> BuscarPorCPF(string _cpf)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,Nome,NomeUsuario,Email,CPF,Senha,
                                  Ativo FROM Usuario WHERE CPF LIKE=@CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _cpf);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(ler["Id"]);
                        usuario.Nome = (ler["Nome"]).ToString();
                        usuario.NomeUsuario = (ler["NomeUsuario"]).ToString();
                        usuario.Email = (ler["Email"]).ToString();
                        usuario.CPF = (ler["CPF"]).ToString();
                        usuario.Senha = (ler["Senha"]).ToString();
                        usuario.Ativo = Convert.ToBoolean(ler["Ativo"]);
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
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
        public List<Usuario> BuscarporNomeUsuario(string _nomeusuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,Nome,Nome_de_usuario,Email,CPF,Senha
                                   Ativo FROM Usuario WHERE Nome LIKE=@nmUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nmUsuario", _nomeusuario);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(ler["Id"]);
                        usuario.Nome = (ler["Nome"]).ToString();
                        usuario.NomeUsuario = (ler["NomeUsuario"]).ToString();
                        usuario.Email = (ler["Email"]).ToString();
                        usuario.CPF = (ler["CPF"]).ToString();
                        usuario.Senha = (ler["Senha"]).ToString();
                        usuario.Ativo = Convert.ToBoolean(ler["Ativo"]);
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
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

        public List<Usuario> BuscarporId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id,Nome,NomeUsuario,Email,CPF,Senha,Ativo FROM Usuario WHERE Id= @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", _id);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    while (ler.Read())
                    {

                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(ler["Id"]);
                        usuario.Nome = (ler["Nome"]).ToString();
                        usuario.NomeUsuario = (ler["NomeUsuario"]).ToString();
                        usuario.Email = (ler["Email"]).ToString();
                        usuario.CPF = (ler["CPF"]).ToString();
                        usuario.Senha = (ler["Senha"]).ToString();
                        usuario.Ativo = Convert.ToBoolean(ler["Ativo"]);
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
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
