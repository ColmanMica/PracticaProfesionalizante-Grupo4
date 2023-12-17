namespace MedicalRespaldo
{
    partial class AltaHistorial
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
            button2 = new Button();
            buttAtras = new Button();
            txtobrasoc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            PickerCreacion = new DateTimePicker();
            comboPac = new ComboBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(579, 376);
            button2.Name = "button2";
            button2.Size = new Size(108, 54);
            button2.TabIndex = 27;
            button2.Text = "Guardar datos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttAtras
            // 
            buttAtras.BackColor = Color.Silver;
            buttAtras.Location = new Point(3, 2);
            buttAtras.Name = "buttAtras";
            buttAtras.Size = new Size(94, 29);
            buttAtras.TabIndex = 26;
            buttAtras.Text = "Atras";
            buttAtras.UseVisualStyleBackColor = false;
            buttAtras.Click += buttAtras_Click;
            // 
            // txtobrasoc
            // 
            txtobrasoc.Location = new Point(422, 175);
            txtobrasoc.Name = "txtobrasoc";
            txtobrasoc.Size = new Size(125, 27);
            txtobrasoc.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 302);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 19;
            label6.Text = "Creado el dia:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 182);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 18;
            label5.Text = "Obra Social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 81);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 14;
            label1.Text = "Paciente";
            // 
            // PickerCreacion
            // 
            PickerCreacion.Format = DateTimePickerFormat.Custom;
            PickerCreacion.Location = new Point(422, 297);
            PickerCreacion.Name = "PickerCreacion";
            PickerCreacion.Size = new Size(125, 27);
            PickerCreacion.TabIndex = 29;
            // 
            // comboPac
            // 
            comboPac.FormattingEnabled = true;
            comboPac.Location = new Point(422, 78);
            comboPac.Name = "comboPac";
            comboPac.Size = new Size(133, 28);
            comboPac.TabIndex = 30;
            comboPac.SelectedIndexChanged += comboPac_SelectedIndexChanged;
            // 
            // AltaHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(900, 450);
            Controls.Add(comboPac);
            Controls.Add(PickerCreacion);
            Controls.Add(button2);
            Controls.Add(buttAtras);
            Controls.Add(txtobrasoc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "AltaHistorial";
            Text = "AltaHistorial";
            Load += AltaHistorial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button buttAtras;
        private TextBox txtobrasoc;
        private Label label6;
        private Label label5;
        private Label label1;
        private DateTimePicker PickerCreacion;
        private ComboBox comboPac;
    }
}