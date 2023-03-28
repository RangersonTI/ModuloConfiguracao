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
using BLL;

namespace WindowsFormsAppPrincipal
{
    public partial class ConsultaGrupoUsuario : Form
    {
        public int Id;
        public ConsultaGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscargrupo_Click_1(object sender, EventArgs e)
        {
            try
            {
                gPusuariosBindingSource.DataSource = new GrupoUsuarioBLL().BuscarporNomeGrupo(textBoxnomegrupo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConsultaGrupoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (gPusuariosBindingSource.Count > 0)
                {
                    Id = ((GrupoUsuario)gPusuariosBindingSource.Current).Id_grupo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
