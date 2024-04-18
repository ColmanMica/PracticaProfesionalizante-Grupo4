namespace MedicalRespaldo
{
    partial class DataGridAgenda_
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
            idColumn = new DataGridViewTextBoxColumn();
            pacienteColumn = new DataGridViewComboBoxColumn();
            fechaHoraColumn = new DataGridViewComboBoxColumn();
            medicoAgendaColumn = new DataGridViewComboBoxColumn();
            agendaBindingSource = new BindingSource(components);
            buttonNewTurno = new Button();
            menuStrip1 = new MenuStrip();
            menuSecretariaToolStripMenuItem = new ToolStripMenuItem();
            menuMedicoToolStripMenuItem = new ToolStripMenuItem();
            butModicar = new Button();
            butEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridAgenda
            // 
            dataGridAgenda.AutoGenerateColumns = false;
            dataGridAgenda.BackgroundColor = Color.Lavender;
            dataGridAgenda.BorderStyle = BorderStyle.None;
            dataGridAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAgenda.Columns.AddRange(new DataGridViewColumn[] { idColumn, pacienteColumn, fechaHoraColumn, medicoAgendaColumn });
            dataGridAgenda.DataSource = agendaBindingSource;
            dataGridAgenda.GridColor = Color.Lavender;
            dataGridAgenda.Location = new Point(66, 79);
            dataGridAgenda.Name = "dataGridAgenda";
            dataGridAgenda.RowHeadersWidth = 51;
            dataGridAgenda.RowTemplate.Height = 29;
            dataGridAgenda.Size = new Size(554, 298);
            dataGridAgenda.TabIndex = 0;
            dataGridAgenda.CellContentClick += dataGridAgenda_CellContentClick;
            dataGridAgenda.CellParsing += dataGridAgenda_CellParsing;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "id";
            idColumn.HeaderText = "id";
            idColumn.MinimumWidth = 6;
            idColumn.Name = "idColumn";
            idColumn.Width = 125;
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
            // medicoAgendaColumn
            // 
            medicoAgendaColumn.DataPropertyName = "medicoAgenda";
            medicoAgendaColumn.HeaderText = "medicoAgenda";
            medicoAgendaColumn.MinimumWidth = 6;
            medicoAgendaColumn.Name = "medicoAgendaColumn";
            medicoAgendaColumn.Resizable = DataGridViewTriState.True;
            medicoAgendaColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            medicoAgendaColumn.Width = 125;
            // 
            // agendaBindingSource
            // 
            agendaBindingSource.DataSource = typeof(BackRespaldo.Agenda);
            // 
            // buttonNewTurno
            // 
            buttonNewTurno.BackColor = Color.LightGray;
            buttonNewTurno.Location = new Point(680, 31);
            buttonNewTurno.Name = "buttonNewTurno";
            buttonNewTurno.Size = new Size(93, 66);
            buttonNewTurno.TabIndex = 1;
            buttonNewTurno.Text = "Nuevo Turno";
            buttonNewTurno.UseVisualStyleBackColor = false;
            buttonNewTurno.Click += buttonVolver_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSecretariaToolStripMenuItem, menuMedicoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuSecretariaToolStripMenuItem
            // 
            menuSecretariaToolStripMenuItem.BackColor = Color.LightGray;
            menuSecretariaToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            menuSecretariaToolStripMenuItem.Name = "menuSecretariaToolStripMenuItem";
            menuSecretariaToolStripMenuItem.Size = new Size(126, 24);
            menuSecretariaToolStripMenuItem.Text = "MenuSecretaria";
            menuSecretariaToolStripMenuItem.Click += menuSecretariaToolStripMenuItem_Click;
            // 
            // menuMedicoToolStripMenuItem
            // 
            menuMedicoToolStripMenuItem.BackColor = Color.LightGray;
            menuMedicoToolStripMenuItem.Name = "menuMedicoToolStripMenuItem";
            menuMedicoToolStripMenuItem.Size = new Size(110, 24);
            menuMedicoToolStripMenuItem.Text = "MenuMedico";
            menuMedicoToolStripMenuItem.Click += menuMedicoToolStripMenuItem_Click;
            // 
            // butModicar
            // 
            butModicar.BackColor = Color.LightGray;
            butModicar.Location = new Point(680, 135);
            butModicar.Name = "butModicar";
            butModicar.Size = new Size(93, 65);
            butModicar.TabIndex = 3;
            butModicar.Text = "Modificar";
            butModicar.UseVisualStyleBackColor = false;
            butModicar.Click += butModicar_Click;
            // 
            // butEliminar
            // 
            butEliminar.BackColor = Color.LightGray;
            butEliminar.Location = new Point(680, 243);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(93, 60);
            butEliminar.TabIndex = 4;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = false;
            butEliminar.Click += button2_Click;
            // 
            // DataGridAgenda_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(butEliminar);
            Controls.Add(butModicar);
            Controls.Add(buttonNewTurno);
            Controls.Add(dataGridAgenda);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DataGridAgenda_";
            Text = "DataGridAgenda_";
            Load += DataGridAgenda__Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)agendaBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridAgenda;
        private BindingSource agendaBindingSource;
        private Button buttonNewTurno;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuSecretariaToolStripMenuItem;
        private ToolStripMenuItem menuMedicoToolStripMenuItem;
        private Button butModicar;
        private Button butEliminar;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewComboBoxColumn pacienteColumn;
        private DataGridViewComboBoxColumn fechaHoraColumn;
        private DataGridViewComboBoxColumn medicoAgendaColumn;
    }
}