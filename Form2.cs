using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Solvish
{
    public partial class signup_form : Form
    {
        WebClient wc = new WebClient(); //declaring the web cliant.
        static string folderdir = @"C:\solvish";
        public string studentpath = folderdir + @"\username.txt";
        public string quespath = folderdir + @"\questions.txt";
        public signup_form()
        {
            InitializeComponent();
            MessageBox.Show("If you are not connected to internet, Please connect to the " +
                "internet before creating account. Or the questions will not be downloaded");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            try
            {
                
                   //code for web cliant. Turn on after question file is uploaded

                if(File.Exists(quespath))
                {
                    //do nothing
                }
                else
                {
                    string url = "https://sakhawatadib.com/wp-content/uploads/2023/03/questions.txt";
                    string ok = quespath;
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(filedw);
                    Uri questions = new Uri(url);
                    wc.DownloadFileAsync(questions, ok);

                }
            }
            catch(Exception)
            {
                MessageBox.Show("You need to connect to internet to download the questions from server.");
            }

            if (tb_name.Text == null || tb_uname.Text == null || tb_pass.Text == null || tb_retype_pass.Text == null) 
            {
                MessageBox.Show("Please Fill out All boxes");
            }
            else
            {
                if(tb_pass.Text != tb_retype_pass.Text)
                {
                    MessageBox.Show("Passwords Do not Match");
                }
                else
                {
                    if(tb_pass.Text.Length <= 8)
                    {
                        MessageBox.Show("Passwords must be more than 7 characters");
                    }
                    else
                    {
                        bool flag = true;
                        foreach(student ss in Utility.studentsArray)
                        {
                            if(ss.username == tb_uname.Text)
                            {
                                MessageBox.Show("Passwords must be more than 7 characters");
                                flag = false;
                                break;
                            }
                        }
                        if(flag)
                        {
                            student s = new student(tb_name.Text, tb_uname.Text, tb_pass.Text);
                            StreamWriter sw = File.AppendText(studentpath);
                            sw.WriteLine($"{tb_name.Text},{tb_uname.Text},{tb_pass.Text}");
                            sw.Close();
                        }
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tb_pass.UseSystemPasswordChar)
            {
                tb_pass.UseSystemPasswordChar = false;
            }
            else
            {
                tb_pass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (tb_retype_pass.UseSystemPasswordChar)
            {
                tb_retype_pass.UseSystemPasswordChar = false;
            }
            else
            {
                tb_retype_pass.UseSystemPasswordChar = true;
            }
        }

        private void filedw(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Downloaded Questions. You are good to go now");
        }
    }
}
