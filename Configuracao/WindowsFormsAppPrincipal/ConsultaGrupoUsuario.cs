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
        
        public ConsultaGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscargrupo_Click(object sender, EventArgs e)
        {
            try
            {
                gPusuariosBindingSource.DataSource = new GrupoUsuarioBLL().BuscarporNomeGrupo(textBoxnomegrupo.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if(gPusuariosBindingSource.Count > 0)
                    int Id = ((GrupoUsuario)gPusuariosBindingSource.Current).Id_grupo;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
