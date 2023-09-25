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
            label3 = new Label();
            txtBoxContrasenia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 81);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtBoxCorreo
            // 
            txtBoxCorreo.Location = new Point(246, 78);
            txtBoxCorreo.Name = "txtBoxCorreo";
            txtBoxCorreo.Size = new Size(125, 27);
            txtBoxCorreo.TabIndex = 1;
            // 
            // ingresoUsuario
            // 
            ingresoUsuario.Location = new Point(246, 297);
            ingresoUsuario.Name = "ingresoUsuario";
            ingresoUsuario.Size = new Size(108, 60);
            ingresoUsuario.TabIndex = 2;
            ingresoUsuario.Text = "Ingresar";
            ingresoUsuario.UseVisualStyleBackColor = true;
            ingresoUsuario.Click += ingresoUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 171);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 205);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 4;
            label3.Text = "Olvide mi contraseña";
            // 
            // txtBoxContrasenia
            // 
            txtBoxContrasenia.Location = new Point(246, 164);
            txtBoxContrasenia.Name = "txtBoxContrasenia";
            txtBoxContrasenia.Size = new Size(125, 27);
            txtBoxContrasenia.TabIndex = 5;
            // 
            // LogUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxContrasenia);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox txtBoxContrasenia;
    }
}