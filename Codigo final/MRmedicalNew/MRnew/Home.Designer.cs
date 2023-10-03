namespace MRnew
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            butIngresoSistem = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // butIngresoSistem
            // 
            butIngresoSistem.Location = new Point(290, 200);
            butIngresoSistem.Name = "butIngresoSistem";
            butIngresoSistem.Size = new Size(157, 54);
            butIngresoSistem.TabIndex = 0;
            butIngresoSistem.Text = "Ingreso al Sistema";
            butIngresoSistem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 160);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 140);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "MRMEDICAL";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(butIngresoSistem);
            Name = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butIngresoSistem;
        private Label label1;
        private Label label2;
    }
}