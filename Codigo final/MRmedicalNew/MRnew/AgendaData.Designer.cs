namespace MRnew
{
    partial class AgendaData
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
            dataGridAgenda = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paciente = new DataGridViewTextBoxColumn();
            fechaHora = new DataGridViewTextBoxColumn();
            medicoAgenda = new DataGridViewTextBoxColumn();
            agendaBindingSource = new BindingSource(components);
            especialidadBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridAgenda
            // 
            dataGridAgenda.AutoGenerateColumns = false;
            dataGridAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAgenda.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, paciente, fechaHora, medicoAgenda });
            dataGridAgenda.DataSource = agendaBindingSource;
            dataGridAgenda.Location = new Point(113, 112);
            dataGridAgenda.Name = "dataGridAgenda";
            dataGridAgenda.RowHeadersWidth = 51;
            dataGridAgenda.RowTemplate.Height = 29;
            dataGridAgenda.Size = new Size(592, 188);
            dataGridAgenda.TabIndex = 0;
            dataGridAgenda.CellContentClick += dataGridAgenda_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // paciente
            // 
            paciente.DataPropertyName = "paciente";
            paciente.HeaderText = "paciente";
            paciente.MinimumWidth = 6;
            paciente.Name = "paciente";
            paciente.Width = 125;
            // 
            // fechaHora
            // 
            fechaHora.DataPropertyName = "fechaHora";
            fechaHora.HeaderText = "fechaHora";
            fechaHora.MinimumWidth = 6;
            fechaHora.Name = "fechaHora";
            fechaHora.Width = 125;
            // 
            // medicoAgenda
            // 
            medicoAgenda.DataPropertyName = "medicoAgenda";
            medicoAgenda.HeaderText = "medicoAgenda";
            medicoAgenda.MinimumWidth = 6;
            medicoAgenda.Name = "medicoAgenda";
            medicoAgenda.Width = 125;
            // 
            // agendaBindingSource
            // 
            agendaBindingSource.DataSource = typeof(Back.Agenda);
            // 
            // especialidadBindingSource
            // 
            especialidadBindingSource.DataSource = typeof(Back.Especialidad);
            // 
            // AgendaData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridAgenda);
            Name = "AgendaData";
            Text = "AgendaData";
            ((System.ComponentModel.ISupportInitialize)dataGridAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridAgenda;
        private BindingSource agendaBindingSource;
        private BindingSource especialidadBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paciente;
        private DataGridViewTextBoxColumn fechaHora;
        private DataGridViewTextBoxColumn medicoAgenda;
    }
}