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
    public partial class FormCadastroUsuario : Form
    {
        int Id;
        public FormCadastroUsuario(int _id=0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?",
                "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.EndEdit();
                if (Id == 0)
                {
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, textBoxConfirmaS.Text);
                }
                else
                {
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, textBoxConfirmaS.Text);
                }
                MessageBox.Show("Registro regitrado com sucesso");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                usuarioBindingSource.AddNew();
            }
            else
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorID(Id);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
