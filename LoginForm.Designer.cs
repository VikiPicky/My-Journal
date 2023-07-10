namespace My_Journal
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            registerLabel = new Label();
            RegisterButton = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            emailField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(592, 45);
            button1.Name = "button1";
            button1.Size = new Size(182, 56);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(emailField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 786);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.BackColor = Color.LightCoral;
            registerLabel.Cursor = Cursors.Hand;
            registerLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            registerLabel.Location = new Point(296, 675);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(222, 37);
            registerLabel.TabIndex = 2;
            registerLabel.Text = "No account yet?";
            registerLabel.Click += registerLabel_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.DimGray;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            RegisterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            RegisterButton.FlatAppearance.MouseOverBackColor = Color.Red;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Sigmar One", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterButton.Location = new Point(262, 532);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(319, 96);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Login";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += LoginButton_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Sigmar One", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(192, 386);
            passField.Name = "passField";
            passField.Size = new Size(712, 68);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(62, 386);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // emailField
            // 
            emailField.Font = new Font("Sigmar One", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            emailField.Location = new Point(192, 267);
            emailField.Multiline = true;
            emailField.Name = "emailField";
            emailField.Size = new Size(712, 91);
            emailField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(62, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 200);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BackColor = Color.FromArgb(255, 192, 255);
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = SystemColors.ActiveCaptionText;
            closeButton.Location = new Point(1109, 9);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(298, 32);
            label1.Name = "label1";
            label1.Size = new Size(243, 88);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1180, 786);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label closeButton;
        private PictureBox pictureBox1;
        private TextBox emailField;
        private TextBox passField;
        private PictureBox pictureBox2;
        private Button RegisterButton;
        private Label registerLabel;
    }
}