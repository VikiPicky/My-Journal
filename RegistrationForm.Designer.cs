namespace My_Journal
{
    partial class RegistrationForm
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
            closeButton = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            emailField = new TextBox();
            ProgramField = new TextBox();
            nameField = new TextBox();
            RegistrationButton = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            BackToLoginLabel = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BackColor = Color.FromArgb(255, 192, 255);
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.ActiveCaptionText;
            closeButton.Location = new Point(777, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click_1;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(151, 25);
            label1.Name = "label1";
            label1.Size = new Size(541, 88);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 200);
            panel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(BackToLoginLabel);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(emailField);
            panel1.Controls.Add(ProgramField);
            panel1.Controls.Add(nameField);
            panel1.Controls.Add(RegistrationButton);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 973);
            panel1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.program;
            pictureBox4.Location = new Point(49, 383);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 91);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.email;
            pictureBox3.Location = new Point(49, 503);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.name;
            pictureBox1.Location = new Point(49, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // emailField
            // 
            emailField.Font = new Font("Sigmar One", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            emailField.Location = new Point(179, 493);
            emailField.Multiline = true;
            emailField.Name = "emailField";
            emailField.Size = new Size(474, 91);
            emailField.TabIndex = 8;
            emailField.Enter += emailField_Enter;
            emailField.Leave += emailField_Leave;
            // 
            // ProgramField
            // 
            ProgramField.Font = new Font("Sigmar One", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            ProgramField.Location = new Point(179, 383);
            ProgramField.Multiline = true;
            ProgramField.Name = "ProgramField";
            ProgramField.Size = new Size(474, 91);
            ProgramField.TabIndex = 2;
            ProgramField.Enter += ProgramField_Enter;
            ProgramField.Leave += ProgramField_Leave;
            // 
            // nameField
            // 
            nameField.Font = new Font("Sigmar One", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            nameField.Location = new Point(179, 276);
            nameField.Multiline = true;
            nameField.Name = "nameField";
            nameField.Size = new Size(474, 91);
            nameField.TabIndex = 6;
            nameField.Enter += nameField_Enter;
            nameField.Leave += nameField_Leave;
            // 
            // RegistrationButton
            // 
            RegistrationButton.BackColor = Color.DimGray;
            RegistrationButton.Cursor = Cursors.Hand;
            RegistrationButton.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            RegistrationButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            RegistrationButton.FlatAppearance.MouseOverBackColor = Color.Red;
            RegistrationButton.FlatStyle = FlatStyle.Flat;
            RegistrationButton.Font = new Font("Sigmar One", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationButton.Location = new Point(274, 781);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(299, 96);
            RegistrationButton.TabIndex = 2;
            RegistrationButton.Text = "Register";
            RegistrationButton.UseVisualStyleBackColor = false;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Sigmar One", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(179, 628);
            passField.Name = "passField";
            passField.Size = new Size(474, 68);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(49, 628);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // BackToLoginLabel
            // 
            BackToLoginLabel.AutoSize = true;
            BackToLoginLabel.BackColor = Color.IndianRed;
            BackToLoginLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackToLoginLabel.Location = new Point(321, 898);
            BackToLoginLabel.Name = "BackToLoginLabel";
            BackToLoginLabel.Size = new Size(180, 32);
            BackToLoginLabel.TabIndex = 3;
            BackToLoginLabel.Text = "Back to Login?";
            BackToLoginLabel.Click += BackToLoginLabel_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 973);
            Controls.Add(panel1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            MouseDown += RegistrationForm_MouseDown;
            MouseMove += RegistrationForm_MouseMove;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label closeButton;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button RegistrationButton;
        private TextBox passField;
        private PictureBox pictureBox2;
        private TextBox ProgramField;
        private TextBox emailField;
        private TextBox nameField;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label BackToLoginLabel;
    }
}