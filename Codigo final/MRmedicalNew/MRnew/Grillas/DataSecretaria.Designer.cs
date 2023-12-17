namespace MRnew
{
    partial class DataSecretaria
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
            dataGridSecretaria = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numerolegajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            secretariaBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSecretaria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secretariaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridSecretaria
            // 
            dataGridSecretaria.AutoGenerateColumns = false;
            dataGridSecretaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSecretaria.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, numerolegajoDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, direccionDataGridViewTextBoxColumn });
            dataGridSecretaria.DataSource = secretariaBindingSource;
            dataGridSecretaria.Location = new Point(32, 40);
            dataGridSecretaria.Name = "dataGridSecretaria";
            dataGridSecretaria.RowHeadersWidth = 51;
            dataGridSecretaria.RowTemplate.Height = 29;
            dataGridSecretaria.Size = new Size(929, 359);
            dataGridSecretaria.TabIndex = 0;
            dataGridSecretaria.CellContentClick += dataGridSecretaria_CellContentClick;
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
            // numerolegajoDataGridViewTextBoxColumn
            // 
            numerolegajoDataGridViewTextBoxColumn.DataPropertyName = "numerolegajo";
            numerolegajoDataGridViewTextBoxColumn.HeaderText = "numerolegajo";
            numerolegajoDataGridViewTextBoxColumn.MinimumWidth = 6;
            numerolegajoDataGridViewTextBoxColumn.Name = "numerolegajoDataGridViewTextBoxColumn";
            numerolegajoDataGridViewTextBoxColumn.Width = 125;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "fechaNacimiento";
            dataGridViewTextBoxColumn1.HeaderText = "fechaNacimiento";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // secretariaBindingSource
            // 
            secretariaBindingSource.DataSource = typeof(Back.Secretaria);
            // 
            // button1
            // 
            button1.Location = new Point(12, 5);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1032, 97);
            button2.Name = "button2";
            button2.Size = new Size(113, 63);
            button2.TabIndex = 2;
            button2.Text = "Agreagr";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1032, 200);
            button3.Name = "button3";
            button3.Size = new Size(118, 59);
            button3.TabIndex = 3;
            button3.Text = "Modificar datos";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1032, 298);
            button4.Name = "button4";
            button4.Size = new Size(117, 62);
            button4.TabIndex = 4;
            button4.Text = "Eliminar Secretraria";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DataSecretaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridSecretaria);
            Name = "DataSecretaria";
            Text = "DataSecretaria";
            Load += DataSecretaria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSecretaria).EndInit();
            ((System.ComponentModel.ISupportInitialize)secretariaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridSecretaria;
        private BindingSource secretariaBindingSource;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numerolegajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}