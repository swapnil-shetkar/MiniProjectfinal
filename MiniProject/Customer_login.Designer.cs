namespace MiniProject
{
    partial class Customer_login
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
            this.Login = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Cust_pass = new System.Windows.Forms.TextBox();
            this.Cust_login = new System.Windows.Forms.TextBox();
            this.Login_ID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Customer_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(283, 202);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(70, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(363, 202);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(70, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Cust_pass
            // 
            this.Cust_pass.Location = new System.Drawing.Point(283, 150);
            this.Cust_pass.MaxLength = 4;
            this.Cust_pass.Name = "Cust_pass";
            this.Cust_pass.PasswordChar = '*';
            this.Cust_pass.Size = new System.Drawing.Size(150, 22);
            this.Cust_pass.TabIndex = 2;
            this.Cust_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cust_login
            // 
            this.Cust_login.Location = new System.Drawing.Point(283, 110);
            this.Cust_login.Name = "Cust_login";
            this.Cust_login.Size = new System.Drawing.Size(150, 22);
            this.Cust_login.TabIndex = 3;
            // 
            // Login_ID
            // 
            this.Login_ID.AutoSize = true;
            this.Login_ID.Location = new System.Drawing.Point(182, 115);
            this.Login_ID.Name = "Login_ID";
            this.Login_ID.Size = new System.Drawing.Size(56, 16);
            this.Login_ID.TabIndex = 4;
            this.Login_ID.Text = "Login ID";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(185, 155);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // Customer_lable
            // 
            this.Customer_lable.AutoSize = true;
            this.Customer_lable.Location = new System.Drawing.Point(312, 29);
            this.Customer_lable.Name = "Customer_lable";
            this.Customer_lable.Size = new System.Drawing.Size(100, 16);
            this.Customer_lable.TabIndex = 6;
            this.Customer_lable.Text = "Customer Login";
            this.Customer_lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // Customer_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Customer_lable);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login_ID);
            this.Controls.Add(this.Cust_login);
            this.Controls.Add(this.Cust_pass);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Login);
            this.Name = "Customer_login";
            this.Text = "Customer_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox Cust_pass;
        private System.Windows.Forms.TextBox Cust_login;
        private System.Windows.Forms.Label Login_ID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Customer_lable;
    }
}