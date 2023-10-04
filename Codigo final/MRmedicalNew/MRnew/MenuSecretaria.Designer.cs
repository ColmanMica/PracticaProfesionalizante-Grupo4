namespace MRnew
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            turnoToolStripMenuItem = new ToolStripMenuItem();
            stafToolStripMenuItem = new ToolStripMenuItem();
            especialidadToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            altaPAcienteToolStripMenuItem = new ToolStripMenuItem();
            bajaPacienteToolStripMenuItem = new ToolStripMenuItem();
            modificaciónPacienteToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agendaToolStripMenuItem, stafToolStripMenuItem, pacientesToolStripMenuItem, historialToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { turnoToolStripMenuItem });
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(75, 24);
            agendaToolStripMenuItem.Text = "Agenda";
            agendaToolStripMenuItem.Click += agendaToolStripMenuItem_Click;
            // 
            // turnoToolStripMenuItem
            // 
            turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            turnoToolStripMenuItem.Size = new Size(224, 26);
            turnoToolStripMenuItem.Text = "Turno";
            turnoToolStripMenuItem.Click += turnoToolStripMenuItem_Click;
            // 
            // stafToolStripMenuItem
            // 
            stafToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { especialidadToolStripMenuItem });
            stafToolStripMenuItem.Name = "stafToolStripMenuItem";
            stafToolStripMenuItem.Size = new Size(49, 24);
            stafToolStripMenuItem.Text = "Staf";
            stafToolStripMenuItem.Click += stafToolStripMenuItem_Click;
            // 
            // especialidadToolStripMenuItem
            // 
            especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            especialidadToolStripMenuItem.Size = new Size(176, 26);
            especialidadToolStripMenuItem.Text = "Especialidad";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaPAcienteToolStripMenuItem, bajaPacienteToolStripMenuItem, modificaciónPacienteToolStripMenuItem });
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(84, 24);
            pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // altaPAcienteToolStripMenuItem
            // 
            altaPAcienteToolStripMenuItem.Name = "altaPAcienteToolStripMenuItem";
            altaPAcienteToolStripMenuItem.Size = new Size(234, 26);
            altaPAcienteToolStripMenuItem.Text = "AltaPAciente";
            // 
            // bajaPacienteToolStripMenuItem
            // 
            bajaPacienteToolStripMenuItem.Name = "bajaPacienteToolStripMenuItem";
            bajaPacienteToolStripMenuItem.Size = new Size(234, 26);
            bajaPacienteToolStripMenuItem.Text = "BajaPaciente";
            // 
            // modificaciónPacienteToolStripMenuItem
            // 
            modificaciónPacienteToolStripMenuItem.Name = "modificaciónPacienteToolStripMenuItem";
            modificaciónPacienteToolStripMenuItem.Size = new Size(234, 26);
            modificaciónPacienteToolStripMenuItem.Text = "ModificaciónPaciente";
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(79, 24);
            historialToolStripMenuItem.Text = "Historial";
            // 
            // MenuSecretaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuSecretaria";
            Text = "MenuSecretaria";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private ToolStripMenuItem turnoToolStripMenuItem;
        private ToolStripMenuItem stafToolStripMenuItem;
        private ToolStripMenuItem especialidadToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem altaPAcienteToolStripMenuItem;
        private ToolStripMenuItem bajaPacienteToolStripMenuItem;
        private ToolStripMenuItem modificaciónPacienteToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
    }
}