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
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.AutoGenerateColumns = false;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn });
            dataGridUsuarios.DataSource = usuarioBindingSource;
            dataGridUsuarios.Location = new Point(52, 28);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.RowHeadersWidth = 51;
            dataGridUsuarios.RowTemplate.Height = 29;
            dataGridUsuarios.Size = new Size(430, 206);
            dataGridUsuarios.TabIndex = 0;
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
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            correoDataGridViewTextBoxColumn.HeaderText = "correo";
            correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Back.Usuario);
            // 
            // button1
            // 
            button1.Location = new Point(518, 39);
            button1.Name = "button1";
            button1.Size = new Size(101, 64);
            button1.TabIndex = 19;
            button1.Text = "ELiminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UsuariosData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private Button button1;
    }
}