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
            crearRegistroToolStripMenuItem = new ToolStripMenuItem();
            stafToolStripMenuItem = new ToolStripMenuItem();
            especialidadToolStripMenuItem = new ToolStripMenuItem();
            nuevoMedicoToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            butCloseSesion = new Button();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { agendaToolStripMenuItem, stafToolStripMenuItem, pacientesToolStripMenuItem, historialToolStripMenuItem, usuariosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(605, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearRegistroToolStripMenuItem });
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(75, 24);
            agendaToolStripMenuItem.Text = "Agenda";
            agendaToolStripMenuItem.Click += agendaToolStripMenuItem_Click;
            // 
            // crearRegistroToolStripMenuItem
            // 
            crearRegistroToolStripMenuItem.Name = "crearRegistroToolStripMenuItem";
            crearRegistroToolStripMenuItem.Size = new Size(186, 26);
            crearRegistroToolStripMenuItem.Text = "Crear Registro";
            // 
            // stafToolStripMenuItem
            // 
            stafToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { especialidadToolStripMenuItem, nuevoMedicoToolStripMenuItem });
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
            especialidadToolStripMenuItem.Click += especialidadToolStripMenuItem_Click;
            // 
            // nuevoMedicoToolStripMenuItem
            // 
            nuevoMedicoToolStripMenuItem.Name = "nuevoMedicoToolStripMenuItem";
            nuevoMedicoToolStripMenuItem.Size = new Size(176, 26);
            nuevoMedicoToolStripMenuItem.Text = "Medico";
            nuevoMedicoToolStripMenuItem.Click += nuevoMedicoToolStripMenuItem_Click;
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(84, 24);
            pacientesToolStripMenuItem.Text = "Pacientes";
            pacientesToolStripMenuItem.Click += pacientesToolStripMenuItem_Click;
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(79, 24);
            historialToolStripMenuItem.Text = "Historial";
            historialToolStripMenuItem.Click += historialToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(79, 24);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // butCloseSesion
            // 
            butCloseSesion.Location = new Point(491, 211);
            butCloseSesion.Name = "butCloseSesion";
            butCloseSesion.Size = new Size(114, 48);
            butCloseSesion.TabIndex = 2;
            butCloseSesion.Text = "Cerrar Sesion";
            butCloseSesion.UseVisualStyleBackColor = true;
            butCloseSesion.Click += butCloseSesion_Click;
            // 
            // MenuSecretaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 261);
            Controls.Add(butCloseSesion);
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
        private ToolStripMenuItem stafToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripMenuItem nuevoMedicoToolStripMenuItem;
        private ToolStripMenuItem especialidadToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Button butCloseSesion;
        private ToolStripMenuItem crearRegistroToolStripMenuItem;
    }
}