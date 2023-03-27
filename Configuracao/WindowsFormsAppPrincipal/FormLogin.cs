using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppPrincipal
{
    public partial class FormLogin : Form
    {
        bool Logou;
        public FormLogin()
        {
            InitializeComponent();
            Logou = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().Altenticar(textBoxnome.Text,textBoxsenha.Text);
                Logou = true;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
