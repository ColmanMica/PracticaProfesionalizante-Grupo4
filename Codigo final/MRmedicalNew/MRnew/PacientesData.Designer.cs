namespace MRnew
{
    partial class PacientesData
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
            dataGridPaciente = new DataGridView();
            pacienteBindingSource = new BindingSource(components);
            idpacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vacunasAlDiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridPaciente
            // 
            dataGridPaciente.AutoGenerateColumns = false;
            dataGridPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPaciente.Columns.AddRange(new DataGridViewColumn[] { idpacienteDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, vacunasAlDiaDataGridViewTextBoxColumn });
            dataGridPaciente.DataSource = pacienteBindingSource;
            dataGridPaciente.Location = new Point(12, 37);
            dataGridPaciente.Name = "dataGridPaciente";
            dataGridPaciente.RowHeadersWidth = 51;
            dataGridPaciente.RowTemplate.Height = 29;
            dataGridPaciente.Size = new Size(1056, 210);
            dataGridPaciente.TabIndex = 0;
            // 
            // pacienteBindingSource
            // 
            pacienteBindingSource.DataSource = typeof(Back.Paciente);
            // 
            // idpacienteDataGridViewTextBoxColumn
            // 
            idpacienteDataGridViewTextBoxColumn.DataPropertyName = "idpaciente";
            idpacienteDataGridViewTextBoxColumn.HeaderText = "idpaciente";
            idpacienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            idpacienteDataGridViewTextBoxColumn.Name = "idpacienteDataGridViewTextBoxColumn";
            idpacienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
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
            // vacunasAlDiaDataGridViewTextBoxColumn
            // 
            vacunasAlDiaDataGridViewTextBoxColumn.DataPropertyName = "vacunasAlDia";
            vacunasAlDiaDataGridViewTextBoxColumn.HeaderText = "vacunasAlDia";
            vacunasAlDiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            vacunasAlDiaDataGridViewTextBoxColumn.Name = "vacunasAlDiaDataGridViewTextBoxColumn";
            vacunasAlDiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // PacientesData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 450);
            Controls.Add(dataGridPaciente);
            Name = "PacientesData";
            Text = "PacientesData";
            Load += PacientesData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridPaciente;
        private DataGridViewTextBoxColumn idpacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vacunasAlDiaDataGridViewTextBoxColumn;
        private BindingSource pacienteBindingSource;
    }
}