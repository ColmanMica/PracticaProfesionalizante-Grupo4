namespace MedicalRespaldo
{
    partial class AltaTurno
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
            combopaciente = new ComboBox();
            butGuardarturno = new Button();
            buvolver = new Button();
            comboMedico = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PickerTurno = new DateTimePicker();
            SuspendLayout();
            // 
            // combopaciente
            // 
            combopaciente.FormattingEnabled = true;
            combopaciente.Location = new Point(293, 219);
            combopaciente.Name = "combopaciente";
            combopaciente.Size = new Size(151, 28);
            combopaciente.TabIndex = 17;
            combopaciente.SelectedIndexChanged += combopaciente_SelectedIndexChanged;
            // 
            // butGuardarturno
            // 
            butGuardarturno.BackColor = Color.Silver;
            butGuardarturno.Location = new Point(316, 331);
            butGuardarturno.Name = "butGuardarturno";
            butGuardarturno.Size = new Size(104, 44);
            butGuardarturno.TabIndex = 16;
            butGuardarturno.Text = "Guardar";
            butGuardarturno.UseVisualStyleBackColor = false;
            butGuardarturno.Click += butGuardarturno_Click;
            // 
            // buvolver
            // 
            buvolver.BackColor = Color.Silver;
            buvolver.Location = new Point(0, 1);
            buvolver.Name = "buvolver";
            buvolver.Size = new Size(94, 29);
            buvolver.TabIndex = 15;
            buvolver.Text = "Volver";
            buvolver.UseVisualStyleBackColor = false;
            buvolver.Click += buvolver_Click;
            // 
            // comboMedico
            // 
            comboMedico.FormattingEnabled = true;
            comboMedico.Location = new Point(293, 150);
            comboMedico.Name = "comboMedico";
            comboMedico.Size = new Size(151, 28);
            comboMedico.TabIndex = 13;
            comboMedico.SelectedIndexChanged += comboMedico_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 227);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 12;
            label3.Text = "Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 150);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(59, 20);
            label2.TabIndex = 11;
            label2.Text = "Medico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 73);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 10;
            label1.Text = "Dia y Horario";
            // 
            // PickerTurno
            // 
            PickerTurno.Format = DateTimePickerFormat.Custom;
            PickerTurno.Location = new Point(293, 73);
            PickerTurno.Name = "PickerTurno";
            PickerTurno.Size = new Size(151, 27);
            PickerTurno.TabIndex = 49;
            // 
            // AltaTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(682, 450);
            Controls.Add(PickerTurno);
            Controls.Add(combopaciente);
            Controls.Add(butGuardarturno);
            Controls.Add(buvolver);
            Controls.Add(comboMedico);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaTurno";
            Text = "AltaTurno";
            Load += AltaTurno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox combopaciente;
        private Button butGuardarturno;
        private Button buvolver;
        private ComboBox comboMedico;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker PickerTurno;
    }
}