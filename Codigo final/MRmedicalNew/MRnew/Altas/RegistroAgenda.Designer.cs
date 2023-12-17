namespace MRnew
{
    partial class RegistroAgenda
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
            comboPac = new ComboBox();
            comboMed = new ComboBox();
            comboTurno = new ComboBox();
            butAgrAgend = new Button();
            butAtras = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 93);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 160);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Medico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 224);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Turno";
            // 
            // comboPac
            // 
            comboPac.FormattingEnabled = true;
            comboPac.Location = new Point(210, 85);
            comboPac.Name = "comboPac";
            comboPac.Size = new Size(151, 28);
            comboPac.TabIndex = 3;
            // 
            // comboMed
            // 
            comboMed.FormattingEnabled = true;
            comboMed.Location = new Point(210, 152);
            comboMed.Name = "comboMed";
            comboMed.Size = new Size(151, 28);
            comboMed.TabIndex = 4;
            // 
            // comboTurno
            // 
            comboTurno.FormattingEnabled = true;
            comboTurno.Location = new Point(210, 221);
            comboTurno.Name = "comboTurno";
            comboTurno.Size = new Size(151, 28);
            comboTurno.TabIndex = 5;
            // 
            // butAgrAgend
            // 
            butAgrAgend.Location = new Point(169, 331);
            butAgrAgend.Name = "butAgrAgend";
            butAgrAgend.Size = new Size(103, 45);
            butAgrAgend.TabIndex = 6;
            butAgrAgend.Text = "Agregar";
            butAgrAgend.UseVisualStyleBackColor = true;
            butAgrAgend.Click += butAgrAgend_Click;
            // 
            // butAtras
            // 
            butAtras.Location = new Point(1, 1);
            butAtras.Name = "butAtras";
            butAtras.Size = new Size(94, 29);
            butAtras.TabIndex = 7;
            butAtras.Text = "Atras";
            butAtras.UseVisualStyleBackColor = true;
            butAtras.Click += butAtras_Click;
            // 
            // RegistroAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 450);
            Controls.Add(butAtras);
            Controls.Add(butAgrAgend);
            Controls.Add(comboTurno);
            Controls.Add(comboMed);
            Controls.Add(comboPac);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroAgenda";
            Text = "RegistroAgenda";
            Load += RegistroAgenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboPac;
        private ComboBox comboMed;
        private ComboBox comboTurno;
        private Button butAgrAgend;
        private Button butAtras;
    }
}