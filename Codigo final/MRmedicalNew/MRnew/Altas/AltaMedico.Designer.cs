namespace MRnew
{
    partial class AltaMedico
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMatricula = new TextBox();
            txtdni = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtdirecc = new TextBox();
            butAgregar = new Button();
            butAtras = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboEspecialidades = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 41);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Matricula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 45);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 105);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 112);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 178);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 185);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 247);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 6;
            label7.Text = "Especialidad";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(211, 38);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(125, 27);
            txtMatricula.TabIndex = 7;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(553, 41);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 8;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(211, 105);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 9;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(553, 112);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 10;
            // 
            // txtdirecc
            // 
            txtdirecc.Location = new Point(553, 195);
            txtdirecc.Name = "txtdirecc";
            txtdirecc.Size = new Size(125, 27);
            txtdirecc.TabIndex = 11;
            // 
            // butAgregar
            // 
            butAgregar.Location = new Point(595, 272);
            butAgregar.Name = "butAgregar";
            butAgregar.Size = new Size(120, 49);
            butAgregar.TabIndex = 14;
            butAgregar.Text = "Agregar";
            butAgregar.UseVisualStyleBackColor = true;
            butAgregar.Click += butAgregar_Click;
            // 
            // butAtras
            // 
            butAtras.Location = new Point(12, 12);
            butAtras.Name = "butAtras";
            butAtras.Size = new Size(94, 29);
            butAtras.TabIndex = 15;
            butAtras.Text = "Atras";
            butAtras.UseVisualStyleBackColor = true;
            butAtras.Click += butAtras_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(195, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(141, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // comboEspecialidades
            // 
            comboEspecialidades.FormattingEnabled = true;
            comboEspecialidades.Location = new Point(195, 239);
            comboEspecialidades.Name = "comboEspecialidades";
            comboEspecialidades.Size = new Size(151, 28);
            comboEspecialidades.TabIndex = 17;
            // 
            // AltaMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 324);
            Controls.Add(comboEspecialidades);
            Controls.Add(dateTimePicker1);
            Controls.Add(butAtras);
            Controls.Add(butAgregar);
            Controls.Add(txtdirecc);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtdni);
            Controls.Add(txtMatricula);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaMedico";
            Text = "AltaMedico";
            Load += AltaMedico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMatricula;
        private TextBox txtdni;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtdirecc;
        private Button butAgregar;
        private Button butAtras;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboEspecialidades;
    }
}