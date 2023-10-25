namespace MRnew
{
    partial class AMBMedico
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
            dataGridMedico = new DataGridView();
            matriculaMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especColumn = new DataGridViewComboBoxColumn();
            medicoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridMedico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridMedico
            // 
            dataGridMedico.AllowUserToOrderColumns = true;
            dataGridMedico.AutoGenerateColumns = false;
            dataGridMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMedico.Columns.AddRange(new DataGridViewColumn[] { matriculaMedicoDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, especColumn });
            dataGridMedico.DataSource = medicoBindingSource;
            dataGridMedico.Location = new Point(12, 21);
            dataGridMedico.Name = "dataGridMedico";
            dataGridMedico.RowHeadersWidth = 51;
            dataGridMedico.RowTemplate.Height = 29;
            dataGridMedico.Size = new Size(936, 198);
            dataGridMedico.TabIndex = 0;
            dataGridMedico.CellContentClick += dataGridMedico_CellContentClick;
            dataGridMedico.CellParsing += dataGridMedico_CellParsing;
            // 
            // matriculaMedicoDataGridViewTextBoxColumn
            // 
            matriculaMedicoDataGridViewTextBoxColumn.DataPropertyName = "matriculaMedico";
            matriculaMedicoDataGridViewTextBoxColumn.HeaderText = "matriculaMedico";
            matriculaMedicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            matriculaMedicoDataGridViewTextBoxColumn.Name = "matriculaMedicoDataGridViewTextBoxColumn";
            matriculaMedicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            dniDataGridViewTextBoxColumn.HeaderText = "dni";
            dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            dniDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // especColumn
            // 
            especColumn.DataPropertyName = "especialidad";
            especColumn.HeaderText = "especialidad";
            especColumn.MinimumWidth = 6;
            especColumn.Name = "especColumn";
            especColumn.Resizable = DataGridViewTriState.True;
            especColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            especColumn.Width = 125;
            // 
            // medicoBindingSource
            // 
            medicoBindingSource.DataSource = typeof(Back.Medico);
            // 
            // AMBMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 450);
            Controls.Add(dataGridMedico);
            Name = "AMBMedico";
            Text = "AMBMedico";
            Load += AMBMedico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMedico).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridMedico;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource medicoBindingSource;
        private DataGridViewTextBoxColumn matriculaMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn especColumn;
    }
}