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
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            obraSocialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            historialBindingSource = new BindingSource(components);
            butModHist = new Button();
            butElimHist = new Button();
            butAtras = new Button();
            butVS = new Button();
            buthardarHist = new Button();
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
            dataGridHistorial.Location = new Point(12, 46);
            dataGridHistorial.Name = "dataGridHistorial";
            dataGridHistorial.RowHeadersWidth = 51;
            dataGridHistorial.RowTemplate.Height = 29;
            dataGridHistorial.Size = new Size(804, 325);
            dataGridHistorial.TabIndex = 0;
            dataGridHistorial.CellContentClick += dataGridHistorial_CellContentClick;
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
            fechaNacimientoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
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
            fechaHoraDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            fechaHoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // historialBindingSource
            // 
            historialBindingSource.DataSource = typeof(Back.Historial);
            // 
            // butModHist
            // 
            butModHist.Location = new Point(853, 168);
            butModHist.Name = "butModHist";
            butModHist.Size = new Size(94, 66);
            butModHist.TabIndex = 1;
            butModHist.Text = "Modificar Historial";
            butModHist.UseVisualStyleBackColor = true;
            butModHist.Click += butModHist_Click;
            // 
            // butElimHist
            // 
            butElimHist.Location = new Point(853, 260);
            butElimHist.Name = "butElimHist";
            butElimHist.Size = new Size(94, 55);
            butElimHist.TabIndex = 2;
            butElimHist.Text = "Eliminar Historial";
            butElimHist.UseVisualStyleBackColor = true;
            butElimHist.Click += butElimHist_Click;
            // 
            // butAtras
            // 
            butAtras.Location = new Point(12, 1);
            butAtras.Name = "butAtras";
            butAtras.Size = new Size(122, 29);
            butAtras.TabIndex = 3;
            butAtras.Text = "Volver Medico";
            butAtras.UseVisualStyleBackColor = true;
            butAtras.Click += butAtras_Click;
            // 
            // butVS
            // 
            butVS.Location = new Point(140, 1);
            butVS.Name = "butVS";
            butVS.Size = new Size(137, 29);
            butVS.TabIndex = 4;
            butVS.Text = "Volver Secretaria";
            butVS.UseVisualStyleBackColor = true;
            butVS.Click += butVS_Click;
            // 
            // buthardarHist
            // 
            buthardarHist.Location = new Point(853, 75);
            buthardarHist.Name = "buthardarHist";
            buthardarHist.Size = new Size(94, 54);
            buthardarHist.TabIndex = 5;
            buthardarHist.Text = "Nuevo Historial";
            buthardarHist.UseVisualStyleBackColor = true;
            buthardarHist.Click += buthardarHist_Click;
            // 
            // FiltroHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 423);
            Controls.Add(buthardarHist);
            Controls.Add(butVS);
            Controls.Add(butAtras);
            Controls.Add(butElimHist);
            Controls.Add(butModHist);
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
        private Button butModHist;
        private Button butElimHist;
        private Button butAtras;
        private Button butVS;
        private Button buthardarHist;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obraSocialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
    }
}