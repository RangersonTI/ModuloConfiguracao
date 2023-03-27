using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class PermissaoBLL
    {   
        public void Inserir(Permissao _permissao)
        {
            ValidarDados(_permissao);
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }
        public void Altualizar(Permissao _permissao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            ValidarDados(_permissao);
            permissaoDAL.Atualizar(_permissao);
        }
        public void Excluir(int _id)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Deletar(_id);
        }
        public List<Permissao> BuscarTudo()
        {
            return new PermissaoDAL().BuscarTodos();
        }
        public List<Permissao> BuscarPorDescricao(string _desc)
        {
            return new PermissaoDAL().BuscarporDescricao(_desc);
        }
        public List<Permissao> BuscarPorId(int _id)
        {
            return new PermissaoDAL().BuscarporId(_id);
        }
        private void ValidarDados(Permissao _permissao)
        {
            if (_permissao.Descricao.Length > 250)
            {
                throw new Exception("A descrição deve conter no maximo 250 caracters");
            }

            if (_permissao.Descricao.Length == 0)
            {
                throw new Exception("A descrição não pode ser nula. Insira uma descrição");
            }
        }
    }
}
