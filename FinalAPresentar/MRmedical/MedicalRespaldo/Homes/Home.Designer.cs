namespace MedicalRespaldo
{
    partial class Home
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
            label2 = new Label();
            label1 = new Label();
            butIngresoSistem = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGoldenrod;
            label2.Font = new Font("Monotype Corsiva", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Image = Properties.Resources.MedLog;
            label2.Location = new Point(248, 33);
            label2.Name = "label2";
            label2.Size = new Size(580, 294);
            label2.TabIndex = 5;
            label2.Text = "     MR\r\nMEDICAL";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 190);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // butIngresoSistem
            // 
            butIngresoSistem.BackColor = Color.Silver;
            butIngresoSistem.ForeColor = Color.FromArgb(64, 64, 64);
            butIngresoSistem.Location = new Point(437, 359);
            butIngresoSistem.Name = "butIngresoSistem";
            butIngresoSistem.Size = new Size(196, 71);
            butIngresoSistem.TabIndex = 3;
            butIngresoSistem.Text = "Ingreso al Sistema";
            butIngresoSistem.UseVisualStyleBackColor = false;
            butIngresoSistem.Click += butIngresoSistem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1047, 476);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(butIngresoSistem);
            ForeColor = Color.FromArgb(0, 64, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button butIngresoSistem;
    }
}