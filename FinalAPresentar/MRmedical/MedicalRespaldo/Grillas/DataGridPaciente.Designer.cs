namespace MedicalRespaldo
{
    partial class DataGridPaciente
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
            button1 = new Button();
            butatrasp = new Button();
            butElimPaciente = new Button();
            butMosPaciente = new Button();
            dataGridPte = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vacunasAlDiaDataGridViewCheckBoxColumn = new DataGridViewTextBoxColumn();
            pacienteBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridPte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.nuevo;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(962, 47);
            button1.Name = "button1";
            button1.Size = new Size(73, 60);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // butatrasp
            // 
            butatrasp.BackColor = Color.Silver;
            butatrasp.BackgroundImageLayout = ImageLayout.Zoom;
            butatrasp.Location = new Point(3, 3);
            butatrasp.Name = "butatrasp";
            butatrasp.Size = new Size(94, 29);
            butatrasp.TabIndex = 8;
            butatrasp.Text = "Atras";
            butatrasp.UseVisualStyleBackColor = false;
            butatrasp.Click += butatrasp_Click;
            // 
            // butElimPaciente
            // 
            butElimPaciente.BackgroundImage = Properties.Resources.Elim;
            butElimPaciente.BackgroundImageLayout = ImageLayout.Zoom;
            butElimPaciente.Location = new Point(967, 234);
            butElimPaciente.Name = "butElimPaciente";
            butElimPaciente.Size = new Size(56, 62);
            butElimPaciente.TabIndex = 7;
            butElimPaciente.UseVisualStyleBackColor = true;
            butElimPaciente.Click += butElimPaciente_Click;
            // 
            // butMosPaciente
            // 
            butMosPaciente.BackgroundImage = Properties.Resources.edit;
            butMosPaciente.BackgroundImageLayout = ImageLayout.Zoom;
            butMosPaciente.Location = new Point(967, 142);
            butMosPaciente.Name = "butMosPaciente";
            butMosPaciente.Size = new Size(68, 58);
            butMosPaciente.TabIndex = 6;
            butMosPaciente.UseVisualStyleBackColor = true;
            butMosPaciente.Click += butMosPaciente_Click;
            // 
            // dataGridPte
            // 
            dataGridPte.AutoGenerateColumns = false;
            dataGridPte.BackgroundColor = Color.PaleGoldenrod;
            dataGridPte.BorderStyle = BorderStyle.None;
            dataGridPte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPte.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, vacunasAlDiaDataGridViewCheckBoxColumn });
            dataGridPte.DataSource = pacienteBindingSource;
            dataGridPte.Location = new Point(12, 47);
            dataGridPte.Name = "dataGridPte";
            dataGridPte.RowHeadersWidth = 51;
            dataGridPte.RowTemplate.Height = 29;
            dataGridPte.Size = new Size(929, 285);
            dataGridPte.TabIndex = 5;
            dataGridPte.CellContentClick += dataGridPte_CellContentClick;
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
            // vacunasAlDiaDataGridViewCheckBoxColumn
            // 
            vacunasAlDiaDataGridViewCheckBoxColumn.DataPropertyName = "vacunasAlDia";
            vacunasAlDiaDataGridViewCheckBoxColumn.HeaderText = "vacunasAlDia";
            vacunasAlDiaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            vacunasAlDiaDataGridViewCheckBoxColumn.Name = "vacunasAlDiaDataGridViewCheckBoxColumn";
            vacunasAlDiaDataGridViewCheckBoxColumn.Resizable = DataGridViewTriState.True;
            vacunasAlDiaDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            vacunasAlDiaDataGridViewCheckBoxColumn.Width = 125;
            // 
            // pacienteBindingSource
            // 
            pacienteBindingSource.DataSource = typeof(BackRespaldo.Paciente);
            // 
            // DataGridPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1073, 450);
            Controls.Add(button1);
            Controls.Add(butatrasp);
            Controls.Add(butElimPaciente);
            Controls.Add(butMosPaciente);
            Controls.Add(dataGridPte);
            Name = "DataGridPaciente";
            Text = "DataGridPaciente";
            Load += DataGridPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPte).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacienteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button butatrasp;
        private Button butElimPaciente;
        private Button butMosPaciente;
        private DataGridView dataGridPte;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vacunasAlDiaDataGridViewCheckBoxColumn;
        private BindingSource pacienteBindingSource;
    }
}