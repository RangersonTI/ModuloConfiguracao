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
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        public void Inserir(Usuario _usuario)
        {
            if(_usuario.Senha.Length <= 4)
            {
                throw new Exception("A senha deve ter mais de 4 caracters");
            }
            
            usuarioDAL.Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario)
        {
            ValidarDados(_usuario);
            usuarioDAL.Atualizar(_usuario);

        }
        private void ValidarDados(Usuario _usuario)
        {
            if(_usuario.Senha.Length <= 4)
            {
                throw new Exception("A senha deve ter mais de 4 caracteres");
            }

            if(_usuario.Nome.Length <= 3)
            {
                throw new Exception("O nome deve ter mais de 3 caracteres");
            }
        }
    }
}
