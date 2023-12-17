namespace MedicalRespaldo
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
            butAtras = new Button();
            butAgregar = new Button();
            txtdirecc = new TextBox();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            txtdni = new TextBox();
            txtMatricula = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboEspecialidades = new ComboBox();
            Pickerfechanac = new DateTimePicker();
            SuspendLayout();
            // 
            // butAtras
            // 
            butAtras.BackColor = Color.Silver;
            butAtras.Location = new Point(2, 2);
            butAtras.Name = "butAtras";
            butAtras.Size = new Size(94, 29);
            butAtras.TabIndex = 47;
            butAtras.Text = "Atras";
            butAtras.UseVisualStyleBackColor = false;
            butAtras.Click += butAtras_Click;
            // 
            // butAgregar
            // 
            butAgregar.BackColor = Color.Silver;
            butAgregar.Location = new Point(584, 375);
            butAgregar.Name = "butAgregar";
            butAgregar.Size = new Size(120, 49);
            butAgregar.TabIndex = 46;
            butAgregar.Text = "Agregar";
            butAgregar.UseVisualStyleBackColor = false;
            butAgregar.Click += butAgregar_Click;
            // 
            // txtdirecc
            // 
            txtdirecc.Location = new Point(607, 238);
            txtdirecc.Name = "txtdirecc";
            txtdirecc.Size = new Size(125, 27);
            txtdirecc.TabIndex = 44;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(607, 172);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 43;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(262, 169);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(145, 27);
            txtnombre.TabIndex = 42;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(607, 105);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 41;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(262, 105);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(145, 27);
            txtMatricula.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 241);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 39;
            label7.Text = "Especialidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(477, 238);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 38;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 314);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 37;
            label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 172);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 36;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 169);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 35;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 105);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 34;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 105);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 33;
            label1.Text = "Matricula";
            // 
            // comboEspecialidades
            // 
            comboEspecialidades.FormattingEnabled = true;
            comboEspecialidades.Location = new Point(262, 241);
            comboEspecialidades.Name = "comboEspecialidades";
            comboEspecialidades.Size = new Size(145, 28);
            comboEspecialidades.TabIndex = 45;
            comboEspecialidades.SelectedIndexChanged += comboEspecialidades_SelectedIndexChanged;
            // 
            // Pickerfechanac
            // 
            Pickerfechanac.Format = DateTimePickerFormat.Custom;
            Pickerfechanac.Location = new Point(262, 314);
            Pickerfechanac.Name = "Pickerfechanac";
            Pickerfechanac.Size = new Size(145, 27);
            Pickerfechanac.TabIndex = 48;
            Pickerfechanac.ValueChanged += Pickerfechanac_ValueChanged;
            // 
            // AltaMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(Pickerfechanac);
            Controls.Add(butAtras);
            Controls.Add(butAgregar);
            Controls.Add(comboEspecialidades);
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
        private Button butAtras;
        private Button butAgregar;
        private TextBox txtdirecc;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private TextBox txtdni;
        private TextBox txtMatricula;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboEspecialidades;
        private DateTimePicker Pickerfechanac;
    }
}