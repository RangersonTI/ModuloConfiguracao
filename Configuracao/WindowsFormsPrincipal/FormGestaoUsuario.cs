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

namespace WindowsFormsPrincipal
{
    public partial class FormGestaoUsuario : Form
    {
        public FormGestaoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorTodos();
        }

        private void FormGestaoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
