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
        public void Inserir(GrupoUsuario _gpUsuario)
        {
            GrupoUsuarioDAL GPUsuarioDAL = new GrupoUsuarioDAL();
            //ValidarDados(_gpUsuario);
            GPUsuarioDAL.Inserir(_gpUsuario);
        }
        public void Altualizar(GrupoUsuario _gpUsuario)
        {
            GrupoUsuarioDAL GPUsuarioDAL = new GrupoUsuarioDAL();
            ValidarDados(_gpUsuario);
            GPUsuarioDAL.Atualizar(_gpUsuario);
        }
        public void Excluir(GrupoUsuario _gpUsuario, int _id)
        {
            GrupoUsuarioDAL GPUsuarioDAL = new GrupoUsuarioDAL();
            ValidarDados(_gpUsuario);
            GPUsuarioDAL.Deletar(_id);
        }
        public List<GrupoUsuario> BuscarTudo()
        {
            return new GrupoUsuarioDAL().BuscarTodos();
        }
        public List<GrupoUsuario>BuscarporNomeGrupo(string _nome)
        {
            return new GrupoUsuarioDAL().BuscarporNome(_nome);
        }
        public List<GrupoUsuario>BuscarporID(int _id)
        {
            return new GrupoUsuarioDAL().BuscarporId(_id);
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

