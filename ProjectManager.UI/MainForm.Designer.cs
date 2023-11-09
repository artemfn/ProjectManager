namespace ProjectManager.UI
{
    partial class MainForm
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddWordFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddExcelFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPowerPointFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjectsListBox = new System.Windows.Forms.ListBox();
            this.MainProjectFilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfileMenuItem,
            this.ProjectMenuItem,
            this.FileMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1124, 25);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // ProfileMenuItem
            // 
            this.ProfileMenuItem.Name = "ProfileMenuItem";
            this.ProfileMenuItem.Size = new System.Drawing.Size(57, 21);
            this.ProfileMenuItem.Text = "Profile";
            this.ProfileMenuItem.Click += new System.EventHandler(this.ProfileMenuItem_Click);
            // 
            // ProjectMenuItem
            // 
            this.ProjectMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProjectMenuItem,
            this.DeleteProjectMenuItem,
            this.OpenProjectMenuItem});
            this.ProjectMenuItem.Name = "ProjectMenuItem";
            this.ProjectMenuItem.Size = new System.Drawing.Size(60, 21);
            this.ProjectMenuItem.Text = "Project";
            // 
            // CreateProjectMenuItem
            // 
            this.CreateProjectMenuItem.Name = "CreateProjectMenuItem";
            this.CreateProjectMenuItem.Size = new System.Drawing.Size(114, 22);
            this.CreateProjectMenuItem.Text = "Create";
            this.CreateProjectMenuItem.Click += new System.EventHandler(this.CreateProjectMenuItem_Click);
            // 
            // DeleteProjectMenuItem
            // 
            this.DeleteProjectMenuItem.Name = "DeleteProjectMenuItem";
            this.DeleteProjectMenuItem.Size = new System.Drawing.Size(114, 22);
            this.DeleteProjectMenuItem.Text = "Delete";
            this.DeleteProjectMenuItem.Click += new System.EventHandler(this.DeleteProjectMenuItem_Click);
            // 
            // OpenProjectMenuItem
            // 
            this.OpenProjectMenuItem.Name = "OpenProjectMenuItem";
            this.OpenProjectMenuItem.Size = new System.Drawing.Size(114, 22);
            this.OpenProjectMenuItem.Text = "Open";
            this.OpenProjectMenuItem.Click += new System.EventHandler(this.OpenProjectMenuItem_Click);
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFileMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(39, 21);
            this.FileMenuItem.Text = "File";
            // 
            // AddFileMenuItem
            // 
            this.AddFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddWordFileMenuItem,
            this.AddExcelFileMenuItem,
            this.AddPowerPointFileMenuItem});
            this.AddFileMenuItem.Name = "AddFileMenuItem";
            this.AddFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddFileMenuItem.Text = "Add";
            // 
            // AddWordFileMenuItem
            // 
            this.AddWordFileMenuItem.Name = "AddWordFileMenuItem";
            this.AddWordFileMenuItem.Size = new System.Drawing.Size(201, 22);
            this.AddWordFileMenuItem.Text = "Microsoft Word";
            this.AddWordFileMenuItem.Click += new System.EventHandler(this.AddWordFileMenuItem_Click);
            // 
            // AddExcelFileMenuItem
            // 
            this.AddExcelFileMenuItem.Name = "AddExcelFileMenuItem";
            this.AddExcelFileMenuItem.Size = new System.Drawing.Size(201, 22);
            this.AddExcelFileMenuItem.Text = "Microsoft Excel";
            this.AddExcelFileMenuItem.Click += new System.EventHandler(this.AddExcelFileMenuItem_Click);
            // 
            // AddPowerPointFileMenuItem
            // 
            this.AddPowerPointFileMenuItem.Name = "AddPowerPointFileMenuItem";
            this.AddPowerPointFileMenuItem.Size = new System.Drawing.Size(201, 22);
            this.AddPowerPointFileMenuItem.Text = "Microsoft PowerPoint";
            this.AddPowerPointFileMenuItem.Click += new System.EventHandler(this.AddPowerPointFileMenuItem_Click);
            // 
            // ProjectsListBox
            // 
            this.ProjectsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectsListBox.FormattingEnabled = true;
            this.ProjectsListBox.ItemHeight = 20;
            this.ProjectsListBox.Location = new System.Drawing.Point(0, 28);
            this.ProjectsListBox.Name = "ProjectsListBox";
            this.ProjectsListBox.Size = new System.Drawing.Size(307, 544);
            this.ProjectsListBox.TabIndex = 3;
            this.ProjectsListBox.DoubleClick += new System.EventHandler(this.OpenProjectMenuItem_Click);
            // 
            // MainProjectFilesPanel
            // 
            this.MainProjectFilesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainProjectFilesPanel.AutoScroll = true;
            this.MainProjectFilesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainProjectFilesPanel.Location = new System.Drawing.Point(308, 28);
            this.MainProjectFilesPanel.Name = "MainProjectFilesPanel";
            this.MainProjectFilesPanel.Size = new System.Drawing.Size(816, 544);
            this.MainProjectFilesPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 575);
            this.Controls.Add(this.ProjectsListBox);
            this.Controls.Add(this.MainProjectFilesPanel);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "ProjectManager";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ProfileMenuItem;
        private System.Windows.Forms.ListBox ProjectsListBox;
        private System.Windows.Forms.FlowLayoutPanel MainProjectFilesPanel;
        private System.Windows.Forms.ToolStripMenuItem ProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddExcelFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPowerPointFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddWordFileMenuItem;
    }
}