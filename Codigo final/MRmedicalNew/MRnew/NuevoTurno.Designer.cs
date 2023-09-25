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
            txtPac = new TextBox();
            txtDate = new TextBox();
            labelfech = new Label();
            labelpac = new Label();
            aturno = new Button();
            combomed = new ComboBox();
            SuspendLayout();
            // 
            // cancelarT
            // 
            cancelarT.Location = new Point(469, 393);
            cancelarT.Name = "cancelarT";
            cancelarT.Size = new Size(94, 29);
            cancelarT.TabIndex = 25;
            cancelarT.Text = "Cancelar";
            cancelarT.UseVisualStyleBackColor = true;
            cancelarT.Click += cancelarT_Click;
            // 
            // elimturno
            // 
            elimturno.Location = new Point(455, 259);
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
            labelmed.Location = new Point(59, 195);
            labelmed.Name = "labelmed";
            labelmed.Size = new Size(59, 20);
            labelmed.TabIndex = 23;
            labelmed.Text = "Medico";
            // 
            // modturno
            // 
            modturno.Location = new Point(455, 177);
            modturno.Name = "modturno";
            modturno.Size = new Size(94, 46);
            modturno.TabIndex = 22;
            modturno.Text = "Modificar";
            modturno.UseVisualStyleBackColor = true;
            modturno.Click += modturno_Click;
            // 
            // txtPac
            // 
            txtPac.Location = new Point(189, 47);
            txtPac.Name = "txtPac";
            txtPac.Size = new Size(125, 27);
            txtPac.TabIndex = 21;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(189, 119);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 20;
            // 
            // labelfech
            // 
            labelfech.AutoSize = true;
            labelfech.Location = new Point(54, 119);
            labelfech.Name = "labelfech";
            labelfech.Size = new Size(81, 20);
            labelfech.TabIndex = 19;
            labelfech.Text = " Dia y hora";
            // 
            // labelpac
            // 
            labelpac.AutoSize = true;
            labelpac.Location = new Point(54, 54);
            labelpac.Name = "labelpac";
            labelpac.Size = new Size(64, 20);
            labelpac.TabIndex = 18;
            labelpac.Text = "Paciente";
            labelpac.Click += label3_Click;
            // 
            // aturno
            // 
            aturno.Location = new Point(455, 89);
            aturno.Name = "aturno";
            aturno.Size = new Size(94, 50);
            aturno.TabIndex = 17;
            aturno.Text = "Nuevo";
            aturno.UseVisualStyleBackColor = true;
            aturno.Click += aturno_Click;
            // 
            // combomed
            // 
            combomed.FormattingEnabled = true;
            combomed.Location = new Point(189, 195);
            combomed.Name = "combomed";
            combomed.Size = new Size(151, 28);
            combomed.TabIndex = 16;
            // 
            // NuevoTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelarT);
            Controls.Add(elimturno);
            Controls.Add(labelmed);
            Controls.Add(modturno);
            Controls.Add(txtPac);
            Controls.Add(txtDate);
            Controls.Add(labelfech);
            Controls.Add(labelpac);
            Controls.Add(aturno);
            Controls.Add(combomed);
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
        private TextBox txtPac;
        private TextBox txtDate;
        private Label labelfech;
        private Label labelpac;
        private Button aturno;
        private ComboBox combomed;
    }
}