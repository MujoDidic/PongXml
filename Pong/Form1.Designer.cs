namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bestenlisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwierigkeitsgradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehrEinfachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mittelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sehrSchwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spielfeldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schlaeger = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.spielfeld = new System.Windows.Forms.Panel();
            this.timerBall = new System.Windows.Forms.Timer(this.components);
            this.timerSpiel = new System.Windows.Forms.Timer(this.components);
            this.timerSekunde = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.spielfeld.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielToolStripMenuItem
            // 
            this.spielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripSeparator1,
            this.bestenlisteToolStripMenuItem,
            this.toolStripSeparator2,
            this.beendenToolStripMenuItem});
            this.spielToolStripMenuItem.Name = "spielToolStripMenuItem";
            this.spielToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.spielToolStripMenuItem.Text = "&Spiel";
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.neuesSpielToolStripMenuItem.Text = "&Neues Spiel";
            this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.NeuesSpielToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pauseToolStripMenuItem.Text = "&Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.PauseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // bestenlisteToolStripMenuItem
            // 
            this.bestenlisteToolStripMenuItem.Name = "bestenlisteToolStripMenuItem";
            this.bestenlisteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bestenlisteToolStripMenuItem.Text = "B&estenliste";
            this.bestenlisteToolStripMenuItem.Click += new System.EventHandler(this.BestenlisteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schwierigkeitsgradToolStripMenuItem,
            this.spielfeldToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "&Einstellungen";
            // 
            // schwierigkeitsgradToolStripMenuItem
            // 
            this.schwierigkeitsgradToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sehrEinfachToolStripMenuItem,
            this.einfachToolStripMenuItem,
            this.mittelToolStripMenuItem,
            this.schwerToolStripMenuItem,
            this.sehrSchwerToolStripMenuItem});
            this.schwierigkeitsgradToolStripMenuItem.Name = "schwierigkeitsgradToolStripMenuItem";
            this.schwierigkeitsgradToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.schwierigkeitsgradToolStripMenuItem.Text = "&Schwierigkeitsgrad";
            // 
            // sehrEinfachToolStripMenuItem
            // 
            this.sehrEinfachToolStripMenuItem.Name = "sehrEinfachToolStripMenuItem";
            this.sehrEinfachToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sehrEinfachToolStripMenuItem.Text = "Se&hr einfach";
            this.sehrEinfachToolStripMenuItem.Click += new System.EventHandler(this.SehrEinfachToolStripMenuItem_Click);
            // 
            // einfachToolStripMenuItem
            // 
            this.einfachToolStripMenuItem.Checked = true;
            this.einfachToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.einfachToolStripMenuItem.Name = "einfachToolStripMenuItem";
            this.einfachToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.einfachToolStripMenuItem.Text = "E&infach";
            this.einfachToolStripMenuItem.Click += new System.EventHandler(this.EinfachToolStripMenuItem_Click);
            // 
            // mittelToolStripMenuItem
            // 
            this.mittelToolStripMenuItem.Name = "mittelToolStripMenuItem";
            this.mittelToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.mittelToolStripMenuItem.Text = "&Mittel";
            this.mittelToolStripMenuItem.Click += new System.EventHandler(this.MittelToolStripMenuItem_Click);
            // 
            // schwerToolStripMenuItem
            // 
            this.schwerToolStripMenuItem.Name = "schwerToolStripMenuItem";
            this.schwerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.schwerToolStripMenuItem.Text = "Sch&wer";
            this.schwerToolStripMenuItem.Click += new System.EventHandler(this.SchwerToolStripMenuItem_Click);
            // 
            // sehrSchwerToolStripMenuItem
            // 
            this.sehrSchwerToolStripMenuItem.Name = "sehrSchwerToolStripMenuItem";
            this.sehrSchwerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sehrSchwerToolStripMenuItem.Text = "Sehr schwe&r";
            this.sehrSchwerToolStripMenuItem.Click += new System.EventHandler(this.SehrSchwerToolStripMenuItem_Click);
            // 
            // spielfeldToolStripMenuItem
            // 
            this.spielfeldToolStripMenuItem.Name = "spielfeldToolStripMenuItem";
            this.spielfeldToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.spielfeldToolStripMenuItem.Text = "S&pielfeld";
            this.spielfeldToolStripMenuItem.Click += new System.EventHandler(this.SpielfeldToolStripMenuItem_Click);
            // 
            // schlaeger
            // 
            this.schlaeger.Location = new System.Drawing.Point(58, 30);
            this.schlaeger.Name = "schlaeger";
            this.schlaeger.Size = new System.Drawing.Size(200, 100);
            this.schlaeger.TabIndex = 0;
            this.schlaeger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Schlaeger_MouseMove);
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(353, 82);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(200, 100);
            this.ball.TabIndex = 1;
            // 
            // spielfeld
            // 
            this.spielfeld.Controls.Add(this.schlaeger);
            this.spielfeld.Controls.Add(this.ball);
            this.spielfeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spielfeld.Location = new System.Drawing.Point(0, 24);
            this.spielfeld.Name = "spielfeld";
            this.spielfeld.Size = new System.Drawing.Size(624, 417);
            this.spielfeld.TabIndex = 3;
            this.spielfeld.Paint += new System.Windows.Forms.PaintEventHandler(this.Spielfeld_Paint);
            // 
            // timerBall
            // 
            this.timerBall.Enabled = true;
            this.timerBall.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timerSpiel
            // 
            this.timerSpiel.Interval = 120000;
            this.timerSpiel.Tick += new System.EventHandler(this.TimerSpiel_Tick);
            // 
            // timerSekunde
            // 
            this.timerSekunde.Interval = 1000;
            this.timerSekunde.Tick += new System.EventHandler(this.TimerSekunde_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.spielfeld);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pong";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spielfeld.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Panel schlaeger;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Panel spielfeld;
        private System.Windows.Forms.Timer timerBall;
        private System.Windows.Forms.Timer timerSpiel;
        private System.Windows.Forms.Timer timerSekunde;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestenlisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwierigkeitsgradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehrEinfachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mittelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sehrSchwerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spielfeldToolStripMenuItem;
    }
}

