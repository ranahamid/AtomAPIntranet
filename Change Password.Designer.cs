namespace Atom_Attendence
{
    partial class Change_Password
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
            this.button1_changePass = new System.Windows.Forms.Button();
            this.textBox1_OlderPassword = new System.Windows.Forms.TextBox();
            this.label4_password = new System.Windows.Forms.Label();
            this.textBox1_NewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_changePass
            // 
            this.button1_changePass.Location = new System.Drawing.Point(517, 152);
            this.button1_changePass.Name = "button1_changePass";
            this.button1_changePass.Size = new System.Drawing.Size(120, 36);
            this.button1_changePass.TabIndex = 34;
            this.button1_changePass.Text = "Change";
            this.button1_changePass.UseVisualStyleBackColor = true;
            this.button1_changePass.Click += new System.EventHandler(this.button1_changePass_Click);
            // 
            // textBox1_OlderPassword
            // 
            this.textBox1_OlderPassword.Location = new System.Drawing.Point(202, 47);
            this.textBox1_OlderPassword.Name = "textBox1_OlderPassword";
            this.textBox1_OlderPassword.Size = new System.Drawing.Size(435, 20);
            this.textBox1_OlderPassword.TabIndex = 33;
            this.textBox1_OlderPassword.UseSystemPasswordChar = true;
            // 
            // label4_password
            // 
            this.label4_password.AutoSize = true;
            this.label4_password.Location = new System.Drawing.Point(17, 50);
            this.label4_password.Name = "label4_password";
            this.label4_password.Size = new System.Drawing.Size(81, 13);
            this.label4_password.TabIndex = 32;
            this.label4_password.Text = "Older Password";
            // 
            // textBox1_NewPassword
            // 
            this.textBox1_NewPassword.Location = new System.Drawing.Point(202, 99);
            this.textBox1_NewPassword.Name = "textBox1_NewPassword";
            this.textBox1_NewPassword.Size = new System.Drawing.Size(435, 20);
            this.textBox1_NewPassword.TabIndex = 36;
            this.textBox1_NewPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "New Password";
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 296);
            this.Controls.Add(this.textBox1_NewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_changePass);
            this.Controls.Add(this.textBox1_OlderPassword);
            this.Controls.Add(this.label4_password);
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_changePass;
        private System.Windows.Forms.TextBox textBox1_OlderPassword;
        private System.Windows.Forms.Label label4_password;
        private System.Windows.Forms.TextBox textBox1_NewPassword;
        private System.Windows.Forms.Label label1;
    }
}