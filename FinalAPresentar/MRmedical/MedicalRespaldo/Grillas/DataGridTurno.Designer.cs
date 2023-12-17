namespace MedicalRespaldo
{
    partial class DataGridTurno
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
            buttAtras = new Button();
            butElimMed = new Button();
            butModTurno = new Button();
            dataGridT = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacienteColumn = new DataGridViewComboBoxColumn();
            medicoColumn = new DataGridViewComboBoxColumn();
            fechaHoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turnoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.nuevo;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(757, 54);
            button1.Name = "button1";
            button1.Size = new Size(65, 59);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttAtras
            // 
            buttAtras.BackColor = Color.Silver;
            buttAtras.Location = new Point(1, 1);
            buttAtras.Name = "buttAtras";
            buttAtras.Size = new Size(94, 29);
            buttAtras.TabIndex = 8;
            buttAtras.Text = "Atras";
            buttAtras.UseVisualStyleBackColor = false;
            buttAtras.Click += buttAtras_Click;
            // 
            // butElimMed
            // 
            butElimMed.BackgroundImage = Properties.Resources.Elim;
            butElimMed.BackgroundImageLayout = ImageLayout.Zoom;
            butElimMed.Location = new Point(757, 223);
            butElimMed.Name = "butElimMed";
            butElimMed.Size = new Size(65, 51);
            butElimMed.TabIndex = 7;
            butElimMed.UseVisualStyleBackColor = true;
            butElimMed.Click += butElimMed_Click;
            // 
            // butModTurno
            // 
            butModTurno.BackgroundImage = Properties.Resources.edit;
            butModTurno.BackgroundImageLayout = ImageLayout.Zoom;
            butModTurno.Location = new Point(757, 142);
            butModTurno.Name = "butModTurno";
            butModTurno.Size = new Size(65, 55);
            butModTurno.TabIndex = 6;
            butModTurno.UseVisualStyleBackColor = true;
            butModTurno.Click += butModTurno_Click;
            // 
            // dataGridT
            // 
            dataGridT.AutoGenerateColumns = false;
            dataGridT.BackgroundColor = Color.PaleGoldenrod;
            dataGridT.BorderStyle = BorderStyle.None;
            dataGridT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridT.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, pacienteColumn, medicoColumn, fechaHoraDataGridViewTextBoxColumn });
            dataGridT.DataSource = turnoBindingSource;
            dataGridT.Location = new Point(96, 54);
            dataGridT.Name = "dataGridT";
            dataGridT.RowHeadersWidth = 51;
            dataGridT.RowTemplate.Height = 29;
            dataGridT.Size = new Size(551, 324);
            dataGridT.TabIndex = 5;
            dataGridT.CellContentClick += dataGridT_CellContentClick;
            dataGridT.CellParsing += dataGridT_CellParsing;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // pacienteColumn
            // 
            pacienteColumn.DataPropertyName = "pacienteTurno";
            pacienteColumn.HeaderText = "pacienteTurno";
            pacienteColumn.MinimumWidth = 6;
            pacienteColumn.Name = "pacienteColumn";
            pacienteColumn.Resizable = DataGridViewTriState.True;
            pacienteColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            pacienteColumn.Width = 125;
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
            // fechaHoraDataGridViewTextBoxColumn
            // 
            fechaHoraDataGridViewTextBoxColumn.DataPropertyName = "fechaHora";
            fechaHoraDataGridViewTextBoxColumn.HeaderText = "fechaHora";
            fechaHoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaHoraDataGridViewTextBoxColumn.Name = "fechaHoraDataGridViewTextBoxColumn";
            fechaHoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // turnoBindingSource
            // 
            turnoBindingSource.DataSource = typeof(BackRespaldo.Turno);
            // 
            // DataGridTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(951, 450);
            Controls.Add(button1);
            Controls.Add(buttAtras);
            Controls.Add(butElimMed);
            Controls.Add(butModTurno);
            Controls.Add(dataGridT);
            Name = "DataGridTurno";
            Text = "DataGridTurno";
            Load += DataGridTurno_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridT).EndInit();
            ((System.ComponentModel.ISupportInitialize)turnoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button buttAtras;
        private Button butElimMed;
        private Button butModTurno;
        private DataGridView dataGridT;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn pacienteColumn;
        private DataGridViewComboBoxColumn medicoColumn;
        private DataGridViewTextBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private BindingSource turnoBindingSource;
    }
}