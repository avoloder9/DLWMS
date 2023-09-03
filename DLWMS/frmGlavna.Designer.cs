namespace DLWMS.WinForms
{
    partial class frmGlavna
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaStudenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.krajRadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblPrikaziDatumVrijeme = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentiToolStripMenuItem,
            this.pingToolStripMenuItem,
            this.toolStripSeparator1,
            this.krajRadaToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // studentiToolStripMenuItem
            // 
            this.studentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviStudentToolStripMenuItem,
            this.pretragaStudenataToolStripMenuItem});
            this.studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            this.studentiToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.studentiToolStripMenuItem.Text = "Studenti";
            this.studentiToolStripMenuItem.Click += new System.EventHandler(this.studentiToolStripMenuItem_Click);
            // 
            // noviStudentToolStripMenuItem
            // 
            this.noviStudentToolStripMenuItem.Name = "noviStudentToolStripMenuItem";
            this.noviStudentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.noviStudentToolStripMenuItem.Text = "Novi student";
            this.noviStudentToolStripMenuItem.Click += new System.EventHandler(this.noviStudentToolStripMenuItem_Click);
            // 
            // pretragaStudenataToolStripMenuItem
            // 
            this.pretragaStudenataToolStripMenuItem.Name = "pretragaStudenataToolStripMenuItem";
            this.pretragaStudenataToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pretragaStudenataToolStripMenuItem.Text = "Pretraga studenata";
            this.pretragaStudenataToolStripMenuItem.Click += new System.EventHandler(this.pretragaStudenataToolStripMenuItem_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // krajRadaToolStripMenuItem
            // 
            this.krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            this.krajRadaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.krajRadaToolStripMenuItem.Text = "Kraj rada";
            this.krajRadaToolStripMenuItem.Click += new System.EventHandler(this.krajRadaToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.odjavaToolStripMenuItem.Text = "¸Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPrikaziDatumVrijeme});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblPrikaziDatumVrijeme
            // 
            this.lblPrikaziDatumVrijeme.Name = "lblPrikaziDatumVrijeme";
            this.lblPrikaziDatumVrijeme.Size = new System.Drawing.Size(118, 17);
            this.lblPrikaziDatumVrijeme.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGlavna";
            this.Text = "DLWMS v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGlavna_FormClosing);
            this.Load += new System.EventHandler(this.frmGlavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem studentiToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem krajRadaToolStripMenuItem;
        private ToolStripMenuItem pingToolStripMenuItem;
        private ToolStripMenuItem noviStudentToolStripMenuItem;
        private ToolStripMenuItem pretragaStudenataToolStripMenuItem;
        private ToolStripMenuItem odjavaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblPrikaziDatumVrijeme;
        private System.Windows.Forms.Timer timer1;
    }
}