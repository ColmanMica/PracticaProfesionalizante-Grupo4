namespace MRmedical
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.bajaturno = new System.Windows.Forms.Button();
            this.modturno = new System.Windows.Forms.Button();
            this.aturno = new System.Windows.Forms.Button();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textdni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboespecialidades = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textfechanacimiento = new System.Windows.Forms.TextBox();
            this.textapellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(405, 23);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(321, 228);
            this.listBox2.TabIndex = 26;
            // 
            // bajaturno
            // 
            this.bajaturno.Location = new System.Drawing.Point(619, 305);
            this.bajaturno.Name = "bajaturno";
            this.bajaturno.Size = new System.Drawing.Size(87, 50);
            this.bajaturno.TabIndex = 25;
            this.bajaturno.Text = "Eliminar";
            this.bajaturno.UseVisualStyleBackColor = true;
            this.bajaturno.Click += new System.EventHandler(this.bajaturno_Click);
            // 
            // modturno
            // 
            this.modturno.Location = new System.Drawing.Point(474, 305);
            this.modturno.Name = "modturno";
            this.modturno.Size = new System.Drawing.Size(95, 50);
            this.modturno.TabIndex = 24;
            this.modturno.Text = "Actualizar Informacion";
            this.modturno.UseVisualStyleBackColor = true;
            this.modturno.Click += new System.EventHandler(this.modturno_Click);
            // 
            // aturno
            // 
            this.aturno.Location = new System.Drawing.Point(327, 305);
            this.aturno.Name = "aturno";
            this.aturno.Size = new System.Drawing.Size(90, 50);
            this.aturno.TabIndex = 23;
            this.aturno.Text = "Agregar";
            this.aturno.UseVisualStyleBackColor = true;
            this.aturno.Click += new System.EventHandler(this.aturno_Click);
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(165, 89);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(100, 22);
            this.textnombre.TabIndex = 21;
            // 
            // textdni
            // 
            this.textdni.Location = new System.Drawing.Point(165, 45);
            this.textdni.Name = "textdni";
            this.textdni.Size = new System.Drawing.Size(100, 22);
            this.textdni.TabIndex = 20;
            this.textdni.TextChanged += new System.EventHandler(this.textdni_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Especialidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "DNI";
            // 
            // comboespecialidades
            // 
            this.comboespecialidades.FormattingEnabled = true;
            this.comboespecialidades.Location = new System.Drawing.Point(165, 249);
            this.comboespecialidades.Name = "comboespecialidades";
            this.comboespecialidades.Size = new System.Drawing.Size(121, 24);
            this.comboespecialidades.TabIndex = 28;
            this.comboespecialidades.SelectedIndexChanged += new System.EventHandler(this.comboespecialidades_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Apellido";
            // 
            // textfechanacimiento
            // 
            this.textfechanacimiento.Location = new System.Drawing.Point(165, 192);
            this.textfechanacimiento.Name = "textfechanacimiento";
            this.textfechanacimiento.Size = new System.Drawing.Size(100, 22);
            this.textfechanacimiento.TabIndex = 31;
            // 
            // textapellido
            // 
            this.textapellido.Location = new System.Drawing.Point(165, 137);
            this.textapellido.Name = "textapellido";
            this.textapellido.Size = new System.Drawing.Size(100, 22);
            this.textapellido.TabIndex = 32;
            // 
            // AltaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textapellido);
            this.Controls.Add(this.textfechanacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboespecialidades);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.bajaturno);
            this.Controls.Add(this.modturno);
            this.Controls.Add(this.aturno);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textdni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaMedico";
            this.Text = "AltaMedico";
            this.Load += new System.EventHandler(this.AltaMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button bajaturno;
        private System.Windows.Forms.Button modturno;
        private System.Windows.Forms.Button aturno;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textdni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboespecialidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textfechanacimiento;
        private System.Windows.Forms.TextBox textapellido;
    }
}