namespace MedicalRespaldo
{
    partial class LogUsuario
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
            linkLabel2 = new LinkLabel();
            txtBoxContrasenia = new TextBox();
            label2 = new Label();
            ingresoUsuario = new Button();
            txtBoxCorreo = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.DarkGreen;
            linkLabel2.Location = new Point(443, 366);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(232, 20);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Registrarme como Nuevo Usuario";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // txtBoxContrasenia
            // 
            txtBoxContrasenia.Location = new Point(452, 163);
            txtBoxContrasenia.Name = "txtBoxContrasenia";
            txtBoxContrasenia.Size = new Size(198, 27);
            txtBoxContrasenia.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 166);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 12;
            label2.Text = "Contraseña";
            // 
            // ingresoUsuario
            // 
            ingresoUsuario.BackColor = Color.Silver;
            ingresoUsuario.Location = new Point(472, 249);
            ingresoUsuario.Name = "ingresoUsuario";
            ingresoUsuario.Size = new Size(153, 64);
            ingresoUsuario.TabIndex = 11;
            ingresoUsuario.Text = "Ingresar";
            ingresoUsuario.UseVisualStyleBackColor = false;
            ingresoUsuario.Click += ingresoUsuario_Click;
            // 
            // txtBoxCorreo
            // 
            txtBoxCorreo.Location = new Point(452, 84);
            txtBoxCorreo.Name = "txtBoxCorreo";
            txtBoxCorreo.Size = new Size(198, 27);
            txtBoxCorreo.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 87);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 9;
            label1.Text = "Usuario";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Font = new Font("Monotype Corsiva", 22.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(-6, -12);
            label3.Name = "label3";
            label3.Size = new Size(264, 470);
            label3.TabIndex = 16;
            label3.Text = "M\r\n   R\r\n\r\n      M\r\n         E\r\n           D\r\n              I\r\n                C\r\n                   A\r\n                      L";
            // 
            // LogUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(linkLabel2);
            Controls.Add(txtBoxContrasenia);
            Controls.Add(label2);
            Controls.Add(ingresoUsuario);
            Controls.Add(txtBoxCorreo);
            Controls.Add(label1);
            Name = "LogUsuario";
            Text = "LogUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel2;
        private TextBox txtBoxContrasenia;
        private Label label2;
        private Button ingresoUsuario;
        private TextBox txtBoxCorreo;
        private Label label1;
        private Label label3;
    }
}