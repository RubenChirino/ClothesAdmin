namespace ClothesAdmin
{
    partial class AuthenticationForm
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
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.mainIconLogIn = new System.Windows.Forms.PictureBox();
            this.mainTitleLogIn = new System.Windows.Forms.Label();
            this.iconUserLogIn = new System.Windows.Forms.PictureBox();
            this.usernameTextBoxLogIn = new System.Windows.Forms.TextBox();
            this.lineUsernameTextBoxLogIn = new System.Windows.Forms.Panel();
            this.iconCheckLockerLogIn = new System.Windows.Forms.PictureBox();
            this.passwordTextBoxLogIn = new System.Windows.Forms.TextBox();
            this.linePasswordTextBoxLogIn = new System.Windows.Forms.Panel();
            this.logInButton = new System.Windows.Forms.Button();
            this.panelLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainIconLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCheckLockerLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.mainIconLogIn);
            this.panelLogIn.Controls.Add(this.mainTitleLogIn);
            this.panelLogIn.Controls.Add(this.iconUserLogIn);
            this.panelLogIn.Controls.Add(this.usernameTextBoxLogIn);
            this.panelLogIn.Controls.Add(this.lineUsernameTextBoxLogIn);
            this.panelLogIn.Controls.Add(this.iconCheckLockerLogIn);
            this.panelLogIn.Controls.Add(this.passwordTextBoxLogIn);
            this.panelLogIn.Controls.Add(this.linePasswordTextBoxLogIn);
            this.panelLogIn.Controls.Add(this.logInButton);
            this.panelLogIn.Location = new System.Drawing.Point(270, 27);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(261, 396);
            this.panelLogIn.TabIndex = 12;
            this.panelLogIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogIn_Paint);
            // 
            // mainIconLogIn
            // 
            this.mainIconLogIn.Image = global::ClothesAdmin.Properties.Resources.fashion_icon_50px;
            this.mainIconLogIn.Location = new System.Drawing.Point(104, 70);
            this.mainIconLogIn.Name = "mainIconLogIn";
            this.mainIconLogIn.Size = new System.Drawing.Size(50, 50);
            this.mainIconLogIn.TabIndex = 10;
            this.mainIconLogIn.TabStop = false;
            this.mainIconLogIn.Click += new System.EventHandler(this.mainIconLogIn_Click);
            // 
            // mainTitleLogIn
            // 
            this.mainTitleLogIn.AutoSize = true;
            this.mainTitleLogIn.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLogIn.Location = new System.Drawing.Point(18, 123);
            this.mainTitleLogIn.Name = "mainTitleLogIn";
            this.mainTitleLogIn.Size = new System.Drawing.Size(223, 36);
            this.mainTitleLogIn.TabIndex = 9;
            this.mainTitleLogIn.Text = "Fashion Forward";
            this.mainTitleLogIn.Click += new System.EventHandler(this.mainTitleLogIn_Click);
            // 
            // iconUserLogIn
            // 
            this.iconUserLogIn.Image = global::ClothesAdmin.Properties.Resources.user_icon_black_30px;
            this.iconUserLogIn.Location = new System.Drawing.Point(17, 188);
            this.iconUserLogIn.Name = "iconUserLogIn";
            this.iconUserLogIn.Size = new System.Drawing.Size(30, 30);
            this.iconUserLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconUserLogIn.TabIndex = 4;
            this.iconUserLogIn.TabStop = false;
            // 
            // usernameTextBoxLogIn
            // 
            this.usernameTextBoxLogIn.BackColor = System.Drawing.Color.White;
            this.usernameTextBoxLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBoxLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usernameTextBoxLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBoxLogIn.ForeColor = System.Drawing.Color.Black;
            this.usernameTextBoxLogIn.Location = new System.Drawing.Point(53, 188);
            this.usernameTextBoxLogIn.Name = "usernameTextBoxLogIn";
            this.usernameTextBoxLogIn.Size = new System.Drawing.Size(194, 28);
            this.usernameTextBoxLogIn.TabIndex = 0;
            this.usernameTextBoxLogIn.Text = "Username";
            // 
            // lineUsernameTextBoxLogIn
            // 
            this.lineUsernameTextBoxLogIn.BackColor = System.Drawing.Color.Black;
            this.lineUsernameTextBoxLogIn.Location = new System.Drawing.Point(17, 221);
            this.lineUsernameTextBoxLogIn.Name = "lineUsernameTextBoxLogIn";
            this.lineUsernameTextBoxLogIn.Size = new System.Drawing.Size(233, 1);
            this.lineUsernameTextBoxLogIn.TabIndex = 5;
            // 
            // iconCheckLockerLogIn
            // 
            this.iconCheckLockerLogIn.Image = global::ClothesAdmin.Properties.Resources.check_lock_icon_30px;
            this.iconCheckLockerLogIn.Location = new System.Drawing.Point(17, 246);
            this.iconCheckLockerLogIn.Name = "iconCheckLockerLogIn";
            this.iconCheckLockerLogIn.Size = new System.Drawing.Size(30, 30);
            this.iconCheckLockerLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCheckLockerLogIn.TabIndex = 6;
            this.iconCheckLockerLogIn.TabStop = false;
            // 
            // passwordTextBoxLogIn
            // 
            this.passwordTextBoxLogIn.BackColor = System.Drawing.Color.White;
            this.passwordTextBoxLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBoxLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordTextBoxLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBoxLogIn.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBoxLogIn.Location = new System.Drawing.Point(53, 246);
            this.passwordTextBoxLogIn.Name = "passwordTextBoxLogIn";
            this.passwordTextBoxLogIn.Size = new System.Drawing.Size(194, 28);
            this.passwordTextBoxLogIn.TabIndex = 2;
            this.passwordTextBoxLogIn.Text = "Password";
            this.passwordTextBoxLogIn.UseSystemPasswordChar = true;
            // 
            // linePasswordTextBoxLogIn
            // 
            this.linePasswordTextBoxLogIn.BackColor = System.Drawing.Color.Black;
            this.linePasswordTextBoxLogIn.Location = new System.Drawing.Point(17, 279);
            this.linePasswordTextBoxLogIn.Name = "linePasswordTextBoxLogIn";
            this.linePasswordTextBoxLogIn.Size = new System.Drawing.Size(233, 1);
            this.linePasswordTextBoxLogIn.TabIndex = 8;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.Black;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.FlatAppearance.BorderSize = 0;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.White;
            this.logInButton.Location = new System.Drawing.Point(63, 311);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(134, 38);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "LOG IN";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogIn);
            this.Name = "AuthenticationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainIconLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCheckLockerLogIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.PictureBox mainIconLogIn;
        private System.Windows.Forms.Label mainTitleLogIn;
        private System.Windows.Forms.PictureBox iconUserLogIn;
        private System.Windows.Forms.TextBox usernameTextBoxLogIn;
        private System.Windows.Forms.Panel lineUsernameTextBoxLogIn;
        private System.Windows.Forms.PictureBox iconCheckLockerLogIn;
        private System.Windows.Forms.TextBox passwordTextBoxLogIn;
        private System.Windows.Forms.Panel linePasswordTextBoxLogIn;
        private System.Windows.Forms.Button logInButton;
    }
}

