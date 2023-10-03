namespace MRnew
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
            historialToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem = new ToolStripMenuItem();
            modificaciónToolStripMenuItem = new ToolStripMenuItem();
            bajaToolStripMenuItem = new ToolStripMenuItem();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            monthCalendar1 = new MonthCalendar();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { historialToolStripMenuItem, agendaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem, modificaciónToolStripMenuItem, bajaToolStripMenuItem });
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(79, 24);
            historialToolStripMenuItem.Text = "Historial";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(224, 26);
            altaToolStripMenuItem.Text = "Alta";
            altaToolStripMenuItem.Click += altaToolStripMenuItem_Click;
            // 
            // modificaciónToolStripMenuItem
            // 
            modificaciónToolStripMenuItem.Name = "modificaciónToolStripMenuItem";
            modificaciónToolStripMenuItem.Size = new Size(224, 26);
            modificaciónToolStripMenuItem.Text = "Modificación";
            // 
            // bajaToolStripMenuItem
            // 
            bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            bajaToolStripMenuItem.Size = new Size(224, 26);
            bajaToolStripMenuItem.Text = "Baja";
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(75, 24);
            agendaToolStripMenuItem.Text = "Agenda";
            agendaToolStripMenuItem.Click += agendaToolStripMenuItem_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(124, 37);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // MenuMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
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
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem modificaciónToolStripMenuItem;
        private ToolStripMenuItem bajaToolStripMenuItem;
        private ToolStripMenuItem agendaToolStripMenuItem;
        private MonthCalendar monthCalendar1;
    }
}