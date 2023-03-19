using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            usuario.Nome = "Junior Falcão";
            usuario.NomeUsuario = "JuninhoBR";
            usuario.Senha = "LabigoDomato45";
            usuario.CPF = "524.640.328-91";
            usuario.Email = "jumentocg@gmail.com";
            usuario.Ativo = true;
        }

        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
                
            }
        }
    }
}
