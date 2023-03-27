namespace WindowsFormsAppPrincipal
{
    partial class FormCadastroGrupoUsuario
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
            System.Windows.Forms.Label nomeGrupoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroGrupoUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvarGpUsu = new System.Windows.Forms.Button();
            this.buttonCancelarGpUsu = new System.Windows.Forms.Button();
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeGrupoLabel.Location = new System.Drawing.Point(48, 176);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(169, 25);
            nomeGrupoLabel.TabIndex = 2;
            nomeGrupoLabel.Text = "Nome do Grupo:";
            nomeGrupoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.18182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Grupos de usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvarGpUsu
            // 
            this.buttonSalvarGpUsu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSalvarGpUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvarGpUsu.Location = new System.Drawing.Point(482, 314);
            this.buttonSalvarGpUsu.Name = "buttonSalvarGpUsu";
            this.buttonSalvarGpUsu.Size = new System.Drawing.Size(96, 38);
            this.buttonSalvarGpUsu.TabIndex = 17;
            this.buttonSalvarGpUsu.Text = "Salvar";
            this.buttonSalvarGpUsu.UseVisualStyleBackColor = false;
            this.buttonSalvarGpUsu.Click += new System.EventHandler(this.buttonSalvarGpUsu_Click);
            // 
            // buttonCancelarGpUsu
            // 
            this.buttonCancelarGpUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelarGpUsu.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarGpUsu.Location = new System.Drawing.Point(380, 314);
            this.buttonCancelarGpUsu.Name = "buttonCancelarGpUsu";
            this.buttonCancelarGpUsu.Size = new System.Drawing.Size(96, 38);
            this.buttonCancelarGpUsu.TabIndex = 16;
            this.buttonCancelarGpUsu.Text = "Cancelar";
            this.buttonCancelarGpUsu.UseVisualStyleBackColor = false;
            this.buttonCancelarGpUsu.Click += new System.EventHandler(this.buttonCancelarGpUsu_Click);
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(223, 176);
            this.nomeGrupoTextBox.Multiline = true;
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(260, 28);
            this.nomeGrupoTextBox.TabIndex = 19;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // FormCadastroGrupoUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(590, 364);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Controls.Add(this.buttonSalvarGpUsu);
            this.Controls.Add(this.buttonCancelarGpUsu);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormCadastroGrupoUsuario";
            this.Text = "Cadastro de Grupo de Usuario";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCadastroGrupoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvarGpUsu;
        private System.Windows.Forms.Button buttonCancelarGpUsu;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
    }
}