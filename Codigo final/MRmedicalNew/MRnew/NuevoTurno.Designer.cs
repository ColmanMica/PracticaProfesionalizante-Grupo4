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
            cancelarT = new Button();
            elimturno = new Button();
            labelmed = new Label();
            modturno = new Button();
            txtDate = new TextBox();
            labelfech = new Label();
            labelpac = new Label();
            aturno = new Button();
            comboMed = new ComboBox();
            comboPac = new ComboBox();
            SuspendLayout();
            // 
            // cancelarT
            // 
            cancelarT.Location = new Point(671, 409);
            cancelarT.Name = "cancelarT";
            cancelarT.Size = new Size(94, 29);
            cancelarT.TabIndex = 25;
            cancelarT.Text = "Cancelar";
            cancelarT.UseVisualStyleBackColor = true;
            cancelarT.Click += cancelarT_Click;
            // 
            // elimturno
            // 
            elimturno.Location = new Point(546, 309);
            elimturno.Name = "elimturno";
            elimturno.RightToLeft = RightToLeft.No;
            elimturno.Size = new Size(94, 42);
            elimturno.TabIndex = 24;
            elimturno.Text = "Eliminar";
            elimturno.UseVisualStyleBackColor = true;
            elimturno.Click += elimturno_Click;
            // 
            // labelmed
            // 
            labelmed.AutoSize = true;
            labelmed.Location = new Point(150, 195);
            labelmed.Name = "labelmed";
            labelmed.Size = new Size(59, 20);
            labelmed.TabIndex = 23;
            labelmed.Text = "Medico";
            // 
            // modturno
            // 
            modturno.Location = new Point(362, 309);
            modturno.Name = "modturno";
            modturno.Size = new Size(94, 46);
            modturno.TabIndex = 22;
            modturno.Text = "Modificar";
            modturno.UseVisualStyleBackColor = true;
            modturno.Click += modturno_Click;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(315, 119);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 20;
            txtDate.TextChanged += txtDate_TextChanged;
            // 
            // labelfech
            // 
            labelfech.AutoSize = true;
            labelfech.Location = new Point(150, 119);
            labelfech.Name = "labelfech";
            labelfech.Size = new Size(81, 20);
            labelfech.TabIndex = 19;
            labelfech.Text = " Dia y hora";
            // 
            // labelpac
            // 
            labelpac.AutoSize = true;
            labelpac.Location = new Point(150, 54);
            labelpac.Name = "labelpac";
            labelpac.Size = new Size(64, 20);
            labelpac.TabIndex = 18;
            labelpac.Text = "Paciente";
            labelpac.Click += label3_Click;
            // 
            // aturno
            // 
            aturno.Location = new Point(180, 309);
            aturno.Name = "aturno";
            aturno.Size = new Size(94, 50);
            aturno.TabIndex = 17;
            aturno.Text = "Nuevo";
            aturno.UseVisualStyleBackColor = true;
            aturno.Click += aturno_Click;
            // 
            // comboMed
            // 
            comboMed.FormattingEnabled = true;
            comboMed.Location = new Point(315, 195);
            comboMed.Name = "comboMed";
            comboMed.Size = new Size(151, 28);
            comboMed.TabIndex = 16;
            comboMed.SelectedIndexChanged += combomed_SelectedIndexChanged;
            // 
            // comboPac
            // 
            comboPac.FormattingEnabled = true;
            comboPac.Location = new Point(315, 46);
            comboPac.Name = "comboPac";
            comboPac.Size = new Size(151, 28);
            comboPac.TabIndex = 26;
            // 
            // NuevoTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboPac);
            Controls.Add(cancelarT);
            Controls.Add(elimturno);
            Controls.Add(labelmed);
            Controls.Add(modturno);
            Controls.Add(txtDate);
            Controls.Add(labelfech);
            Controls.Add(labelpac);
            Controls.Add(aturno);
            Controls.Add(comboMed);
            Name = "NuevoTurno";
            Text = "NuevoTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelarT;
        private Button elimturno;
        private Label labelmed;
        private Button modturno;
        private TextBox txtDate;
        private Label labelfech;
        private Label labelpac;
        private Button aturno;
        private ComboBox comboMed;
        private ComboBox comboPac;
    }
}