namespace MedicalRespaldo
{
    partial class DataGridHistorial
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
            buthardarHist = new Button();
            butVS = new Button();
            butAtras = new Button();
            butElimHist = new Button();
            butModHist = new Button();
            dataGridHist = new DataGridView();
            historialBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacientecolum = new DataGridViewComboBoxColumn();
            obraSocialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridHist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historialBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buthardarHist
            // 
            buthardarHist.BackColor = Color.LightGray;
            buthardarHist.BackgroundImageLayout = ImageLayout.Zoom;
            buthardarHist.Location = new Point(673, 61);
            buthardarHist.Name = "buthardarHist";
            buthardarHist.Size = new Size(95, 52);
            buthardarHist.TabIndex = 11;
            buthardarHist.Text = "Agregar";
            buthardarHist.UseVisualStyleBackColor = false;
            buthardarHist.Click += buthardarHist_Click;
            // 
            // butVS
            // 
            butVS.BackColor = Color.LightGray;
            butVS.Location = new Point(130, 2);
            butVS.Name = "butVS";
            butVS.Size = new Size(137, 29);
            butVS.TabIndex = 10;
            butVS.Text = "Volver Secretaria";
            butVS.UseVisualStyleBackColor = false;
            butVS.Click += butVS_Click;
            // 
            // butAtras
            // 
            butAtras.BackColor = Color.LightGray;
            butAtras.BackgroundImageLayout = ImageLayout.Center;
            butAtras.Location = new Point(2, 2);
            butAtras.Name = "butAtras";
            butAtras.Size = new Size(122, 29);
            butAtras.TabIndex = 9;
            butAtras.Text = "Volver Medico";
            butAtras.UseVisualStyleBackColor = false;
            butAtras.Click += butAtras_Click;
            // 
            // butElimHist
            // 
            butElimHist.BackColor = Color.LightGray;
            butElimHist.BackgroundImageLayout = ImageLayout.Zoom;
            butElimHist.ForeColor = Color.Black;
            butElimHist.Location = new Point(673, 257);
            butElimHist.Name = "butElimHist";
            butElimHist.Size = new Size(95, 55);
            butElimHist.TabIndex = 8;
            butElimHist.Text = "Eliminar";
            butElimHist.UseVisualStyleBackColor = false;
            butElimHist.Click += butElimHist_Click;
            // 
            // butModHist
            // 
            butModHist.BackColor = Color.LightGray;
            butModHist.BackgroundImageLayout = ImageLayout.Zoom;
            butModHist.Location = new Point(673, 160);
            butModHist.Name = "butModHist";
            butModHist.Size = new Size(95, 58);
            butModHist.TabIndex = 7;
            butModHist.Text = "Modificar";
            butModHist.UseVisualStyleBackColor = false;
            butModHist.Click += butModHist_Click;
            // 
            // dataGridHist
            // 
            dataGridHist.AutoGenerateColumns = false;
            dataGridHist.BackgroundColor = Color.Lavender;
            dataGridHist.BorderStyle = BorderStyle.None;
            dataGridHist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHist.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, pacientecolum, obraSocialDataGridViewTextBoxColumn, fechaHoraDataGridViewTextBoxColumn });
            dataGridHist.DataSource = historialBindingSource;
            dataGridHist.Location = new Point(44, 61);
            dataGridHist.Name = "dataGridHist";
            dataGridHist.RowHeadersWidth = 51;
            dataGridHist.RowTemplate.Height = 29;
            dataGridHist.Size = new Size(551, 325);
            dataGridHist.TabIndex = 6;
            dataGridHist.CellContentClick += dataGridHist_CellContentClick;
            dataGridHist.CellParsing += dataGridHist_CellParsing;
            dataGridHist.TabIndexChanged += dataGridHist_TabIndexChanged;
            // 
            // historialBindingSource
            // 
            historialBindingSource.DataSource = typeof(BackRespaldo.Historial);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // pacientecolum
            // 
            pacientecolum.DataPropertyName = "paciente";
            pacientecolum.HeaderText = "paciente";
            pacientecolum.MinimumWidth = 6;
            pacientecolum.Name = "pacientecolum";
            pacientecolum.Resizable = DataGridViewTriState.True;
            pacientecolum.SortMode = DataGridViewColumnSortMode.Automatic;
            pacientecolum.Width = 125;
            // 
            // obraSocialDataGridViewTextBoxColumn
            // 
            obraSocialDataGridViewTextBoxColumn.DataPropertyName = "obraSocial";
            obraSocialDataGridViewTextBoxColumn.HeaderText = "obraSocial";
            obraSocialDataGridViewTextBoxColumn.MinimumWidth = 6;
            obraSocialDataGridViewTextBoxColumn.Name = "obraSocialDataGridViewTextBoxColumn";
            obraSocialDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaHoraDataGridViewTextBoxColumn
            // 
            fechaHoraDataGridViewTextBoxColumn.DataPropertyName = "fechaHora";
            fechaHoraDataGridViewTextBoxColumn.HeaderText = "fechaHora";
            fechaHoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaHoraDataGridViewTextBoxColumn.Name = "fechaHoraDataGridViewTextBoxColumn";
            fechaHoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // DataGridHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(832, 450);
            Controls.Add(buthardarHist);
            Controls.Add(butVS);
            Controls.Add(butAtras);
            Controls.Add(butElimHist);
            Controls.Add(butModHist);
            Controls.Add(dataGridHist);
            Name = "DataGridHistorial";
            Text = "DataGridHistorial";
            Load += DataGridHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHist).EndInit();
            ((System.ComponentModel.ISupportInitialize)historialBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buthardarHist;
        private Button butVS;
        private Button butAtras;
        private Button butElimHist;
        private Button butModHist;
        private DataGridView dataGridHist;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private BindingSource historialBindingSource;
        private DataGridViewTextBoxColumn pacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn pacientecolum;
        private DataGridViewTextBoxColumn obraSocialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
    }
}