namespace My_Journal
{
    partial class ProfileForm
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
            panel1 = new Panel();
            dataGridViewProfile = new DataGridView();
            viewEntries = new Button();
            SaveEntryButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            seeMyEntriesToolStripMenuItem = new ToolStripMenuItem();
            seeMyEntriesToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfile).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(dataGridViewProfile);
            panel1.Controls.Add(viewEntries);
            panel1.Controls.Add(SaveEntryButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 712);
            panel1.TabIndex = 4;
            // 
            // dataGridViewProfile
            // 
            dataGridViewProfile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProfile.Dock = DockStyle.Fill;
            dataGridViewProfile.Location = new Point(0, 200);
            dataGridViewProfile.Name = "dataGridViewProfile";
            dataGridViewProfile.RowHeadersWidth = 82;
            dataGridViewProfile.RowTemplate.Height = 41;
            dataGridViewProfile.Size = new Size(1184, 512);
            dataGridViewProfile.TabIndex = 5;
            // 
            // viewEntries
            // 
            viewEntries.BackColor = Color.IndianRed;
            viewEntries.Font = new Font("Sigmar One", 10.124999F, FontStyle.Regular, GraphicsUnit.Point);
            viewEntries.Location = new Point(751, 741);
            viewEntries.Name = "viewEntries";
            viewEntries.Size = new Size(284, 94);
            viewEntries.TabIndex = 12;
            viewEntries.Text = "View Entries";
            viewEntries.UseVisualStyleBackColor = false;
            // 
            // SaveEntryButton
            // 
            SaveEntryButton.BackColor = Color.DimGray;
            SaveEntryButton.Cursor = Cursors.Hand;
            SaveEntryButton.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            SaveEntryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            SaveEntryButton.FlatAppearance.MouseOverBackColor = Color.Red;
            SaveEntryButton.FlatStyle = FlatStyle.Flat;
            SaveEntryButton.Font = new Font("Sigmar One", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            SaveEntryButton.Location = new Point(393, 745);
            SaveEntryButton.Name = "SaveEntryButton";
            SaveEntryButton.Size = new Size(299, 96);
            SaveEntryButton.TabIndex = 2;
            SaveEntryButton.Text = "Save";
            SaveEntryButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 200);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(382, 38);
            label1.Name = "label1";
            label1.Size = new Size(427, 88);
            label1.TabIndex = 0;
            label1.Text = "My Profile";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { seeMyEntriesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 40);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // seeMyEntriesToolStripMenuItem
            // 
            seeMyEntriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seeMyEntriesToolStripMenuItem1, exitToolStripMenuItem });
            seeMyEntriesToolStripMenuItem.Name = "seeMyEntriesToolStripMenuItem";
            seeMyEntriesToolStripMenuItem.Size = new Size(97, 36);
            seeMyEntriesToolStripMenuItem.Text = "Menu";
            // 
            // seeMyEntriesToolStripMenuItem1
            // 
            seeMyEntriesToolStripMenuItem1.Name = "seeMyEntriesToolStripMenuItem1";
            seeMyEntriesToolStripMenuItem1.Size = new Size(359, 44);
            seeMyEntriesToolStripMenuItem1.Text = "See My Entries";
            seeMyEntriesToolStripMenuItem1.Click += seeMyEntriesToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(359, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 752);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfile).EndInit();
            panel2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewProfile;
        private Button viewEntries;
        private Button SaveEntryButton;
        private Panel panel2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem seeMyEntriesToolStripMenuItem;
        private ToolStripMenuItem seeMyEntriesToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}