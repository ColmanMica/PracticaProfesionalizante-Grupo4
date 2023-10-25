namespace MRnew
{
    partial class logUsuario2
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
            txtTipo = new TextBox();
            butRegistro = new Button();
            linkLabel1 = new LinkLabel();
            txtBoxContrasenia = new TextBox();
            label2 = new Label();
            ingresoUsuario = new Button();
            txtBoxCorreo = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(280, 209);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(199, 27);
            txtTipo.TabIndex = 16;
            // 
            // butRegistro
            // 
            butRegistro.Location = new Point(317, 310);
            butRegistro.Name = "butRegistro";
            butRegistro.Size = new Size(124, 50);
            butRegistro.TabIndex = 15;
            butRegistro.Text = "Registrarse";
            butRegistro.UseVisualStyleBackColor = true;
            butRegistro.Click += butRegistro_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(280, 212);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 14;
            // 
            // txtBoxContrasenia
            // 
            txtBoxContrasenia.Location = new Point(280, 120);
            txtBoxContrasenia.Name = "txtBoxContrasenia";
            txtBoxContrasenia.Size = new Size(198, 27);
            txtBoxContrasenia.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 127);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 12;
            label2.Text = "Ingrese una Contraseña";
            // 
            // ingresoUsuario
            // 
            ingresoUsuario.Location = new Point(622, 74);
            ingresoUsuario.Name = "ingresoUsuario";
            ingresoUsuario.Size = new Size(101, 64);
            ingresoUsuario.TabIndex = 11;
            ingresoUsuario.Text = "Modificar";
            ingresoUsuario.UseVisualStyleBackColor = true;
            ingresoUsuario.Click += ingresoUsuario_Click;
            // 
            // txtBoxCorreo
            // 
            txtBoxCorreo.Location = new Point(280, 44);
            txtBoxCorreo.Name = "txtBoxCorreo";
            txtBoxCorreo.Size = new Size(198, 27);
            txtBoxCorreo.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 51);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 9;
            label1.Text = "Ingrese el nombre de Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 212);
            label3.Name = "label3";
            label3.Size = new Size(181, 20);
            label3.TabIndex = 17;
            label3.Text = "Ingrese el tipo de usuario ";
            // 
            // logUsuario2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtTipo);
            Controls.Add(butRegistro);
            Controls.Add(linkLabel1);
            Controls.Add(txtBoxContrasenia);
            Controls.Add(label2);
            Controls.Add(ingresoUsuario);
            Controls.Add(txtBoxCorreo);
            Controls.Add(label1);
            Name = "logUsuario2";
            Text = "logUsuario2";
            Load += logUsuario2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTipo;
        private Button butRegistro;
        private LinkLabel linkLabel1;
        private TextBox txtBoxContrasenia;
        private Label label2;
        private Button ingresoUsuario;
        private TextBox txtBoxCorreo;
        private Label label1;
        private Label label3;
    }
}