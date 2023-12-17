namespace MRnew
{
    partial class NuevoHistorial
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtnombre = new TextBox();
            txtobrasoc = new TextBox();
            txtapellido = new TextBox();
            txtdni = new TextBox();
            combofechahr = new ComboBox();
            combofechanac = new ComboBox();
            buttAtras = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 78);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 75);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 158);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 151);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 225);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 4;
            label5.Text = "Obra Social";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 230);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 5;
            label6.Text = "Creado el dia:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(124, 75);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 6;
            // 
            // txtobrasoc
            // 
            txtobrasoc.Location = new Point(124, 222);
            txtobrasoc.Name = "txtobrasoc";
            txtobrasoc.Size = new Size(125, 27);
            txtobrasoc.TabIndex = 7;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(520, 72);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 8;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(124, 151);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 9;
            // 
            // combofechahr
            // 
            combofechahr.FormattingEnabled = true;
            combofechahr.Location = new Point(520, 230);
            combofechahr.Name = "combofechahr";
            combofechahr.Size = new Size(151, 28);
            combofechahr.TabIndex = 10;
            // 
            // combofechanac
            // 
            combofechanac.FormattingEnabled = true;
            combofechanac.Location = new Point(520, 151);
            combofechanac.Name = "combofechanac";
            combofechanac.Size = new Size(151, 28);
            combofechanac.TabIndex = 11;
            // 
            // buttAtras
            // 
            buttAtras.Location = new Point(12, 1);
            buttAtras.Name = "buttAtras";
            buttAtras.Size = new Size(94, 29);
            buttAtras.TabIndex = 12;
            buttAtras.Text = "Atras";
            buttAtras.UseVisualStyleBackColor = true;
            buttAtras.Click += buttAtras_Click;
            // 
            // button2
            // 
            button2.Location = new Point(520, 357);
            button2.Name = "button2";
            button2.Size = new Size(108, 54);
            button2.TabIndex = 13;
            button2.Text = "Guardar datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NuevoHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(button2);
            Controls.Add(buttAtras);
            Controls.Add(combofechanac);
            Controls.Add(combofechahr);
            Controls.Add(txtdni);
            Controls.Add(txtapellido);
            Controls.Add(txtobrasoc);
            Controls.Add(txtnombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoHistorial";
            Text = "NuevoHistorial";
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
        private TextBox txtnombre;
        private TextBox txtobrasoc;
        private TextBox txtapellido;
        private TextBox txtdni;
        private ComboBox combofechahr;
        private ComboBox combofechanac;
        private Button buttAtras;
        private Button button2;
    }
}