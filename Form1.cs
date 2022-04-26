using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Microsoft.Win32;

namespace Atom_Attendence
{
    public partial class Form1 : Form
    {
        

        private readonly string App_Name = "Atom Attendence";

        //create Registry key to launch this app in the startup 

        private readonly RegistryKey rkApp =
            Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);


        public Form1()
        {
            
            InitializeComponent();
            //Check the startup 
            rkApp.SetValue(App_Name, Application.ExecutablePath);

            


            string username = Properties.Settings.Default.UserName2;
            if (username == string.Empty)
            {
                var login = new Log_In();
                //Show the about window
                login.Show();
            }

        }

        





        //Exit MenuItem
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        //about MenuItem
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox1();
            //Show the about window
            about.Show();
        }



        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {

            //log
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();

            int userCount = Properties.Settings.Default.UserCount++;
            Properties.Settings.Default.Save();

      
            VariableClass.file.WriteLine("Close App: " + time + " " + date);
            VariableClass.file.WriteLine("Username: " + Properties.Settings.Default.UserName2);
            VariableClass.file.WriteLine("-------------------");
            VariableClass.file.Flush();
            //end of log
        }


        private void Form1_Load(object sender, EventArgs e)
        {

          
        }

        private void HitLink()
        {
            string pass = Properties.Settings.Default.PassWord2;
            string username = Properties.Settings.Default.UserName2;


       //     MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);


            string link = "http://atomsystemro.atomapgroup.com/windowsservice.php?uid=" + username + "&pas=" + pass;
            webKitBrowser1.Navigate(link);
            //log
            string date3 = DateTime.Now.ToLongDateString();
            string time3 = DateTime.Now.ToLongTimeString();

            VariableClass.file.WriteLine("Hit Link: " + time3 + " " + date3);
            VariableClass.file.WriteLine("Username: " + username);
            VariableClass.file.WriteLine("-------------------");
            VariableClass.file.Flush();
            string msg = "Your attendence is added.";
            MessageBox.Show(msg, "Success");

/*

       //Run batch

            string link = "http://atomsystemro.atomapgroup.com/windowsservice.php?uid=" + username + "&pas=" + pass;
            string batDir = string.Format(AppDomain.CurrentDomain.BaseDirectory);
            string ExecutableFilePath = @batDir + "callurl.cmd";
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
                string date1 = DateTime.Now.ToLongDateString();
                string time1 = DateTime.Now.ToLongTimeString();

                VariableClass.file.WriteLine("Hit Link: " + time1 + " " + date1);
                VariableClass.file.WriteLine("Username: " + username);
                VariableClass.file.WriteLine("-------------------");
                VariableClass.file.Flush();

                //end of log
                string msg = "Your attendence is added.";
                MessageBox.Show(msg, "Success");

            }
            else
            {

                //   MessageBox.Show("Can't find the Batch file, path= "+ ExecutableFilePath);
                MessageBox.Show("Can't find the Batch file.");

                //log
                string date2 = DateTime.Now.ToLongDateString();
                string time2 = DateTime.Now.ToLongTimeString();

                VariableClass.file.WriteLine("Batch not found: " + time2 + " " + date2);
                VariableClass.file.WriteLine("Username: " + username);
                VariableClass.file.WriteLine("-------------------");
                VariableClass.file.Flush();

                //end of log
            }
            //end of batch

*/

         
        }


        private void HitLink_checkOut()
        {
            var pass = Properties.Settings.Default.PassWord2;
            var username = Properties.Settings.Default.UserName2;
        //    string link = "http://atomsystemro.atomapgroup.com/windowsservice.php?uid=" + username + "&pas=" + pass;

      

            string link = "http://atomsystemro.atomapgroup.com/windowsservice.php?uid=" + username + "&pas=" + pass;
         //   link = "http://google.com";
            webKitBrowser1.Navigate(link);
            //log
            string date3 = DateTime.Now.ToLongDateString();
            string time3 = DateTime.Now.ToLongTimeString();

            VariableClass.file.WriteLine("CheckOut : " + time3 + " " + date3);
            VariableClass.file.WriteLine("Username: " + username);
            VariableClass.file.WriteLine("-------------------");
            VariableClass.file.Flush();

            //end of log
            string msg = "Your checkOut attendence is added.";
            MessageBox.Show(msg, "Success");
/*

            //Run batch
            string batDir = string.Format(AppDomain.CurrentDomain.BaseDirectory);
            string ExecutableFilePath = @batDir + "callurl.cmd";
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
                string date3 = DateTime.Now.ToLongDateString();
                string time3 = DateTime.Now.ToLongTimeString();

                VariableClass.file.WriteLine("Hit Link: " + time3 + " " + date3);
                VariableClass.file.WriteLine("Username: " + username);
                VariableClass.file.WriteLine("-------------------");
                VariableClass.file.Flush();

                //end of log
                string msg = "Your checkOut attendence is added.";
                MessageBox.Show(msg, "Success");

            }
            else
            {

                //   MessageBox.Show("Can't find the Batch file, path= "+ ExecutableFilePath);
                MessageBox.Show("Can't find the Batch file.");

                //log
                string date4 = DateTime.Now.ToLongDateString();
                string time4 = DateTime.Now.ToLongTimeString();

                VariableClass.file.WriteLine("Batch not found: " + time4 + " " + date4);
                VariableClass.file.WriteLine("Username: " + username);
                VariableClass.file.WriteLine("-------------------");
                VariableClass.file.Flush();

                //end of log
            }
            //end of batch
*/


     


           
        }



       

        private void button1_login_Click(object sender, EventArgs e)
        {
            //change User

            if (Properties.Settings.Default.UserName2 == string.Empty)
            {

                var login = new Log_In();
                //Show the about window
                login.Show();
            }
            else
            {
                DialogResult result=MessageBox.Show("You are logged in. Do You really want to change user?", "Change User",MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //log
                    string date = DateTime.Now.ToLongDateString();
                    string time = DateTime.Now.ToLongTimeString();

                    VariableClass.file.WriteLine("Logout Successfully: " + time + " " + date);
                    VariableClass.file.WriteLine("Username: " + Properties.Settings.Default.UserName2);
                    VariableClass.file.WriteLine("-------------------");
                    VariableClass.file.Flush();

                    //end of log

                    Properties.Settings.Default.UserName2 = string.Empty;
                    Properties.Settings.Default.PassWord2 = string.Empty;
                    Properties.Settings.Default.Save();



                    //  string msg = "Remove username and password";
                    // MessageBox.Show(msg);
                    var login = new Log_In();
                    login.Show();
                }
                  
            }
        }

        private void ChekHit()
        {
            string pass = Properties.Settings.Default.PassWord2;
            string username = Properties.Settings.Default.UserName2;

            if ((username != string.Empty) && (pass != string.Empty))
            {
                // MessageBox.Show("username: " + username + "pass: " + pass);
                HitLink();
            }
        }


 



        private void Form1_Shown(object sender, EventArgs e)
        {
            ChekHit();
        }

        private void button1_checkOut_Click(object sender, EventArgs e)
        {
            string pass = Properties.Settings.Default.PassWord2;
            string username = Properties.Settings.Default.UserName2;

            if ((username == string.Empty) || (pass == string.Empty))
            {
                string msg = "You are not logged in.";
                MessageBox.Show(msg, "Error");
            }
            else
            {
                HitLink_checkOut();
            }

  
        }

   

    }
}
