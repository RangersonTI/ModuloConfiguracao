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
        int Id;
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarTudo();
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            new GrupoUsuarioBLL().Excluir(id);
            MessageBox.Show("Registro excluído com sucesso");
        }

        private void buttonAdicionarGpUsuario_Click(object sender, EventArgs e)
        {
            using(FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void FormBuscarGrupoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
