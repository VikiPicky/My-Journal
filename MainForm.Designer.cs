namespace My_Journal
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
            label1 = new Label();
            panel2 = new Panel();
            closeButton = new Label();
            recordField = new TextBox();
            SaveEntryButton = new Button();
            panel1 = new Panel();
            viewEntries = new Button();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(277, 42);
            label1.Name = "label1";
            label1.Size = new Size(622, 88);
            label1.TabIndex = 0;
            label1.Text = "Record Keeping";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1092, 200);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BackColor = Color.FromArgb(255, 192, 255);
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.ActiveCaptionText;
            closeButton.Location = new Point(1050, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // recordField
            // 
            recordField.Font = new Font("Sigmar One", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            recordField.Location = new Point(179, 276);
            recordField.Multiline = true;
            recordField.Name = "recordField";
            recordField.Size = new Size(750, 91);
            recordField.TabIndex = 6;
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
            SaveEntryButton.Click += SaveEntryButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(viewEntries);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(recordField);
            panel1.Controls.Add(SaveEntryButton);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 969);
            panel1.TabIndex = 3;
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
            viewEntries.Click += viewEntries_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sigmar One", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(179, 397);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(750, 91);
            textBox1.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.date;
            pictureBox3.Location = new Point(49, 383);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.text;
            pictureBox1.Location = new Point(49, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 969);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label closeButton;
        private TextBox dateField;
        private TextBox recordField;
        private Button SaveEntryButton;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button viewEntries;
    }
}