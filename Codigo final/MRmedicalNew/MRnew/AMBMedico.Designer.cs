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
            dataGridView1 = new DataGridView();
            matriculaMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especialidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            medicoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { matriculaMedicoDataGridViewTextBoxColumn, especialidadDataGridViewTextBoxColumn, usuarioMedicoDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = medicoBindingSource;
            dataGridView1.Location = new Point(2, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(786, 188);
            dataGridView1.TabIndex = 0;
            // 
            // matriculaMedicoDataGridViewTextBoxColumn
            // 
            matriculaMedicoDataGridViewTextBoxColumn.DataPropertyName = "matriculaMedico";
            matriculaMedicoDataGridViewTextBoxColumn.HeaderText = "matriculaMedico";
            matriculaMedicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            matriculaMedicoDataGridViewTextBoxColumn.Name = "matriculaMedicoDataGridViewTextBoxColumn";
            matriculaMedicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // especialidadDataGridViewTextBoxColumn
            // 
            especialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad";
            especialidadDataGridViewTextBoxColumn.HeaderText = "especialidad";
            especialidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            especialidadDataGridViewTextBoxColumn.Name = "especialidadDataGridViewTextBoxColumn";
            especialidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioMedicoDataGridViewTextBoxColumn
            // 
            usuarioMedicoDataGridViewTextBoxColumn.DataPropertyName = "usuarioMedico";
            usuarioMedicoDataGridViewTextBoxColumn.HeaderText = "usuarioMedico";
            usuarioMedicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            usuarioMedicoDataGridViewTextBoxColumn.Name = "usuarioMedicoDataGridViewTextBoxColumn";
            usuarioMedicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
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
            // medicoBindingSource
            // 
            medicoBindingSource.DataSource = typeof(Back.Medico);
            // 
            // AMBMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "AMBMedico";
            Text = "AMBMedico";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn matriculaMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private BindingSource medicoBindingSource;
    }
}