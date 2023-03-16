using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        GrupoUsuarioDAL GPUsuarioDAL = new GrupoUsuarioDAL();
        public void Inserir(GrupoUsuario _gpUsuario)
        {
            ValidarDados(_gpUsuario);
            GPUsuarioDAL.Inserir(_gpUsuario);
        }
        public void Altualizar(GrupoUsuario _gpUsuario)
        {
            ValidarDados(_gpUsuario);
            GPUsuarioDAL.Atualizar(_gpUsuario);
        }
        public void Excluir(int _id)
        {
            GPUsuarioDAL.Deletar(_id);
        }

        private void ValidarDados(GrupoUsuario _gpUsuario)
        {
            if (_gpUsuario.NomeGrupo.Length > 150)
            {
                throw new Exception("O nome para o grupo deve conter no maximo 150 caracters");
            }

            if (_gpUsuario.NomeGrupo.Length < 3)
            {
                throw new Exception("O nome para este grupo, não condiz com o tamanho que é permitido. Insira um nome maior que 3 caracters");
            }
        }
    }
}

