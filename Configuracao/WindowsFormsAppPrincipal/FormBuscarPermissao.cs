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
    public partial class FormBuscarPermissao : Form
    {
        public FormBuscarPermissao()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                PermissaoBindingSource.DataSource = new PermissaoBLL().BuscarTudo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExcluirpermisao_Click(object sender, EventArgs e)
        {
            if(PermissaoBindingSource.Count)
        }
    }
}
