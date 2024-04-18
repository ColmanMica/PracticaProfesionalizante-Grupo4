namespace MedicalRespaldo
{
    partial class DataGridSecretaria
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridS = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numerolegajoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaNacimientoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            secretariaBindingSource = new BindingSource(components);
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secretariaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(1023, 257);
            button4.Name = "button4";
            button4.Size = new Size(84, 64);
            button4.TabIndex = 9;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(1023, 147);
            button3.Name = "button3";
            button3.Size = new Size(84, 61);
            button3.TabIndex = 8;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(1023, 46);
            button2.Name = "button2";
            button2.Size = new Size(84, 61);
            button2.TabIndex = 7;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(-169, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridS
            // 
            dataGridS.AutoGenerateColumns = false;
            dataGridS.BackgroundColor = Color.Lavender;
            dataGridS.BorderStyle = BorderStyle.None;
            dataGridS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridS.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, numerolegajoDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn });
            dataGridS.DataSource = secretariaBindingSource;
            dataGridS.Location = new Point(12, 34);
            dataGridS.Name = "dataGridS";
            dataGridS.RowHeadersWidth = 51;
            dataGridS.RowTemplate.Height = 29;
            dataGridS.Size = new Size(927, 359);
            dataGridS.TabIndex = 5;
            dataGridS.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // secretariaBindingSource
            // 
            secretariaBindingSource.DataSource = typeof(BackRespaldo.Secretaria);
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.Location = new Point(2, -1);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 10;
            button5.Text = "Atras";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // DataGridSecretaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1169, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridS);
            Name = "DataGridSecretaria";
            Text = "DataGridSecretaria";
            Load += DataGridSecretaria_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridS).EndInit();
            ((System.ComponentModel.ISupportInitialize)secretariaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridS;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numerolegajoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private BindingSource secretariaBindingSource;
        private Button button5;
    }
}