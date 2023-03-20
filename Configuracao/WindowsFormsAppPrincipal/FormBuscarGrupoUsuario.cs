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

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            grupoUsuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorTodos();
        }

        private void buttonExcluirGpUsuario_Click(object sender, EventArgs e)
        {
            if(grupoUsuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não registros para ser excluido");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este intem?",
                "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id_grupo;
            new UsuarioBLL().Excluir(id);
            MessageBox.Show("Registro excluído com sucesso");
        }
    }
}
