namespace MedicalRespaldo
{
    partial class AltaSecretaria
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
            butguardarsecret = new Button();
            butatras = new Button();
            txtdni = new TextBox();
            txtndirecc = new TextBox();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            txtnumlegajo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PickerFechaNac = new DateTimePicker();
            SuspendLayout();
            // 
            // butguardarsecret
            // 
            butguardarsecret.BackColor = Color.Silver;
            butguardarsecret.Location = new Point(584, 366);
            butguardarsecret.Name = "butguardarsecret";
            butguardarsecret.Size = new Size(117, 49);
            butguardarsecret.TabIndex = 28;
            butguardarsecret.Text = "Agregar";
            butguardarsecret.UseVisualStyleBackColor = false;
            butguardarsecret.Click += butguardarsecret_Click;
            // 
            // butatras
            // 
            butatras.BackColor = Color.Silver;
            butatras.Location = new Point(2, 2);
            butatras.Name = "butatras";
            butatras.Size = new Size(94, 29);
            butatras.TabIndex = 27;
            butatras.Text = "Atras";
            butatras.UseVisualStyleBackColor = false;
            butatras.Click += butatras_Click;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(598, 107);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 26;
            // 
            // txtndirecc
            // 
            txtndirecc.Location = new Point(598, 236);
            txtndirecc.Name = "txtndirecc";
            txtndirecc.Size = new Size(125, 27);
            txtndirecc.TabIndex = 25;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(598, 172);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 24;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(231, 172);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 23;
            // 
            // txtnumlegajo
            // 
            txtnumlegajo.Location = new Point(231, 100);
            txtnumlegajo.Name = "txtnumlegajo";
            txtnumlegajo.Size = new Size(125, 27);
            txtnumlegajo.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 236);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 21;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 175);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 20;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 239);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 19;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 175);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 18;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 114);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 17;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 107);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 16;
            label1.Text = "Numero de Legajo";
            // 
            // PickerFechaNac
            // 
            PickerFechaNac.Format = DateTimePickerFormat.Custom;
            PickerFechaNac.Location = new Point(231, 232);
            PickerFechaNac.Name = "PickerFechaNac";
            PickerFechaNac.Size = new Size(125, 27);
            PickerFechaNac.TabIndex = 29;
            // 
            // AltaSecretaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(PickerFechaNac);
            Controls.Add(butguardarsecret);
            Controls.Add(butatras);
            Controls.Add(txtdni);
            Controls.Add(txtndirecc);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtnumlegajo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaSecretaria";
            Text = "AltaSecretaria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button butguardarsecret;
        private Button butatras;
        private TextBox txtdni;
        private TextBox txtndirecc;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private TextBox txtnumlegajo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker PickerFechaNac;
    }
}