namespace MedicalRespaldo
{
    partial class DataGridEspecialidad
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
            butAtras = new Button();
            dataGridEspecialidades = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especialidadBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridEspecialidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // butAtras
            // 
            butAtras.BackColor = Color.LightGray;
            butAtras.Location = new Point(3, 3);
            butAtras.Name = "butAtras";
            butAtras.Size = new Size(94, 29);
            butAtras.TabIndex = 5;
            butAtras.Text = "Atrás";
            butAtras.UseVisualStyleBackColor = false;
            butAtras.Click += butAtras_Click;
            // 
            // dataGridEspecialidades
            // 
            dataGridEspecialidades.AutoGenerateColumns = false;
            dataGridEspecialidades.BackgroundColor = Color.Lavender;
            dataGridEspecialidades.BorderStyle = BorderStyle.None;
            dataGridEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEspecialidades.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn });
            dataGridEspecialidades.DataSource = especialidadBindingSource;
            dataGridEspecialidades.Location = new Point(178, 26);
            dataGridEspecialidades.Name = "dataGridEspecialidades";
            dataGridEspecialidades.RowHeadersWidth = 51;
            dataGridEspecialidades.RowTemplate.Height = 29;
            dataGridEspecialidades.Size = new Size(301, 360);
            dataGridEspecialidades.TabIndex = 4;
            dataGridEspecialidades.CellContentClick += dataGridEspecialidades_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // especialidadBindingSource
            // 
            especialidadBindingSource.DataSource = typeof(BackRespaldo.Especialidad);
            // 
            // DataGridEspecialidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(686, 450);
            Controls.Add(butAtras);
            Controls.Add(dataGridEspecialidades);
            Name = "DataGridEspecialidad";
            Text = "DataGridEspecialidad";
            Load += DataGridEspecialidad_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEspecialidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button butAtras;
        private DataGridView dataGridEspecialidades;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private BindingSource especialidadBindingSource;
    }
}