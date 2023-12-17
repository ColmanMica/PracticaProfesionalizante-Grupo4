namespace MedicalRespaldo
{
    partial class DataGridMedico
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
            butAgrMed = new Button();
            butatrasms = new Button();
            butElimMed = new Button();
            butModMed = new Button();
            butatras = new Button();
            medicoBindingSource = new BindingSource(components);
            DataGridView1 = new DataGridView();
            medicoBindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matriculaMedicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especialidadColumn = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // butAgrMed
            // 
            butAgrMed.BackColor = Color.Silver;
            butAgrMed.BackgroundImage = Properties.Resources.nuevo;
            butAgrMed.BackgroundImageLayout = ImageLayout.Zoom;
            butAgrMed.FlatStyle = FlatStyle.Popup;
            butAgrMed.ForeColor = SystemColors.ControlText;
            butAgrMed.Location = new Point(1124, 28);
            butAgrMed.Name = "butAgrMed";
            butAgrMed.Size = new Size(87, 62);
            butAgrMed.TabIndex = 9;
            butAgrMed.UseVisualStyleBackColor = false;
            butAgrMed.Click += butAgrMed_Click;
            // 
            // butatrasms
            // 
            butatrasms.Location = new Point(-132, 52);
            butatrasms.Name = "butatrasms";
            butatrasms.Size = new Size(94, 29);
            butatrasms.TabIndex = 8;
            butatrasms.Text = "Atras";
            butatrasms.UseVisualStyleBackColor = true;
            // 
            // butElimMed
            // 
            butElimMed.BackgroundImage = Properties.Resources.Elim;
            butElimMed.BackgroundImageLayout = ImageLayout.Zoom;
            butElimMed.Cursor = Cursors.IBeam;
            butElimMed.ForeColor = SystemColors.ControlText;
            butElimMed.Location = new Point(1124, 214);
            butElimMed.Name = "butElimMed";
            butElimMed.Size = new Size(73, 60);
            butElimMed.TabIndex = 7;
            butElimMed.UseVisualStyleBackColor = true;
            butElimMed.Click += butElimMed_Click;
            // 
            // butModMed
            // 
            butModMed.BackgroundImage = Properties.Resources.edit;
            butModMed.BackgroundImageLayout = ImageLayout.Zoom;
            butModMed.Cursor = Cursors.IBeam;
            butModMed.ForeColor = Color.DarkSlateGray;
            butModMed.Location = new Point(1124, 120);
            butModMed.Name = "butModMed";
            butModMed.Size = new Size(87, 58);
            butModMed.TabIndex = 6;
            butModMed.UseVisualStyleBackColor = true;
            butModMed.Click += butModMed_Click;
            // 
            // butatras
            // 
            butatras.BackColor = Color.Silver;
            butatras.FlatStyle = FlatStyle.Popup;
            butatras.ForeColor = Color.Black;
            butatras.Location = new Point(2, 2);
            butatras.Name = "butatras";
            butatras.Size = new Size(94, 29);
            butatras.TabIndex = 10;
            butatras.Text = "Atras";
            butatras.UseVisualStyleBackColor = false;
            butatras.Click += button1_Click;
            // 
            // medicoBindingSource
            // 
            medicoBindingSource.DataSource = typeof(BackRespaldo.Medico);
            // 
            // DataGridView1
            // 
            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.BackgroundColor = Color.Lavender;
            DataGridView1.BorderStyle = BorderStyle.None;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, matriculaMedicoDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn, especialidadColumn });
            DataGridView1.DataSource = medicoBindingSource1;
            DataGridView1.Location = new Point(26, 63);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 29;
            DataGridView1.Size = new Size(1052, 306);
            DataGridView1.TabIndex = 11;
            DataGridView1.CellContentClick += DataGridView1_CellContentClick;
            DataGridView1.CellParsing += DataGridView1_CellParsing;
            // 
            // medicoBindingSource1
            // 
            medicoBindingSource1.DataSource = typeof(BackRespaldo.Medico);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // matriculaMedicoDataGridViewTextBoxColumn
            // 
            matriculaMedicoDataGridViewTextBoxColumn.DataPropertyName = "matriculaMedico";
            matriculaMedicoDataGridViewTextBoxColumn.HeaderText = "matriculaMedico";
            matriculaMedicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            matriculaMedicoDataGridViewTextBoxColumn.Name = "matriculaMedicoDataGridViewTextBoxColumn";
            matriculaMedicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "dni";
            dniDataGridViewTextBoxColumn.HeaderText = "dni";
            dniDataGridViewTextBoxColumn.MinimumWidth = 6;
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            dniDataGridViewTextBoxColumn.Width = 125;
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
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "fechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "fechaNacimiento";
            fechaNacimientoDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            fechaNacimientoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // especialidadColumn
            // 
            especialidadColumn.DataPropertyName = "especialidad";
            especialidadColumn.HeaderText = "especialidad";
            especialidadColumn.MinimumWidth = 6;
            especialidadColumn.Name = "especialidadColumn";
            especialidadColumn.Resizable = DataGridViewTriState.True;
            especialidadColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            especialidadColumn.Width = 125;
            // 
            // DataGridMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1311, 472);
            Controls.Add(DataGridView1);
            Controls.Add(butatras);
            Controls.Add(butAgrMed);
            Controls.Add(butatrasms);
            Controls.Add(butElimMed);
            Controls.Add(butModMed);
            ForeColor = SystemColors.ControlLightLight;
            Name = "DataGridMedico";
            Text = "DataGridMedico";
            Load += DataGridMedico_Load;
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicoBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button butAgrMed;
        private Button butatrasms;
        private Button butElimMed;
        private Button butModMed;
        private Button butatras;
        private BindingSource medicoBindingSource;
        private DataGridView DataGridView1;
        private BindingSource medicoBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matriculaMedicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn especialidadColumn;
    }
}