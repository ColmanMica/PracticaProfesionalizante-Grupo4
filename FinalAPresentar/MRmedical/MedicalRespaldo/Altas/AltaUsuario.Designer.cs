namespace MedicalRespaldo
{
    partial class AltaUsuario
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
            button1 = new Button();
            label3 = new Label();
            butRegistro = new Button();
            linkLabel1 = new LinkLabel();
            txtBoxContrasenia = new TextBox();
            label2 = new Label();
            txtBoxCorreo = new TextBox();
            label1 = new Label();
            comboTipo = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(694, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 57);
            button1.TabIndex = 27;
            button1.Text = "Volver al Ingreso";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 252);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 26;
            label3.Text = "Elija el tipo de usuario ";
            // 
            // butRegistro
            // 
            butRegistro.BackColor = Color.Silver;
            butRegistro.Location = new Point(335, 334);
            butRegistro.Name = "butRegistro";
            butRegistro.Size = new Size(124, 50);
            butRegistro.TabIndex = 24;
            butRegistro.Text = "Registrarse";
            butRegistro.UseVisualStyleBackColor = false;
            butRegistro.Click += butRegistro_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(306, 203);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 23;
            // 
            // txtBoxContrasenia
            // 
            txtBoxContrasenia.Location = new Point(306, 173);
            txtBoxContrasenia.Name = "txtBoxContrasenia";
            txtBoxContrasenia.Size = new Size(198, 27);
            txtBoxContrasenia.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 180);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 21;
            label2.Text = "Ingrese una Contraseña";
            // 
            // txtBoxCorreo
            // 
            txtBoxCorreo.Location = new Point(306, 111);
            txtBoxCorreo.Name = "txtBoxCorreo";
            txtBoxCorreo.Size = new Size(198, 27);
            txtBoxCorreo.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 118);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 19;
            label1.Text = "Ingrese el nombre de Usuario";
            // 
            // comboTipo
            // 
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(306, 244);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(196, 28);
            comboTipo.TabIndex = 28;
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(comboTipo);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(butRegistro);
            Controls.Add(linkLabel1);
            Controls.Add(txtBoxContrasenia);
            Controls.Add(label2);
            Controls.Add(txtBoxCorreo);
            Controls.Add(label1);
            Name = "AltaUsuario";
            Text = "AltaUsuario";
            Load += AltaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Button butRegistro;
        private LinkLabel linkLabel1;
        private TextBox txtBoxContrasenia;
        private Label label2;
        private TextBox txtBoxCorreo;
        private Label label1;
        private ComboBox comboTipo;
    }
}