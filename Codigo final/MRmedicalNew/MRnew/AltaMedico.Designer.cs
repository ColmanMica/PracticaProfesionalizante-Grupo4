namespace MRnew
{
    partial class AltaMedico
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
            txtdni = new TextBox();
            comboespec = new ComboBox();
            amedico = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtdate = new TextBox();
            txtapell = new TextBox();
            textname = new TextBox();
            modmed = new Button();
            label5 = new Label();
            elimedico = new Button();
            cancelarM = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // txtdni
            // 
            txtdni.Location = new Point(360, 38);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 1;
            // 
            // comboespec
            // 
            comboespec.FormattingEnabled = true;
            comboespec.Location = new Point(360, 280);
            comboespec.Name = "comboespec";
            comboespec.Size = new Size(125, 28);
            comboespec.TabIndex = 2;
            comboespec.SelectedIndexChanged += comboespec_SelectedIndexChanged;
            // 
            // amedico
            // 
            amedico.Location = new Point(634, 41);
            amedico.Name = "amedico";
            amedico.Size = new Size(113, 55);
            amedico.TabIndex = 3;
            amedico.Text = "Agregar";
            amedico.UseVisualStyleBackColor = true;
            amedico.Click += amedico_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 95);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 151);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 215);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha de nacimiento";
            // 
            // txtdate
            // 
            txtdate.Location = new Point(360, 208);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(125, 27);
            txtdate.TabIndex = 9;
            // 
            // txtapell
            // 
            txtapell.Location = new Point(360, 144);
            txtapell.Name = "txtapell";
            txtapell.Size = new Size(125, 27);
            txtapell.TabIndex = 10;
            // 
            // textname
            // 
            textname.Location = new Point(360, 88);
            textname.Name = "textname";
            textname.Size = new Size(125, 27);
            textname.TabIndex = 11;
            // 
            // modmed
            // 
            modmed.Location = new Point(634, 144);
            modmed.Name = "modmed";
            modmed.Size = new Size(113, 54);
            modmed.TabIndex = 12;
            modmed.Text = "Actualizar Informacion";
            modmed.UseVisualStyleBackColor = true;
            modmed.Click += modmed_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 288);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 13;
            label5.Text = "Especialidad";
            // 
            // elimedico
            // 
            elimedico.Location = new Point(634, 255);
            elimedico.Name = "elimedico";
            elimedico.RightToLeft = RightToLeft.No;
            elimedico.Size = new Size(113, 53);
            elimedico.TabIndex = 14;
            elimedico.Text = "Eliminar";
            elimedico.UseVisualStyleBackColor = true;
            elimedico.Click += elimedico_Click;
            // 
            // cancelarM
            // 
            cancelarM.Location = new Point(653, 409);
            cancelarM.Name = "cancelarM";
            cancelarM.Size = new Size(94, 29);
            cancelarM.TabIndex = 15;
            cancelarM.Text = "Cancelar";
            cancelarM.UseVisualStyleBackColor = true;
            cancelarM.Click += cancelarM_Click;
            // 
            // AltaMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelarM);
            Controls.Add(elimedico);
            Controls.Add(label5);
            Controls.Add(modmed);
            Controls.Add(textname);
            Controls.Add(txtapell);
            Controls.Add(txtdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(amedico);
            Controls.Add(comboespec);
            Controls.Add(txtdni);
            Controls.Add(label1);
            Name = "AltaMedico";
            Text = "AltaMedico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtdni;
        private ComboBox comboespec;
        private Button amedico;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtdate;
        private TextBox txtapell;
        private TextBox textname;
        private Button modmed;
        private Label label5;
        private Button elimedico;
        private Button cancelarM;
    }
}