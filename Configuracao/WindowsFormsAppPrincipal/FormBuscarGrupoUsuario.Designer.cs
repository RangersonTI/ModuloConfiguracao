namespace WindowsFormsAppPrincipal
{
    partial class FormBuscarGrupoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarGrupoUsuario));
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExcluirPermissao = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluirGpUsuario = new System.Windows.Forms.Button();
            this.buttonAdicionarGpUsuario = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(12, 109);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 47;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(564, 443);
            this.grupoUsuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_grupo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID do grupo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do grupo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // permissoesBindingSource1
            // 
            this.permissoesBindingSource1.DataMember = "Permissoes";
            this.permissoesBindingSource1.DataSource = this.grupoUsuarioBindingSource;
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirPermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExcluirPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(583, 67);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(91, 31);
            this.buttonExcluirPermissao.TabIndex = 16;
            this.buttonExcluirPermissao.Text = "Excluir";
            this.buttonExcluirPermissao.UseVisualStyleBackColor = false;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(109, 66);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(91, 31);
            this.buttonAlterar.TabIndex = 15;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluirGpUsuario
            // 
            this.buttonExcluirGpUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirGpUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExcluirGpUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirGpUsuario.Location = new System.Drawing.Point(206, 67);
            this.buttonExcluirGpUsuario.Name = "buttonExcluirGpUsuario";
            this.buttonExcluirGpUsuario.Size = new System.Drawing.Size(91, 31);
            this.buttonExcluirGpUsuario.TabIndex = 14;
            this.buttonExcluirGpUsuario.Text = "Excluir";
            this.buttonExcluirGpUsuario.UseVisualStyleBackColor = false;
            this.buttonExcluirGpUsuario.Click += new System.EventHandler(this.buttonExcluirGpUsuario_Click);
            // 
            // buttonAdicionarGpUsuario
            // 
            this.buttonAdicionarGpUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarGpUsuario.Location = new System.Drawing.Point(303, 66);
            this.buttonAdicionarGpUsuario.Name = "buttonAdicionarGpUsuario";
            this.buttonAdicionarGpUsuario.Size = new System.Drawing.Size(91, 31);
            this.buttonAdicionarGpUsuario.TabIndex = 13;
            this.buttonAdicionarGpUsuario.Text = "Adicionar";
            this.buttonAdicionarGpUsuario.UseVisualStyleBackColor = true;
            this.buttonAdicionarGpUsuario.Click += new System.EventHandler(this.buttonAdicionarGpUsuario_Click);
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(680, 67);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(91, 31);
            this.buttonAdicionarPermissao.TabIndex = 12;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(12, 67);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(91, 31);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 30);
            this.textBox1.TabIndex = 17;
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource1;
            this.permissoesDataGridView.Location = new System.Drawing.Point(582, 109);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersWidth = 47;
            this.permissoesDataGridView.Size = new System.Drawing.Size(668, 443);
            this.permissoesDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_permi";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID Permissão";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // FormBuscarGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 564);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExcluirPermissao);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonExcluirGpUsuario);
            this.Controls.Add(this.buttonAdicionarGpUsuario);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarGrupoUsuario";
            this.Text = "Grupo de Usuario";
            this.Load += new System.EventHandler(this.FormBuscarGrupoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.BindingSource permissoesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluirGpUsuario;
        private System.Windows.Forms.Button buttonAdicionarGpUsuario;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}