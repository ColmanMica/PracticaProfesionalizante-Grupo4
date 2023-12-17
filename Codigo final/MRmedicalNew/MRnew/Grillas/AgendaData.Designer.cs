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
            agendaBindingSource1 = new BindingSource(components);
            agendaBindingSource = new BindingSource(components);
            especialidadBindingSource = new BindingSource(components);
            butElimAgend = new Button();
            butModAgend = new Button();
            butAMenus = new Button();
            butMenuMed = new Button();
            butnewTurno = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pacienteColumm = new DataGridViewComboBoxColumn();
            medicoColumn = new DataGridViewComboBoxColumn();
            fechaHoraColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridAgenda
            // 
            dataGridAgenda.AutoGenerateColumns = false;
            dataGridAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAgenda.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, pacienteColumm, medicoColumn, fechaHoraColumn });
            dataGridAgenda.DataSource = agendaBindingSource1;
            dataGridAgenda.Location = new Point(48, 71);
            dataGridAgenda.Name = "dataGridAgenda";
            dataGridAgenda.RowHeadersWidth = 51;
            dataGridAgenda.RowTemplate.Height = 29;
            dataGridAgenda.Size = new Size(558, 292);
            dataGridAgenda.TabIndex = 0;
            dataGridAgenda.CellContentClick += dataGridAgenda_CellContentClick;
            dataGridAgenda.CellParsing += dataGridAgenda_CellParsing;
            // 
            // agendaBindingSource1
            // 
            agendaBindingSource1.DataSource = typeof(Back.Agenda);
            // 
            // butElimAgend
            // 
            butElimAgend.Location = new Point(635, 274);
            butElimAgend.Name = "butElimAgend";
            butElimAgend.Size = new Size(123, 58);
            butElimAgend.TabIndex = 1;
            butElimAgend.Text = "Eliminar Agenda";
            butElimAgend.UseVisualStyleBackColor = true;
            butElimAgend.Click += butElimAgend_Click;
            // 
            // butModAgend
            // 
            butModAgend.Location = new Point(635, 179);
            butModAgend.Name = "butModAgend";
            butModAgend.Size = new Size(113, 63);
            butModAgend.TabIndex = 2;
            butModAgend.Text = "Modificar Agenda";
            butModAgend.UseVisualStyleBackColor = true;
            butModAgend.Click += butModAgend_Click;
            // 
            // butAMenus
            // 
            butAMenus.Location = new Point(12, 0);
            butAMenus.Name = "butAMenus";
            butAMenus.Size = new Size(116, 58);
            butAMenus.TabIndex = 3;
            butAMenus.Text = "Volver al Menu Secretaria";
            butAMenus.UseVisualStyleBackColor = true;
            butAMenus.Click += button1_Click;
            // 
            // butMenuMed
            // 
            butMenuMed.Location = new Point(135, 0);
            butMenuMed.Name = "butMenuMed";
            butMenuMed.Size = new Size(123, 58);
            butMenuMed.TabIndex = 4;
            butMenuMed.Text = "Volver al Menu Medico";
            butMenuMed.UseVisualStyleBackColor = true;
            butMenuMed.Click += butMenuMed_Click;
            // 
            // butnewTurno
            // 
            butnewTurno.Location = new Point(697, 6);
            butnewTurno.Name = "butnewTurno";
            butnewTurno.Size = new Size(102, 46);
            butnewTurno.TabIndex = 5;
            butnewTurno.Text = "Nuevo Turno";
            butnewTurno.UseVisualStyleBackColor = true;
            butnewTurno.Click += butnewTurno_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewTextBoxColumn1.Frozen = true;
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // pacienteColumm
            // 
            pacienteColumm.DataPropertyName = "paciente";
            pacienteColumm.HeaderText = "paciente";
            pacienteColumm.MinimumWidth = 6;
            pacienteColumm.Name = "pacienteColumm";
            pacienteColumm.Resizable = DataGridViewTriState.True;
            pacienteColumm.SortMode = DataGridViewColumnSortMode.Automatic;
            pacienteColumm.Width = 125;
            // 
            // medicoColumn
            // 
            medicoColumn.DataPropertyName = "medicoAgenda";
            medicoColumn.HeaderText = "medicoAgenda";
            medicoColumn.MinimumWidth = 6;
            medicoColumn.Name = "medicoColumn";
            medicoColumn.Resizable = DataGridViewTriState.True;
            medicoColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            medicoColumn.Width = 125;
            // 
            // fechaHoraColumn
            // 
            fechaHoraColumn.DataPropertyName = "fechaHora";
            fechaHoraColumn.HeaderText = "fechaHora";
            fechaHoraColumn.MinimumWidth = 6;
            fechaHoraColumn.Name = "fechaHoraColumn";
            fechaHoraColumn.Resizable = DataGridViewTriState.True;
            fechaHoraColumn.Width = 125;
            // 
            // AgendaData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 450);
            Controls.Add(butnewTurno);
            Controls.Add(butMenuMed);
            Controls.Add(butAMenus);
            Controls.Add(butModAgend);
            Controls.Add(butElimAgend);
            Controls.Add(dataGridAgenda);
            Name = "AgendaData";
            Text = "AgendaData";
            Load += AgendaData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridAgenda;
        private BindingSource agendaBindingSource;
        private BindingSource especialidadBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Button butElimAgend;
        private Button butModAgend;
        private BindingSource agendaBindingSource1;
        private Button butAMenus;
        private Button butMenuMed;
        private Button butnewTurno;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn pacienteColumm;
        private DataGridViewComboBoxColumn medicoColumn;
        private DataGridViewTextBoxColumn fechaHoraColumn;
    }
}