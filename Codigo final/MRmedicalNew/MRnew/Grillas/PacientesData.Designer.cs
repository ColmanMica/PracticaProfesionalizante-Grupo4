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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vacunasAlDiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacienteBindingSource = new BindingSource(components);
            butMosPaciente = new Button();
            butElimPaciente = new Button();
            butatrasp = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridPaciente
            // 
            dataGridPaciente.AutoGenerateColumns = false;
            dataGridPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPaciente.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, vacunasAlDiaDataGridViewTextBoxColumn });
            dataGridPaciente.DataSource = pacienteBindingSource;
            dataGridPaciente.Location = new Point(12, 43);
            dataGridPaciente.Name = "dataGridPaciente";
            dataGridPaciente.RowHeadersWidth = 51;
            dataGridPaciente.RowTemplate.Height = 29;
            dataGridPaciente.Size = new Size(929, 285);
            dataGridPaciente.TabIndex = 0;
            dataGridPaciente.CellContentClick += dataGridPaciente_CellContentClick;
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
            fechaNacimientoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
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
            // pacienteBindingSource
            // 
            pacienteBindingSource.DataSource = typeof(Back.Paciente);
            // 
            // butMosPaciente
            // 
            butMosPaciente.Location = new Point(962, 168);
            butMosPaciente.Name = "butMosPaciente";
            butMosPaciente.Size = new Size(94, 61);
            butMosPaciente.TabIndex = 1;
            butMosPaciente.Text = "Modificar Paciente";
            butMosPaciente.UseVisualStyleBackColor = true;
            butMosPaciente.Click += butMosPaciente_Click;
            // 
            // butElimPaciente
            // 
            butElimPaciente.Location = new Point(962, 247);
            butElimPaciente.Name = "butElimPaciente";
            butElimPaciente.Size = new Size(94, 57);
            butElimPaciente.TabIndex = 2;
            butElimPaciente.Text = "Eliminar Paciente";
            butElimPaciente.UseVisualStyleBackColor = true;
            butElimPaciente.Click += butElimPaciente_Click;
            // 
            // butatrasp
            // 
            butatrasp.Location = new Point(12, 8);
            butatrasp.Name = "butatrasp";
            butatrasp.Size = new Size(94, 29);
            butatrasp.TabIndex = 3;
            butatrasp.Text = "Atras";
            butatrasp.UseVisualStyleBackColor = true;
            butatrasp.Click += butatrasp_Click;
            // 
            // button1
            // 
            button1.Location = new Point(962, 77);
            button1.Name = "button1";
            button1.Size = new Size(94, 55);
            button1.TabIndex = 4;
            button1.Text = "Nuevo Paciente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PacientesData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 354);
            Controls.Add(button1);
            Controls.Add(butatrasp);
            Controls.Add(butElimPaciente);
            Controls.Add(butMosPaciente);
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
        private BindingSource pacienteBindingSource;
        private Button butMosPaciente;
        private Button butElimPaciente;
        private Button butatrasp;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vacunasAlDiaDataGridViewTextBoxColumn;
    }
}