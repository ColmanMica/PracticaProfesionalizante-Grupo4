namespace MRnew
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtnumlegajo = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtndirecc = new TextBox();
            txtdni = new TextBox();
            butatras = new Button();
            butguardarsecret = new Button();
            combofechanac = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 74);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero de Legajo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 74);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 147);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 235);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 150);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "Apellido";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 235);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 5;
            label6.Text = "Direccion";
            label6.Click += label6_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtnumlegajo
            // 
            txtnumlegajo.Location = new Point(234, 71);
            txtnumlegajo.Name = "txtnumlegajo";
            txtnumlegajo.Size = new Size(125, 27);
            txtnumlegajo.TabIndex = 7;
            txtnumlegajo.TextChanged += txtnumlegajo_TextChanged;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(234, 147);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 8;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(532, 150);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 9;
            txtapellido.TextChanged += txtapellido_TextChanged;
            // 
            // txtndirecc
            // 
            txtndirecc.Location = new Point(532, 235);
            txtndirecc.Name = "txtndirecc";
            txtndirecc.Size = new Size(125, 27);
            txtndirecc.TabIndex = 10;
            txtndirecc.TextChanged += txtndirecc_TextChanged;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(532, 67);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 12;
            txtdni.TextChanged += txtdni_TextChanged;
            // 
            // butatras
            // 
            butatras.Location = new Point(12, 12);
            butatras.Name = "butatras";
            butatras.Size = new Size(94, 29);
            butatras.TabIndex = 13;
            butatras.Text = "Atras";
            butatras.UseVisualStyleBackColor = true;
            butatras.Click += butatras_Click;
            // 
            // butguardarsecret
            // 
            butguardarsecret.Location = new Point(513, 331);
            butguardarsecret.Name = "butguardarsecret";
            butguardarsecret.Size = new Size(122, 63);
            butguardarsecret.TabIndex = 14;
            butguardarsecret.Text = "Agregar";
            butguardarsecret.UseVisualStyleBackColor = true;
            butguardarsecret.Click += button2_Click;
            // 
            // combofechanac
            // 
            combofechanac.FormattingEnabled = true;
            combofechanac.Location = new Point(234, 235);
            combofechanac.Name = "combofechanac";
            combofechanac.Size = new Size(151, 28);
            combofechanac.TabIndex = 15;
            combofechanac.SelectedIndexChanged += combofechanac_SelectedIndexChanged;
            // 
            // AltaSecretaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 406);
            Controls.Add(combofechanac);
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
            Load += AltaSecretaria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtnumlegajo;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtndirecc;
        private TextBox txtdni;
        private Button butatras;
        private Button butguardarsecret;
        private ComboBox combofechanac;
    }
}