namespace MedicalRespaldo
{
    partial class AltaPaciente
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
            butGuardar = new Button();
            butatras = new Button();
            txtdirecc = new TextBox();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            txtdni = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TimePickerFechanac = new DateTimePicker();
            combovacunas = new ComboBox();
            SuspendLayout();
            // 
            // butGuardar
            // 
            butGuardar.BackColor = Color.Silver;
            butGuardar.Location = new Point(574, 384);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(118, 54);
            butGuardar.TabIndex = 28;
            butGuardar.Text = "Guardar Paciente";
            butGuardar.UseVisualStyleBackColor = false;
            butGuardar.Click += butGuardar_Click;
            // 
            // butatras
            // 
            butatras.BackColor = Color.Silver;
            butatras.Location = new Point(3, 3);
            butatras.Name = "butatras";
            butatras.Size = new Size(94, 29);
            butatras.TabIndex = 27;
            butatras.Text = "Atras";
            butatras.UseVisualStyleBackColor = false;
            butatras.Click += butatras_Click;
            // 
            // txtdirecc
            // 
            txtdirecc.Location = new Point(199, 261);
            txtdirecc.Name = "txtdirecc";
            txtdirecc.Size = new Size(125, 27);
            txtdirecc.TabIndex = 24;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(199, 188);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 23;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(567, 123);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 22;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(199, 119);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 248);
            label6.Name = "label6";
            label6.Size = new Size(133, 40);
            label6.TabIndex = 20;
            label6.Text = "¿Tiene colocada \r\ntodas sus vacunas?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 264);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 19;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 175);
            label4.Name = "label4";
            label4.Size = new Size(86, 40);
            label4.TabIndex = 18;
            label4.Text = "Fecha de \r\nNacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 188);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 17;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 126);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 16;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 119);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 15;
            label1.Text = "DNI";
            // 
            // TimePickerFechanac
            // 
            TimePickerFechanac.Format = DateTimePickerFormat.Custom;
            TimePickerFechanac.Location = new Point(567, 186);
            TimePickerFechanac.Name = "TimePickerFechanac";
            TimePickerFechanac.Size = new Size(132, 27);
            TimePickerFechanac.TabIndex = 29;
            // 
            // combovacunas
            // 
            combovacunas.FormattingEnabled = true;
            combovacunas.Location = new Point(567, 256);
            combovacunas.Name = "combovacunas";
            combovacunas.Size = new Size(132, 28);
            combovacunas.TabIndex = 30;
            // 
            // AltaPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(combovacunas);
            Controls.Add(TimePickerFechanac);
            Controls.Add(butGuardar);
            Controls.Add(butatras);
            Controls.Add(txtdirecc);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtdni);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaPaciente";
            Text = "AltaPaciente";
            Load += AltaPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butGuardar;
        private Button butatras;
        private TextBox txtdirecc;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private TextBox txtdni;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker TimePickerFechanac;
        private ComboBox combovacunas;
    }
}