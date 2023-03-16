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
        PermissaoDAL permissaoDAL = new PermissaoDAL();
        public void Inserir(Permissao _permissao)
        {
            ValidarDados(_permissao);
            permissaoDAL.Inserir(_permissao);
        }
        public void Altualizar(Permissao _permissao)
        {
            ValidarDados(_permissao);
            permissaoDAL.Atualizar(_permissao);
        }
        public void Excluir(int _id)
        {
            permissaoDAL.Deletar(_id);
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
