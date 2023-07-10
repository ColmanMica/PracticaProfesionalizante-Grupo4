namespace MRmedical
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPaciente = new System.Windows.Forms.TextBox();
            this.textMedico = new System.Windows.Forms.TextBox();
            this.textFechaHora = new System.Windows.Forms.TextBox();
            this.aturno = new System.Windows.Forms.Button();
            this.modturno = new System.Windows.Forms.Button();
            this.bajaturno = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia y Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medico";
            // 
            // textPaciente
            // 
            this.textPaciente.Location = new System.Drawing.Point(179, 55);
            this.textPaciente.Name = "textPaciente";
            this.textPaciente.Size = new System.Drawing.Size(100, 22);
            this.textPaciente.TabIndex = 3;
            // 
            // textMedico
            // 
            this.textMedico.Location = new System.Drawing.Point(179, 169);
            this.textMedico.Name = "textMedico";
            this.textMedico.Size = new System.Drawing.Size(100, 22);
            this.textMedico.TabIndex = 4;
            this.textMedico.TextChanged += new System.EventHandler(this.Medico_TextChanged);
            // 
            // textFechaHora
            // 
            this.textFechaHora.Location = new System.Drawing.Point(179, 112);
            this.textFechaHora.Name = "textFechaHora";
            this.textFechaHora.Size = new System.Drawing.Size(100, 22);
            this.textFechaHora.TabIndex = 5;
            // 
            // aturno
            // 
            this.aturno.Location = new System.Drawing.Point(341, 315);
            this.aturno.Name = "aturno";
            this.aturno.Size = new System.Drawing.Size(90, 50);
            this.aturno.TabIndex = 6;
            this.aturno.Text = "Nuevo";
            this.aturno.UseVisualStyleBackColor = true;
            this.aturno.Click += new System.EventHandler(this.aturno_Click);
            // 
            // modturno
            // 
            this.modturno.Location = new System.Drawing.Point(507, 315);
            this.modturno.Name = "modturno";
            this.modturno.Size = new System.Drawing.Size(95, 50);
            this.modturno.TabIndex = 7;
            this.modturno.Text = "Editar";
            this.modturno.UseVisualStyleBackColor = true;
            this.modturno.Click += new System.EventHandler(this.modturno_Click);
            // 
            // bajaturno
            // 
            this.bajaturno.Location = new System.Drawing.Point(664, 315);
            this.bajaturno.Name = "bajaturno";
            this.bajaturno.Size = new System.Drawing.Size(87, 50);
            this.bajaturno.TabIndex = 8;
            this.bajaturno.Text = "Eliminar";
            this.bajaturno.UseVisualStyleBackColor = true;
            this.bajaturno.Click += new System.EventHandler(this.bajaturno_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(419, 33);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 228);
            this.listBox1.TabIndex = 15;
            // 
            // AltaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bajaturno);
            this.Controls.Add(this.modturno);
            this.Controls.Add(this.aturno);
            this.Controls.Add(this.textFechaHora);
            this.Controls.Add(this.textMedico);
            this.Controls.Add(this.textPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaTurno";
            this.Text = "AltaTurno";
            this.Load += new System.EventHandler(this.AltaTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPaciente;
        private System.Windows.Forms.TextBox textMedico;
        private System.Windows.Forms.TextBox textFechaHora;
        private System.Windows.Forms.Button aturno;
        private System.Windows.Forms.Button modturno;
        private System.Windows.Forms.Button bajaturno;
        private System.Windows.Forms.ListBox listBox1;
    }
}