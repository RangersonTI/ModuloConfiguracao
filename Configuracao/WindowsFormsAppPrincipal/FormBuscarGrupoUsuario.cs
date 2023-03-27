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
        public int Id;
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (grupoUsuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Selecione uma opção para alterar.");
                return;
            }
            else
            {
                int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id_grupo;
                using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
        }
    }
}
