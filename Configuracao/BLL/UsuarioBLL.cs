using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        
        public void Inserir(Usuario _usuario)
        {
            ValidarDados(_usuario);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario)
        {
            ValidarDados(_usuario);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Atualizar(_usuario);

        }
        public void Excluir(int _id)
        {
            new UsuarioDAL().Deletar(_id);
        }

        public List<Usuario> BuscarPorTodos()
        {
            return new UsuarioDAL().BuscarTodos();
        }
        public List<Usuario>BuscarPorNome(string _nome)
        {
            return new UsuarioDAL().BuscarporNome(_nome);
        }
        public List<Usuario>BuscarPorID(int _id)
        {
            return new UsuarioDAL().BuscarporId(_id);
        }
        public List<Usuario>BuscarPorCPF(string _Cpf)
        {
            return new UsuarioDAL().BuscarPorCPF(_Cpf);
        }
        public List<Usuario> BuscarPorNMUsuario(string _nmusuario)
        {
            return new UsuarioDAL().BuscarporNomeUsuario(_nmusuario);
        }

        private void ValidarDados(Usuario _usuario)
        {
            if(_usuario.Senha.Length <= 3)
            {
                throw new Exception("A senha deve ter mais de 4 caracteres");
            }

            if(_usuario.Nome.Length <= 2)
            {
                throw new Exception("O nome deve ter mais de 3 caracteres");
            }
        }
    }
}
