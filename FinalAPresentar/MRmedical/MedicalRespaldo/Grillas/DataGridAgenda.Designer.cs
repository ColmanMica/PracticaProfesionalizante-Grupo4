namespace MedicalRespaldo
{
    partial class DataGridAgenda
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
            butnewTurno = new Button();
            butModAgend = new Button();
            butElimAgend = new Button();
            dataGridView1 = new DataGridView();
            agendaBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            menuSecretariaToolStripMenuItem = new ToolStripMenuItem();
            menuMedicoToolStripMenuItem = new ToolStripMenuItem();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pacienteColumn = new DataGridViewComboBoxColumn();
            fechaHoraColumn = new DataGridViewComboBoxColumn();
            medicoColumn = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // butnewTurno
            // 
            butnewTurno.BackColor = Color.Silver;
            butnewTurno.FlatStyle = FlatStyle.Popup;
            butnewTurno.Location = new Point(686, 18);
            butnewTurno.Name = "butnewTurno";
            butnewTurno.Size = new Size(102, 46);
            butnewTurno.TabIndex = 11;
            butnewTurno.Text = "Nuevo Turno";
            butnewTurno.UseVisualStyleBackColor = false;
            butnewTurno.Click += butnewTurno_Click;
            // 
            // butModAgend
            // 
            butModAgend.BackgroundImage = Properties.Resources.edit;
            butModAgend.BackgroundImageLayout = ImageLayout.Zoom;
            butModAgend.Cursor = Cursors.IBeam;
            butModAgend.ForeColor = Color.PaleGoldenrod;
            butModAgend.Location = new Point(699, 113);
            butModAgend.Name = "butModAgend";
            butModAgend.Size = new Size(59, 49);
            butModAgend.TabIndex = 8;
            butModAgend.UseVisualStyleBackColor = true;
            butModAgend.Click += butModAgend_Click;
            // 
            // butElimAgend
            // 
            butElimAgend.BackColor = Color.PaleGoldenrod;
            butElimAgend.BackgroundImage = Properties.Resources.Elim;
            butElimAgend.BackgroundImageLayout = ImageLayout.Zoom;
            butElimAgend.Location = new Point(699, 209);
            butElimAgend.Name = "butElimAgend";
            butElimAgend.Size = new Size(59, 48);
            butElimAgend.TabIndex = 7;
            butElimAgend.UseVisualStyleBackColor = false;
            butElimAgend.Click += butElimAgend_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.PaleGoldenrod;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, pacienteColumn, fechaHoraColumn, medicoColumn });
            dataGridView1.DataSource = agendaBindingSource;
            dataGridView1.Location = new Point(48, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(553, 292);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellParsing += dataGridView1_CellParsing;
            // 
            // agendaBindingSource
            // 
            agendaBindingSource.DataSource = typeof(BackRespaldo.Agenda);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSecretariaToolStripMenuItem, menuMedicoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuSecretariaToolStripMenuItem
            // 
            menuSecretariaToolStripMenuItem.BackColor = Color.Silver;
            menuSecretariaToolStripMenuItem.Name = "menuSecretariaToolStripMenuItem";
            menuSecretariaToolStripMenuItem.Size = new Size(126, 24);
            menuSecretariaToolStripMenuItem.Text = "MenuSecretaria";
            menuSecretariaToolStripMenuItem.Click += menuSecretariaToolStripMenuItem_Click;
            // 
            // menuMedicoToolStripMenuItem
            // 
            menuMedicoToolStripMenuItem.BackColor = Color.Silver;
            menuMedicoToolStripMenuItem.Name = "menuMedicoToolStripMenuItem";
            menuMedicoToolStripMenuItem.Size = new Size(110, 24);
            menuMedicoToolStripMenuItem.Text = "MenuMedico";
            menuMedicoToolStripMenuItem.Click += menuMedicoToolStripMenuItem_Click;
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
            // pacienteColumn
            // 
            pacienteColumn.DataPropertyName = "paciente";
            pacienteColumn.HeaderText = "paciente";
            pacienteColumn.MinimumWidth = 6;
            pacienteColumn.Name = "pacienteColumn";
            pacienteColumn.Resizable = DataGridViewTriState.True;
            pacienteColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            pacienteColumn.Width = 125;
            // 
            // fechaHoraColumn
            // 
            fechaHoraColumn.DataPropertyName = "fechaHora";
            fechaHoraColumn.HeaderText = "fechaHora";
            fechaHoraColumn.MinimumWidth = 6;
            fechaHoraColumn.Name = "fechaHoraColumn";
            fechaHoraColumn.Resizable = DataGridViewTriState.True;
            fechaHoraColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            fechaHoraColumn.Width = 125;
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
            // DataGridAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(butnewTurno);
            Controls.Add(butModAgend);
            Controls.Add(butElimAgend);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DataGridAgenda";
            Text = "DataGridAgenda";
            Load += DataGridAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butnewTurno;
        private Button butModAgend;
        private Button butElimAgend;
        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn pacienteDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn fechaHoraDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn medicoAgendaDataGridViewTextBoxColumn;
        private BindingSource agendaBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuSecretariaToolStripMenuItem;
        private ToolStripMenuItem menuMedicoToolStripMenuItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn pacienteColumn;
        private DataGridViewComboBoxColumn fechaHoraColumn;
        private DataGridViewComboBoxColumn medicoColumn;
    }
}