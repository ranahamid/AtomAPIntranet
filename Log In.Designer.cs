namespace Atom_Attendence
{
    partial class Log_In
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
            this.Send_button1 = new System.Windows.Forms.Button();
            this.textBox1_password = new System.Windows.Forms.TextBox();
            this.label4_password = new System.Windows.Forms.Label();
            this.textBox2_username = new System.Windows.Forms.TextBox();
            this.label2_username = new System.Windows.Forms.Label();
            this.webKitBrowser1 = new WebKit.WebKitBrowser();
            this.SuspendLayout();
            // 
            // Send_button1
            // 
            this.Send_button1.Location = new System.Drawing.Point(532, 152);
            this.Send_button1.Name = "Send_button1";
            this.Send_button1.Size = new System.Drawing.Size(120, 36);
            this.Send_button1.TabIndex = 29;
            this.Send_button1.Text = "Log In";
            this.Send_button1.UseVisualStyleBackColor = true;
            this.Send_button1.Click += new System.EventHandler(this.Send_button1_Click);
            // 
            // textBox1_password
            // 
            this.textBox1_password.Location = new System.Drawing.Point(217, 89);
            this.textBox1_password.Name = "textBox1_password";
            this.textBox1_password.Size = new System.Drawing.Size(435, 20);
            this.textBox1_password.TabIndex = 28;
            this.textBox1_password.UseSystemPasswordChar = true;
            this.textBox1_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_username_KeyDown);
            // 
            // label4_password
            // 
            this.label4_password.AutoSize = true;
            this.label4_password.Location = new System.Drawing.Point(32, 92);
            this.label4_password.Name = "label4_password";
            this.label4_password.Size = new System.Drawing.Size(53, 13);
            this.label4_password.TabIndex = 27;
            this.label4_password.Text = "Password";
            // 
            // textBox2_username
            // 
            this.textBox2_username.Location = new System.Drawing.Point(217, 47);
            this.textBox2_username.Name = "textBox2_username";
            this.textBox2_username.Size = new System.Drawing.Size(435, 20);
            this.textBox2_username.TabIndex = 26;
            this.textBox2_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_username_KeyDown);
            // 
            // label2_username
            // 
            this.label2_username.AutoSize = true;
            this.label2_username.Location = new System.Drawing.Point(32, 50);
            this.label2_username.Name = "label2_username";
            this.label2_username.Size = new System.Drawing.Size(60, 13);
            this.label2_username.TabIndex = 25;
            this.label2_username.Text = "User Name";
            // 
            // webKitBrowser1
            // 
            this.webKitBrowser1.BackColor = System.Drawing.Color.White;
            this.webKitBrowser1.Location = new System.Drawing.Point(665, 280);
            this.webKitBrowser1.Name = "webKitBrowser1";
            this.webKitBrowser1.Size = new System.Drawing.Size(10, 10);
            this.webKitBrowser1.TabIndex = 30;
            this.webKitBrowser1.Url = null;
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 296);
            this.Controls.Add(this.webKitBrowser1);
            this.Controls.Add(this.Send_button1);
            this.Controls.Add(this.textBox1_password);
            this.Controls.Add(this.label4_password);
            this.Controls.Add(this.textBox2_username);
            this.Controls.Add(this.label2_username);
            this.Name = "Log_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_button1;
        private System.Windows.Forms.TextBox textBox1_password;
        private System.Windows.Forms.Label label4_password;
        private System.Windows.Forms.TextBox textBox2_username;
        private System.Windows.Forms.Label label2_username;
        private WebKit.WebKitBrowser webKitBrowser1;
    
    }
}