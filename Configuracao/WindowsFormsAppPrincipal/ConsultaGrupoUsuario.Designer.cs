namespace WindowsFormsAppPrincipal
{
    partial class ConsultaGrupoUsuario
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
            this.gPusuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPusuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBuscargrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnomegrupo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gPusuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPusuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gPusuariosDataGridView
            // 
            this.gPusuariosDataGridView.AllowUserToAddRows = false;
            this.gPusuariosDataGridView.AllowUserToDeleteRows = false;
            this.gPusuariosDataGridView.AutoGenerateColumns = false;
            this.gPusuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPusuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.gPusuariosDataGridView.DataSource = this.gPusuariosBindingSource;
            this.gPusuariosDataGridView.Location = new System.Drawing.Point(12, 148);
            this.gPusuariosDataGridView.Name = "gPusuariosDataGridView";
            this.gPusuariosDataGridView.ReadOnly = true;
            this.gPusuariosDataGridView.RowHeadersWidth = 47;
            this.gPusuariosDataGridView.Size = new System.Drawing.Size(640, 290);
            this.gPusuariosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Grupos de usuários";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 20;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // gPusuariosBindingSource
            // 
            this.gPusuariosBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(673, 400);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(115, 38);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Selecionar";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(673, 346);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(115, 38);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBuscargrupo
            // 
            this.buttonBuscargrupo.Location = new System.Drawing.Point(673, 96);
            this.buttonBuscargrupo.Name = "buttonBuscargrupo";
            this.buttonBuscargrupo.Size = new System.Drawing.Size(115, 38);
            this.buttonBuscargrupo.TabIndex = 4;
            this.buttonBuscargrupo.Text = "Buscar";
            this.buttonBuscargrupo.UseVisualStyleBackColor = true;
            this.buttonBuscargrupo.Click += new System.EventHandler(this.buttonBuscargrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(444, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consulta de grupo de Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Informe o nome do grupo:";
            // 
            // textBoxnomegrupo
            // 
            this.textBoxnomegrupo.Location = new System.Drawing.Point(12, 104);
            this.textBoxnomegrupo.Multiline = true;
            this.textBoxnomegrupo.Name = "textBoxnomegrupo";
            this.textBoxnomegrupo.Size = new System.Drawing.Size(567, 30);
            this.textBoxnomegrupo.TabIndex = 7;
            // 
            // ConsultaGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxnomegrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscargrupo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.gPusuariosDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaGrupoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaGrupoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.gPusuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPusuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gPusuariosBindingSource;
        private System.Windows.Forms.DataGridView gPusuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscargrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnomegrupo;
    }
}