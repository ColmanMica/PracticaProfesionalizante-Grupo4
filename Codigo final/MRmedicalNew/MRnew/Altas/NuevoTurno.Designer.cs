namespace MRnew
{
    partial class NuevoTurno
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
            comboMedico = new ComboBox();
            combodatetime = new ComboBox();
            buvolver = new Button();
            butGuardarturno = new Button();
            combopaciente = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 73);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Dia y Horario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 150);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Medico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 227);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Paciente";
            // 
            // comboMedico
            // 
            comboMedico.FormattingEnabled = true;
            comboMedico.Location = new Point(262, 150);
            comboMedico.Name = "comboMedico";
            comboMedico.Size = new Size(151, 28);
            comboMedico.TabIndex = 4;
            // 
            // combodatetime
            // 
            combodatetime.FormattingEnabled = true;
            combodatetime.Location = new Point(262, 73);
            combodatetime.Name = "combodatetime";
            combodatetime.Size = new Size(151, 28);
            combodatetime.TabIndex = 6;
            // 
            // buvolver
            // 
            buvolver.Location = new Point(12, 12);
            buvolver.Name = "buvolver";
            buvolver.Size = new Size(94, 29);
            buvolver.TabIndex = 7;
            buvolver.Text = "Volver";
            buvolver.UseVisualStyleBackColor = true;
            buvolver.Click += buvolver_Click;
            // 
            // butGuardarturno
            // 
            butGuardarturno.Location = new Point(191, 359);
            butGuardarturno.Name = "butGuardarturno";
            butGuardarturno.Size = new Size(104, 44);
            butGuardarturno.TabIndex = 8;
            butGuardarturno.Text = "Guardar";
            butGuardarturno.UseVisualStyleBackColor = true;
            butGuardarturno.Click += button2_Click;
            // 
            // combopaciente
            // 
            combopaciente.FormattingEnabled = true;
            combopaciente.Location = new Point(262, 219);
            combopaciente.Name = "combopaciente";
            combopaciente.Size = new Size(151, 28);
            combopaciente.TabIndex = 9;
            // 
            // NuevoTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 450);
            Controls.Add(combopaciente);
            Controls.Add(butGuardarturno);
            Controls.Add(buvolver);
            Controls.Add(combodatetime);
            Controls.Add(comboMedico);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoTurno";
            Text = "NuevoTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboMedico;
        private ComboBox combodatetime;
        private Button buvolver;
        private Button butGuardarturno;
        private ComboBox combopaciente;
    }
}