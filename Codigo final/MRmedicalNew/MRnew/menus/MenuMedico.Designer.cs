﻿namespace MRnew
{
    partial class MenuMedico
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
            menuStrip1 = new MenuStrip();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            hIstorialToolStripMenuItem = new ToolStripMenuItem();
            butCerrarSesionMed = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { agendaToolStripMenuItem, hIstorialToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(474, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(75, 24);
            agendaToolStripMenuItem.Text = "Agenda";
            agendaToolStripMenuItem.Click += agendaToolStripMenuItem_Click;
            // 
            // hIstorialToolStripMenuItem
            // 
            hIstorialToolStripMenuItem.Name = "hIstorialToolStripMenuItem";
            hIstorialToolStripMenuItem.Size = new Size(79, 24);
            hIstorialToolStripMenuItem.Text = "Historial";
            hIstorialToolStripMenuItem.Click += hIstorialToolStripMenuItem_Click_1;
            // 
            // butCerrarSesionMed
            // 
            butCerrarSesionMed.Location = new Point(358, 207);
            butCerrarSesionMed.Name = "butCerrarSesionMed";
            butCerrarSesionMed.Size = new Size(116, 57);
            butCerrarSesionMed.TabIndex = 1;
            butCerrarSesionMed.Text = "Cerrar Sesion";
            butCerrarSesionMed.UseVisualStyleBackColor = true;
            butCerrarSesionMed.Click += butCerrarSesionMed_Click;
            // 
            // MenuMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 264);
            Controls.Add(butCerrarSesionMed);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuMedico";
            Text = "MenuMedico";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private ToolStripMenuItem hIstorialToolStripMenuItem;
        private Button butCerrarSesionMed;
    }
}