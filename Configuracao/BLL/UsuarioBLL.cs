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
            ValidarPermissao(2);
            ValidarDados(_usuario);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario)
        {
            ValidarPermissao(3);
            ValidarDados(_usuario);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Atualizar(_usuario);

        }
        public void Excluir(int _id)
        {
            ValidarPermissao(4);
            new UsuarioDAL().Deletar(_id);
        }

        public List<Usuario> BuscarPorTodos()
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarTodos();
        }
        public List<Usuario>BuscarPorNome(string _nome)
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarporNome(_nome);
        }
        public List<Usuario>BuscarPorID(int _id)
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarporId(_id);
        }
        public List<Usuario>BuscarPorCPF(string _Cpf)
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarPorCPF(_Cpf);
        }
        public List<Usuario> BuscarPorNMUsuario(string _nmusuario)
        {
            ValidarPermissao(1);
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
        public void ValidarPermissao(int _idPermissao)
        {
            if (!new UsuarioDAL().ValidarPermissao(Constante.IdUsuarioLogado, _idPermissao))
                throw new Exception("Você não tem permissão de realizar esta operação. Procure o administrador do sistema");
        }
    }
}
