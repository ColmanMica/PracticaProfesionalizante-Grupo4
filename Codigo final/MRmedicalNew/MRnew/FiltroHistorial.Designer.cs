namespace MRnew
{
    partial class FiltroHistorial
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
            dataGridHistorial = new DataGridView();
            historialBindingSource = new BindingSource(components);
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            obraSocialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridHistorial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historialBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridHistorial
            // 
            dataGridHistorial.AutoGenerateColumns = false;
            dataGridHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHistorial.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, obraSocialDataGridViewTextBoxColumn, fechaHoraDataGridViewTextBoxColumn });
            dataGridHistorial.DataSource = historialBindingSource;
            dataGridHistorial.Location = new Point(12, 31);
            dataGridHistorial.Name = "dataGridHistorial";
            dataGridHistorial.RowHeadersWidth = 51;
            dataGridHistorial.RowTemplate.Height = 29;
            dataGridHistorial.Size = new Size(805, 264);
            dataGridHistorial.TabIndex = 0;
            // 
            // historialBindingSource
            // 
            historialBindingSource.DataSource = typeof(Back.Historial);
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
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            dniDataGridViewTextBoxColumn.HeaderText = "dni";
            dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            dniDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.Width = 125;
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
            // FiltroHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 450);
            Controls.Add(dataGridHistorial);
            Name = "FiltroHistorial";
            Text = "FiltroHistorial";
            Load += FiltroHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHistorial).EndInit();
            ((System.ComponentModel.ISupportInitialize)historialBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridHistorial;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource historialBindingSource;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obraSocialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
    }
}