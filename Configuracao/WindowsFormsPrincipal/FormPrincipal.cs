using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            usuario.Nome = "Jumento";
            usuario.NomeUsuario = "Labigo";
            usuario.Ativo = true;
            usuario.CPF = "518,364,298-64";
            usuario.Email = "labiju@gmail.com";
            usuario.Senha = "HPDeLL";
            new UsuarioBLL().Inserir(usuario);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario form = new FormBuscarUsuario())
            {
                form.ShowDialog();
            }
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
