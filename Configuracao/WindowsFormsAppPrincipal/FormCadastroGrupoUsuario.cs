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

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastroGrupoUsuario : Form
    {
        int Id;
        public FormCadastroGrupoUsuario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonCancelarGpUsu_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja cancelar a operação?",
                "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonSalvarGpUsu_Click(object sender, EventArgs e)
        {
            try
            {
                GrupoUsuarioBLL gpusuarioBLL = new GrupoUsuarioBLL();
                grupoUsuarioBindingSource.EndEdit();
                if (Id == 0)
                {
                    gpusuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                }
                else
                {
                    gpusuarioBLL.Atualizar((GrupoUsuario)grupoUsuarioBindingSource.Current);
                }
                MessageBox.Show("Registro regitrado com sucesso");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FormCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                grupoUsuarioBindingSource.AddNew();
            }
            else
            {
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarporID(Id);
            }
        }
    }
}
