namespace WindowsFormsPrincipal
{
    partial class FormBuscarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarUsuario));
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPusuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAlterarUsuario = new System.Windows.Forms.Button();
            this.buttonDeletarUsuario = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAdicionarGrupo = new System.Windows.Forms.Button();
            this.buttonGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPusuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.Location = new System.Drawing.Point(12, 272);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.RowHeadersWidth = 51;
            this.usuarioDataGridView.RowTemplate.Height = 24;
            this.usuarioDataGridView.Size = new System.Drawing.Size(1012, 400);
            this.usuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn6.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // gPusuariosDataGridView
            // 
            this.gPusuariosDataGridView.AllowUserToAddRows = false;
            this.gPusuariosDataGridView.AllowUserToDeleteRows = false;
            this.gPusuariosDataGridView.AllowUserToOrderColumns = true;
            this.gPusuariosDataGridView.AutoGenerateColumns = false;
            this.gPusuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPusuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gPusuariosDataGridView.DataSource = this.gruposBindingSource;
            this.gPusuariosDataGridView.Location = new System.Drawing.Point(1031, 272);
            this.gPusuariosDataGridView.Name = "gPusuariosDataGridView";
            this.gPusuariosDataGridView.ReadOnly = true;
            this.gPusuariosDataGridView.RowHeadersWidth = 51;
            this.gPusuariosDataGridView.RowTemplate.Height = 24;
            this.gPusuariosDataGridView.Size = new System.Drawing.Size(370, 400);
            this.gPusuariosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_grupo";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID do grupo";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nome do grupo";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 213);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 33);
            this.textBox1.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(420, 211);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(95, 38);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAlterarUsuario
            // 
            this.buttonAlterarUsuario.Location = new System.Drawing.Point(522, 211);
            this.buttonAlterarUsuario.Name = "buttonAlterarUsuario";
            this.buttonAlterarUsuario.Size = new System.Drawing.Size(95, 38);
            this.buttonAlterarUsuario.TabIndex = 4;
            this.buttonAlterarUsuario.Text = "Alterar";
            this.buttonAlterarUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonDeletarUsuario
            // 
            this.buttonDeletarUsuario.Location = new System.Drawing.Point(624, 211);
            this.buttonDeletarUsuario.Name = "buttonDeletarUsuario";
            this.buttonDeletarUsuario.Size = new System.Drawing.Size(95, 38);
            this.buttonDeletarUsuario.TabIndex = 4;
            this.buttonDeletarUsuario.Text = "Deletar";
            this.buttonDeletarUsuario.UseVisualStyleBackColor = true;
            this.buttonDeletarUsuario.Click += new System.EventHandler(this.buttonDeletarUsuario_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(726, 211);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(95, 38);
            this.buttonAdicionar.TabIndex = 4;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarGrupo
            // 
            this.buttonAdicionarGrupo.Location = new System.Drawing.Point(1166, 211);
            this.buttonAdicionarGrupo.Name = "buttonAdicionarGrupo";
            this.buttonAdicionarGrupo.Size = new System.Drawing.Size(95, 38);
            this.buttonAdicionarGrupo.TabIndex = 4;
            this.buttonAdicionarGrupo.Text = "Adicionar";
            this.buttonAdicionarGrupo.UseVisualStyleBackColor = true;
            // 
            // buttonGrupo
            // 
            this.buttonGrupo.Location = new System.Drawing.Point(1267, 211);
            this.buttonGrupo.Name = "buttonGrupo";
            this.buttonGrupo.Size = new System.Drawing.Size(95, 38);
            this.buttonGrupo.TabIndex = 4;
            this.buttonGrupo.Text = "Excluir";
            this.buttonGrupo.UseVisualStyleBackColor = true;
            // 
            // FormBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 683);
            this.Controls.Add(this.buttonGrupo);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonAdicionarGrupo);
            this.Controls.Add(this.buttonDeletarUsuario);
            this.Controls.Add(this.buttonAlterarUsuario);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gPusuariosDataGridView);
            this.Controls.Add(this.usuarioDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuscarUsuario";
            this.Text = "FormGestaoUsuario";
            this.Load += new System.EventHandler(this.FormGestaoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPusuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private System.Windows.Forms.DataGridView gPusuariosDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAlterarUsuario;
        private System.Windows.Forms.Button buttonDeletarUsuario;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAdicionarGrupo;
        private System.Windows.Forms.Button buttonGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}