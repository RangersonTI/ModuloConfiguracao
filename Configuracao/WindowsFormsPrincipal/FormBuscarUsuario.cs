using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace WindowsFormsPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
            
        }

        private void FormGestaoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorTodos();
        }

        private void buttonDeletarUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show(" Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show(" Deseja excluir este resistro?",
                "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL().Excluir(id);
            usuarioBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso");
        }
    }
}
