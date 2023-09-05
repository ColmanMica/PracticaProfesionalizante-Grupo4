namespace MRmedical
{
    partial class MenuSecretaria
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajapacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.stafToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnoToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.turnoToolStripMenuItem.Text = "Turno";
            this.turnoToolStripMenuItem.Click += new System.EventHandler(this.turnoToolStripMenuItem_Click);
            // 
            // stafToolStripMenuItem
            // 
            this.stafToolStripMenuItem.Name = "stafToolStripMenuItem";
            this.stafToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.stafToolStripMenuItem.Text = "Staf";
            this.stafToolStripMenuItem.Click += new System.EventHandler(this.stafToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPacienteToolStripMenuItem,
            this.bajapacienteToolStripMenuItem,
            this.modificacionPacienteToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // altaPacienteToolStripMenuItem
            // 
            this.altaPacienteToolStripMenuItem.Name = "altaPacienteToolStripMenuItem";
            this.altaPacienteToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.altaPacienteToolStripMenuItem.Text = "AltaPaciente";
            // 
            // bajapacienteToolStripMenuItem
            // 
            this.bajapacienteToolStripMenuItem.Name = "bajapacienteToolStripMenuItem";
            this.bajapacienteToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.bajapacienteToolStripMenuItem.Text = "Bajapaciente";
            // 
            // modificacionPacienteToolStripMenuItem
            // 
            this.modificacionPacienteToolStripMenuItem.Name = "modificacionPacienteToolStripMenuItem";
            this.modificacionPacienteToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.modificacionPacienteToolStripMenuItem.Text = "ModificacionPaciente";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // MenuSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuSecretaria";
            this.Text = "MenuSecretaria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajapacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
    }
}