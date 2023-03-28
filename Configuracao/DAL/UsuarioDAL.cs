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
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
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
                        usuario.GPusuarios = new GrupoUsuarioDAL().BuscarporIdUsuario(usuario.Id);
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

        public Usuario BuscarporNome(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
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
                    if (ler.Read())
                    {
                        usuario.Id = Convert.ToInt32(ler["Id"]);
                        usuario.Nome = (ler["Nome"]).ToString();
                        usuario.NomeUsuario = (ler["NomeUsuario"]).ToString();
                        usuario.Email = (ler["Email"]).ToString();
                        usuario.CPF = (ler["CPF"]).ToString();
                        usuario.Senha = (ler["Senha"]).ToString();
                        usuario.Ativo = Convert.ToBoolean(ler["Ativo"]);
                        usuario.GPusuarios = new GrupoUsuarioDAL().BuscarporIdUsuario(usuario.Id);
                         }
                }
                return usuario;
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
        public Usuario BuscarPorCPF(string _cpf)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
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
                        usuario.GPusuarios = new GrupoUsuarioDAL().BuscarporIdUsuario(usuario.Id);
                    }
                }
                return usuario;
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
        public Usuario BuscarporNomeUsuario(string _nomeusuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
             Usuario usuario = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id,Nome,NomeUsuario,Email,CPF,Senha,
                                   Ativo FROM Usuario WHERE NomeUsuario LIKE @nmUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nmUsuario", _nomeusuario);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    if (ler.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(ler["Id"]);
                        usuario.Nome = (ler["Nome"]).ToString();
                        usuario.NomeUsuario = (ler["NomeUsuario"]).ToString();
                        usuario.Email = (ler["Email"]).ToString();
                        usuario.CPF = (ler["CPF"]).ToString();
                        usuario.Senha = (ler["Senha"]).ToString();
                        usuario.Ativo = Convert.ToBoolean(ler["Ativo"]);
                        usuario.GPusuarios = new GrupoUsuarioDAL().BuscarporIdUsuario(usuario.Id);
                    }
                }
                return usuario;
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

        public Usuario BuscarporId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
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
                        usuario.GPusuarios = new GrupoUsuarioDAL().BuscarporIdUsuario(usuario.Id);
                    }
                }
                return usuario;
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
        public bool ValidarPermissao(int _idUsuario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM PermissaoGrupoUsuario
                                INNER JOIN UsuarioGrupoUsuario 
                    ON PermissaoGrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.IdGrupoUsuario
                    WHERE UsuarioGrupoUsuario.IdUsuario = @IdUsuario 
                    AND PermissaoGrupoUsuario.IdPermissao = @IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);

                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    if (ler.Read())
                    {
                        return true;
                    }
                }
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception("Você não tem permissao", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AdicionarGrupoUsuario(int _idusuario, object _idgpUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO UsuarioGrupoUsuario(IdUsuario, IdGrupoUsuario)
                                  VALUES(@Idusuario,@Ativo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idgpUsuario);
                cmd.Parameters.AddWithValue("@IdUsuario", _idusuario);
                
                cmd.Connection = cn;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar vincular um grupo a um usuaroi no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }

        }

        public bool UsuarioPertencerAoGrupo(int _idusuario, int _idgrupousuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT 1 FROM UsuarioGrupoUsuario " +
                    "WHERE IdUsuario = @IdUsuario AND IdGrupoUsuario=@IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idusuario);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idgrupousuario);
                cn.Open();

                using (SqlDataReader ler = cmd.ExecuteReader())
                {
                    if (ler.Read())
                    {
                        return true;
                    }
                }
                return false;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar existência de grupo vinculado ao usuario no banco.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void RemoveGrupoUsuario(int _idGpUsuario,int _idUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM UsuarioGrupoUsuario 
                                    WHERE IdUsuario = @IdUsuario AND IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGpUsuario);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar remover um grupo do usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}