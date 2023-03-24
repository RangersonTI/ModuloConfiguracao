﻿using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorTodos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir o registro?",
                "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL().Excluir(id);
            usuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
           using(FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
           buttonBuscar_Click(null,null);
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {

        }


        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count<=0)
            {
                MessageBox.Show("Selecione uma opção para alterar.");
                return;
            }
            else
            {
                int id = ((Usuario)usuarioBindingSource.Current).Id;
                using (FormCadastroUsuario frm = new FormCadastroUsuario(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
        }

        private void buttonAdicionarGpUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConsultaGrupoUsuario frm = new ConsultaGrupoUsuario())
                {
                    frm.ShowDialog();

                    if (frm.Id != 0)
                    {
                        int Idusuario = ((Usuario)usuarioBindingSource.Current).Id;
                        new UsuarioBLL().AdicionarGrupoUsuario(Idusuario, frm.Id);
                    }
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirGpUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int idGpUsuario = ((GrupoUsuario)gruposBindingSource.Current).Id_grupo;
                int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBLL().RemoverGrupoUsuario(idGpUsuario,idUsuario);
                gruposBindingSource.RemoveCurrent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
