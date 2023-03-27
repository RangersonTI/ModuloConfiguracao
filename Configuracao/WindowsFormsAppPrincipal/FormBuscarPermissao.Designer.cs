namespace WindowsFormsAppPrincipal
{
    partial class FormBuscarPermissao
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
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.PermissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluirpermisao = new System.Windows.Forms.Button();
            this.buttonAdicionarpermissao = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonExcluirpermigP = new System.Windows.Forms.Button();
            this.buttonAdicionarpermigP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.permissaoDataGridView.DataSource = this.PermissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(12, 143);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersWidth = 47;
            this.permissaoDataGridView.Size = new System.Drawing.Size(499, 301);
            this.permissaoDataGridView.TabIndex = 1;
            // 
            // PermissaoBindingSource
            // 
            this.PermissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_permi";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Permissão";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricão";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "grupos";
            this.gruposBindingSource.DataSource = this.PermissaoBindingSource;
            // 
            // gruposDataGridView
            // 
            this.gruposDataGridView.AllowUserToAddRows = false;
            this.gruposDataGridView.AllowUserToDeleteRows = false;
            this.gruposDataGridView.AllowUserToOrderColumns = true;
            this.gruposDataGridView.AutoGenerateColumns = false;
            this.gruposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gruposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gruposDataGridView.DataSource = this.gruposBindingSource;
            this.gruposDataGridView.Location = new System.Drawing.Point(517, 143);
            this.gruposDataGridView.Name = "gruposDataGridView";
            this.gruposDataGridView.ReadOnly = true;
            this.gruposDataGridView.RowHeadersWidth = 47;
            this.gruposDataGridView.Size = new System.Drawing.Size(353, 301);
            this.gruposDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_grupo";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID do Grupo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome do grupo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 27);
            this.textBox1.TabIndex = 3;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(109, 86);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 35);
            this.buttonAlterar.TabIndex = 12;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluirpermisao
            // 
            this.buttonExcluirpermisao.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirpermisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExcluirpermisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirpermisao.Location = new System.Drawing.Point(206, 87);
            this.buttonExcluirpermisao.Name = "buttonExcluirpermisao";
            this.buttonExcluirpermisao.Size = new System.Drawing.Size(94, 35);
            this.buttonExcluirpermisao.TabIndex = 11;
            this.buttonExcluirpermisao.Text = "Excluir";
            this.buttonExcluirpermisao.UseVisualStyleBackColor = false;
            this.buttonExcluirpermisao.Click += new System.EventHandler(this.buttonExcluirpermisao_Click);
            // 
            // buttonAdicionarpermissao
            // 
            this.buttonAdicionarpermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarpermissao.Location = new System.Drawing.Point(303, 86);
            this.buttonAdicionarpermissao.Name = "buttonAdicionarpermissao";
            this.buttonAdicionarpermissao.Size = new System.Drawing.Size(94, 35);
            this.buttonAdicionarpermissao.TabIndex = 10;
            this.buttonAdicionarpermissao.Text = "Adicionar";
            this.buttonAdicionarpermissao.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(12, 87);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 35);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonExcluirpermigP
            // 
            this.buttonExcluirpermigP.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExcluirpermigP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonExcluirpermigP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirpermigP.Location = new System.Drawing.Point(669, 88);
            this.buttonExcluirpermigP.Name = "buttonExcluirpermigP";
            this.buttonExcluirpermigP.Size = new System.Drawing.Size(94, 35);
            this.buttonExcluirpermigP.TabIndex = 14;
            this.buttonExcluirpermigP.Text = "Excluir";
            this.buttonExcluirpermigP.UseVisualStyleBackColor = false;
            // 
            // buttonAdicionarpermigP
            // 
            this.buttonAdicionarpermigP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarpermigP.Location = new System.Drawing.Point(766, 87);
            this.buttonAdicionarpermigP.Name = "buttonAdicionarpermigP";
            this.buttonAdicionarpermigP.Size = new System.Drawing.Size(94, 35);
            this.buttonAdicionarpermigP.TabIndex = 13;
            this.buttonAdicionarpermigP.Text = "Adicionar";
            this.buttonAdicionarpermigP.UseVisualStyleBackColor = true;
            // 
            // FormBuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 456);
            this.Controls.Add(this.buttonExcluirpermigP);
            this.Controls.Add(this.buttonAdicionarpermigP);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonExcluirpermisao);
            this.Controls.Add(this.buttonAdicionarpermissao);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gruposDataGridView);
            this.Controls.Add(this.permissaoDataGridView);
            this.Name = "FormBuscarPermissao";
            this.Text = "ForBuscarPermissao";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource PermissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private System.Windows.Forms.DataGridView gruposDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluirpermisao;
        private System.Windows.Forms.Button buttonAdicionarpermissao;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonExcluirpermigP;
        private System.Windows.Forms.Button buttonAdicionarpermigP;
    }
}