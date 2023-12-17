namespace MRnew
{
    partial class UsuariosData
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
            components = new System.ComponentModel.Container();
            dataGridUsuarios = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contrasenia = new DataGridViewTextBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            butElimUser = new Button();
            butModUsuario = new Button();
            butAtrasU = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.AutoGenerateColumns = false;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, contrasenia });
            dataGridUsuarios.DataSource = usuarioBindingSource;
            dataGridUsuarios.Location = new Point(43, 54);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.RowHeadersWidth = 51;
            dataGridUsuarios.RowTemplate.Height = 29;
            dataGridUsuarios.Size = new Size(554, 340);
            dataGridUsuarios.TabIndex = 0;
            dataGridUsuarios.CellContentClick += dataGridUsuarios_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            correoDataGridViewTextBoxColumn.HeaderText = "correo";
            correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // contrasenia
            // 
            contrasenia.DataPropertyName = "contrasenia";
            contrasenia.HeaderText = "contrasenia";
            contrasenia.MinimumWidth = 6;
            contrasenia.Name = "contrasenia";
            contrasenia.Width = 125;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Back.Usuario);
            // 
            // butElimUser
            // 
            butElimUser.Location = new Point(641, 212);
            butElimUser.Name = "butElimUser";
            butElimUser.Size = new Size(101, 64);
            butElimUser.TabIndex = 19;
            butElimUser.Text = "ELiminar";
            butElimUser.UseVisualStyleBackColor = true;
            butElimUser.Click += button1_Click;
            // 
            // butModUsuario
            // 
            butModUsuario.Location = new Point(641, 84);
            butModUsuario.Name = "butModUsuario";
            butModUsuario.Size = new Size(101, 64);
            butModUsuario.TabIndex = 20;
            butModUsuario.Text = "Modificar";
            butModUsuario.UseVisualStyleBackColor = true;
            butModUsuario.Click += butModUsuario_Click;
            // 
            // butAtrasU
            // 
            butAtrasU.Location = new Point(1, 3);
            butAtrasU.Name = "butAtrasU";
            butAtrasU.Size = new Size(94, 29);
            butAtrasU.TabIndex = 21;
            butAtrasU.Text = "Atras";
            butAtrasU.UseVisualStyleBackColor = true;
            butAtrasU.Click += butAtrasU_Click;
            // 
            // UsuariosData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butAtrasU);
            Controls.Add(butModUsuario);
            Controls.Add(butElimUser);
            Controls.Add(dataGridUsuarios);
            Name = "UsuariosData";
            Text = "UsuariosData";
            Load += UsuariosData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridUsuarios;
        private BindingSource usuarioBindingSource;
        private Button butElimUser;
        private Button butModUsuario;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contrasenia;
        private Button butAtrasU;
    }
}