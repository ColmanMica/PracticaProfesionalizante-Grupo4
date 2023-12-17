namespace MRnew
{
    partial class AltaPaciente
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
            txtdni = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtdirecc = new TextBox();
            txtvacuna = new TextBox();
            combofechanac = new ComboBox();
            butatras = new Button();
            butGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 66);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 73);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 135);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 122);
            label4.Name = "label4";
            label4.Size = new Size(86, 40);
            label4.TabIndex = 3;
            label4.Text = "Fecha de \r\nNacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 215);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 195);
            label6.Name = "label6";
            label6.Size = new Size(133, 40);
            label6.TabIndex = 5;
            label6.Text = "¿Tiene colocada \r\ntodas sus vacunas?";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtdni
            // 
            txtdni.Location = new Point(192, 66);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 7;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(576, 73);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 8;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(192, 135);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 9;
            // 
            // txtdirecc
            // 
            txtdirecc.Location = new Point(192, 208);
            txtdirecc.Name = "txtdirecc";
            txtdirecc.Size = new Size(125, 27);
            txtdirecc.TabIndex = 10;
            // 
            // txtvacuna
            // 
            txtvacuna.Location = new Point(576, 208);
            txtvacuna.Name = "txtvacuna";
            txtvacuna.Size = new Size(125, 27);
            txtvacuna.TabIndex = 11;
            // 
            // combofechanac
            // 
            combofechanac.FormattingEnabled = true;
            combofechanac.Location = new Point(576, 134);
            combofechanac.Name = "combofechanac";
            combofechanac.Size = new Size(151, 28);
            combofechanac.TabIndex = 12;
            // 
            // butatras
            // 
            butatras.Location = new Point(27, 12);
            butatras.Name = "butatras";
            butatras.Size = new Size(94, 29);
            butatras.TabIndex = 13;
            butatras.Text = "Atras";
            butatras.UseVisualStyleBackColor = true;
            butatras.Click += butatras_Click;
            // 
            // butGuardar
            // 
            butGuardar.Location = new Point(642, 279);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(118, 54);
            butGuardar.TabIndex = 14;
            butGuardar.Text = "Guardar Paciente";
            butGuardar.UseVisualStyleBackColor = true;
            butGuardar.Click += butGuardar_Click;
            // 
            // AltaPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 335);
            Controls.Add(butGuardar);
            Controls.Add(butatras);
            Controls.Add(combofechanac);
            Controls.Add(txtvacuna);
            Controls.Add(txtdirecc);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtdni);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaPaciente";
            Text = "AltaPaciente";
            Load += AltaPaciente_Load;
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
        private TextBox txtdni;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtdirecc;
        private TextBox txtvacuna;
        private ComboBox combofechanac;
        private Button butatras;
        private Button butGuardar;
    }
}