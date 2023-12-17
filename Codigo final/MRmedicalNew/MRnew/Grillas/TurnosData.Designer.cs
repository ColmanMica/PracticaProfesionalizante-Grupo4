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
            pacienteColumn = new DataGridViewTextBoxColumn();
            fechaHoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            medicoColumn = new DataGridViewComboBoxColumn();
            pacienteTurnoDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            turnoBindingSource = new BindingSource(components);
            butModTurno = new Button();
            butElimMed = new Button();
            buttAtras = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTurno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridTurno
            // 
            dataGridTurno.AutoGenerateColumns = false;
            dataGridTurno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTurno.Columns.AddRange(new DataGridViewColumn[] { pacienteColumn, fechaHoraDataGridViewTextBoxColumn, medicoColumn, pacienteTurnoDataGridViewTextBoxColumn });
            dataGridTurno.DataSource = turnoBindingSource;
            dataGridTurno.Location = new Point(27, 46);
            dataGridTurno.Name = "dataGridTurno";
            dataGridTurno.RowHeadersWidth = 51;
            dataGridTurno.RowTemplate.Height = 29;
            dataGridTurno.Size = new Size(551, 324);
            dataGridTurno.TabIndex = 0;
            dataGridTurno.CellContentClick += dataGridTurno_CellContentClick;
            dataGridTurno.CellParsing += dataGridTurno_CellParsing;
            // 
            // pacienteColumn
            // 
            pacienteColumn.DataPropertyName = "id";
            pacienteColumn.HeaderText = "id";
            pacienteColumn.MinimumWidth = 6;
            pacienteColumn.Name = "pacienteColumn";
            pacienteColumn.Resizable = DataGridViewTriState.True;
            pacienteColumn.Width = 125;
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
            pacienteTurnoDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            pacienteTurnoDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            pacienteTurnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnoBindingSource
            // 
            turnoBindingSource.DataSource = typeof(Back.Turno);
            // 
            // butModTurno
            // 
            butModTurno.Location = new Point(621, 181);
            butModTurno.Name = "butModTurno";
            butModTurno.Size = new Size(94, 57);
            butModTurno.TabIndex = 1;
            butModTurno.Text = "Modificar Turno";
            butModTurno.UseVisualStyleBackColor = true;
            butModTurno.Click += butModTurno_Click;
            // 
            // butElimMed
            // 
            butElimMed.Location = new Point(621, 266);
            butElimMed.Name = "butElimMed";
            butElimMed.Size = new Size(94, 64);
            butElimMed.TabIndex = 2;
            butElimMed.Text = "Eliminar Medico";
            butElimMed.UseVisualStyleBackColor = true;
            butElimMed.Click += butElimMed_Click;
            // 
            // buttAtras
            // 
            buttAtras.Location = new Point(12, 11);
            buttAtras.Name = "buttAtras";
            buttAtras.Size = new Size(94, 29);
            buttAtras.TabIndex = 3;
            buttAtras.Text = "Atras";
            buttAtras.UseVisualStyleBackColor = true;
            buttAtras.Click += buttAtras_Click;
            // 
            // button1
            // 
            button1.Location = new Point(615, 90);
            button1.Name = "button1";
            button1.Size = new Size(100, 51);
            button1.TabIndex = 4;
            button1.Text = "NuevoTurno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TurnosData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttAtras);
            Controls.Add(butElimMed);
            Controls.Add(butModTurno);
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
        private Button butModTurno;
        private Button butElimMed;
        private Button buttAtras;
        private Button button1;
        private DataGridViewTextBoxColumn pacienteColumn;
        private DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn medicoColumn;
        private DataGridViewComboBoxColumn pacienteTurnoDataGridViewTextBoxColumn;
    }
}