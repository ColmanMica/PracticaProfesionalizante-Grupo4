namespace MRnew
{
    partial class ABMespecialidad
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
            dataGridEspecialidades = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            especialidadBindingSource = new BindingSource(components);
            initialCreateBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridEspecialidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridEspecialidades
            // 
            dataGridEspecialidades.AutoGenerateColumns = false;
            dataGridEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEspecialidades.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn });
            dataGridEspecialidades.DataSource = especialidadBindingSource;
            dataGridEspecialidades.Location = new Point(52, 75);
            dataGridEspecialidades.Name = "dataGridEspecialidades";
            dataGridEspecialidades.RowHeadersWidth = 51;
            dataGridEspecialidades.RowTemplate.Height = 29;
            dataGridEspecialidades.Size = new Size(458, 188);
            dataGridEspecialidades.TabIndex = 0;
            dataGridEspecialidades.CellContentClick += dataGridView1_CellContentClick;
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
            especialidadBindingSource.DataSource = typeof(Back.Especialidad);
            // 
            // initialCreateBindingSource
            // 
            initialCreateBindingSource.DataSource = typeof(Back.Migrations.InitialCreate);
            // 
            // ABMespecialidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridEspecialidades);
            Name = "ABMespecialidad";
            Text = "Form1";
            Load += ABMespecialidad_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridEspecialidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)especialidadBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialCreateBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridEspecialidades;
        private DataGridViewTextBoxColumn idEspecialidadDataGridViewTextBoxColumn;
        private BindingSource especialidadBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private BindingSource initialCreateBindingSource;
    }
}