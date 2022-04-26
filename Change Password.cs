using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atom_Attendence
{
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void button1_changePass_Click(object sender, EventArgs e)
        {
            string olderPass = textBox1_OlderPassword.Text;
            string newPass = textBox1_NewPassword.Text;
            string existPass = Properties.Settings.Default.PassWord2;
            if (olderPass.Equals(existPass))
            {
                Properties.Settings.Default.PassWord2 = newPass;
                Properties.Settings.Default.Save();
                //log
                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();

                VariableClass.file.WriteLine("Password changed: " + time + " " + date);
                VariableClass.file.WriteLine("Username: " +Properties.Settings.Default.UserName2);
                VariableClass.file.Flush();
                VariableClass.file.WriteLine("-------------------");
                //end of log


                this.Close();
                string msg = "Your Password changed.";
                MessageBox.Show(msg);

            }
            else
            {
                string msg = "Your Password isn't matched.";

                //log
                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();
                VariableClass.file.WriteLine("Try to change Password: " + time + " " + date);
                VariableClass.file.WriteLine("Username: " + Properties.Settings.Default.UserName2);
                VariableClass.file.Flush();
                VariableClass.file.WriteLine("-------------------");
                //end of log

                MessageBox.Show(msg);
            }
        }
    }
}
