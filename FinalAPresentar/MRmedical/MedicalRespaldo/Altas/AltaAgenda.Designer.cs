namespace MedicalRespaldo
{
    partial class AltaAgenda
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
            butAgrAgend = new Button();
            comboTurno = new ComboBox();
            comboMed = new ComboBox();
            comboPac = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // butAtras
            // 
            butAtras.BackColor = Color.Silver;
            butAtras.Location = new Point(3, 1);
            butAtras.Name = "butAtras";
            butAtras.Size = new Size(94, 29);
            butAtras.TabIndex = 15;
            butAtras.Text = "Atras";
            butAtras.UseVisualStyleBackColor = false;
            butAtras.Click += butAtras_Click_1;
            // 
            // butAgrAgend
            // 
            butAgrAgend.BackColor = Color.Silver;
            butAgrAgend.Location = new Point(258, 341);
            butAgrAgend.Name = "butAgrAgend";
            butAgrAgend.Size = new Size(111, 54);
            butAgrAgend.TabIndex = 14;
            butAgrAgend.Text = "Agregar";
            butAgrAgend.UseVisualStyleBackColor = false;
            butAgrAgend.Click += butAgrAgend_Click;
            // 
            // comboTurno
            // 
            comboTurno.FormattingEnabled = true;
            comboTurno.Location = new Point(234, 232);
            comboTurno.Name = "comboTurno";
            comboTurno.Size = new Size(151, 28);
            comboTurno.TabIndex = 13;
            comboTurno.SelectedIndexChanged += comboTurno_SelectedIndexChanged;
            // 
            // comboMed
            // 
            comboMed.FormattingEnabled = true;
            comboMed.Location = new Point(234, 163);
            comboMed.Name = "comboMed";
            comboMed.Size = new Size(151, 28);
            comboMed.TabIndex = 12;
            comboMed.SelectedIndexChanged += comboMed_SelectedIndexChanged;
            // 
            // comboPac
            // 
            comboPac.FormattingEnabled = true;
            comboPac.Location = new Point(234, 96);
            comboPac.Name = "comboPac";
            comboPac.Size = new Size(151, 28);
            comboPac.TabIndex = 11;
            comboPac.SelectedIndexChanged += comboPac_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 235);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 10;
            label3.Text = "Turno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 171);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 9;
            label2.Text = "Medico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 104);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Paciente";
            // 
            // AltaAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(610, 450);
            Controls.Add(butAtras);
            Controls.Add(butAgrAgend);
            Controls.Add(comboTurno);
            Controls.Add(comboMed);
            Controls.Add(comboPac);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaAgenda";
            Text = "AltaAgenda";
            Load += AltaAgenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butAtras;
        private Button butAgrAgend;
        private ComboBox comboTurno;
        private ComboBox comboMed;
        private ComboBox comboPac;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}