namespace MedicalRespaldo
{
    partial class DataGridUsuario
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
            butAtrasU = new Button();
            butModUsuario = new Button();
            butElimUser = new Button();
            dataGridUsuarios = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contraseniaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // butAtrasU
            // 
            butAtrasU.BackColor = Color.Silver;
            butAtrasU.BackgroundImageLayout = ImageLayout.Center;
            butAtrasU.FlatStyle = FlatStyle.Popup;
            butAtrasU.Location = new Point(2, 3);
            butAtrasU.Name = "butAtrasU";
            butAtrasU.Size = new Size(94, 29);
            butAtrasU.TabIndex = 25;
            butAtrasU.Text = "Atras";
            butAtrasU.UseVisualStyleBackColor = false;
            butAtrasU.Click += butAtrasU_Click;
            // 
            // butModUsuario
            // 
            butModUsuario.BackgroundImage = Properties.Resources.edit;
            butModUsuario.BackgroundImageLayout = ImageLayout.Zoom;
            butModUsuario.Location = new Point(703, 52);
            butModUsuario.Name = "butModUsuario";
            butModUsuario.Size = new Size(57, 62);
            butModUsuario.TabIndex = 24;
            butModUsuario.UseVisualStyleBackColor = true;
            butModUsuario.Click += butModUsuario_Click;
            // 
            // butElimUser
            // 
            butElimUser.BackgroundImage = Properties.Resources.Elim;
            butElimUser.BackgroundImageLayout = ImageLayout.Zoom;
            butElimUser.Location = new Point(703, 145);
            butElimUser.Name = "butElimUser";
            butElimUser.Size = new Size(57, 64);
            butElimUser.TabIndex = 23;
            butElimUser.UseVisualStyleBackColor = true;
            butElimUser.Click += butElimUser_Click;
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.AutoGenerateColumns = false;
            dataGridUsuarios.BackgroundColor = Color.PaleGoldenrod;
            dataGridUsuarios.BorderStyle = BorderStyle.None;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, contraseniaDataGridViewTextBoxColumn });
            dataGridUsuarios.DataSource = usuarioBindingSource;
            dataGridUsuarios.Location = new Point(61, 52);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.RowHeadersWidth = 51;
            dataGridUsuarios.RowTemplate.Height = 29;
            dataGridUsuarios.Size = new Size(554, 340);
            dataGridUsuarios.TabIndex = 22;
            dataGridUsuarios.CellContentClick += dataGridUsuarios_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // contraseniaDataGridViewTextBoxColumn
            // 
            contraseniaDataGridViewTextBoxColumn.DataPropertyName = "contrasenia";
            contraseniaDataGridViewTextBoxColumn.HeaderText = "contrasenia";
            contraseniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            contraseniaDataGridViewTextBoxColumn.Name = "contraseniaDataGridViewTextBoxColumn";
            contraseniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(BackRespaldo.Usuario);
            // 
            // DataGridUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(914, 450);
            Controls.Add(butAtrasU);
            Controls.Add(butModUsuario);
            Controls.Add(butElimUser);
            Controls.Add(dataGridUsuarios);
            Name = "DataGridUsuario";
            Text = "DataGridUsuario";
            Load += DataGridUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button butAtrasU;
        private Button butModUsuario;
        private Button butElimUser;
        private DataGridView dataGridUsuarios;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contraseniaDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
    }
}