using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class PermissaoDAL
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

        }

        public void Deletar(int _id)
        {

        }

        public List<Permissao> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public List<Permissao> BuscarporDescricao(string _descricao)
        {
            throw new NotImplementedException();
        }

        public List<Permissao> BuscarporId(int _id)
        {
            throw new NotImplementedException();
        }
    }
}
