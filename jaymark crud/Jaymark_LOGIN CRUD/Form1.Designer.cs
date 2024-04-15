namespace Jaymark_LOGIN_CRUD
{
    partial class Form1
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            chbShowPassword = new CheckBox();
            label4 = new Label();
            LinkSignUp = new LinkLabel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(200, 60);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(98, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 217);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 2;
            label2.Text = "Username ";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = SystemColors.InactiveCaptionText;
            txtUsername.Location = new Point(37, 250);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(270, 35);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 298);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(37, 336);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password ";
            txtPassword.Size = new Size(270, 34);
            txtPassword.TabIndex = 5;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.GradientActiveCaption;
            btnSignIn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = SystemColors.Highlight;
            btnSignIn.Location = new Point(37, 401);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(209, 43);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.Location = new Point(37, 376);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(111, 19);
            chbShowPassword.TabIndex = 7;
            chbShowPassword.Text = " Show password";
            chbShowPassword.UseVisualStyleBackColor = true;
            chbShowPassword.CheckedChanged += chbShowPassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(37, 459);
            label4.Name = "label4";
            label4.Size = new Size(175, 21);
            label4.TabIndex = 8;
            label4.Text = "don't have an account?";
            label4.Click += label4_Click;
            // 
            // LinkSignUp
            // 
            LinkSignUp.AutoSize = true;
            LinkSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkSignUp.Location = new Point(231, 459);
            LinkSignUp.Name = "LinkSignUp";
            LinkSignUp.Size = new Size(65, 21);
            LinkSignUp.TabIndex = 9;
            LinkSignUp.TabStop = true;
            LinkSignUp.Text = "Sign Up";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Brown;
            btnClose.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(55, 497);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(241, 55);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 664);
            Controls.Add(btnClose);
            Controls.Add(LinkSignUp);
            Controls.Add(label4);
            Controls.Add(chbShowPassword);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Button btnSignIn;
        private CheckBox chbShowPassword;
        private Label label4;
        private LinkLabel LinkSignUp;
        private Button btnClose;
    }
}
