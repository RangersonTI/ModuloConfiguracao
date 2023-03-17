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
    }
}
