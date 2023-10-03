namespace MRnew
{
    partial class AHistorial
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
            AHname = new Label();
            AHdni = new Label();
            AHapell = new Label();
            AHfechanac = new Label();
            AHobrasoc = new Label();
            txtAHname = new TextBox();
            txtAH = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // AHname
            // 
            AHname.AutoSize = true;
            AHname.Location = new Point(210, 44);
            AHname.Name = "AHname";
            AHname.Size = new Size(64, 20);
            AHname.TabIndex = 0;
            AHname.Text = "Nombre";
            // 
            // AHdni
            // 
            AHdni.AutoSize = true;
            AHdni.Location = new Point(210, 160);
            AHdni.Name = "AHdni";
            AHdni.Size = new Size(35, 20);
            AHdni.TabIndex = 1;
            AHdni.Text = "DNI";
            // 
            // AHapell
            // 
            AHapell.AutoSize = true;
            AHapell.Location = new Point(210, 107);
            AHapell.Name = "AHapell";
            AHapell.Size = new Size(66, 20);
            AHapell.TabIndex = 2;
            AHapell.Text = "Apellido";
            // 
            // AHfechanac
            // 
            AHfechanac.AutoSize = true;
            AHfechanac.Location = new Point(210, 229);
            AHfechanac.Name = "AHfechanac";
            AHfechanac.Size = new Size(149, 20);
            AHfechanac.TabIndex = 3;
            AHfechanac.Text = "Fecha de Nacimiento";
            // 
            // AHobrasoc
            // 
            AHobrasoc.AutoSize = true;
            AHobrasoc.Location = new Point(210, 292);
            AHobrasoc.Name = "AHobrasoc";
            AHobrasoc.Size = new Size(86, 20);
            AHobrasoc.TabIndex = 4;
            AHobrasoc.Text = "Obra Social";
            // 
            // txtAHname
            // 
            txtAHname.Location = new Point(373, 37);
            txtAHname.Name = "txtAHname";
            txtAHname.Size = new Size(125, 27);
            txtAHname.TabIndex = 5;
            // 
            // txtAH
            // 
            txtAH.Location = new Point(373, 100);
            txtAH.Name = "txtAH";
            txtAH.Size = new Size(125, 27);
            txtAH.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(373, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(373, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(373, 292);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(373, 382);
            button1.Name = "button1";
            button1.Size = new Size(138, 41);
            button1.TabIndex = 10;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(665, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // AHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(txtAH);
            Controls.Add(txtAHname);
            Controls.Add(AHobrasoc);
            Controls.Add(AHfechanac);
            Controls.Add(AHapell);
            Controls.Add(AHdni);
            Controls.Add(AHname);
            Name = "AHistorial";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AHname;
        private Label AHdni;
        private Label AHapell;
        private Label AHfechanac;
        private Label AHobrasoc;
        private TextBox txtAHname;
        private TextBox txtAH;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
    }
}