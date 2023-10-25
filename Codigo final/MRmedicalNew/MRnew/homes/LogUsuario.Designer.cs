namespace MRnew
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
            label1 = new Label();
            txtBoxCorreo = new TextBox();
            ingresoUsuario = new Button();
            label2 = new Label();
            txtBoxContrasenia = new TextBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 78);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtBoxCorreo
            // 
            txtBoxCorreo.Location = new Point(356, 78);
            txtBoxCorreo.Name = "txtBoxCorreo";
            txtBoxCorreo.Size = new Size(198, 27);
            txtBoxCorreo.TabIndex = 1;
            // 
            // ingresoUsuario
            // 
            ingresoUsuario.Location = new Point(356, 250);
            ingresoUsuario.Name = "ingresoUsuario";
            ingresoUsuario.Size = new Size(153, 64);
            ingresoUsuario.TabIndex = 2;
            ingresoUsuario.Text = "Ingresar";
            ingresoUsuario.UseVisualStyleBackColor = true;
            ingresoUsuario.Click += ingresoUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 160);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtBoxContrasenia
            // 
            txtBoxContrasenia.Location = new Point(356, 157);
            txtBoxContrasenia.Name = "txtBoxContrasenia";
            txtBoxContrasenia.Size = new Size(198, 27);
            txtBoxContrasenia.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(356, 187);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvide mi contraseña";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.DarkGreen;
            linkLabel2.Location = new Point(322, 362);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(232, 20);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Registrarme como Nuevo Usuario";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // LogUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
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

        private Label label1;
        private TextBox txtBoxCorreo;
        private Button ingresoUsuario;
        private Label label2;
        private TextBox txtBoxContrasenia;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}