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
            butatrasLog = new Button();
            linkLabel2 = new LinkLabel();
            txtBoxContrasenia = new TextBox();
            label2 = new Label();
            ingresoUsuario = new Button();
            txtBoxCorreo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // butatrasLog
            // 
            butatrasLog.BackColor = Color.Silver;
            butatrasLog.Location = new Point(2, 3);
            butatrasLog.Name = "butatrasLog";
            butatrasLog.Size = new Size(94, 29);
            butatrasLog.TabIndex = 15;
            butatrasLog.Text = "Atras";
            butatrasLog.UseVisualStyleBackColor = false;
            butatrasLog.Click += butatrasLog_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.DarkGreen;
            linkLabel2.Location = new Point(289, 370);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(232, 20);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Registrarme como Nuevo Usuario";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // txtBoxContrasenia
            // 
            txtBoxContrasenia.Location = new Point(301, 163);
            txtBoxContrasenia.Name = "txtBoxContrasenia";
            txtBoxContrasenia.Size = new Size(198, 27);
            txtBoxContrasenia.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 170);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 12;
            label2.Text = "Contraseña";
            // 
            // ingresoUsuario
            // 
            ingresoUsuario.BackColor = Color.Silver;
            ingresoUsuario.Location = new Point(321, 257);
            ingresoUsuario.Name = "ingresoUsuario";
            ingresoUsuario.Size = new Size(153, 64);
            ingresoUsuario.TabIndex = 11;
            ingresoUsuario.Text = "Ingresar";
            ingresoUsuario.UseVisualStyleBackColor = false;
            ingresoUsuario.Click += ingresoUsuario_Click;
            // 
            // txtBoxCorreo
            // 
            txtBoxCorreo.Location = new Point(301, 88);
            txtBoxCorreo.Name = "txtBoxCorreo";
            txtBoxCorreo.Size = new Size(198, 27);
            txtBoxCorreo.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 91);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 9;
            label1.Text = "Usuario";
            // 
            // LogUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(butatrasLog);
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

        private Button butatrasLog;
        private LinkLabel linkLabel2;
        private TextBox txtBoxContrasenia;
        private Label label2;
        private Button ingresoUsuario;
        private TextBox txtBoxCorreo;
        private Label label1;
    }
}