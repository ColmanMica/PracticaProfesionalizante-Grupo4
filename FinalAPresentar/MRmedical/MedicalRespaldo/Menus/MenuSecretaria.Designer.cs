namespace MedicalRespaldo
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
            butCloseSesion = new Button();
            menuStrip1 = new MenuStrip();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            crearRegistroToolStripMenuItem = new ToolStripMenuItem();
            abrirAgendaToolStripMenuItem = new ToolStripMenuItem();
            stafToolStripMenuItem = new ToolStripMenuItem();
            especialidadToolStripMenuItem = new ToolStripMenuItem();
            medicoToolStripMenuItem = new ToolStripMenuItem();
            agregarSecretariaToolStripMenuItem = new ToolStripMenuItem();
            listdoDeMedicosToolStripMenuItem = new ToolStripMenuItem();
            listadoDeSecretariasToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            turnosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // butCloseSesion
            // 
            butCloseSesion.BackColor = Color.Silver;
            butCloseSesion.Location = new Point(609, 279);
            butCloseSesion.Name = "butCloseSesion";
            butCloseSesion.Size = new Size(114, 48);
            butCloseSesion.TabIndex = 3;
            butCloseSesion.Text = "Cerrar Sesion";
            butCloseSesion.UseVisualStyleBackColor = false;
            butCloseSesion.Click += butCloseSesion_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agendaToolStripMenuItem, stafToolStripMenuItem, pacienteToolStripMenuItem, historialToolStripMenuItem, usuariosToolStripMenuItem, turnosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(735, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearRegistroToolStripMenuItem, abrirAgendaToolStripMenuItem });
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(75, 24);
            agendaToolStripMenuItem.Text = "Agenda";
            agendaToolStripMenuItem.Click += agendaToolStripMenuItem_Click;
            // 
            // crearRegistroToolStripMenuItem
            // 
            crearRegistroToolStripMenuItem.Name = "crearRegistroToolStripMenuItem";
            crearRegistroToolStripMenuItem.Size = new Size(190, 26);
            crearRegistroToolStripMenuItem.Text = "Crear Registro ";
            crearRegistroToolStripMenuItem.Click += crearRegistroToolStripMenuItem_Click;
            // 
            // abrirAgendaToolStripMenuItem
            // 
            abrirAgendaToolStripMenuItem.Name = "abrirAgendaToolStripMenuItem";
            abrirAgendaToolStripMenuItem.Size = new Size(190, 26);
            abrirAgendaToolStripMenuItem.Text = "Abrir Agenda";
            abrirAgendaToolStripMenuItem.Click += abrirAgendaToolStripMenuItem_Click;
            // 
            // stafToolStripMenuItem
            // 
            stafToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { especialidadToolStripMenuItem, medicoToolStripMenuItem, agregarSecretariaToolStripMenuItem, listdoDeMedicosToolStripMenuItem, listadoDeSecretariasToolStripMenuItem });
            stafToolStripMenuItem.Name = "stafToolStripMenuItem";
            stafToolStripMenuItem.Size = new Size(54, 24);
            stafToolStripMenuItem.Text = "Staff";
            stafToolStripMenuItem.Click += stafToolStripMenuItem_Click;
            // 
            // especialidadToolStripMenuItem
            // 
            especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            especialidadToolStripMenuItem.Size = new Size(237, 26);
            especialidadToolStripMenuItem.Text = "Especialidad";
            especialidadToolStripMenuItem.Click += especialidadToolStripMenuItem_Click;
            // 
            // medicoToolStripMenuItem
            // 
            medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            medicoToolStripMenuItem.Size = new Size(237, 26);
            medicoToolStripMenuItem.Text = "Agregar Medico";
            medicoToolStripMenuItem.Click += medicoToolStripMenuItem_Click;
            // 
            // agregarSecretariaToolStripMenuItem
            // 
            agregarSecretariaToolStripMenuItem.Name = "agregarSecretariaToolStripMenuItem";
            agregarSecretariaToolStripMenuItem.Size = new Size(237, 26);
            agregarSecretariaToolStripMenuItem.Text = "Agregar Secretaria";
            agregarSecretariaToolStripMenuItem.Click += agregarSecretariaToolStripMenuItem_Click;
            // 
            // listdoDeMedicosToolStripMenuItem
            // 
            listdoDeMedicosToolStripMenuItem.Name = "listdoDeMedicosToolStripMenuItem";
            listdoDeMedicosToolStripMenuItem.Size = new Size(237, 26);
            listdoDeMedicosToolStripMenuItem.Text = "Listdo de Medicos";
            listdoDeMedicosToolStripMenuItem.Click += listdoDeMedicosToolStripMenuItem_Click;
            // 
            // listadoDeSecretariasToolStripMenuItem
            // 
            listadoDeSecretariasToolStripMenuItem.Name = "listadoDeSecretariasToolStripMenuItem";
            listadoDeSecretariasToolStripMenuItem.Size = new Size(237, 26);
            listadoDeSecretariasToolStripMenuItem.Text = "Listado de Secretarias";
            listadoDeSecretariasToolStripMenuItem.Click += listadoDeSecretariasToolStripMenuItem_Click;
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(84, 24);
            pacienteToolStripMenuItem.Text = "Pacientes";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
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
            // turnosToolStripMenuItem
            // 
            turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            turnosToolStripMenuItem.Size = new Size(67, 24);
            turnosToolStripMenuItem.Text = "Turnos";
            turnosToolStripMenuItem.Click += turnosToolStripMenuItem_Click;
            // 
            // MenuSecretaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.Medical;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(735, 339);
            Controls.Add(butCloseSesion);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuSecretaria";
            Text = "MenuSecretaria";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butCloseSesion;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private ToolStripMenuItem crearRegistroToolStripMenuItem;
        private ToolStripMenuItem stafToolStripMenuItem;
        private ToolStripMenuItem especialidadToolStripMenuItem;
        private ToolStripMenuItem medicoToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem agregarSecretariaToolStripMenuItem;
        private ToolStripMenuItem listdoDeMedicosToolStripMenuItem;
        private ToolStripMenuItem listadoDeSecretariasToolStripMenuItem;
        private ToolStripMenuItem abrirAgendaToolStripMenuItem;
        private ToolStripMenuItem turnosToolStripMenuItem;
    }
}