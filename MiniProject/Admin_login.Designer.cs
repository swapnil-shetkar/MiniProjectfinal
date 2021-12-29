namespace MiniProject
{
    partial class Admin_login
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
            this.Admin_user = new System.Windows.Forms.TextBox();
            this.Admin_pass = new System.Windows.Forms.TextBox();
            this.Login_ID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Admin_user
            // 
            this.Admin_user.Location = new System.Drawing.Point(283, 110);
            this.Admin_user.Name = "Admin_user";
            this.Admin_user.Size = new System.Drawing.Size(150, 22);
            this.Admin_user.TabIndex = 0;
            this.Admin_user.TextChanged += new System.EventHandler(this.Admin_ID);
            // 
            // Admin_pass
            // 
            this.Admin_pass.Location = new System.Drawing.Point(283, 150);
            this.Admin_pass.MaxLength = 4;
            this.Admin_pass.Name = "Admin_pass";
            this.Admin_pass.PasswordChar = '*';
            this.Admin_pass.Size = new System.Drawing.Size(150, 22);
            this.Admin_pass.TabIndex = 1;
            this.Admin_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Admin_pass.TextChanged += new System.EventHandler(this.Admin_PASS);
            // 
            // Login_ID
            // 
            this.Login_ID.AutoSize = true;
            this.Login_ID.Location = new System.Drawing.Point(193, 116);
            this.Login_ID.Name = "Login_ID";
            this.Login_ID.Size = new System.Drawing.Size(56, 16);
            this.Login_ID.TabIndex = 2;
            this.Login_ID.Text = "Login ID";
            this.Login_ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(193, 155);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Admin_login_button);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin Login";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Admin_goback_button);
            // 
            // Admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login_ID);
            this.Controls.Add(this.Admin_pass);
            this.Controls.Add(this.Admin_user);
            this.Name = "Admin_login";
            this.Text = "Admin_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Admin_user;
        private System.Windows.Forms.TextBox Admin_pass;
        private System.Windows.Forms.Label Login_ID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}