using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atom_Attendence
{
    public partial class Log_In : Form
    {
        
      
        
        
        public Log_In()
        {
            InitializeComponent();
        }



        private void Send_button1_Click(object sender, EventArgs e)
        {
            string username = textBox2_username.Text;
            string password = textBox1_password.Text;

            if( (username != string.Empty) && (password != string.Empty))
            {
                Properties.Settings.Default.UserName2 = textBox2_username.Text;
                Properties.Settings.Default.PassWord2 = textBox1_password.Text;
                Properties.Settings.Default.Save();

                HitLink();

                this.Close();



   

                //log
                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();

                int userCount = Properties.Settings.Default.UserCount++;
                Properties.Settings.Default.Save();

                VariableClass.file.WriteLine("User Count :" + userCount);
                VariableClass.file.WriteLine("User login success: " + time + " " + date);
                VariableClass.file.WriteLine("Username: " + Properties.Settings.Default.UserName2);
                VariableClass.file.WriteLine("-------------------");
                VariableClass.file.Flush();
                //end of log
              



            }
            else
            {
                //log
                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();
                VariableClass.file.WriteLine("User login failed: " + time + " " + date);
                if (Properties.Settings.Default.UserName2 != string.Empty)
                {
                    VariableClass.file.WriteLine("Try with Username: " + Properties.Settings.Default.UserName2);
                }
            
                else
                {
                    VariableClass.file.WriteLine("Username: Not a username supplied." ); 
                }
               
              
                //end of log
                string msg = "User can't logged in.";
                VariableClass.file.WriteLine(msg);
                VariableClass.file.WriteLine("-------------------");
                VariableClass.file.Flush();
                MessageBox.Show(msg,"Error in Login");

            }
        }



        private void HitLink()
        {
            string pass = Properties.Settings.Default.PassWord2;
            string username = Properties.Settings.Default.UserName2;
  



            string link = "http://atomsystemro.atomapgroup.com/windowsservice.php?uid=" + username + "&pas=" + pass;
            webKitBrowser1.Navigate(link);
          
            //log
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();

            VariableClass.file.WriteLine("Logged in: " + time + " " + date);
            VariableClass.file.WriteLine("Username: " + username);
            VariableClass.file.WriteLine("-------------------");
            VariableClass.file.Flush();

            //end of log
            string msg = "Logged in successfully \nYour attendence is added with the specified username and password.";
            MessageBox.Show(msg, "Success");



         /*   //Run the batch file
            string batDir = string.Format(AppDomain.CurrentDomain.BaseDirectory);
            string ExecutableFilePath = @batDir+"callurl.cmd";
            string Arguments = @link;

            if (File.Exists(ExecutableFilePath))
            {
                ProcessStartInfo psi = new ProcessStartInfo(ExecutableFilePath, Arguments);
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                Process.Start(psi);
           //     MessageBox.Show("path= " + ExecutableFilePath+"\nlink"+Arguments);

                //         webControl1.WebView.Url = link;
                //log
                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();

                VariableClass.file.WriteLine("Hit Link: " + time + " " + date);
                VariableClass.file.WriteLine("Username: " + username);
                VariableClass.file.WriteLine("-------------------");
                VariableClass.file.Flush();

                //end of log
                string msg = "Logged in successfully \nYour attendence is added with the specified username and password.";
                MessageBox.Show(msg, "Success");

            }
            else
            {
               
            //   MessageBox.Show("Can't find the Batch file, path= "+ ExecutableFilePath);
                 MessageBox.Show("Can't find the Batch file.");

                 //log
                 string date = DateTime.Now.ToLongDateString();
                 string time = DateTime.Now.ToLongTimeString();

                 VariableClass.file.WriteLine("Batch not found: " + time + " " + date);
                 VariableClass.file.WriteLine("Username: " + username);
                 VariableClass.file.WriteLine("-------------------");
                 VariableClass.file.Flush();

                //end of log
            }
            //end of batch
*/

   
        }

       

        private void textBox2_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send_button1_Click(sender, e);
            }
        }

    }
}
