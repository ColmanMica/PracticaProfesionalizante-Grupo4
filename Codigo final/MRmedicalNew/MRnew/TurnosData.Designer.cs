namespace MRnew
{
    partial class TurnosData
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
            dataGridTurno = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaHoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            medicoColumn = new DataGridViewComboBoxColumn();
            pacienteTurnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridTurno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridTurno
            // 
            dataGridTurno.AutoGenerateColumns = false;
            dataGridTurno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTurno.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fechaHoraDataGridViewTextBoxColumn, medicoColumn, pacienteTurnoDataGridViewTextBoxColumn });
            dataGridTurno.DataSource = turnoBindingSource;
            dataGridTurno.Location = new Point(27, 46);
            dataGridTurno.Name = "dataGridTurno";
            dataGridTurno.RowHeadersWidth = 51;
            dataGridTurno.RowTemplate.Height = 29;
            dataGridTurno.Size = new Size(552, 188);
            dataGridTurno.TabIndex = 0;
            dataGridTurno.CellParsing += dataGridTurno_CellParsing;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaHoraDataGridViewTextBoxColumn
            // 
            fechaHoraDataGridViewTextBoxColumn.DataPropertyName = "fechaHora";
            fechaHoraDataGridViewTextBoxColumn.HeaderText = "fechaHora";
            fechaHoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaHoraDataGridViewTextBoxColumn.Name = "fechaHoraDataGridViewTextBoxColumn";
            fechaHoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // medicoColumn
            // 
            medicoColumn.DataPropertyName = "medicoTurno";
            medicoColumn.HeaderText = "medicoTurno";
            medicoColumn.MinimumWidth = 6;
            medicoColumn.Name = "medicoColumn";
            medicoColumn.Resizable = DataGridViewTriState.True;
            medicoColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            medicoColumn.Width = 125;
            // 
            // pacienteTurnoDataGridViewTextBoxColumn
            // 
            pacienteTurnoDataGridViewTextBoxColumn.DataPropertyName = "pacienteTurno";
            pacienteTurnoDataGridViewTextBoxColumn.HeaderText = "pacienteTurno";
            pacienteTurnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            pacienteTurnoDataGridViewTextBoxColumn.Name = "pacienteTurnoDataGridViewTextBoxColumn";
            pacienteTurnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnoBindingSource
            // 
            turnoBindingSource.DataSource = typeof(Back.Turno);
            // 
            // TurnosData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridTurno);
            Name = "TurnosData";
            Text = "TurnosData";
            Load += TurnosData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTurno).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridTurno;
        private BindingSource turnoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn medicoColumn;
        private DataGridViewTextBoxColumn pacienteTurnoDataGridViewTextBoxColumn;
    }
}